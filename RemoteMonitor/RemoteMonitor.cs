using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteMonitor
{
    public class RemoteMonitor: List<RemoteVar>, IList<RemoteVar>
    {
        public IMonitorGateway MonitorGateway
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public uint Interval
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ReadValue(RemoteVar remoteVar)
        {
            throw new System.NotImplementedException();
        }

        public void WriteValue(RemoteVar remoteVar)
        {
            throw new System.NotImplementedException();
        }

        public void ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public void WriteAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
