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
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_thing1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_thing1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text box number 1 hold the value :"+txt_thing1 +"\n"+ "text box number 1 hold the value :" + txt_thing2 );
            string holder_value = txt_thing1.Text;
            txt_thing1.Text = txt_thing2.Text;
            txt_thing2.Text = holder_value;
            MessageBox.Show("text box number 1 hold the value :" + txt_thing1 + "\n" + "text box number 1 hold the value :" + txt_thing2);

        }
    }
}
