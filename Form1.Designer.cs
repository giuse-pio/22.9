namespace _22._9
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.btmArea = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btmClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(119, 101);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(66, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(191, 101);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(66, 20);
            this.txtAltezza.TabIndex = 1;
            // 
            // btmArea
            // 
            this.btmArea.Location = new System.Drawing.Point(136, 127);
            this.btmArea.Name = "btmArea";
            this.btmArea.Size = new System.Drawing.Size(105, 36);
            this.btmArea.TabIndex = 3;
            this.btmArea.Text = "calcola area";
            this.btmArea.UseVisualStyleBackColor = true;
            this.btmArea.Click += new System.EventHandler(this.btmArea_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(292, 104);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "altezza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "area";
            // 
            // btmClear
            // 
            this.btmClear.Location = new System.Drawing.Point(62, 133);
            this.btmClear.Name = "btmClear";
            this.btmClear.Size = new System.Drawing.Size(46, 25);
            this.btmClear.TabIndex = 8;
            this.btmClear.Text = "pulisci";
            this.btmClear.UseVisualStyleBackColor = true;
            this.btmClear.Click += new System.EventHandler(this.btmClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 235);
            this.Controls.Add(this.btmClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btmArea);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Button btmArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmClear;
    }
}

