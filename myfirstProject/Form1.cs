using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstProject
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContinueasGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Dashboard dash = new Dashboard("Guest");
            dash.Show();
            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            LoginAdmin la = new LoginAdmin();
            la.Show();
            this.Hide();
        }
    }
}
