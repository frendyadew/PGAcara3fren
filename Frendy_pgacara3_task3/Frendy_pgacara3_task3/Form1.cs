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
using DotSpatial.Topology;
using DotSpatial.Controls;
using DotSpatial.Data;


namespace Frendy_pgacara3_task3
{
    public partial class Form1 : Form
    {
        // Point ShapeFile class level variable
        FeatureSet pointF = new FeatureSet(DotSpatial.Data.FeatureType.Point);
        int pointID = 0;
        bool pointmouseClick = false;
        private string shapeType; // Deklarasi variabel shapeType

        FeatureSet lineF = new FeatureSet(DotSpatial.Data.FeatureType.Line);
        int lineID = 0;
        bool firstClick = false;
        bool linemouseClick = false;
        MapLineLayer lineLayer;

        FeatureSet polygonF = new FeatureSet(DotSpatial.Data.FeatureType.Polygon);
        int polygonID = 0;
        bool polygonmouseClick = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void map1_Load(object sender, EventArgs e)
        {
            {
                //AddLayer() method is used to add a shape file in the MapControl.
                map1.AddLayer();
            }
        }


        private void createPointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the cursor style
            map1.Cursor = Cursors.Cross;

            // Set the shape type to the class-level string variable
            // We are going to use this variable in a select case statement
            shapeType = "Point";

            // Set projection
            pointF.Projection = map1.Projection;

            // Initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);

            // Add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)map1.Layers.Add(pointF);

            // Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);

            // Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;

            // Set the legendText as point
            pointLayer.LegendText = "point";

            // Set left mouse click as true
            pointmouseClick = true;
        }

