using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EncodingUtilities.Certificates;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	using System.Security.Cryptography.X509Certificates;
	using EncodingUtilities.Core;
	[Menu("Certificats", "Fichier")]
	public partial class ViewCertificate : UserControl
	{
		X509Certificate2 certificate;

		public ViewCertificate()
		{
			InitializeComponent();
		}

		private void Decode_Click( object sender, EventArgs e )
		{
			try {
				certificate = new X509Certificate2(File.Text, Password.Text, X509KeyStorageFlags.Exportable);
				this.Target.Text = CertificateUtils.ReadCertificatContent(certificate);

				FilePfx.Enabled = certificate.HasPrivateKey;
				SavePfx.Enabled = certificate.HasPrivateKey;
				ExportPassword.Enabled = certificate.HasPrivateKey;
				FileCer.Enabled = true;
				SaveCer.Enabled = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		private void SaveCer_Click( object sender, EventArgs e )
		{
			byte[] content = certificate.Export(X509ContentType.Cert);
			FileCer.WriteAllBytes(content);
		}

		private void SavePfx_Click( object sender, EventArgs e )
		{
			if (ExportPassword.Text=="") {
				MessageBox.Show("Veuillez saisir un mot de passe d'export");
				return;
			}
			byte[] content = certificate.Export(X509ContentType.Pfx, ExportPassword.Text);
			FilePfx.WriteAllBytes(content);
		}
	}
}
