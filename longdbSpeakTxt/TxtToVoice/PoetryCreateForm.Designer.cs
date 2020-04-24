namespace longdbSpeakTxt.TxtToVoice
{
    partial class PoetryCreateForm
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
            this.btnsave = new System.Windows.Forms.Button();
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.btnquerry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.FTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FMNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txttitle);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnquerry);
            this.splitContainer1.Panel1.Controls.Add(this.btnsave);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgrid);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 66;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(12, 21);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dgrid
            // 
            this.dgrid.AllowUserToAddRows = false;
            this.dgrid.BackgroundColor = System.Drawing.Color.White;
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FTitle,
            this.FLine,
            this.FMNo});
            this.dgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgrid.GridColor = System.Drawing.Color.White;
            this.dgrid.Location = new System.Drawing.Point(0, 0);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersVisible = false;
            this.dgrid.RowTemplate.Height = 23;
            this.dgrid.Size = new System.Drawing.Size(800, 380);
            this.dgrid.TabIndex = 0;
            // 
            // btnquerry
            // 
            this.btnquerry.Location = new System.Drawing.Point(426, 22);
            this.btnquerry.Name = "btnquerry";
            this.btnquerry.Size = new System.Drawing.Size(75, 23);
            this.btnquerry.TabIndex = 1;
            this.btnquerry.Text = "查询";
            this.btnquerry.UseVisualStyleBackColor = true;
            this.btnquerry.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "题目：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(287, 23);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(127, 21);
            this.txttitle.TabIndex = 3;
            this.txttitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FTitle
            // 
            this.FTitle.DataPropertyName = "FTitle";
            this.FTitle.HeaderText = "名称";
            this.FTitle.Name = "FTitle";
            // 
            // FLine
            // 
            this.FLine.DataPropertyName = "FLine";
            this.FLine.HeaderText = "诗句";
            this.FLine.Name = "FLine";
            this.FLine.Width = 400;
            // 
            // FMNo
            // 
            this.FMNo.DataPropertyName = "FMNo";
            this.FMNo.HeaderText = "FMNo";
            this.FMNo.Name = "FMNo";
            this.FMNo.ReadOnly = true;
            this.FMNo.Visible = false;
            // 
            // PoetryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PoetryCreateForm";
            this.ShowIcon = false;
            this.Text = "古诗录入";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquerry;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn FMNo;
    }
}