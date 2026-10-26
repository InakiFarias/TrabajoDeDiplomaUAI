namespace UI
{
    // Grilla de solo lectura con fondo blanco, líneas finas y selección en bordó claro
    public class GrillaSGB : DataGridView
    {
        public GrillaSGB()
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
            GridColor = Tema.Borde;
            EnableHeadersVisualStyles = false;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ColumnHeadersHeight = 40;
            ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            ColumnHeadersDefaultCellStyle.ForeColor = Tema.TextoSecundario;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Tema.TextoSecundario;
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DefaultCellStyle.BackColor = Color.White;
            DefaultCellStyle.ForeColor = Tema.Texto;
            DefaultCellStyle.SelectionBackColor = Tema.BordoClaro;
            DefaultCellStyle.SelectionForeColor = Tema.BordoOscuro;
            DefaultCellStyle.Font = new Font(Tema.Familia, 10.5F);
            DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            RowTemplate.Height = 36;
        }

        // Línea inferior del encabezado para separarlo de las filas
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (ColumnHeadersVisible)
                using (Pen pen = new Pen(Tema.Borde))
                    e.Graphics.DrawLine(pen, 0, ColumnHeadersHeight - 1, Width, ColumnHeadersHeight - 1);
        }
    }
}
