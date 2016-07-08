namespace Act15_ControlLibrary
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bEval = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rIP = new System.Windows.Forms.RadioButton();
            this.rPart = new System.Windows.Forms.RadioButton();
            this.rEmail = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkValid = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bEval
            // 
            this.bEval.Location = new System.Drawing.Point(35, 123);
            this.bEval.Name = "bEval";
            this.bEval.Size = new System.Drawing.Size(107, 23);
            this.bEval.TabIndex = 0;
            this.bEval.Text = "Evaluate";
            this.bEval.UseVisualStyleBackColor = true;
            this.bEval.Click += new System.EventHandler(this.bEval_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rIP);
            this.panel1.Controls.Add(this.rPart);
            this.panel1.Controls.Add(this.rEmail);
            this.panel1.Location = new System.Drawing.Point(294, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 140);
            this.panel1.TabIndex = 5;
            // 
            // rIP
            // 
            this.rIP.AutoSize = true;
            this.rIP.Location = new System.Drawing.Point(16, 81);
            this.rIP.Name = "rIP";
            this.rIP.Size = new System.Drawing.Size(76, 17);
            this.rIP.TabIndex = 2;
            this.rIP.TabStop = true;
            this.rIP.Text = "IP Address";
            this.rIP.UseVisualStyleBackColor = true;
            // 
            // rPart
            // 
            this.rPart.AutoSize = true;
            this.rPart.Location = new System.Drawing.Point(16, 58);
            this.rPart.Name = "rPart";
            this.rPart.Size = new System.Drawing.Size(84, 17);
            this.rPart.TabIndex = 1;
            this.rPart.TabStop = true;
            this.rPart.Text = "Part Number";
            this.rPart.UseVisualStyleBackColor = true;
            // 
            // rEmail
            // 
            this.rEmail.AutoSize = true;
            this.rEmail.Location = new System.Drawing.Point(16, 35);
            this.rEmail.Name = "rEmail";
            this.rEmail.Size = new System.Drawing.Size(91, 17);
            this.rEmail.TabIndex = 0;
            this.rEmail.TabStop = true;
            this.rEmail.Text = "Email Address";
            this.rEmail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item to Evaluate:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // chkValid
            // 
            this.chkValid.AutoSize = true;
            this.chkValid.Location = new System.Drawing.Point(177, 123);
            this.chkValid.Name = "chkValid";
            this.chkValid.Size = new System.Drawing.Size(90, 17);
            this.chkValid.TabIndex = 8;
            this.chkValid.Text = "ItemValidated";
            this.chkValid.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkValid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bEval);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(464, 307);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEval;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rIP;
        private System.Windows.Forms.RadioButton rPart;
        private System.Windows.Forms.RadioButton rEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkValid;
    }
}
