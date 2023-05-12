namespace EncodingUtilities
{
	partial class ViewCertificate
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose( bool disposing )
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
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.File = new EncodingUtilities.OpenFileBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.Decode = new System.Windows.Forms.Button();
			this.Target = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FilePfx = new EncodingUtilities.OpenFileBox();
			this.FileCer = new EncodingUtilities.OpenFileBox();
			this.SavePfx = new System.Windows.Forms.Button();
			this.SaveCer = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.ExportPassword = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.File, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Password, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.Decode, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.Target, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.FilePfx, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.FileCer, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.SavePfx, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.SaveCer, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.ExportPassword, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 396);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// File
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.File, 2);
			this.File.Dock = System.Windows.Forms.DockStyle.Fill;
			this.File.FileDialog = EncodingUtilities.FileDialogEnum.OpenFile;
			this.File.Filter = "Tous les fichiers(*.*)|*.*|Certificat (*.cer, *.crt)|*.cer;*.crt|Clef privée (*.p" +
    "fx, *.p12)|*.pfx;*.p12";
			this.File.Location = new System.Drawing.Point(103, 274);
			this.File.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.File.MinimumSize = new System.Drawing.Size(25, 20);
			this.File.Name = "File";
			this.File.Size = new System.Drawing.Size(418, 20);
			this.File.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 271);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fichier";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mot de passe";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Password
			// 
			this.Password.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Password.Location = new System.Drawing.Point(103, 299);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(318, 20);
			this.Password.TabIndex = 3;
			// 
			// Decode
			// 
			this.Decode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Decode.Location = new System.Drawing.Point(427, 299);
			this.Decode.Name = "Decode";
			this.Decode.Size = new System.Drawing.Size(94, 19);
			this.Decode.TabIndex = 4;
			this.Decode.Text = "Décoder";
			this.Decode.UseVisualStyleBackColor = true;
			this.Decode.Click += new System.EventHandler(this.Decode_Click);
			// 
			// Target
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Target, 3);
			this.Target.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Target.Location = new System.Drawing.Point(3, 3);
			this.Target.Multiline = true;
			this.Target.Name = "Target";
			this.Target.Size = new System.Drawing.Size(518, 265);
			this.Target.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 321);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Exporter PFX";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 371);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Exporter CER";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FilePfx
			// 
			this.FilePfx.DefaultExtension = "*.pfx";
			this.FilePfx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilePfx.Enabled = false;
			this.FilePfx.FileDialog = EncodingUtilities.FileDialogEnum.SaveFile;
			this.FilePfx.Filter = "Certificat avec clef privée (*.pfx)|*.pfx";
			this.FilePfx.Location = new System.Drawing.Point(103, 324);
			this.FilePfx.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FilePfx.MinimumSize = new System.Drawing.Size(25, 20);
			this.FilePfx.Name = "FilePfx";
			this.FilePfx.Size = new System.Drawing.Size(318, 20);
			this.FilePfx.TabIndex = 8;
			// 
			// FileCer
			// 
			this.FileCer.DefaultExtension = "*.cer";
			this.FileCer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileCer.Enabled = false;
			this.FileCer.FileDialog = EncodingUtilities.FileDialogEnum.SaveFile;
			this.FileCer.Filter = "Certificats (*.cer)|*.cer";
			this.FileCer.Location = new System.Drawing.Point(103, 374);
			this.FileCer.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FileCer.MinimumSize = new System.Drawing.Size(25, 20);
			this.FileCer.Name = "FileCer";
			this.FileCer.Size = new System.Drawing.Size(318, 20);
			this.FileCer.TabIndex = 9;
			// 
			// SavePfx
			// 
			this.SavePfx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SavePfx.Enabled = false;
			this.SavePfx.Location = new System.Drawing.Point(427, 324);
			this.SavePfx.Name = "SavePfx";
			this.tableLayoutPanel1.SetRowSpan(this.SavePfx, 2);
			this.SavePfx.Size = new System.Drawing.Size(94, 44);
			this.SavePfx.TabIndex = 10;
			this.SavePfx.Text = "Créer Pfx";
			this.SavePfx.UseVisualStyleBackColor = true;
			this.SavePfx.Click += new System.EventHandler(this.SavePfx_Click);
			// 
			// SaveCer
			// 
			this.SaveCer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SaveCer.Enabled = false;
			this.SaveCer.Location = new System.Drawing.Point(427, 374);
			this.SaveCer.Name = "SaveCer";
			this.SaveCer.Size = new System.Drawing.Size(94, 19);
			this.SaveCer.TabIndex = 11;
			this.SaveCer.Text = "Créer Cer";
			this.SaveCer.UseVisualStyleBackColor = true;
			this.SaveCer.Click += new System.EventHandler(this.SaveCer_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 25);
			this.label5.TabIndex = 12;
			this.label5.Text = "Mot de passe";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ExportPassword
			// 
			this.ExportPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExportPassword.Enabled = false;
			this.ExportPassword.Location = new System.Drawing.Point(103, 349);
			this.ExportPassword.Name = "ExportPassword";
			this.ExportPassword.Size = new System.Drawing.Size(318, 20);
			this.ExportPassword.TabIndex = 13;
			// 
			// ViewCertificate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ViewCertificate";
			this.Size = new System.Drawing.Size(524, 396);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private OpenFileBox File;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Button Decode;
		private System.Windows.Forms.TextBox Target;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private OpenFileBox FilePfx;
		private OpenFileBox FileCer;
		private System.Windows.Forms.Button SavePfx;
		private System.Windows.Forms.Button SaveCer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ExportPassword;
	}
}
