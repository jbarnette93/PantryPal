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
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnEditPantry_Click(object sender, EventArgs e)
        {
            frmEditPantry EditWindow = new frmEditPantry();
            EditWindow.Show();
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            frmViewRecipe ViewRecipeWin = new frmViewRecipe();
            ViewRecipeWin.Show();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            frmAddRecipe AddRecipeWin = new frmAddRecipe();
            AddRecipeWin.Show();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            lstPantry.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
        }
    }
}
