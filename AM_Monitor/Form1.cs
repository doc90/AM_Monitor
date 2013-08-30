using System.Windows.Forms;
using System.ServiceProcess;
using System.Drawing;

namespace AM_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ServiceStatus CheckProcess(string process)
        {
            ServiceController sc = new ServiceController(process);

            ServiceStatus s = new ServiceStatus();

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    s.Color = Color.Green;
                    s.Status = "Running";
                    s.BtnStart = false;
                    s.BtnStop = true;
                    break;
                case ServiceControllerStatus.Stopped:
                    s.Color = Color.Red;
                    s.Status = "Stopped";
                    s.BtnStart = true;
                    s.BtnStop = false;
                    break;
                case ServiceControllerStatus.Paused:
                    s.Color = Color.Yellow;
                    s.Status = "Paused";
                    s.BtnStart = true;
                    s.BtnStop = false;
                    break;
                case ServiceControllerStatus.StopPending:
                    s.Color = Color.Orange;
                    s.Status = "Stopping";
                    s.BtnStart = false;
                    s.BtnStop = false;
                    break;
                case ServiceControllerStatus.StartPending:
                    s.Color = Color.YellowGreen;
                    s.Status = "Starting";
                    s.BtnStart = false;
                    s.BtnStop = false;
                    break;
                default:
                    s.Color = Color.Black;
                    s.Status = "Status Changing";
                    s.BtnStart = false;
                    s.BtnStop = false;
                    break;
            }
            return s;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            ServiceStatus Apache = CheckProcess("Apache2.4");
            ServiceStatus Mysql = CheckProcess("MySql56");

            ApacheStatus.ForeColor = Apache.Color;
            ApacheStatus.Text = Apache.Status;
            ApacheStart.Enabled = Apache.BtnStart;
            ApacheStop.Enabled = Apache.BtnStop;

            MysqlStatus.ForeColor = Mysql.Color;
            MysqlStatus.Text = Mysql.Status;
            MysqlStart.Enabled = Mysql.BtnStart;
            MysqlStop.Enabled = Mysql.BtnStop;
        }

        private void ApacheStart_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("Apache2.4");
            sc.Start();
        }

        private void MysqlStart_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("MySql56");
            sc.Start();
        }

        private void ApacheStop_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("Apache2.4");
            sc.Stop();
        }

        private void MysqlStop_Click(object sender, System.EventArgs e)
        {
            ServiceController sc = new ServiceController("MySql56");
            sc.Stop();
        }
    }
    public class ServiceStatus
    {
        private Color _color;
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private string _status;
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private bool _btnStart;
        public bool BtnStart
        {
            get { return _btnStart; }
            set { _btnStart = value; }
        }

        private bool _btnStop;
        public bool BtnStop
        {
            get { return _btnStop; }
            set { _btnStop = value; }
        }
    }
}
