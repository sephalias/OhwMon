using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using OpenHardwareMonitor.Hardware;
using Microsoft.Win32;

namespace OhwMon
{
    public partial class Main : Form
    {

        float gpuTemp, cpuTemp;

        string currentPort;


        private SerialPort port = new SerialPort();

        Computer computer = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            FanControllerEnabled = true,
            HDDEnabled = true,
            MainboardEnabled = true,
            RAMEnabled = true,
        };


        public Main()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.statistics;

            string theme = GetSystemTheme();

            if (theme == "Light")
            {
                notifyIconMain.Icon = Properties.Resources.outline_assessment_black_32;
            }
             else
            {
                notifyIconMain.Icon = Properties.Resources.outline_assessment_white_32;
            }

            notifyIconMain.Visible = false;
            buttonClear.Enabled = false;
            buttonSetPort.Enabled = false;

            comboBoxInterval.SelectedItem = Properties.Settings.Default.Interval.ToString();

            toolStripStatusLabel.Text = "Getting Ports...";

            GetPorts();

            toolStripStatusLabel.Text = "Getting Ports... Done.";
        }

        private string GetSystemTheme()
        {
            String registryPath = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
            String theme;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath))
                {

                    int themeRegistryValue = (int)Registry.GetValue(registryPath, "SystemUsesLightTheme", null);

                    #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    if (themeRegistryValue != null)
                    #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
                    {
                        if (themeRegistryValue == 1)
                        {
                            theme = "Light";
                        } else
                        {
                            theme = "Dark";
                        }
                    } else
                    {
                        theme = "None";
                    }
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                theme = "None";
            }
            return theme;
        }
        
        
        private void GetPorts()
        {
            try
            {
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.DataBits = 8;
                port.Handshake = Handshake.None;
                port.RtsEnable = true;
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    comboBoxPorts.Items.Add(port);
                }
                if (comboBoxPorts.Items.Count > 0)
                {
                    comboBoxPorts.SelectedIndex = 0;
                    currentPort = comboBoxPorts.SelectedItem.ToString();
                } 
                else
                {
                    currentPort = "";
                }
                port.BaudRate = 9600;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedIndex >= 0)
            {
                if (currentPort != comboBoxPorts.SelectedItem.ToString())
                {
                    buttonSetPort.Enabled = true;
                }
                
            }
        }

        private void ComboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBoxInterval.SelectedItem) != Properties.Settings.Default.Interval)
            {
                buttonSetInterval.Enabled = true;
            } 
            else
            {
                buttonSetInterval.Enabled = false;
            }
        }

        private void Button_SetInterval(object sender, EventArgs e)
        {
            Properties.Settings.Default.Interval = Convert.ToInt32(comboBoxInterval.SelectedItem);
            Properties.Settings.Default.Save();
            buttonSetInterval.Enabled = false;

            toolStripStatusLabel.Text = "Restarting...";
            
            if (labelPortStatus.Text == "Connected.")
            {
                buttonClear.PerformClick();
                buttonSetPort.PerformClick();
            }
            
            toolStripStatusLabel.Text = "Interval Changed.";
        }

        private void Button_Refresh(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Refreshing Ports List...";
            comboBoxPorts.SelectedItem = null;
            comboBoxPorts.Items.Clear();
            GetPorts();
            toolStripStatusLabel.Text = "Refreshing Ports List... Done.";
        }


        private void Button_Set(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.PortName = comboBoxPorts.Text;
                    port.Open();
                    timerMain.Interval = Properties.Settings.Default.Interval;
                    timerMain.Enabled = true;
                    toolStripStatusLabel.Text = "Sending Data...";
                    labelPortStatus.Text = "Connected.";
                    labelPortStatus.BackColor = Color.Green;
                    buttonSetPort.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (labelPortStatus.Text == "Connected.")
            {
                buttonClear.Enabled = true;
                currentPort = comboBoxPorts.SelectedItem.ToString();
            }
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            try
            {
                port.Write("DIS*");
                port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            labelPortStatus.Text = "Disconnected.";
            labelPortStatus.BackColor = Color.IndianRed;
            timerMain.Enabled = false;
            toolStripStatusLabel.Text = "Waiting for device...";
            buttonClear.Enabled = false;
            buttonSetPort.Enabled = true;
        }

        private void Status()
        {
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();

                        }

                }
            }

            try
            {
                port.Write(gpuTemp + "*" + cpuTemp + "#");
                System.Console.WriteLine(gpuTemp + "*" + cpuTemp + "#");
            }
            catch (Exception ex)
            {
                timerMain.Stop();
                MessageBox.Show(ex.Message);
                labelPortStatus.Text = "Disconnected";
                labelPortStatus.BackColor = Color.IndianRed;
                buttonClear.Enabled = false;
                buttonRefesh.PerformClick();
                toolStripStatusLabel.Text = "Device disconnected or not responding...";
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            computer.Open();
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            Status();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIconMain.Visible = true;
                try
                {
                    notifyIconMain.ShowBalloonTip(500, "OhwMon", toolStripStatusLabel.Text, ToolTipIcon.Info);
                    notifyIconMain.Text = toolStripStatusLabel.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            }
        }

        private void NotificationIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIconMain.Visible = false;
        }
    }
}
