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
    public class ScheduleViewModel : INotifyPropertyChanged
    {
        #region Properties

        #region ScheduleAppointmentCollection
        private ObservableCollection<CustomAppointmentModel> scheduleAppointmentCollection = new ObservableCollection<CustomAppointmentModel>();

        /// <summary>
        /// Schedule custom appointment collection
        /// </summary>
        public ObservableCollection<CustomAppointmentModel> ScheduleAppointmentCollection
        {
            get
            {
                return scheduleAppointmentCollection;
            }
            set
            {
                this.scheduleAppointmentCollection = value;
                OnPropertyChanged("ScheduleAppointmentCollection");
            }
        }

        private ObservableCollection<ResourceType> scheduleResourcesCollection = new ObservableCollection<ResourceType>();

        /// <summary>
        /// Schedule resource collection
        /// </summary>
        public ObservableCollection<ResourceType> ScheduleResourcesCollection
        {
            get
            {
                return scheduleResourcesCollection;
            }
            set
            {
                this.scheduleResourcesCollection = value;
                OnPropertyChanged("ScheduleResourcesCollection");
            }
        }


        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// construtor for ScheduleViewModel
        /// </summary>
        public ScheduleViewModel()
        {
            ScheduleResourcesCollection = new ObservableCollection<ResourceType>()
            {
                new ResourceType(){ ResourceCollection =new ObservableCollection<object>()
                {
                    new Resource(){ResourceName="Jacob", DisplayName="Dr. Jacob" , TypeName="Doctors" },
                     new Resource(){ResourceName="Darsy", DisplayName="Dr. Darsy" , TypeName="Doctors" }
                }, TypeName ="Doctors"
                }
            };
           
            CustomAppointmentModel appointment1 = new CustomAppointmentModel()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(2),
                Subject = "Johny's Appointment",
                Location = "USA"
            };
           
            appointment1.ResourceCollection.Add(new Resource()
            {
                ResourceName = "Jacob",
                TypeName = "Doctors"
            });

            CustomAppointmentModel appointment2 = new CustomAppointmentModel()
            {
                StartTime = DateTime.Now.AddHours(-6),
                EndTime = DateTime.Now.AddHours(-4),
                Subject = "Darsy's Appointment",
                Location = "USA",                
            };
            appointment2.ResourceCollection.Add(new Resource()
            {
                ResourceName = "Darsy",
                TypeName = "Doctors"
            });

            //Add the custom appointments to schedule appointment collection
            scheduleAppointmentCollection.Add(appointment1);
            scheduleAppointmentCollection.Add(appointment2);

        }

        #endregion

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
