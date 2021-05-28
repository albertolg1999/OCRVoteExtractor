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
using System.Threading;

namespace OCRVoteExtractor
{
    public partial class Form1 : Form
    {
        Rutas r;
        List<Papeleta> Papeletas;
        Papeleta papeleta;
        String ruta_papeletas = "C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\papeletas";
        int xT, yT;
        public GdPictureImaging oGdPictureImaging = new GdPictureImaging();
        public Form1()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            r = new Rutas();
            progresResultado.Visible = false;
            label2.Visible = false;
            
            //partidosPapeleta = new List<partido>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Papeleta papeleta = new Papeleta(ruta_papeletas+"\\"+listBox1.SelectedItem.ToString());
            Image <Bgr, Byte> img = new Image<Bgr, Byte>((Bitmap)pictureBox1.Image);
           
            
            buscar(img, Papeletas[listBox1.SelectedIndex]);

            //for(int i = 0; i < Papeletas[listBox1.SelectedIndex].partidosPapeleta.Count; i++)
            //{
            //    MessageBox.Show(Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Nombre + ", marcado: " + Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Marcado);
            //}
            //pintaCuadrados(f);
            //}
        }


        //public void cargarPartidos()
        //{
        //    XmlDocument xDoc;
        //    xDoc = new XmlDocument();
        //    partido p;
        //    xDoc.Load("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\xml\\xml1.xml");
        //    XmlNodeList papeleta = xDoc.GetElementsByTagName("papeleta");
        //    XmlNodeList cuadrado = ((XmlElement)papeleta[0]).GetElementsByTagName("cuadrado");
        //    foreach (XmlElement cuadro in cuadrado)
        //    {
        //        p = new partido();
        //        XmlNodeList nombre = cuadro.GetElementsByTagName("nombrePartido");
        //        p.Nombre = ((XmlElement)nombre[0]).InnerText.ToString();
        //        XmlNodeList representante = cuadro.GetElementsByTagName("representante");
        //        p.Representante = ((XmlElement)representante[0]).InnerText.ToString();
        //        XmlNodeList distX = cuadro.GetElementsByTagName("distCuadroX");
        //        p.DistX = int.Parse(((XmlElement)distX[0]).InnerText.ToString());
        //        XmlNodeList distY = cuadro.GetElementsByTagName("distCuadroY");
        //        p.DistY = int.Parse(((XmlElement)distY[0]).InnerText.ToString());
        //        XmlNodeList ancho = cuadro.GetElementsByTagName("anchoCuadro");
        //        p.Ancho = int.Parse(((XmlElement)ancho[0]).InnerText.ToString());
        //        XmlNodeList alto = cuadro.GetElementsByTagName("altoCuadro");
        //        p.Alto = int.Parse(((XmlElement)alto[0]).InnerText.ToString());
        //        p.Marcado = false;
        //       // this.partidosPapeleta.Add(p);
        //        //MessageBox.Show(p.Nombre);
        //    }
        //}

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

