Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports System.Net

Module modBasicFunction
    Private iAnzahlMandantenSettings As Integer = 10

    Public txtShopURL As String = "" 'My.Settings.shop_abmelden_url(My.Settings.mandant_position)




    '###################################################################
    '# >> Fenstertitel anzeigen 
    '###################################################################
    Public Function setMainWindowTitle(ByVal strFormularName As String, ByVal frmForm As Form) As Boolean
        Try
            If strFormularName.Length > 0 Then
                frmForm.Text = "JTL Newsletter - " & strFormularName & " - Mandant: " & My.Settings.mandant_letzter_name & " v." & strVersionsNummer
            Else
                frmForm.Text = "JTL Newsletter - Mandant: " & My.Settings.mandant_letzter_name & " v." & strVersionsNummer
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "setMainWindowTitle", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

End Module
