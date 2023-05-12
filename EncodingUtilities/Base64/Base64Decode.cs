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
	[Menu("Base 64", "Décodage texte")]
	public partial class Base64Decode : UserControl
	{
		public Base64Decode ()
		{
			InitializeComponent();
		}

		private void btnEncode_Click ( object sender, EventArgs e )
		{
			try {
				byte[] target = Convert.FromBase64String(Source.Text);
				Target.Text = System.Text.Encoding.Default.GetString(target);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Target.Text = ex.Message;
			}
		}
	}
}
