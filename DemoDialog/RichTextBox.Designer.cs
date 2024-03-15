namespace DemoDialog
{
    partial class RichTextBox
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontChu = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(383, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(718, 278);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // fontChu
            // 
            this.fontChu.Location = new System.Drawing.Point(1266, 178);
            this.fontChu.Name = "fontChu";
            this.fontChu.Size = new System.Drawing.Size(147, 51);
            this.fontChu.TabIndex = 1;
            this.fontChu.Text = "Font";
            this.fontChu.UseVisualStyleBackColor = true;
            this.fontChu.Click += new System.EventHandler(this.fontChu_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(1266, 275);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(147, 55);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(640, 440);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(171, 52);
            this.btnSaoChep.TabIndex = 3;
            this.btnSaoChep.Text = "Sao Chep";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(383, 531);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(718, 278);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // RichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 1080);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.fontChu);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RichTextBox";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button fontChu;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button btnSaoChep;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}