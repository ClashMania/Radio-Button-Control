namespace RadioButtonControl
{
    partial class Form1
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
            this.TextOdabir = new System.Windows.Forms.TextBox();
            this.BtnRezerviraj = new System.Windows.Forms.Button();
            this.RbtnVlastiti = new System.Windows.Forms.RadioButton();
            this.RbtnAutobus = new System.Windows.Forms.RadioButton();
            this.RbtnAvion = new System.Windows.Forms.RadioButton();
            this.GrpBox = new System.Windows.Forms.GroupBox();
            this.GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextOdabir
            // 
            this.TextOdabir.Location = new System.Drawing.Point(87, 264);
            this.TextOdabir.Multiline = true;
            this.TextOdabir.Name = "TextOdabir";
            this.TextOdabir.ReadOnly = true;
            this.TextOdabir.Size = new System.Drawing.Size(152, 41);
            this.TextOdabir.TabIndex = 8;
            // 
            // BtnRezerviraj
            // 
            this.BtnRezerviraj.Location = new System.Drawing.Point(87, 200);
            this.BtnRezerviraj.Name = "BtnRezerviraj";
            this.BtnRezerviraj.Size = new System.Drawing.Size(152, 23);
            this.BtnRezerviraj.TabIndex = 7;
            this.BtnRezerviraj.Text = "Rezerviraj";
            this.BtnRezerviraj.UseVisualStyleBackColor = true;
            this.BtnRezerviraj.Click += new System.EventHandler(this.BtnRezerviraj_Click);
            // 
            // RbtnVlastiti
            // 
            this.RbtnVlastiti.AutoSize = true;
            this.RbtnVlastiti.Location = new System.Drawing.Point(19, 67);
            this.RbtnVlastiti.Name = "RbtnVlastiti";
            this.RbtnVlastiti.Size = new System.Drawing.Size(94, 17);
            this.RbtnVlastiti.TabIndex = 2;
            this.RbtnVlastiti.TabStop = true;
            this.RbtnVlastiti.Text = "Vlastiti prijevoz";
            this.RbtnVlastiti.UseVisualStyleBackColor = true;
            // 
            // RbtnAutobus
            // 
            this.RbtnAutobus.AutoSize = true;
            this.RbtnAutobus.Location = new System.Drawing.Point(19, 44);
            this.RbtnAutobus.Name = "RbtnAutobus";
            this.RbtnAutobus.Size = new System.Drawing.Size(64, 17);
            this.RbtnAutobus.TabIndex = 1;
            this.RbtnAutobus.TabStop = true;
            this.RbtnAutobus.Text = "Autobus";
            this.RbtnAutobus.UseVisualStyleBackColor = true;
            // 
            // RbtnAvion
            // 
            this.RbtnAvion.AutoSize = true;
            this.RbtnAvion.Location = new System.Drawing.Point(19, 20);
            this.RbtnAvion.Name = "RbtnAvion";
            this.RbtnAvion.Size = new System.Drawing.Size(52, 17);
            this.RbtnAvion.TabIndex = 0;
            this.RbtnAvion.TabStop = true;
            this.RbtnAvion.Text = "Avion";
            this.RbtnAvion.UseVisualStyleBackColor = true;
            // 
            // GrpBox
            // 
            this.GrpBox.Controls.Add(this.RbtnVlastiti);
            this.GrpBox.Controls.Add(this.RbtnAutobus);
            this.GrpBox.Controls.Add(this.RbtnAvion);
            this.GrpBox.Location = new System.Drawing.Point(68, 70);
            this.GrpBox.Name = "GrpBox";
            this.GrpBox.Size = new System.Drawing.Size(200, 96);
            this.GrpBox.TabIndex = 6;
            this.GrpBox.TabStop = false;
            this.GrpBox.Text = "Odaberite vrstu prijevoza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 388);
            this.Controls.Add(this.TextOdabir);
            this.Controls.Add(this.BtnRezerviraj);
            this.Controls.Add(this.GrpBox);
            this.Name = "Form1";
            this.Text = "Radio Button Control";
            this.GrpBox.ResumeLayout(false);
            this.GrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextOdabir;
        private System.Windows.Forms.Button BtnRezerviraj;
        private System.Windows.Forms.RadioButton RbtnVlastiti;
        private System.Windows.Forms.RadioButton RbtnAutobus;
        private System.Windows.Forms.RadioButton RbtnAvion;
        private System.Windows.Forms.GroupBox GrpBox;
    }
}

