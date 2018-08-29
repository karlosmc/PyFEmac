Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class clsEncriptacion
   Private Shared DES As New TripleDESCryptoServiceProvider
   Private Shared MD5 As New MD5CryptoServiceProvider

<System.Diagnostics.DebuggerNonUserCode()> _
Private Shared Function MD5Hash(ByVal value As String) As Byte()
   Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
End Function

<System.Diagnostics.DebuggerNonUserCode()> _
Public Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
   DES.Key = clsEncriptacion.MD5Hash(key)
   DES.Mode = CipherMode.ECB
   Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
   Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
End Function

<System.Diagnostics.DebuggerNonUserCode()> _
Public Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
   Dim msg As String
   Try
       DES.Key = clsEncriptacion.MD5Hash(key)
       DES.Mode = CipherMode.ECB
       Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
       Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
   Catch ex As Exception
       msg = " Invalid Key"
       Return msg
   End Try
End Function
End Class
