using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    public class DatabaseInfo : INotifyPropertyChanged
    {

        public string DatabaseId { get; set; }
        public string DatabaseName { get; set; }

        private string _state;

        public string State
        {
            get => _state;
            internal set { _state = value; NotifyPropertyChanged("State"); }
        }

        public DateTime LastProcessed { get; set; }

        private bool _selected = false;

        public bool Selected
        {
            get => _selected;
            set { _selected = value; NotifyPropertyChanged("Selected"); }
        }

        private bool _processing;
        public bool Processing
        {
            get => _processing;
            internal set { _processing = value; NotifyPropertyChanged("Processing"); }
        }

        public DateTime? ProcessStart { get; internal set; }
        public DateTime? ProcessEnd { get; internal set; }
        public TimeSpan? ProcessDuration
        {
            get
            {
                if (ProcessStart.HasValue && ProcessEnd.HasValue)
                    return ProcessEnd.Value - ProcessStart.Value;

                return null;
            }
        }

        public bool ProcessSuccessfull { get; set; }
        public string ProcessError { get; set; }


        public string Name { get; set; }
        public string Id { get; set; }

        public string Display
        {
            get
            {
                if (Id == Name)
                    return Name;
                else return $"{Name} ({Id})";
            }
        }

        public DatabaseObjectType ObjectType { get; internal set; }

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
