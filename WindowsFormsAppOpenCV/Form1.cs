using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsAppOpenCV
{
    public partial class Form_ImageProcessing : Form
    {
        public Form_ImageProcessing()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Cac ham xu kien xu ly image bang cac Button_click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Button Function Events
        private void Btn_Image_Sepia_Click(object sender, EventArgs e)
        {


            // lay gia tri tu trackbar ve de set gia tri cho ham Sepia
            float[] _listGettrb_value = { trb_value1.Value, trb_value2.Value, trb_value3.Value, trb_value4.Value, trb_value5.Value, trb_value6.Value, trb_value7.Value, trb_value8.Value, trb_value9.Value };

            lbl_display_value1.Text = trb_value1.Value.ToString();
            lbl_display_value2.Text = trb_value2.Value.ToString();
            lbl_display_value3.Text = trb_value3.Value.ToString();
            lbl_display_value4.Text = trb_value4.Value.ToString();
            lbl_display_value5.Text = trb_value5.Value.ToString();
            lbl_display_value6.Text = trb_value6.Value.ToString();
            lbl_display_value7.Text = trb_value7.Value.ToString();
            lbl_display_value8.Text = trb_value8.Value.ToString();
            lbl_display_value9.Text = trb_value9.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            //Sepia(src, dst, new float[] { 0.272f, 0.534f, 0.131f, 0.349f, 0.686f, 0.168f, 0.393f, 0.769f, 0.189f });
            Sepia(src, dst, _listGettrb_value);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------ Edge Dection Function
        private void Btn_Image_EdgeDetect_Click(object sender, EventArgs e)
        {
            float temp1 = trb_edge_value1.Value;
            float temp2 = trb_edge_value2.Value;

            lbl_edge_display1.Text = trb_edge_value1.Value.ToString();
            lbl_edge_display2.Text = trb_edge_value2.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            edge_detection(src, dst, temp1, temp2);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------- Gaussian Blur function
        private void Btn_Image_GaussianBlur_Click(object sender, EventArgs e)
        {
            double temp = trb_gaussianblur_value_edit.Value;
            lbl_gaussianblur_value_display.Text = trb_gaussianblur_value_edit.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            gaussian_blur(src, dst, new OpenCvSharp.Size(15, 15), temp);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------- Median Blur
        private void Btn_Image_MedianBlur_Click(object sender, EventArgs e)
        {
            lbl_medianblur_value_display.Text = trb_medianblur_value_edit.Value.ToString();
            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            median_blur(src, dst, trb_medianblur_value_edit.Value);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------- Blur
        private void Btn_Image_Blur_Click(object sender, EventArgs e)
        {
            double temp = trb_blur_value_edit.Value;
            lbl_blur_value_display.Text = trb_blur_value_edit.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            blur(src, dst, new OpenCvSharp.Size(temp, temp));

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------- Box Filter function
        private void Btn_Image_BoxFilter_Click(object sender, EventArgs e)
        {
            double temp = trb_boxF_value_edit2.Value;
            lbl_boxF_value_display1.Text = trb_boxF_value_edit1.Value.ToString();
            lbl_boxF_value_display2.Text = trb_boxF_value_edit2.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            box_filter(src, dst, 1, new OpenCvSharp.Size(temp, temp));

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }
        //------- Dilation function
        private void Btn_Image_Dilation_Click(object sender, EventArgs e)
        {
            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();

            OpenCvSharp.Point p = new OpenCvSharp.Point();
            p.X = -1;
            p.Y = -1;
            
            lbl_dilation_value_display.Text = trb_dilation_value_edit.Value.ToString();
            dilation(src, dst, new Mat(),p,trb_dilation_value_edit.Value);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //----------- Erosion function
        private void Btn_Image_Erosion_Click(object sender, EventArgs e)
        {
            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor); //"C://Users//HariAoMatsuzuki//Pictures//VRMikuicon.png"
            Mat dst = new Mat();

            OpenCvSharp.Point p = new OpenCvSharp.Point();
            p.X = -1;
            p.Y = -1;

            lbl_erosion_value_display.Text = trb_erosion_value_edit.Value.ToString();
            erosion(src, dst, new Mat(), p, trb_erosion_value_edit.Value);

            //Window source = new Window("Source of Image", src);
            //Window des = new Window("Image after Processing", dst);


            //picBox_des_image.Image = new Bitmap(dst.ToString());
            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------------- Threshold function
        private void Btn_Image_Threshold_Click(object sender, EventArgs e)
        {
            double temp1 = trb_threshold_edit1.Value;
           

            lbl_threshold_value1.Text = trb_threshold_edit1.Value.ToString();
            

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            threshold(src,dst,temp1,255);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //------------ Bit;ateral Filter function
        private void Btn_Image_BilateralFilter_Click(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(textBox1.Text.ToString());
            double temp2 = Convert.ToDouble(textBox2.Text.ToString());

            lbl_bilateralF_value_display.Text = trb_bitlateral_value_edit.Value.ToString();

            Mat src = new Mat(TxB_File_Source.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            bilateral_filter(src, dst, trb_bitlateral_value_edit.Value, temp1, temp2);

            Bitmap _bitmapImg = dst.ToBitmap();
            picBox_des_image.Image = _bitmapImg;
            picBox_des_image.SizeMode = PictureBoxSizeMode.StretchImage;
            Cv2.WaitKey(0);
        }

        //---------- Menu OpenFile function
        private void Menu_OpenFile_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Images(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                
                picBox_source_image.Image = new Bitmap(open.FileName);
                
                picBox_source_image.SizeMode = PictureBoxSizeMode.StretchImage;
                // image file path  
                
                TxB_File_Source.Text = open.FileName;
                
            }
        }

        //------------- Menu SaveFile function
        private void Menu_SaveFile_Click(object sender, EventArgs e)
        {
            // khoi tao mot saveFileDialog
            SaveFileDialog save_img = new SaveFileDialog();
            save_img.Filter = "Jpeg Image|*.jpg|PNG Image|*.png|Gif Image|*.gif";
            save_img.Title = "Save an Image file";

            // tao dieu kien if de kiem tra xem file da co ten chua
            if (save_img.ShowDialog() == DialogResult.OK && save_img.FileName!=null)
            {
                // Saves the Image via a FileStream created by the OpenFile method.  
                // Saves the Image in the appropriate ImageFormat based upon the  
                // File type selected in the dialog box.  
                // NOTE that the FilterIndex property is one-based.  
                System.IO.FileInfo fi = new System.IO.FileInfo(save_img.FileName);
                string _filename = fi.Name;

                switch (save_img.FilterIndex)
                {
                    case 1:
                        picBox_des_image.Image.Save("C://Users//HariAoMatsuzuki//Pictures//" + _filename);
                       
                        break;

                    case 2:
                        picBox_des_image.Image.Save("C://Users//HariAoMatsuzuki//Pictures//" + _filename);
                        
                        break;

                    case 3:
                        picBox_des_image.Image.Save("C://Users//HariAoMatsuzuki//Pictures//" + _filename);
                       
                        break;
                }
                
            }
        }


        //----------------------- Menu Open Login Firebase
        private void Menu_Login_Click(object sender, EventArgs e)
        {
            LoginFirebaseForm _newform = new LoginFirebaseForm();
            _newform.Show();
        }



        /// <summary>
        /// This part is some functions to process image from OpenCV libs
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <param name="data"></param>
        //----------------------------------------------------------
        public static void Sepia(Mat src, Mat dst, float[] data)
        {
            Mat kernel = new Mat(rows: 3, cols: 3, type: MatType.CV_32FC1, data: data);
            Cv2.Transform(src, dst, kernel);
        }

        //-----------------------------------------------------------
        public static void edge_detection(Mat src, Mat dst, double a, double b)
        {
            Cv2.Canny(src, dst, a, b);
            
        }

        //-------------------------------------------------------------
        public static void gaussian_blur(Mat src, Mat dst, OpenCvSharp.Size k, double s)
        {
            Cv2.GaussianBlur(src, dst, k, s);
        }

        //--------------------------------------------------------------
        public static void median_blur(Mat src, Mat dst, int k)
        {
            Cv2.MedianBlur(src, dst, k);
        }
        
        //--------------------------------------------------------------
        public static void blur(Mat src, Mat dst, OpenCvSharp.Size k)
        {
            Cv2.Blur(src, dst, k);
        }
        //--------------------------------------------------------------
        public static void box_filter(Mat src, Mat dst, int var_depth, OpenCvSharp.Size k)
        {
            Cv2.BoxFilter(src, dst, var_depth, k);
        }
        //--------------------------------------------------------------
        public static void dilation(Mat src, Mat dst, Mat m, OpenCvSharp.Point p, int iter)
        {
            Cv2.Dilate(src, dst, m, p, iter);
        }

        //---------------------------------------------------------------
        public static void erosion(Mat src, Mat dst, Mat m, OpenCvSharp.Point p, int iter)
        {
            Cv2.Erode(src, dst, m, p, iter);
        }

        //---------------------------------------------------------------
        public static void threshold(Mat src, Mat dst, double a, double b)
        {
            Cv2.Threshold(src, dst, a, b, ThresholdTypes.Binary);
            
        }

        //---------------------------------------------------------------
        public static void bilateral_filter(Mat src, Mat dst, int d, double sigma_color, double sigma_space)
        {
            Cv2.BilateralFilter(src, dst, d, sigma_color, sigma_space);
        }

        //---------------------------------------------------------------
        private void lbl_acc_Click(object sender, EventArgs e)
        {
            LoginFirebaseForm loginF = new LoginFirebaseForm();

            lbl_display_acc.Text = loginF._username;
        }

        
    }
}
