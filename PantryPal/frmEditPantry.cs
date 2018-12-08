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
    public partial class frmEditPantry : Form
    {
        public frmEditPantry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPanItem1.Text != "" && !Program.pantryItems.Contains(txtPanItem1.Text))
                Program.pantryItems.Add(txtPanItem1.Text);
            if (txtPanItem2.Text != "" && !Program.pantryItems.Contains(txtPanItem2.Text))
                Program.pantryItems.Add(txtPanItem2.Text);
            if (txtPanItem3.Text != "" && !Program.pantryItems.Contains(txtPanItem3.Text))
                Program.pantryItems.Add(txtPanItem3.Text);
            if (txtPanItem4.Text != "" && !Program.pantryItems.Contains(txtPanItem4.Text))
                Program.pantryItems.Add(txtPanItem4.Text);
            if (txtPanItem5.Text != "" && !Program.pantryItems.Contains(txtPanItem5.Text))
                Program.pantryItems.Add(txtPanItem5.Text);
            if (txtPanItem6.Text != "" && !Program.pantryItems.Contains(txtPanItem6.Text))
                Program.pantryItems.Add(txtPanItem6.Text);
            if (txtPanItem7.Text != "" && !Program.pantryItems.Contains(txtPanItem7.Text))
                Program.pantryItems.Add(txtPanItem7.Text);
            if (txtPanItem8.Text != "" && !Program.pantryItems.Contains(txtPanItem8.Text))
                Program.pantryItems.Add(txtPanItem8.Text);
            if (txtPanItem9.Text != "" && !Program.pantryItems.Contains(txtPanItem9.Text))
                Program.pantryItems.Add(txtPanItem9.Text);

            tblPantryItems.Items.Clear();



            for (int i = 0; i < Program.pantryItems.Count; i++)
            {
               tblPantryItems.Items.Add(Program.pantryItems[i].ToString());
            }

            txtPanItem1.Clear();
            txtPanItem2.Clear();
            txtPanItem3.Clear();
            txtPanItem4.Clear();
            txtPanItem5.Clear();
            txtPanItem6.Clear();
            txtPanItem7.Clear();
            txtPanItem8.Clear();
            txtPanItem9.Clear();
        }

        private void frmEditPantry_Load(object sender, EventArgs e)
        {
            tblPantryItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;

            for (int i = 0; i < Program.pantryItems.Count; i++)
            {
                tblPantryItems.Items.Add(Program.pantryItems[i].ToString());
            }

            tblPantryItems.Refresh();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            
        }
    }
}
