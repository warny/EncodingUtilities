using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using EncodingUtilities.Core;

namespace EncodingUtilities
{
	public partial class Main : Form
	{
		public Main ()
		{
			InitializeComponent();

			var a = Assembly.GetExecutingAssembly();
			foreach (Type t in a.GetTypes()) {
				if (!typeof(UserControl).IsAssignableFrom(t)) continue;
				MenuAttribute menuAttribute = t.GetCustomAttribute<MenuAttribute>(true);
				if (menuAttribute == null) continue;
				menuAttribute.AddToMenu(menuStrip1, this, t);
			}
		}

		public void ShowForm ( UserControl form, string tabName )
		{
			TabPage tab = new TabPage(tabName);
			tab.Controls.Add(form);
			form.Dock = DockStyle.Fill;

			OpenedWindows.TabPages.Add(tab);

			OpenedWindows.SelectedTab = tab;
		}

		private void CloseTab_Click ( object sender, EventArgs e )
		{
			if(OpenedWindows.SelectedTab!= null)
				OpenedWindows.TabPages.Remove(OpenedWindows.SelectedTab);
		}

	}
}
