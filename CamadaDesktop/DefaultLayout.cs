using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;

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
            dg.AllowUserToAddRows = false;
            dg.AllowUserToOrderColumns = true;
            dg.AllowUserToResizeColumns = false;
            dg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dg.BackgroundColor = Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(34)))), ((int)(((byte)(125)))));
            dg.BorderStyle = BorderStyle.None;
            dg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dg.ColumnHeadersHeight = 30;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SlateBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dg.DefaultCellStyle = dataGridViewCellStyle3;
            dg.EnableHeadersVisualStyles = false;
            dg.MultiSelect = false;
            dg.Name = "dgFisica";
            dg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.PaleGreen;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dg.RowHeadersVisible = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.TabIndex = 3;
        }

        public void LayoutReportViewer(ReportViewer reportViewer)
        {
            //reportViewer.Size = new Size(919, 483);
            reportViewer.TabIndex = 0;
            reportViewer.Visible = false;
            reportViewer.BorderStyle = BorderStyle.FixedSingle;
            //reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
    }
}
