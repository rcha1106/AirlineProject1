Imports System.Data.SQLite

Public Class frmAttendantFlights
    Private strConnectionString As String = "Data Source=flyme2themoon.db;Version=3;"

    Private Sub frmAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SQLiteConnection(strConnectionString)
            conn.Open()
            Dim strQuery As String = "SELECT strLastName FROM TAttendants ORDER BY strLastName;"

            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    cboAttendants.Items.Clear()
                    While reader.Read()
                        cboAttendants.Items.Add(reader("strLastName").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboAttendants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttendants.SelectedIndexChanged
        If cboAttendants.SelectedIndex <> -1 Then
            Using conn As New SQLiteConnection(strConnectionString)
                conn.Open()

                Dim strQuery As String = "SELECT F.strFlightNumber, F.dtmFlightDate, F.dtmTimeOfDeparture " &
                                         "FROM TFlights AS F " &
                                         "JOIN TAttendantFlights AS AF ON F.intFlightID = AF.intFlightID " &
                                         "JOIN TAttendants AS A ON A.intAttendantID = AF.intAttendantID " &
                                         "WHERE A.strLastName = '" & cboAttendants.SelectedItem.ToString() & "';"

                Using command As New SQLiteCommand(strQuery, conn)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        lstFlights.Items.Clear()
                        While reader.Read()
                            Dim strInfo As String = reader("strFlightNumber").ToString() & " | " &
                                                    reader("dtmFlightDate").ToString() & " | " &
                                                    reader("dtmTimeOfDeparture").ToString()
                            lstFlights.Items.Add(strInfo)
                        End While
                    End Using
                End Using
            End Using
        End If
    End Sub
End Class