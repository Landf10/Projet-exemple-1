using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "admin" && txt_user.Text == "admin")
            {
                Form2 formullaire = new Form2();
                formullaire.Show();
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
