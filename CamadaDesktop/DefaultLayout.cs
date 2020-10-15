using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;

namespace CamadaDesktop
{
    public class DefaultLayout
    {
        public void FormDefaultFilha(Form form, List<IconButton> iconButtons)
        {

            //Default Form
            form.Size = new Size(976, 665);
            form.BackColor = Color.FromArgb(66, 34, 125);
            form.ForeColor = Color.White;

            //Default Label
            //foreach (TextBox textBox in textBoxes)
            //{
            //    textBox.BackColor=Color.FromArgb(66, 34, 125);
            //    textBox.BorderStyle = BorderStyle.None;
            //    textBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            //    textBox.ForeColor = System.Drawing.Color.White;
            //}

            //Default Button
            foreach (IconButton button in iconButtons)
            {
                button.BackColor = Color.FromArgb(38, 50, 56);
                button.FlatStyle = FlatStyle.Flat;
                button.Flip = FlipOrientation.Normal;
                button.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                button.ForeColor = Color.White;
                button.IconColor = Color.White;
                button.IconSize = 32;
                button.Size = new Size(137, 46);
                button.FlatAppearance.BorderSize = 0;
                button.ImageAlign = ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

        }

        public void ConfigButtonDefault(IconButton iconButton)
        {
            iconButton.BackColor = Color.FromArgb(38, 50, 56);
            iconButton.FlatStyle = FlatStyle.Flat;
            iconButton.Flip = FlipOrientation.Normal;
            iconButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton.ForeColor = Color.White;
            iconButton.IconColor = Color.White;
            iconButton.IconSize = 32;
            iconButton.Size = new Size(137, 46);
            iconButton.FlatAppearance.BorderSize = 0;
            iconButton.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton.TextAlign = ContentAlignment.MiddleCenter;
            iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        public void LayoutGrid(DataGridView dg)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            dg.AllowUserToOrderColumns = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dg.ColumnHeadersHeight = 30;
            dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.Column1,
            //this.Column2,
            //this.Column9,
            //this.Column10,
            //this.colConsultar,
            //this.colEditar,
            //this.colExcluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dg.DefaultCellStyle = dataGridViewCellStyle3;
            dg.EnableHeadersVisualStyles = false;
            //dg.Location = new System.Drawing.Point(52, 121);
            dg.MultiSelect = false;
            dg.Name = "dgFisica";
            dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg.RowHeadersVisible = false;
            dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //dg.Size = new System.Drawing.Size(822, 375);
            dg.TabIndex = 3;
        }
    }
}
