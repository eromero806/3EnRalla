Public Class C3EnRatlla

    Public Enum EstatPartida
        CONTINUA
        GUANYADOR
        EMPAT
    End Enum

    Private taulell(2, 2) As Char

    Public Property JugadorActual As Char = "X"

    Public Sub New()
        InicialitzarTaulell()
    End Sub

    Public Sub InicialitzarTaulell()
        For i = 0 To 2
            For j = 0 To 2
                taulell(i, j) = " "c
            Next
        Next
        JugadorActual = "X"
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
            If taulell(i, 0) <> " "c AndAlso
                taulell(i, 0) = taulell(i, 1) AndAlso
                taulell(i, 1) = taulell(i, 2) Then
                Return EstatPartida.GUANYADOR
            End If
        Next

        For j = 0 To 2
            If taulell(0, j) <> " "c AndAlso
                taulell(0, j) = taulell(1, j) AndAlso
                taulell(1, j) = taulell(2, j) Then
                Return EstatPartida.GUANYADOR
            End If
        Next

        If taulell(0, 0) <> " "c AndAlso taulell(0, 0) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 2) Then
            Return EstatPartida.GUANYADOR
        End If

        If taulell(0, 2) <> " "c AndAlso taulell(0, 2) = taulell(1, 1) AndAlso taulell(1, 1) = taulell(2, 0) Then
            Return EstatPartida.GUANYADOR
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
