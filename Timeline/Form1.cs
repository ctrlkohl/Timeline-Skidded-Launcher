using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DiscordRpcDemo;
using Guna.UI2.WinForms;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using Siticone.Desktop.UI.WinForms;

namespace Timeline
{
	// Token: 0x0200000B RID: 11
	public partial class Form1 : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000224C File Offset: 0x0000044C
		public Form1()
		{
			this.InitializeComponent();
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("1085449948688044072", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("1085449948688044072", ref this.handlers, true, null);
			this.presence.details = "Using Timeline";
			this.presence.state = "discord.gg/TimelineFN";
			this.presence.largeImageKey = "image1";
			this.presence.smallImageKey = "image2";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002310 File Offset: 0x00000510
		private void Form1_Load(object sender, EventArgs e)
		{
            // Get the base directory and the path to the config file
			// REVERSE ENGINEERED BY CTRLKOHL DECOMP
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //string configFilePath = Path.Combine(baseDirectory, "config.json");

            //// Check if the config file exists
            //if (File.Exists(configFilePath))
            //{
                // Read the contents of the config file
                /*string configFileContent = File.ReadAllText(configFilePath);

                // Deserialize the JSON data to an object
                var configData = JsonConvert.DeserializeObject<dynamic>(configFileContent);

                // Update the text property of the path control
                string pathControlText = configData.FNPath;
                this.path.Text = pathControlText;

                // Update the text property of the email control
                string emailControlText = configData.Email;
                this.email.Text = emailControlText;

                // Update the text property of the password control
                string passwordControlText = configData.Password;
                this.pass.Text = passwordControlText;
            }*/
        }

		// Token: 0x06000020 RID: 32 RVA: 0x00002526 File Offset: 0x00000726
		private void Content_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002526 File Offset: 0x00000726
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000252C File Offset: 0x0000072C
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			string text = this.email.Text;
			string text2 = this.pass.Text;
			string text3 = this.path.Text;
			Environment.CurrentDirectory = this.aioDir;
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1084458618608422985/1086747361847550043/IGCSInjector.exe", this.aioDir + "\\injection.exe");
			Thread.Sleep(1000);
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1084458618608422985/1086747362216656906/IGCSInjector.ini", this.aioDir + "\\IGCSInjector.ini");
			Thread.Sleep(1000);
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1090530590656319518/1091713076660813904/ssl.dll", this.aioDir + "\\api.dll");
			Environment.CurrentDirectory = text3;
			Process process = ProcessHelper.StartProcess(text3 + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
			Process process2 = ProcessHelper.StartProcess(text3 + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
			Process process3 = ProcessHelper.StartProcess(text3 + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
			Process process4 = ProcessHelper.StartProcess(text3 + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, string.Concat(new string[]
			{
				"-AUTH_TYPE=epic -AUTH_LOGIN=\"",
				text,
				"\" -AUTH_PASSWORD=\"",
				text2,
				"\" -SKIPPATCHCHECK"
			}));
			process4.WaitForInputIdle();
			Environment.CurrentDirectory = this.aioDir;
			Thread.Sleep(1000);
			new Process
			{
				StartInfo = 
				{
					UseShellExecute = false,
					FileName = this.aioDir + "\\injection.exe",
					CreateNoWindow = true
				}
			}.Start();
			Thread.Sleep(1500);
			foreach (Process process5 in Process.GetProcessesByName("injection"))
			{
				process5.Kill();
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002714 File Offset: 0x00000914
		private void guna2GradientButton5_Click(object sender, EventArgs e)
		{
            // Create a new instance of CommonOpenFileDialog
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            // Set the initial directory to open to
            dialog.InitialDirectory = @"C:\";

			// Set the dialog to select folders only
			dialog.IsFolderPicker = true;

            // Show the dialog and check if the user clicked the "OK" button
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // Set the selected folder path to the "path" textbox
                this.path.Text = dialog.FileName;
            }
        }

		// Token: 0x06000024 RID: 36 RVA: 0x00002760 File Offset: 0x00000960
		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
            // REVERSE ENGINEERED BY CTRLKOHL DECOMP
            // Get the directory where the application is running from
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the file name to get the full path to the config file
            string configFilePath = Path.Combine(baseDirectory, "config.json");

            // Create an anonymous object to hold the configuration data
            var configData = new
            {
                Email = this.email.Text,
                Password = this.pass.Text,
                FNPath = this.path.Text
            };

            // Convert the configuration data to JSON format
            string jsonContents = JsonConvert.SerializeObject(configData);

            // Write the JSON data to the config file
            File.WriteAllText(configFilePath, jsonContents);

            // Display a success message to the user
            MessageBox.Show("The configuration has been written to config.json with success!");
        }

		// Token: 0x06000025 RID: 37 RVA: 0x00002526 File Offset: 0x00000726
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002526 File Offset: 0x00000726
		private void path_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002526 File Offset: 0x00000726
		private void guna2GradientButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002526 File Offset: 0x00000726
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002526 File Offset: 0x00000726
		private void tabPage2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000027C8 File Offset: 0x000009C8
		private void guna2GradientButton6_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory(this.aioDir2);
			Environment.CurrentDirectory = this.aioDir2;
			new WebClient().DownloadFile("https://github.com/Kyiro/Fortnite-ManifestsArchive/releases/download/1.2/EasyInstaller.exe", this.aioDir2 + "\\EasyInstaller.exe");
			MessageBox.Show("NOTE: To install build 10.40, please enter the build number 75");
			Process.Start("EasyInstaller.exe");
		}

		// Token: 0x0400001F RID: 31
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000020 RID: 32
		private DiscordRpc.RichPresence presence;

		// Token: 0x04000021 RID: 33
		private string aioDir = "C:\\";

		// Token: 0x04000022 RID: 34
		private string aioDir2 = "C:\\";
	}
}
