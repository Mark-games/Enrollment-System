using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edp_enrollment
{
    public partial class Enrollees : Form
    {
        public Enrollees()
        {
            InitializeComponent();
        }

        private void close4_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back2_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back2 = new Dashboard();
            back2.Show();
        }
    }
}
