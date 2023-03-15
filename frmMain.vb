Imports System.Text

Public Class frmMain
    Public clsDB As New clsDatenbank
    Dim strPath As String = Application.StartupPath & "/Yatego CSV/"
    'chic-net.yatego.com
    'AIYFNZDM
    Dim strYategoPath_tmp As String = "https://www1.yatego.com/admin/modules/yatego/orders.php?user=###DOMAIN_NAME###&passwd=###PASSWD###&action=csv_order&von=###VON###&bis=###BIS###"
    Dim strYategoPath_item_tmp As String = "http://www1.yatego.com/admin/modules/yatego/orders.php?user=###DOMAIN_NAME###&passwd=###PASSWD###&action=csv_products&von=###VON###&bis=###BIS###"
    '#################################################
    '# >> setSettingsInit
    '# My.Settings.xxx String Collection initalisieren
    '#################################################
    Public Function setSettingsInit(ByVal iSize As Integer) As Integer
        Try
            Dim txtShopURL_test As String = ""
            Dim iCount_insert As Integer = 0

            If My.Settings.db_server.Count - 1 < iSize Then
                For iCount As Integer = My.Settings.db_server.Count To iSize
                    Try
                        txtShopURL_test = My.Settings.db_server.Item(My.Settings.mandant_position)
                    Catch ex As Exception
                        My.Settings.db_server.Insert(iCount, "")
                        My.Settings.db_datenbankname.Insert(iCount, "")
                        My.Settings.db_username.Insert(iCount, "")
                        My.Settings.db_passwort.Insert(iCount, "")

                        iCount_insert += 1
                    End Try
                Next

            End If
            Return iCount_insert
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInitSettings: " & ex.Message, "setInitSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    '#################################################
    '# >> setSettingsDelete
    '# My.Settings.xxx String Collection alle löschen
    '#################################################
    Public Function setSettingsDelete() As Boolean
        Dim i As Integer
        For i = 0 To My.Settings.db_server.Count - 1
            Try
                My.Settings.db_server.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_datenbankname.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_username.RemoveAt(0)
            Catch ex As Exception

            End Try
            Try
                My.Settings.db_passwort.RemoveAt(0)
            Catch ex As Exception

            End Try

            msgMaster.Text = "Es existieren noch " & My.Settings.db_server.Count & " Einstellungen"
        Next
        Return True
    End Function
    '##################################################################################
    '# >> geteazybusinessSettings()
    '# Findet die Position an der Sich die Hauptdatenbank befindet 
    '##################################################################################
    Public Function getMySettingsPositionByDatabase(strDatabaseName As String) As Integer
        Try
            Dim i As Byte
            Dim iGefunden As Integer = -1
            Dim bGefunden As Boolean = False

            '# Keine Einstellung gefunden 
            If My.Settings.db_datenbankname.Count = 0 Then
                Return -1
                Exit Function
            End If

            For i = 0 To My.Settings.db_datenbankname.Count - 1
                If My.Settings.db_datenbankname(i) = strDatabaseName Then
                    bGefunden = True
                    iGefunden = i
                    Exit For
                End If
            Next
            '# Nicht gefunden Position 0 
            If bGefunden = False Then
                iGefunden = -1
            End If

            My.Settings.Save()
            Return iGefunden
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "geteMySettingsbyDatabase()", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        End
    End Sub

    Private Sub DatenbankeinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatenbankeinstellungenToolStripMenuItem.Click
        Dim frmDatenbank As New frmDatenbankEinstellungen
        frmDatenbank.Show()
    End Sub

    '#################################################################################################
    '# >> UPDATER: Programm Updates durch Server Verteilen 
    '#################################################################################################
    Public Function getYategoData() As Boolean
        Dim strYategoPath As String = ""

        'PRÜFEN ob Datei existiert
        If Not IO.Directory.Exists(strPath) Then
            ' MessageBox.Show("Kein gültiges Verzeichnis", "Fehler beim Aktualisieren", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Return
        End If
        DateTimePicker1.CustomFormat = "dd.mm.yyyy"
        DateTimePicker2.CustomFormat = "dd.mm.yyyy"
        '    Dim strYategoPath As String = "https://www1.yatego.com/admin/modules/yatego/orders.php?user=###DOMAIN_NAME###&passwd=###PASSWD###&action=csv_order&von=###VON###&bis=###BIS###"
        strYategoPath = strYategoPath_tmp.Replace("###DOMAIN_NAME###", My.Settings.yatego_domain).Replace("###PASSWD###", My.Settings.yatego_pwd).Replace("###VON###", DateTimePicker1.Value.ToString("dd.MM.yyyy")).Replace("###BIS###", DateTimePicker2.Value.ToString("dd.MM.yyyy"))
        'Download starten 
        Try

            lvwBestelldaten.Items.Clear()

            clsUpdateDownloader = New WebFileDownloader
            'txtDownloadTo.Text.TrimEnd("\"c) 
            Application.DoEvents()
            My.Computer.Network.DownloadFile(strYategoPath, Application.StartupPath & "\Yatego CSV\bestellungen.csv", String.Empty, String.Empty, False, 100000, True)


            '# Einlesen als UTF7 dann klappt es mit german umlauts
            Dim strFileData As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Yatego CSV\bestellungen.csv", System.Text.Encoding.UTF7  )
            Dim strFileLines() As String = strFileData.Split(vbCrLf)

            ' 1 Zeile ist der CSV Header
            For i = 1 To strFileLines.Count - 1
                Dim strFileLinesRow() As String = strFileLines(i).Split(";")

                Dim lvw_item As New ListViewItem
                lvw_item.Text = strFileLinesRow(0).Replace("""", "")
                lvw_item.SubItems.Add(strFileLinesRow(1).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(2).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(3).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(4).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(5).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(6).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(7).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(8).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(9).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(10).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(11).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(12).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(13).Replace("""", ""))

                lvwBestelldaten.Items.Add(lvw_item)

            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Function
    Private Sub btnYategoBestellungenEinlesen_Click(sender As Object, e As EventArgs) Handles btnYategoBestellungenEinlesen.Click
        Call getYategoData()
    End Sub

    Private Sub YategoEinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YategoEinstellungenToolStripMenuItem.Click
        Dim frmYategoSetting As New frmYategoSettings
        frmYategoSetting.Show()
    End Sub

    Private Sub lvwBestelldaten_Click(sender As Object, e As EventArgs) Handles lvwBestelldaten.Click
        Try

            lvwBestelldaten.Enabled = False

            Dim strYategoPath As String = strYategoPath_item_tmp.Replace("###DOMAIN_NAME###", My.Settings.yatego_domain).Replace("###PASSWD###", My.Settings.yatego_pwd).Replace("###VON###", lvwBestelldaten.SelectedItems(0).SubItems(1).Text).Replace("###BIS###", lvwBestelldaten.SelectedItems(0).SubItems(1).Text)

            My.Computer.Network.DownloadFile(strYategoPath, Application.StartupPath & "\Yatego CSV\bestellungen.csv", String.Empty, String.Empty, False, 100000, True)
            lvwOrders_sub.Items.Clear()

            '# Einlesen als UTF7 dann klappt es mit german umlauts
            Dim strFileData As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Yatego CSV\bestellungen.csv", System.Text.Encoding.UTF7)
            Dim strFileLines() As String = strFileData.Split(vbCrLf)

            ' 1 Zeile ist der CSV Header
            For i = 1 To strFileLines.Count - 1
                Dim strFileLinesRow() As String = strFileLines(i).Split(";")

                Dim lvw_item As New ListViewItem
                lvw_item.Text = strFileLinesRow(0).Replace("""", "")
                lvw_item.SubItems.Add(strFileLinesRow(1).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(2).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(3).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(4).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(5).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(6).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(7).Replace("""", ""))
                lvw_item.SubItems.Add(strFileLinesRow(8).Replace("""", ""))

                lvwOrders_sub.Items.Add(lvw_item)

            Next
            lvwBestelldaten.Enabled = True

        Catch ex As Exception
            lvwBestelldaten.Enabled = True
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
