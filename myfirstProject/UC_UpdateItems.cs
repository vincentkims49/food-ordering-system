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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
           
            loadData();

        }
        public void loadData()
        {
            query = "select * from Items";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Items where name like '"+txtSearchItem.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }
        int id;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int v = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            id = v;
            string category = guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name= guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name='" + txtName.Text + "',category='" + txtCategory.Text + "',price='" + txtPrice.Text + "' where iid ='" + id + "'";
            fn.SetData(query);
            loadData();

            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();

        }
    } 
}
