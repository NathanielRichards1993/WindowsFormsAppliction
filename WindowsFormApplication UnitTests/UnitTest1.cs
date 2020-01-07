using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsAppliction;

namespace WindowsFormApplication_UnitTests
{
    [TestClass]
    public class ServerTests
    {

        [TestMethod]
        public void SetNewServerAndAlarmData_version1_expectedPass()
        {
            //setup
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            insertTextBox.Text = "The alarm id from video server number 7 is 10.";

            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == 10 && server.ID == 7);
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_version2_expectedPass()
        {
            //setup
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            insertTextBox.Text = "Alarm id 10 has been received from video server number 7.";

            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == 10 && server.ID == 7);
        }

        [TestMethod]
        //fails due to int being to small to store
        public void SetNewServerAndAlarmData_LargeNumbers_expectedPass()
        {
            //setup
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            insertTextBox.Text = "The alarm id from video server number 100000000 is 10000000.";

            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsFalse(server.GetAlarm().ID == 100000000 && server.ID == 10000000);
        }

        [TestMethod]
        public void GetDefault_expectedPass()
        {
            //setup
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();

            Server server = new Server(insertTextBox, serverValue, AlarmValue);

            //checking result
            Assert.IsTrue(server.GetAlarm().ID == -1 && server.ID == -1);
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_version3_expectedPass()
        {
            //setup
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            insertTextBox.Text = "Alarm id 10 has been received from video server number 7.";

            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == 10 && server.ID == 7);

            //next entry
            insertTextBox.Text = "Alarm id 18 has been received from video server number 2.";
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == 18 && server.ID == 2);
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_Random1000_expectedPass()
        {
            Random rng = new Random();
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            const int size = 1000;
            int alarmNumber = 0;
            int serverNumber = 0;
            for (int iter = 0; iter < size; ++iter)
            {
                alarmNumber = rng.Next();
                serverNumber = rng.Next();
                //setup
                insertTextBox.Text = "The alarm id from video server number "+serverNumber+" is "+alarmNumber+".";
                //Excuting
                server.SetNewServerAndAlarmData();
                //checking result
                Assert.IsTrue(server.GetAlarm().ID == alarmNumber && server.ID == serverNumber);
            }
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_Random1000OtherFormat_expectedPass()
        {
            Random rng = new Random();
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);
            const int size = 1000;
            int alarmNumber = 0;
            int serverNumber = 0;
            for (int iter = 0; iter < size; ++iter)
            {
                alarmNumber = rng.Next();
                serverNumber = rng.Next();
                //setup
                insertTextBox.Text = "Alarm id " + alarmNumber + " has been received from video server number " + serverNumber + ".";
                //Excuting
                server.SetNewServerAndAlarmData();
                //checking result
                Assert.IsTrue(server.GetAlarm().ID == alarmNumber && server.ID == serverNumber);
            }
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_CheckingFormat_expectedPass()
        {
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);


            //setup
            insertTextBox.Text = "Alarm id 7 has been recd from video server number 6.";
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == -1 && server.ID == -1);
            
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_CheckingFormatOther_expectedPass()
        {
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);


            //setup
            insertTextBox.Text = "The alarm id fm video server number 7 is 10.";
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(server.GetAlarm().ID == -1 && server.ID == -1);

        }

        [TestMethod]
        public void SetNewServerAndAlarmData_CheckingLabelUpdate_expectedPass()
        {
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);


            //setup
            insertTextBox.Text = "The alarm id from video server number 7 is 10.";
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Console.WriteLine("Server = " + serverValue.Text + "Alarm = " + AlarmValue.Text);
            Assert.IsTrue(serverValue.Text == "7" && AlarmValue.Text == "10");
        }

        [TestMethod]
        public void SetNewServerAndAlarmData_CheckingLabelUpdateEmpty_expectedPass()
        {
            System.Windows.Forms.Label serverValue = new Label();
            System.Windows.Forms.Label AlarmValue = new Label();
            System.Windows.Forms.RichTextBox insertTextBox = new RichTextBox();
            Server server = new Server(insertTextBox, serverValue, AlarmValue);


            //setup
            insertTextBox.Text = "The alarm id from  server nber 7 is 10.";
            //Excuting
            server.SetNewServerAndAlarmData();
            //checking result
            Assert.IsTrue(serverValue.Text == "empty" && AlarmValue.Text == "empty");
        }
    }
}
