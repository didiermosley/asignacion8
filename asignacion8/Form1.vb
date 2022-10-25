Imports System.Data.SqlClient

Public Class Form1
    Dim conn As New SqlConnection("Data Source=DIDIER;Initial Catalog=asignacion8;Integrated Security=true")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub executequery(ByVal query As String)
        Dim cmd As New SqlCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim insertquery As String = "INSERT INTO Datos(cedula, nombre, apellido, profesion, carrera) values ('" & tbCedula.Text & "','" & tbNombre.Text & "','" & tbApellido.Text & "','" & tbProf.Text & "','" & tbCarrera.Text & "')"
        executequery(insertquery)
        MessageBox.Show("¡Datos agregados con éxito!", "Insersión de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()

    End Sub

    Private Sub btnConsul_Click(sender As Object, e As EventArgs) Handles btnConsul.Click
        Dim cmd As New SqlCommand("SELECT * FROM Datos WHERE cedula=@ID", conn)
        cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = tbCedula.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            tbNombre.Text = dt.Rows(0)(1).ToString
            tbApellido.Text = dt.Rows(0)(2).ToString
            tbCarrera.Text = dt.Rows(0)(3).ToString
            tbProf.Text = dt.Rows(0)(4).ToString
        Else
            MessageBox.Show("No se encontró ese registro", "Hay un problema...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        Dim actualizarQuery As String = "UPDATE Datos SET nombre='" & tbNombre.Text & "', apellido='" & tbApellido.Text & "', profesion='" & tbProf.Text & "', carrera='" & tbCarrera.Text & "' WHERE cedula = '" & tbCedula.Text & "'"
        executequery(actualizarQuery)
        MessageBox.Show("¡Datos actualizados con éxito!", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminarDatos As String = "DELETE FROM Datos WHERE cedula ='" & tbCedula.Text & "'"
        executequery(eliminarDatos)
        MessageBox.Show("¡Datos eliminados con éxito!", "Datos eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()
    End Sub

    Private Sub btnF2_Click(sender As Object, e As EventArgs) Handles btnF2.Click
        Form2.Show()
    End Sub
End Class
