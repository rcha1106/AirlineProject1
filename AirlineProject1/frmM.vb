Public Class frmM
    Private Sub btnShowPassengers_Click(sender As Object, e As EventArgs) Handles btnShowPassengers.Click
        Dim frmPassengers As New frmPassengers
        frmPassengers.ShowDialog()
    End Sub

    Private Sub btnShowPilotFlights_Click(sender As Object, e As EventArgs) Handles btnShowPilotFlights.Click
        Dim frmPilotFlights As New frmPilotFlights
        frmPilotFlights.ShowDialog()
    End Sub

    Private Sub btnShowAttendentFlights_Click(sender As Object, e As EventArgs) Handles btnShowAttendentFlights.Click
        Dim frmAttendentFlights As New frmAttendantFlights
        frmAttendantFlights.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
