<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTreadmillSpeed = New Label()
        GroupBox1 = New GroupBox()
        lstOutput = New ListBox()
        btnExit = New Button()
        btnData = New Button()
        comboSpeed = New ComboBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTreadmillSpeed
        ' 
        lblTreadmillSpeed.AutoSize = True
        lblTreadmillSpeed.Location = New Point(50, 39)
        lblTreadmillSpeed.Name = "lblTreadmillSpeed"
        lblTreadmillSpeed.Size = New Size(115, 20)
        lblTreadmillSpeed.TabIndex = 0
        lblTreadmillSpeed.Text = "Treadmill speed"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lstOutput)
        GroupBox1.Location = New Point(65, 114)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 183)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Calories Burned Information"
        ' 
        ' lstOutput
        ' 
        lstOutput.FormattingEnabled = True
        lstOutput.ItemHeight = 20
        lstOutput.Location = New Point(10, 38)
        lstOutput.Name = "lstOutput"
        lstOutput.Size = New Size(336, 144)
        lstOutput.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(287, 365)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 3
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnData
        ' 
        btnData.Location = New Point(87, 365)
        btnData.Name = "btnData"
        btnData.Size = New Size(135, 29)
        btnData.TabIndex = 4
        btnData.Text = "Display Data"
        btnData.UseVisualStyleBackColor = True
        ' 
        ' comboSpeed
        ' 
        comboSpeed.FormattingEnabled = True
        comboSpeed.Items.AddRange(New Object() {"Low", "Medium", "High"})
        comboSpeed.Location = New Point(214, 36)
        comboSpeed.Name = "comboSpeed"
        comboSpeed.Size = New Size(151, 28)
        comboSpeed.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(608, 447)
        Controls.Add(comboSpeed)
        Controls.Add(btnData)
        Controls.Add(btnExit)
        Controls.Add(GroupBox1)
        Controls.Add(lblTreadmillSpeed)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTreadmillSpeed As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnData As Button
    Friend WithEvents comboSpeed As ComboBox
    Friend WithEvents lstOutput As ListBox
End Class
