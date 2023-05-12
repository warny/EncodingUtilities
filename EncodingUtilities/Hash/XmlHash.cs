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
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Hash", "Xml(1)")]

	public partial class XmlHash : UserControl
	{
		static string[] HashAlgorithm = new string[] {
			"SHA1",
			"SHA256",
			"SHA384",
			"SHA512",
			"MD5",
			"RIPEMD160"
		};

		public XmlHash ()
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


		#region Fonctions statiques
		public static byte[] HashXml ( XmlElement xe, HashAlgorithm hash )
		{
			XmlDocument xd = new XmlDocument();
			xd.LoadXml(xe.OuterXml);
			return HashXml(xd, hash);
		}

		public static byte[] HashXml ( XmlDocument xd, HashAlgorithm hash )
		{
			Assembly a = Assembly.Load("System.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
			Type t = a.GetType("System.Security.Cryptography.Xml.CanonicalXml");
			ConstructorInfo c = t.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XmlDocument), typeof(XmlResolver) }, null);
			object cx = c.Invoke(new object[] { xd, null });
			byte[] result = (byte[])t.InvokeMember("GetDigestedBytes", BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance, null, cx, new object[] { hash });
			return result;
		}
		#endregion

	}
}
