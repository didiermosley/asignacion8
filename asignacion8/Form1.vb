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
        MessageBox.Show("Datos agregados con éxito!", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tbNombre.Clear()
        tbCedula.Clear()
        tbApellido.Clear()
        tbProf.Clear()
        tbCarrera.Clear()

    End Sub
End Class
