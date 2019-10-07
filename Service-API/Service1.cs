using Service_API.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Service_API
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            FileWatcher fileWatcher = new FileWatcher();
        }

        protected override void OnStart(string[] args)
        {
            
        }

        protected override void OnStop()
        {
        }

        public void OnDebug()
        {
            OnStart(null);
            Debug.WriteLine("service is starting");
        }
    }
}
