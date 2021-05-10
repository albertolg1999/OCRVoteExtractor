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

namespace OCRVoteExtractor
{
    public partial class Form1 : Form
    {
        public GdPictureImaging oGdPictureImaging = new GdPictureImaging();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Image<Bgr, Byte> img = new Image<Bgr, Byte>("D:\\testimages\\2372884_41620516.tif");
            //Rectangle r = DetectSquare(img, 5, 3600, 70, 60, 70, 60);+
            //string[] ficheros = System.IO.Directory.GetFiles("C:\\Users\\disen\\Downloads\\cuadros\\cuadros\\imagenes");
            //    RecogSchema esquema = LeerXml();
            //    //DateTime fechaVoto = DateTime.Now;
            //foreach (string f in ficheros)            {
            string f = "C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\image1.jpg";
            pintaCuadrados(f);
            //}
        }

        public void pintaCuadrados(string imagen)
        {
            // detectar si hay cuadrados

            Image<Bgr, Byte> img = new Image<Bgr, Byte>(imagen);
            System.IO.FileInfo f = new System.IO.FileInfo(imagen);
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
            uimage.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\" + f.Name + "_erode.png");
            // CvInvoke.PyrDown(uimage, pyrDown);
            // CvInvoke.PyrUp(pyrDown, uimage);
            //CvInvoke.Threshold(uimage, uimage, 50, 255, ThresholdType.Binary);

            CvInvoke.Canny(uimage, cannyEdges, 100, 250);
            cannyEdges.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\" + f.Name + "_canny.png");

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
                        img.Draw(rect, new Bgr(Color.Red), 2);
                    }


                }

            }
            img.Save("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\" + f.Name + "_rectangulo.jpg");
            MessageBox.Show("Numero de cuadrados imagen " + f.Name + " es de " + a);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            detectTemplate();
            //detectMultiTemplate();
        }

        public void detectTemplate()
        {

            Emgu.CV.Image<Bgr, byte> template = new Emgu.CV.Image<Bgr, byte>("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\logo1.png");

            // Image<Bgr, byte> source = new Image<Bgr, byte>("C:\\Users\\alain\\Downloads\\cuadros2\\cuadros\\cuadros\\DetectarCuadros\\imagen\\1556274603WhatsAppImage2019-04-16at13.11.56_forCrop_NoticiaAmpliada.jpg");

            Emgu.CV.Image<Bgr, byte> source = new Emgu.CV.Image<Bgr, byte>("C:\\Users\\alain\\Documents\\PFG\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\image1.jpg");
            //Image<Bgr, byte> source = new Image<Bgr, byte>("C:\\Users\\alain\\Downloads\\cuadros2\\cuadros\\cuadros\\DetectarCuadros\\imagen\\coleccion-logos-redes-sociales-populares-circulos_1361-901.jpg");
            //MessageBox.Show("hola" + template.ToString());


            Mat imgout = new Mat();

            CvInvoke.MatchTemplate(source, template, imgout, Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);

            MessageBox.Show(imgout.ToString());
            double minVal = 0.0;
            double maxVal = 0.0;
            Point minLoc = new Point();
            Point maxLoc = new Point();

            CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
            Rectangle r = new Rectangle(minLoc, template.Size);
            CvInvoke.Rectangle(source, r, new MCvScalar(255, 0, 0), 3);
            pictureBox1.Image = source.ToBitmap();
            pictureBox1.Image.Save("C:\\Users\\alain\\Documents\\Proyecto Fin Grado\\OCRVoteExtractor\\OCRVoteExtractor\\OCRVoteExtractor\\imagen\\guardada.jpg");

        }

        private void btnScanners_Click(object sender, EventArgs e)
        {
            oGdPictureImaging.TwainSelectSource(this.Handle);
            MessageBox.Show(this.Handle.ToString());
        }

        //    public static Rectangle DetectSquare(Image<Bgr, Byte> img, int dilate, int contour_area, int maxW, int minW, int maxH, int minH)
        //    {
        //        double cannyThreshold = 100.0;
        //        double cannyThresholdLinking = 200.0;

        //        Convert the image to grayscale and filter out the noise
        //        Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

        //        try
        //        {
        //            Image<Gray, Byte> cannyEdges = gray.Canny(cannyThreshold, cannyThresholdLinking);
        //            cannyEdges = cannyEdges.Dilate(dilate);

        //            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
        //                for (Contour<Point> contours = cannyEdges.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
        //                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage); contours != null; contours = contours.HNext)
        //                {
        //                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.02, storage);

        //                    if (currentContour.Area > contour_area)
        //                    {
        //                        if (currentContour.Total >= 4) //The contour has 4 vertices.
        //                        {
        //                            Point[] pts = currentContour.ToArray();
        //                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

        //                            if (img.GetSubRect(currentContour.BoundingRectangle).Width > minW &&
        //                                img.GetSubRect(currentContour.BoundingRectangle).Width < maxW &&
        //                                img.GetSubRect(currentContour.BoundingRectangle).Height > minH &&
        //                                img.GetSubRect(currentContour.BoundingRectangle).Height < maxH)
        //                            {

        //                                Image<Bgr, Byte> imgResult = new Image<Bgr, Byte>(currentContour.GetMinAreaRect().MinAreaRect().Height, currentContour.GetMinAreaRect().MinAreaRect().Width);
        //                                Rectangle rect = new Rectangle();
        //                                rect.X = currentContour.BoundingRectangle.X;
        //                                rect.Y = currentContour.BoundingRectangle.Y;
        //                                rect.Width = currentContour.BoundingRectangle.Width;
        //                                rect.Height = currentContour.BoundingRectangle.Height;
        //                                imgResult = img.GetSubRect(rect);
        //                                img.Draw(rect, new Bgr(Color.Red), 2);
        //                                img.Save("D:\\rectangulo.jpg");

        //                                return rect;
        //                            }
        //                        }
        //                    }
        //                }
        //        }
        //        catch (Exception e)
        //        {

        //        }
        //        return Rectangle.Empty;
        //    }
        //}
    }
}
