using Program3.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Program3.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int threadCounter;


        private void StartButton_Click(object sender, EventArgs e)
        {
            ThreadsListBox.Items.Clear();
            List<Thread> listOfThreads = new List<Thread>();
            List<int> listOfMaxValues = new List<int>();
            List<int> listOfIntervals = new List<int>();
            List<Counter> counters = new List<Counter>();
            RadioButton selectedButton = TypeOfCounterGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            List<string> textBoxesTexts = new List<string>();
            foreach (Control textBox in Controls)
            {
                if (textBox is TextBox)
                {
                    textBoxesTexts.Add(textBox.Text);
                }
            }

            bool flag = StaticMethodsForWfa.ValidateInput(textBoxesTexts, selectedButton.Text);

            if (flag)
            {
                foreach (Control textBox in Controls)
                {
                    if (textBox.Name.StartsWith("MaxValueTextBox"))
                    {
                        int intToProcess;
                        if (selectedButton.Text.Equals("tekstowy"))
                            intToProcess = StaticMethods.WordToNumberConverter(textBox.Text);
                        else
                            intToProcess = Int32.Parse(textBox.Text);
                        listOfMaxValues.Add(intToProcess);
                    }
                    if (textBox.Name.StartsWith("IntervalTextBox"))
                    {
                        int intToProcess;
                        if (selectedButton.Text.Equals("tekstowy"))
                            intToProcess = StaticMethods.WordToNumberConverter(textBox.Text);
                        else
                            intToProcess = Int32.Parse(textBox.Text);
                        listOfIntervals.Add(intToProcess * 1000);
                    }
                }

                int amountOfCounters;
                if (selectedButton.Text.Equals("tekstowy"))
                    amountOfCounters = StaticMethods.WordToNumberConverter(LicznikiTextBox.Text);
                else
                    amountOfCounters = Int32.Parse(LicznikiTextBox.Text);

                counters = StaticMethods.GetListOfCounters(amountOfCounters, listOfMaxValues, listOfIntervals);

                foreach (Counter c in counters)
                {
                    threadCounter++;
                    listOfThreads.Add(new Thread(() => PrintCounterOnListBox(c.MaxValue, c.Interval)) { Name = $"Licznik {threadCounter}" });
                }

                foreach (Thread t in listOfThreads)
                {
                    t.Start();
                }
                // TO DO:
                // Obsługa ProgressLabel
            }
        }

        private void GenerateCountersButton_Click(object sender, EventArgs e)
        {
            int controlsCounter = -1;
            RadioButton selectedButton = TypeOfCounterGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            if (selectedButton.Text.Equals("liczbowy"))
            {
                Int32.TryParse(LicznikiTextBox.Text, out controlsCounter);
            }
            if (selectedButton.Text.Equals("tekstowy"))
            {
                try
                {
                    controlsCounter = StaticMethods.WordToNumberConverter(LicznikiTextBox.Text);
                }
                catch
                {
                }
            }
            if (controlsCounter > 0)
            {
                for (int i = 1; i <= controlsCounter; i++)
                {
                    Label labelMaxValue = new Label();
                    Controls.Add(labelMaxValue);
                    labelMaxValue.Top = i * 30 + 100;
                    labelMaxValue.Left = 10;
                    labelMaxValue.Name = labelMaxValue.Text = "MaxValueLabel" + i + ":";

                    TextBox textBoxMaxValue = new TextBox();
                    Controls.Add(textBoxMaxValue);
                    textBoxMaxValue.Top = i * 30 + 100;
                    textBoxMaxValue.Left = 110;
                    textBoxMaxValue.Width = 40;
                    textBoxMaxValue.Name = "MaxValueTextBox" + i;

                    Label labelInteval = new Label();
                    Controls.Add(labelInteval);
                    labelInteval.Top = i * 30 + 100;
                    labelInteval.Left = 190;
                    labelInteval.Name = labelInteval.Text = "IntervalLabel" + i + ":";

                    TextBox textBoxInterval = new TextBox();
                    Controls.Add(textBoxInterval);
                    textBoxInterval.Top = i * 30 + 100;
                    textBoxInterval.Left = 290;
                    textBoxInterval.Width = 40;
                    textBoxInterval.Name = "IntervalTextBox" + i;
                }
            }
        }


        public delegate void delSetValue(string value);
        public void MthSetValue(string value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetValue(MthSetValue), value);
            }
            else
            {
                ThreadsListBox.Items.Add(value);
            }
        }
        public void PrintCounterOnListBox(int maxvalue, int interval)
        {
            for (int i = 1; i <= maxvalue; i++)
            {
                var threadName = Thread.CurrentThread.Name;
                MthSetValue($"{threadName}: {i}");
                Thread.Sleep(interval);
            }
        }
    }
}