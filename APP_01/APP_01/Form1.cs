using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string box_value = txt_age.Text; // get the edad through the box
            int age = Int32.Parse(box_value); // convert the string value of the box in a int value
            bool check = age > 18; // the condicion

            if (check)
            {
                txt_1.Text = "the user is an adult";
            }
            else
            {
                txt_1.Text = "the user is a younger";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string text_label = "Oh!" + " Haz dado Click al Texto" + "  y FUNCIONA!!!!!";
            button1.Text = text_label;
        }
    }
}
