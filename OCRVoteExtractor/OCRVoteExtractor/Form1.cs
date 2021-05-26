using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;
using GdPicture10;
using Emgu.CV;
using OCRVoteExtractor.clases;
using System.Xml;
using System.IO;

namespace OCRVoteExtractor
{
    public partial class Form1 : Form
    {
        List<Papeleta> Papeletas;
        Papeleta papeleta;
        String ruta_papeletas = "C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\papeletas";
        int xT, yT;
        public GdPictureImaging oGdPictureImaging = new GdPictureImaging();
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            //partidosPapeleta = new List<partido>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Papeleta papeleta = new Papeleta(ruta_papeletas+"\\"+listBox1.SelectedItem.ToString());
            Image <Bgr, Byte> img = new Image<Bgr, Byte>((Bitmap)pictureBox1.Image);
           
            // Image<Bgr, Byte> img = new Image<Bgr, Byte>("D:\\testimages\\2372884_41620516.tif");
            //Rectangle r = DetectSquare(img, 5, 3600, 70, 60, 70, 60);+
            //string[] ficheros = System.IO.Directory.GetFiles("C:\\Users\\disen\\Downloads\\cuadros\\cuadros\\imagenes");
            //    RecogSchema esquema = LeerXml();
            //    //DateTime fechaVoto = DateTime.Now;
            //foreach (string f in ficheros)            {
            //string f = "C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\image1.jpg";
            
            //pintaCuadrados();
            buscar(img, Papeletas[listBox1.SelectedIndex]);

            for(int i = 0; i < Papeletas[listBox1.SelectedIndex].partidosPapeleta.Count; i++)
            {
                MessageBox.Show(Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Nombre + ", marcado: " + Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Marcado);
            }
            //pintaCuadrados(f);
            //}
        }


        public void cargarPartidos()
        {
            XmlDocument xDoc;
            xDoc = new XmlDocument();
            partido p;
            xDoc.Load("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\xml\\xml1.xml");
            XmlNodeList papeleta = xDoc.GetElementsByTagName("papeleta");
            XmlNodeList cuadrado = ((XmlElement)papeleta[0]).GetElementsByTagName("cuadrado");
            foreach (XmlElement cuadro in cuadrado)
            {
                p = new partido();
                XmlNodeList nombre = cuadro.GetElementsByTagName("nombrePartido");
                p.Nombre = ((XmlElement)nombre[0]).InnerText.ToString();
                XmlNodeList representante = cuadro.GetElementsByTagName("representante");
                p.Representante = ((XmlElement)representante[0]).InnerText.ToString();
                XmlNodeList distX = cuadro.GetElementsByTagName("distCuadroX");
                p.DistX = int.Parse(((XmlElement)distX[0]).InnerText.ToString());
                XmlNodeList distY = cuadro.GetElementsByTagName("distCuadroY");
                p.DistY = int.Parse(((XmlElement)distY[0]).InnerText.ToString());
                XmlNodeList ancho = cuadro.GetElementsByTagName("anchoCuadro");
                p.Ancho = int.Parse(((XmlElement)ancho[0]).InnerText.ToString());
                XmlNodeList alto = cuadro.GetElementsByTagName("altoCuadro");
                p.Alto = int.Parse(((XmlElement)alto[0]).InnerText.ToString());
                p.Marcado = false;
               // this.partidosPapeleta.Add(p);
                //MessageBox.Show(p.Nombre);
            }
        }

        public Papeleta pintarCuadros(Rectangle r,int k, Papeleta p)
        {
            // detectar si hay cuadrados

            Image<Bgr, Byte> img = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            img.ROI = new Rectangle(r.X, r.Y, r.Width, r.Height);
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);
            UMat pyrDown = new UMat();
            UMat cannyEdges = new UMat();
            // CvInvoke.AdaptiveThreshold(uimage, uimage, 125, AdaptiveThresholdType.MeanC, ThresholdType.Binary, 11, 12);
            CvInvoke.Threshold(uimage, uimage, 180, 200, ThresholdType.Binary);
            //CvInvoke.Threshold(uimage, uimage, 127, 256, 0);



            var element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

            //CvInvoke.Dilate(uimage, uimage, element, new Point(-1, -1), 1, BorderType.Isolated, default(MCvScalar));
            CvInvoke.Erode(uimage, uimage, element, new Point(-1, -1), 1, BorderType.Default, default(MCvScalar));

