namespace PetDatabasProjekt
{
    partial class PetInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 192);
            this.panel1.TabIndex = 0;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(48, 95);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(213, 65);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add pet";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtPhonenumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBreed);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSize);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(32, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 728);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(94, 605);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 53);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(94, 470);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(362, 31);
            this.txtPhonenumber.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "PhoneNumber";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(94, 383);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(362, 31);
            this.txtBreed.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Breed:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(94, 308);
            this.txtColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(362, 31);
            this.txtColor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Color:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(94, 223);
            this.txtSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(362, 31);
            this.txtSize.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(94, 152);
            this.txtType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(362, 31);
            this.txtType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 1288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PetInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label label6;
    }
}