namespace PantryPal
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPantry = new System.Windows.Forms.Label();
            this.lstPantry = new System.Windows.Forms.ListView();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnViewRecipe = new System.Windows.Forms.Button();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnEditPantry = new System.Windows.Forms.Button();
            this.items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblPantry
            // 
            this.lblPantry.AutoSize = true;
            this.lblPantry.Location = new System.Drawing.Point(45, 34);
            this.lblPantry.Name = "lblPantry";
            this.lblPantry.Size = new System.Drawing.Size(65, 13);
            this.lblPantry.TabIndex = 0;
            this.lblPantry.Text = "Your Pantry:";
            // 
            // lstPantry
            // 
            this.lstPantry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.items});
            this.lstPantry.Location = new System.Drawing.Point(48, 63);
            this.lstPantry.Name = "lstPantry";
            this.lstPantry.Size = new System.Drawing.Size(181, 244);
            this.lstPantry.TabIndex = 1;
            this.lstPantry.UseCompatibleStateImageBehavior = false;
            this.lstPantry.View = System.Windows.Forms.View.Details;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(372, 34);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(123, 13);
            this.lblRecipes.TabIndex = 2;
            this.lblRecipes.Text = "Recipes You Can Make:";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Control;
            this.listView2.Location = new System.Drawing.Point(375, 63);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(169, 244);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewRecipe
            // 
            this.btnViewRecipe.Location = new System.Drawing.Point(375, 327);
            this.btnViewRecipe.Name = "btnViewRecipe";
            this.btnViewRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnViewRecipe.TabIndex = 4;
            this.btnViewRecipe.Text = "View Recipe";
            this.btnViewRecipe.UseVisualStyleBackColor = true;
            this.btnViewRecipe.Click += new System.EventHandler(this.btnViewRecipe_Click);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(469, 327);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 5;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnEditPantry
            // 
            this.btnEditPantry.Location = new System.Drawing.Point(48, 327);
            this.btnEditPantry.Name = "btnEditPantry";
            this.btnEditPantry.Size = new System.Drawing.Size(94, 23);
            this.btnEditPantry.TabIndex = 6;
            this.btnEditPantry.Text = "Edit Pantry";
            this.btnEditPantry.UseVisualStyleBackColor = true;
            this.btnEditPantry.Click += new System.EventHandler(this.btnEditPantry_Click);
            // 
            // items
            // 
            this.items.Text = "Items in Pantry:";
            this.items.Width = 150;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 441);
            this.Controls.Add(this.btnEditPantry);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.btnViewRecipe);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.lstPantry);
            this.Controls.Add(this.lblPantry);
            this.Name = "frmMainWindow";
            this.Text = "PantryPal";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPantry;
        private System.Windows.Forms.ListView lstPantry;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnViewRecipe;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnEditPantry;
        private System.Windows.Forms.ColumnHeader items;
    }
}