            //CvInvoke.Dilate(uimage, uimage, element, new Point(-1, -1),2, BorderType.Reflect, default(MCvScalar));
            uimage.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_erode.png");
            // CvInvoke.PyrDown(uimage, pyrDown);
            // CvInvoke.PyrUp(pyrDown, uimage);
            //CvInvoke.Threshold(uimage, uimage, 50, 255, ThresholdType.Binary);

            CvInvoke.Canny(uimage, cannyEdges, 100, 250);
            cannyEdges.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_canny.png");

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();

            CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            double maxArea = 0;
            Rectangle rect = Rectangle.Empty;
            int blackQty = 0;

            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint contour = contours[i];

                VectorOfPoint approxContour = new VectorOfPoint();

                //nos dice  si es una figura poligonal
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                // Calcula el área de todo el contorno o sección del contorno.
                double area = CvInvoke.ContourArea(approxContour, false);
                // MessageBox.Show(area.ToString());

                if (approxContour.Size == 4 && area > maxArea)
                {
                    maxArea = area;
                    rect = CvInvoke.BoundingRectangle(approxContour);
                    using (UMat cuadrado = new UMat(uimage, rect))
                    {
                        blackQty = CvInvoke.CountNonZero(cuadrado);
                        if (blackQty < 6100)
                        {
                            MessageBox.Show(blackQty.ToString());
                            p.partidosPapeleta[k].Marcado = true;
                        }
                    }
                }
            }

            if (!rect.IsEmpty)
            img.Draw(rect, new Bgr(Color.Red), 2);
            
            img.ROI = new Rectangle();

            img.Draw(r, new Bgr(Color.Blue), 2);

            pictureBox1.Image = img.ToBitmap();

            //MessageBox.Show(count.ToString());

            //MessageBox.Show("a");
            return p;
        }
        public void buscar(Image<Bgr, Byte> img, Papeleta p)
        {
            List<Rectangle> rectangulos = new List<Rectangle>();
            for (int i = 0; i < p.partidosPapeleta.Count(); i++)
            {
                Rectangle rect = new Rectangle(this.xT + p.partidosPapeleta[i].DistX, this.yT + p.partidosPapeleta[i].DistY, p.partidosPapeleta[i].Ancho, p.partidosPapeleta[i].Alto);
                rectangulos.Add(rect);


            }

            pictureBox1.Image = img.ToBitmap();

            for (int k = 0; k < rectangulos.Count; k++)
            {
               p=pintarCuadros(rectangulos[k],k,p);
            }
            img=new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            img.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_deteccion_votos.png");

        }

        /*public void pintaCuadrados()
        {
            // detectar si hay cuadrados

            Image<Bgr, Byte> img = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            //System.IO.FileInfo f = new System.IO.FileInfo(imagen);
            UMat uimage = new UMat();
            CvInvoke.CvtColor(img, uimage, ColorConversion.Bgr2Gray);
            UMat pyrDown = new UMat();
            UMat cannyEdges = new UMat();
            // CvInvoke.AdaptiveThreshold(uimage, uimage, 125, AdaptiveThresholdType.MeanC, ThresholdType.Binary, 11, 12);
            CvInvoke.Threshold(uimage, uimage, 180, 200, ThresholdType.Binary);
            //CvInvoke.Threshold(uimage, uimage, 127, 256, 0);



            var element = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(3, 3), new Point(-1, -1));

            //CvInvoke.Dilate(uimage, uimage, element, new Point(-1, -1), 1, BorderType.Isolated, default(MCvScalar));
            CvInvoke.Erode(uimage, uimage, element, new Point(-1, -1), 1, BorderType.Default, default(MCvScalar));

            //CvInvoke.Dilate(uimage, uimage, element, new Point(-1, -1),2, BorderType.Reflect, default(MCvScalar));
            uimage.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_erode.png");
            // CvInvoke.PyrDown(uimage, pyrDown);
            // CvInvoke.PyrUp(pyrDown, uimage);
            //CvInvoke.Threshold(uimage, uimage, 50, 255, ThresholdType.Binary);

            CvInvoke.Canny(uimage, cannyEdges, 100, 250);
            cannyEdges.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_canny.png");

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
            int count = contours.Size;
            int a = 0;
            for (int i = 0; i < count; i++)
            {
                VectorOfPoint contour = contours[i];
                VectorOfPoint approxContour = new VectorOfPoint();
                //nos dice  si es una figura poligonal
                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
                // Calcula el área de todo el contorno o sección del contorno.
                double area = CvInvoke.ContourArea(approxContour, false);

                if (approxContour.Size >= 4)
                {
                    // es un cuadrado
                    
                    Rectangle rect = CvInvoke.BoundingRectangle(approxContour);
                    if (rect.Width > (img.Width * 0.02) && rect.Width < (img.Width * 0.06)
                        && rect.Height > (img.Height * 0.04) && rect.Height < (img.Height * 0.07))
                    {
                        a++;
                        //MessageBox.Show(approxContour.Size.ToString());
                        img.Draw(rect, new Bgr(Color.Red), 2);
                        pictureBox1.Image = img.ToBitmap();
                    }


                }

            }
            pictureBox1.Image = img.ToBitmap();
            img.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada_rectangulo_j.jpg");
            MessageBox.Show("Numero de cuadrados imagen es de " + a);

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            detectTemplate();
            btnBuscarCuadros.Enabled = true;
            //detectMultiTemplate();
        }

        public void detectTemplate()
        {
            try
            {

                Emgu.CV.Image<Bgr, byte> template = new Emgu.CV.Image<Bgr, byte>("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\logo1.png");

                // Image<Bgr, byte> source = new Image<Bgr, byte>("C:\\Users\\alain\\Downloads\\cuadros2\\cuadros\\cuadros\\DetectarCuadros\\imagen\\1556274603WhatsAppImage2019-04-16at13.11.56_forCrop_NoticiaAmpliada.jpg");

                Emgu.CV.Image<Bgr, byte> source = new Image<Bgr, Byte>(new Bitmap(pictureBox1.Image));
                //Image<Bgr, byte> source = new Image<Bgr, byte>("C:\\Users\\alain\\Downloads\\cuadros2\\cuadros\\cuadros\\DetectarCuadros\\imagen\\coleccion-logos-redes-sociales-populares-circulos_1361-901.jpg");
                //MessageBox.Show("hola" + template.ToString());


                Mat imgout = new Mat();

                CvInvoke.MatchTemplate(source, template, imgout, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

                double minVal = 0.0;
                double maxVal = 0.0;
                Point minLoc = new Point();
                Point maxLoc = new Point();

                CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                Rectangle r = new Rectangle(minLoc, template.Size);
                this.xT = minLoc.X;
                this.yT = minLoc.Y;
                CvInvoke.Rectangle(source, r, new MCvScalar(255, 0, 0), 3);
                pictureBox1.Image = source.ToBitmap();
                pictureBox1.Image.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada.jpg");


            }
            catch(IOException io)
            {
                MessageBox.Show("Archivo no encontrado");
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Primero debe haber una imagen cargada en el picture box");
            }
      }

        private void btnScanners_Click(object sender, EventArgs e)
        {
            Papeletas = new List<Papeleta>();
            listBox1.Items.Clear();
            foreach(String folder in Directory.GetFiles(ruta_papeletas)){
                listBox1.Items.Add(Path.GetFileName(folder));
                papeleta = new Papeleta(ruta_papeletas + "\\" + Path.GetFileName(folder));
                papeleta.XML_file = "C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\xml\\xml1.xml";
                papeleta.cargarPartidos();
                Papeletas.Add(papeleta);
            }
            
            listBox1.SelectedIndex=0;

            if (listBox1.SelectedIndex != -1)
            {
                btnTemplate.Enabled = true;
            }
            
 
        
        }

        private void origenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oGdPictureImaging.TwainSelectSource(this.Handle);
            MessageBox.Show(this.Handle.ToString());
        }

        private void abrirOrigenSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(oGdPictureImaging.TwainOpenDefaultSource(this.Handle)))
            {

                MessageBox.Show("Can't open default source !");
            }
        }

        private void sourceSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oGdPictureImaging.TwainGetState() < TwainStatus.TWAIN_SOURCE_OPEN)
            {
                MessageBox.Show("You need to open a source first !");
            }
            else
            {
                oGdPictureImaging.TwainShowSetupDialogSource(this.Handle);
            }
        }

        private void cerrarOrigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oGdPictureImaging.TwainCloseSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image<Bgr, Byte> img = new Image<Bgr, Byte>(ruta_papeletas+"\\"+listBox1.SelectedItem.ToString());
            pictureBox1.Image = img.ToBitmap();
        }

        private void cerrarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oGdPictureImaging.TwainCloseSourceManager(this.Handle);
        }

       
    }
}
