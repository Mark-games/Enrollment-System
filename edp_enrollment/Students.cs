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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void close9_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studback_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard back7 = new Dashboard();
            back7.Show();
        }
    }
}
