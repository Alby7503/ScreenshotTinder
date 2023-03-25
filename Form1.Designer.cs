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
            btnDelete = new Button();
            btnKeep = new Button();
            btnBack = new Button();
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
            // btnDelete
            // 
            btnDelete.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.AutoSize = true;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Location = new Point(12, 604);
            btnDelete.MaximumSize = new Size(1000, 50);
            btnDelete.MinimumSize = new Size(480, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(480, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnKeep
            // 
            btnKeep.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
            btnKeep.AutoSize = true;
            btnKeep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnKeep.Location = new Point(504, 604);
            btnKeep.MaximumSize = new Size(1000, 50);
            btnKeep.MinimumSize = new Size(480, 50);
            btnKeep.Name = "btnKeep";
            btnKeep.Size = new Size(480, 50);
            btnKeep.TabIndex = 2;
            btnKeep.Text = "Keep";
            btnKeep.UseVisualStyleBackColor = true;
            btnKeep.Click += btnKeep_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.AutoSize = true;
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.Cursor = Cursors.PanWest;
            btnBack.Location = new Point(472, 573);
            btnBack.MaximumSize = new Size(200, 50);
            btnBack.MinimumSize = new Size(50, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 25);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 666);
            Controls.Add(btnBack);
            Controls.Add(btnKeep);
            Controls.Add(btnDelete);
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
        private Button btnDelete;
        private Button btnKeep;
        private Button btnBack;
    }
}