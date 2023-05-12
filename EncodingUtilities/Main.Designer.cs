namespace EncodingUtilities
{
	partial class Main
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent ()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.OpenedWindows = new System.Windows.Forms.TabControl();
			this.CloseTab = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(764, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// OpenedWindows
			// 
			this.OpenedWindows.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OpenedWindows.Location = new System.Drawing.Point(0, 24);
			this.OpenedWindows.Name = "OpenedWindows";
			this.OpenedWindows.SelectedIndex = 0;
			this.OpenedWindows.Size = new System.Drawing.Size(764, 546);
			this.OpenedWindows.TabIndex = 2;
			// 
			// CloseTab
			// 
			this.CloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseTab.Font = new System.Drawing.Font("Wingdings 2", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.CloseTab.Location = new System.Drawing.Point(742, 2);
			this.CloseTab.Name = "CloseTab";
			this.CloseTab.Size = new System.Drawing.Size(20, 20);
			this.CloseTab.TabIndex = 3;
			this.CloseTab.TabStop = false;
			this.CloseTab.Text = "O";
			this.CloseTab.UseVisualStyleBackColor = true;
			this.CloseTab.Click += new System.EventHandler(this.CloseTab_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 570);
			this.Controls.Add(this.CloseTab);
			this.Controls.Add(this.OpenedWindows);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "Encoding Utilities";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabControl OpenedWindows;
		private System.Windows.Forms.Button CloseTab;
    }
}

