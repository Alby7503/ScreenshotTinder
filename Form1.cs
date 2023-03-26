using Microsoft.VisualBasic.FileIO;

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
            ImagesPath = Directory.GetFiles(SelectedPath, "*", System.IO.SearchOption.TopDirectoryOnly);
            Shuffle(ImagesPath);
            NextImage();
        }

        private void ButtonDelete_Click(object sender, EventArgs e) {
            //File.Delete(CurrentImage);
            if (CurrentImage != null)
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(CurrentImage, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
            NextImage();
        }

        private void ButtonKeep_Click(object sender, EventArgs e) {
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

        private static void Shuffle<T>(T[] array) {
            Random Random = new();
            int n = array.Length;
            while (n > 1) {
                int k = Random.Next(n--);
                (array[k], array[n]) = (array[n], array[k]);
            }
        }
    }
}