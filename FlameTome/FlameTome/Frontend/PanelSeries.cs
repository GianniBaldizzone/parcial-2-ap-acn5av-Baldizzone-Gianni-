using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlameTome.Controladores;
using FlameTome.Modelos;

namespace FlameTome.Frontend
{
    public partial class PanelSeries : UserControl
    {
        public PanelSeries()
        {
            InitializeComponent();
            CargarSeriesEnTabla(tabla_series);
        }

        public void CargarSeriesEnTabla(DataGridView dataGridViewSeries)
        {
            var controlador = new Controller_Serie();
            List<Serie> listaSeries = controlador.ObtenerSeries();

            dataGridViewSeries.Rows.Clear();
            dataGridViewSeries.Columns.Clear();

            // Crear columnas
            dataGridViewSeries.Columns.Add("Id", "ID");
            dataGridViewSeries.Columns.Add("Nombre", "Nombre");
            dataGridViewSeries.Columns.Add("FechaModificacion", "Fecha Modificación");
            dataGridViewSeries.Columns.Add("Activo", "Activo");
            dataGridViewSeries.Columns.Add("IdCategoria", "ID Categoría");

            // Columna de imagen
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Foto";
            imgCol.HeaderText = "Foto";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewSeries.Columns.Add(imgCol);

            foreach (Serie serie in listaSeries)
            {
                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imagenes", "series", $"{serie.Id}.jpg");
                Image imagen = null;

                if (File.Exists(rutaImagen))
                {
                    using (var bmpTemp = new Bitmap(rutaImagen))
                    {
                        imagen = new Bitmap(bmpTemp);
                    }
                }
                else
                {
                    imagen = null;
                }

                dataGridViewSeries.Rows.Add(
                    serie.Id,
                    serie.Nombre,
                    serie.FechaModificacion?.ToShortDateString() ?? "N/A",
                    serie.Activo ? "Sí" : "No",
                    serie.IdCategoria,
                    imagen
                );
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }
    }
}
