Public Class Form1

    Private joc As C3EnRatlla
    Private labels As List(Of System.Windows.Forms.Label)

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Inicialitzacions()
        pnlLyo.Enabled = True
    End Sub

    Private Sub Inicialitzacions()
        joc = New C3EnRatlla()

        labels = New List(Of System.Windows.Forms.Label) From {Label0, Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8}

        For Each lbl In labels
            lbl.Text = ""
        Next
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label0.Click, Label1.Click, Label2.Click,
                                                                Label3.Click, Label4.Click, Label5.Click,
                                                                Label6.Click, Label7.Click, Label8.Click

        Dim lbl As System.Windows.Forms.Label = CType(sender, System.Windows.Forms.Label)
        Dim index As Integer = labels.IndexOf(lbl)

        Dim fila As Integer = index \ 3
        Dim col As Integer = index Mod 3

        ' Fer jugada
        If joc.FerJugada(fila, col) Then
            lbl.Text = If(joc.JugadorActual = "X"c, "O", "X")
        Else
            MessageBox.Show("Casella ocupada!")
            Exit Sub
        End If

        ' Comprovar final partida
        Dim estat = joc.EsFinalPartida()

        Select Case estat
            Case C3EnRatlla.EstatPartida.GUANYADOR
                MessageBox.Show("Ha guanyat un jugador!")
                pnlLyo.Enabled = False
            Case C3EnRatlla.EstatPartida.EMPAT
                MessageBox.Show("Empat!")
                pnlLyo.Enabled = False
        End Select
    End Sub

End Class
