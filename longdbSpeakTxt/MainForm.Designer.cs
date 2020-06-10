namespace longdbSpeakTxt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mitemtxttovoice = new System.Windows.Forms.ToolStripMenuItem();
            this.txttovice = new System.Windows.Forms.ToolStripMenuItem();
            this.PoetryCreateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagetotxtitem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagetotxt = new System.Windows.Forms.ToolStripMenuItem();
            this.titemdealimg = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenuitemchart = new System.Windows.Forms.ToolStripMenuItem();
            this.titembarchart = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenusetting = new System.Windows.Forms.ToolStripMenuItem();
            this.settingitem = new System.Windows.Forms.ToolStripMenuItem();
            this.backsetitem = new System.Windows.Forms.ToolStripMenuItem();
            this.RateItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sockettem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemtxttovoice,
            this.imagetotxtitem,
            this.tmenuitemchart,
            this.toolStripMenuItem1,
            this.tmenusetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mitemtxttovoice
            // 
            this.mitemtxttovoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txttovice,
            this.PoetryCreateItem});
            this.mitemtxttovoice.Name = "mitemtxttovoice";
            this.mitemtxttovoice.Size = new System.Drawing.Size(80, 21);
            this.mitemtxttovoice.Text = "文字转语音";
            // 
            // txttovice
            // 
            this.txttovice.Name = "txttovice";
            this.txttovice.Size = new System.Drawing.Size(136, 22);
            this.txttovice.Text = "文字转语音";
            this.txttovice.Click += new System.EventHandler(this.txttovice_Click);
            // 
            // PoetryCreateItem
            // 
            this.PoetryCreateItem.Name = "PoetryCreateItem";
            this.PoetryCreateItem.Size = new System.Drawing.Size(136, 22);
            this.PoetryCreateItem.Text = "古诗录入";
            this.PoetryCreateItem.Click += new System.EventHandler(this.PoetryCreateItem_Click);
            // 
            // imagetotxtitem
            // 
            this.imagetotxtitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagetotxt,
            this.titemdealimg});
            this.imagetotxtitem.Name = "imagetotxtitem";
            this.imagetotxtitem.Size = new System.Drawing.Size(68, 21);
            this.imagetotxtitem.Text = "图片处理";
            // 
            // imagetotxt
            // 
            this.imagetotxt.Name = "imagetotxt";
            this.imagetotxt.Size = new System.Drawing.Size(148, 22);
            this.imagetotxt.Text = "提取图片文字";
            this.imagetotxt.Click += new System.EventHandler(this.imagetotxt_Click);
            // 
            // titemdealimg
            // 
            this.titemdealimg.Name = "titemdealimg";
            this.titemdealimg.Size = new System.Drawing.Size(148, 22);
            this.titemdealimg.Text = "图片处理";
            this.titemdealimg.Click += new System.EventHandler(this.titemdealimg_Click);
            // 
            // tmenuitemchart
            // 
            this.tmenuitemchart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titembarchart});
            this.tmenuitemchart.Name = "tmenuitemchart";
            this.tmenuitemchart.Size = new System.Drawing.Size(44, 21);
            this.tmenuitemchart.Text = "图表";
            // 
            // titembarchart
            // 
            this.titembarchart.Name = "titembarchart";
            this.titembarchart.Size = new System.Drawing.Size(180, 22);
            this.titembarchart.Text = "排序柱状图表";
            this.titembarchart.Click += new System.EventHandler(this.titembarchart_Click);
            // 
            // tmenusetting
            // 
            this.tmenusetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingitem,
            this.backsetitem,
            this.RateItemSetting});
            this.tmenusetting.Name = "tmenusetting";
            this.tmenusetting.Size = new System.Drawing.Size(44, 21);
            this.tmenusetting.Text = "设置";
            // 
            // settingitem
            // 
            this.settingitem.Name = "settingitem";
            this.settingitem.Size = new System.Drawing.Size(180, 22);
            this.settingitem.Text = "切换皮肤";
            this.settingitem.Click += new System.EventHandler(this.settingitem_Click);
            // 
            // backsetitem
            // 
            this.backsetitem.Name = "backsetitem";
            this.backsetitem.Size = new System.Drawing.Size(180, 22);
            this.backsetitem.Text = "背景设置";
            this.backsetitem.Click += new System.EventHandler(this.backsetitem_Click);
            // 
            // RateItemSetting
            // 
            this.RateItemSetting.Name = "RateItemSetting";
            this.RateItemSetting.Size = new System.Drawing.Size(180, 22);
            this.RateItemSetting.Text = "语速设置";
            this.RateItemSetting.Click += new System.EventHandler(this.RateItemSetting_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sockettem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "即时通讯";
            // 
            // sockettem
            // 
            this.sockettem.Name = "sockettem";
            this.sockettem.Size = new System.Drawing.Size(180, 22);
            this.sockettem.Text = "websocket";
            this.sockettem.Click += new System.EventHandler(this.sockettem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mitemtxttovoice;
        private System.Windows.Forms.ToolStripMenuItem txttovice;
        private System.Windows.Forms.ToolStripMenuItem imagetotxtitem;
        private System.Windows.Forms.ToolStripMenuItem imagetotxt;
        private System.Windows.Forms.ToolStripMenuItem tmenusetting;
        private System.Windows.Forms.ToolStripMenuItem settingitem;
        private System.Windows.Forms.ToolStripMenuItem backsetitem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem RateItemSetting;
        private System.Windows.Forms.ToolStripMenuItem PoetryCreateItem;
        private System.Windows.Forms.ToolStripMenuItem titemdealimg;
        private System.Windows.Forms.ToolStripMenuItem tmenuitemchart;
        private System.Windows.Forms.ToolStripMenuItem titembarchart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sockettem;
    }
}