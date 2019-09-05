namespace ConsultaAutorizacionSRI
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvIn = new System.Windows.Forms.DataGridView();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvOut = new System.Windows.Forms.DataGridView();
			this.btnPegar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOut)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvIn
			// 
			this.dgvIn.AllowDrop = true;
			this.dgvIn.AllowUserToDeleteRows = false;
			this.dgvIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvIn.Location = new System.Drawing.Point(3, 33);
			this.dgvIn.Name = "dgvIn";
			this.dgvIn.ReadOnly = true;
			this.dgvIn.Size = new System.Drawing.Size(386, 242);
			this.dgvIn.TabIndex = 0;
			// 
			// btnConsultar
			// 
			this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnConsultar.Location = new System.Drawing.Point(395, 3);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(497, 24);
			this.btnConsultar.TabIndex = 1;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.8806F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.1194F));
			this.tableLayoutPanel1.Controls.Add(this.dgvOut, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.dgvIn, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnPegar, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnConsultar, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 278);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// dgvOut
			// 
			this.dgvOut.AllowUserToAddRows = false;
			this.dgvOut.AllowUserToDeleteRows = false;
			this.dgvOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOut.Location = new System.Drawing.Point(395, 33);
			this.dgvOut.Name = "dgvOut";
			this.dgvOut.ReadOnly = true;
			this.dgvOut.Size = new System.Drawing.Size(497, 242);
			this.dgvOut.TabIndex = 1;
			// 
			// btnPegar
			// 
			this.btnPegar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPegar.Location = new System.Drawing.Point(3, 3);
			this.btnPegar.Name = "btnPegar";
			this.btnPegar.Size = new System.Drawing.Size(386, 24);
			this.btnPegar.TabIndex = 3;
			this.btnPegar.Text = "Pegar Portapapeles";
			this.btnPegar.UseVisualStyleBackColor = true;
			this.btnPegar.Click += new System.EventHandler(this.btnPegar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(895, 278);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOut)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvIn;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dgvOut;
		private System.Windows.Forms.Button btnPegar;
	}
}

