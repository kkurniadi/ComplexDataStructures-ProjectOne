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
        // 4.1	Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic namespace.
        // The data must be of type “double”; you are not permitted to use any additional classes, nodes, pointers
        // or data structures (array, list, etc) in the implementation of this application.
        // The two LinkedLists of type double are to be declared as global within the “public partial class”.
        LinkedList<double> sensorAData = new LinkedList<double>();
        LinkedList<double> sensorBData = new LinkedList<double>();

        // 4.2	Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate reference in the solution explorer.
        // Create a method called “LoadData” which will populate both LinkedLists.
        // Declare an instance of the Galileo library in the method and create the appropriate loop construct to populate the two LinkedList;
        // the data from Sensor A will populate the first LinkedList, while the data from Sensor B will populate the second LinkedList.
        // The LinkedList size will be hardcoded inside the method and must be equal to 400. The input parameters are empty, and the return type is void.
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
        // 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView.
        // Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters are empty, and the return type is void.
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
        // 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.
        // The input parameters are empty, and the return type is void.
        private void buttonLoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
        }
        // 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList.
        // The method signature will have an input parameter of type LinkedList, and the calling code argument is the linkedlist name.
        public int NumberOfNodes(LinkedList<double> ll)
        {
            return ll.Count;
        }
        // 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the appropriate ListBox.
        // The method signature will have two input parameters; a LinkedList, and the ListBox name.
        // The calling code argument is the linkedlist name and the listbox name.
        public void DisplayListboxData(LinkedList<double> ll, ListBox lb)
        {
            lb.Items.Clear();
            for (int i = 0; i < NumberOfNodes(ll); i++)
            {
                lb.Items.Add(ll.ElementAt(i).ToString());
            }
        }
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList,
        // while the calling code argument is the linkedlist name.
        // The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
        public void SelectionSort(LinkedList<double> list)
        {
            int min = 0;
            int max = NumberOfNodes(list);
            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (list.ElementAt(j) < list.ElementAt(min))
                        min = j;
                }
                LinkedListNode<double> currentMin = list.Find(list.ElementAt(min));
                LinkedListNode<double> currentI = list.Find(list.ElementAt(i));
                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
            }
        }
    }
}
