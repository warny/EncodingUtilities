using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using EncodingUtilities.Certificates;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Certificats", "Base 64")]
	public partial class ReadCertificate : UserControl
	{
		public ReadCertificate ()
		{
			InitializeComponent();
		}

		private void Decode_Click ( object sender, EventArgs e )
		{
			try {
				byte[] datas = Convert.FromBase64String(Source.Text);
				X509Certificate2 cer = new X509Certificate2(datas);

				this.Target.Text = CertificateUtils.ReadCertificatContent(cer);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void Export_Click ( object sender, EventArgs e )
		{
			if (ExportName.Text.EndsWith(".cer")) {
				byte[] datas = Convert.FromBase64String(Source.Text);
				X509Certificate2 cer = new X509Certificate2(datas);

				ExportName.WriteAllBytes(cer.Export(X509ContentType.Cert));
				return;
			} 
			//else if (ExportName.Text.EndsWith(".p12") || ExportName.Text.EndsWith(".pfx")) {
			//    byte[] datas = Convert.FromBase64String(Source.Text);
			//    X509Certificate2 cer = new X509Certificate2(datas);

			//    MessageBox.Show

			//    ExportName.WriteAllBytes(cer.Export(X509ContentType.Cert));
			//    return;
			//}
		}

	}
}
