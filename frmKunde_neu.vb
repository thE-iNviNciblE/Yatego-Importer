﻿Public Class frmKunde_neu
    Public lvwKunden As ListView

    Private Sub btnNeuerKunde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNeuerKunde.Click

        Dim strJTLKundenNummer As String = "-1"
        Dim strJTLNummer As String = "-1"

        '# Kunden in JTL WaWi speichern 
        If chkJTLSpeichern.Checked = True Then
            strJTLKundenNummer = frmMain.clsDB.getLftNummer("tLaufendeNummern", "WHERE cName='Kunde'")
            strJTLNummer = frmMain.clsDB.getJTLNumber(My.Settings.nr_kunden_prefix.Item(My.Settings.mandant_position), My.Settings.nr_kunden_suffix.Item(My.Settings.mandant_position), strJTLKundenNummer)
            If frmMain.clsDB.setKunde_neu(Me, "tkunde") = False Then
                MessageBox.Show("Fehler beim Kunden speichern!", "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        Else

        End If

        Dim lvwItem As New ListViewItem
        lvwItem.Text = strJTLNummer
        lvwItem.SubItems.Add(txtVorname.Text)
        lvwItem.SubItems.Add(txtNachname.Text)
        lvwItem.SubItems.Add(txtOrt.Text)        
        lvwItem.SubItems.Add(txtStraße.Text)
        lvwItem.SubItems.Add(txtPostleitzahl.Text)        
        lvwItem.SubItems.Add(cmbLand.Text)
        lvwItem.SubItems.Add(txtFirma.Text)
        lvwItem.SubItems.Add(txtTelefon.Text)
        lvwItem.SubItems.Add(txtEmail.Text)
        lvwItem.SubItems.Add(chkJTLSpeichern.Checked)
        lvwItem.SubItems.Add(frmMain.clsDB.iKID)
        lvwKunden.Items.Add(lvwItem)
        lvwKunden.Items(lvwKunden.Items.Count - 1).Selected = True
        lvwKunden.EnsureVisible(lvwKunden.Items.Count - 1)
        MessageBox.Show("Kunde wurde gespeichert", "Kunde speichern", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub frmKunde_neu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call frmMain.setMainWindowTitle("Neuen Kunden anlegen", Me)

        chkJTLSpeichern.Checked = Convert.ToBoolean(My.Settings.kunde_opt_jtl_add.Item(My.Settings.mandant_position))

        '# Kundengruppe bekommen 
        Call frmMain.clsDB.getKundenGruppe(cmbKundengruppe)

        '# Länderliste holen 
        Call frmMain.clsDB.getKundenLänderliste(cmbLand)
        cmbLand.SelectedIndex = 43
    End Sub

    Private Sub chkJTLSpeichern_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJTLSpeichern.CheckedChanged
        My.Settings.kunde_opt_jtl_add.Item(My.Settings.mandant_position) = chkJTLSpeichern.Checked
        My.Settings.Save()
    End Sub

    Private Sub cmbLand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLand.SelectedIndexChanged
        txtLand.Text = cmbLand.Text
    End Sub

    Private Sub cmbKundengruppe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKundengruppe.SelectedIndexChanged
        txtKundengruppe.Text = cmbKundengruppe.Text
    End Sub
End Class