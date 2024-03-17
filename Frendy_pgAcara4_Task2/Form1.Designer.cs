
using System;

namespace Frendy_pgAcara4_Task2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splcMapLegend = new System.Windows.Forms.SplitContainer();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.Map1 = new DotSpatial.Controls.Map();
            this.splcDataOperation = new System.Windows.Forms.SplitContainer();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnFilterByPopulation = new System.Windows.Forms.Button();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.btnViewAttributes = new System.Windows.Forms.Button();
            this.btnRandomColors = new System.Windows.Forms.Button();
            this.btnFilterByPopState = new System.Windows.Forms.Button();
            this.btnFilterByStateName = new System.Windows.Forms.Button();
            this.btnDisplayStateName = new System.Windows.Forms.Button();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).BeginInit();
            this.splcMapLegend.Panel1.SuspendLayout();
            this.splcMapLegend.Panel2.SuspendLayout();
            this.splcMapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).BeginInit();
            this.splcDataOperation.Panel1.SuspendLayout();
            this.splcDataOperation.Panel2.SuspendLayout();
            this.splcDataOperation.SuspendLayout();
            this.gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapToolStripMenuItem,
            this.clearMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loadMapToolStripMenuItem.Text = "&Load Map";
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clearMapToolStripMenuItem.Text = "&Clear Map";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomExtentToolStripMenuItem});
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.mapToolStripMenuItem.Text = "&Map Operations";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.mapToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom &In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom &Out";
            // 
            // zoomExtentToolStripMenuItem
            // 
            this.zoomExtentToolStripMenuItem.Name = "zoomExtentToolStripMenuItem";
            this.zoomExtentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.zoomExtentToolStripMenuItem.Text = "Zoom &Extent";
            // 
            // splcMapLegend
            // 
            this.splcMapLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.splcMapLegend.Location = new System.Drawing.Point(0, 24);
            this.splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            this.splcMapLegend.Panel1.Controls.Add(this.legend1);
            // 
            // splcMapLegend.Panel2
            // 
            this.splcMapLegend.Panel2.Controls.Add(this.Map1);
            this.splcMapLegend.Size = new System.Drawing.Size(800, 228);
            this.splcMapLegend.SplitterDistance = 268;
            this.splcMapLegend.TabIndex = 1;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 268, 228);
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
            this.legend1.Size = new System.Drawing.Size(268, 228);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.UseLegendForSelection = true;
            this.legend1.VerticalScrollEnabled = true;
            // 
            // Map1
            // 
            this.Map1.AllowDrop = true;
            this.Map1.BackColor = System.Drawing.Color.White;
            this.Map1.CollisionDetection = false;
            this.Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map1.ExtendBuffer = false;
            this.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.Map1.IsBusy = false;
            this.Map1.IsZoomedToMaxExtent = false;
            this.Map1.Legend = this.legend1;
            this.Map1.Location = new System.Drawing.Point(0, 0);
            this.Map1.Name = "Map1";
            this.Map1.ProgressHandler = null;
            this.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.RedrawLayersWhileResizing = false;
            this.Map1.SelectionEnabled = true;
            this.Map1.Size = new System.Drawing.Size(528, 228);
            this.Map1.TabIndex = 0;
            this.Map1.ZoomOutFartherThanMaxExtent = false;
            this.Map1.Load += new System.EventHandler(this.Map1_Load);
            // 
            // splcDataOperation
            // 
            this.splcDataOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcDataOperation.Location = new System.Drawing.Point(0, 252);
            this.splcDataOperation.Name = "splcDataOperation";
            this.splcDataOperation.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcDataOperation.Panel1
            // 
            this.splcDataOperation.Panel1.Controls.Add(this.gbOperations);
            this.splcDataOperation.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splcDataOperation.Panel2
            // 
            this.splcDataOperation.Panel2.Controls.Add(this.dgvAttributeTable);
            this.splcDataOperation.Size = new System.Drawing.Size(800, 221);
            this.splcDataOperation.SplitterDistance = 97;
            this.splcDataOperation.TabIndex = 2;
            this.splcDataOperation.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.lblTitle);
            this.gbOperations.Controls.Add(this.btnFilterByPopulation);
            this.gbOperations.Controls.Add(this.txtPopulation);
            this.gbOperations.Controls.Add(this.lblPopulation);
            this.gbOperations.Controls.Add(this.btnViewAttributes);
            this.gbOperations.Controls.Add(this.btnRandomColors);
            this.gbOperations.Controls.Add(this.btnFilterByPopState);
            this.gbOperations.Controls.Add(this.btnFilterByStateName);
            this.gbOperations.Controls.Add(this.btnDisplayStateName);
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperations.Location = new System.Drawing.Point(0, 0);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(800, 97);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 16);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Attribute Table";
            // 
            // btnFilterByPopulation
            // 
            this.btnFilterByPopulation.Location = new System.Drawing.Point(505, 48);
            this.btnFilterByPopulation.Name = "btnFilterByPopulation";
            this.btnFilterByPopulation.Size = new System.Drawing.Size(211, 23);
            this.btnFilterByPopulation.TabIndex = 7;
            this.btnFilterByPopulation.Text = "Filter by amount of &population";
            this.btnFilterByPopulation.UseVisualStyleBackColor = true;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(345, 50);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(154, 20);
            this.txtPopulation.TabIndex = 6;
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(149, 53);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(190, 13);
            this.lblPopulation.TabIndex = 5;
            this.lblPopulation.Text = "Enter the amount of population in 1990";
            // 
            // btnViewAttributes
            // 
            this.btnViewAttributes.Location = new System.Drawing.Point(12, 48);
            this.btnViewAttributes.Name = "btnViewAttributes";
            this.btnViewAttributes.Size = new System.Drawing.Size(131, 23);
            this.btnViewAttributes.TabIndex = 4;
            this.btnViewAttributes.Text = "View &Attributes";
            this.btnViewAttributes.UseVisualStyleBackColor = true;
            this.btnViewAttributes.Click += new EventHandler(btnViewAttributes_Click);
            // 
            // btnRandomColors
            // 
            this.btnRandomColors.Location = new System.Drawing.Point(505, 19);
            this.btnRandomColors.Name = "btnRandomColors";
            this.btnRandomColors.Size = new System.Drawing.Size(211, 23);
            this.btnRandomColors.TabIndex = 3;
            this.btnRandomColors.Text = "&Random colors based on State Name";
            this.btnRandomColors.UseVisualStyleBackColor = true;
            // 
            // btnFilterByPopState
            // 
            this.btnFilterByPopState.Location = new System.Drawing.Point(286, 19);
            this.btnFilterByPopState.Name = "btnFilterByPopState";
            this.btnFilterByPopState.Size = new System.Drawing.Size(213, 23);
            this.btnFilterByPopState.TabIndex = 2;
            this.btnFilterByPopState.Text = "Filter by &Population and State Name";
            this.btnFilterByPopState.UseVisualStyleBackColor = true;
            // 
            // btnFilterByStateName
            // 
            this.btnFilterByStateName.Location = new System.Drawing.Point(149, 19);
            this.btnFilterByStateName.Name = "btnFilterByStateName";
            this.btnFilterByStateName.Size = new System.Drawing.Size(131, 23);
            this.btnFilterByStateName.TabIndex = 1;
            this.btnFilterByStateName.Text = "Filter by &State Name";
            this.btnFilterByStateName.UseVisualStyleBackColor = true;
            // 
            // btnDisplayStateName
            // 
            this.btnDisplayStateName.Location = new System.Drawing.Point(12, 19);
            this.btnDisplayStateName.Name = "btnDisplayStateName";
            this.btnDisplayStateName.Size = new System.Drawing.Size(131, 23);
            this.btnDisplayStateName.TabIndex = 0;
            this.btnDisplayStateName.Text = "&Display State Name";
            this.btnDisplayStateName.UseVisualStyleBackColor = true;
            this.btnDisplayStateName.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.Size = new System.Drawing.Size(800, 120);
            this.dgvAttributeTable.TabIndex = 0;
            this.dgvAttributeTable.SelectionChanged += new System.EventHandler(this.dgvAttributeTable_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.splcDataOperation);
            this.Controls.Add(this.splcMapLegend);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splcMapLegend.Panel1.ResumeLayout(false);
            this.splcMapLegend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).EndInit();
            this.splcMapLegend.ResumeLayout(false);
            this.splcDataOperation.Panel1.ResumeLayout(false);
            this.splcDataOperation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).EndInit();
            this.splcDataOperation.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.loadMapToolStripMenuItem.Click += new EventHandler(LoadMapToolStripMenuItem_Click);
            this.clearMapToolStripMenuItem.Click += new EventHandler(ClearMapToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);
            this.zoomInToolStripMenuItem.Click += new EventHandler(zoomInToolStripMenuItem_Click);
            this.zoomOutToolStripMenuItem.Click += new EventHandler(zoomOutToolStripMenuItem_Click);
            this.zoomExtentToolStripMenuItem.Click += new EventHandler(zoomExtentToolStripMenuItem_Click);
            this.btnDisplayStateName.Click += new EventHandler(btnDisplayStateName_Click);
            this.btnFilterByStateName.Click += new EventHandler(btnFilterByStateName_Click);
            this.btnRandomColors.Click += new EventHandler(btnRandomColors_Click);
            this.btnViewAttributes.Click += new EventHandler(btnViewAttributes_Click);
            this.btnFilterByPopulation.Click += new EventHandler(btnFilterByPopulation_Click);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcMapLegend;
        private System.Windows.Forms.SplitContainer splcDataOperation;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map Map1;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnRandomColors;
        private System.Windows.Forms.Button btnFilterByPopState;
        private System.Windows.Forms.Button btnFilterByStateName;
        private System.Windows.Forms.Button btnDisplayStateName;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnFilterByPopulation;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Button btnViewAttributes;
    }
}

