<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYategoSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtYategoDomainnamen = New System.Windows.Forms.TextBox()
        Me.txtYategoPasswd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtYategoDomainnamen
        '
        Me.txtYategoDomainnamen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYategoDomainnamen.Location = New System.Drawing.Point(29, 31)
        Me.txtYategoDomainnamen.Name = "txtYategoDomainnamen"
        Me.txtYategoDomainnamen.Size = New System.Drawing.Size(356, 20)
        Me.txtYategoDomainnamen.TabIndex = 0
        '
        'txtYategoPasswd
        '
        Me.txtYategoPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYategoPasswd.Location = New System.Drawing.Point(29, 85)
        Me.txtYategoPasswd.Name = "txtYategoPasswd"
        Me.txtYategoPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtYategoPasswd.Size = New System.Drawing.Size(356, 20)
        Me.txtYategoPasswd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Yatego Domainnamen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Yatego Passwort"
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(124, 148)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(261, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'frmYategoSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 213)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYategoPasswd)
        Me.Controls.Add(Me.txtYategoDomainnamen)
        Me.Name = "frmYategoSettings"
        Me.Text = "Yatego Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtYategoDomainnamen As TextBox
    Friend WithEvents txtYategoPasswd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOK As Button
End Class
