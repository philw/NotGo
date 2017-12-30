<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MoveLabel = New System.Windows.Forms.Label()
        Me.BoardDisplay = New System.Windows.Forms.PictureBox()
        CType(Me.BoardDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoveLabel
        '
        Me.MoveLabel.AutoSize = True
        Me.MoveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveLabel.Location = New System.Drawing.Point(51, 9)
        Me.MoveLabel.Name = "MoveLabel"
        Me.MoveLabel.Size = New System.Drawing.Size(325, 55)
        Me.MoveLabel.TabIndex = 0
        Me.MoveLabel.Text = "Black to move"
        '
        'BoardDisplay
        '
        Me.BoardDisplay.BackColor = System.Drawing.Color.White
        Me.BoardDisplay.Location = New System.Drawing.Point(61, 78)
        Me.BoardDisplay.Name = "BoardDisplay"
        Me.BoardDisplay.Size = New System.Drawing.Size(592, 538)
        Me.BoardDisplay.TabIndex = 1
        Me.BoardDisplay.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(851, 699)
        Me.Controls.Add(Me.BoardDisplay)
        Me.Controls.Add(Me.MoveLabel)
        Me.Name = "MainForm"
        Me.Text = "Not Go"
        CType(Me.BoardDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoveLabel As Label
    Friend WithEvents BoardDisplay As PictureBox
End Class
