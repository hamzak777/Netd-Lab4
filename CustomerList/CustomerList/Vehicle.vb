Option Strict On
Public Class Vehicle
    Private Shared vehicleCount As Integer                 ' static or shared private variable to hold the number of customers
    Private vehicleIdentificationNumber As Integer = 0     ' private variable to hold the customer's identification number
    Private vehicleMake As String = String.Empty         ' private variable to hold the customer's title
    Private vehicleModel As String = String.Empty     ' private variable to hold the customer's first name
    Private year As Integer      ' private variable to hold the customer's last name
    Private vehiclePrice As Double
    Private vehicleNew As Boolean = False              ' private variable to hold the customer's status


    ''' <summary>
    ''' Constructor - Default - creates a new vehicle object
    ''' </summary>
    Public Sub New()

        vehicleCount += 1      ' increment the shared/static variable counter by 1
        vehicleIdentificationNumber = vehicleCount ' assign the vehicle id

    End Sub

    Public Sub New(Make As String, Model As String, assemblyYear As Integer, price As Double, vehicleStatus As Boolean)

        ' call the other constructor 
        ' to set the customer count and
        ' to set the customer id
        Me.New()


        vehicleMake = Make          ' set the customer title
        vehicleModel = Model  ' set the customer first name
        year = assemblyYear    ' set the customer last name
        vehiclePrice = price
        vehicleNew = vehicleStatus       ' set the customer status

    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return vehicleCount
        End Get
    End Property

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return vehicleIdentificationNumber
        End Get
    End Property

    Public Property Make() As String
        Get
            Return vehicleMake
        End Get
        Set(ByVal value As String)
            vehicleMake = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return vehicleModel
        End Get
        Set(ByVal value As String)
            vehicleModel = value
        End Set
    End Property

    Public Property assemblyYear() As Integer
        Get
            Return year
        End Get
        Set(ByVal value As Integer)
            year = value
        End Set
    End Property

    Public Property vehicleStatus() As Boolean
        Get
            Return vehicleNew
        End Get
        Set(ByVal value As Boolean)
            vehicleNew = value
        End Set
    End Property

    Public Property price() As Double
        Get
            Return vehiclePrice
        End Get
        Set(ByVal value As Double)
            vehiclePrice = value
        End Set
    End Property

    Public Function GetCarData() As String

        Return "Car is " & vehicleMake & " " & vehicleModel & " " & year & ", " & IIf(vehicleNew = True, "Car is new", "Car is not new").ToString() & ", For $" & vehiclePrice

    End Function

End Class
