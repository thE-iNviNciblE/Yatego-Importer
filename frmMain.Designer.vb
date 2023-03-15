<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmbMandant = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.msgMaster = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenbankeinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YategoEinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvwBestelldaten = New System.Windows.Forms.ListView()
        Me.bestell_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bestellnummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bestelldatum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Firma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Titel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Anrede = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Vorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Nachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_PLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Stadt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.R_Telefon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Firma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Titel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Vorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Nachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Strasse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_PLZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Stadt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Land = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.L_Telefon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Zahlart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnYategoBestellungenEinlesen = New System.Windows.Forms.Button()
        Me.btn2JTLWaWiYatego = New System.Windows.Forms.Button()
        Me.lvwOrders_sub = New System.Windows.Forms.ListView()
        Me.colBestellnummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Artikelnummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Produktname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Variantenname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Anzahl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Einzelpreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mengenrabatt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gesamtpreis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Steuer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbMandant
        '
        Me.cmbMandant.FormattingEnabled = True
        Me.cmbMandant.Location = New System.Drawing.Point(745, 46)
        Me.cmbMandant.Name = "cmbMandant"
        Me.cmbMandant.Size = New System.Drawing.Size(289, 21)
        Me.cmbMandant.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msgMaster})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1046, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'msgMaster
        '
        Me.msgMaster.Name = "msgMaster"
        Me.msgMaster.Size = New System.Drawing.Size(120, 17)
        Me.msgMaster.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1046, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatenbankeinstellungenToolStripMenuItem, Me.YategoEinstellungenToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "&Einstellungen"
        '
        'DatenbankeinstellungenToolStripMenuItem
        '
        Me.DatenbankeinstellungenToolStripMenuItem.Name = "DatenbankeinstellungenToolStripMenuItem"
        Me.DatenbankeinstellungenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DatenbankeinstellungenToolStripMenuItem.Text = "Datenbankeinstellungen..."
        '
        'YategoEinstellungenToolStripMenuItem
        '
        Me.YategoEinstellungenToolStripMenuItem.Name = "YategoEinstellungenToolStripMenuItem"
        Me.YategoEinstellungenToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.YategoEinstellungenToolStripMenuItem.Text = "Yatego Einstellungen..."
        '
        'lvwBestelldaten
        '
        Me.lvwBestelldaten.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwBestelldaten.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.bestell_id, Me.Bestellnummer, Me.Bestelldatum, Me.EMail, Me.R_Firma, Me.R_Titel, Me.R_Anrede, Me.R_Vorname, Me.R_Nachname, Me.R_Strasse, Me.R_PLZ, Me.R_Stadt, Me.R_Land, Me.R_Telefon, Me.L_Firma, Me.L_Titel, Me.L_Vorname, Me.L_Nachname, Me.L_Strasse, Me.L_PLZ, Me.L_Stadt, Me.L_Land, Me.L_Telefon, Me.Zahlart})
        Me.lvwBestelldaten.FullRowSelect = True
        Me.lvwBestelldaten.GridLines = True
        Me.lvwBestelldaten.Location = New System.Drawing.Point(12, 91)
        Me.lvwBestelldaten.Name = "lvwBestelldaten"
        Me.lvwBestelldaten.Size = New System.Drawing.Size(1022, 323)
        Me.lvwBestelldaten.TabIndex = 3
        Me.lvwBestelldaten.UseCompatibleStateImageBehavior = False
        Me.lvwBestelldaten.View = System.Windows.Forms.View.Details
        '
        'bestell_id
        '
        Me.bestell_id.Text = "Bestellid"
        '
        'Bestellnummer
        '
        Me.Bestellnummer.Text = "Bestellnummer"
        '
        'Bestelldatum
        '
        Me.Bestelldatum.DisplayIndex = 3
        Me.Bestelldatum.Text = "Bestelldatum"
        '
        'EMail
        '
        Me.EMail.DisplayIndex = 4
        Me.EMail.Text = "E-Mail-Adresse"
        '
        'R_Firma
        '
        Me.R_Firma.DisplayIndex = 5
        Me.R_Firma.Text = "R_Firma"
        '
        'R_Titel
        '
        Me.R_Titel.DisplayIndex = 6
        Me.R_Titel.Text = "R_Titel"
        '
        'R_Anrede
        '
        Me.R_Anrede.DisplayIndex = 7
        Me.R_Anrede.Text = "R_Anrede"
        '
        'R_Vorname
        '
        Me.R_Vorname.DisplayIndex = 8
        Me.R_Vorname.Text = "R_Vorname"
        '
        'R_Nachname
        '
        Me.R_Nachname.DisplayIndex = 9
        Me.R_Nachname.Text = "R_Nachname"
        '
        'R_Strasse
        '
        Me.R_Strasse.DisplayIndex = 10
        Me.R_Strasse.Text = "R_Strasse"
        '
        'R_PLZ
        '
        Me.R_PLZ.DisplayIndex = 11
        Me.R_PLZ.Text = "R_PLZ"
        '
        'R_Stadt
        '
        Me.R_Stadt.DisplayIndex = 12
        Me.R_Stadt.Text = "R_Stadt"
        '
        'R_Land
        '
        Me.R_Land.DisplayIndex = 13
        Me.R_Land.Text = "R_Land"
        '
        'R_Telefon
        '
        Me.R_Telefon.DisplayIndex = 14
        Me.R_Telefon.Text = "R_Telefon"
        '
        'L_Firma
        '
        Me.L_Firma.DisplayIndex = 15
        Me.L_Firma.Text = "L_Firma"
        '
        'L_Titel
        '
        Me.L_Titel.DisplayIndex = 16
        Me.L_Titel.Text = "L_Titel"
        '
        'L_Vorname
        '
        Me.L_Vorname.DisplayIndex = 17
        Me.L_Vorname.Text = "L_Vorname"
        '
        'L_Nachname
        '
        Me.L_Nachname.DisplayIndex = 18
        Me.L_Nachname.Text = "L_Nachname"
        '
        'L_Strasse
        '
        Me.L_Strasse.DisplayIndex = 19
        Me.L_Strasse.Text = "L_Strasse"
        '
        'L_PLZ
        '
        Me.L_PLZ.DisplayIndex = 20
        Me.L_PLZ.Text = "L_PLZ"
        '
        'L_Stadt
        '
        Me.L_Stadt.DisplayIndex = 21
        Me.L_Stadt.Text = "L_Stadt"
        '
        'L_Land
        '
        Me.L_Land.DisplayIndex = 22
        Me.L_Land.Text = "L_Land"
        '
        'L_Telefon
        '
        Me.L_Telefon.DisplayIndex = 23
        Me.L_Telefon.Text = "L_Telefon"
        '
        'Zahlart
        '
        Me.Zahlart.DisplayIndex = 2
        Me.Zahlart.Text = "Zahlart"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 43)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(235, 43)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'btnYategoBestellungenEinlesen
        '
        Me.btnYategoBestellungenEinlesen.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnYategoBestellungenEinlesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYategoBestellungenEinlesen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYategoBestellungenEinlesen.Location = New System.Drawing.Point(448, 42)
        Me.btnYategoBestellungenEinlesen.Name = "btnYategoBestellungenEinlesen"
        Me.btnYategoBestellungenEinlesen.Size = New System.Drawing.Size(261, 23)
        Me.btnYategoBestellungenEinlesen.TabIndex = 12
        Me.btnYategoBestellungenEinlesen.Text = "Yatego Bestellungen einlesen"
        Me.btnYategoBestellungenEinlesen.UseVisualStyleBackColor = False
        '
        'btn2JTLWaWiYatego
        '
        Me.btn2JTLWaWiYatego.BackColor = System.Drawing.Color.PapayaWhip
        Me.btn2JTLWaWiYatego.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2JTLWaWiYatego.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2JTLWaWiYatego.Location = New System.Drawing.Point(773, 544)
        Me.btn2JTLWaWiYatego.Name = "btn2JTLWaWiYatego"
        Me.btn2JTLWaWiYatego.Size = New System.Drawing.Size(261, 23)
        Me.btn2JTLWaWiYatego.TabIndex = 13
        Me.btn2JTLWaWiYatego.Text = "&JTL WaWi übertragen"
        Me.btn2JTLWaWiYatego.UseVisualStyleBackColor = False
        '
        'lvwOrders_sub
        '
        Me.lvwOrders_sub.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwOrders_sub.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBestellnummer, Me.Artikelnummer, Me.Produktname, Me.Variantenname, Me.Anzahl, Me.Einzelpreis, Me.Mengenrabatt, Me.Gesamtpreis, Me.Steuer})
        Me.lvwOrders_sub.FullRowSelect = True
        Me.lvwOrders_sub.GridLines = True
        Me.lvwOrders_sub.Location = New System.Drawing.Point(12, 420)
        Me.lvwOrders_sub.Name = "lvwOrders_sub"
        Me.lvwOrders_sub.Size = New System.Drawing.Size(1022, 118)
        Me.lvwOrders_sub.TabIndex = 14
        Me.lvwOrders_sub.UseCompatibleStateImageBehavior = False
        Me.lvwOrders_sub.View = System.Windows.Forms.View.Details
        '
        'colBestellnummer
        '
        Me.colBestellnummer.Text = "Bestellnummer"
        Me.colBestellnummer.Width = 86
        '
        'Artikelnummer
        '
        Me.Artikelnummer.Text = "Artikelnummer"
        Me.Artikelnummer.Width = 92
        '
        'Produktname
        '
        Me.Produktname.Text = "Produktname"
        Me.Produktname.Width = 358
        '
        'Variantenname
        '
        Me.Variantenname.Text = "Variantenname"
        Me.Variantenname.Width = 178
        '
        'Anzahl
        '
        Me.Anzahl.Text = "Anzahl"
        '
        'Einzelpreis
        '
        Me.Einzelpreis.Text = "Einzelpreis"
        '
        'Mengenrabatt
        '
        Me.Mengenrabatt.Text = "Mengenrabatt"
        '
        'Gesamtpreis
        '
        Me.Gesamtpreis.Text = "Gesamtpreis"
        '
        'Steuer
        '
        Me.Steuer.Text = "Steuer"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 597)
        Me.Controls.Add(Me.lvwOrders_sub)
        Me.Controls.Add(Me.btn2JTLWaWiYatego)
        Me.Controls.Add(Me.btnYategoBestellungenEinlesen)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lvwBestelldaten)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.cmbMandant)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Yatego Bestellungen importieren"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMandant As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents msgMaster As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatenbankeinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvwBestelldaten As ListView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnYategoBestellungenEinlesen As Button
    Friend WithEvents btn2JTLWaWiYatego As Button
    Friend WithEvents bestell_id As ColumnHeader
    Friend WithEvents Bestellnummer As ColumnHeader
    Friend WithEvents Bestelldatum As ColumnHeader
    Friend WithEvents EMail As ColumnHeader
    Friend WithEvents R_Firma As ColumnHeader
    Friend WithEvents R_Titel As ColumnHeader
    Friend WithEvents R_Anrede As ColumnHeader
    Friend WithEvents R_Vorname As ColumnHeader
    Friend WithEvents R_Nachname As ColumnHeader
    Friend WithEvents R_Strasse As ColumnHeader
    Friend WithEvents R_PLZ As ColumnHeader
    Friend WithEvents R_Stadt As ColumnHeader
    Friend WithEvents R_Land As ColumnHeader
    Friend WithEvents R_Telefon As ColumnHeader
    Friend WithEvents L_Firma As ColumnHeader
    Friend WithEvents L_Titel As ColumnHeader
    Friend WithEvents L_Vorname As ColumnHeader
    Friend WithEvents L_Nachname As ColumnHeader
    Friend WithEvents L_Strasse As ColumnHeader
    Friend WithEvents L_PLZ As ColumnHeader
    Friend WithEvents L_Stadt As ColumnHeader
    Friend WithEvents L_Land As ColumnHeader
    Friend WithEvents L_Telefon As ColumnHeader
    Friend WithEvents Zahlart As ColumnHeader
    Friend WithEvents YategoEinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvwOrders_sub As ListView
    Friend WithEvents colBestellnummer As ColumnHeader
    Friend WithEvents Artikelnummer As ColumnHeader
    Friend WithEvents Produktname As ColumnHeader
    Friend WithEvents Variantenname As ColumnHeader
    Friend WithEvents Anzahl As ColumnHeader
    Friend WithEvents Einzelpreis As ColumnHeader
    Friend WithEvents Mengenrabatt As ColumnHeader
    Friend WithEvents Gesamtpreis As ColumnHeader
    Friend WithEvents Steuer As ColumnHeader
End Class
