using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Symbology;

namespace Frendy_pgAcara4_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Metode AddLayer() digunakan untuk menambahkan sebuah shape file ke MapControl.
            Map1.AddLayer();
        }

        private void ClearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Metode Clear() digunakan untuk menghapus semua lapisan dari kontrol peta.
            Map1.Layers.Clear();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Konfirmasikan dengan pengguna apakah mereka siap untuk menutup aplikasi atau tidak dengan bantuan kotak pesan.
            if (MessageBox.Show("Do you want to close this application?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Metode Close() digunakan untuk menutup aplikasi.
                this.Close();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomOut();
        }

        private void zoomExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomToMaxExtent();
        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.Layers.Clear();
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Map1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayStateName_Click(object sender, EventArgs e)
        {
            // Periksa jumlah lapisan dari MapControl
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                IFeatureLayer stateLayer = default(IFeatureLayer);

                // TypeCast layer pertama dari MapControl ke IFeatureLayer.
                // Lapisan dimulai dari indeks 0, sehingga 0 akan mengambil lapisan pertama dari MapControl
                stateLayer = (IFeatureLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Tambahkan label ke stateLayer
                    //[STATE_NAME] adalah atribut dari contoh shape file Negara Bagian AS.
                    stateLayer.AddLabels("[STATE_NAME]", new Font("Tahoma", (float)8.0), Color.Black);
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        private void btnFilterByStateName_Click(object sender, EventArgs e)
        {
            // Periksa jumlah lapisan dari MapControl
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // TypeCast layer pertama dari MapControl ke MapPolygonLayer.
                // Lapisan dimulai dari indeks 0, sehingga 0 akan mengambil lapisan pertama dari MapControl
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Metode SelectByAttribute digunakan untuk mengimplementasikan operasi filter.
                    // Dalam contoh ini, STATE_NAME digunakan untuk mengimplementasikan operasi filter
                    // Kita dapat melihat negara bagian Idaho di peta
                    stateLayer.SelectByAttribute("[STATE_NAME] = 'Idaho'");
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        private void btnFilterByPopState_Click(object sender, EventArgs e)
        {
            // Periksa jumlah lapisan dari kontrol peta
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // Type cast layer pertama dari kontrol peta ke MapPolygonLayer
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Ini akan memuat tabel atribut lapisan ke dalam memori.
                    stateLayer.DataSet.FillAttributes();

                    // Buat sebuah PolygonScheme baru
                    PolygonScheme scheme = new PolygonScheme();

                    // Buat sebuah PolygonCategory baru
                    PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);

                    // Deklarasikan string filter
                    //[POP1990],[STATE_NAME] adalah atribut dari tabel atribut dari file shape yang diberikan.
                    string filter = "[POP1990] > 10000000 OR [STATE_NAME] = 'Idaho'";

                    // Tetapkan ekspresi filter ke PolygonCategory
                    category.FilterExpression = filter;

                    // Tetapkan teks legenda
                    category.LegendText = "populasi > 10 Juta";

                    // Tambahkan PolygonCategory ke dalam PolygonScheme
                    scheme.AddCategory(category);

                    // Tetapkan skema ke simbologi MapPolygonLayer
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        private void btnRandomColors_Click(object sender, EventArgs e)
        {
            // Periksa jumlah lapisan dari kontrol peta
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // Type cast layer pertama dari kontrol peta ke MapPolygonLayer
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Buat sebuah PolygonScheme baru
                    PolygonScheme scheme = new PolygonScheme();

                    // Atur ClassificationType untuk PolygonScheme melalui EditorSettings
                    scheme.EditorSettings.ClassificationType = ClassificationType.UniqueValues;

                    // Tetapkan nama bidang UniqueValue
                    // Di sini STATE_NAME akan menjadi bidang nilai unik
                    scheme.EditorSettings.FieldName = "STATE_NAME";

                    // Buat kategori pada skema berdasarkan tabel atribut dan nama bidang
                    // Dalam kasus ini nama bidang adalah STATE_NAME
                    scheme.CreateCategories(stateLayer.DataSet.DataTable);

                    // Tetapkan skema ke simbologi stateLayer
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        /// <summary>
        /// Metode ini digunakan untuk menyaring tabel atribut shapefile berdasarkan populasi pada tahun 1990.
        /// </summary>
        /// <param name="population">Jumlah populasi pada tahun 1990</param>
        /// <remarks>Tidak ada nilai yang dikembalikan</remarks>
        private void FilterByPopulation(int population)
        {
            // Periksa jumlah lapisan dari kontrol peta
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // Type cast layer pertama dari kontrol peta ke MapPolygonLayer
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Ini akan memuat tabel atribut lapisan ke dalam memori.
                    stateLayer.DataSet.FillAttributes();

                    // Buat sebuah PolygonScheme baru
                    PolygonScheme scheme = new PolygonScheme();

                    // Buat sebuah PolygonCategory baru
                    PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);

                    // Buat ekspresi filter berdasarkan populasi
                    string filter = "[POP1990] < " + population;

                    // Tetapkan ekspresi filter ke PolygonCategory
                    category.FilterExpression = filter;

                    // Tetapkan teks legenda
                    category.LegendText = "populasi < " + population.ToString();

                    // Tambahkan PolygonCategory ke dalam PolygonScheme
                    scheme.AddCategory(category);

                    // Tetapkan skema ke simbologi stateLayer
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        private void btnFilterByPopulation_Click(object sender, EventArgs e)
        {
            double number;

            // Memvalidasi input textbox
            if (string.IsNullOrEmpty(txtPopulation.Text) || !double.TryParse(txtPopulation.Text, out number))
            {
                MessageBox.Show("Masukkan nilai yang valid", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPopulation.Text = "";
            }
            else
            {
                // Memanggil metode FilterByPopulation.
                // Kita perlu meneruskan parameter input integer,
                // Oleh karena itu, saya hanya melakukan pengecoran tipe integer.
                FilterByPopulation(Convert.ToInt32(txtPopulation.Text));
            }
        }

        private void btnViewAttributes_Click(object sender, EventArgs e)
        {
            // Deklarasikan sebuah datatable
            DataTable dt = null;

            // Periksa jumlah lapisan dari kontrol peta
            if (Map1.Layers.Count > 0)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // Type cast layer pertama dari kontrol peta ke MapPolygonLayer
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Dapatkan tabel atribut shapefile ke dalam datatable dt
                    dt = stateLayer.DataSet.DataTable;

                    // Tetapkan datagridview datasource dari datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Silakan tambahkan sebuah lapisan ke peta.");
            }
        }

        private void dgvAttributeTable_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttributeTable.SelectedRows)
            {
                // Deklarasikan sebuah MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                // Type cast layer pertama dari kontrol peta ke MapPolygonLayer
                stateLayer = (MapPolygonLayer)Map1.Layers[0];

                // Periksa apakah stateLayer adalah lapisan poligon atau tidak
                if (stateLayer == null)
                {
                    MessageBox.Show("Lapisannya bukan lapisan poligon.");
                }
                else
                {
                    // Memilih berdasarkan atribut
                    stateLayer.SelectByAttribute("[STATE_NAME] = '" + row.Cells["STATE_NAME"].Value + "'");
                }
            }
        }

    }
}
