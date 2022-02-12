
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;




namespace myfirstProject.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
        {
            function fn = new function();
            String query;
            public UC_PlaceOrder()
            {
                InitializeComponent();
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                String category = comboCategory.Text;
                query = "select Name from Items where Category='" + category + "'";
                showItemList(query);
            }

            private void txtSearch_TextChanged(object sender, EventArgs e)
            {

                String category = comboCategory.Text;
                query = "select Name from Items where Category='" + category + "'and name like'" + txtSearch.Text + "%'";
                showItemList(query);

            }

            private void showItemList(String query)
            {
                listBox1.Items.Clear();
                DataSet ds = fn.getData(query);

                int i;
                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                txtQuantityUpDown.ResetText();
                txtTotal.Clear();

                string txt = listBox1.GetItemText(listBox1.SelectedItem);
                txtItemName.Text = txt;

                query = "select price from Items where name='" + txt + "'";
                DataSet ds = fn.getData(query);

                try
                {
                    txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
                }
                catch { }
            }

            private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
            {
                Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
                Int64 price = Int64.Parse(txtPrice.Text);
                txtTotal.Text = (quan * price).ToString();
            }

            int amount;
            private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    amount = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                catch { }
            }

            private void btnRemove_Click(object sender, EventArgs e)
            {
                try
                {
                    guna2DataGridView3.Rows.RemoveAt(this.guna2DataGridView3.SelectedRows[0].Index);
                    total -= amount;
                    labelTotalAmount.Text = "KSh. " + total;
                }
                catch { }
                



        }

            protected int n, total = 0;

        private void btnPrint_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(labelTotalAmount.Text != "KSh. 0" && labelTotalAmount.Text !="")
            {
                MessageBox.Show("Order Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    guna2DataGridView3.Rows.Clear();
                }
                catch { }

                total = 0;
                labelTotalAmount.Text = "KSh. "+total;

            }
            else 
            {
                MessageBox.Show("Add Items To Cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {
            if (total < 1)
            {
                total = 0;
                labelTotalAmount.Text = "KSh. " + total;
            }
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
            {
                if (txtTotal.Text != "0" && txtTotal.Text != "")
                {

                    n = guna2DataGridView3.Rows.Add();
                    guna2DataGridView3.Rows[n].Cells[0].Value = txtItemName.Text;
                    guna2DataGridView3.Rows[n].Cells[1].Value = txtPrice.Text;
                    guna2DataGridView3.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                    guna2DataGridView3.Rows[n].Cells[3].Value = txtTotal.Text;

                    total = total + int.Parse(txtTotal.Text);
                    labelTotalAmount.Text = "KSh. " + total;
                }
                else
                {
                    MessageBox.Show("Minimum Quantity should be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }


