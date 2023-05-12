using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	[Menu("Base 64", "Encodage texte")]
	public partial class Base64Encode : UserControl
	{
		public Base64Encode ()
		{
			InitializeComponent();
		}

		private void btnEncode_Click ( object sender, EventArgs e )
		{
			byte[] source = System.Text.Encoding.Default.GetBytes(Source.Text);
			Target.Text = Convert.ToBase64String(source);
		}
	}
}
