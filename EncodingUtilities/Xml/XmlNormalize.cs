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
	[Menu("Xml", "Normalisation C14N")]
	public partial class XmlNormalize : UserControl
	{
		public XmlNormalize()
		{
			InitializeComponent();
    	}

		private void Compute_Click ( object sender, EventArgs e )
		{
			XmlDocument source = new XmlDocument();
			try {
				source.LoadXml(txtText.Text);

                Normalized.Text = NormalizeXml(source);
			} catch (XmlException ex) {
				MessageBox.Show(ex.Message);
			}
		}

        public static string NormalizeXml( XmlDocument myDoc )
        {
            var t = new System.Security.Cryptography.Xml.XmlDsigC14NTransform();
            t.LoadInput(myDoc);
            using (var s = (Stream)t.GetOutput(typeof(Stream))) 
            using (var sr = new StreamReader(s)) {
                return sr.ReadToEnd();
            }
        }

    }
}
