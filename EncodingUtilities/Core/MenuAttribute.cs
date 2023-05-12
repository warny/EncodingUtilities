using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncodingUtilities.Core
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	class MenuAttribute	: Attribute
	{
		public IEnumerable<string> Menu { get; }

		public MenuAttribute( params string[] menu )
		{
			Menu = menu;
		}

		public void AddToMenu(MenuStrip menuStrip, Main main, Type controlType)
		{
			if (!typeof(UserControl).IsAssignableFrom(controlType)) return;

			ToolStripItemCollection items = menuStrip.Items;
			ToolStripMenuItem item = null;
			foreach (var menuItem in Menu) {
				if (items.ContainsKey(menuItem)) {
					item = (ToolStripMenuItem)items[menuItem];
				} else {
					item = new ToolStripMenuItem(menuItem);
					item.Name = menuItem;
					bool inserted = false;
					for (int i = 0 ; i < items.Count ; i++) {
						ToolStripMenuItem indexItem = (ToolStripMenuItem)items[i];
						if (string.Compare(menuItem, indexItem.Text) < 0) {
							items.Insert(i, item);
							inserted = true;
							break;
						}
					}
					if (!inserted) {
						items.Add(item);
					}
				}
				items = item.DropDownItems;
			}

			item.Click+=(sender, e) => {
				UserControl control = (UserControl)Activator.CreateInstance(controlType);
				main.ShowForm(control, string.Join(" ► ", Menu));
			};
		}

	}
}
