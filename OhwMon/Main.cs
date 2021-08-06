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

            InitializeMonitor();


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

        private void InitializeMonitor()
        {
            
            try
            {
                notifyIconMain.Visible = false;
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
                port.BaudRate = 9600;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Status()
        {
            foreach(var hardware in computer.Hardware)
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
            } catch (Exception ex)
            {
                timerMain.Stop();
                MessageBox.Show(ex.Message);
                toolStripStatusLabel.Text = "Device is not responding...";
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

        private void Button_Set(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.PortName = comboBoxPorts.Text;
                    port.Open();
                    timerMain.Enabled = true;
                    toolStripStatusLabel.Text = "Sending Data...";
                    labelPortStatus.Text = "Connected.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            timerMain.Enabled = false;
            toolStripStatusLabel.Text = "Waiting for device...";
        }
    }
}
