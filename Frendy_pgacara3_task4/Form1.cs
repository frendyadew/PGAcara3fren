using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Data;
using DotSpatial.Controls;
using DotSpatial.Symbology;


namespace Frendy_pgacara3_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fname = "Tahoma";
        double fsize = 8.0;
        Color fcolor = Color.Black;


        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear existing layers from the map control
            map1.Layers.Clear();

            // Clear existing items from the combobox
            cmbFiledName.Items.Clear();

            // Open file dialog to select shapefile
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Shapefiles|*.shp";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the selected shapefile
                string filePath = fileDialog.FileName; // Get file path
                IFeatureSet featureSet = FeatureSet.Open(filePath); // Open using type name

                // Convert IFeatureSet to FeatureSet
                FeatureSet concreteFeatureSet = featureSet as FeatureSet;

                if (concreteFeatureSet != null)
                {
                    // Fill combobox with attribute column names
                    FillColumnNames(concreteFeatureSet);

                    // Reproject feature set to match map projection
                    concreteFeatureSet.Reproject(map1.Projection);

                    // Add feature set as a layer to the map
                    map1.Layers.Add(concreteFeatureSet);

                    // Zoom to the extent of the added layer
                    map1.ZoomToMaxExtent();
                }
                else
                {
                    // Handle the case where conversion failed
                    MessageBox.Show("Failed to load shapefile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to fill combobox with attribute column names
        private void FillColumnNames(FeatureSet featureSet)
        {
            foreach (DataColumn column in featureSet.DataTable.Columns)
            {
                cmbFiledName.Items.Add(column.ColumnName);
            }
        }

        /// <summary>
        /// Populates the attribute names from the shapefile into the combobox.
        /// </summary>
        /// <param name="featureSet">The feature set containing attribute data.</param>
        private void FillColumnNames(IFeatureSet featureSet)
        {
            // Iterate through each column in the feature set
            foreach (DataColumn column in featureSet.DataTable.Columns)
            {
                // Add the column name to the combobox
                cmbFiledName.Items.Add(column.ColumnName);
            }
        }

        private void btnDisplayLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFiledName.Text))
            {
                MessageBox.Show("Please select an attribute from the combobox.");
            }
            else
            {
                DisplayLabels(cmbFiledName.Text);
            }
        }

        /// <summary>
        /// Displays a label on a shape file based on user selection from combobox.
        /// </summary>
        /// <param name="attributename">The name of the attribute used for labeling.</param>
        private void DisplayLabels(string attributename)
        {
            // Check if there are any layers in the MapControl
            if (map1.Layers.Count > 0)
            {
                // Get the first layer from the map
                IFeatureLayer featureLayer = map1.Layers[0] as IFeatureLayer;

                if (featureLayer != null)
                {
                    // Create a new LabelSymbolizer with the selected font and color
                    var labelSymbolizer = new LabelSymbolizer
                    {
                        FontFamily = fname,
                        FontSize = (float)fsize,
                        FontColor = fcolor
                    };

                    // Add labels to the feature layer with the new LabelSymbolizer
                    featureLayer.AddLabels("[" + attributename + "]", "", labelSymbolizer, "");
                }
                else
                {
                    MessageBox.Show("The layer is not a valid feature layer.");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisplayCustomLabel(txtCustomAttribute.Text);
            txtCustomAttribute.Text = "";
        }

        private void DisplayCustomLabel(string attributeValue)
        {
            // Check if the label text is provided
            if (string.IsNullOrEmpty(attributeValue))
            {
                MessageBox.Show("Please enter the label text.");
                return;
            }

            // Check if there is a layer added to the map
            IMapFeatureLayer selectedLayer = (IMapFeatureLayer)map1.Layers[0];
            if (selectedLayer == null)
            {
                MessageBox.Show("Please add a layer to the map.");
                return;
            }

            // Check if there is any shape selected in the map
            int numSelectedFeatures = selectedLayer.Selection.Count;
            if (numSelectedFeatures == 0)
            {
                MessageBox.Show("Please select a shape in the map.");
                return;
            }

            // Get the attribute table of the layer
            DataTable table = selectedLayer.DataSet.DataTable;

            // Check if the column 'new_label' exists, if not add it
            if (!table.Columns.Contains("new_label"))
            {
                table.Columns.Add(new DataColumn("new_label"));
            }

            // Get the selected feature and set the value for the new label column
            List<IFeature> selectedFeatureList = selectedLayer.Selection.ToFeatureList();
            IFeature selectedFeature = selectedFeatureList[0];
            selectedFeature.DataRow["new_label"] = attributeValue;

            // Set label symbolizer properties
            var labelSymbolizer = new LabelSymbolizer
            {
                FontFamily = fname, // Menggunakan nama font langsung sebagai string
                FontSize = (float)fsize,
                FontColor = fcolor // Menggunakan FontColor untuk menentukan warna teks
            };

            // Display labels in the map
            selectedLayer.AddLabels("[new_label]", "", labelSymbolizer, "");

            // Reset map selection mode
            map1.FunctionMode = FunctionMode.None;
        }


        private void txtCustomAttribute_TextChanged_1(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Select;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                IMapFeatureLayer stateLayer = (IMapFeatureLayer)map1.Layers[0];
                stateLayer.DataSet.Save();
                MessageBox.Show("Attribute has been saved in the shapefile.");
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Declare a DataTable
            DataTable dt = null;

            if (map1.Layers.Count > 0)
            {
                // Get the first layer from the map
                IMapFeatureLayer stateLayer = (IMapFeatureLayer)map1.Layers[0];

                // Get the shapefile's attribute table into our DataTable dt
                dt = stateLayer.DataSet.DataTable;

                // Remove a column
                dt.Columns.Remove("new_label");

                // Save the changes to the shapefile
                stateLayer.DataSet.Save();

                MessageBox.Show("Attribute has been removed from the shapefile.");
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

       
        private void btnSetFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                fname = fontDialog1.Font.Name;
                fsize = fontDialog1.Font.Size;

                // Setel label dengan warna baru
                SetLabelProperties();
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fcolor = colorDialog1.Color;

                // Setel label dengan warna baru
                SetLabelProperties();
            }
        }


        private void SetLabelProperties()
        {
            // Ambil layer yang sedang dipilih
            IMapFeatureLayer selectedLayer = (IMapFeatureLayer)map1.Layers[0];
            if (selectedLayer != null)
            {
                // Setel properti label dengan nilai terbaru
                var labelSymbolizer = new LabelSymbolizer
                {
                    FontFamily = fname,
                    FontSize = (float)fsize,
                    FontColor = fcolor
                };
                // Hapus label lama dan tambahkan label baru dengan properti baru
                selectedLayer.ClearLabels();
                selectedLayer.AddLabels(" ", "", labelSymbolizer, "");
                // Perbaharui tampilan peta
                map1.ResetBuffer();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.Layers.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Menampilkan dialog konfirmasi sebelum keluar
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void zoomToExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.Pan;
        }

        private void Map1_MouseClickForMeasurement(object sender, MouseEventArgs e)
        {
            // Lakukan pengukuran sesuai dengan klik mouse
            // Contoh: hitung jarak antara dua titik yang dipilih
            // atau hitung luas area tertentu

            // Setelah pengukuran selesai, pastikan untuk menghapus event handler
            map1.MouseClick -= Map1_MouseClickForMeasurement;

            // Kembalikan mode peta ke mode default
            map1.FunctionMode = FunctionMode.None;
        }
        private void measureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aktifkan mode pengukuran
            map1.FunctionMode = FunctionMode.Select;

            // Tambahkan event handler untuk menangani pengukuran
            map1.MouseClick += Map1_MouseClickForMeasurement;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.FunctionMode = FunctionMode.None;
        }


    }
}
