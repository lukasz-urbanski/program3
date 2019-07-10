using Program3.Functions;
using System;
using System.Collections.Generic;
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
        List<Counter> counters = new List<Counter>();
        int doliczeniaMaxValue;
        int doliczeniaInterval;

        private void StartButton_Click(object sender, EventArgs e)
        {
            int intLicznik = Int32.Parse(LicznikiTextBox.Text);
            AddNewControls(intLicznik);

            List<Thread> listOfThreads = new List<Thread>();

            foreach (Counter c in counters)
            {
                threadCounter++;
                listOfThreads.Add(new Thread(() => PrintCounterOnLabel(c.MaxValue, c.Interval)) { Name = $"Licznik {threadCounter}" });
            }

            foreach (Thread t in listOfThreads)
            {
                t.Start();
            }
        }

        private List<Control> AddNewControls(int controlsCounter)
        {
            List<Control> listOfControls = new List<Control>();

            for (int i = 1; i <= controlsCounter; i++)
            {
                Label labelMaxValue = new Label();
                Controls.Add(labelMaxValue);
                labelMaxValue.Top = i * 40;
                labelMaxValue.Left = 10;
                labelMaxValue.Name = labelMaxValue.Text = "MaxValueLabel" + i;

                TextBox textBoxMaxValue = new TextBox();
                Controls.Add(textBoxMaxValue);
                textBoxMaxValue.Top = i * 40;
                textBoxMaxValue.Left = 110;
                textBoxMaxValue.Name = "MaxValueTextBox" + i;
                //textBoxMaxValue.Text = textBoxMaxValue.Name;

                Label labelInteval = new Label();
                Controls.Add(labelInteval);
                labelInteval.Top = i * 40;
                labelInteval.Left = 230;
                labelInteval.Name = labelInteval.Text = "IntervalLabel" + i;

                TextBox textBoxInterval = new TextBox();
                Controls.Add(textBoxInterval);
                textBoxInterval.Top = i * 40;
                textBoxInterval.Left = 330;
                textBoxInterval.Name = "IntervalTextBox" + i;
                //textBoxInterval.Text = textBoxInterval.Name;
            }
            return listOfControls;
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
                WynikLabel.Text = value;
            }
        }

        public void PrintCounterOnLabel(int maxvalue, int interval)
        {
            for (int i = 1; i <= maxvalue; i++)
            {
                var threadName = Thread.CurrentThread.Name;
                MthSetValue($"{threadName}: {i}");
                Thread.Sleep(interval);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            foreach (Control tb in Controls)
            {
                if ((tb is TextBox) && tb.Name.StartsWith("MaxValueTextBox"))
                {
                    doliczeniaMaxValue += Int32.Parse(tb.Text);
                }
                if ((tb is TextBox) && tb.Name.StartsWith("IntervalTextBox"))
                {
                    doliczeniaInterval += Int32.Parse(tb.Text);
                }
            }
            OutputMaxValueTextBox.Text = doliczeniaMaxValue.ToString();
            OutputIntervalTextBox.Text = doliczeniaInterval.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Control tb in Controls)
            {
                listBox1.Items.Add(tb.GetType() + " - " + tb.Text);
            }
        }
    }
}