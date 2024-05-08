using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int currentIndex = 0;
        private string[] imagePaths = { @"C:\Users\vovaa\source\repos\WpfApp1\Materials\бургер1.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\бургер2.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\чтоЭтоЖеНеБургерИзвините.jpg", @"C:\Users\vovaa\source\repos\WpfApp1\Materials\мэ.jpg" };
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imagePaths[currentIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length;
            pictureBox1.Image = Image.FromFile(imagePaths[currentIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagePaths.Length) % imagePaths.Length;
            pictureBox1.Image = Image.FromFile(imagePaths[currentIndex]);
        }
    }
}
