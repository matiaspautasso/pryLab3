namespace pryLab3.Caja
{
    partial class frmMovimientosHistoricos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chMostrar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // chMostrar
            // 
            this.chMostrar.BackColor = System.Drawing.Color.RosyBrown;
            this.chMostrar.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chMostrar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMostrar.Legends.Add(legend1);
            this.chMostrar.Location = new System.Drawing.Point(39, 103);
            this.chMostrar.Name = "chMostrar";
            this.chMostrar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chMostrar.Series.Add(series1);
            this.chMostrar.Size = new System.Drawing.Size(720, 513);
            this.chMostrar.TabIndex = 0;
            this.chMostrar.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grafico";
            // 
            // frmMovimientosHistoricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chMostrar);
            this.Name = "frmMovimientosHistoricos";
            this.Text = "frmMovimientosHistoricos";
            ((System.ComponentModel.ISupportInitialize)(this.chMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chMostrar;
        private System.Windows.Forms.Label label1;
    }
}