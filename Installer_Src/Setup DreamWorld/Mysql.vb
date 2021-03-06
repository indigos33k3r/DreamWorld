﻿
Imports Mysql.Data.MySqlClient
Imports System.Net.Sockets

Public Class Mysql
    Implements IDisposable

    Dim MysqlConn As MySqlConnection

    Public Sub New(connStr As String)

        MysqlConn = New MySqlConnection(connStr)

    End Sub
    Public Function IsUserPresent(regionUUID As String) As Integer

        Dim UserCount = QueryString("SELECT count(RegionID) from presence where RegionID = '" + regionUUID + "'")
        If UserCount = Nothing Then Return 0
        'Debug.Print("User Count: {0}", UserCount)
        Return Convert.ToInt16(UserCount)

    End Function
    Public Function IsMySqlRunning() As String

        Dim Mysql = CheckPort("127.0.0.1", CType(Form1.MySetting.MySqlPort, Integer))
        If Mysql Then
            Dim version = QueryString("SELECT VERSION()")
            Debug.Print("MySQL version: {0}", version)
            Return version
        End If
        Return Nothing

    End Function

    <CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")>
    Public Function QueryString(SQL As String) As String
        Try
            'Debug.Print("Connecting to MySQL...")
            MysqlConn.Open()
        Catch ex As Exception
            Debug.Print("Error: " & ex.ToString())
            MysqlConn.Close()
            Return Nothing
        End Try

        Try
            Dim cmd As MySqlCommand = New MySqlCommand(SQL, MysqlConn)
            Dim v = Convert.ToString(cmd.ExecuteScalar())
            Return v
        Catch ex As Exception
            Debug.Print(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
        Return Nothing

    End Function


    Private Function CheckPort(ServerAddress As String, Port As Integer) As Boolean

        Dim iPort As Integer = Convert.ToInt16(Port)
        Dim ClientSocket As New TcpClient

        Try
            ClientSocket.Connect(ServerAddress, iPort)
        Catch ex As Exception
            Return False
        End Try

        If ClientSocket.Connected Then
            ClientSocket.Close()
            Return True
        End If
        CheckPort = False

    End Function
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                MysqlConn.Close()
                MysqlConn.Dispose()
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True

    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    <CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly")>
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
