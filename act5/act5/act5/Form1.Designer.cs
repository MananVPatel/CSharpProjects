namespace act5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.totalAssociate = new System.Windows.Forms.Label();
            this.totalFull = new System.Windows.Forms.Label();
            this.totalPart = new System.Windows.Forms.Label();
            this.totalNew = new System.Windows.Forms.Label();
            this.totalUsed = new System.Windows.Forms.Label();
            this.numAssociate = new System.Windows.Forms.Label();
            this.numFull = new System.Windows.Forms.Label();
            this.numPart = new System.Windows.Forms.Label();
            this.numNew = new System.Windows.Forms.Label();
            this.numUsed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales by Full Time Sales Associates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales by Part Time Sales Associates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sales by New Car Sales Associates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sales by Used Car Sales Associates";
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(59, 60);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(75, 23);
            this.bCalc.TabIndex = 4;
            this.bCalc.Text = "Calculate";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(48, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 20);
            this.txtID.TabIndex = 6;
            // 
            // totalAssociate
            // 
            this.totalAssociate.AutoSize = true;
            this.totalAssociate.Location = new System.Drawing.Point(336, 23);
            this.totalAssociate.Name = "totalAssociate";
            this.totalAssociate.Size = new System.Drawing.Size(0, 13);
            this.totalAssociate.TabIndex = 7;
            // 
            // totalFull
            // 
            this.totalFull.AutoSize = true;
            this.totalFull.Location = new System.Drawing.Point(336, 111);
            this.totalFull.Name = "totalFull";
            this.totalFull.Size = new System.Drawing.Size(35, 13);
            this.totalFull.TabIndex = 8;
            this.totalFull.Text = "label7";
            // 
            // totalPart
            // 
            this.totalPart.AutoSize = true;
            this.totalPart.Location = new System.Drawing.Point(336, 141);
            this.totalPart.Name = "totalPart";
            this.totalPart.Size = new System.Drawing.Size(35, 13);
            this.totalPart.TabIndex = 9;
            this.totalPart.Text = "label8";
            // 
            // totalNew
            // 
            this.totalNew.AutoSize = true;
            this.totalNew.Location = new System.Drawing.Point(336, 173);
            this.totalNew.Name = "totalNew";
            this.totalNew.Size = new System.Drawing.Size(35, 13);
            this.totalNew.TabIndex = 10;
            this.totalNew.Text = "label9";
            // 
            // totalUsed
            // 
            this.totalUsed.AutoSize = true;
            this.totalUsed.Location = new System.Drawing.Point(336, 206);
            this.totalUsed.Name = "totalUsed";
            this.totalUsed.Size = new System.Drawing.Size(41, 13);
            this.totalUsed.TabIndex = 11;
            this.totalUsed.Text = "label10";
            // 
            // numAssociate
            // 
            this.numAssociate.AutoSize = true;
            this.numAssociate.Location = new System.Drawing.Point(245, 23);
            this.numAssociate.Name = "numAssociate";
            this.numAssociate.Size = new System.Drawing.Size(0, 13);
            this.numAssociate.TabIndex = 12;
            // 
            // numFull
            // 
            this.numFull.AutoSize = true;
            this.numFull.Location = new System.Drawing.Point(245, 111);
            this.numFull.Name = "numFull";
            this.numFull.Size = new System.Drawing.Size(41, 13);
            this.numFull.TabIndex = 13;
            this.numFull.Text = "label12";
            // 
            // numPart
            // 
            this.numPart.AutoSize = true;
            this.numPart.Location = new System.Drawing.Point(245, 141);
            this.numPart.Name = "numPart";
            this.numPart.Size = new System.Drawing.Size(41, 13);
            this.numPart.TabIndex = 14;
            this.numPart.Text = "label13";
            // 
            // numNew
            // 
            this.numNew.AutoSize = true;
            this.numNew.Location = new System.Drawing.Point(245, 173);
            this.numNew.Name = "numNew";
            this.numNew.Size = new System.Drawing.Size(41, 13);
            this.numNew.TabIndex = 15;
            this.numNew.Text = "label14";
            // 
            // numUsed
            // 
            this.numUsed.AutoSize = true;
            this.numUsed.Location = new System.Drawing.Point(245, 206);
            this.numUsed.Name = "numUsed";
            this.numUsed.Size = new System.Drawing.Size(41, 13);
            this.numUsed.TabIndex = 16;
            this.numUsed.Text = "label15";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(302, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(431, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numUsed);
            this.Controls.Add(this.numNew);
            this.Controls.Add(this.numPart);
            this.Controls.Add(this.numFull);
            this.Controls.Add(this.numAssociate);
            this.Controls.Add(this.totalUsed);
            this.Controls.Add(this.totalNew);
            this.Controls.Add(this.totalPart);
            this.Controls.Add(this.totalFull);
            this.Controls.Add(this.totalAssociate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "O. Dewey Cheatam Motors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label totalAssociate;
        private System.Windows.Forms.Label totalFull;
        private System.Windows.Forms.Label totalPart;
        private System.Windows.Forms.Label totalNew;
        private System.Windows.Forms.Label totalUsed;
        private System.Windows.Forms.Label numAssociate;
        private System.Windows.Forms.Label numFull;
        private System.Windows.Forms.Label numPart;
        private System.Windows.Forms.Label numNew;
        private System.Windows.Forms.Label numUsed;
        private System.Windows.Forms.Button button1;
    }
}

