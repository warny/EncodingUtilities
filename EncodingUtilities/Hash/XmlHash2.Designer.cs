namespace EncodingUtilities
{
	partial class XmlHash2
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
			this.txtText = new System.Windows.Forms.TextBox();
			this.Algorithm = new System.Windows.Forms.ComboBox();
			this.Compute = new System.Windows.Forms.Button();
			this.HexHash = new System.Windows.Forms.TextBox();
			this.Base64Hash = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.txtText, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Algorithm, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Compute, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.HexHash, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Base64Hash, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 267);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// txtText
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.txtText, 2);
			this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtText.Location = new System.Drawing.Point(3, 3);
			this.txtText.MaxLength = 2000000000;
			this.txtText.Multiline = true;
			this.txtText.Name = "txtText";
			this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtText.Size = new System.Drawing.Size(398, 186);
			this.txtText.TabIndex = 0;
			// 
			// Algorithm
			// 
			this.Algorithm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Algorithm.FormattingEnabled = true;
			this.Algorithm.Location = new System.Drawing.Point(3, 195);
			this.Algorithm.Name = "Algorithm";
			this.Algorithm.Size = new System.Drawing.Size(298, 21);
			this.Algorithm.TabIndex = 1;
			// 
			// Compute
			// 
			this.Compute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Compute.Location = new System.Drawing.Point(306, 194);
			this.Compute.Margin = new System.Windows.Forms.Padding(2);
			this.Compute.Name = "Compute";
			this.Compute.Size = new System.Drawing.Size(96, 21);
			this.Compute.TabIndex = 2;
			this.Compute.Text = "Calculer";
			this.Compute.UseVisualStyleBackColor = true;
			this.Compute.Click += new System.EventHandler(this.Compute_Click);
			// 
			// HexHash
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.HexHash, 2);
			this.HexHash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HexHash.Location = new System.Drawing.Point(3, 220);
			this.HexHash.Name = "HexHash";
			this.HexHash.ReadOnly = true;
			this.HexHash.Size = new System.Drawing.Size(398, 20);
			this.HexHash.TabIndex = 3;
			// 
			// Base64Hash
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Base64Hash, 2);
			this.Base64Hash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Base64Hash.Location = new System.Drawing.Point(3, 245);
			this.Base64Hash.Name = "Base64Hash";
			this.Base64Hash.ReadOnly = true;
			this.Base64Hash.Size = new System.Drawing.Size(398, 20);
			this.Base64Hash.TabIndex = 4;
			// 
			// XmlHash2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "XmlHash2";
			this.Size = new System.Drawing.Size(404, 267);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.ComboBox Algorithm;
		private System.Windows.Forms.Button Compute;
		private System.Windows.Forms.TextBox HexHash;
		private System.Windows.Forms.TextBox Base64Hash;
	}
}
