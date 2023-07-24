
namespace Examen_graficas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafica_barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_graficar = new System.Windows.Forms.Button();
            this.icon_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_datos = new System.Windows.Forms.TextBox();
            this.label_series = new System.Windows.Forms.Label();
            this.label_datos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // grafica_barras
            // 
            chartArea3.Name = "ChartArea1";
            this.grafica_barras.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafica_barras.Legends.Add(legend3);
            this.grafica_barras.Location = new System.Drawing.Point(234, 58);
            this.grafica_barras.Name = "grafica_barras";
            this.grafica_barras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.grafica_barras.Series.Add(series3);
            this.grafica_barras.Size = new System.Drawing.Size(317, 243);
            this.grafica_barras.TabIndex = 0;
            this.grafica_barras.Text = "chart1";
            // 
            // btn_graficar
            // 
            this.btn_graficar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_graficar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graficar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graficar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_graficar.Location = new System.Drawing.Point(282, 325);
            this.btn_graficar.Name = "btn_graficar";
            this.btn_graficar.Size = new System.Drawing.Size(111, 39);
            this.btn_graficar.TabIndex = 4;
            this.btn_graficar.Text = "Graficar";
            this.btn_graficar.UseVisualStyleBackColor = false;
            this.btn_graficar.Click += new System.EventHandler(this.btn_graficar_Click_1);
            // 
            // icon_cerrar
            // 
            this.icon_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.icon_cerrar.BackgroundImage = global::Examen_graficas.Properties.Resources._7479439;
            this.icon_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_cerrar.Location = new System.Drawing.Point(564, 7);
            this.icon_cerrar.Name = "icon_cerrar";
            this.icon_cerrar.Size = new System.Drawing.Size(23, 23);
            this.icon_cerrar.TabIndex = 1;
            this.icon_cerrar.TabStop = false;
            this.icon_cerrar.Click += new System.EventHandler(this.icon_cerrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Orange;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpiar.Location = new System.Drawing.Point(399, 325);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(111, 39);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_serie
            // 
            this.txt_serie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_serie.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serie.Location = new System.Drawing.Point(53, 136);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(100, 18);
            this.txt_serie.TabIndex = 6;
            // 
            // txt_datos
            // 
            this.txt_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datos.Location = new System.Drawing.Point(53, 224);
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.Size = new System.Drawing.Size(100, 18);
            this.txt_datos.TabIndex = 7;
            // 
            // label_series
            // 
            this.label_series.AutoSize = true;
            this.label_series.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_series.Location = new System.Drawing.Point(48, 106);
            this.label_series.Name = "label_series";
            this.label_series.Size = new System.Drawing.Size(63, 27);
            this.label_series.TabIndex = 8;
            this.label_series.Text = "Series";
            // 
            // label_datos
            // 
            this.label_datos.AutoSize = true;
            this.label_datos.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datos.Location = new System.Drawing.Point(52, 194);
            this.label_datos.Name = "label_datos";
            this.label_datos.Size = new System.Drawing.Size(59, 27);
            this.label_datos.TabIndex = 9;
            this.label_datos.Text = "Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 408);
            this.Controls.Add(this.label_datos);
            this.Controls.Add(this.label_series);
            this.Controls.Add(this.txt_datos);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_graficar);
            this.Controls.Add(this.icon_cerrar);
            this.Controls.Add(this.grafica_barras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafica_barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_barras;
        private System.Windows.Forms.PictureBox icon_cerrar;
        private System.Windows.Forms.Button btn_graficar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_datos;
        private System.Windows.Forms.Label label_series;
        private System.Windows.Forms.Label label_datos;
    }
}

