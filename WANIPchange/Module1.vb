Imports System.Net
Module Module1
    Function GetIP() As String
        Dim IP As New WebClient
        Return IP.DownloadString("http://icanhazip.com/")
    End Function
    Sub Main()
        Dim fájlba As New System.IO.StreamWriter("C:\ddupdate")
        fájlba.WriteLine("server robolution.eu" & vbNewLine & "zone poligon-it.hu" & vbNewLine & "update delete polisys.poligon-it.hu. A" & vbNewLine & "update add polisys.poligon-it.hu. 300 A " & GetIP() & "show" & vbNewLine & "send")
        fájlba.Close()
        Process.Start("C:\ipupdate.bat")
    End Sub
End Module
