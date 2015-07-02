using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Booker_9000
{
    public partial class frmBookingSeatPlanner : Form
    {
        public frmBookingSeatPlanner()
        {
            InitializeComponent();
        }

        private void btnPlaceOne_Click(object sender, EventArgs e)
        {
            if(btnPlaceOne.BackColor == Color.Lime)
            {
                btnPlaceOne.BackColor = Color.White;
                btnPlaceOne.Text = "B";
            }
            else
            {
                btnPlaceOne.BackColor = Color.Lime;
                btnPlaceOne.Text = "1";
            }
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Lime)
            {
                button2.BackColor = Color.White;
                button2.Text = "B";
            }
            else
            {
                button2.BackColor = Color.Lime;
                button2.Text = "2";
            }
       }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Lime)
            {
                button4.BackColor = Color.White;
                button4.Text = "B";
            }
            else
            {
                button4.BackColor = Color.Lime;
                button4.Text = "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Lime)
            {
                button3.BackColor = Color.White;
                button3.Text = "B";
            }
            else
            {
                button3.BackColor = Color.Lime;
                button3.Text = "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Lime)
            {
                button8.BackColor = Color.White;
                button8.Text = "B";
            }
            else
            {
                button8.BackColor = Color.Lime;
                button8.Text = "5";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Lime)
            {
                button23.BackColor = Color.White;
                button23.Text = "B";
            }
            else
            {
                button23.BackColor = Color.Lime;
                button23.Text = "1";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Lime)
            {
                button22.BackColor = Color.White;
                button22.Text = "B";
            }
            else
            {
                button22.BackColor = Color.Lime;
                button22.Text = "2";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Lime)
            {
                button21.BackColor = Color.White;
                button21.Text = "B";
            }
            else
            {
                button21.BackColor = Color.Lime;
                button21.Text = "3";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.Lime)
            {
                button35.BackColor = Color.White;
                button35.Text = "B";
            }
            else
            {
                button35.BackColor = Color.Lime;
                button35.Text = "1";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.Lime)
            {
                button34.BackColor = Color.White;
                button34.Text = "B";
            }
            else
            {
                button34.BackColor = Color.Lime;
                button34.Text = "2";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Lime)
            {
                button33.BackColor = Color.White;
                button33.Text = "B";
            }
            else
            {
                button33.BackColor = Color.Lime;
                button33.Text = "3";
            }
        }
    }
}
