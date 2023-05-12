namespace EncodingUtilities
{
	partial class OpenFileBox
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
			this.Filename = new System.Windows.Forms.TextBox();
			this.ShowForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Filename
			// 
			this.Filename.AllowDrop = true;
			this.Filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Filename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.Filename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.Filename.Location = new System.Drawing.Point(0, 0);
			this.Filename.Name = "Filename";
			this.Filename.Size = new System.Drawing.Size(375, 20);
			this.Filename.TabIndex = 0;
			this.Filename.DragDrop += new System.Windows.Forms.DragEventHandler(this.Filename_DragDrop);
			this.Filename.DragOver += new System.Windows.Forms.DragEventHandler(this.Filename_DragOver);
			// 
			// ShowForm
			// 
			this.ShowForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ShowForm.Location = new System.Drawing.Point(376, 0);
			this.ShowForm.Name = "ShowForm";
			this.ShowForm.Size = new System.Drawing.Size(25, 20);
			this.ShowForm.TabIndex = 1;
			this.ShowForm.Text = "...";
			this.ShowForm.UseVisualStyleBackColor = true;
			this.ShowForm.Click += new System.EventHandler(this.Show_Click);
			// 
			// OpenFileBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ShowForm);
			this.Controls.Add(this.Filename);
			this.MaximumSize = new System.Drawing.Size(1073741824, 20);
			this.MinimumSize = new System.Drawing.Size(25, 20);
			this.Name = "OpenFileBox";
			this.Size = new System.Drawing.Size(400, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Filename;
		private System.Windows.Forms.Button ShowForm;
	}
}
