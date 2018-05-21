using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Main_Project;
using BonusMain;

namespace MagicalJournal
{
    public partial class Form1 : Form
    {
        public static string Journal_ImagePath;
        public static MWArray[] Results = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.tif; *.png *.bmp)|*.jpg; *.jpeg; *.gif; *.tif; *.png; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                Journal_ImagePath = openFileDialog1.FileName;
            }
            Main_Project.Proj Obj = new Proj();
            MWCharArray Image_Path = new MWCharArray(Journal_ImagePath);
            Results = Obj.Main_Project(0, Image_Path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.tif; *.png *.bmp)|*.jpg; *.jpeg; *.gif; *.tif; *.png; *.bmp";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog2.FileName);
                Journal_ImagePath = openFileDialog2.FileName;
            }
            BonusMain.Bonus Obj = new Bonus();
            MWCharArray Image_Path = new MWCharArray(Journal_ImagePath);
            Results = Obj.BonusMain(0, Image_Path);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "G:\\mohmed\\Fourth year\\Second Term\\Image Processing\\Magical Newspaper\\Harry Potter Theme Song.mp3";
            wplayer.controls.play();
        }
    }
}
