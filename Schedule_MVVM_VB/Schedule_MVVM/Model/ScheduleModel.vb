Imports Syncfusion.UI.Xaml.Schedule
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Schedule_MVVM
	Public Class CustomAppointmentModel
		Implements INotifyPropertyChanged

		Public Sub New()

		End Sub

'INSTANT VB NOTE: The field starttime was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private starttime_Renamed As Date

		''' <summary>
		''' Gets or sets start time 
		''' </summary>
		Public Property StartTime() As Date
			Get
				Return starttime_Renamed
			End Get
			Set(ByVal value As Date)
				starttime_Renamed = value
				OnPropertyChanged("StartTime")
			End Set
		End Property

'INSTANT VB NOTE: The field endtime was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private endtime_Renamed As Date

		''' <summary>
		''' Gets or sets end time 
		''' </summary>
		Public Property EndTime() As Date
			Get
				Return endtime_Renamed
			End Get
			Set(ByVal value As Date)
				endtime_Renamed = value
				OnPropertyChanged("EndTime")
			End Set
		End Property

'INSTANT VB NOTE: The field subject was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private subject_Renamed As String

		''' <summary>
		''' Gets or sets subject
		''' </summary>
		Public Property Subject() As String
			Get
				Return subject_Renamed
			End Get
			Set(ByVal value As String)
				subject_Renamed = value
				OnPropertyChanged("Subject")
			End Set
		End Property

'INSTANT VB NOTE: The field location was renamed since Visual Basic does not allow fields to have the same name as methods:
		Private location_Renamed As String

		''' <summary>
		''' Gets or sets location 
		''' </summary>
		Public Property Location() As String
			Get
				Return location_Renamed
			End Get
			Set(ByVal value As String)
				location_Renamed = value
				OnPropertyChanged("Location")
			End Set
		End Property

'INSTANT VB NOTE: The field resourceCollection was renamed since Visual Basic does not allow fields to have the same name as methods:
		Public resourceCollection_Renamed As New ObservableCollection(Of Object)()
		''' <summary>
		''' Gets or sets the resource collection
		''' </summary>
		Public Property ResourceCollection() As ObservableCollection(Of Object)
			Get
				Return resourceCollection_Renamed
			End Get
			Set(ByVal value As ObservableCollection(Of Object))
				resourceCollection_Renamed = value
				OnPropertyChanged("ResourceCollection")
			End Set
		End Property

		#Region "PropertyChanged Event"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Public Sub OnPropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))

		End Sub

		#End Region
	End Class
End Namespace
