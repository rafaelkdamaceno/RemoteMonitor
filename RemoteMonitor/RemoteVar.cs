using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RemoteMonitor
{
    public class RemoteVar: INotifyPropertyChanged
    {

        public object Value
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Guid GUID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Description
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Path
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public RemoteMonitor RemoteMonitor
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public object Parent
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ReadValue()
        {
            throw new System.NotImplementedException();
        }

        public void WriteValue()
        {
            throw new System.NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
