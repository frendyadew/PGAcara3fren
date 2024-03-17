using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Symbology;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Topology;
using DotSpatial.Serialization;

namespace frendy_pgacara3_task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadRaster_Click(object sender, EventArgs e)
        {
            LoadRasterLayer();
        }

        private void LoadRasterLayer()
        {
            // Memanggil metode AddRasterLayer() untuk memuat lapisan raster pada peta
            Map1.AddRasterLayer();

            // Mengatur zoom peta ke ekstensi maksimum
            Map1.ZoomToMaxExtent();
        }

        private void btnHillshade_Click(object sender, EventArgs e)
        {
            if (Map1.Layers.Count > 0)
            {
                // Melakukan pengecekan apakah layer pertama adalah layer raster
                if (Map1.Layers[0] is IMapRasterLayer layer)
                {
                    // Memastikan bahwa layer tidak null
                    if (layer == null)
                    {
                        MessageBox.Show("Please select a raster layer.");
                        return;
                    }

                    // Mengatur properti hillshade
                    layer.Symbolizer.ShadedRelief.ElevationFactor = 1;
                    layer.Symbolizer.ShadedRelief.IsUsed = true;

                    // Menyegarkan tampilan layer pada peta
                    layer.WriteBitmap();
                }
                else
                {
                    MessageBox.Show("The first layer is not a raster layer.");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (Map1.Layers.Count > 0)
            {
                // Memastikan bahwa layer pertama adalah layer raster
                if (Map1.Layers[0] is IMapRasterLayer layer)
                {
                    // Memastikan bahwa layer tidak null
                    if (layer == null)
                    {
                        MessageBox.Show("Please add a raster layer.");
                        return;
                    }

                    // Membuat skema warna
                    ColorScheme scheme = new ColorScheme();

                    // Membuat kategori warna
                    ColorCategory category1 = new ColorCategory(2500, 3000, Color.Red, Color.Yellow);
                    category1.LegendText = "Elevation 2500 - 3000";
                    scheme.AddCategory(category1);

                    ColorCategory category2 = new ColorCategory(1000, 2500, Color.Blue, Color.Green);
                    category2.LegendText = "Elevation 1000 - 2500";
                    scheme.AddCategory(category2);

                    // Mengatur skema warna baru pada layer
                    layer.Symbolizer.Scheme = scheme;

                    // Menyegarkan tampilan layer pada peta
                    layer.WriteBitmap();
                }
                else
                {
                    MessageBox.Show("The first layer is not a raster layer.");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnMultiplyRaster_Click(object sender, EventArgs e)
        {
            // Memeriksa jumlah layer pada peta
            if (Map1.Layers.Count > 0)
            {
                // Melakukan type casting layer pertama ke MapRasterLayer
                if (Map1.Layers[0] is IMapRasterLayer layer)
                {
                    // Memastikan layer tidak null
                    if (layer == null)
                    {
                        MessageBox.Show("Please select a raster layer.");
                        return;
                    }

                    // Mendapatkan dataset raster
                    IRaster demRaster = layer.DataSet;

                    // Membuat raster baru dengan dimensi yang sama dengan raster asli
                    string[] rasterOptions = new string[1];
                    IRaster newRaster = Raster.CreateRaster("multiply.bgd", null, demRaster.NumColumns, demRaster.NumRows, 1, demRaster.DataType, rasterOptions);

                    // Menetapkan batas untuk menentukan ukuran sel dan koordinat sudut raster
                    newRaster.Bounds = demRaster.Bounds.Copy();
                    newRaster.NoDataValue = demRaster.NoDataValue;
                    newRaster.Projection = demRaster.Projection;

                    // Melakukan perkalian
                    for (int i = 0; i < demRaster.NumRows; i++)
                    {
                        for (int j = 0; j < demRaster.NumColumns; j++)
                        {
                            if (demRaster.Value[i, j] != demRaster.NoDataValue)
                            {
                                newRaster.Value[i, j] = demRaster.Value[i, j] * 2;
                            }
                        }
                    }

                    // Menyimpan raster baru ke file
                    newRaster.Save();

                    // Menambahkan raster baru ke peta
                    Map1.Layers.Add(newRaster);
                }
                else
                {
                    MessageBox.Show("The first layer is not a raster layer.");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnReclassify_Click(object sender, EventArgs e)
        {
            // Melakukan type casting layer terpilih ke IMapRasterLayer
            IMapRasterLayer layer = Map1.Layers.SelectedLayer as IMapRasterLayer;
            if (layer == null)
            {
                MessageBox.Show("Please select a raster layer.");
                return;
            }

            // Mendapatkan dataset raster
            IRaster demRaster = layer.DataSet;

            // Membuat raster baru kosong dengan dimensi yang sama dengan raster asli
            string[] rasterOptions = new string[1];
            IRaster newRaster = Raster.CreateRaster("reclassify.bgd", null, demRaster.NumColumns, demRaster.NumRows, 1, demRaster.DataType, rasterOptions);
            newRaster.Bounds = demRaster.Bounds.Copy();
            newRaster.NoDataValue = demRaster.NoDataValue;
            newRaster.Projection = demRaster.Projection;

            // Melakukan reklassifikasi raster
            double oldValue = 0;
            double specifiedValue = Convert.ToDouble(txtElevation.Text);
            for (int i = 0; i < demRaster.NumRows; i++)
            {
                for (int j = 0; j < demRaster.NumColumns; j++)
                {
                    oldValue = demRaster.Value[i, j];
                    if (oldValue >= specifiedValue)
                    {
                        newRaster.Value[i, j] = 1;
                    }
                    else
                    {
                        newRaster.Value[i, j] = 0;
                    }
                }
            }

            // Menyimpan raster baru
            newRaster.Save();

            // Menambahkan raster baru ke peta
            Map1.Layers.Add(newRaster);
        }

        private void chbRasterValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRasterValue.Checked)
            {
                IMapRasterLayer rasterLayer = Map1.Layers.SelectedLayer as IMapRasterLayer;
                if (rasterLayer != null)
                {
                    // Mengatur kursor peta menjadi silang
                    Map1.Cursor = Cursors.Cross;
                }
                else
                {
                    // Jika tidak ada layer raster yang dipilih, batalkan centang pada checkbox
                    MessageBox.Show("Please select a raster layer.");
                    chbRasterValue.Checked = false;
                }
            }
            else
            {
                // Mengembalikan kursor peta menjadi panah
                Map1.Cursor = Cursors.Arrow;
            }
        }

        private void Map1_MouseUp(object sender, MouseEventArgs e)
        {
            if (chbRasterValue.Checked)
            {
                // Mendapatkan layer yang dipilih dalam legenda
                IMapRasterLayer rasterLayer = Map1.Layers.SelectedLayer as IMapRasterLayer;
                if (rasterLayer != null)
                {
                    // Mendapatkan objek data raster
                    IRaster raster = rasterLayer.DataSet;

                    // Mengkonversi posisi mouse ke koordinat peta
                   GeoAPI.Geometries.Coordinate coord = Map1.PixelToProj(e.Location);

                    // Mengkonversi koordinat peta ke baris dan kolom raster
                    RcIndex rc = raster.Bounds.ProjToCell(coord);
                    int row = rc.Row;
                    int column = rc.Column;

                    // Memeriksa apakah titik yang diklik berada di dalam raster
                    if (column > 0 && column < raster.NumColumns && row > 0 && row < raster.NumRows)
                    {
                        // Mendapatkan nilai raster pada baris dan kolom
                        double value = raster.Value[row, column];

                        // Menampilkan baris, kolom, dan nilai dalam label
                        lblRasterValue.Text = string.Format("row: {0} column: {1} value: {2}", row, column, value);
                    }
                    else
                    {
                        lblRasterValue.Text = "outside of raster";
                    }
                }
            }
        }



    }
}
