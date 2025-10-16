using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace multithreaded_code
{
    public partial class Multithreading : Form
    {
        public Multithreading()
        {
            InitializeComponent();
        }

        //simulates activities that require a long runtime
        private void simulatingRunning(int length)         //length parameter gives the length of time to simulate running in milliseconds
        {
            Thread.Sleep(length);                          // pauses the execution of the thread it is run in by the number of milliseconds specified by the parameter
        }

        private void updateProgress(double currentVal, double maxVal)
        {
            int percentage = (int)Math.Round((currentVal / maxVal) * 100);

            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    prbProcessProgress.Value = percentage;
                });
            }

        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            double curVal = 0.0;
            double maxVal = 50.0;
            bool continueMonitoring = true;

            Thread monitoringThread = new Thread(() =>
            {
                while (continueMonitoring)
                {
                    updateProgress(curVal, maxVal);

                    Thread.Sleep(250); // Update every 250 milliseconds
                }

                updateProgress(1, 1); // Ensure progress bar is full at the end
            });

            monitoringThread.Start();

            FileIOSimulator.File[] directory = FileIOSimulator.Directory.getFiles();
            List<FileIOSimulator.File>[] threadContents = new List<FileIOSimulator.File>[4];

            for (int i = 0; i < threadContents.Length; i++)
                threadContents[i] = new List<FileIOSimulator.File>();

            int listIndex = 0;

            for (int i = 0; i < directory.Length; i++)
            {
                threadContents[listIndex].Add(directory[i]);
                listIndex++;

                if (listIndex == 4)
                    listIndex = 0;
            }

            maxVal = directory.Length;

            for (int i = 0; i < threadContents.Length; i++)
            {
                bool leftCritical = false;

                Thread thrd = new Thread(() =>
                {
                    // each thread the files list is passed to the thread
                    List<FileIOSimulator.File> thisThreadsList = threadContents[i];

                    leftCritical = true;

                    foreach (FileIOSimulator.File file in thisThreadsList)
                    {
                        file.readFile();
                        simulatingRunning(1);

                        curVal++;
                    }

                    if (curVal == maxVal)
                        continueMonitoring = false;

                });

                thrd.Start();

                while (!leftCritical)
                    Thread.Sleep(1);
            }

        }

        private void btnShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple message");
            func(15, 100);
        }

        delegate void calcPercentage(double val, double maxVal);

        calcPercentage func = delegate (double x, double max)
        {
            MessageBox.Show("The percentage value is " + (x / max) * 100.0);
            List<int> numbers = new List<int>() { 1, 5, 6, 85, 84, 55, 9, 4, 77, 2, 6, 7, 1 };
            int evens = numbers.Count(n => n % 2 == 0);
        };

        public class FileIOSimulator
        {
            public class File
            {
                private int fileReadTimeMilliseconds;

                public void readFile()
                {
                    Thread.Sleep(fileReadTimeMilliseconds);
                }

                public File(int fileReadTimeMilliseconds)
                {
                    this.fileReadTimeMilliseconds = fileReadTimeMilliseconds;
                }
            }

            public class Directory
            {
                public static File[] getFiles()
                {
                    Random rand = new Random();

                    Thread.Sleep(rand.Next(5, 50));

                    File[] rArr = new File[rand.Next(1, 200)];

                    for (int i = 0; i < rArr.Length; i++)
                        rArr[i] = new File(rand.Next(1, 80));

                    return rArr;
                }

            }
        }

    }
}
