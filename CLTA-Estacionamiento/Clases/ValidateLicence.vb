Imports MySql.Data.MySqlClient

Public Class validateLicence

    Dim Conexion = New MySqlConnection()
    Dim Conectar = "server=1a.ncomputers.org; user id=clta290513_root; password=tqNUx!L9; database=clta290513_licence; Port=3306;"

    Public Function Consult(ByVal sql As String)
        Dim dato As MySqlDataReader

        Try
            Conexion.close()
            Conexion.ConnectionString = Conectar
            Conexion.Open()
            Dim adapter As New MySqlDataAdapter
            Dim commando As New MySqlCommand
            commando.Connection = Conexion
            commando.CommandText = sql
            adapter.SelectCommand = commando
            dato = commando.ExecuteReader()
        Catch ex As Exception
            dato = Nothing
            MsgBox("Imposible conectar a la base de datos", MsgBoxStyle.Critical, "Error")
        End Try

        Return dato

    End Function

    Public Function Ejecutar(ByVal sql As String) As Boolean
        Try
            Conexion.close()
            Conexion.ConnectionString = Conectar
            Conexion.Open()
            Dim commando As New MySqlCommand
            commando.Connection = Conexion
            commando.CommandText = sql
            commando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class