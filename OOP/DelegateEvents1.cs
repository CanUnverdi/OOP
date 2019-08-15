using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public delegate void Logger(string param);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SmsLogger(string message)
        {
            lblSms.Text = message;
        }

        public void XmlLogger(string message)
        {
            lblXml.Text = message;
        }

        public void MailLogger(string message)
        {
            lblMail.Text = message;
        }

        public void DbLogger(string message)
        {
            lblDb.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger(SmsLogger);
            logger += XmlLogger;
            logger += DbLogger;
            logger += MailLogger;

            logger("Hello World");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
