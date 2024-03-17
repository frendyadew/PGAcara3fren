using System;

namespace Frendy_pgacara3_task3
{
    partial class Form1
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
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapefileOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeTableOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAColumnInTheAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAColumnInTheAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAttributeTableInShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAttributeTableToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.map1 = new DotSpatial.Controls.Map();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlAttribute = new System.Windows.Forms.Panel();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.pnlOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.menuStrip1);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(800, 33);
            this.pnlOperations.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapefileOperationsToolStripMenuItem,
            this.mapOptionsToolStripMenuItem,
            this.attributeTableOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.map1_Load);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // shapefileOperationsToolStripMenuItem
            // 
            this.shapefileOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.shapefileOperationsToolStripMenuItem.Name = "shapefileOperationsToolStripMenuItem";
            this.shapefileOperationsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.shapefileOperationsToolStripMenuItem.Text = "Shapefile Operations";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPointShapefileToolStripMenuItem,
            this.savePointShapefileToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pointToolStripMenuItem.Text = "Point";
            // 
            // createPointShapefileToolStripMenuItem
            // 
            this.createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem";
            this.createPointShapefileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile";
            this.createPointShapefileToolStripMenuItem.Click += new System.EventHandler(this.createPointShapefileToolStripMenuItem_Click);
            // 
            // savePointShapefileToolStripMenuItem
            // 
            this.savePointShapefileToolStripMenuItem.Name = "savePointShapefileToolStripMenuItem";
            this.savePointShapefileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.savePointShapefileToolStripMenuItem.Text = "Save Point Shapefile";
            this.savePointShapefileToolStripMenuItem.Click += new System.EventHandler(this.SavePointShapeFileToolStripMenuItem_Click);
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolylineShapefileToolStripMenuItem,
            this.savePolylineShapefileToolStripMenuItem});
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polylineToolStripMenuItem.Text = "Polyline";
            // 
            // createPolylineShapefileToolStripMenuItem
            // 
            this.createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem";
            this.createPolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile";
            this.createPolylineShapefileToolStripMenuItem.Click += new System.EventHandler(this.CreatePolylineShapeFileToolStripMenuItem_Click);
            // 
            // savePolylineShapefileToolStripMenuItem
            // 
            this.savePolylineShapefileToolStripMenuItem.Name = "savePolylineShapefileToolStripMenuItem";
            this.savePolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.savePolylineShapefileToolStripMenuItem.Text = "Save Polyline Shapefile";
            this.savePolylineShapefileToolStripMenuItem.Click += new System.EventHandler(this.SavePolylineShapeFileToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolygonShapefileToolStripMenuItem,
            this.savePolygonShapefileToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // createPolygonShapefileToolStripMenuItem
            // 
            this.createPolygonShapefileToolStripMenuItem.Name = "createPolygonShapefileToolStripMenuItem";
            this.createPolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.createPolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile";
            this.createPolygonShapefileToolStripMenuItem.Click += new System.EventHandler(this.CreatePolygonShapeFileToolStripMenuItem_Click);
            // 
            // savePolygonShapefileToolStripMenuItem
            // 
            this.savePolygonShapefileToolStripMenuItem.Name = "savePolygonShapefileToolStripMenuItem";
            this.savePolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.savePolygonShapefileToolStripMenuItem.Text = "Save Polygon Shapefile";
            this.savePolygonShapefileToolStripMenuItem.Click += new System.EventHandler(this.SavePolygonShapeFileToolStripMenuItem_Click);
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.measurementToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomToExtentToolStripMenuItem,
            this.panToolStripMenuItem,
            this.printMapToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mapOptionsToolStripMenuItem.Text = "Map Options";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // measurementToolStripMenuItem
            // 
            this.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem";
            this.measurementToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.measurementToolStripMenuItem.Text = "Measurement";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // zoomToExtentToolStripMenuItem
            // 
            this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            this.zoomToExtentToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.panToolStripMenuItem.Text = "Pan";
            // 
            // printMapToolStripMenuItem
            // 
            this.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            this.printMapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printMapToolStripMenuItem.Text = "Print Map";
            this.printMapToolStripMenuItem.Click += new System.EventHandler(this.PrintMapToolStripMenuItem_Click);
            // 
            // attributeTableOperationsToolStripMenuItem
            // 
            this.attributeTableOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttributeTableToolStripMenuItem,
            this.addAColumnInTheAttributeTableToolStripMenuItem,
            this.deleteAColumnInTheAttributeTableToolStripMenuItem,
            this.updateAttributeTableInShapefileToolStripMenuItem,
            this.exportAttributeTableToExcelToolStripMenuItem});
            this.attributeTableOperationsToolStripMenuItem.Name = "attributeTableOperationsToolStripMenuItem";
            this.attributeTableOperationsToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.attributeTableOperationsToolStripMenuItem.Text = "Attribute Table Operations";
            // 
            // viewAttributeTableToolStripMenuItem
            // 
            this.viewAttributeTableToolStripMenuItem.Name = "viewAttributeTableToolStripMenuItem";
            this.viewAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.viewAttributeTableToolStripMenuItem.Text = "View Attribute Table";
            this.viewAttributeTableToolStripMenuItem.Click += new System.EventHandler(this.ViewAttrbuteTableToolStripMenuItem_Click);
            // 
            // addAColumnInTheAttributeTableToolStripMenuItem
            // 
            this.addAColumnInTheAttributeTableToolStripMenuItem.Name = "addAColumnInTheAttributeTableToolStripMenuItem";
            this.addAColumnInTheAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.addAColumnInTheAttributeTableToolStripMenuItem.Text = "Add a column in the attribute table";
            this.addAColumnInTheAttributeTableToolStripMenuItem.Click += new System.EventHandler(this.CreateAColumInAttributeTableToolStripMenuItem_Click);
            // 
            // deleteAColumnInTheAttributeTableToolStripMenuItem
            // 
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Name = "deleteAColumnInTheAttributeTableToolStripMenuItem";
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Text = "Delete a column in the attribute table";
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Click += new System.EventHandler(this.DeleteColumnInAttributeTableToolStripMenuItem_Click);
            // 
            // updateAttributeTableInShapefileToolStripMenuItem
            // 
            this.updateAttributeTableInShapefileToolStripMenuItem.Name = "updateAttributeTableInShapefileToolStripMenuItem";
            this.updateAttributeTableInShapefileToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.updateAttributeTableInShapefileToolStripMenuItem.Text = "Update attribute table in Shapefile";
            this.updateAttributeTableInShapefileToolStripMenuItem.Click += new System.EventHandler(this.SaveTheColumInShapeFileToolStripMenuItem_Click);
            // 
            // exportAttributeTableToExcelToolStripMenuItem
            // 
            this.exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem";
            this.exportAttributeTableToExcelToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute table to Excel";
            this.exportAttributeTableToExcelToolStripMenuItem.Click += new System.EventHandler(this.ExportAttributeTableToExcelToolStripMenuItem_Click);
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Controls.Add(this.pnlLegend);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 33);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(800, 417);
            this.pnlMap.TabIndex = 2;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.legend1;
            this.map1.Location = new System.Drawing.Point(200, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(600, 417);
            this.map1.TabIndex = 1;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            this.map1.Load += new System.EventHandler(this.map1_Load);
            this.map1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map1_MouseDown);
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 200, 417);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(200, 417);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.UseLegendForSelection = true;
            this.legend1.VerticalScrollEnabled = true;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.legend1);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLegend.Location = new System.Drawing.Point(0, 0);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(200, 417);
            this.pnlLegend.TabIndex = 0;
            // 
            // pnlAttribute
            // 
            this.pnlAttribute.Controls.Add(this.dgvAttributeTable);
            this.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAttribute.Location = new System.Drawing.Point(0, 332);
            this.pnlAttribute.Name = "pnlAttribute";
            this.pnlAttribute.Size = new System.Drawing.Size(800, 118);
            this.pnlAttribute.TabIndex = 3;
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.Size = new System.Drawing.Size(800, 118);
            this.dgvAttributeTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAttribute);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperations);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlAttribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlAttribute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapefileOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeTableOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAColumnInTheAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAColumnInTheAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAttributeTableInShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAttributeTableToExcelToolStripMenuItem;
        private DotSpatial.Controls.Map map1;
        private DotSpatial.Controls.Legend legend1;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
    }
}

