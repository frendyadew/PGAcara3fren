
namespace frendy_pgacara3_task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.btnLoadRaster = new System.Windows.Forms.Button();
            this.btnHillshade = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnMultiplyRaster = new System.Windows.Forms.Button();
            this.btnReclassify = new System.Windows.Forms.Button();
            this.lblElevation = new System.Windows.Forms.Label();
            this.lblRasterValue = new System.Windows.Forms.Label();
            this.chbRasterValue = new System.Windows.Forms.CheckBox();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.Legend1 = new DotSpatial.Controls.Legend();
            this.Map1 = new DotSpatial.Controls.Map();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.pnlOperations.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.txtElevation);
            this.pnlOperations.Controls.Add(this.chbRasterValue);
            this.pnlOperations.Controls.Add(this.lblRasterValue);
            this.pnlOperations.Controls.Add(this.lblElevation);
            this.pnlOperations.Controls.Add(this.btnReclassify);
            this.pnlOperations.Controls.Add(this.btnMultiplyRaster);
            this.pnlOperations.Controls.Add(this.btnChangeColor);
            this.pnlOperations.Controls.Add(this.btnHillshade);
            this.pnlOperations.Controls.Add(this.btnLoadRaster);
            this.pnlOperations.Location = new System.Drawing.Point(2, 1);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(795, 100);
            this.pnlOperations.TabIndex = 0;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.Legend1);
            this.pnlLegend.Location = new System.Drawing.Point(2, 107);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(190, 341);
            this.pnlLegend.TabIndex = 1;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.Map1);
            this.pnlMap.Location = new System.Drawing.Point(198, 107);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(599, 341);
            this.pnlMap.TabIndex = 2;
            // 
            // btnLoadRaster
            // 
            this.btnLoadRaster.Location = new System.Drawing.Point(10, 11);
            this.btnLoadRaster.Name = "btnLoadRaster";
            this.btnLoadRaster.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRaster.TabIndex = 0;
            this.btnLoadRaster.Text = "&Load Raster";
            this.btnLoadRaster.UseVisualStyleBackColor = true;
            this.btnLoadRaster.Click += new System.EventHandler(this.btnLoadRaster_Click);
            // 
            // btnHillshade
            // 
            this.btnHillshade.Location = new System.Drawing.Point(91, 11);
            this.btnHillshade.Name = "btnHillshade";
            this.btnHillshade.Size = new System.Drawing.Size(75, 23);
            this.btnHillshade.TabIndex = 1;
            this.btnHillshade.Text = "&Hillshade";
            this.btnHillshade.UseVisualStyleBackColor = true;
            this.btnHillshade.Click += new System.EventHandler(this.btnHillshade_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(172, 11);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "Change &Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnMultiplyRaster
            // 
            this.btnMultiplyRaster.Location = new System.Drawing.Point(253, 11);
            this.btnMultiplyRaster.Name = "btnMultiplyRaster";
            this.btnMultiplyRaster.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplyRaster.TabIndex = 3;
            this.btnMultiplyRaster.Text = "&Multiply Raster";
            this.btnMultiplyRaster.UseVisualStyleBackColor = true;
            this.btnMultiplyRaster.Click += new System.EventHandler(this.btnMultiplyRaster_Click);
            // 
            // btnReclassify
            // 
            this.btnReclassify.Location = new System.Drawing.Point(474, 34);
            this.btnReclassify.Name = "btnReclassify";
            this.btnReclassify.Size = new System.Drawing.Size(93, 23);
            this.btnReclassify.TabIndex = 4;
            this.btnReclassify.Text = "&Reclassify Raster";
            this.btnReclassify.UseVisualStyleBackColor = true;
            this.btnReclassify.Click += new System.EventHandler(this.btnReclassify_Click);
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(336, 39);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(51, 13);
            this.lblElevation.TabIndex = 5;
            this.lblElevation.Text = "Elevation";
            // 
            // lblRasterValue
            // 
            this.lblRasterValue.AutoSize = true;
            this.lblRasterValue.Location = new System.Drawing.Point(620, 70);
            this.lblRasterValue.Name = "lblRasterValue";
            this.lblRasterValue.Size = new System.Drawing.Size(106, 13);
            this.lblRasterValue.TabIndex = 6;
            this.lblRasterValue.Text = "Row: Column: Value:";
            // 
            // chbRasterValue
            // 
            this.chbRasterValue.AutoSize = true;
            this.chbRasterValue.Location = new System.Drawing.Point(614, 34);
            this.chbRasterValue.Name = "chbRasterValue";
            this.chbRasterValue.Size = new System.Drawing.Size(161, 17);
            this.chbRasterValue.TabIndex = 7;
            this.chbRasterValue.Text = "Raster value at clicked point";
            this.chbRasterValue.UseVisualStyleBackColor = true;
            this.chbRasterValue.CheckedChanged += new System.EventHandler(this.chbRasterValue_CheckedChanged);
            this.chbRasterValue.Click += new System.EventHandler(this.chbRasterValue_CheckedChanged);
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(393, 36);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.Size = new System.Drawing.Size(46, 20);
            this.txtElevation.TabIndex = 8;
            this.txtElevation.Text = "3000";
            // 
            // Legend1
            // 
            this.Legend1.BackColor = System.Drawing.Color.White;
            this.Legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 190, 341);
            this.Legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.Legend1.HorizontalScrollEnabled = true;
            this.Legend1.Indentation = 30;
            this.Legend1.IsInitialized = false;
            this.Legend1.Location = new System.Drawing.Point(0, 0);
            this.Legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.Legend1.Name = "Legend1";
            this.Legend1.ProgressHandler = null;
            this.Legend1.ResetOnResize = false;
            this.Legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.Legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Legend1.Size = new System.Drawing.Size(190, 341);
            this.Legend1.TabIndex = 0;
            this.Legend1.Text = "legend1";
            this.Legend1.UseLegendForSelection = true;
            this.Legend1.VerticalScrollEnabled = true;
            // 
            // Map1
            // 
            this.Map1.AllowDrop = true;
            this.Map1.BackColor = System.Drawing.Color.White;
            this.Map1.CollisionDetection = false;
            this.Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map1.ExtendBuffer = false;
            this.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.Map1.IsBusy = false;
            this.Map1.IsZoomedToMaxExtent = false;
            this.Map1.Legend = this.Legend1;
            this.Map1.Location = new System.Drawing.Point(0, 0);
            this.Map1.Name = "Map1";
            this.Map1.ProgressHandler = null;
            this.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.RedrawLayersWhileResizing = false;
            this.Map1.SelectionEnabled = true;
            this.Map1.Size = new System.Drawing.Size(599, 341);
            this.Map1.TabIndex = 0;
            this.Map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = null;
            this.appManager1.HeaderControl = null;
            this.appManager1.Legend = this.Legend1;
            this.appManager1.Map = this.Map1;
            this.appManager1.ProgressHandler = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Button btnReclassify;
        private System.Windows.Forms.Button btnMultiplyRaster;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnHillshade;
        private System.Windows.Forms.Button btnLoadRaster;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label lblRasterValue;
        private System.Windows.Forms.CheckBox chbRasterValue;
        private System.Windows.Forms.TextBox txtElevation;
        private DotSpatial.Controls.Legend Legend1;
        private DotSpatial.Controls.Map Map1;
        private DotSpatial.Controls.AppManager appManager1;
    }
}

