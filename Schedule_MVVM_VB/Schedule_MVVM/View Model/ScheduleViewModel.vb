Imports Syncfusion.UI.Xaml.Schedule
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Schedule_MVVM
	Public Class ScheduleViewModel
		Implements INotifyPropertyChanged

		#Region "Properties"

		#Region "ScheduleAppointmentCollection"
'INSTANT VB NOTE: The field scheduleAppointmentCollection was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private scheduleAppointmentCollection_Renamed As New ObservableCollection(Of CustomAppointmentModel)()

		''' <summary>
		''' Schedule custom appointment collection
		''' </summary>
		Public Property ScheduleAppointmentCollection() As ObservableCollection(Of CustomAppointmentModel)
			Get
				Return scheduleAppointmentCollection_Renamed
			End Get
			Set(ByVal value As ObservableCollection(Of CustomAppointmentModel))
				Me.scheduleAppointmentCollection_Renamed = value
				OnPropertyChanged("ScheduleAppointmentCollection")
			End Set
		End Property

'INSTANT VB NOTE: The field scheduleResourcesCollection was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private scheduleResourcesCollection_Renamed As New ObservableCollection(Of ResourceType)()

		''' <summary>
		''' Schedule resource collection
		''' </summary>
		Public Property ScheduleResourcesCollection() As ObservableCollection(Of ResourceType)
			Get
				Return scheduleResourcesCollection_Renamed
			End Get
			Set(ByVal value As ObservableCollection(Of ResourceType))
				Me.scheduleResourcesCollection_Renamed = value
				OnPropertyChanged("ScheduleResourcesCollection")
			End Set
		End Property


		#End Region

		#End Region

		#Region "Constructor"

		''' <summary>
		''' construtor for ScheduleViewModel
		''' </summary>
		Public Sub New()
			ScheduleResourcesCollection = New ObservableCollection(Of ResourceType)() _
				From {
					New ResourceType() With {
						.ResourceCollection = New ObservableCollection(Of Object)() From {
							New Resource() With {
								.ResourceName="Jacob",
								.DisplayName="Dr. Jacob",
								.TypeName="Doctors"
							},
							New Resource() With {
								.ResourceName="Darsy",
								.DisplayName="Dr. Darsy",
								.TypeName="Doctors"
							}
						},
						.TypeName ="Doctors"
					}
				}

			Dim appointment1 As New CustomAppointmentModel() With {
				.StartTime = Date.Now,
				.EndTime = Date.Now.AddHours(2),
				.Subject = "Johny's Appointment",
				.Location = "USA"
			}

			appointment1.ResourceCollection.Add(New Resource() With {
				.ResourceName = "Jacob",
				.TypeName = "Doctors"
			})

			Dim appointment2 As New CustomAppointmentModel() With {
				.StartTime = Date.Now.AddHours(-6),
				.EndTime = Date.Now.AddHours(-4),
				.Subject = "Darsy's Appointment",
				.Location = "USA"
			}
			appointment2.ResourceCollection.Add(New Resource() With {
				.ResourceName = "Darsy",
				.TypeName = "Doctors"
			})

			'Add the custom appointments to schedule appointment collection
			scheduleAppointmentCollection_Renamed.Add(appointment1)
			scheduleAppointmentCollection_Renamed.Add(appointment2)

		End Sub

		#End Region

		#Region "PropertyChanged Event"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Public Sub OnPropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))

		End Sub

		#End Region
	End Class
End Namespace
