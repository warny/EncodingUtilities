using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Hash", "Texte")]

	public partial class Hash : UserControl
	{
		static string[] HashAlgorithm = new string[] {
			"SHA1",
			"SHA256",
			"SHA384",
			"SHA512",
			"MD5",
			"RIPEMD160"
		};
	
		public Hash ()
		{
			InitializeComponent();

			Algorithm.Items.AddRange(HashAlgorithm);
			Algorithm.SelectedIndex = 0;
		}

		private void Compute_Click ( object sender, EventArgs e )
		{
			HashAlgorithm algorithm = System.Security.Cryptography.HashAlgorithm.Create(Algorithm.Text);

			byte[] source = System.Text.Encoding.Default.GetBytes(txtText.Text);

			byte[] result = algorithm.ComputeHash(source);

			StringBuilder HexaResult = new StringBuilder();
			foreach (byte Byte in result) {
				HexaResult.AppendFormat("{0:X2} ", Byte);
			}
			HexHash.Text = HexaResult.ToString();

			Base64Hash.Text = Convert.ToBase64String(result);
		}
	}
}
