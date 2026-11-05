<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantFlights
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
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.lstFlights = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(180, 114)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(251, 24)
        Me.cboAttendants.TabIndex = 0
        '
        'lstFlights
        '
        Me.lstFlights.FormattingEnabled = True
        Me.lstFlights.ItemHeight = 16
        Me.lstFlights.Location = New System.Drawing.Point(180, 144)
        Me.lstFlights.Name = "lstFlights"
        Me.lstFlights.Size = New System.Drawing.Size(251, 276)
        Me.lstFlights.TabIndex = 1
        '
        'frmAttendantFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstFlights)
        Me.Controls.Add(Me.cboAttendants)
        Me.Name = "frmAttendantFlights"
        Me.Text = "frmAttendantFlights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboAttendants As ComboBox
    Friend WithEvents lstFlights As ListBox
End Class
