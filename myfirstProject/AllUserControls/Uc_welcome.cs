using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstProject.AllUserControls
{
    public partial class Uc_welcome : UserControl
    {
        public Uc_welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            {
                if (num == 0)
                {
                    Caltxt.Location = new Point(3, 383);
                    Caltxt.ForeColor = Color.Blue;
                    num++;
                }
                else if (num == 1)
                {
                    Caltxt.Location = new Point(141, 383);
                    Caltxt.ForeColor = Color.Green;
                    num++;
                }
                else if (num == 2)
                {
                    Caltxt.Location = new Point(221, 383);
                    Caltxt.ForeColor = Color.Blue;
                    num++;
                }
                else if (num == 3)
                {
                    Caltxt.Location = new Point(351, 383);
                    Caltxt.ForeColor = Color.Green;
                    num++;
                }
                else
                {
                    Caltxt.Location = new Point(424, 383);
                    Caltxt.ForeColor = Color.Blue;
                    num=0;
                }
            }
        }

        private void Uc_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
