Imports MySql.Data.MySqlClient
Module ModGlobalVariable
    'global variable

    Public serverName As String     'localhost
    Public dbUserName As String     'username
    Public dbPassword As String     'password
    Public dbName As String         'schema
    Public port As String           'port
    Public conBrgyMgtSys As New MySqlConnection 'Variable that hold for the connection string
    Public command As New MySqlCommand           'instance of mysqlCommand to execute sql commands
    Public strConnectionString As String
    Public residentPhotoPath As String      ' image location / path
    Public logoPhotoPath As String

    Public datBrgy As New DataTable
    Public sqlAdapterBrgy As New MySqlDataAdapter

    Public row As Integer
    Public action As String



    Public img As New DataGridViewImageCell
    Public colName As String


    Public officialPhotoPath As String
    Public tempID As Integer
    Public tempResidentID As Integer
    Public tempOfficialID As Integer

    Public tempFullName As String


    Public tempTransactionType As String

    Public brgyCaptain As String

    Public blotterID As String

    Public userName As String
    Public userType As String
    Public locLogInOut As Point

    Public purokID As String
    Public purokName As String

    Public empID As Integer

End Module
