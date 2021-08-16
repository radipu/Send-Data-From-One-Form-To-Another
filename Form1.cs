using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToAnotherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(txtValue.Text);
            frm.ShowDialog();
        }

        //private void btnSend2_Click(object sender, EventArgs e)
        //{
        //    Form2 frm = new Form2();
        //    frm.Value = txtValue.Text;
        //    frm.ShowDialog();
        //}
    }
}
