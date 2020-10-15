namespace CamadaDesktop
{
    partial class frmListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaClientes));
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new FontAwesome.Sharp.IconButton();
            this.dgFisica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsultar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFisica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPesquisar.IconColor = System.Drawing.Color.White;
            this.btnPesquisar.IconSize = 32;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(425, 59);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Rotation = 0D;
            this.btnPesquisar.Size = new System.Drawing.Size(137, 46);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisar.Location = new System.Drawing.Point(52, 85);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(367, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar Nome";
            // 
            // btnNovo
            // 
            this.btnNovo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNovo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNovo.IconColor = System.Drawing.Color.White;
            this.btnNovo.IconSize = 32;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(568, 59);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Rotation = 0D;
            this.btnNovo.Size = new System.Drawing.Size(137, 46);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgFisica
            // 
            this.dgFisica.AllowUserToOrderColumns = true;
            this.dgFisica.AllowUserToResizeColumns = false;
            this.dgFisica.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgFisica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFisica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.dgFisica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFisica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgFisica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFisica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFisica.ColumnHeadersHeight = 30;
            this.dgFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgFisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column10,
            this.colConsultar,
            this.colEditar,
            this.colExcluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFisica.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgFisica.EnableHeadersVisualStyles = false;
            this.dgFisica.Location = new System.Drawing.Point(52, 121);
            this.dgFisica.MultiSelect = false;
            this.dgFisica.Name = "dgFisica";
            this.dgFisica.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFisica.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFisica.RowHeadersVisible = false;
            this.dgFisica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFisica.Size = new System.Drawing.Size(822, 375);
            this.dgFisica.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CPF";
            this.Column2.HeaderText = "CPF";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Email";
            this.Column9.HeaderText = "Email";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 250;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Telefone";
            this.Column10.HeaderText = "Telefone";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 120;
            // 
            // colConsultar
            // 
            this.colConsultar.HeaderText = "";
            this.colConsultar.Image = ((System.Drawing.Image)(resources.GetObject("colConsultar.Image")));
            this.colConsultar.Name = "colConsultar";
            this.colConsultar.ReadOnly = true;
            this.colConsultar.Width = 25;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Width = 25;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Width = 25;
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.dgFisica);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "frmListaClientes";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFisica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnNovo;
        private System.Windows.Forms.DataGridView dgFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewImageColumn colConsultar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
    }
}