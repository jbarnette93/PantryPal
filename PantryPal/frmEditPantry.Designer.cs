namespace PantryPal
{
    partial class frmEditPantry
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
            this.lblAddItems = new System.Windows.Forms.Label();
            this.lblDeleteItems = new System.Windows.Forms.Label();
            this.tblPantryItems = new System.Windows.Forms.ListView();
            this.txtPanItem1 = new System.Windows.Forms.TextBox();
            this.txtPanItem7 = new System.Windows.Forms.TextBox();
            this.txtPanItem6 = new System.Windows.Forms.TextBox();
            this.txtPanItem5 = new System.Windows.Forms.TextBox();
            this.txtPanItem4 = new System.Windows.Forms.TextBox();
            this.txtPanItem3 = new System.Windows.Forms.TextBox();
            this.txtPanItem2 = new System.Windows.Forms.TextBox();
            this.txtPanItem9 = new System.Windows.Forms.TextBox();
            this.txtPanItem8 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.colPantyItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.Location = new System.Drawing.Point(26, 37);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(57, 13);
            this.lblAddItems.TabIndex = 0;
            this.lblAddItems.Text = "Add Items:";
            // 
            // lblDeleteItems
            // 
            this.lblDeleteItems.AutoSize = true;
            this.lblDeleteItems.Location = new System.Drawing.Point(256, 37);
            this.lblDeleteItems.Name = "lblDeleteItems";
            this.lblDeleteItems.Size = new System.Drawing.Size(69, 13);
            this.lblDeleteItems.TabIndex = 1;
            this.lblDeleteItems.Text = "Delete Items:";
            // 
            // tblPantryItems
            // 
            this.tblPantryItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPantyItems});
            this.tblPantryItems.Location = new System.Drawing.Point(259, 53);
            this.tblPantryItems.Name = "tblPantryItems";
            this.tblPantryItems.Size = new System.Drawing.Size(181, 244);
            this.tblPantryItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.tblPantryItems.TabIndex = 2;
            this.tblPantryItems.UseCompatibleStateImageBehavior = false;
            this.tblPantryItems.View = System.Windows.Forms.View.Details;
            // 
            // txtPanItem1
            // 
            this.txtPanItem1.Location = new System.Drawing.Point(29, 61);
            this.txtPanItem1.Name = "txtPanItem1";
            this.txtPanItem1.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem1.TabIndex = 3;
            // 
            // txtPanItem7
            // 
            this.txtPanItem7.Location = new System.Drawing.Point(29, 217);
            this.txtPanItem7.Name = "txtPanItem7";
            this.txtPanItem7.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem7.TabIndex = 9;
            // 
            // txtPanItem6
            // 
            this.txtPanItem6.Location = new System.Drawing.Point(29, 191);
            this.txtPanItem6.Name = "txtPanItem6";
            this.txtPanItem6.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem6.TabIndex = 8;
            // 
            // txtPanItem5
            // 
            this.txtPanItem5.Location = new System.Drawing.Point(29, 165);
            this.txtPanItem5.Name = "txtPanItem5";
            this.txtPanItem5.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem5.TabIndex = 7;
            // 
            // txtPanItem4
            // 
            this.txtPanItem4.Location = new System.Drawing.Point(29, 139);
            this.txtPanItem4.Name = "txtPanItem4";
            this.txtPanItem4.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem4.TabIndex = 6;
            // 
            // txtPanItem3
            // 
            this.txtPanItem3.Location = new System.Drawing.Point(29, 113);
            this.txtPanItem3.Name = "txtPanItem3";
            this.txtPanItem3.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem3.TabIndex = 5;
            // 
            // txtPanItem2
            // 
            this.txtPanItem2.Location = new System.Drawing.Point(29, 87);
            this.txtPanItem2.Name = "txtPanItem2";
            this.txtPanItem2.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem2.TabIndex = 4;
            // 
            // txtPanItem9
            // 
            this.txtPanItem9.Location = new System.Drawing.Point(29, 269);
            this.txtPanItem9.Name = "txtPanItem9";
            this.txtPanItem9.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem9.TabIndex = 11;
            // 
            // txtPanItem8
            // 
            this.txtPanItem8.Location = new System.Drawing.Point(29, 243);
            this.txtPanItem8.Name = "txtPanItem8";
            this.txtPanItem8.Size = new System.Drawing.Size(153, 20);
            this.txtPanItem8.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add To Pantry";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Location = new System.Drawing.Point(259, 316);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveItems.TabIndex = 14;
            this.btnRemoveItems.Text = "Remove From Pantry";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(167, 386);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close Window ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colPantyItems
            // 
            this.colPantyItems.Text = "Items In Pantry:";
            this.colPantyItems.Width = 160;
            // 
            // frmEditPantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPanItem8);
            this.Controls.Add(this.txtPanItem9);
            this.Controls.Add(this.txtPanItem2);
            this.Controls.Add(this.txtPanItem3);
            this.Controls.Add(this.txtPanItem4);
            this.Controls.Add(this.txtPanItem5);
            this.Controls.Add(this.txtPanItem6);
            this.Controls.Add(this.txtPanItem7);
            this.Controls.Add(this.txtPanItem1);
            this.Controls.Add(this.tblPantryItems);
            this.Controls.Add(this.lblDeleteItems);
            this.Controls.Add(this.lblAddItems);
            this.Name = "frmEditPantry";
            this.Text = "frmEditPantry";
            this.Load += new System.EventHandler(this.frmEditPantry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.Label lblDeleteItems;
        private System.Windows.Forms.ListView tblPantryItems;
        private System.Windows.Forms.TextBox txtPanItem1;
        private System.Windows.Forms.TextBox txtPanItem7;
        private System.Windows.Forms.TextBox txtPanItem6;
        private System.Windows.Forms.TextBox txtPanItem5;
        private System.Windows.Forms.TextBox txtPanItem4;
        private System.Windows.Forms.TextBox txtPanItem3;
        private System.Windows.Forms.TextBox txtPanItem2;
        private System.Windows.Forms.TextBox txtPanItem9;
        private System.Windows.Forms.TextBox txtPanItem8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader colPantyItems;
    }
}