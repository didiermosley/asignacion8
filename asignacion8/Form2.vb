Imports System.Data.SqlClient
Public Class Form2
    Dim conn As New SqlConnection("Data Source=DIDIER;Initial Catalog=asignacion8;Integrated Security=true")
    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Public Sub executequery(ByRef accion As String, ByRef params As SqlParameter())

        Dim command As New SqlCommand()
        command.Connection = conn
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = accion

        command.Parameters.AddRange(params)


        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim parametros(4) As SqlParameter

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

        executequery("Insertar", parametros)

        MessageBox.Show("¡Datos agregados con éxito!", "Insersión de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        Dim parametros(4) As SqlParameter
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

        executequery("Actualizar", parametros)

        MessageBox.Show("¡Datos actualizados con éxito!", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim parametro(0) As SqlParameter
        parametro(0) = New SqlParameter("@cedula", SqlDbType.VarChar)
        parametro(0).Value = tbCedula.Text

        executequery("Eliminar", parametro)
        MessageBox.Show("¡Datos actualizados con éxito!", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()
    End Sub

    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        Dim parametro(0) As SqlParameter
        parametro(0) = New SqlParameter("@cedula", SqlDbType.VarChar)
        parametro(0).Value = tbCedula.Text

        executequery("Consultar", parametro)

    End Sub
End Class