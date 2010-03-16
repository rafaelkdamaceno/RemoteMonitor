using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteMonitor
{
    public interface IMonitorGateway
    {
        void ReadValue(RemoteVar var);

        void WriteValue(RemoteVar var);

        void Connect();
    }
}