                if (approxContour.Size >= 4 && area < 9600 && area>maxArea)
                {
                    //MessageBox.Show(area.ToString());
                    maxArea = area;
                    rect = CvInvoke.BoundingRectangle(approxContour);
                    using (UMat cuadrado = new UMat(uimage, rect))
                    {
                        blackQty = CvInvoke.CountNonZero(cuadrado);
                        //MessageBox.Show(blackQty.ToString());
                        if (blackQty < 6700&& blackQty>3000)
                        {
                            //MessageBox.Show(blackQty.ToString());
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
            img.Dispose();
            uimage.Dispose();
            pyrDown.Dispose();
            cannyEdges.Dispose();
            element.Dispose();
            contours.Dispose();
            //approxContour


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
            img = new Image<Bgr, byte>((Bitmap)pictureBox1.Image);
            
            img.Save(r.ruta_temporales + "\\resultados_" + listBox1.SelectedItem.ToString());

            img = new Image<Bgr, Byte>(r.ruta_papeletas + "\\" + listBox1.SelectedItem.ToString());
            
            pictureBox1.Image = img.ToBitmap();

            img.Dispose();

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
            
            //detectMultiTemplate();
        }

        private Image<Bgr, byte> detectTemplate()
        {
            Emgu.CV.Image<Bgr, byte> source=null;
            Emgu.CV.Image<Bgr, byte> template = null;
            try
            {

               template = new Emgu.CV.Image<Bgr, byte>(this.r.rc_imag+"\\logo1.png");

                
               source= new Image<Bgr, Byte>(new Bitmap(pictureBox1.Image));
               


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
                pictureBox1.Image.Save(this.r.rc_imag+"\\guardada.jpg");
                

            }
            catch(IOException io)
            {
                MessageBox.Show("Archivo no encontrado");
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Primero debe haber una imagen cargada en el picture box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
            finally
            {
                //template.Dispose();
                //source.Dispose();
            }
            return source;
            
        }
        private void Escanear()
        {
            
            int nImageCount = 0;
            int ImageID = 0;

            try
            {
                if (oGdPictureImaging.TwainOpenDefaultSource(this.Handle))
                {
                    nImageCount = 0;

                    //InitScanConfig();

                    oGdPictureImaging.TwainSetAutoFeed(true); // Set AutoFeed Enabled
                    oGdPictureImaging.TwainSetAutoScan(true); // To  achieve the maximum scanning rate

                    oGdPictureImaging.TwainSetResolution(300);
                    oGdPictureImaging.TwainSetPixelType(TwainPixelType.TWPT_RGB); // RGB
                    oGdPictureImaging.TwainSetBitDepth(24); //  24 bpp

                    do
                    {
                        ImageID = oGdPictureImaging.TwainAcquireToGdPictureImage(this.Handle);
                        if (ImageID != 0)
                        {

                            if (ImageID != 0)
                            {

                                nImageCount = nImageCount + 1;
                                oGdPictureImaging.SaveAsJPEG(ImageID, this.r.ruta_temporales + "\\papeleta" + nImageCount.ToString().Trim() + ".jpg", 75);
                                oGdPictureImaging.ReleaseGdPictureImage(ImageID);
                            }

                        }

                    }
                    while (oGdPictureImaging.TwainGetState() > TwainStatus.TWAIN_SOURCE_ENABLED);

                    oGdPictureImaging.TwainCloseSource();
                    MessageBox.Show("Escaner finalizado");
                }
                else
                {
                    MessageBox.Show("can't open default source, twain state is: " + oGdPictureImaging.TwainGetState().ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }

            
        }
        private void btnScanners_Click(object sender, EventArgs e)
        {
           
            try {
               // Escanear();
                Papeletas = new List<Papeleta>();
                listBox1.Items.Clear();

                foreach (String folder in Directory.GetFiles(ruta_papeletas))
                {
                    listBox1.Items.Add(Path.GetFileName(folder));
                    papeleta = new Papeleta(this.r.ruta_papeletas + "\\" + Path.GetFileName(folder));
                    //papeleta = new Papeleta(ruta_papeletas + "\\" + Path.GetFileName(folder));
                    papeleta.XML_file = this.r.ruta_xml+"\\xml1.xml";
                    papeleta.cargarPartidos();
                    Papeletas.Add(papeleta);
                }

               
                btnTerminar.Enabled = true;

                Image<Bgr, Byte> img_original = new Image<Bgr, Byte>(ruta_papeletas + "\\" + listBox1.Items[0].ToString());
                pictureBox1.Image = img_original.ToBitmap();
                //listBox1.SelectedIndex = 0;

                progresResultado.Maximum = Papeletas.Count;

            }
            catch(ArgumentOutOfRangeException aore)
            {
                MessageBox.Show("No se encontraron archivos");
            }
        }

        //Messagebox Automatico
        private void showMessage(string msg, int duration)
        {
            using (System.Windows.Forms.Timer t = new System.Windows.Forms.Timer())
            {
                System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
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
            Image<Bgr, Byte> img_original = new Image<Bgr, Byte>(ruta_papeletas + "\\" + listBox1.Items[listBox1.SelectedIndex].ToString());
            pictureBox1.Image = img_original.ToBitmap();
        }

        private void tsmtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void GuardarResultado()
        {
            XmlDocument xDoc = new XmlDocument();
            XmlDeclaration xmlDeclaration = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = xDoc.DocumentElement;
            xDoc.InsertBefore(xmlDeclaration, root);

            XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "resultados", string.Empty);
            xDoc.AppendChild(elementoRaiz);

            for (int i = 0; i < Papeletas.Count; i++)
            {
                XmlElement xpapeleta = xDoc.CreateElement(string.Empty, "papeleta", string.Empty);

                xpapeleta.SetAttribute("nombre", listBox1.Items[i].ToString());
                //for (int k = 0; k < Papeletas[i].partidosPapeleta.Count; k++)
                //{
                //    MessageBox.Show(Papeletas[i].partidosPapeleta[k].Nombre + ", marcado: " + Papeletas[i].partidosPapeleta[k].Marcado);
                //}
                for (int ind = 0; ind < Papeletas[i].partidosPapeleta.Count; ind++)
                {

                    if (Papeletas[i].partidosPapeleta[ind].Marcado)
                    {

                        XmlElement xRepresentante = xDoc.CreateElement(string.Empty, "representante", string.Empty);
                        XmlText xTXTRepres = xDoc.CreateTextNode(Papeletas[i].partidosPapeleta[ind].Representante);
                        xRepresentante.AppendChild(xTXTRepres);
                        xpapeleta.AppendChild(xRepresentante);

                    }


                }
                elementoRaiz.AppendChild(xpapeleta);
            }

            xDoc.Save(this.r.ruta_xml + "\\resultados.xml");
            MessageBox.Show("Resultados guardados en el xml. Votación terminada!!");
        }
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Empezando el escaneo");
            progresResultado.Visible = true;
            label2.Visible = true;
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            for (int ind = 0; ind < listBox1.Items.Count; ind++)
            {
                progresResultado.Value += 1;
                listBox1.SelectedIndex = ind;

                //if (ind < listBox1.Items.Count)
                //{
                //    showMessage("Siguiente papeleta: " + listBox1.SelectedItem.ToString(), 2000);
                //}

                

                Image<Bgr, Byte> img = detectTemplate();
                //btnBuscarCuadros.Enabled = true;


                buscar(img, Papeletas[listBox1.SelectedIndex]);
                //listBox1.Items.Count

                

                //showMessage("Extracción completada: " + listBox1.SelectedItem.ToString(), 2000);

                //for (int i = 0; i < Papeletas[listBox1.SelectedIndex].partidosPapeleta.Count; i++)
                //{
                //    MessageBox.Show(Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Nombre + ", marcado: " + Papeletas[listBox1.SelectedIndex].partidosPapeleta[i].Marcado);
                //}


            }
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            label2.Text = "Extracción terminada";
            MessageBox.Show("Papeletas Escaneadas exitosamente");

            GuardarResultado();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (IntPtr.Size == 8)
            //{
            //    MessageBox.Show("Warning: The application is running in 64-bit mode. To be able to handle 32-bit TWAIN drivers you will have to target it to 32-bit mode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //GdPicture10.LicenseManager oLicenceManager = new GdPicture10.LicenseManager(); //Go to http://evaluation-gdpicture.com to get a 1 month trial key unlocking all features of the toolkit.
            //oLicenceManager.RegisterKEY("211849558933247691113131281102544");//Please, replace XXXX by a valid demo or commercial license key. 
        }

        private void cerrarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oGdPictureImaging.TwainCloseSourceManager(this.Handle);
        }

       
    }
}
