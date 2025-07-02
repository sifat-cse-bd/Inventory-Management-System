using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;
namespace InventoryManagement.Database
{
    public class ImageManager
    {
        public ImageManager()
        {
        }
        public string FindSupershopDataFolder()
        {
            string currentPath = Application.StartupPath;

            while (!string.IsNullOrEmpty(currentPath))
            {
                string potentialPath = Path.Combine(currentPath, "Supershop Data");
                if (Directory.Exists(potentialPath))
                {
                    return potentialPath;
                }
                currentPath = Directory.GetParent(currentPath)?.FullName;
            }
            return null;
        }

        public string SaveImageToUserFolder(string sourceImagePath, string username)
        {
            string[] prefixName = username.Split(' ');
            try
            {
                string supershopDataPath = FindSupershopDataFolder();
                string appImagePath = Path.Combine(supershopDataPath, "App Image");

                string userImagePath = Path.Combine(appImagePath, "User Image");
                if (!Directory.Exists(userImagePath))
                    Directory.CreateDirectory(userImagePath);
                string extension = Path.GetExtension(sourceImagePath);
                string uniqueFileName = prefixName[0] + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                string destinationPath = Path.Combine(userImagePath, uniqueFileName);
                File.Copy(sourceImagePath, destinationPath, true);

                return destinationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string SaveImageToProductFolder(string sourceImagePath, string productName)
        {
            string[] prefixName = productName.Split(' ');
            try
            {
                string supershopDataPath = FindSupershopDataFolder();
                string appImagePath = Path.Combine(supershopDataPath, "App Image");

                string userImagePath = Path.Combine(appImagePath, "Product Image");
                if (!Directory.Exists(userImagePath))
                    Directory.CreateDirectory(userImagePath);
                string extension = Path.GetExtension(sourceImagePath);
                string uniqueFileName = prefixName[0] + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                string destinationPath = Path.Combine(userImagePath, uniqueFileName);
                File.Copy(sourceImagePath, destinationPath, true);

                return destinationPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        //Open dialoge
        public bool OpenFileExplorer(out string filePath, out Image selectedImage)
        {
            filePath = null;
            selectedImage = null;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;

                        using (Image img = Image.FromFile(filePath))
                        {
                            if (img.Width != 150 || img.Height != 150)
                            {
                                MessageBox.Show("⚠️ Please select an image of exactly 150x150 pixels!", "Invalid Image Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                filePath = null;
                                return false;
                            }

                            selectedImage = CorrectImageOrientation((Image)img.Clone());
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public bool OpenFileExplorerProduct(out string filePath, out Image selectedImage)
        {
            filePath = null;
            selectedImage = null;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.webp)|*.jpg;*.jpeg;*.png;*.webp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;

                        using (Image img = Image.FromFile(filePath))
                        {
                            // Return the image
                            selectedImage = CorrectImageOrientation((Image)img.Clone());
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        private static Image CorrectImageOrientation(Image img)
        {
            try
            {
                if (img.PropertyIdList.Contains(0x0112))
                {
                    var prop = img.GetPropertyItem(0x0112);
                    int val = BitConverter.ToUInt16(prop.Value, 0);

                    switch (val)
                    {
                        case 3:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 6:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 8:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                    }

                    try { img.RemovePropertyItem(0x0112); } catch { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error correcting image orientation: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return img;
        }

        public void DeleteImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Delete(imagePath);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
    

