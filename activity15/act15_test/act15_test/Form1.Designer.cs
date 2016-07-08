namespace act15_test
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
            this.bProcess = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.userControl11 = new Act15_ControlLibrary.UserControl1();
            this.SuspendLayout();
            // 
            // bProcess
            // 
            this.bProcess.Location = new System.Drawing.Point(53, 356);
            this.bProcess.Name = "bProcess";
            this.bProcess.Size = new System.Drawing.Size(114, 23);
            this.bProcess.TabIndex = 1;
            this.bProcess.Text = "Process";
            this.bProcess.UseVisualStyleBackColor = true;
            this.bProcess.Click += new System.EventHandler(this.bProcess_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(199, 356);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(141, 23);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(544, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 225);
            this.listBox1.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(42, 26);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(464, 307);
            this.userControl11.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 401);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bProcess;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.ListBox listBox1;
        private Act15_ControlLibrary.UserControl1 userControl11;
    }
}

