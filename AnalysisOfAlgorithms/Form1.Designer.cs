namespace AnalysisOfAlgorithms
{
    partial class HuffmanGUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decodedLbl = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.chart0 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaticRadio = new System.Windows.Forms.RadioButton();
            this.DynamicRadio = new System.Windows.Forms.RadioButton();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.Graphics = new System.Windows.Forms.Label();
            this.FileInfLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.CharNumberLabel = new System.Windows.Forms.Label();
            this.NOCLabel = new System.Windows.Forms.Label();
            this.DynamicResult = new System.Windows.Forms.RichTextBox();
            this.BothRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart0)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ChooseFileButton.Location = new System.Drawing.Point(436, 59);
            this.ChooseFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(400, 41);
            this.ChooseFileButton.TabIndex = 3;
            this.ChooseFileButton.Text = "Добавить документ";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(432, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 4;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(32, 201);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(804, 44);
            this.start.TabIndex = 5;
            this.start.Text = "Начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(19, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(19, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 9;
            // 
            // decodedLbl
            // 
            this.decodedLbl.AutoSize = true;
            this.decodedLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.decodedLbl.Location = new System.Drawing.Point(147, 389);
            this.decodedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodedLbl.Name = "decodedLbl";
            this.decodedLbl.Size = new System.Drawing.Size(0, 23);
            this.decodedLbl.TabIndex = 10;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddLabel.Location = new System.Drawing.Point(432, 31);
            this.AddLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(353, 20);
            this.AddLabel.TabIndex = 12;
            this.AddLabel.Text = "Нажмите чтобы добавить документ:";
            // 
            // chart0
            // 
            this.chart0.BackColor = System.Drawing.Color.Transparent;
            this.chart0.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart0.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart0.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart0.Legends.Add(legend1);
            this.chart0.Location = new System.Drawing.Point(8, 14);
            this.chart0.Margin = new System.Windows.Forms.Padding(4);
            this.chart0.Name = "chart0";
            this.chart0.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart0.Series.Add(series1);
            this.chart0.Size = new System.Drawing.Size(795, 294);
            this.chart0.TabIndex = 1;
            this.chart0.Text = "chart0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(332, 560);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Коэффициент сжатия";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.chart0);
            this.panel1.Location = new System.Drawing.Point(33, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 315);
            this.panel1.TabIndex = 2;
            // 
            // StaticRadio
            // 
            this.StaticRadio.AutoSize = true;
            this.StaticRadio.Location = new System.Drawing.Point(36, 69);
            this.StaticRadio.Margin = new System.Windows.Forms.Padding(4);
            this.StaticRadio.Name = "StaticRadio";
            this.StaticRadio.Size = new System.Drawing.Size(114, 21);
            this.StaticRadio.TabIndex = 13;
            this.StaticRadio.TabStop = true;
            this.StaticRadio.Text = "Статический";
            this.StaticRadio.UseVisualStyleBackColor = true;
            // 
            // DynamicRadio
            // 
            this.DynamicRadio.AutoSize = true;
            this.DynamicRadio.Location = new System.Drawing.Point(169, 69);
            this.DynamicRadio.Margin = new System.Windows.Forms.Padding(4);
            this.DynamicRadio.Name = "DynamicRadio";
            this.DynamicRadio.Size = new System.Drawing.Size(127, 21);
            this.DynamicRadio.TabIndex = 14;
            this.DynamicRadio.TabStop = true;
            this.DynamicRadio.Text = "Динамический";
            this.DynamicRadio.UseVisualStyleBackColor = true;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectionLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.SelectionLabel.Location = new System.Drawing.Point(31, 31);
            this.SelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(263, 20);
            this.SelectionLabel.TabIndex = 16;
            this.SelectionLabel.Text = "Тип алгоритма Хаффмана:";
            // 
            // Graphics
            // 
            this.Graphics.AutoSize = true;
            this.Graphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Graphics.ForeColor = System.Drawing.Color.SteelBlue;
            this.Graphics.Location = new System.Drawing.Point(27, 534);
            this.Graphics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Graphics.Name = "Graphics";
            this.Graphics.Size = new System.Drawing.Size(805, 25);
            this.Graphics.TabIndex = 17;
            this.Graphics.Text = "Графики -------------------------------------------------------------------------" +
    "--------------";
            // 
            // FileInfLabel
            // 
            this.FileInfLabel.AutoSize = true;
            this.FileInfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FileInfLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.FileInfLabel.Location = new System.Drawing.Point(27, 117);
            this.FileInfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileInfLabel.Name = "FileInfLabel";
            this.FileInfLabel.Size = new System.Drawing.Size(780, 25);
            this.FileInfLabel.TabIndex = 18;
            this.FileInfLabel.Text = "Document Information ------------------------------------------------------------" +
    "---------";
            this.FileInfLabel.Click += new System.EventHandler(this.FileInfLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(371, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Размер:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SizeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SizeLabel.Location = new System.Drawing.Point(462, 160);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(104, 20);
            this.SizeLabel.TabIndex = 20;
            this.SizeLabel.Text = "                   ";
            // 
            // DName
            // 
            this.DName.AutoSize = true;
            this.DName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DName.Location = new System.Drawing.Point(142, 160);
            this.DName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(99, 20);
            this.DName.TabIndex = 22;
            this.DName.Text = "                  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(29, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Название:";
            // 
            // Results
            // 
            this.Results.BackColor = System.Drawing.Color.LightBlue;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Results.Location = new System.Drawing.Point(33, 262);
            this.Results.Margin = new System.Windows.Forms.Padding(4);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(397, 254);
            this.Results.TabIndex = 23;
            this.Results.Text = "";
            // 
            // CharNumberLabel
            // 
            this.CharNumberLabel.AutoSize = true;
            this.CharNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CharNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.CharNumberLabel.Location = new System.Drawing.Point(669, 160);
            this.CharNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CharNumberLabel.Name = "CharNumberLabel";
            this.CharNumberLabel.Size = new System.Drawing.Size(107, 20);
            this.CharNumberLabel.TabIndex = 24;
            this.CharNumberLabel.Text = "Символов:";
            this.CharNumberLabel.Click += new System.EventHandler(this.CharNumberLabel_Click);
            // 
            // NOCLabel
            // 
            this.NOCLabel.AutoSize = true;
            this.NOCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NOCLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NOCLabel.Location = new System.Drawing.Point(784, 160);
            this.NOCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOCLabel.Name = "NOCLabel";
            this.NOCLabel.Size = new System.Drawing.Size(54, 20);
            this.NOCLabel.TabIndex = 25;
            this.NOCLabel.Text = "         ";
            // 
            // DynamicResult
            // 
            this.DynamicResult.BackColor = System.Drawing.Color.PaleGreen;
            this.DynamicResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DynamicResult.Location = new System.Drawing.Point(436, 262);
            this.DynamicResult.Margin = new System.Windows.Forms.Padding(4);
            this.DynamicResult.Name = "DynamicResult";
            this.DynamicResult.Size = new System.Drawing.Size(399, 254);
            this.DynamicResult.TabIndex = 26;
            this.DynamicResult.Text = "";
            // 
            // BothRadio
            // 
            this.BothRadio.AutoSize = true;
            this.BothRadio.Location = new System.Drawing.Point(301, 69);
            this.BothRadio.Margin = new System.Windows.Forms.Padding(4);
            this.BothRadio.Name = "BothRadio";
            this.BothRadio.Size = new System.Drawing.Size(56, 21);
            this.BothRadio.TabIndex = 27;
            this.BothRadio.TabStop = true;
            this.BothRadio.Text = "Оба";
            this.BothRadio.UseVisualStyleBackColor = true;
            // 
            // HuffmanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(865, 922);
            this.Controls.Add(this.BothRadio);
            this.Controls.Add(this.DynamicResult);
            this.Controls.Add(this.NOCLabel);
            this.Controls.Add(this.CharNumberLabel);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FileInfLabel);
            this.Controls.Add(this.Graphics);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.DynamicRadio);
            this.Controls.Add(this.StaticRadio);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.decodedLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HuffmanGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Хаффмана";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart0)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label decodedLbl;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton StaticRadio;
        private System.Windows.Forms.RadioButton DynamicRadio;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.Label Graphics;
        private System.Windows.Forms.Label FileInfLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label DName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Label CharNumberLabel;
        private System.Windows.Forms.Label NOCLabel;
        private System.Windows.Forms.RichTextBox DynamicResult;
        private System.Windows.Forms.RadioButton BothRadio;
    }
}