        private void Map1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if (pointmouseClick)
                        {
                            // Mengonversi koordinat layar ke koordinat peta
                            GeoAPI.Geometries.Coordinate coord = map1.PixelToProj(e.Location);

                            // Membuat titik baru menggunakan koordinat DotSpatial
                            DotSpatial.Topology.Coordinate dotSpatialCoord = new DotSpatial.Topology.Coordinate(coord.X, coord.Y);
                            DotSpatial.Topology.Point dotSpatialPoint = new DotSpatial.Topology.Point(dotSpatialCoord);

                            // Menambahkan titik ke FeatureSet titik
                            IFeature currentFeature = pointF.AddFeature((GeoAPI.Geometries.IGeometry)dotSpatialPoint);

                            // Menambahkan ID titik
                            pointID++;

                            // Menetapkan atribut ID
                            currentFeature.DataRow["ID"] = pointID;

                            // Memperbarui peta
                            map1.ResetBuffer();
                        }
                    }
                    else
                    {
                        // Klik kanan mouse
                        map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "Line":
                    if (e.Button == MouseButtons.Left)
                    {
                        // Left click - fill array of coordinates
                        // Coordinate of clicked point
                        GeoAPI.Geometries.Coordinate coord = map1.PixelToProj(e.Location);
                        if (linemouseClick)
                        {
                            // First time left click - create empty line feature
                            if (firstClick)
                            {
                                // Create a new List called lineArray to store the Coordinates
                                List<GeoAPI.Geometries.Coordinate> lineArray = new List<GeoAPI.Geometries.Coordinate>();
                                // Create an instance for LineString class.
                                DotSpatial.Topology.LineString lineGeometry = new DotSpatial.Topology.LineString((IEnumerable<ICoordinate>)lineArray.ToArray());
                                // Add the line geometry to line feature.
                                IFeature lineFeature = lineF.AddFeature((GeoAPI.Geometries.IGeometry)lineGeometry);
                                // Add first coordinate to the line feature
                                lineArray.Add(coord); // Add coordinate to the list
                                                      // Set the line feature attribute
                                lineID++;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            }
                            else
                            {
                                // Second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                // Get the LineString geometry from the existing feature
                                DotSpatial.Topology.LineString lineGeometry = (DotSpatial.Topology.LineString)existingFeature.Geometry;
                                // Add the coordinate to the LineString
                                lineGeometry.Coordinates.Add(new DotSpatial.Topology.Coordinate(coord.X, coord.Y));
                                // Refresh the map if line has 2 or more points
                                if (lineGeometry.Coordinates.Count >= 2)
                                {
                                    lineF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        // Right click - reset first mouse click
                        firstClick = true;
                        map1.ResetBuffer();
                    }
                    break;

                case "polygon":
                    if (e.Button == MouseButtons.Left)
                    {
                        // Left click - fill array of coordinates
                        GeoAPI.Geometries.Coordinate geoCoord = map1.PixelToProj(e.Location);
                        if (polygonmouseClick)
                        {
                            // First time left click - create empty polygon feature
                            if (firstClick)
                            {
                                // Create a new List called polygonArray to store the Coordinates
                                List<DotSpatial.Topology.Coordinate> polygonArray = new List<DotSpatial.Topology.Coordinate>();
                                // Add the coordinate to the list
                                polygonArray.Add(new DotSpatial.Topology.Coordinate(geoCoord.X, geoCoord.Y));
                                // Create an instance for LinearRing class.
                                // We pass the polygon List to the constructor of this class
                                DotSpatial.Topology.LinearRing polygonGeometry = new DotSpatial.Topology.LinearRing(polygonArray.ToArray());
                                // Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature((GeoAPI.Geometries.IGeometry)polygonGeometry);
                                // Set the polygon feature attribute
                                polygonID++;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            }
                            else
                            {
                                // Second or more clicks - add points to the existing feature
                                IFeature existingFeature = polygonF.Features[polygonF.Features.Count - 1];
                                // Get the geometry of the existing feature
                                DotSpatial.Topology.IGeometry geometry = (IGeometry)existingFeature.Geometry;
                                // Ensure the geometry is of type Polygon
                                if (geometry is DotSpatial.Topology.Polygon polygon)
                                {
                                    // Get the exterior ring (LinearRing) of the polygon
                                    DotSpatial.Topology.LinearRing exteriorRing = (LinearRing)polygon.Shell;
                                    // Add the coordinate to the exterior ring
                                    exteriorRing.Coordinates.Add(new DotSpatial.Topology.Coordinate(geoCoord.X, geoCoord.Y));
                                    // Refresh the map if polygon has at least 3 points
                                    if (exteriorRing.Coordinates.Count >= 3)
                                    {
                                        // Refresh the map
                                        polygonF.InitializeVertices();
                                        map1.ResetBuffer();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Right click - reset first mouse click
                        firstClick = true;
                    }
                    break;
            }
        }



        private void SavePointShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Simpan sebagai shapefile dengan nama "point.shp"
            pointF.SaveAs("point.shp", true);

            // Tampilkan pesan bahwa shapefile titik telah disimpan
            MessageBox.Show("The point shapefile has been saved.");

            // Kembalikan kursor ke tipe panah (default)
            map1.Cursor = Cursors.Arrow;
        }

        private void CreatePolylineShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the mouse cursor
            map1.Cursor = Cursors.Cross;

            // Set shape type
            shapeType = "line";

            // Set projection
            lineF.Projection = map1.Projection;

            // Initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");
            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }

            // Add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF);

            // Set the symbolizer to the line feature
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;
            linemouseClick = true;
        }

        private void SavePolylineShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineF.SaveAs(@"c:\MW\line.shp", true);
            MessageBox.Show("The line shapefile has been saved in C:\\MW\\");
            map1.Cursor = Cursors.Arrow;
            linemouseClick = false;
        }

        private void CreatePolygonShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Initialize polygon feature set
            map1.Cursor = Cursors.Cross;

            // Set shape type
            shapeType = "polygon";

            // Set projection
            polygonF.Projection = map1.Projection;

            // Initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");
            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }

            // Add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)map1.Layers.Add(polygonF);

            // Set symbolizer for polygon
            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);
            polygonLayer.Symbolizer = symbol;

            // Set legend text for polygon
            polygonLayer.LegendText = "polygon";

            firstClick = true;
            polygonmouseClick = true;
        }

        private void SavePolygonShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygonF.SaveAs("c:\\MW\\polygon.shp", true);
            MessageBox.Show("The polygon shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
            polygonmouseClick = false;
        }

        private void ViewAttrbuteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a DataTable
            System.Data.DataTable dt = null;
            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    // Get the shapefile's attribute table to our DataTable dt
                    dt = stateLayer.DataSet.DataTable;
                    // Set the DataGridView's DataSource to the DataTable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void CreateAColumInAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a DataTable
            System.Data.DataTable dt = null;
            // Check the layers
            if (map1.Layers.Count > 0)
            {
                // Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                // Assign the MapPolygonLayer from the map
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    // Get the shapefile's attribute table to our DataTable dt
                    dt = stateLayer.DataSet.DataTable;
                    // Add new column
                    DataColumn column = new DataColumn("PercentMales");
                    dt.Columns.Add(column);
                    // Calculate values
                    foreach (DataRow row in dt.Rows)
                    {
                        double males = Convert.ToDouble(row["males"]);
                        double females = Convert.ToDouble(row["females"]);
                        double malesPercentage = (males / (males + females)) * 100;
                        row["PercentMales"] = malesPercentage;
                    }
                    // Set the DataGridView's DataSource to the DataTable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void SaveTheColumInShapeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                // Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                // Assign the MapPolygonLayer from the map
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    stateLayer.DataSet.Save();
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void DeleteColumnInAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a DataTable
            System.Data.DataTable dt = null;
            if (map1.Layers.Count > 0)
            {
                // Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                // Assign the MapPolygonLayer from the map
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    // Get the shapefile's attribute table to our DataTable dt
                    dt = stateLayer.DataSet.DataTable;
                    // Remove a column
                    dt.Columns.Remove("PercentMale");
                    // Set the DataGridView datasource from DataTable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void ExportAttributeTableToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a DataTable
            System.Data.DataTable dt = null;
            if (map1.Layers.Count > 0)
            {
                // Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                // Assign the MapPolygonLayer from the map
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    // Get the shapefile's attribute table to our DataTable dt
                    dt = stateLayer.DataSet.DataTable;
                    // Call the method ExportToExcel 
                    // This method expects a DataTable as an input
                    ExportToExcel(dt);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        /// <summary>
        /// This method is used to export the attribute table to an Excel worksheet.
        /// </summary>
        /// <param name="objDT">The attribute table as a DataTable input</param>
        /// <remarks>Make sure to add a reference to Microsoft Excel Object Library.</remarks>
        private void ExportToExcel(System.Data.DataTable objDT)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            string strFilename = null;
            int intCol = 0;
            int intRow = 0;
            string strPath = "C:\\2009 Falls\\";

            if (xlApp == null)
            {
                MessageBox.Show("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                xlApp.SheetsInNewWorkbook = 1;
                xlApp.Workbooks.Add();
                xlApp.Worksheets[1].Select();
                xlApp.Cells[1, 1].Value = "Attribute table";
                xlApp.Cells[1, 1].EntireRow.Font.Bold = true;

                int intI = 1;
                for (intCol = 0; intCol < objDT.Columns.Count; intCol++)
                {
                    xlApp.Cells[2, intI].Value = objDT.Columns[intCol].ColumnName;
                    xlApp.Cells[2, intI].EntireRow.Font.Bold = true;
                    intI++;
                }

                intI = 3;
                int intK = 1;
                for (intCol = 0; intCol < objDT.Columns.Count; intCol++)
                {
                    intI = 3;
                    for (intRow = 0; intRow < objDT.Rows.Count; intRow++)
                    {
                        xlApp.Cells[intI, intK].Value = objDT.Rows[intRow].ItemArray[intCol];
                        intI++;
                    }
                    intK++;
                }

                if (strPath.Substring(strPath.Length - 1, 1) != "\\")
                {
                    strPath = strPath + "\\";
                }

                strFilename = strPath + "AttributeTable.xls";
                xlApp.ActiveCell.Worksheet.SaveAs(strFilename);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                xlApp = null;

                MessageBox.Show("Data has been exported to Excel successfully in '" + strFilename + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            System.Diagnostics.Process[] pro = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process i in pro)
            {
                i.Kill();
            }
        }
        private void PrintMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DotSpatial.Controls.LayoutForm frm = new DotSpatial.Controls.LayoutForm();
            frm.MapControl = map1;
            frm.Show();
        }

    }
}
