namespace WindowsFormsApplication1
{
    partial class Form3
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
            dotnetCHARTING.WinForms.Label label1 = new dotnetCHARTING.WinForms.Label();
            this.button31 = new System.Windows.Forms.Button();
            this.chart31 = new dotnetCHARTING.WinForms.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart31)).BeginInit();
            this.SuspendLayout();
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(694, 457);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 0;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // chart31
            // 
            this.chart31.Background.Color = System.Drawing.Color.White;
            this.chart31.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.chart31.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.chart31.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.chart31.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart31.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.chart31.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chart31.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart31.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.chart31.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart31.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.chart31.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.chart31.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.chart31.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.chart31.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.chart31.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart31.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.chart31.ChartArea.LegendBox.Padding = 4;
            this.chart31.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.chart31.ChartArea.LegendBox.Visible = true;
            this.chart31.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.chart31.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart31.ChartArea.Title = "Chart31";
            this.chart31.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.chart31.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart31.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.chart31.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.chart31.ChartArea.TitleBox.Label.Text = "Chart31";
            this.chart31.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.chart31.ChartArea.TitleBox.Visible = true;
            this.chart31.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart31.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.chart31.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart31.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart31.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart31.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.chart31.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.chart31.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.chart31.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.chart31.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.chart31.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.chart31.DataGrid = null;
            this.chart31.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.chart31.LabelChart = label1;
            this.chart31.Location = new System.Drawing.Point(12, 9);
            this.chart31.Name = "chart31";
            this.chart31.NoDataLabel.Text = "No Data";
            this.chart31.Size = new System.Drawing.Size(640, 480);
            this.chart31.StartDateOfYear = new System.DateTime(((long)(0)));
            this.chart31.TabIndex = 1;
            this.chart31.TempDirectory = "C:\\Users\\J\\AppData\\Local\\Temp\\";
            this.chart31.Title = "Chart31";
            this.chart31.Use3D = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 501);
            this.Controls.Add(this.chart31);
            this.Controls.Add(this.button31);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.chart31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button31;
        private dotnetCHARTING.WinForms.Chart chart31;
    }
}