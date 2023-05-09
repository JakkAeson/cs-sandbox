using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace ProcessHandling
{
    public partial class Form1 : Form
    {
        Process process;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("notepad");
            if (processList.Length > 0)
            {
                process = processList[0];
                AutomationElement.FromHandle(process.MainWindowHandle).SetFocus();
                labelStatus.Text = "Notepad already running, switching focus.";
            }
            else
            {
                process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "notepad",
                        ErrorDialog = true,
                    }
                };
                process.Start();
                labelStatus.Text = "Notepad opened.";
            }
            timer1.Enabled = true;
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                process.CloseMainWindow();
                process.Dispose();
                process = null;
                labelStatus.Text = "Notepad closed.";
            }
            catch (Exception exception)
            {
                labelStatus.Text = $"Failed to close process: \n{exception}";
            }
            timer1.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null)
            {
                try
                {
                    process.CloseMainWindow();
                    labelStatus.Text = "Program exiting, closing Notepad...";
                    if (process.WaitForExit(5000))
                    {
                        process.Dispose();
                        process = null;
                    }
                    if (process != null)
                    {
                        labelStatus.Text = "Still waiting for Notepad to close...";
                        if (process.WaitForExit(5000))
                        {
                            process.Dispose();
                            process = null;
                        }
                    }
                }
                catch { }

                if (process != null)
                {
                    labelStatus.Text = "Could not close Notepad, exiting without closing.";
                    process.Dispose();
                    labelStatus.Refresh();
                    Thread.Sleep(3000);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                process.Refresh();
                labelStatus.Text = $"ID: {process.Id}\n" +
                                   $"MainModule: {process.MainModule}\n" +
                                   $"MainWindowHandle: {process.MainWindowHandle}\n" +
                                   $"MainWindowTitle: {process.MainWindowTitle}\n" +
                                   $"ProcessName: {process.ProcessName}\n" +
                                   $"TotalProcessorTime: {process.TotalProcessorTime}\n" +
                                   $"WorkingSet: {process.WorkingSet64}";
            }
            catch (Exception exception)
            {
                labelStatus.Text = $"Could not get process information: \n{exception}";
                timer1.Stop();
            }
        }
    }
}
