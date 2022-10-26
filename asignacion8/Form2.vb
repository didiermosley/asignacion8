Imports System.Data.SqlClient
Public Class Form2
    Dim conn As New SqlConnection("Data Source=DIDIER;Initial Catalog=asignacion8;Integrated Security=true")
    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim parametros(1) As SqlParameter

        parametros(0) = New SqlParameter("@cedula", SqlDbType.VarChar)
        parametros(0).Value = tbCedula.Text

        parametros(1) = New SqlParameter("@nombre", SqlDbType.VarChar)
        parametros(1).Value = tbNombre.Text

        parametros(2) = New SqlParameter("@apellido", SqlDbType.VarChar)
        parametros(2).Value = tbApellido.Text

        parametros(3) = New SqlParameter("@profesion", SqlDbType.VarChar)
        parametros(3).Value = tbProf.Text

        parametros(4) = New SqlParameter("@carrera", SqlDbType.VarChar)
        parametros(4).Value = tbCarrera.Text

        Dim command As New SqlCommand()
        command.Connection = conn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "Insertar"

        command.Parameters.AddRange(parametros)

        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class