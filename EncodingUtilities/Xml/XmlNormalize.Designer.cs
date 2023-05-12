namespace EncodingUtilities
{
    partial class XmlNormalize
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.Normalized = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Compute, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Normalized, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.txtText.Size = new System.Drawing.Size(398, 115);
            this.txtText.TabIndex = 0;
            // 
            // Compute
            // 
            this.Compute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compute.Location = new System.Drawing.Point(306, 244);
            this.Compute.Margin = new System.Windows.Forms.Padding(2);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(96, 21);
            this.Compute.TabIndex = 4;
            this.Compute.Text = "Calculer";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Normalized
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Normalized, 2);
            this.Normalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Normalized.Location = new System.Drawing.Point(3, 124);
            this.Normalized.Multiline = true;
            this.Normalized.Name = "Normalized";
            this.Normalized.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Normalized.Size = new System.Drawing.Size(398, 115);
            this.Normalized.TabIndex = 5;
            // 
            // XmlNomalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XmlNomalize";
            this.Size = new System.Drawing.Size(404, 267);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.TextBox Normalized;
    }
}
