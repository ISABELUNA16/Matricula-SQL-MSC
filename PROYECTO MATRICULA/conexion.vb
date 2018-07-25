Imports System.Data.SqlClient
Public Class conexion
    Protected cnn As New SqlConnection
    Protected Function conectado()
        Try
            'cnn = New SqlConnection("Data Source=ESTRELLA-PC;Initial Catalog=MATRICULA;Integrated Security=True")
            'cnn = New SqlConnection("Data Source=KELLY-PC\SQLEXPRESS;Initial Catalog=Matricula;Integrated Security=True")
            '  cnn = New SqlConnection("Data Source=PC-100-PC;Initial Catalog=MATRICULA;Integrated Security=True")
            cnn = New SqlConnection("Data Source=(local);Initial Catalog=MATRICULA;Integrated Security=True")
            'cnn = New SqlConnection("Data Source=PC-100-PC;Initial Catalog=Matriculita;Integrated Security=True")
            'cnn = New SqlConnection("Data Source=ROCIO-PC;Initial Catalog=MATRICULA;Integrated Security=True")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Class
