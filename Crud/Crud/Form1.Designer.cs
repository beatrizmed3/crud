namespace Crud
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbNovo = new System.Windows.Forms.ToolStripButton();
			this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
			this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
			this.tsbAlterar = new System.Windows.Forms.ToolStripButton();
			this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tstIdBuscar = new System.Windows.Forms.ToolStripLabel();
			this.tstBuscar = new System.Windows.Forms.ToolStripTextBox();
			this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtUf = new System.Windows.Forms.TextBox();
			this.mskCep = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Thistle;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbCancelar,
            this.tsbSalvar,
            this.tsbAlterar,
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tstIdBuscar,
            this.tstBuscar,
            this.tsbBuscar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(589, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbNovo
			// 
			this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
			this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNovo.Name = "tsbNovo";
			this.tsbNovo.Size = new System.Drawing.Size(23, 22);
			this.tsbNovo.Text = "Novo";
			this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
			// 
			// tsbCancelar
			// 
			this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
			this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCancelar.Name = "tsbCancelar";
			this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
			this.tsbCancelar.Text = "Cancelar";
			this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
			// 
			// tsbSalvar
			// 
			this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
			this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSalvar.Name = "tsbSalvar";
			this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
			this.tsbSalvar.Text = "Salvar";
			this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
			// 
			// tsbAlterar
			// 
			this.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlterar.Image")));
			this.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAlterar.Name = "tsbAlterar";
			this.tsbAlterar.Size = new System.Drawing.Size(23, 22);
			this.tsbAlterar.Text = "Alterar";
			this.tsbAlterar.Click += new System.EventHandler(this.tsbAlterar_Click);
			// 
			// tsbExcluir
			// 
			this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
			this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExcluir.Name = "tsbExcluir";
			this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
			this.tsbExcluir.Text = "Excluir";
			this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tstIdBuscar
			// 
			this.tstIdBuscar.Name = "tstIdBuscar";
			this.tstIdBuscar.Size = new System.Drawing.Size(76, 22);
			this.tstIdBuscar.Text = "Buscar por Id";
			// 
			// tstBuscar
			// 
			this.tstBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tstBuscar.Name = "tstBuscar";
			this.tstBuscar.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbBuscar
			// 
			this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
			this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbBuscar.Name = "tsbBuscar";
			this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
			this.tsbBuscar.Text = "Buscar";
			this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(94, 99);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(408, 20);
			this.txtNome.TabIndex = 3;
			this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(27, 162);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(475, 20);
			this.txtEndereco.TabIndex = 4;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(97, 224);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(182, 20);
			this.txtBairro.TabIndex = 5;
			this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Endereço:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "CEP:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(94, 208);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Bairro:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(280, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Cidade:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(457, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "UF:";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(283, 224);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(171, 20);
			this.txtCidade.TabIndex = 13;
			// 
			// txtUf
			// 
			this.txtUf.Location = new System.Drawing.Point(460, 224);
			this.txtUf.Name = "txtUf";
			this.txtUf.Size = new System.Drawing.Size(42, 20);
			this.txtUf.TabIndex = 14;
			// 
			// mskCep
			// 
			this.mskCep.Location = new System.Drawing.Point(27, 224);
			this.mskCep.Mask = "00000-000";
			this.mskCep.Name = "mskCep";
			this.mskCep.Size = new System.Drawing.Size(64, 20);
			this.mskCep.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(27, 271);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Telefone:";
			// 
			// mskTelefone
			// 
			this.mskTelefone.Location = new System.Drawing.Point(27, 287);
			this.mskTelefone.Mask = "(00)00000-0000";
			this.mskTelefone.Name = "mskTelefone";
			this.mskTelefone.Size = new System.Drawing.Size(90, 20);
			this.mskTelefone.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Id:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(30, 98);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(37, 20);
			this.txtId.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(589, 482);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mskTelefone);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.mskCep);
			this.Controls.Add(this.txtUf);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alunos";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbNovo;
		private System.Windows.Forms.ToolStripButton tsbCancelar;
		private System.Windows.Forms.ToolStripButton tsbSalvar;
		private System.Windows.Forms.ToolStripButton tsbAlterar;
		private System.Windows.Forms.ToolStripButton tsbExcluir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tstIdBuscar;
		private System.Windows.Forms.ToolStripTextBox tstBuscar;
		private System.Windows.Forms.ToolStripButton tsbBuscar;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtUf;
		private System.Windows.Forms.MaskedTextBox mskCep;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox mskTelefone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtId;
	}
}

