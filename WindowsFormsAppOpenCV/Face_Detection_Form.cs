using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using OpenCvSharp;

namespace WindowsFormsAppOpenCV
{
    public partial class Face_Detection_Form : Form
    {

        // khai bao bien 
        Emgu.CV.CascadeClassifier _faceDetected;
        Image<Emgu.CV.Structure.Bgr, Byte> Frame;
       
        Emgu.CV.VideoCapture camera;
        Image<Gray, byte> _result;
        Image<Gray, byte> _TrainedFace=null;
        Image<Gray, byte> _GrayFace = null;
        List<Image<Gray, byte>> trainningImages = new List<Image<Gray, byte>>();
        List<string> _labelsObject = new List<string>();
        List<string> _Users = new List<string>();
        int Count, Numlabels, t;
        string name, names = null;

        
        public Face_Detection_Form()
        {
            InitializeComponent();

            _faceDetected = new Emgu.CV.CascadeClassifier("Cascade_Class_Face.xml");
            try
            {
                string labelsInfo = File.ReadAllText(Application.StartupPath + "\\faces\\faces.txt");
                string[] labels = labelsInfo.Split(',');
                Numlabels = Convert.ToInt16(labels[0]);
                Count = Numlabels;
                string Faceload;
                for(int i = 1; i < Numlabels + 1; i++)
                {
                    Faceload = "Face" + i + ".bmp";
                    trainningImages.Add(new Image<Gray, byte>(Application.StartupPath + "\\faces\\faces.txt"));
                    _labelsObject.Add(labels[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can not read data from Database!");
            }

        }

        private void btn_detect_Click(object sender, EventArgs e)
        {
            camera = new Emgu.CV.VideoCapture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            camera = new Emgu.CV.VideoCapture();   
            _Users.Add("");
            //Frame = camera.QueryFrame().Resize(320,240,Emgu.CV.CvEnum.Inter.Cubic);
            
            throw new NotImplementedException();
        }
    }
}
