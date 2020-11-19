namespace CamadaDesktop
{
    partial class frmListaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaUsuario));
            this.dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsultar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnCriar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.pxCarregando2 = new System.Windows.Forms.PictureBox();
            this.lblCarregando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregando2)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.ColumnHeadersHeight = 30;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.colConsultar,
            this.colEditar,
            this.colExcluir});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(25, 127);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg.RowHeadersVisible = false;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(845, 391);
            this.dg.TabIndex = 3;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 500;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Login";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Login";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ativo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Ativo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // colConsultar
            // 
            this.colConsultar.HeaderText = "";
            this.colConsultar.Image = ((System.Drawing.Image)(resources.GetObject("colConsultar.Image")));
            this.colConsultar.Name = "colConsultar";
            this.colConsultar.ReadOnly = true;
            this.colConsultar.Visible = false;
            this.colConsultar.Width = 25;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Image = ((System.Drawing.Image)(resources.GetObject("colEditar.Image")));
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Visible = false;
            this.colEditar.Width = 25;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "";
            this.colExcluir.Image = ((System.Drawing.Image)(resources.GetObject("colExcluir.Image")));
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.ReadOnly = true;
            this.colExcluir.Visible = false;
            this.colExcluir.Width = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar Nome";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisar.Location = new System.Drawing.Point(28, 91);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(367, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // btnCriar
            // 
            this.btnCriar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCriar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCriar.IconColor = System.Drawing.Color.White;
            this.btnCriar.IconSize = 32;
            this.btnCriar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriar.Location = new System.Drawing.Point(544, 65);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Rotation = 0D;
            this.btnCriar.Size = new System.Drawing.Size(137, 46);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Novo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Visible = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnBuscar.IconColor = System.Drawing.Color.White;
            this.btnBuscar.IconSize = 32;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(401, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Rotation = 0D;
            this.btnBuscar.Size = new System.Drawing.Size(137, 46);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Pesquisar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pxCarregando2
            // 
            this.pxCarregando2.Image = ((System.Drawing.Image)(resources.GetObject("pxCarregando2.Image")));
            this.pxCarregando2.Location = new System.Drawing.Point(33, 188);
            this.pxCarregando2.Name = "pxCarregando2";
            this.pxCarregando2.Size = new System.Drawing.Size(217, 23);
            this.pxCarregando2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pxCarregando2.TabIndex = 17;
            this.pxCarregando2.TabStop = false;
            this.pxCarregando2.Visible = false;
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.White;
            this.lblCarregando.Location = new System.Drawing.Point(34, 166);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(117, 19);
            this.lblCarregando.TabIndex = 16;
            this.lblCarregando.Text = "Carregando...";
            this.lblCarregando.Visible = false;
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 626);
            this.Controls.Add(this.pxCarregando2);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmListaUsuario";
            this.Text = "frmListaUsuario";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxCarregando2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private FontAwesome.Sharp.IconButton btnCriar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn colConsultar;
        private System.Windows.Forms.DataGridViewImageColumn colEditar;
        private System.Windows.Forms.DataGridViewImageColumn colExcluir;
        private System.Windows.Forms.PictureBox pxCarregando2;
        private System.Windows.Forms.Label lblCarregando;
    }
}