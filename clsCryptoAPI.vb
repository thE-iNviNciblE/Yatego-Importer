Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class clsCryptoAPI
    Dim DES3 As New TripleDESCryptoServiceProvider
    Private Function setByteArrayToString(bAarray() As Byte) As String
        Dim strString As String = ""
        Dim strTrennzeichen As String = "-"
        Try
            For i As Byte = 0 To bAarray.Length - 1
                If i = bAarray.Length - 1 Then
                    strTrennzeichen = ""
                End If
                strString &= bAarray(i).ToString & strTrennzeichen
            Next
            Return strString
        Catch ex As Exception
            MessageBox.Show("Fehler:" & ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function setStringToByteArray(strData As String) As Byte()
        Dim strSplit() As String = strData.Split("-")
        Dim strInit As String = ""
        Dim strTrennzeichen As String = ","
        Try

            'For i As Byte = 0 To strData.Length - 1
            '    If i = strData.Length - 1 Then
            '        strTrennzeichen = ""
            '    End If
            '    strInit &= "0" & strTrennzeichen
            'Next
            '= {strInit}

            Dim bArray() As Byte
            ReDim bArray(strSplit.Length - 1)

            For i As Byte = 0 To strSplit.Length - 1
                bArray(i) = strSplit(i)
            Next

            Return bArray
        Catch ex As Exception
            MessageBox.Show("Fehler:" & ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function setInitKeyIV() As Boolean
        Try
            My.Settings.DES3_IV = setByteArrayToString(DES3.IV)
            My.Settings.DES3_key = setByteArrayToString(DES3.Key)
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show("Fehler bei setInitKeyIV:" & ex.Message, "setInitKeyIV", MessageBoxButtons.OK)
        End Try
    End Function

    Public Function setSettingsCrypto_encrypt(strText As String) As String  'Byte()

        Try

            Dim mStream As New MemoryStream
            Dim bAry_KEY() As Byte = setStringToByteArray(My.Settings.DES3_key)
            Dim bAry_IV() As Byte = setStringToByteArray(My.Settings.DES3_IV)

            ' Create a CryptoStream using the MemoryStream 
            ' and the passed key and initialization vector (IV).
            Dim cStream As New CryptoStream(mStream, New TripleDESCryptoServiceProvider().CreateEncryptor(bAry_KEY, bAry_IV), CryptoStreamMode.Write)

            ' Convert the passed string to a byte array.
            Dim toEncrypt As Byte() = New ASCIIEncoding().GetBytes(strText)

            ' Write the byte array to the crypto stream and flush it.
            cStream.Write(toEncrypt, 0, toEncrypt.Length)
            cStream.FlushFinalBlock()

            ' Get an array of bytes from the 
            ' MemoryStream that holds the 
            ' encrypted data.
            Dim ret As Byte() = mStream.ToArray()

            ' Close the streams.
            cStream.Close()

            'Return BitConverter.ToString(ret)
            Return Convert.ToBase64String(ret)
            'Return ret
        Catch ex As CryptographicException
            MessageBox.Show("Fehler in der Crypto API:" & ex.Message)
            Return Nothing
        End Try

    End Function
    Function setSettingsCrypto_decrypt(strData As String, Optional bAry As Byte() = Nothing) As String
        Try
            Dim strDatabAry As Byte()
            Dim bAry_KEY() As Byte = setStringToByteArray(My.Settings.DES3_key)
            Dim bAry_IV() As Byte = setStringToByteArray(My.Settings.DES3_IV)
            ' Create a new MemoryStream using the passed 
            ' array of encrypted data.
            strDatabAry = System.Text.Encoding.UTF8.GetBytes(strData)
            'strDatabAry = setStringToByteArray(strData)
            Dim msDecrypt As New MemoryStream(strDatabAry)

            ' Create a CryptoStream using the MemoryStream 
            ' and the passed key and initialization vector (IV).
            Dim csDecrypt As New CryptoStream(msDecrypt, _
                                              New TripleDESCryptoServiceProvider().CreateDecryptor(bAry_KEY, bAry_IV), _
                                              CryptoStreamMode.Read)

            ' Create buffer to hold the decrypted data.
            Dim fromEncrypt(strDatabAry.Length - 1) As Byte

            ' Read the decrypted data out of the crypto stream
            ' and place it into the temporary buffer.
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length)

            'Convert the buffer into a string and return it.
            Return New ASCIIEncoding().GetString(fromEncrypt)

        Catch ex As CryptographicException
            MessageBox.Show("Fehler in der Crypto API: " & ex.Message)
            Return Nothing
        End Try

    End Function

End Class
