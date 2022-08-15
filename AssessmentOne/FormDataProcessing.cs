using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        // 4.13	Add two NumericUpDown controls for Sigma and Mu. The value for Sigma must be limited with a minimum of 10 and a maximum of 20.
        // Set the default value to 10. The value for Mu must be limited with a minimum of 35 and a maximum of 75. Set the default value to 50.
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
        public bool SelectionSort(LinkedList<double> list)
        {
            int max = NumberOfNodes(list);
            for (int i = 0; i < max; i++)
            {
                int min = i;
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
            return true;
        }
        // 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList,
        // while the calling code argument is the linkedlist name.
        // The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
        public bool InsertionSort(LinkedList<double> list)
        {
            int max = NumberOfNodes(list);
            for (int i = 0; i < max - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list.ElementAt(j - 1) > list.ElementAt(j))
                    {
                        LinkedListNode<double> current = list.Find(list.ElementAt(j));
                        var temp = current.Previous.Value;
                        current.Previous.Value = current.Value;
                        current.Value = temp;
                    }
                }
            }
            return true;
        }
        // 4.9	Create a method called “BinarySearchIterative” which has the following four parameters:
        // LinkedList, SearchValue, Minimum and Maximum.
        // This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value.
        // The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        public int BinarySearchIterative(LinkedList<double> list, int value, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (value == list.ElementAt(mid))
                    return ++mid;
                else if (value < list.ElementAt(mid))
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return min;
        }
        // 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters:
        // LinkedList, SearchValue, Minimum and Maximum.
        // This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value.
        // The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list.
        // The method code must follow the pseudo code supplied below in the Appendix.
        public int BinarySearchRecursive(LinkedList<double> list, int value, int min, int max)
        {
            if (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (value == list.ElementAt(mid))
                    return mid;
                else if (value < list.ElementAt(mid))
                    return BinarySearchRecursive(list, value, min, mid - 1);
                else
                    return BinarySearchRecursive(list, value, mid + 1, max);
            }
            return min;
        }
        // 4.11	Create four button click methods that will search the LinkedList for a value entered into a textbox on the form. The four methods are:
        // 1.	Method for Sensor A and Binary Search Iterative
        // 2.	Method for Sensor A and Binary Search Recursive
        // 3.	Method for Sensor B and Binary Search Iterative
        // 4.	Method for Sensor B and Binary Search Recursive
        // The search code must check to ensure the data is sorted, then start a stopwatch before calling the search method.
        // Once the search is complete the stopwatch will stop and the number of ticks will be displayed in a read only textbox.
        // Finally, the code will call the “DisplayListboxData” method and highlight the appropriate number (or the next closest number).
        #region BinSearchButtons
        public bool IsSorted(LinkedList<double> list)
        {
            for (int i = 0; i < NumberOfNodes(list) - 1; i++)
            {
                if (list.ElementAt(i) > list.ElementAt(i + 1))
                    return false;
            }
            return true;
        }

        private void buttonBinSearchIterA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearchTargetA.Text))
            {
                if (!IsSorted(sensorAData))
                {
                    InsertionSort(sensorAData);
                    ShowAllSensorData();
                }
                Stopwatch stopwatch = Stopwatch.StartNew();
                int target = BinarySearchIterative(sensorAData, int.Parse(textBoxSearchTargetA.Text), 0, NumberOfNodes(sensorAData));
                stopwatch.Stop();
                textBoxBinSearchIterA.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorAData, listBoxSensorA);
                HighlightData(listBoxSensorA, target);
            }
            else
                MessageBox.Show("Please enter a value to search for", "Binary Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonBinSearchRecA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearchTargetA.Text))
            {
                if (!IsSorted(sensorAData))
                {
                    SelectionSort(sensorAData);
                    ShowAllSensorData();
                }
                Stopwatch stopwatch = Stopwatch.StartNew();
                int target = BinarySearchRecursive(sensorAData, int.Parse(textBoxSearchTargetA.Text), 0, NumberOfNodes(sensorAData));
                stopwatch.Stop();
                textBoxBinSearchRecA.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorAData, listBoxSensorA);
                HighlightData(listBoxSensorA, target);
            }
            else
                MessageBox.Show("Please enter a value to search for", "Binary Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonBinSearchIterB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearchTargetB.Text))
            {
                if (!IsSorted(sensorBData))
                {
                    InsertionSort(sensorBData);
                    ShowAllSensorData();
                }
                Stopwatch stopwatch = Stopwatch.StartNew();
                int target = BinarySearchIterative(sensorBData, int.Parse(textBoxSearchTargetB.Text), 0, NumberOfNodes(sensorBData));
                stopwatch.Stop();
                textBoxBinSearchIterB.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorBData, listBoxSensorB);
                HighlightData(listBoxSensorB, target);
            }
            else
                MessageBox.Show("Please enter a value to search for", "Binary Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonBinSearchRecB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSearchTargetB.Text))
            {
                if (!IsSorted(sensorBData))
                {
                    SelectionSort(sensorBData);
                    ShowAllSensorData();
                }
                Stopwatch stopwatch = Stopwatch.StartNew();
                int target = BinarySearchRecursive(sensorBData, int.Parse(textBoxSearchTargetB.Text), 0, NumberOfNodes(sensorBData));
                stopwatch.Stop();
                textBoxBinSearchRecB.Text = stopwatch.ElapsedTicks.ToString() + " ticks";
                DisplayListboxData(sensorBData, listBoxSensorB);
                HighlightData(listBoxSensorB, target);
            }
            else
                MessageBox.Show("Please enter a value to search for", "Binary Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void HighlightData(ListBox lb, int foundIndex)
        {
            int y = foundIndex;
            int z = lb.Items.Count;
            if (y > 1 && y < z - 3)
            {
                for (int x = y - 2; x < y + 3; x++)
                    lb.SetSelected(x, true);
            }
            else if (y <= 1)
            {
                for (int x = 0; x < 5; x++)
                    lb.SetSelected(x, true);
                if (y == 0)
                    MessageBox.Show("Search target is smaller than the minimum value (" + lb.Items[0].ToString() + ")", "Binary Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (y > z - 4)
            {
                for (int x = z - 5; x < z; x++)
                    lb.SetSelected(x, true);
                if (y == z)
                    MessageBox.Show("Search target is larger than the maximum value (" + lb.Items[z - 1].ToString() + ")", "Binary Search",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }
        #endregion
        // 4.12	Create four button click methods that will sort the LinkedList using the Selection and Insertion methods. The four methods are:
        // 1.	Method for Sensor A and Selection Sort
        // 2.	Method for Sensor A and Insertion Sort
        // 3.	Method for Sensor B and Selection Sort
        // 4.	Method for Sensor B and Insertion Sort
        // The button method must start a stopwatch before calling the sort method.
        // Once the sort is complete the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox.
        // Finally, the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.
        #region SortButtons
        private void buttonSelectionSortA_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (SelectionSort(sensorAData))
            {
                stopwatch.Stop();
                textBoxSelectionSortA.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                ShowAllSensorData();
                DisplayListboxData(sensorAData, listBoxSensorA);
            }
        }
        private void buttonInsertionSortA_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (InsertionSort(sensorAData))
            {
                stopwatch.Stop();
                textBoxInsertionSortA.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                ShowAllSensorData();
                DisplayListboxData(sensorAData, listBoxSensorA);
            }
        }
        private void buttonSelectionSortB_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (SelectionSort(sensorBData))
            {
                stopwatch.Stop();
                textBoxSelectionSortB.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                ShowAllSensorData();
                DisplayListboxData(sensorBData, listBoxSensorB);
            }
        }
        private void buttonInsertionSortB_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (InsertionSort(sensorBData))
            {
                stopwatch.Stop();
                textBoxInsertionSortB.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
                ShowAllSensorData();
                DisplayListboxData(sensorBData, listBoxSensorB);
            }
        }
        #endregion
        // 4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        #region TextBoxInput
        private void textBoxSearchTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNonNumericalInput(e);
        }
        private void textBoxSearchTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNonNumericalInput(e);
        }
        public void HandleNonNumericalInput(KeyPressEventArgs kp)
        {
            if (!(char.IsDigit(kp.KeyChar) || kp.KeyChar == (char)Keys.Back))
            {
                kp.Handled = true;
            }
        }
        #endregion
    }
}
