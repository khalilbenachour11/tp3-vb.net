Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxTaille.Items.Add("Petite")
        ComboBoxTaille.Items.Add("Moyenne")
        ComboBoxTaille.Items.Add("Grande")
    End Sub

    Private Sub BtnAfficher_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        Dim taille As String = ComboBoxTaille.SelectedItem
        If String.IsNullOrEmpty(taille) Then
            MessageBox.Show("Veuillez sélectionner une taille de pizza.")
            Return
        End If

        Dim croute As String = ""
        If RadioCrouteFine.Checked Then
            croute = "Croûte Fine"
        ElseIf RadioCrouteClassique.Checked Then
            croute = "Croûte Classique"
        ElseIf RadioCrouteEpaisse.Checked Then
            croute = "Croûte Épaisse"
        Else
            MessageBox.Show("Veuillez sélectionner un type de croûte.")
            Return
        End If

        Dim ingredients As String = "Ingrédients supplémentaires : "
        If CheckChampignons.Checked Then
            ingredients &= "Champignons, "
        End If
        If CheckOlives.Checked Then
            ingredients &= "Olives, "
        End If
        If CheckPoivrons.Checked Then
            ingredients &= "Poivrons, "
        End If
        If CheckFromage.Checked Then
            ingredients &= "Fromage, "

        End If

        If ingredients.EndsWith(", ") Then
            ingredients = ingredients.Substring(0, ingredients.Length - 2)
        End If


        Dim recapitulatif As String = $"Taille : {taille}" & vbCrLf &
                                      $"Type de croûte : {croute}" & vbCrLf &
                                      $"{ingredients}"

        MessageBox.Show(recapitulatif, "Récapitulatif de la Commande")
    End Sub
End Class