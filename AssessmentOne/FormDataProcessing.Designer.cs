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
            this.listViewSensorData.HideSelection = false;
            this.listViewSensorData.Location = new System.Drawing.Point(12, 85);
            this.listViewSensorData.Name = "listViewSensorData";
            this.listViewSensorData.Size = new System.Drawing.Size(172, 353);
            this.listViewSensorData.TabIndex = 5;
            this.listViewSensorData.UseCompatibleStateImageBehavior = false;
            this.listViewSensorData.View = System.Windows.Forms.View.Details;
            // 
            // FormDataProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

