namespace EncodingUtilities
{
	partial class ReadCertificate
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent ()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ExportName = new EncodingUtilities.OpenFileBox();
			this.Export = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Source = new System.Windows.Forms.TextBox();
			this.Target = new System.Windows.Forms.TextBox();
			this.Decode = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.ExportName, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Export, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Decode, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 326);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ExportName
			// 
			this.ExportName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExportName.FileDialog = EncodingUtilities.FileDialogEnum.SaveFile;
			this.ExportName.Location = new System.Drawing.Point(3, 304);
			this.ExportName.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.ExportName.MinimumSize = new System.Drawing.Size(25, 20);
			this.ExportName.Name = "ExportName";
			this.ExportName.Size = new System.Drawing.Size(362, 20);
			this.ExportName.TabIndex = 0;
			// 
			// Export
			// 
			this.Export.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Export.Location = new System.Drawing.Point(371, 304);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(94, 19);
			this.Export.TabIndex = 1;
			this.Export.Text = "Exporter";
			this.Export.UseVisualStyleBackColor = true;
			this.Export.Click += new System.EventHandler(this.Export_Click);
			// 
			// splitContainer1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 2);
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Source);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Target);
			this.splitContainer1.Size = new System.Drawing.Size(462, 270);
			this.splitContainer1.SplitterDistance = 132;
			this.splitContainer1.TabIndex = 2;
			// 
			// Source
			// 
			this.Source.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Source.Location = new System.Drawing.Point(0, 0);
			this.Source.MaxLength = 2147483647;
			this.Source.Multiline = true;
			this.Source.Name = "Source";
			this.Source.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Source.Size = new System.Drawing.Size(462, 132);
			this.Source.TabIndex = 0;
			// 
			// Target
			// 
			this.Target.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Target.Location = new System.Drawing.Point(0, 0);
			this.Target.MaxLength = 2147483647;
			this.Target.Multiline = true;
			this.Target.Name = "Target";
			this.Target.ReadOnly = true;
			this.Target.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Target.Size = new System.Drawing.Size(462, 134);
			this.Target.TabIndex = 0;
			// 
			// Decode
			// 
			this.Decode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Decode.Location = new System.Drawing.Point(371, 279);
			this.Decode.Name = "Decode";
			this.Decode.Size = new System.Drawing.Size(94, 19);
			this.Decode.TabIndex = 3;
			this.Decode.Text = "Décoder";
			this.Decode.UseVisualStyleBackColor = true;
			this.Decode.Click += new System.EventHandler(this.Decode_Click);
			// 
			// ReadCertificate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ReadCertificate";
			this.Size = new System.Drawing.Size(468, 326);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private OpenFileBox ExportName;
		private System.Windows.Forms.Button Export;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox Source;
		private System.Windows.Forms.TextBox Target;
		private System.Windows.Forms.Button Decode;
	}
}
