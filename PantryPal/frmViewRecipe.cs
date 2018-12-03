using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantryPal
{
    public partial class frmViewRecipe : Form
    {
        public frmViewRecipe()
        {
            InitializeComponent();
        }

        private void frmViewRecipe_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseViewWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
