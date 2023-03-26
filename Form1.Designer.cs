namespace ScreenshotTinder {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            pbImage = new PictureBox();
            ButtonDelete = new Button();
            ButtonKeep = new Button();
            ButtonBack = new Button();
            ((System.ComponentModel.ISupportInitialize) pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(0, 0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(996, 666);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonDelete.AutoSize = true;
            ButtonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonDelete.Location = new Point(12, 604);
            ButtonDelete.MaximumSize = new Size(1000, 50);
            ButtonDelete.MinimumSize = new Size(480, 50);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(480, 50);
            ButtonDelete.TabIndex = 1;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonKeep
            // 
            ButtonKeep.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonKeep.AutoSize = true;
            ButtonKeep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonKeep.Location = new Point(504, 604);
            ButtonKeep.MaximumSize = new Size(1000, 50);
            ButtonKeep.MinimumSize = new Size(480, 50);
            ButtonKeep.Name = "ButtonKeep";
            ButtonKeep.Size = new Size(480, 50);
            ButtonKeep.TabIndex = 2;
            ButtonKeep.Text = "Keep";
            ButtonKeep.UseVisualStyleBackColor = true;
            ButtonKeep.Click += ButtonKeep_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonBack.AutoSize = true;
            ButtonBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonBack.Cursor = Cursors.PanWest;
            ButtonBack.Location = new Point(472, 573);
            ButtonBack.MaximumSize = new Size(200, 50);
            ButtonBack.MinimumSize = new Size(50, 25);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(50, 25);
            ButtonBack.TabIndex = 3;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 666);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonKeep);
            Controls.Add(ButtonDelete);
            Controls.Add(pbImage);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Screenshot Tinder";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize) pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Button ButtonDelete;
        private Button ButtonKeep;
        private Button ButtonBack;
    }
}