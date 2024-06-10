using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class Screenshot
    {
        public Rectangle ScreenSection { get; set; }

        public void SetScreenSection(int i_X, int i_Y, int i_Width, int i_Height)
        {
            ScreenSection = new Rectangle(i_X, i_Y, i_Width, i_Height);
        }

        public bool TakeScreenshotAndCheckIfSucceed()
        {
            bool isScreenShotSucceed = false;

            if (ScreenSection != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Files|*.png|JPEG Files|*.jpg|BMP Files|*.bmp";
                    saveFileDialog.Title = "Save Screenshot";
                    saveFileDialog.DefaultExt = "png";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string savePath = saveFileDialog.FileName;
                        captureScreenSection(savePath);
                        isScreenShotSucceed = true;
                    }
                }
            }

            return isScreenShotSucceed;
        }

        private void captureScreenSection(string i_SavePath)
        {
            using (Bitmap bitmap = new Bitmap(ScreenSection.Width, ScreenSection.Height))
            {
                using (Graphics graphic = Graphics.FromImage(bitmap))
                {
                    graphic.CopyFromScreen(ScreenSection.Location, Point.Empty, ScreenSection.Size);
                }

                bitmap.Save(i_SavePath);
            }
        }
    }
}