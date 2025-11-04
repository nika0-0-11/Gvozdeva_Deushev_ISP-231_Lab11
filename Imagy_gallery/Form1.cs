using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagy_gallery
{
    public partial class Form1 : Form
    {
        int currentIndex = 1; 

        public Form1()
        {
            InitializeComponent();
            ShowImage();
        }
        
        private readonly object[] images =
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3
        };

        private void ShowImage()
        {
            pictureBox1.Image = (System.Drawing.Image)images[currentIndex]; 
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Length) 
                currentIndex = 0;
            ShowImage();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) 
                currentIndex = images.Length - 1;
            ShowImage();
        }
    }
}
