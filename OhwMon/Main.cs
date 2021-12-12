using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO.Ports;
using OpenHardwareMonitor.Hardware;
using Microsoft.Win32;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;

namespace OhwMon
{
    public partial class Main : Form
    {

        float gpuTemp, cpuTemp, cpuClock, usedRAM, totalRAM, gpuMemUsed, gpuMemTotal;
        int gpuLoad, cpuLoad, cpuFanSpeed;
        string cpuName, gpuName, jsonData;

        bool serverStarted = true;



        Computer computer = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            FanControllerEnabled = true,
            HDDEnabled = true,
            MainboardEnabled = true,
            RAMEnabled = true,
        };

        HttpServer server = new HttpServer(2418);

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

            // comboBoxInterval.SelectedItem = Properties.Settings.Default.Interval.ToString();

            StartTimer();

            UpdateControl();


            StartServer();
        }

        private void GetIPAddress()
        {
            string ipAddress = "null";
            string hostName = Dns.GetHostName();
            var host = Dns.GetHostEntry(hostName);
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                }
            }
            labelIPAddress.Text = ipAddress;
        }

        private void StartServer()
        {
            LogRemote("[INFO]\tStarting Sever...");
            server.StartHTTPListener();
            serverStarted = true;
            toolStripStatusLabel.Text = "Server Started.";
           
            UpdateControl();
            // try starting
            // LogRemote("[ERROR] Server Started...");
            // fail: enable button
            LogRemote("[OK]\tServer Started at port "+ server.ListenerPort +"...");
            SendData("Hello");
        }

        private void StopServer()
        {
            LogRemote("[INFO]\tStopping Sever...");
            if (server.StopHTTPListener())
            {
            serverStarted = false;
            toolStripStatusLabel.Text = "Server Stopped.";
            }
            
            UpdateControl();
        }

        private void SendData(string data)
        {
            server.JSONData = data;
        }

        private void LogRemote(string item)
        {
            listBoxRemoteLogs.Items.Insert(0, item);
        }

        // add separate timer for data

        private void StartTimer()
        {
            timerMain.Interval = Properties.Settings.Default.Interval;
            timerMain.Enabled = true;
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
                        }
                        else
                        {
                            theme = "Dark";
                        }
                    }
                    else
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

        private void btnClientConnenct_Click(object sender, EventArgs e)
        {
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopServer();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        private void GetStatus()
        {
            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                {
                    gpuName = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU Core"))
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core"))
                        {
                            gpuLoad = (int)sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.Name.Contains("GPU Memory Used"))
                        {
                            gpuMemUsed = sensor.Value.GetValueOrDefault() / 1000;
                        }
                        if (sensor.Name.Contains("GPU Memory Total"))
                        {
                            gpuMemTotal = sensor.Value.GetValueOrDefault() / 1000;
                        }

                    }
                }
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    cpuName = hardware.Name;
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU Package"))
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();

                        }
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("CPU Total"))
                        {
                            cpuLoad = (int)sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.SensorType == SensorType.Clock && sensor.Name.Contains("CPU Core #1"))
                        {
                            cpuClock = (float)(sensor.Value.GetValueOrDefault() / 1000);
                        }
                    }

                }

                if (hardware.HardwareType == HardwareType.RAM)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name.Contains("Used Memory"))
                        {
                            usedRAM = sensor.Value.GetValueOrDefault();
                        }
                        if (sensor.Name.Contains("Available Memory"))
                        {
                            totalRAM = usedRAM + sensor.Value.GetValueOrDefault();
                        }
                    }

                }
                if (hardware.HardwareType == HardwareType.Mainboard)
                {
                    foreach (var subhardware in hardware.SubHardware)
                    {
                        subhardware.Update();
                        foreach (var sensor in subhardware.Sensors)
                        {
                            if (sensor.Name.Equals("Fan #1"))
                            {
                                cpuFanSpeed = (int)sensor.Value.GetValueOrDefault();
                            }
                        }
                    }
                }
            }
            labelCPUName.Text = cpuName;
            labelCPUTemp.Text = cpuTemp + "°C";
            labelCPULoad.Text = cpuLoad + "%";
            labelCPUFanSpeed.Text = cpuFanSpeed + " RPM";
            labelCPUClock.Text = cpuClock.ToString("F") + " GHz";

            labelGPUName.Text = gpuName;
            labelGPUTemp.Text = gpuTemp + "°C";
            labelGPULoad.Text = gpuLoad + "%";
            labelGPUMemory.Text = gpuMemUsed.ToString("0.0") + " GB of " + gpuMemTotal.ToString("0.0") + " GB";
            labelRAMUsage.Text = usedRAM.ToString("0.0") + " GB of " + totalRAM.ToString("0.0") + " GB";
            /*   Trasmission data codes.   
             * 
             *  *   Start of Data
             *  ~cn CPU Name
             *  ~ct CPU Temp
             *  ~cl CPU Load
             *  ~gn GPU Name
             *  ~gt GPU Temp
             *  ~gu GPU Mem. Used
             *  ~go GPU Mem. Total
             *  ~ru RAM Usage
             *  ~rt RAM Total
             *  #   End of Data
             *
             */
            if (gpuName.Contains("NVIDIA"))
            {
                gpuName = gpuName.Replace("NVIDIA", "").Trim();
            }
            // make object
            jsonData = "{";
            jsonData += "\"cn\":\"" + cpuName + "\",\"ct\":" + cpuTemp + ",\"cl\":" + cpuLoad + ",\"gn\":\""
                + gpuName + "\",\"gt\":" + gpuTemp + ",\"gl\":" + gpuLoad + ",\"gu\":" + gpuMemUsed + ",\"go\":"
                + gpuMemTotal + ",\"ru\":" + usedRAM + ",\"rt\":" + totalRAM + ",\"cc\":" + cpuClock.ToString("F") + ",\"cf\":" + cpuFanSpeed;
            jsonData += "}";
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            GetStatus();
            if (serverStarted)
            {
                SendData(jsonData);
            }

            GetIPAddress();

        }

        private void UpdateControl()
        {

            if (serverStarted)
            {
                btnServerStart.Enabled = false;
                btnServerStop.Enabled = true;
                lblServerStatus.Text = "Running.";
            }
            else
            {
                btnServerStart.Enabled = true;
                btnServerStop.Enabled = false;
                lblServerStatus.Text = "Stopped.";
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            computer.Open();
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
