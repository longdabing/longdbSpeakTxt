namespace longdbSpeakTxt
{
    partial class SRateSettingForm
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
            this.cboxrate = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "语速设置";
            // 
            // cboxrate
            // 
            this.cboxrate.FormattingEnabled = true;
            this.cboxrate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1"});
            this.cboxrate.Location = new System.Drawing.Point(85, 34);
            this.cboxrate.Name = "cboxrate";
            this.cboxrate.Size = new System.Drawing.Size(159, 20);
            this.cboxrate.TabIndex = 18;
            this.cboxrate.Text = "0";
            this.cboxrate.SelectedIndexChanged += new System.EventHandler(this.cboxrate_SelectedIndexChanged);
            // 
            // SRateSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxrate);
            this.Name = "SRateSettingForm";
            this.ShowIcon = false;
            this.Text = "SRateSettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxrate;
    }
}