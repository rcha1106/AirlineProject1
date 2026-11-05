<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengers
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
        Me.lstPassengers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstPassengers
        '
        Me.lstPassengers.FormattingEnabled = True
        Me.lstPassengers.ItemHeight = 16
        Me.lstPassengers.Location = New System.Drawing.Point(96, 62)
        Me.lstPassengers.Name = "lstPassengers"
        Me.lstPassengers.Size = New System.Drawing.Size(604, 340)
        Me.lstPassengers.TabIndex = 0
        '
        'frmPassengers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstPassengers)
        Me.Name = "frmPassengers"
        Me.Text = "frmPassengers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstPassengers As ListBox
End Class
