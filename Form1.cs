namespace ScreenshotTinder {
    public partial class Form1 : Form {
        private int ImagesIndex = 1;
        private string? CurrentImage;
        private readonly string SelectedPath;
        private readonly string[] ImagesPath;
        private readonly List<string> AllowedExtensions = new() {
            "jpg",
            "png",
            "jpeg"
        };

        public Form1() {
            InitializeComponent();
            MinimumSize = Size;
            FolderBrowserDialog fbd = new() {
                Description = "Images folder"
            };

            while (fbd.ShowDialog() != DialogResult.OK)
                ;
            SelectedPath = fbd.SelectedPath;
            ImagesPath = Directory.GetFiles(SelectedPath, "*", SearchOption.TopDirectoryOnly);
            NextImage();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            File.Delete(CurrentImage);
            NextImage();
        }

        private void btnKeep_Click(object sender, EventArgs e) {
            NextImage();
        }

        private void NextImage() {
            do {
                CurrentImage = ImagesPath[ImagesIndex++];
            } while (ImagesIndex < ImagesPath.Length
                     && !AllowedExtensions.Contains(Path.GetExtension(CurrentImage)[1..]));

            using FileStream Fs = new(CurrentImage, FileMode.Open, FileAccess.Read);
            ShowImage(Image.FromStream(Fs));
        }

        private void ShowImage(Image Image) {
            pbImage.Image = Image;
        }
    }
}