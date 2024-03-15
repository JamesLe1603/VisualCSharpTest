namespace DemoDialog
{
    partial class frmBaiTap
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSec = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnTrc = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(58, 55);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(222, 40);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn Các Hình Ảnh";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tự chuyển hình sau: ";
            // 
            // nudSec
            // 
            this.nudSec.Location = new System.Drawing.Point(484, 63);
            this.nudSec.Name = "nudSec";
            this.nudSec.Size = new System.Drawing.Size(120, 31);
            this.nudSec.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "(giây)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(893, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1003, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Dừng";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // picMain
            // 
            this.picMain.Location = new System.Drawing.Point(58, 173);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1020, 295);
            this.picMain.TabIndex = 5;
            this.picMain.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(167, 542);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "Đầu tiên";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnTrc
            // 
            this.btnTrc.Location = new System.Drawing.Point(272, 542);
            this.btnTrc.Name = "btnTrc";
            this.btnTrc.Size = new System.Drawing.Size(75, 23);
            this.btnTrc.TabIndex = 6;
            this.btnTrc.Text = "Trước";
            this.btnTrc.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(383, 542);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(75, 23);
            this.btnSau.TabIndex = 6;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(505, 542);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = "Cuối cùng";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // frmBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 700);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTrc);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChon);
            this.Name = "frmBaiTap";
            this.Text = "frmBaiTap";
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnTrc;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnLast;
    }
}