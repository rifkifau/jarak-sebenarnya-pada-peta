Public Class Perhitungan_Jarak
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim asal As String
        Dim tujuan As String
        Dim jarakpeta As Object
        Dim penyebutskala As Integer
        Dim jarakbenar As Object
        Dim jarakbenarmeter As Object

        asal = dari.Text
        tujuan = ke.Text
        jarakpeta = peta.Text
        penyebutskala = CInt(skala.Text)

        jarakbenar = jarakpeta * penyebutskala
        jarakbenarmeter = jarakbenar / 100
        MsgBox("Jarak sebenarnya dari " & asal & " ke " & tujuan & " adalah " & jarakbenar & " cm " & "(" & jarakbenarmeter & " m)")
    End Sub

    Private Sub Jarakfs_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jarakfs.Click


        Dim asal As String
        Dim tujuan As String
        Dim jarakpeta As Object
        Dim penyebutskala As Integer
        Dim jarakbenarskalameter As Object
        Dim jarakbenarskala As Object
        Dim faktorskala As Object

        asal = dari.Text
        tujuan = ke.Text
        jarakpeta = peta.Text
        penyebutskala = CInt(skala.Text)
        faktorskala = fakskal.Text

        jarakbenarskala = jarakpeta * penyebutskala * faktorskala
        jarakbenarskalameter = jarakbenarskala / 100

        MsgBox("Jarak sebenarnya dari " & asal & " ke " & tujuan & " adalah " & jarakbenarskala & " cm " & "(" & jarakbenarskalameter & " m)")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim asal As String
        Dim tujuan As String
        Dim jarakpeta As Object
        Dim penyebutskala As Integer
        Dim jarakbenar As Object
        Dim jarakbenarskala As Object
        Dim faktorskala As Object
        Dim selisihjarak As Object
        Dim selisihjarakmeter As Object

        asal = dari.Text
        tujuan = ke.Text
        jarakpeta = peta.Text
        penyebutskala = CInt(skala.Text)
        faktorskala = fakskal.Text

        jarakbenarskala = jarakpeta * penyebutskala * faktorskala
        jarakbenar = jarakpeta * penyebutskala
        selisihjarak = jarakbenar - jarakbenarskala
        selisihjarakmeter = selisihjarak / 100

        MsgBox("Selisih jarak sebenarnya antara perhitungan dengan dan tanpa nilai faktor skala adalah " & selisihjarak & " cm " & "(" & selisihjarakmeter & " m)")

    End Sub

End Class