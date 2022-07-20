using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
