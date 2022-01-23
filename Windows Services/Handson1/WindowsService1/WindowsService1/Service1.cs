
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private Timer t;
        public Service1()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            t = new Timer();
            this.t.Interval = 10000;
            this.t.Elapsed += new System.Timers.ElapsedEventHandler(this.timeTicker);
            t.Enabled = true;
            Work.WriteErrorLog("service stated :");
        }
        private void timeTicker(object sender, ElapsedEventArgs e)
        {
            Work.WriteErrorLog("TimeTicker  job Success" + "Job started at:");
        }
        protected override void OnStop()
        {
            t.Enabled = false;
            Work.WriteErrorLog(" service stopped :");

        }
    }
}

