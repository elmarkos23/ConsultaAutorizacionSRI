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
      this.btnPegar = new System.Windows.Forms.Button();
      this.lblOut = new System.Windows.Forms.Label();
      this.lblIn = new System.Windows.Forms.Label();
      this.barra = new System.Windows.Forms.ProgressBar();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.gvAutorizados = new System.Windows.Forms.DataGridView();
      this.gvNoAutorizados = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvAutorizados)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvNoAutorizados)).BeginInit();
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
      this.dgvIn.Size = new System.Drawing.Size(386, 212);
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
      this.tableLayoutPanel1.Controls.Add(this.dgvIn, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnPegar, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnConsultar, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblOut, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblIn, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.barra, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 278);
      this.tableLayoutPanel1.TabIndex = 2;
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
      // lblOut
      // 
      this.lblOut.AutoSize = true;
      this.lblOut.Location = new System.Drawing.Point(395, 248);
      this.lblOut.Name = "lblOut";
      this.lblOut.Size = new System.Drawing.Size(16, 13);
      this.lblOut.TabIndex = 4;
      this.lblOut.Text = "...";
      // 
      // lblIn
      // 
      this.lblIn.AutoSize = true;
      this.lblIn.Location = new System.Drawing.Point(3, 248);
      this.lblIn.Name = "lblIn";
      this.lblIn.Size = new System.Drawing.Size(16, 13);
      this.lblIn.TabIndex = 5;
      this.lblIn.Text = "...";
      // 
      // barra
      // 
      this.barra.Dock = System.Windows.Forms.DockStyle.Fill;
      this.barra.Location = new System.Drawing.Point(395, 271);
      this.barra.Name = "barra";
      this.barra.Size = new System.Drawing.Size(497, 4);
      this.barra.TabIndex = 6;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(395, 33);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(497, 212);
      this.tabControl1.TabIndex = 7;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.gvAutorizados);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(489, 186);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Autorizados";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.gvNoAutorizados);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(489, 186);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "No Autorizados";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // gvAutorizados
      // 
      this.gvAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvAutorizados.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvAutorizados.Location = new System.Drawing.Point(3, 3);
      this.gvAutorizados.Name = "gvAutorizados";
      this.gvAutorizados.Size = new System.Drawing.Size(483, 180);
      this.gvAutorizados.TabIndex = 0;
      // 
      // gvNoAutorizados
      // 
      this.gvNoAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvNoAutorizados.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvNoAutorizados.Location = new System.Drawing.Point(3, 3);
      this.gvNoAutorizados.Name = "gvNoAutorizados";
      this.gvNoAutorizados.Size = new System.Drawing.Size(483, 180);
      this.gvNoAutorizados.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(895, 278);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Validación Documentos";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvIn)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvAutorizados)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvNoAutorizados)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvIn;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnPegar;
		private System.Windows.Forms.Label lblOut;
		private System.Windows.Forms.Label lblIn;
		private System.Windows.Forms.ProgressBar barra;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.DataGridView gvAutorizados;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridView gvNoAutorizados;
  }
}

