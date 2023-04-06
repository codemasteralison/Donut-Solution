<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbDoughnut = New System.Windows.Forms.GroupBox()
        Me.gbFinal = New System.Windows.Forms.GroupBox()
        Me.gbCoffee = New System.Windows.Forms.GroupBox()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalestax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.gbDoughnut.SuspendLayout()
        Me.gbFinal.SuspendLayout()
        Me.gbCoffee.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(52, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(523, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Our doughnuts and coffee are the best in town!"
        '
        'gbDoughnut
        '
        Me.gbDoughnut.Controls.Add(Me.radFilled)
        Me.gbDoughnut.Controls.Add(Me.radChocolate)
        Me.gbDoughnut.Controls.Add(Me.radSugar)
        Me.gbDoughnut.Controls.Add(Me.radGlazed)
        Me.gbDoughnut.Location = New System.Drawing.Point(58, 82)
        Me.gbDoughnut.Name = "gbDoughnut"
        Me.gbDoughnut.Size = New System.Drawing.Size(229, 155)
        Me.gbDoughnut.TabIndex = 1
        Me.gbDoughnut.TabStop = False
        Me.gbDoughnut.Text = "Doughnut Choices"
        '
        'gbFinal
        '
        Me.gbFinal.Controls.Add(Me.lbl3)
        Me.gbFinal.Controls.Add(Me.lbl2)
        Me.gbFinal.Controls.Add(Me.lbl1)
        Me.gbFinal.Controls.Add(Me.lblTotal)
        Me.gbFinal.Controls.Add(Me.lblSalestax)
        Me.gbFinal.Controls.Add(Me.lblSubtotal)
        Me.gbFinal.Location = New System.Drawing.Point(334, 82)
        Me.gbFinal.Name = "gbFinal"
        Me.gbFinal.Size = New System.Drawing.Size(204, 155)
        Me.gbFinal.TabIndex = 2
        Me.gbFinal.TabStop = False
        '
        'gbCoffee
        '
        Me.gbCoffee.Controls.Add(Me.radCappuccino)
        Me.gbCoffee.Controls.Add(Me.radRegular)
        Me.gbCoffee.Controls.Add(Me.radNone)
        Me.gbCoffee.Location = New System.Drawing.Point(58, 260)
        Me.gbCoffee.Name = "gbCoffee"
        Me.gbCoffee.Size = New System.Drawing.Size(229, 129)
        Me.gbCoffee.TabIndex = 3
        Me.gbCoffee.TabStop = False
        Me.gbCoffee.Text = "Coffee Choices"
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(29, 37)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(113, 20)
        Me.radGlazed.TabIndex = 5
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(29, 63)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(106, 20)
        Me.radSugar.TabIndex = 6
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(29, 89)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(131, 20)
        Me.radChocolate.TabIndex = 7
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "C&hocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(29, 115)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(103, 20)
        Me.radFilled.TabIndex = 5
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(29, 30)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(61, 20)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(29, 56)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(118, 20)
        Me.radRegular.TabIndex = 1
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(29, 82)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(142, 20)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Ca&ppuccino ($2.75)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(334, 283)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 39)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 36)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(27, 35)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(59, 16)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblSalestax
        '
        Me.lblSalestax.AutoSize = True
        Me.lblSalestax.Location = New System.Drawing.Point(27, 67)
        Me.lblSalestax.Name = "lblSalestax"
        Me.lblSalestax.Size = New System.Drawing.Size(71, 16)
        Me.lblSalestax.TabIndex = 1
        Me.lblSalestax.Text = "Sales Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(27, 98)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(69, 16)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total Due:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl1.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl1.Location = New System.Drawing.Point(105, 35)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(43, 16)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "            "
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl2.Location = New System.Drawing.Point(105, 67)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(43, 16)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "            "
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl3.Location = New System.Drawing.Point(105, 98)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(43, 16)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "            "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.gbCoffee)
        Me.Controls.Add(Me.gbFinal)
        Me.Controls.Add(Me.gbDoughnut)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.gbDoughnut.ResumeLayout(False)
        Me.gbDoughnut.PerformLayout()
        Me.gbFinal.ResumeLayout(False)
        Me.gbFinal.PerformLayout()
        Me.gbCoffee.ResumeLayout(False)
        Me.gbCoffee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents gbDoughnut As GroupBox
    Friend WithEvents gbFinal As GroupBox
    Friend WithEvents gbCoffee As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSalestax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
