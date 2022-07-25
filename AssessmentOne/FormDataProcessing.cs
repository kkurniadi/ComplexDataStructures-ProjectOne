using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;

namespace AssessmentOne
{
    public partial class FormDataProcessing : Form
    {
        public FormDataProcessing()
        {
            InitializeComponent();
        }
        LinkedList<double> sensorAData = new LinkedList<double>();
        LinkedList<double> sensorBData = new LinkedList<double>();

        public void LoadData()
        {
            ReadData rd = new ReadData();
            int maxSize = 400;
            sensorAData.Clear();
            sensorBData.Clear();
            for (int x = 0; x < maxSize; x++)
            {
                sensorAData.AddLast(rd.SensorA((double)numericUpDownMu.Value,(double)numericUpDownSigma.Value));
                sensorBData.AddLast(rd.SensorB((double)numericUpDownMu.Value,(double)numericUpDownSigma.Value));
            }
        }
        public void ShowAllSensorData()
        {
            listViewSensorData.Items.Clear();
            for (int i = 0; i < sensorAData.Count; i++)
            {
                string[] row = { sensorAData.ElementAt(i).ToString(), sensorBData.ElementAt(i).ToString() };
                ListViewItem lvi = new ListViewItem(row);
                listViewSensorData.Items.Add(lvi);
            }
        }
    }
}
