using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//pictureBox1.Image = Properties.Resources.cover as Bitmap;
//pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 

namespace Higer_or_Lower
{

    public partial class Form1 : Form
    {
        int card1, card2;
        int MaxCards = 13;
        int win = 0;
        int fail = 0;

         int C1gen ()
         {
             Random rand = new Random();
             int card1 = rand.Next(13) + 1;
             return card1;
         }

        int C2gen ()
         {
             Random randd = new Random();
             int card2 = randd.Next(13) + 1;
             return card2;
         }

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.cover as Bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Properties.Resources.cover as Bitmap;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            button3_Click(null,null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (card2>card1)
            {
                label2.Text = "YOU WIN";
                win++;
                label5.Text = Convert.ToString(win);
            }
            else
            {
                label2.Text = "YOU FAIL";
                fail++;
                label6.Text = Convert.ToString(fail);
            }
            
            if (card2 == 1)
           {
               pictureBox2.Image = Properties.Resources.c1 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 2)
           {
               pictureBox2.Image = Properties.Resources.c2 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 3)
           {
               pictureBox2.Image = Properties.Resources.c3 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 4)
           {
               pictureBox2.Image = Properties.Resources.c4 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 5)
           {
               pictureBox2.Image = Properties.Resources.c5 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 6)
           {
               pictureBox2.Image = Properties.Resources.c6 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 7)
           {
               pictureBox2.Image = Properties.Resources.c7 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 8)
           {
               pictureBox2.Image = Properties.Resources.c8 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 9)
           {
               pictureBox2.Image = Properties.Resources.c9 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 10)
           {
               pictureBox2.Image = Properties.Resources.c10 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 11)
           {
               pictureBox2.Image = Properties.Resources.c11 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 12)
           {
               pictureBox2.Image = Properties.Resources.c12 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 13)
           {
               pictureBox2.Image = Properties.Resources.c13 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }

           button1.Enabled = false;
           button2.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //случайно нажал
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //случайно нажал
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (card2<card1)
            {
                label2.Text = "YOU WIN";
                win++;
                label5.Text = Convert.ToString(win);
            }
            else
            {
                label2.Text = "YOU FAIL";
                fail++;
                label6.Text = Convert.ToString(fail);
            }
            
            if (card2 == 1)
           {
               pictureBox2.Image = Properties.Resources.c1 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 2)
           {
               pictureBox2.Image = Properties.Resources.c2 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 3)
           {
               pictureBox2.Image = Properties.Resources.c3 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 4)
           {
               pictureBox2.Image = Properties.Resources.c4 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 5)
           {
               pictureBox2.Image = Properties.Resources.c5 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 6)
           {
               pictureBox2.Image = Properties.Resources.c6 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 7)
           {
               pictureBox2.Image = Properties.Resources.c7 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 8)
           {
               pictureBox2.Image = Properties.Resources.c8 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 9)
           {
               pictureBox2.Image = Properties.Resources.c9 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 10)
           {
               pictureBox2.Image = Properties.Resources.c10 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 11)
           {
               pictureBox2.Image = Properties.Resources.c11 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 12)
           {
               pictureBox2.Image = Properties.Resources.c12 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           if (card2 == 13)
           {
               pictureBox2.Image = Properties.Resources.c13 as Bitmap;
               pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
           }
           button1.Enabled = false;
           button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            pictureBox2.Image = Properties.Resources.cover as Bitmap;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Enabled = true;
            button2.Enabled = true;
            card1 = C1gen();
            card2 = C2gen();
            while (card2 == card1)
            {
                card2 = C2gen();
            }
            if (card1 == 2)
            {
                pictureBox1.Image = Properties.Resources.c2 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 3)
            {
                pictureBox1.Image = Properties.Resources.c3 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 4)
            {
                pictureBox1.Image = Properties.Resources.c4 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 5)
            {
                pictureBox1.Image = Properties.Resources.c5 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 6)
            {
                pictureBox1.Image = Properties.Resources.c6 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 7)
            {
                pictureBox1.Image = Properties.Resources.c7 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 8)
            {
                pictureBox1.Image = Properties.Resources.c8 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 9)
            {
                pictureBox1.Image = Properties.Resources.c9 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 10)
            {
                pictureBox1.Image = Properties.Resources.c10 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 11)
            {
                pictureBox1.Image = Properties.Resources.c11 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 12)
            {
                pictureBox1.Image = Properties.Resources.c12 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (card1 == 13)
            {
                pictureBox1.Image = Properties.Resources.c13 as Bitmap;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
