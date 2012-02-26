using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.IO;

namespace COMPortTerminal
{
    class RequestThread
    {
        ListBox l;
        public RequestThread (ListBox l){
            this.l = l;
        }
        public void Poll()
        {
            do
            {
                System.Timers.Timer t = new System.Timers.Timer();
                t.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                t.Interval = 30000;
                t.Enabled = true;
                t.Start();
            }
            while (null == null);
            
        }
        void OnTimedEvent(object sender, EventArgs e)
        {
            ((System.Timers.Timer)sender).Dispose();
            populateReqs();
            l.Refresh();
        }

        public void populateReqs()
        {
            List<string> reqs = File.ReadAllLines("C:\\Users\\Loki\\DimSumManager\\Data\\Requests.txt").ToList();
            COMPortTerminal.RequestList reqlist = new COMPortTerminal.RequestList(reqs);
            l.DataSource = reqlist.toStringList();
            l.Refresh();
        }
    }
}
