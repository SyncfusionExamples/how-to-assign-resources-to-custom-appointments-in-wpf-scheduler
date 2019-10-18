using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_MVVM
{
    public class CustomAppointmentModel : INotifyPropertyChanged
    {
        public CustomAppointmentModel()
        {

        }

        private DateTime starttime;

        /// <summary>
        /// Gets or sets start time 
        /// </summary>
        public DateTime StartTime
        {
            get { return starttime; }
            set
            {
                starttime = value;
                OnPropertyChanged("StartTime");
            }
        }

        private DateTime endtime;

        /// <summary>
        /// Gets or sets end time 
        /// </summary>
        public DateTime EndTime
        {
            get { return endtime; }
            set
            {
                endtime = value;
                OnPropertyChanged("EndTime");
            }
        }

        private string subject;

        /// <summary>
        /// Gets or sets subject
        /// </summary>
        public string Subject
        {
            get { return subject; }
            set
            {
                subject = value;
                OnPropertyChanged("Subject");
            }
        }

        private string location;

        /// <summary>
        /// Gets or sets location 
        /// </summary>
        public string Location
        {
            get { return location; }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        public ObservableCollection<object> resourceCollection = new ObservableCollection<object>();
        /// <summary>
        /// Gets or sets the resource collection
        /// </summary>
        public ObservableCollection<object> ResourceCollection
        {
            get { return resourceCollection; }
            set
            {
                resourceCollection = value;
                OnPropertyChanged("ResourceCollection");
            }
        }

        #region PropertyChanged Event

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));

        }

        #endregion
    }
}
