Imports System.Data.SQLite

Public Class frmPilotFlights
    Private connectionString As String = "Data Source=flyme2themoon.db;Version=3;"

    Private Sub frmPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String = "SELECT strLastName FROM TPilots ORDER BY strLastName;"

            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    cboPilots.Items.Clear()
                    While reader.Read()
                        cboPilots.Items.Add(reader("strLastName").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboPilots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPilots.SelectedIndexChanged
        If cboPilots.SelectedIndex <> -1 Then
            Using conn As New SQLiteConnection(connectionString)
                conn.Open()

                Dim strQuery As String = "SELECT F.strFlightNumber, F.dtmFlightDate, F.dtmTimeOfDeparture " &
                                         "FROM TFlights AS F " &
                                         "JOIN TPilotFlights AS PF ON F.intFlightID = PF.intFlightID " &
                                         "JOIN TPilots AS P ON P.intPilotID = PF.intPilotID " &
                                         "WHERE P.strLastName = '" & cboPilots.SelectedItem.ToString() & "';"

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