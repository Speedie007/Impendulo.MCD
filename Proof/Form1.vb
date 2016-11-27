Imports Impendulo.Data.Models

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbConnection As New MCDEntities
        Dim a = From v In dbConnection.CourseCategories
                Select v
        Me.CourseCategoryBindingSource.DataSource = a.ToList()
    End Sub


End Class
