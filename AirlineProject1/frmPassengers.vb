Imports System.Data.SQLite

Public Class frmPassengers
    Private connectionString As String = "Data Source=flyme2themoon.db;Version=3;"

    Private Sub frmPassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPassengers()
    End Sub

    Private Sub LoadPassengers()
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()

            Dim strQuery As String = "SELECT strFirstName, strLastName FROM TPassengers ORDER BY strLastName, strFirstName"

            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    lstPassengers.Items.Clear()

                    While reader.Read()
                        Dim strFullName As String = reader("strLastName").ToString() & ", " & reader("strFirstName").ToString()
                        lstPassengers.Items.Add(strFullName)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class