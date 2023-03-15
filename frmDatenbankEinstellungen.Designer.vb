<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatenbankEinstellungen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatenbankEinstellungen))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDatenbank = New System.Windows.Forms.TextBox()
        Me.btnDBTest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPasswort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.cmbMandant = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MainStatus = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDBNew = New System.Windows.Forms.Button()
        Me.MainStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Datenbankname"
        '
        'txtDatenbank
        '
        Me.txtDatenbank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatenbank.Location = New System.Drawing.Point(17, 135)
        Me.txtDatenbank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDatenbank.Name = "txtDatenbank"
        Me.txtDatenbank.Size = New System.Drawing.Size(355, 22)
        Me.txtDatenbank.TabIndex = 11
        Me.txtDatenbank.Text = "eazybusiness"
        '
        'btnDBTest
        '
        Me.btnDBTest.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnDBTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBTest.Location = New System.Drawing.Point(17, 369)
        Me.btnDBTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDBTest.Name = "btnDBTest"
        Me.btnDBTest.Size = New System.Drawing.Size(209, 28)
        Me.btnDBTest.TabIndex = 15
        Me.btnDBTest.Text = "Verbindungstest"
        Me.btnDBTest.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Passwort"
        '
        'txtPasswort
        '
        Me.txtPasswort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswort.Location = New System.Drawing.Point(19, 273)
        Me.txtPasswort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPasswort.Name = "txtPasswort"
        Me.txtPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswort.Size = New System.Drawing.Size(355, 22)
        Me.txtPasswort.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Benutzername"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location = New System.Drawing.Point(19, 203)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(355, 22)
        Me.txtUsername.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Server + Instanz"
        '
        'txtServerName
        '
        Me.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerName.Location = New System.Drawing.Point(19, 66)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(355, 22)
        Me.txtServerName.TabIndex = 9
        '
        'cmbMandant
        '
        Me.cmbMandant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMandant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.Location = New System.Drawing.Point(20, 332)
        Me.cmbMandant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(353, 24)
        Me.cmbMandant.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 313)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Verfügbare Mandanten"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 36)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Bitte zuerst mit der Standard Datenbank 'eazybusiness' beginnen"
        '
        'MainStatus
        '
        Me.MainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster})
        Me.MainStatus.Location = New System.Drawing.Point(0, 400)
        Me.MainStatus.Name = "MainStatus"
        Me.MainStatus.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.MainStatus.Size = New System.Drawing.Size(388, 25)
        Me.MainStatus.TabIndex = 21
        '
        'msgMaster
        '
        Me.msgMaster.Name = "msgMaster"
        Me.msgMaster.Size = New System.Drawing.Size(93, 20)
        Me.msgMaster.Text = "Läd gerade..."
        '
        'btnDBNew
        '
        Me.btnDBNew.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnDBNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDBNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBNew.Location = New System.Drawing.Point(234, 368)
        Me.btnDBNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDBNew.Name = "btnDBNew"
        Me.btnDBNew.Size = New System.Drawing.Size(141, 28)
        Me.btnDBNew.TabIndex = 22
        Me.btnDBNew.Text = "&Neu"
        Me.btnDBNew.UseVisualStyleBackColor = False
        '
        'frmDatenbankEinstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 425)
        Me.Controls.Add(Me.btnDBNew)
        Me.Controls.Add(Me.MainStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbMandant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDatenbank)
        Me.Controls.Add(Me.btnDBTest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPasswort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(406, 470)
        Me.MinimumSize = New System.Drawing.Size(406, 470)
        Me.Name = "frmDatenbankEinstellungen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "JTL Translator Datenbankverbindungen"
        Me.MainStatus.ResumeLayout(False)
        Me.MainStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDatenbank As System.Windows.Forms.TextBox
    Friend WithEvents btnDBTest As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPasswort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents cmbMandant As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MainStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents msgMaster As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnDBNew As System.Windows.Forms.Button
End Class
