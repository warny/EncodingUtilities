namespace EncodingUtilities
{
	partial class LongFile
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
			this.FilenameFrom = new EncodingUtilities.OpenFileBox();
			this.FilenameTo = new EncodingUtilities.OpenFileBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ChEncode = new System.Windows.Forms.RadioButton();
			this.ChDecode = new System.Windows.Forms.RadioButton();
			this.execute = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.FilenameFrom, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.FilenameTo, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.ChEncode, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ChDecode, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.execute, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 435);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// FilenameFrom
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.FilenameFrom, 2);
			this.FilenameFrom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilenameFrom.FileDialog = EncodingUtilities.FileDialogEnum.OpenFile;
			this.FilenameFrom.Location = new System.Drawing.Point(121, 3);
			this.FilenameFrom.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FilenameFrom.MinimumSize = new System.Drawing.Size(0, 20);
			this.FilenameFrom.Name = "FilenameFrom";
			this.FilenameFrom.Size = new System.Drawing.Size(665, 20);
			this.FilenameFrom.TabIndex = 7;
			// 
			// FilenameTo
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.FilenameTo, 2);
			this.FilenameTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FilenameTo.FileDialog = EncodingUtilities.FileDialogEnum.SaveFile;
			this.FilenameTo.Location = new System.Drawing.Point(121, 78);
			this.FilenameTo.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.FilenameTo.MinimumSize = new System.Drawing.Size(25, 20);
			this.FilenameTo.Name = "FilenameTo";
			this.FilenameTo.Size = new System.Drawing.Size(665, 20);
			this.FilenameTo.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "Source";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Cible";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ChEncode
			// 
			this.ChEncode.AutoSize = true;
			this.ChEncode.Checked = true;
			this.ChEncode.Location = new System.Drawing.Point(121, 28);
			this.ChEncode.Name = "ChEncode";
			this.ChEncode.Size = new System.Drawing.Size(66, 17);
			this.ChEncode.TabIndex = 11;
			this.ChEncode.TabStop = true;
			this.ChEncode.Text = "Decoder";
			this.ChEncode.UseVisualStyleBackColor = true;
			// 
			// ChDecode
			// 
			this.ChDecode.AutoSize = true;
			this.ChDecode.Location = new System.Drawing.Point(121, 53);
			this.ChDecode.Name = "ChDecode";
			this.ChDecode.Size = new System.Drawing.Size(65, 17);
			this.ChDecode.TabIndex = 12;
			this.ChDecode.Text = "Encoder";
			this.ChDecode.UseVisualStyleBackColor = true;
			// 
			// execute
			// 
			this.execute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.execute.Location = new System.Drawing.Point(692, 28);
			this.execute.Name = "execute";
			this.tableLayoutPanel1.SetRowSpan(this.execute, 2);
			this.execute.Size = new System.Drawing.Size(94, 44);
			this.execute.TabIndex = 13;
			this.execute.Text = "Executer";
			this.execute.UseVisualStyleBackColor = true;
			this.execute.Click += new System.EventHandler(this.execute_Click);
			// 
			// LongFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "LongFile";
			this.Size = new System.Drawing.Size(789, 435);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private OpenFileBox FilenameFrom;
		private OpenFileBox FilenameTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton ChEncode;
		private System.Windows.Forms.RadioButton ChDecode;
		private System.Windows.Forms.Button execute;
	}
}
