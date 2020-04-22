namespace longdbSpeakTxt.TxtToVoice
{
    partial class TxtToVoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btngettxt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gboxlist = new System.Windows.Forms.GroupBox();
            this.listgrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnpasuse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgrid = new System.Windows.Forms.DataGridView();
            this.txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCycle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gboxlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listgrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btngettxt
            // 
            this.btngettxt.Location = new System.Drawing.Point(6, 12);
            this.btngettxt.Name = "btngettxt";
            this.btngettxt.Size = new System.Drawing.Size(75, 23);
            this.btngettxt.TabIndex = 5;
            this.btngettxt.Text = "播放";
            this.btngettxt.UseVisualStyleBackColor = true;
            this.btngettxt.Click += new System.EventHandler(this.btngettxt_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gboxlist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(803, 454);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 6;
            // 
            // gboxlist
            // 
            this.gboxlist.Controls.Add(this.listgrid);
            this.gboxlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxlist.Location = new System.Drawing.Point(0, 0);
            this.gboxlist.Name = "gboxlist";
            this.gboxlist.Size = new System.Drawing.Size(266, 454);
            this.gboxlist.TabIndex = 6;
            this.gboxlist.TabStop = false;
            this.gboxlist.Text = "列表：";
            // 
            // listgrid
            // 
            this.listgrid.BackgroundColor = System.Drawing.Color.White;
            this.listgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listgrid.ColumnHeadersVisible = false;
            this.listgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title});
            this.listgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.listgrid.Location = new System.Drawing.Point(3, 17);
            this.listgrid.Name = "listgrid";
            this.listgrid.RowHeadersVisible = false;
            this.listgrid.RowTemplate.Height = 23;
            this.listgrid.Size = new System.Drawing.Size(260, 434);
            this.listgrid.TabIndex = 6;
            this.listgrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listgrid_CellDoubleClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Title.DefaultCellStyle = dataGridViewCellStyle3;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCycle);
            this.groupBox2.Controls.Add(this.btnstop);
            this.groupBox2.Controls.Add(this.btnpasuse);
            this.groupBox2.Controls.Add(this.btngettxt);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(288, 12);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 7;
            this.btnstop.Text = "停止";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnpasuse
            // 
            this.btnpasuse.Location = new System.Drawing.Point(194, 12);
            this.btnpasuse.Name = "btnpasuse";
            this.btnpasuse.Size = new System.Drawing.Size(75, 23);
            this.btnpasuse.TabIndex = 6;
            this.btnpasuse.Text = "暂停";
            this.btnpasuse.UseVisualStyleBackColor = true;
            this.btnpasuse.Click += new System.EventHandler(this.btnpasuse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 392);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtgrid
            // 
            this.txtgrid.BackgroundColor = System.Drawing.Color.White;
            this.txtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtgrid.ColumnHeadersVisible = false;
            this.txtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt});
            this.txtgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.txtgrid.Location = new System.Drawing.Point(3, 17);
            this.txtgrid.Name = "txtgrid";
            this.txtgrid.RowHeadersVisible = false;
            this.txtgrid.RowTemplate.Height = 23;
            this.txtgrid.Size = new System.Drawing.Size(527, 372);
            this.txtgrid.TabIndex = 7;
            // 
            // txt
            // 
            this.txt.DataPropertyName = "txt";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.txt.DefaultCellStyle = dataGridViewCellStyle4;
            this.txt.HeaderText = "txt";
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Width = 200;
            // 
            // btnCycle
            // 
            this.btnCycle.Location = new System.Drawing.Point(100, 12);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(75, 23);
            this.btnCycle.TabIndex = 8;
            this.btnCycle.Text = "循环播放";
            this.btnCycle.UseVisualStyleBackColor = true;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // TxtToVoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 454);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TxtToVoiceForm";
            this.ShowIcon = false;
            this.Text = "TxtToVoiceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TxtToVoiceForm_FormClosing);
            this.Load += new System.EventHandler(this.TxtToVoiceForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gboxlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listgrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btngettxt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gboxlist;
        private System.Windows.Forms.DataGridView listgrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnpasuse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView txtgrid;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt;
        private System.Windows.Forms.Button btnCycle;
    }
}