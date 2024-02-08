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
        Label1 = New Label()
        txtFirstnum = New TextBox()
        Label2 = New Label()
        txtSecondnum = New TextBox()
        btnSubtract = New Button()
        Label3 = New Label()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number:"
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(114, 12)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(111, 23)
        txtFirstnum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 2
        Label2.Text = "Second Number:"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(114, 52)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(111, 23)
        txtSecondnum.TabIndex = 3
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(132, 91)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(75, 23)
        btnSubtract.TabIndex = 4
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(151, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 5
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(139, 128)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(61, 15)
        lblResult.TabIndex = 6
        lblResult.Text = "Difference"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 288)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(btnSubtract)
        Controls.Add(txtSecondnum)
        Controls.Add(Label2)
        Controls.Add(txtFirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents btnSubtract As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
End Class
