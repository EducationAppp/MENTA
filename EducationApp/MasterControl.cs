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
    public partial class MasterControl : UserControl
    {
        public MasterControl()
        {
            InitializeComponent();
        }

        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            Form1.mente.Visible = false;
            Form1.sale.Visible = true;
        }
    }
}
