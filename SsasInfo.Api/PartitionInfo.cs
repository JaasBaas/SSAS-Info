using Microsoft.AnalysisServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    public class PartitionInfo : INotifyPropertyChanged
    {
        private bool _processing;
        private bool _selected;

        public PartitionInfo()
        {
        }

        internal DatabaseInfoNew DatabaseInternal { get; set; }
        internal Partition PartitionInternal { get; set; }

        public string PartitionId { get { return PartitionInternal.ID; } }
        public string PartitionName { get { return PartitionInternal.Name; } }
        public string Display
        {
            get
            {
                if (PartitionId == PartitionName)
                    return PartitionId;
                else
                    return $"{PartitionName} ({PartitionId})";
            }
        }

        public string CubeId { get { return PartitionInternal.ParentCube.ID; } }
        public string CubeName { get { return PartitionInternal.ParentCube.Name; } }
        public string CubeDisplay
        {
            get
            {
                if (CubeId == CubeName)
                    return CubeId;
                else
                    return $"{CubeName} ({CubeId})";
            }
        }

        public DateTime LastProcessed { get { return PartitionInternal.LastProcessed; } }
        public string State { get { return PartitionInternal.State.ToString(); } }

        public bool Selected { get => _selected; set { _selected = value; NotifyPropertyChanged("Selected"); } }
        public bool Processing { get => _processing; set { _processing = value; NotifyPropertyChanged("Processing"); } }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public bool ProcessSuccessfull { get; set; }
        public string ProcessError { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        internal void NotifyProcessPropertiesChanged()
        {
            NotifyPropertyChanged("ProcessSuccessfull");
            NotifyPropertyChanged("ProcessError");
            NotifyPropertyChanged("State");
            NotifyPropertyChanged("LastProcessed");
        }

        public bool Disabled
        {
            get
            {
                var b = (QueryBinding)PartitionInternal.Source;
                return b.QueryDefinition.Contains("1 = 0");
            }
        }

        public string QueryDefinition
        {
            get
            {
                var b = (QueryBinding)this.PartitionInternal.Source;
                return b == null ? "" : b.QueryDefinition;
            }
            set
            {
                var b = (QueryBinding)this.PartitionInternal.Source;
                if (b != null)
                {
                    b.QueryDefinition = value;
                    this.PartitionInternal.Update();
                }
            }
        }


        public string MeasureGroupLong
        {
            get
            {
                if (this.PartitionInternal.Parent.ID == this.PartitionInternal.Parent.Name)
                    return this.PartitionInternal.Parent.Name;
                else
                    return $"{this.PartitionInternal.Parent.Name} ({this.PartitionInternal.Parent.ID})";
            }
        }


        public void Process()
        {
            this.Process(ProcessType.ProcessDefault);
        }
        public void Process(ProcessType processType)
        {
            try
            {
                var ptid = (int)processType;
                var mspt = (Microsoft.AnalysisServices.ProcessType)ptid;

                this.Processing = true;
                this.ProcessStart = DateTime.Now;
                this.PartitionInternal.Process(mspt);
                this.ProcessEnd = DateTime.Now;
                this.Processing = false;
                this.ProcessSuccessfull = true;

                this.Selected = false;
            }
            catch (Exception ex)
            {
                this.ProcessEnd = DateTime.Now;
                this.Processing = false;
                this.ProcessSuccessfull = false;
                this.ProcessError = ex.ToString();
            }

            this.PartitionInternal.Refresh();
            this.NotifyProcessPropertiesChanged();
        }
    }
}
