namespace longdbSpeakTxt
{
    partial class SetSkinsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "背景设置";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " ",
            "Calmness",
            "CalmnessColor1",
            "CalmnessColor2",
            "DeepCyan",
            "DeepGreen",
            "DeepOrange",
            "DiamondBlue",
            "DiamondGreen",
            "DiamondOlive",
            "DiamondPurple",
            "DiamondRed",
            "Eighteen",
            "EighteenColor1",
            "EighteenColor2",
            "Emerald",
            "EmeraldColor1",
            "GlassBrown",
            "GlassGreen",
            "Longhorn",
            "MacOS",
            "Midsummer",
            "MidsummerColor1",
            "mp10",
            "mp10green",
            "MSN",
            "office2007",
            "OneBlue",
            "Page",
            "PageColor1",
            "Silver",
            "SilverColor1",
            "SportsBlue",
            "SportsCyan",
            "vista1",
            "Warm",
            "XPBlue",
            "XPSilver"});
            this.comboBox1.Location = new System.Drawing.Point(77, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 20);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "office2007";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SetSkinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Name = "SetSkinsForm";
            this.ShowIcon = false;
            this.Text = "SetSkinsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}