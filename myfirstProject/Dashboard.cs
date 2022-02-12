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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if(user== "Guest")
            {
                btnAddItems.Hide();
                btnupdateItems.Hide();
                btnRemoveItems.Hide();

            }
            else if(user=="Admin")
            {
                btnAddItems.Show();
                btnupdateItems.Show();
                btnRemoveItems.Show();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uc_RemoveItems1.Visible = false;
        }

        private void btnplaceOrder_Click(object sender, EventArgs e)
        {
            uc_welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnupdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uc_RemoveItems1.Visible = true;
            uc_RemoveItems1.BringToFront();
        }
    }
}
