using OpenCvSharp;
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

namespace Quiz01
{
    public partial class Form1 : Form
    {
        private Mat image1;
        private Mat image2;
        private Mat dst;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 간단한 프로그램은 Form_Load할 때 초기화하면 가장 버그가 적게 생김

            image1 = new Mat(250, 250, MatType.CV_8UC1, Scalar.All(0));
            image2 = new Mat(250, 250, MatType.CV_8UC1, Scalar.All(0));
            image3 = new Mat();
            image4 = new Mat();
            image5 = new Mat();
            image6 = new Mat();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = BitmapConverter.ToBitmap(image1);

        }
    }
}
