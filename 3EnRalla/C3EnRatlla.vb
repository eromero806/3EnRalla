Public Class C3EnRatlla

    Public Enum EstatPartida
        CONTINUA
        GUANYADORX
        GUANYADORO
        EMPAT
    End Enum

    Private taulell(2, 2) As Char

    Public Property JugadorActual As Char = "X"

    Public Sub New()
        InicialitzarTaulell(JugadorActual)
    End Sub

    Public Sub InicialitzarTaulell(jug As Char)
        For i = 0 To 2
            For j = 0 To 2
                taulell(i, j) = " "c
            Next
        Next
        JugadorActual = jug
    End Sub

    Public Function FerJugada(fila As Integer, columna As Integer) As Boolean
        If taulell(fila, columna) = " "c Then
            taulell(fila, columna) = JugadorActual

            If JugadorActual = "X"c Then
                JugadorActual = "O"c
            Else
                JugadorActual = "X"c
            End If

            Return True
        End If

        Return False
    End Function

    Public Function EsFinalPartida() As EstatPartida

        For i = 0 To 2
            If taulell(i, 0) = "X"c AndAlso
                taulell(i, 0) = taulell(i, 1) AndAlso
                taulell(i, 1) = taulell(i, 2) Then
                Return EstatPartida.GUANYADORX
            ElseIf taulell(i, 0) = "O"c AndAlso
                taulell(i, 0) = taulell(i, 1) AndAlso
                taulell(i, 1) = taulell(i, 2) Then
                Return EstatPartida.GUANYADORO
            End If
        Next

        For j = 0 To 2
            If taulell(0, j) = "X"c AndAlso
                taulell(0, j) = taulell(1, j) AndAlso
                taulell(1, j) = taulell(2, j) Then
                Return EstatPartida.GUANYADORX
            ElseIf taulell(0, j) = "O"c AndAlso
                taulell(0, j) = taulell(1, j) AndAlso
                taulell(1, j) = taulell(2, j) Then
                Return EstatPartida.GUANYADORO
            End If
        Next

        If taulell(0, 0) = "X"c AndAlso taulell(0, 0) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 2) Then
            Return EstatPartida.GUANYADORX
        ElseIf taulell(0, 0) = "O"c AndAlso taulell(0, 0) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 2) Then
            Return EstatPartida.GUANYADORO
        End If

        If taulell(0, 2) = "X"c AndAlso taulell(0, 2) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 0) Then
            Return EstatPartida.GUANYADORX

        ElseIf taulell(0, 2) = "O"c AndAlso taulell(0, 2) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 0) Then
            Return EstatPartida.GUANYADORO
        End If

        For i = 0 To 2
            For j = 0 To 2
                If taulell(i, j) = " "c Then
                    Return EstatPartida.CONTINUA
                End If
            Next
        Next

        Return EstatPartida.EMPAT
    End Function

End Class
