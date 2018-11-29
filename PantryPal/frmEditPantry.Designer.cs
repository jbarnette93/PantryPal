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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
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
            this.tblPantryItems.Location = new System.Drawing.Point(259, 53);
            this.tblPantryItems.Name = "tblPantryItems";
            this.tblPantryItems.Size = new System.Drawing.Size(181, 244);
            this.tblPantryItems.TabIndex = 2;
            this.tblPantryItems.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 165);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(29, 139);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(153, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(29, 113);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(153, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(29, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(153, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(29, 269);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 20);
            this.textBox9.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(29, 243);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 20);
            this.textBox10.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add To Pantry";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Location = new System.Drawing.Point(259, 316);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(130, 23);
            this.btnRemoveItems.TabIndex = 14;
            this.btnRemoveItems.Text = "Remove From Pantry";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            // 
            // frmEditPantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 445);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tblPantryItems);
            this.Controls.Add(this.lblDeleteItems);
            this.Controls.Add(this.lblAddItems);
            this.Name = "frmEditPantry";
            this.Text = "frmEditPantry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.Label lblDeleteItems;
        private System.Windows.Forms.ListView tblPantryItems;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveItems;
    }
}