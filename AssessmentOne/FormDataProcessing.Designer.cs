namespace AssessmentOne
{
    partial class FormDataProcessing
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
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoadSensorData = new System.Windows.Forms.Button();
            this.listViewSensorData = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBinSearchIterA = new System.Windows.Forms.Button();
            this.textBoxBinSearchIterA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBinSearchRecA = new System.Windows.Forms.Button();
            this.textBoxBinSearchRecA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearchTargetA = new System.Windows.Forms.TextBox();
            this.buttonSelectionSortA = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSelectionSortA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonInsertionSortA = new System.Windows.Forms.Button();
            this.textBoxInsertionSortA = new System.Windows.Forms.TextBox();
            this.listBoxSensorA = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonBinSearchIterB = new System.Windows.Forms.Button();
            this.textBoxBinSearchIterB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBinSearchRecB = new System.Windows.Forms.Button();
            this.textBoxBinSearchRecB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSearchTargetB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonSelectionSortB = new System.Windows.Forms.Button();
            this.textBoxSelectionSortB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonInsertionSortB = new System.Windows.Forms.Button();
            this.textBoxInsertionSortB = new System.Windows.Forms.TextBox();
            this.listBoxSensorB = new System.Windows.Forms.ListBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.Location = new System.Drawing.Point(42, 29);
            this.numericUpDownSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownSigma.TabIndex = 0;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sigma";
            // 
            // numericUpDownMu
            // 
            this.numericUpDownMu.Location = new System.Drawing.Point(107, 29);
            this.numericUpDownMu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownMu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownMu.Name = "numericUpDownMu";
            this.numericUpDownMu.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownMu.TabIndex = 2;
            this.numericUpDownMu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mu";
            // 
            // buttonLoadSensorData
            // 
            this.buttonLoadSensorData.Location = new System.Drawing.Point(42, 56);
            this.buttonLoadSensorData.Name = "buttonLoadSensorData";
            this.buttonLoadSensorData.Size = new System.Drawing.Size(108, 23);
            this.buttonLoadSensorData.TabIndex = 4;
            this.buttonLoadSensorData.Text = "Load Sensor Data";
            this.buttonLoadSensorData.UseVisualStyleBackColor = true;
            // 
            // listViewSensorData
            // 
            this.listViewSensorData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSensorData.HideSelection = false;
            this.listViewSensorData.Location = new System.Drawing.Point(12, 85);
            this.listViewSensorData.Name = "listViewSensorData";
            this.listViewSensorData.Size = new System.Drawing.Size(172, 427);
            this.listViewSensorData.TabIndex = 5;
            this.listViewSensorData.UseCompatibleStateImageBehavior = false;
            this.listViewSensorData.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sensor A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Binary Search Iterative";
            // 
            // buttonBinSearchIterA
            // 
            this.buttonBinSearchIterA.Location = new System.Drawing.Point(211, 64);
            this.buttonBinSearchIterA.Name = "buttonBinSearchIterA";
            this.buttonBinSearchIterA.Size = new System.Drawing.Size(75, 23);
            this.buttonBinSearchIterA.TabIndex = 8;
            this.buttonBinSearchIterA.Text = "Search";
            this.buttonBinSearchIterA.UseVisualStyleBackColor = true;
            // 
            // textBoxBinSearchIterA
            // 
            this.textBoxBinSearchIterA.Location = new System.Drawing.Point(211, 94);
            this.textBoxBinSearchIterA.Name = "textBoxBinSearchIterA";
            this.textBoxBinSearchIterA.ReadOnly = true;
            this.textBoxBinSearchIterA.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinSearchIterA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Binary Search Recursive";
            // 
            // buttonBinSearchRecA
            // 
            this.buttonBinSearchRecA.Location = new System.Drawing.Point(214, 155);
            this.buttonBinSearchRecA.Name = "buttonBinSearchRecA";
            this.buttonBinSearchRecA.Size = new System.Drawing.Size(75, 23);
            this.buttonBinSearchRecA.TabIndex = 11;
            this.buttonBinSearchRecA.Text = "Search";
            this.buttonBinSearchRecA.UseVisualStyleBackColor = true;
            // 
            // textBoxBinSearchRecA
            // 
            this.textBoxBinSearchRecA.Location = new System.Drawing.Point(214, 185);
            this.textBoxBinSearchRecA.Name = "textBoxBinSearchRecA";
            this.textBoxBinSearchRecA.ReadOnly = true;
            this.textBoxBinSearchRecA.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinSearchRecA.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Target";
            // 
            // textBoxSearchTargetA
            // 
            this.textBoxSearchTargetA.Location = new System.Drawing.Point(259, 231);
            this.textBoxSearchTargetA.Name = "textBoxSearchTargetA";
            this.textBoxSearchTargetA.Size = new System.Drawing.Size(52, 20);
            this.textBoxSearchTargetA.TabIndex = 15;
            // 
            // buttonSelectionSortA
            // 
            this.buttonSelectionSortA.Location = new System.Drawing.Point(217, 320);
            this.buttonSelectionSortA.Name = "buttonSelectionSortA";
            this.buttonSelectionSortA.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectionSortA.TabIndex = 16;
            this.buttonSelectionSortA.Text = "Sort";
            this.buttonSelectionSortA.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selection Sort";
            // 
            // textBoxSelectionSortA
            // 
            this.textBoxSelectionSortA.Location = new System.Drawing.Point(217, 349);
            this.textBoxSelectionSortA.Name = "textBoxSelectionSortA";
            this.textBoxSelectionSortA.ReadOnly = true;
            this.textBoxSelectionSortA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectionSortA.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Insertion Sort";
            // 
            // buttonInsertionSortA
            // 
            this.buttonInsertionSortA.Location = new System.Drawing.Point(220, 407);
            this.buttonInsertionSortA.Name = "buttonInsertionSortA";
            this.buttonInsertionSortA.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertionSortA.TabIndex = 20;
            this.buttonInsertionSortA.Text = "Sort";
            this.buttonInsertionSortA.UseVisualStyleBackColor = true;
            // 
            // textBoxInsertionSortA
            // 
            this.textBoxInsertionSortA.Location = new System.Drawing.Point(220, 437);
            this.textBoxInsertionSortA.Name = "textBoxInsertionSortA";
            this.textBoxInsertionSortA.ReadOnly = true;
            this.textBoxInsertionSortA.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertionSortA.TabIndex = 21;
            // 
            // listBoxSensorA
            // 
            this.listBoxSensorA.FormattingEnabled = true;
            this.listBoxSensorA.Location = new System.Drawing.Point(340, 47);
            this.listBoxSensorA.Name = "listBoxSensorA";
            this.listBoxSensorA.Size = new System.Drawing.Size(120, 459);
            this.listBoxSensorA.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(482, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sensor B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Binary Search Iterative";
            // 
            // buttonBinSearchIterB
            // 
            this.buttonBinSearchIterB.Location = new System.Drawing.Point(489, 63);
            this.buttonBinSearchIterB.Name = "buttonBinSearchIterB";
            this.buttonBinSearchIterB.Size = new System.Drawing.Size(75, 23);
            this.buttonBinSearchIterB.TabIndex = 25;
            this.buttonBinSearchIterB.Text = "Search";
            this.buttonBinSearchIterB.UseVisualStyleBackColor = true;
            // 
            // textBoxBinSearchIterB
            // 
            this.textBoxBinSearchIterB.Location = new System.Drawing.Point(489, 93);
            this.textBoxBinSearchIterB.Name = "textBoxBinSearchIterB";
            this.textBoxBinSearchIterB.ReadOnly = true;
            this.textBoxBinSearchIterB.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinSearchIterB.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Binary Search Recursive";
            // 
            // buttonBinSearchRecB
            // 
            this.buttonBinSearchRecB.Location = new System.Drawing.Point(492, 154);
            this.buttonBinSearchRecB.Name = "buttonBinSearchRecB";
            this.buttonBinSearchRecB.Size = new System.Drawing.Size(75, 23);
            this.buttonBinSearchRecB.TabIndex = 28;
            this.buttonBinSearchRecB.Text = "Search";
            this.buttonBinSearchRecB.UseVisualStyleBackColor = true;
            // 
            // textBoxBinSearchRecB
            // 
            this.textBoxBinSearchRecB.Location = new System.Drawing.Point(492, 184);
            this.textBoxBinSearchRecB.Name = "textBoxBinSearchRecB";
            this.textBoxBinSearchRecB.ReadOnly = true;
            this.textBoxBinSearchRecB.Size = new System.Drawing.Size(100, 20);
            this.textBoxBinSearchRecB.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Search";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(492, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Target";
            // 
            // textBoxSearchTargetB
            // 
            this.textBoxSearchTargetB.Location = new System.Drawing.Point(540, 231);
            this.textBoxSearchTargetB.Name = "textBoxSearchTargetB";
            this.textBoxSearchTargetB.Size = new System.Drawing.Size(49, 20);
            this.textBoxSearchTargetB.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(489, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Selection Sort";
            // 
            // buttonSelectionSortB
            // 
            this.buttonSelectionSortB.Location = new System.Drawing.Point(492, 321);
            this.buttonSelectionSortB.Name = "buttonSelectionSortB";
            this.buttonSelectionSortB.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectionSortB.TabIndex = 34;
            this.buttonSelectionSortB.Text = "Sort";
            this.buttonSelectionSortB.UseVisualStyleBackColor = true;
            // 
            // textBoxSelectionSortB
            // 
            this.textBoxSelectionSortB.Location = new System.Drawing.Point(492, 351);
            this.textBoxSelectionSortB.Name = "textBoxSelectionSortB";
            this.textBoxSelectionSortB.ReadOnly = true;
            this.textBoxSelectionSortB.Size = new System.Drawing.Size(100, 20);
            this.textBoxSelectionSortB.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(492, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Insertion Sort";
            // 
            // buttonInsertionSortB
            // 
            this.buttonInsertionSortB.Location = new System.Drawing.Point(492, 406);
            this.buttonInsertionSortB.Name = "buttonInsertionSortB";
            this.buttonInsertionSortB.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertionSortB.TabIndex = 37;
            this.buttonInsertionSortB.Text = "Sort";
            this.buttonInsertionSortB.UseVisualStyleBackColor = true;
            // 
            // textBoxInsertionSortB
            // 
            this.textBoxInsertionSortB.Location = new System.Drawing.Point(492, 437);
            this.textBoxInsertionSortB.Name = "textBoxInsertionSortB";
            this.textBoxInsertionSortB.ReadOnly = true;
            this.textBoxInsertionSortB.Size = new System.Drawing.Size(100, 20);
            this.textBoxInsertionSortB.TabIndex = 38;
            // 
            // listBoxSensorB
            // 
            this.listBoxSensorB.FormattingEnabled = true;
            this.listBoxSensorB.Location = new System.Drawing.Point(621, 47);
            this.listBoxSensorB.Name = "listBoxSensorB";
            this.listBoxSensorB.Size = new System.Drawing.Size(120, 459);
            this.listBoxSensorB.TabIndex = 39;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sensor A";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sensor B";
            // 
            // FormDataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 524);
            this.Controls.Add(this.listBoxSensorB);
            this.Controls.Add(this.textBoxInsertionSortB);
            this.Controls.Add(this.buttonInsertionSortB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxSelectionSortB);
            this.Controls.Add(this.buttonSelectionSortB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxSearchTargetB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxBinSearchRecB);
            this.Controls.Add(this.buttonBinSearchRecB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxBinSearchIterB);
            this.Controls.Add(this.buttonBinSearchIterB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxSensorA);
            this.Controls.Add(this.textBoxInsertionSortA);
            this.Controls.Add(this.buttonInsertionSortA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSelectionSortA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSelectionSortA);
            this.Controls.Add(this.textBoxSearchTargetA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBinSearchRecA);
            this.Controls.Add(this.buttonBinSearchRecA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBinSearchIterA);
            this.Controls.Add(this.buttonBinSearchIterA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewSensorData);
            this.Controls.Add(this.buttonLoadSensorData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSigma);
            this.Name = "FormDataProcessing";
            this.Text = "Data Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoadSensorData;
        private System.Windows.Forms.ListView listViewSensorData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBinSearchIterA;
        private System.Windows.Forms.TextBox textBoxBinSearchIterA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBinSearchRecA;
        private System.Windows.Forms.TextBox textBoxBinSearchRecA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSearchTargetA;
        private System.Windows.Forms.Button buttonSelectionSortA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSelectionSortA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonInsertionSortA;
        private System.Windows.Forms.TextBox textBoxInsertionSortA;
        private System.Windows.Forms.ListBox listBoxSensorA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonBinSearchIterB;
        private System.Windows.Forms.TextBox textBoxBinSearchIterB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBinSearchRecB;
        private System.Windows.Forms.TextBox textBoxBinSearchRecB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSearchTargetB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSelectionSortB;
        private System.Windows.Forms.TextBox textBoxSelectionSortB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonInsertionSortB;
        private System.Windows.Forms.TextBox textBoxInsertionSortB;
        private System.Windows.Forms.ListBox listBoxSensorB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

