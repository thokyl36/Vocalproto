Public Class frmKeyboard
    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click

        frmFood.Show()
        Me.Hide()
    End Sub

    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click
        frmSentenceStarters.Show()
        Me.Hide()


    End Sub

    Private Sub frmKeyboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmFood.myPlaylist = frmFood.noiseMaker.playlistCollection.newPlaylist("soundsToPlay")
    End Sub

    Private Sub btnEmotions_Click(sender As Object, e As EventArgs) Handles btnEmotions.Click
        frmEmotions.Show()
        Me.Hide()

    End Sub

    Private Sub btnPeople_Click(sender As Object, e As EventArgs) Handles btnPeople.Click
        frmPeople.Show()
        Me.Hide()
    End Sub
End Class
