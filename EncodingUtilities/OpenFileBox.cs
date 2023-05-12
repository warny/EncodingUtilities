using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EncodingUtilities
{
	public partial class OpenFileBox : UserControl
	{

		private FileDialog fileDialogForm;

		private FileDialogEnum fileDialog;

		public FileDialogEnum FileDialog
		{
			get { return fileDialog; }
			set
			{
				fileDialog = value;

				switch (FileDialog) {
					case FileDialogEnum.OpenFile:
						AllowDrop = true;
						fileDialogForm = new OpenFileDialog();
						break;
					case FileDialogEnum.SaveFile:
						AllowDrop = false;
						fileDialogForm = new SaveFileDialog();
						break;
					default:
						throw new NotImplementedException();
				}
			}
		}

		public override string Text
		{
			get { return Filename.Text; }
			set { Filename.Text = value; }
		}

		[DefaultValue("Tous les fichiers(*.*)|*.*")]
		public string Filter { get; set; } = "Tous les fichiers(*.*)|*.*";

		[DefaultValue(false)]
		public bool AddExtension { get; set; } = false;

		[DefaultValue("")]
		public string DefaultExtension { get; set; } = "";

		public DialogResult ShowDialog()
		{
			fileDialogForm.FileName = Filename.Text;
			fileDialogForm.AddExtension = AddExtension;
			fileDialogForm.Filter = Filter;
			fileDialogForm.DefaultExt = DefaultExtension;

			var result = fileDialogForm.ShowDialog();

			if (result == DialogResult.OK) {
				Filename.Text = fileDialogForm.FileName;
			}

			return result;
		}

		public OpenFileBox()
		{
			InitializeComponent();
		}

		public FileInfo GetFileInfo()
		{
			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return new FileInfo(Filename.Text);
		}

		#region lecture des fichiers
		/// <summary>
		/// Lit touts les octets du fichier
		/// </summary>
		/// <returns></returns>
		public byte[] ReadAllBytes()
		{
			if (fileDialog!=FileDialogEnum.OpenFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return File.ReadAllBytes(Filename.Text);
		}

		/// <summary>
		/// Lit toutes les lignes du fichier
		/// </summary>
		/// <returns></returns>
		public string[] ReadAllLines()
		{
			if (fileDialog != FileDialogEnum.OpenFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return File.ReadAllLines(Filename.Text);
		}

		/// <summary>
		/// Lit tout le texte du fichier
		/// </summary>
		/// <returns></returns>
		public string ReadAllText()
		{
			if (fileDialog != FileDialogEnum.OpenFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return File.ReadAllText(Filename.Text);
		}

		/// <summary>
		/// Ouvre le fichier
		/// </summary>
		/// <returns></returns>
		public FileStream OpenRead()
		{
			if (fileDialog != FileDialogEnum.OpenFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return File.OpenRead(Filename.Text);
		}
		#endregion

		#region Ecriture des fichiers
		/// <summary>
		/// Ecrit tous les octets vers le fichier
		/// </summary>
		/// <param name="value">Valeur à écrire</param>
		public void WriteAllBytes( byte[] value )
		{
			if (fileDialog != FileDialogEnum.SaveFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return;

			File.WriteAllBytes(Filename.Text, value);
		}

		/// <summary>
		/// Ecrit toutes les lignes vers le fichier
		/// </summary>
		/// <param name="value">Valeur à écrire</param>
		public void WriteAllLines( string[] value )
		{
			if (fileDialog != FileDialogEnum.SaveFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return;

			File.WriteAllLines(Filename.Text, value);
		}

		/// <summary>
		/// Ecrit tout le texte vers le fichier
		/// </summary>
		/// <param name="value">Valeur à écrire</param>
		public void WriteAllText( string value )
		{
			if (fileDialog != FileDialogEnum.SaveFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return;

			File.WriteAllText(Filename.Text, value);
		}

		/// <summary>
		/// Ouvre le fichier en ecriture
		/// </summary>
		/// <returns>Filestream vers le fichier</returns>
		public FileStream OpenWrite()
		{
			if (fileDialog != FileDialogEnum.SaveFile)
				throw new NotImplementedException();

			if (Filename.Text.Trim() == string.Empty)
				if (ShowDialog() != DialogResult.OK) return null;

			return File.OpenWrite(Filename.Text);
		}

		#endregion

		private void Show_Click( object sender, EventArgs e )
		{
			ShowDialog();
		}

		private void Filename_DragDrop( object sender, DragEventArgs e )
		{
			if (fileDialog == FileDialogEnum.OpenFile && e.Data.GetDataPresent(DataFormats.FileDrop, true)) {
				string filename = (e.Data.GetData(DataFormats.FileDrop, true) as string[]).FirstOrDefault();
				Filename.Text = filename;
			}
		}

		private void Filename_DragOver( object sender, DragEventArgs e )
		{
			if (fileDialog == FileDialogEnum.OpenFile && e.Data.GetDataPresent(DataFormats.FileDrop, true)) {
				e.Effect = DragDropEffects.Copy;
			}
		}
	}


	public enum FileDialogEnum
	{
		OpenFile,
		SaveFile
	}
}
