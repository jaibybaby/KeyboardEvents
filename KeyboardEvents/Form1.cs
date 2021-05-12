using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardEvents
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtHeading_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            //picBall.Location = panel1.Location;
            // picBall.Location = this.Location;

            
            //if (x <= panel1.Width-50)
            //{
               
           // }
}
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = picBall.Location.X;
            int y = picBall.Location.Y;
            if (x >= 25)
            {
                if (e.KeyCode == Keys.A)
                {
                    picBall.Left = picBall.Left - 10;
                }
            }
            if (x <= 400)
            {
                if (e.KeyCode == Keys.B)
                {
                    picBall.Left = picBall.Left + 10;
                }
            }
            if (y>= 25)
            {
                if (e.KeyCode == Keys.W)
                {
                    picBall.Top = picBall.Top - 10;
                }
            }
            if (y<= 400)
            {
                if (e.KeyCode == Keys.F)
                {
                    picBall.Top = picBall.Top + 10;
                }
            }
             if (e.KeyCode == Keys.C)
            {
                picBall.Location = new Point((panel1.Width / 2) - (picBall.Width / 2), (panel1.Height / 2) - (picBall.Height / 2));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // picBall.Location = panel1.Location;
           //if(picBall.Location <= panel1.Location)
            
           //     {
           //     MessageBox.Show("cannot move");
           //     } 

            picBall.Focus();
        }
    }
}
