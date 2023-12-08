Public Class Form2

    Private Sub WebfavoritosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebfavoritosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WebfavoritosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatawebDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatawebDataSet.webfavoritos' table. You can move, or remove it, as needed.
        Me.WebfavoritosTableAdapter.Fill(Me.DatawebDataSet.webfavoritos)

    End Sub
End Class