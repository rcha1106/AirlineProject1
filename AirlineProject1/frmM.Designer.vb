<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnShowPassengers = New System.Windows.Forms.Button()
        Me.btnShowPilotFlights = New System.Windows.Forms.Button()
        Me.btnShowAttendentFlights = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowPassengers
        '
        Me.btnShowPassengers.Location = New System.Drawing.Point(205, 132)
        Me.btnShowPassengers.Name = "btnShowPassengers"
        Me.btnShowPassengers.Size = New System.Drawing.Size(106, 71)
        Me.btnShowPassengers.TabIndex = 0
        Me.btnShowPassengers.Text = "Show Passengers"
        Me.btnShowPassengers.UseVisualStyleBackColor = True
        '
        'btnShowPilotFlights
        '
        Me.btnShowPilotFlights.Location = New System.Drawing.Point(338, 132)
        Me.btnShowPilotFlights.Name = "btnShowPilotFlights"
        Me.btnShowPilotFlights.Size = New System.Drawing.Size(106, 71)
        Me.btnShowPilotFlights.TabIndex = 1
        Me.btnShowPilotFlights.Text = "Show Pilot Flights"
        Me.btnShowPilotFlights.UseVisualStyleBackColor = True
        '
        'btnShowAttendentFlights
        '
        Me.btnShowAttendentFlights.Location = New System.Drawing.Point(472, 132)
        Me.btnShowAttendentFlights.Name = "btnShowAttendentFlights"
        Me.btnShowAttendentFlights.Size = New System.Drawing.Size(106, 71)
        Me.btnShowAttendentFlights.TabIndex = 2
        Me.btnShowAttendentFlights.Text = "Show Attendent Flights"
        Me.btnShowAttendentFlights.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(338, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 71)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowAttendentFlights)
        Me.Controls.Add(Me.btnShowPilotFlights)
        Me.Controls.Add(Me.btnShowPassengers)
        Me.Name = "frmM"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShowPassengers As Button
    Friend WithEvents btnShowPilotFlights As Button
    Friend WithEvents btnShowAttendentFlights As Button
    Friend WithEvents btnExit As Button
End Class
