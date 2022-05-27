
namespace Enterprise_Resource_Planning
{
    partial class frmShowGraphChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenderChartBack = new System.Windows.Forms.Button();
            this.lblGenderRatio = new System.Windows.Forms.Label();
            this.chartBloodGroup = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBloodGroupRatio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBloodGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGender
            // 
            this.chartGender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chartGender.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea3.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGender.Legends.Add(legend3);
            this.chartGender.Location = new System.Drawing.Point(69, 75);
            this.chartGender.Name = "chartGender";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "ShowGenderChart";
            this.chartGender.Series.Add(series3);
            this.chartGender.Size = new System.Drawing.Size(440, 300);
            this.chartGender.TabIndex = 0;
            this.chartGender.Text = "Gender Chart";
            // 
            // btnGenderChartBack
            // 
            this.btnGenderChartBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenderChartBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenderChartBack.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGenderChartBack.Location = new System.Drawing.Point(1232, 25);
            this.btnGenderChartBack.Name = "btnGenderChartBack";
            this.btnGenderChartBack.Size = new System.Drawing.Size(94, 42);
            this.btnGenderChartBack.TabIndex = 1;
            this.btnGenderChartBack.Text = "Back";
            this.btnGenderChartBack.UseVisualStyleBackColor = false;
            this.btnGenderChartBack.Click += new System.EventHandler(this.btnGenderChartBack_Click);
            // 
            // lblGenderRatio
            // 
            this.lblGenderRatio.AutoSize = true;
            this.lblGenderRatio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGenderRatio.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderRatio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGenderRatio.Location = new System.Drawing.Point(68, 44);
            this.lblGenderRatio.Name = "lblGenderRatio";
            this.lblGenderRatio.Size = new System.Drawing.Size(122, 24);
            this.lblGenderRatio.TabIndex = 2;
            this.lblGenderRatio.Text = "Gender Ratio";
            // 
            // chartBloodGroup
            // 
            this.chartBloodGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chartBloodGroup.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea4.Name = "ChartArea1";
            this.chartBloodGroup.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartBloodGroup.Legends.Add(legend4);
            this.chartBloodGroup.Location = new System.Drawing.Point(609, 74);
            this.chartBloodGroup.Name = "chartBloodGroup";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "ShowBloodGroupChart";
            this.chartBloodGroup.Series.Add(series4);
            this.chartBloodGroup.Size = new System.Drawing.Size(440, 300);
            this.chartBloodGroup.TabIndex = 3;
            this.chartBloodGroup.Text = "Blood Group Chart";
            // 
            // lblBloodGroupRatio
            // 
            this.lblBloodGroupRatio.AutoSize = true;
            this.lblBloodGroupRatio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBloodGroupRatio.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroupRatio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBloodGroupRatio.Location = new System.Drawing.Point(610, 42);
            this.lblBloodGroupRatio.Name = "lblBloodGroupRatio";
            this.lblBloodGroupRatio.Size = new System.Drawing.Size(167, 24);
            this.lblBloodGroupRatio.TabIndex = 4;
            this.lblBloodGroupRatio.Text = "Blood Group Ratio";
            // 
            // frmShowGraphChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 506);
            this.Controls.Add(this.lblBloodGroupRatio);
            this.Controls.Add(this.chartBloodGroup);
            this.Controls.Add(this.lblGenderRatio);
            this.Controls.Add(this.btnGenderChartBack);
            this.Controls.Add(this.chartGender);
            this.Name = "frmShowGraphChart";
            this.Text = "Details_Chart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gender_Chart_FormClosed);
            this.Load += new System.EventHandler(this.Gender_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBloodGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.Button btnGenderChartBack;
        private System.Windows.Forms.Label lblGenderRatio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBloodGroup;
        private System.Windows.Forms.Label lblBloodGroupRatio;
    }
}