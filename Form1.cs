using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTT_Client_CanSat_Competition
{
    public partial class Form1 : Form
    {
        string state;
        string data;
        string bin = Application.StartupPath;

        string topic = "teams/9999";
        string username = "9999";
        string password = "teams9999";
        MqttClient client;
        bool mqtt = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            while (mqtt == true)
            {
                if (state != "LANDED")
                {
                    if (!String.IsNullOrEmpty(data))
                    {

                        Application.DoEvents();

                        try
                        {

                            var pathFile = bin + "\\FLIGHT_9999_C.csv";
                            var filename = File.Open(pathFile, FileMode.Open, (FileAccess)FileIOPermissionAccess.Read, FileShare.ReadWrite);
                            StreamReader reader = new StreamReader(filename);

                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();

                                if (!String.IsNullOrWhiteSpace(line))
                                {
                                    string[] values = line.Split(',');

                                    if (values.Length > 1)
                                    {
                                        if (values[3] == "C")
                                        {
                                            Application.DoEvents();
                                            Thread.Sleep(1000);
                                        }
                                    }
                                }
                                client.Publish(topic, Encoding.UTF8.GetBytes(line), MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, false);
                            }
                        }
                        catch (Exception ex)
                        {
                            return;
                        }
                    }
                }
                else if (state == "LANDED")
                {
                    mqtt = false;
                    client.Disconnect();
                }
            }
        }
    }
}
