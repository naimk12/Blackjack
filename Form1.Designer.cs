namespace KortspelDemo
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
            this.buOK = new System.Windows.Forms.Button();
            this.tbFarg = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.buEXIT = new System.Windows.Forms.Button();
            this.buPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buOK
            // 
            this.buOK.Location = new System.Drawing.Point(105, 64);
            this.buOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buOK.Name = "buOK";
            this.buOK.Size = new System.Drawing.Size(89, 46);
            this.buOK.TabIndex = 0;
            this.buOK.Text = "Choose card";
            this.buOK.UseVisualStyleBackColor = true;
            this.buOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFarg
            // 
            this.tbFarg.Location = new System.Drawing.Point(11, 10);
            this.tbFarg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFarg.Name = "tbFarg";
            this.tbFarg.Size = new System.Drawing.Size(89, 22);
            this.tbFarg.TabIndex = 1;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(105, 10);
            this.tbValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(89, 22);
            this.tbValor.TabIndex = 2;
            // 
            // buEXIT
            // 
            this.buEXIT.Location = new System.Drawing.Point(12, 64);
            this.buEXIT.Name = "buEXIT";
            this.buEXIT.Size = new System.Drawing.Size(87, 46);
            this.buEXIT.TabIndex = 3;
            this.buEXIT.Text = "Exit";
            this.buEXIT.UseVisualStyleBackColor = true;
            this.buEXIT.Click += new System.EventHandler(this.buEXIT_Click);
            // 
            // buPicture
            // 
            this.buPicture.Location = new System.Drawing.Point(292, 145);
            this.buPicture.Name = "buPicture";
            this.buPicture.Size = new System.Drawing.Size(75, 45);
            this.buPicture.TabIndex = 4;
            this.buPicture.Text = "Show picture";
            this.buPicture.UseVisualStyleBackColor = true;
            this.buPicture.Click += new System.EventHandler(this.buPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(228, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 129);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(334, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 129);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 343);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buPicture);
            this.Controls.Add(this.buEXIT);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbFarg);
            this.Controls.Add(this.buOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buOK;
        private System.Windows.Forms.TextBox tbFarg;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button buEXIT;
        private System.Windows.Forms.Button buPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

