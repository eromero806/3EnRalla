Public Class Form1

    Private joc As C3EnRatlla
    Private labels As List(Of System.Windows.Forms.Label)
    Private partidesGuanyadesX As Integer = 0
    Private partidesGuanyadesO As Integer = 0
    Private joc1Jugador As Boolean = False
    Private jugadorHuma As Char = "X"c
    Private rnd As New Random()


    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Inicialitzacions()
        pnlLyo.Enabled = True
    End Sub

    Private Sub Inicialitzacions()
        joc = New C3EnRatlla()

        labels = New List(Of System.Windows.Forms.Label) From {
        Label0, Label1, Label2,
        Label3, Label4, Label5,
        Label6, Label7, Label8
    }

        For Each lbl In labels
            lbl.Text = ""
        Next

        ' Si és 1 jugador i l'humà és O → comença la màquina
        If joc1Jugador AndAlso jugadorHuma = "O"c Then
            JocMaquina()
        End If
    End Sub


    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label0.Click, Label1.Click, Label2.Click,
                                                                Label3.Click, Label4.Click, Label5.Click,
                                                                Label6.Click, Label7.Click, Label8.Click
        If joc1Jugador AndAlso joc.JugadorActual <> jugadorHuma Then Exit Sub

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
            Case C3EnRatlla.EstatPartida.GUANYADORX
                MessageBox.Show("Ha guanyat X!")
                pnlLyo.Enabled = False
                partidesGuanyadesX += 1
                lblX.Text = partidesGuanyadesX.ToString()
            Case C3EnRatlla.EstatPartida.GUANYADORO
                MessageBox.Show("Ha guanyat O!")
                pnlLyo.Enabled = False
                partidesGuanyadesO += 1
                lblO.Text = partidesGuanyadesO.ToString()
            Case C3EnRatlla.EstatPartida.EMPAT
                MessageBox.Show("Empat!")
                pnlLyo.Enabled = False
        End Select

        If joc1Jugador AndAlso estat = C3EnRatlla.EstatPartida.CONTINUA Then
            JocMaquina()
        End If

    End Sub

    Private Sub chk1jug_CheckedChanged(sender As Object, e As EventArgs) Handles chk1jug.CheckedChanged
        joc1Jugador = chk1jug.Checked
        chkO.Enabled = joc1Jugador

    End Sub

    Private Sub chkO_CheckedChanged(sender As Object, e As EventArgs) Handles chkO.CheckedChanged
        If chkO.Checked Then
            jugadorHuma = "O"c
        Else
            jugadorHuma = "X"c
        End If
    End Sub

    Private Sub JocMaquina()
        If joc.JugadorActual = jugadorHuma Then Exit Sub

        Dim lliures As New List(Of Integer)

        For i = 0 To labels.Count - 1
            If labels(i).Text = "" Then
                lliures.Add(i)
            End If
        Next

        If lliures.Count = 0 Then Exit Sub

        Dim index As Integer = lliures(rnd.Next(lliures.Count))
        Dim fila As Integer = index \ 3
        Dim col As Integer = index Mod 3

        joc.FerJugada(fila, col)
        labels(index).Text = If(jugadorHuma = "X"c, "O", "X")

        Dim estat = joc.EsFinalPartida()

        Select Case estat
            Case C3EnRatlla.EstatPartida.GUANYADORX
                MessageBox.Show("Ha guanyat X!")
                pnlLyo.Enabled = False
                partidesGuanyadesX += 1
                lblX.Text = partidesGuanyadesX.ToString()

            Case C3EnRatlla.EstatPartida.GUANYADORO
                MessageBox.Show("Ha guanyat O!")
                pnlLyo.Enabled = False
                partidesGuanyadesO += 1
                lblO.Text = partidesGuanyadesO.ToString()

            Case C3EnRatlla.EstatPartida.EMPAT
                MessageBox.Show("Empat!")
                pnlLyo.Enabled = False
        End Select
    End Sub

End Class
