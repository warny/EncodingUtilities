using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.Reflection;
using System.IO;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Hash", "Xml(2)")]
	public partial class XmlHash2 : UserControl
	{
		static string[] HashAlgorithm = new string[] {
			"SHA1",
			"SHA256",
			"SHA384",
			"SHA512",
			"MD5",
			"RIPEMD160"
		};

		public XmlHash2 ()
		{
			InitializeComponent();

			Algorithm.Items.AddRange(HashAlgorithm);
			Algorithm.SelectedIndex = 0;
		}

		private void Compute_Click ( object sender, EventArgs e )
		{
			HashAlgorithm algorithm = System.Security.Cryptography.HashAlgorithm.Create(Algorithm.Text);

			XmlDocument source = new XmlDocument();
			try {
				source.LoadXml(txtText.Text);

				byte[] result = HashXml(source, algorithm);

				StringBuilder HexaResult = new StringBuilder();
				foreach (byte Byte in result) {
					HexaResult.AppendFormat("{0:X2} ",Byte);
				}
				HexHash.Text = HexaResult.ToString();

				Base64Hash.Text = Convert.ToBase64String(result);
			} catch (XmlException ex) {
				MessageBox.Show(ex.Message);
			}
		}

        public static byte[] HashXml( XmlDocument myDoc, HashAlgorithm hash )
        {
            var t = new System.Security.Cryptography.Xml.XmlDsigC14NTransform();
            t.LoadInput(myDoc);
            using (var s = (Stream)t.GetOutput(typeof(Stream))) {
                return hash.ComputeHash(s);
            }
        }



	}
}
