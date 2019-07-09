namespace wfaRegularPolygons
{
    partial class FrmRegularPolygons
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSides = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.nudSides = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.BtnSkia = new System.Windows.Forms.Button();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblCorLabel = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSides
            // 
            this.lblSides.AutoSize = true;
            this.lblSides.Location = new System.Drawing.Point(12, 9);
            this.lblSides.Name = "lblSides";
            this.lblSides.Size = new System.Drawing.Size(36, 13);
            this.lblSides.TabIndex = 0;
            this.lblSides.Text = "Sides:";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(67, 9);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius:";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(125, 9);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(37, 13);
            this.lblAngle.TabIndex = 2;
            this.lblAngle.Text = "Angle:";
            // 
            // nudSides
            // 
            this.nudSides.Location = new System.Drawing.Point(12, 25);
            this.nudSides.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSides.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSides.Name = "nudSides";
            this.nudSides.Size = new System.Drawing.Size(52, 20);
            this.nudSides.TabIndex = 3;
            this.nudSides.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(70, 25);
            this.nudRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(52, 20);
            this.nudRadius.TabIndex = 4;
            this.nudRadius.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(128, 25);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(52, 20);
            this.nudAngle.TabIndex = 5;
            this.nudAngle.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(408, 12);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(70, 33);
            this.BtnDraw.TabIndex = 6;
            this.BtnDraw.Text = "Draw &GDI+";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 51);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(466, 372);
            this.picCanvas.TabIndex = 7;
            this.picCanvas.TabStop = false;
            // 
            // BtnSkia
            // 
            this.BtnSkia.Location = new System.Drawing.Point(332, 12);
            this.BtnSkia.Name = "BtnSkia";
            this.BtnSkia.Size = new System.Drawing.Size(70, 33);
            this.BtnSkia.TabIndex = 8;
            this.BtnSkia.Text = "Draw &SKIA";
            this.BtnSkia.UseVisualStyleBackColor = true;
            this.BtnSkia.Click += new System.EventHandler(this.BtnSkia_Click);
            // 
            // lblCor
            // 
            this.lblCor.BackColor = System.Drawing.Color.Red;
            this.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor.Location = new System.Drawing.Point(186, 25);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(52, 20);
            this.lblCor.TabIndex = 10;
            this.lblCor.Click += new System.EventHandler(this.LblCor_Click);
            // 
            // lblCorLabel
            // 
            this.lblCorLabel.AutoSize = true;
            this.lblCorLabel.Location = new System.Drawing.Point(183, 9);
            this.lblCorLabel.Name = "lblCorLabel";
            this.lblCorLabel.Size = new System.Drawing.Size(34, 13);
            this.lblCorLabel.TabIndex = 12;
            this.lblCorLabel.Text = "Color:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(241, 9);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "Width:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(244, 25);
            this.nudWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(52, 20);
            this.nudWidth.TabIndex = 14;
            this.nudWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FrmRegularPolygonsDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 435);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblCorLabel);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.BtnSkia);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.nudAngle);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.nudSides);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblSides);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegularPolygonsDrawing";
            this.ShowIcon = false;
            this.Text = "Regular Polygons";
            ((System.ComponentModel.ISupportInitialize)(this.nudSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSides;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.NumericUpDown nudSides;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button BtnSkia;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblCorLabel;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nudWidth;
    }
}

