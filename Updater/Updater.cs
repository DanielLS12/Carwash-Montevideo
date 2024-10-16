using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();

            var client = new WebClient();

            try
            {
                if (File.Exists(@".\SetupCarwash.msi")) { File.Delete(@".\SetupCarwash.msi"); }
                if (File.Exists(@".\SetupCarwash.zip")) { File.Delete(@".\SetupCarwash.zip"); }

                client.DownloadFile("https://moonti.000webhostapp.com/Update/SetupCarwash.zip", @"SetupCarwash.zip");
                string zipPath = @".\SetupCarwash.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);

                File.Delete(zipPath);

                Process process = new Process();
                process.StartInfo.FileName = "msiexec";
                process.StartInfo.Arguments = String.Format("/i SetupCarwash.msi");

                this.Close();

                process.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
