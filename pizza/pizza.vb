Public Class Form1
    Private Sub Btn_click(sender As Object, e As EventArgs) Handles Btn_click
        Dim selectedItem As Object = lst_demande.SelectedItem
        Dim taille = Btn_click.SelectedItem.ToString()
        Dim ingredient As String = ""
        If rd_fine.Checked Then
            ingredient = " Croute Fine"
        ElseIf rd_classique.Checked Then
            ingredient = "Croute classique"
        ElseIf rd_épaise.Checked Then
            ingredient = "Croute Epaise"
        End If
        Dim ingrSupp As String = ""
        If hk_champigion.Checked Then
            ingrSupp = ingrSupp + "Champignon"
        ElseIf hk_olives.Checked Then
            ingrSupp = ingrSupp + "Olives"
        ElseIf hk_poissons.Checked Then
            ingrSupp = ingrSupp + "poivrons"
        ElseIf hk_fromage.Checked Then
            ingrSupp = ingrSupp + "Fromage supplimentaire"
        End If
        Dim msg As String = "taille:    " + taille + " type de croute :   " + ingredient + "   ingredient suplémentaire:   " + ingrSupp
        MessageBox.Show(msg)

    End Sub

    Private Sub lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_demande.SelectedIndexChanged

    End Sub
End Class
