using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Signature", "Vérification")]
	public partial class VerifySignature : UserControl
	{
		X509Certificate2 certificate;

		public VerifySignature ()
		{
			base.Text = "Vérification signature";
			InitializeComponent();
		}

		private void Verify_Click ( object sender, EventArgs e )
		{
			byte[] hash = Convert.FromBase64String(Hash.Text);
			byte[] signature = Convert.FromBase64String(Signature.Text);
			RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)certificate.PublicKey.Key;
			if (rsa.VerifyHash(hash, "SHA1", signature)) {
				Result.Text = "Signature OK";
			} else {
				Result.Text = "Signature invalide";
			}

		}

		private void Certificate_Leave ( object sender, EventArgs e )
		{
			if (String.IsNullOrWhiteSpace(CertResult.Text)) {
				CertResult.Text = "Pas de certificat";
			}
			try {
				certificate = new X509Certificate2(Convert.FromBase64String(Certificate.Text));
				CertResult.Text = certificate.FriendlyName;
			} catch (Exception ex) {
				CertResult.Text = String.Format("ERREUR : {0}", ex.Message);
				certificate = null;				
			}
			Verify.Enabled = certificate != null;
		}

		private void Certificate_TextChanged ( object sender, EventArgs e )
		{
		}
	}
}
