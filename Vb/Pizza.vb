Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Dim taille = lsttaille.SelectedItem.ToString()
        MessageBox.Show(taille)
        Dim ingredient As String = ""
        If Rdproposition1.Checked Then
            ingredient = "Croute fine"
        ElseIf Rdproposition2.Checked Then
            ingredient = "Croute Classique"
        ElseIf Rdproposition3.Checked Then
            ingredient = "Croute Epaisse"
        End If
        MessageBox.Show(ingredient)
        Dim ingredientsupp As String = ""
        Dim ingredientsupp1 As String = ""
        Dim ingredientsupp2 As String = ""
        Dim ingredientsupp3 As String = ""
        If Chk1.Checked Then
            ingredientsupp = "Chompignons"
            MessageBox.Show(ingredientsupp)
            RichTextBox1.Text = ingredientsupp
        End If
        If Chk2.Checked Then
            ingredientsupp1 = "Olives"
            MessageBox.Show(ingredientsupp1)
            RichTextBox1.Text = ingredientsupp1
        End If
        If Chk3.Checked Then
            ingredientsupp2 = "Poivrons"
            MessageBox.Show(ingredientsupp2)
            RichTextBox1.Text = ingredientsupp2
        End If
        If Chk4.Checked Then
            ingredientsupp3 = "Frommage supplémentaire"
            MessageBox.Show(ingredientsupp3)
            RichTextBox1.Text = ingredientsupp3
        End If
        RichTextBox1.Text = taille.ToString & Chr(13) + ingredient.ToString & Chr(13) + ingredientsupp.ToString & Chr(13) + ingredientsupp1.ToString & Chr(13) + ingredientsupp2.ToString & Chr(13) + ingredientsupp3.ToString

    End Sub

End Class
