using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class SalesControl : UserControl
    {
        public SalesControl()
        {
            InitializeComponent();
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            Form1.mente.Visible = true;
            Form1.sale.Visible = false;
        }
    }
}
