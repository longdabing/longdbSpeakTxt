namespace longdbSpeakTxt.ImageToTxt
{
    partial class DealImageForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btngrap = new System.Windows.Forms.Button();
            this.btnloadimg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrotatflip = new System.Windows.Forms.Button();
            this.btgetgray = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncutscreen = new System.Windows.Forms.Button();
            this.btnaddtxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picbox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // picbox
            // 
            this.picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbox.Location = new System.Drawing.Point(0, 0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(649, 450);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseDown);
            this.picbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseMove);
            this.picbox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbox_MouseUp);
            // 
            // btngrap
            // 
            this.btngrap.Location = new System.Drawing.Point(14, 47);
            this.btngrap.Name = "btngrap";
            this.btngrap.Size = new System.Drawing.Size(127, 23);
            this.btngrap.TabIndex = 0;
            this.btngrap.Text = "亮度处理";
            this.btngrap.UseVisualStyleBackColor = true;
            this.btngrap.Click += new System.EventHandler(this.btngrap_Click);
            // 
            // btnloadimg
            // 
            this.btnloadimg.Location = new System.Drawing.Point(14, 18);
            this.btnloadimg.Name = "btnloadimg";
            this.btnloadimg.Size = new System.Drawing.Size(127, 23);
            this.btnloadimg.TabIndex = 1;
            this.btnloadimg.Text = "选择图片";
            this.btnloadimg.UseVisualStyleBackColor = true;
            this.btnloadimg.Click += new System.EventHandler(this.btnloadimg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaddtxt);
            this.groupBox1.Controls.Add(this.btncutscreen);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btgetgray);
            this.groupBox1.Controls.Add(this.btnrotatflip);
            this.groupBox1.Controls.Add(this.btngrap);
            this.groupBox1.Controls.Add(this.btnloadimg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 450);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // btnrotatflip
            // 
            this.btnrotatflip.Location = new System.Drawing.Point(14, 76);
            this.btnrotatflip.Name = "btnrotatflip";
            this.btnrotatflip.Size = new System.Drawing.Size(127, 23);
            this.btnrotatflip.TabIndex = 2;
            this.btnrotatflip.Text = "翻转";
            this.btnrotatflip.UseVisualStyleBackColor = true;
            this.btnrotatflip.Click += new System.EventHandler(this.btnrotatflip_Click);
            // 
            // btgetgray
            // 
            this.btgetgray.Location = new System.Drawing.Point(14, 105);
            this.btgetgray.Name = "btgetgray";
            this.btgetgray.Size = new System.Drawing.Size(127, 23);
            this.btgetgray.TabIndex = 3;
            this.btgetgray.Text = "取灰度";
            this.btgetgray.UseVisualStyleBackColor = true;
            this.btgetgray.Click += new System.EventHandler(this.btgetgray_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(14, 193);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(127, 23);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "复原";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(14, 222);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 23);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncutscreen
            // 
            this.btncutscreen.Location = new System.Drawing.Point(14, 135);
            this.btncutscreen.Name = "btncutscreen";
            this.btncutscreen.Size = new System.Drawing.Size(127, 23);
            this.btncutscreen.TabIndex = 6;
            this.btncutscreen.Text = "截屏幕";
            this.btncutscreen.UseVisualStyleBackColor = true;
            this.btncutscreen.Click += new System.EventHandler(this.btncutscreen_Click);
            // 
            // btnaddtxt
            // 
            this.btnaddtxt.Location = new System.Drawing.Point(14, 164);
            this.btnaddtxt.Name = "btnaddtxt";
            this.btnaddtxt.Size = new System.Drawing.Size(127, 23);
            this.btnaddtxt.TabIndex = 7;
            this.btnaddtxt.Text = "添加文字";
            this.btnaddtxt.UseVisualStyleBackColor = true;
            this.btnaddtxt.Click += new System.EventHandler(this.btnaddtxt_Click);
            // 
            // DealImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DealImageForm";
            this.Text = "DealImageForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btngrap;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Button btnloadimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrotatflip;
        private System.Windows.Forms.Button btgetgray;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncutscreen;
        private System.Windows.Forms.Button btnaddtxt;
    }
}