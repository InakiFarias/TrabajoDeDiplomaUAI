namespace UI
{
    // Grilla de solo lectura con fondo blanco, líneas finas y selección en bordó claro
    public class GrillaSGB_351FI : DataGridView
    {
        public GrillaSGB_351FI()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            ReadOnly = true;
            MultiSelect = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RowHeadersVisible = false;

            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridColor = Tema_351FI.Borde_351FI;
            EnableHeadersVisualStyles = false;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 40;
            ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            ColumnHeadersDefaultCellStyle.ForeColor = Tema_351FI.TextoSecundario_351FI;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Tema_351FI.TextoSecundario_351FI;
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DefaultCellStyle.BackColor = Color.White;
            DefaultCellStyle.ForeColor = Tema_351FI.Texto_351FI;
            DefaultCellStyle.SelectionBackColor = Tema_351FI.BordoClaro_351FI;
            DefaultCellStyle.SelectionForeColor = Tema_351FI.BordoOscuro_351FI;
            DefaultCellStyle.Font = new Font(Tema_351FI.Familia, 10.5F);
            DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            RowTemplate.Height = 36;
        }

        // Línea inferior del encabezado para separarlo de las filas
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ColumnHeadersVisible)
                using (Pen pen = new Pen(Tema_351FI.Borde_351FI))
                    e.Graphics.DrawLine(pen, 0, ColumnHeadersHeight - 1, Width, ColumnHeadersHeight - 1);
        }
    }
}
