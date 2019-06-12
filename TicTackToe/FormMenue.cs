using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTackToe
{
    public partial class FormMenue : Form
    {
        public FormMenue()
        {
            InitializeComponent();
        }

        private void buttonStartPvsP_Click(object sender, EventArgs e)
        {
            FormGamefield form = new FormGamefield(this);
            form.Show();
            this.Visible = false;
        }
    }
}
