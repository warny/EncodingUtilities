namespace EncodingUtilities
{
	partial class VerifySignature
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
			this.Verify = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Certificate = new System.Windows.Forms.TextBox();
			this.Signature = new System.Windows.Forms.TextBox();
			this.Result = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CertResult = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Hash = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Verify
			// 
			this.Verify.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Verify.Location = new System.Drawing.Point(3, 306);
			this.Verify.Name = "Verify";
			this.Verify.Size = new System.Drawing.Size(100, 20);
			this.Verify.TabIndex = 0;
			this.Verify.Text = "Vérifier";
			this.Verify.UseVisualStyleBackColor = true;
			this.Verify.Click += new System.EventHandler(this.Verify_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Verify, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.Certificate, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.Signature, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.Result, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.CertResult, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.Hash, 1, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 329);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// Certificate
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Certificate, 2);
			this.Certificate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Certificate.Location = new System.Drawing.Point(3, 23);
			this.Certificate.Multiline = true;
			this.Certificate.Name = "Certificate";
			this.Certificate.Size = new System.Drawing.Size(450, 113);
			this.Certificate.TabIndex = 1;
			this.Certificate.TextChanged += new System.EventHandler(this.Certificate_TextChanged);
			this.Certificate.Leave += new System.EventHandler(this.Certificate_Leave);
			// 
			// Signature
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.Signature, 2);
			this.Signature.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Signature.Location = new System.Drawing.Point(3, 162);
			this.Signature.Multiline = true;
			this.Signature.Name = "Signature";
			this.Signature.Size = new System.Drawing.Size(450, 113);
			this.Signature.TabIndex = 2;
			// 
			// Result
			// 
			this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Result.Location = new System.Drawing.Point(109, 306);
			this.Result.Name = "Result";
			this.Result.Size = new System.Drawing.Size(344, 20);
			this.Result.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Certificat :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Signature :";
			// 
			// CertResult
			// 
			this.CertResult.AutoSize = true;
			this.CertResult.Location = new System.Drawing.Point(109, 0);
			this.CertResult.Name = "CertResult";
			this.CertResult.Size = new System.Drawing.Size(83, 13);
			this.CertResult.TabIndex = 6;
			this.CertResult.Text = "Pas de certificat";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Hash :";
			// 
			// Hash
			// 
			this.Hash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Hash.Location = new System.Drawing.Point(109, 281);
			this.Hash.Name = "Hash";
			this.Hash.Size = new System.Drawing.Size(344, 20);
			this.Hash.TabIndex = 8;
			// 
			// VerifySignature
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "VerifySignature";
			this.Size = new System.Drawing.Size(456, 329);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Verify;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox Certificate;
		private System.Windows.Forms.TextBox Signature;
		private System.Windows.Forms.TextBox Result;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label CertResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Hash;
	}
}
