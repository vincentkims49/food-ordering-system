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
   
    public partial class Uc_RemoveItems : UserControl
    {
        function fn = new function();
        String query;
        public Uc_RemoveItems()
        {
            InitializeComponent();
        }

        private void Uc_RemoveItems_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE?";
            DelLabel.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds=fn.getData(query);
            guna2DataGrid.DataSource = ds.Tables[0];


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGrid.DataSource = ds.Tables[0];
        }

        private void guna2DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("DELETE Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where iid =" + id + "";
                fn.SetData(query);
                loadData();
            }
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "Click on Row To Delete An Item.";
        }

        private void Uc_RemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
