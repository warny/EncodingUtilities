﻿namespace EncodingUtilities
{
	partial class Base64Encode
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Source = new System.Windows.Forms.TextBox();
			this.Target = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEncode = new System.Windows.Forms.Button();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
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
			this.splitContainer1.Size = new System.Drawing.Size(451, 344);
			this.splitContainer1.SplitterDistance = 178;
			this.splitContainer1.TabIndex = 0;
			// 
			// Source
			// 
			this.Source.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Source.Location = new System.Drawing.Point(0, 0);
			this.Source.Multiline = true;
			this.Source.Name = "Source";
			this.Source.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Source.Size = new System.Drawing.Size(451, 178);
			this.Source.TabIndex = 0;
			// 
			// Target
			// 
			this.Target.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Target.Location = new System.Drawing.Point(0, 0);
			this.Target.Multiline = true;
			this.Target.Name = "Target";
			this.Target.ReadOnly = true;
			this.Target.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Target.Size = new System.Drawing.Size(451, 162);
			this.Target.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.btnEncode, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 375);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(3, 353);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(75, 19);
			this.btnEncode.TabIndex = 0;
			this.btnEncode.Text = "Encoder";
			this.btnEncode.UseVisualStyleBackColor = true;
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// Base64Encode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 375);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Base64Encode";
			this.Text = "Base64Encode";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox Source;
		private System.Windows.Forms.TextBox Target;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnEncode;
	}
}