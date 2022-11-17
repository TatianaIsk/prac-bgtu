namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bntYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы довольны своей зп?";
            // 
            // bntYes
            // 
            this.bntYes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntYes.Location = new System.Drawing.Point(59, 84);
            this.bntYes.Name = "bntYes";
            this.bntYes.Size = new System.Drawing.Size(94, 29);
            this.bntYes.TabIndex = 1;
            this.bntYes.Text = "yes";
            this.bntYes.UseVisualStyleBackColor = false;
            this.bntYes.Click += new System.EventHandler(this.bntYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNo.Location = new System.Drawing.Point(199, 84);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(94, 29);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "no";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            this.btnNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNo_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 149);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.bntYes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Насущный Вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bntYes;
        private Button btnNo;
    }
}