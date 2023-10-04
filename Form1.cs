using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RbtnAvion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnRezerviraj_Click(object sender, EventArgs e)
        {
            TextOdabir.Clear();

            if (RbtnAutobus.Checked)
            {
                TextOdabir.AppendText("Odabrali ste prijevoz autobusom.");
            }
            if (RbtnAvion.Checked)
            {
                TextOdabir.AppendText("Odabrali ste prijevoz avionom.");
            }
            if (RbtnVlastiti.Checked)
            {
                TextOdabir.AppendText("Odabrali ste prijevoz vlastitim vozilom.");
            }
        }
    }
}
