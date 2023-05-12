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
	public partial class LongFile : UserControl
	{
		public LongFile ()
		{
			InitializeComponent();
		}

		private void execute_Click ( object sender, EventArgs e )
		{
			if (ChDecode.Checked) decode();
			if (ChEncode.Checked) encode();
		}

		private void decode ()
		{
			using (TextReader source = new StreamReader(File.OpenRead(FilenameFrom.Text)))
			using (Stream target = File.OpenWrite(FilenameTo.Text)) {
				while (true) {
					char[] block = new char[4];
					
				}
			}
			
		}

		private void encode ()
		{
		}
	}
}
