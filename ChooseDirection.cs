using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inteferente_ECO
{
    public partial class ChooseDirection : Form
    {
        public ChooseDirection()
        {
            InitializeComponent();
        }

        private void DownButton_Click_1(object sender, EventArgs e)
        {
            Context.Direction = "Down";
            Dispose();
        }

        private void LeftButton_Click_1(object sender, EventArgs e)
        {
            Context.Direction = "Left";
            Dispose();
        }

        private void RightButton_Click_1(object sender, EventArgs e)
        {
            Context.Direction = "Right";
            Dispose();
        }

        private void UpButton_Click_1(object sender, EventArgs e)
        {
            Context.Direction = "Up";
            Dispose();
        }
    }
}
