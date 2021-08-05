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



namespace OhwMon
{
    public partial class Main : Form
    {
        static string data;

        float temps;

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

            InitializeMonitor();


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
                            temps = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }

            try
            {
                port.Write(temps + "*" + "#");
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
            data = "";
        }
    }
}
