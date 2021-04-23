namespace NetSparkleUpdater.UI.WinForms
{
    partial class CheckingForUpdatesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckingForUpdatesWindow));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.CheckingForUpdates = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iconImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 57);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.MarqueeAnimationSpeed = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(298, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // CheckingForUpdates
            // 
            this.CheckingForUpdates.AutoSize = true;
            this.CheckingForUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckingForUpdates.Location = new System.Drawing.Point(82, 17);
            this.CheckingForUpdates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckingForUpdates.Name = "CheckingForUpdates";
            this.CheckingForUpdates.Size = new System.Drawing.Size(275, 24);
            this.CheckingForUpdates.TabIndex = 1;
            this.CheckingForUpdates.Text = "Revisando actualizaciones...";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(172, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Saltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // iconImage
            // 
            this.iconImage.Image = ((System.Drawing.Image)(resources.GetObject("iconImage.Image")));
            this.iconImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconImage.Location = new System.Drawing.Point(8, 17);
            this.iconImage.Name = "iconImage";
            this.iconImage.Size = new System.Drawing.Size(48, 48);
            this.iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconImage.TabIndex = 7;
            this.iconImage.TabStop = false;
            // 
            // CheckingForUpdatesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 127);
            this.Controls.Add(this.iconImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckingForUpdates);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckingForUpdatesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualización de Software";
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label CheckingForUpdates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox iconImage;
    }
}