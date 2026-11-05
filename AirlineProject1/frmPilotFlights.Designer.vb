<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotFlights
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
        Me.cboPilots = New System.Windows.Forms.ComboBox()
        Me.lstFlights = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboPilots
        '
        Me.cboPilots.FormattingEnabled = True
        Me.cboPilots.Location = New System.Drawing.Point(218, 75)
        Me.cboPilots.Name = "cboPilots"
        Me.cboPilots.Size = New System.Drawing.Size(271, 24)
        Me.cboPilots.TabIndex = 0
        '
        'lstFlights
        '
        Me.lstFlights.FormattingEnabled = True
        Me.lstFlights.ItemHeight = 16
        Me.lstFlights.Location = New System.Drawing.Point(218, 136)
        Me.lstFlights.Name = "lstFlights"
        Me.lstFlights.Size = New System.Drawing.Size(271, 244)
        Me.lstFlights.TabIndex = 1
        '
        'frmPilotFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstFlights)
        Me.Controls.Add(Me.cboPilots)
        Me.Name = "frmPilotFlights"
        Me.Text = "frmPilotFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboPilots As ComboBox
    Friend WithEvents lstFlights As ListBox
End Class
