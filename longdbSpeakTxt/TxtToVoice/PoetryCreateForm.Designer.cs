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
            this.txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtline = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnsave.Location = new System.Drawing.Point(12, 25);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // dgrid
            // 
            this.dgrid.AllowUserToAddRows = false;
            this.dgrid.BackgroundColor = System.Drawing.Color.White;
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt,
            this.txtline});
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
            // txt
            // 
            this.txt.DataPropertyName = "FTitle";
            this.txt.HeaderText = "名称";
            this.txt.Name = "txt";
            // 
            // txtline
            // 
            this.txtline.DataPropertyName = "FLine";
            this.txtline.HeaderText = "诗句";
            this.txtline.Name = "txtline";
            this.txtline.Width = 400;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtline;
    }
}