using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Base 64", "Encodage/Décodage Fichier")]
	public partial class Base64File : UserControl
	{
		public Base64File ()
		{
			InitializeComponent();
		}

		private void FileFrom_Click ( object sender, EventArgs e )
		{
			OpenFile();
		}

		private void FileTo_Click ( object sender, EventArgs e )
		{
			SaveFile();
		}

		private void OpenFile ()
		{
			openFileDialog.FileName = FilenameFrom.Text;
			openFileDialog.ShowDialog();
			FilenameFrom.Text = openFileDialog.FileName;
		}

		private void SaveFile ()
		{
			saveFileDialog.FileName = FilenameTo.Text;
			saveFileDialog.ShowDialog();
			FilenameTo.Text = saveFileDialog.FileName;
		}

		private void Encode_Click ( object sender, EventArgs e )
		{
			try {
				byte[] content = FilenameFrom.ReadAllBytes();
				Base64Text.Text = Convert.ToBase64String(content);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void Decode_Click ( object sender, EventArgs e )
		{
			try {
				byte[] content = Convert.FromBase64String(Base64Text.Text);
				FilenameTo.WriteAllBytes(content);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

	}
}
