<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMilesDriven = New System.Windows.Forms.Label()
        Me.lblMpg = New System.Windows.Forms.Label()
        Me.textBoxMilesDriven = New System.Windows.Forms.TextBox()
        Me.textBoxMpg = New System.Windows.Forms.TextBox()
        Me.lblCostOfGas = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMilesDriven
        '
        Me.lblMilesDriven.AutoSize = True
        Me.lblMilesDriven.Location = New System.Drawing.Point(44, 9)
        Me.lblMilesDriven.Name = "lblMilesDriven"
        Me.lblMilesDriven.Size = New System.Drawing.Size(62, 13)
        Me.lblMilesDriven.TabIndex = 0
        Me.lblMilesDriven.Text = "miles driven"
        '
        'lblMpg
        '
        Me.lblMpg.AutoSize = True
        Me.lblMpg.Location = New System.Drawing.Point(196, 9)
        Me.lblMpg.Name = "lblMpg"
        Me.lblMpg.Size = New System.Drawing.Size(27, 13)
        Me.lblMpg.TabIndex = 1
        Me.lblMpg.Text = "mpg"
        '
        'textBoxMilesDriven
        '
        Me.textBoxMilesDriven.Location = New System.Drawing.Point(47, 25)
        Me.textBoxMilesDriven.Name = "textBoxMilesDriven"
        Me.textBoxMilesDriven.Size = New System.Drawing.Size(52, 20)
        Me.textBoxMilesDriven.TabIndex = 2
        '
        'textBoxMpg
        '
        Me.textBoxMpg.Location = New System.Drawing.Point(184, 25)
        Me.textBoxMpg.Name = "textBoxMpg"
        Me.textBoxMpg.Size = New System.Drawing.Size(52, 20)
        Me.textBoxMpg.TabIndex = 3
        '
        'lblCostOfGas
        '
        Me.lblCostOfGas.AutoSize = True
        Me.lblCostOfGas.Location = New System.Drawing.Point(65, 104)
        Me.lblCostOfGas.Name = "lblCostOfGas"
        Me.lblCostOfGas.Size = New System.Drawing.Size(62, 13)
        Me.lblCostOfGas.TabIndex = 4
        Me.lblCostOfGas.Text = "cost of gas:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(133, 104)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(103, 58)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 33)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 139)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCostOfGas)
        Me.Controls.Add(Me.textBoxMpg)
        Me.Controls.Add(Me.textBoxMilesDriven)
        Me.Controls.Add(Me.lblMpg)
        Me.Controls.Add(Me.lblMilesDriven)
        Me.Name = "Form1"
        Me.Text = "Cost of Gas Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMilesDriven As Label
    Friend WithEvents lblMpg As Label
    Friend WithEvents textBoxMilesDriven As TextBox
    Friend WithEvents textBoxMpg As TextBox
    Friend WithEvents lblCostOfGas As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
End Class
