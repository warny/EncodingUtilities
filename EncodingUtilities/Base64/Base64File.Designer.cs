namespace EncodingUtilities
{
	partial class Base64File
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
			this.Encode = new System.Windows.Forms.Button();
			this.Decode = new System.Windows.Forms.Button();
			this.Base64Text = new System.Windows.Forms.TextBox();
			this.FilenameFrom = new EncodingUtilities.OpenFileBox();
			this.FilenameTo = new EncodingUtilities.OpenFileBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.Encode, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Decode, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.Base64Text, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.FilenameFrom, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.FilenameTo, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 340);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Encode
			// 
			this.Encode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Encode.Location = new System.Drawing.Point(357, 2);
			this.Encode.Margin = new System.Windows.Forms.Padding(2);
			this.Encode.Name = "Encode";
			this.Encode.Size = new System.Drawing.Size(96, 21);
			this.Encode.TabIndex = 0;
			this.Encode.Text = "Encoder";
			this.Encode.UseVisualStyleBackColor = true;
			this.Encode.Click += new System.EventHandler(this.Encode_Click);
			// 
			// Decode
			// 
			this.Decode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Decode.Location = new System.Drawing.Point(357, 317);
			this.Decode.Margin = new System.Windows.Forms.Padding(2);
			this.Decode.Name = "Decode";
			this.Decode.Size = new System.Drawing.Size(96, 21);
			this.Decode.TabIndex = 1;
			this.Decode.Text = "Décoder";
			this.Decode.UseVisualStyleBackColor = true;
			this.Decode.Click += new System.EventHandler(this.Decode_Click);
			// 
			// Base64Text
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Base64Text, 2);
			this.Base64Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Base64Text.Location = new System.Drawing.Point(3, 28);
			this.Base64Text.MaxLength = 2147483647;
			this.Base64Text.Multiline = true;
			this.Base64Text.Name = "Base64Text";
			this.Base64Text.Size = new System.Drawing.Size(449, 284);
			this.Base64Text.TabIndex = 6;
			// 
			// FilenameFrom
			// 
			this.FilenameFrom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilenameFrom.FileDialog = EncodingUtilities.FileDialogEnum.OpenFile;
			this.FilenameFrom.Location = new System.Drawing.Point(3, 3);
			this.FilenameFrom.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FilenameFrom.MinimumSize = new System.Drawing.Size(0, 20);
			this.FilenameFrom.Name = "FilenameFrom";
			this.FilenameFrom.Size = new System.Drawing.Size(349, 20);
			this.FilenameFrom.TabIndex = 7;
			// 
			// FilenameTo
			// 
			this.FilenameTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilenameTo.FileDialog = EncodingUtilities.FileDialogEnum.SaveFile;
			this.FilenameTo.Location = new System.Drawing.Point(3, 318);
			this.FilenameTo.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FilenameTo.MinimumSize = new System.Drawing.Size(25, 20);
			this.FilenameTo.Name = "FilenameTo";
			this.FilenameTo.Size = new System.Drawing.Size(349, 20);
			this.FilenameTo.TabIndex = 8;
			// 
			// Base64File
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Base64File";
			this.Size = new System.Drawing.Size(455, 340);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Encode;
		private System.Windows.Forms.Button Decode;
		private System.Windows.Forms.TextBox Base64Text;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private OpenFileBox FilenameFrom;
		private OpenFileBox FilenameTo;
	}
}
