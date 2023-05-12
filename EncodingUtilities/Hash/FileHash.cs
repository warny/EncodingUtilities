using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Hash", "Fichier")]
	public partial class FileHash : UserControl
	{

		static string[] HashAlgorithm = new string[] {
			"SHA1",
			"SHA256",
			"SHA384",
			"SHA512",
			"MD5",
			"RIPEMD160"
		};

		public FileHash ()
		{
			InitializeComponent();

			Algorithm.Items.AddRange(HashAlgorithm);
			Algorithm.SelectedIndex = 0;

			OpenFile();
		}

		private void Compute_Click ( object sender, EventArgs e )
		{
			HashAlgorithm algorithm = System.Security.Cryptography.HashAlgorithm.Create(Algorithm.Text);

			try {
				byte[] source = Filename.ReadAllBytes();

				byte[] result = algorithm.ComputeHash(source);

				StringBuilder HexaResult = new StringBuilder();
				foreach (byte Byte in result) {
					HexaResult.AppendFormat("{0:X2} ", Byte);
				}
				HexHash.Text = HexaResult.ToString();

				Base64Hash.Text = Convert.ToBase64String(result);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void Open_Click ( object sender, EventArgs e )
		{
			OpenFile();
		}

		private void OpenFile ()
		{
			openFileDialog.FileName = Filename.Text;
			openFileDialog.ShowDialog();
			Filename.Text = openFileDialog.FileName;
		}
	}
}
