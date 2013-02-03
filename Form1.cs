using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;


namespace RicartAgrawala2
{
    public partial class Form1 : Form
    {
        Server server;
        Logic logic;
        bool isKill = false;
        string iplist;

        static Form1 instance = null;

        public Form1(String listOfIP)
        {
            InitializeComponent();
            iplist = listOfIP;
            printIPlist(iplist);

            instance = this;
        }

        public void printIPlist(String IPlist)
        {
            availableIPTextBox.Text = IPlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(IPTextBox.Text);
                server = new Server(IPTextBox.Text, int.Parse(portTextBox.Text));
                logic = new Logic(int.Parse(portTextBox.Text), IPTextBox.Text, uniqueNameTextBox.Text);
                connectButton.Enabled = false;
                printLog("connected ip: " + IPTextBox.Text);
            }
            catch (FormatException)
            {
                printLog("Wrong data format: ");
            }
        }

        private void SponsorButton_Click(object sender, EventArgs e)
        {
            if (null != logic)
            {
                try
                {
                    IPAddress ip = IPAddress.Parse(IPTextBox.Text);
                    logic.currentState = Logic.states.INITIALIZATION;
                    logic.requestSponsor(sponsorIPTextBox.Text, int.Parse(sponsorPortTextBox.Text));
                }
                catch (FormatException)
                {
                    printLog("Wrong data format");
                }              
            }
        }

        private void csReqButton_Click(object sender, EventArgs e)
        {
            if (null != logic)
            {
                logic.RequestForCS();
                printLog("Request for critical section");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (null != logic)
            {
                if (MessageBuffer.get().HasElement())
                {
                    String str = MessageBuffer.get().PopBack();
                    Message rm = Message.fromJson(str);
                    logic.OnReceive(rm);
                }
                logic.Tick();
                if (logic.canRequestCS)
                {
                    csReqButton.Enabled = true;
                }
                else
                {
                    csReqButton.Enabled = false;
                }
            }
        }

        private void setNameButton_Click(object sender, EventArgs e)
        {
            if (null != logic)
            {
                if (uniqueNameTextBox.Text == "")
                {
                    logic.itIsI.UNIQUENAME = "Maria";
                    uniqueNameTextBox.Text = "Maria";
                }
                else
                {
                    logic.itIsI.UNIQUENAME = uniqueNameTextBox.Text;
                }
                printLog("Unique name set to " + uniqueNameTextBox.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int sec = Int32.Parse(this.csTextBox.Text);
                logic.setCriticalSectTimespan(sec);
            }
            catch (FormatException)
            {
                printLog("Wrong data format: critical section timespan");
            }
        }

        public static void printLog(string str)
        {
            Console.WriteLine(str);
        }

        public static void printNodeList(string str)
        {
            instance.nodeListextBox.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (null != logic)
            {
                try
                {
                    int sec = Int32.Parse(this.csTextBox.Text);
                    logic.setNetworkDelay(sec);
                }
                catch (FormatException)
                {
                    printLog("Wrong data format: network delay");
                }
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (null != server && null != logic)
            {
                logic.sendDead();
                logic.dispose();
                logic = null;
                server.Dispose();
                server = null;
                printIPlist(iplist);
                connectButton.Enabled = true;
                nodeListextBox.Text = "";
            }
        }

        private void deadButton_Click(object sender, EventArgs e)
        {
            if (null != logic)
            {
                if (isKill)
                {
                    logic.respawn();
                    deadButton.Text = "play dead";
                    isKill = false;
                }
                else
                {
                    logic.playDead();
                    deadButton.Text = "connect";
                    isKill = true;
                }
            }          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ForceIdle_Click(object sender, EventArgs e)
        {
            if (logic != null)
                logic.currentState = Logic.states.IDLE;
        }

        

        

        

       

       

        
    }
}
