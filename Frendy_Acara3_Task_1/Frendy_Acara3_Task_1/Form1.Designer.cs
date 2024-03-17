using System;
namespace Frendy_Acara3_Task_1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomToExtent = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.map1 = new DotSpatial.Controls.Map();
            this.pnlOperations.SuspendLayout();
            this.grbOperations.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            this.btnNone.Click += new EventHandler(this.btnNone_Click);
            this.btnSelect.Click += new EventHandler(this.btnSelect_Click);
            this.btnInfo.Click += new EventHandler(this.btnInfo_Click);
            this.btnPan.Click += new EventHandler(this.btnPan_Click);
            this.btnZoomToExtent.Click += new EventHandler(this.btnZoomToExtent_Click);
            this.btnZoomOut.Click += new EventHandler(this.btnZoomOut_Click);
            this.btnZoomIn.Click += new EventHandler(this.btnZoomIn_Click);
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnLoad.Click += new EventHandler(this.btnLoad_Click);
        //    this.btnMeasure.Click += new EventHandler(this.btnMeasure_Click);
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.lblTitle);
            this.pnlOperations.Controls.Add(this.grbOperations);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(668, 107);
            this.pnlOperations.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(214, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Basic Map Operations";
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnNone);
            this.grbOperations.Controls.Add(this.btnSelect);
            this.grbOperations.Controls.Add(this.btnMeasure);
            this.grbOperations.Controls.Add(this.btnInfo);
            this.grbOperations.Controls.Add(this.btnPan);
            this.grbOperations.Controls.Add(this.btnZoomToExtent);
            this.grbOperations.Controls.Add(this.btnZoomOut);
            this.grbOperations.Controls.Add(this.btnZoomIn);
            this.grbOperations.Controls.Add(this.btnClear);
            this.grbOperations.Controls.Add(this.btnLoad);
            this.grbOperations.Location = new System.Drawing.Point(12, 27);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(644, 74);
            this.grbOperations.TabIndex = 0;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "Operations";
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(368, 45);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 9;
            this.btnNone.Text = "&None";
            this.btnNone.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(287, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(206, 45);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(75, 23);
            this.btnMeasure.TabIndex = 7;
            this.btnMeasure.Text = "&Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;

            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(125, 45);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "In&fo";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(468, 19);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(75, 23);
            this.btnPan.TabIndex = 5;
            this.btnPan.Text = "&Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            // 
            // btnZoomToExtent
            // 
            this.btnZoomToExtent.Location = new System.Drawing.Point(368, 19);
            this.btnZoomToExtent.Name = "btnZoomToExtent";
            this.btnZoomToExtent.Size = new System.Drawing.Size(94, 23);
            this.btnZoomToExtent.TabIndex = 4;
            this.btnZoomToExtent.Text = "Zoom to &Extent";
            this.btnZoomToExtent.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(287, 19);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "Zoom &Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(206, 19);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "Zoom &In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear Map";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(44, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load Map";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 107);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(668, 334);
            this.pnlMap.TabIndex = 1;
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
            this.map1.Legend = null;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(668, 334);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 441);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.grbOperations.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlMap;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoomToExtent;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitle;
    }
}

