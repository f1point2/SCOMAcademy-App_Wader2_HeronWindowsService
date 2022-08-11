using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace App_Wader2_HeronWindowsService
{
    public partial class AppWader2HeronService : ServiceBase
    {
        public AppWader2HeronService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            int startingEventID = 21;
            eventLogAppWader2HeronService.WriteEntry("App Wader 2 Heron Service Starting", EventLogEntryType.Information, startingEventID );
        }

        protected override void OnStop()
        {
            int stoppingEventID = 20;
            eventLogAppWader2HeronService.WriteEntry("App Wader 2 Heron Service Stopping",EventLogEntryType.Warning, stoppingEventID);
        }
    }
}
