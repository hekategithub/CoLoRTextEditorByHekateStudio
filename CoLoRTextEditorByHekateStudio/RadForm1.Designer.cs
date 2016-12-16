namespace CoLoRTextEditorByHekateStudio
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.txt_Hekate = new Telerik.WinControls.UI.RadRichTextEditor();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hekate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Hekate
            // 
            this.txt_Hekate.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Hekate.CaretWidth = float.NaN;
            this.txt_Hekate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Hekate.Font = new System.Drawing.Font("Inconsolata", 8.25F);
            this.txt_Hekate.Location = new System.Drawing.Point(0, 0);
            this.txt_Hekate.Name = "txt_Hekate";
            this.txt_Hekate.Size = new System.Drawing.Size(658, 709);
            this.txt_Hekate.TabIndex = 1;
            this.txt_Hekate.ThemeName = "VisualStudio2012Dark";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 709);
            this.Controls.Add(this.txt_Hekate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1300, 0);
            this.Name = "RadForm1";
            this.Opacity = 0.8D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hekate Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RadForm1_FormClosing);
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Hekate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRichTextEditor txt_Hekate;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;



    }
}