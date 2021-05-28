
namespace PDF_Watermark
{
    partial class Watermark_Form
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
            this.Watermark_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.Password_CheckBox = new System.Windows.Forms.CheckBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // Watermark_TextBox
            // 
            this.Watermark_TextBox.Location = new System.Drawing.Point(104, 6);
            this.Watermark_TextBox.Name = "Watermark_TextBox";
            this.Watermark_TextBox.Size = new System.Drawing.Size(154, 20);
            this.Watermark_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Watermark Text:";
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(182, 57);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(76, 26);
            this.Go.TabIndex = 2;
            this.Go.Text = "Watermark";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Password_CheckBox
            // 
            this.Password_CheckBox.AutoSize = true;
            this.Password_CheckBox.Location = new System.Drawing.Point(15, 33);
            this.Password_CheckBox.Name = "Password_CheckBox";
            this.Password_CheckBox.Size = new System.Drawing.Size(72, 17);
            this.Password_CheckBox.TabIndex = 3;
            this.Password_CheckBox.Text = "Password";
            this.Password_CheckBox.UseVisualStyleBackColor = true;
            this.Password_CheckBox.CheckedChanged += new System.EventHandler(this.Password_CheckBox_CheckedChanged);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(104, 31);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(154, 20);
            this.Password_TextBox.TabIndex = 4;
            // 
            // Watermark_Form
            // 
            this.AcceptButton = this.Go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 96);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Password_CheckBox);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Watermark_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Watermark_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDF Watermark";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Watermark_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.CheckBox Password_CheckBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

