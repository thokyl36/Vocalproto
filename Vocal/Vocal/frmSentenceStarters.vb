Public Class frmSentenceStarters

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmKeyboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnIWant_Click(sender As Object, e As EventArgs) Handles btnIWant.Click
        frmFood.words.Add("I want ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "iWant.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("iWant.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub frmSentenceStarters_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmFood.noiseMaker.settings.autoStart = False
    End Sub

    Private Sub frmSentenceStarters_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmFood.noiseMaker = Nothing
    End Sub

    Private Sub btnCanWe_Click(sender As Object, e As EventArgs) Handles btnCanWe.Click
        frmFood.words.Add("I need ")
        'frmFood.listen.Add("iWant.mp3") 

        frmFood.display()
        frmFood.noiseMaker.URL = "iNeed.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("iNeed.mp3"))
        frmFood.num += 1

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblSentence.Text = ""
        frmFood.lblSentence.Text = ""
        frmFood.sentence = ""
        frmFood.words.Clear()

        frmFood.myPlaylist.clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmFood.words.RemoveAt(frmFood.words.Count() - 1)
        frmFood.sentence = ""

        For Each item As String In frmFood.words
            frmFood.sentence += item
        Next

        'word = words(words.Count() - 1)
        'sentence += word

        frmFood.myPlaylist.removeItem(frmFood.myPlaylist.Item(frmFood.num - 1))
        frmFood.num -= 1
        lblSentence.Text = frmFood.sentence
        frmFood.lblSentence.Text = frmFood.sentence
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        frmFood.noiseMaker.currentPlaylist = frmFood.myPlaylist
        frmFood.noiseMaker.controls.play()
    End Sub

    Private Sub btnIAm_Click(sender As Object, e As EventArgs) Handles btnIAm.Click
        frmFood.words.Add("I am ")
        'frmFood.listen.Add("iWant.mp3") 
        'replace with"I am"
        frmFood.display()
        frmFood.noiseMaker.URL = "iNeed.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("iNeed.mp3"))
        frmFood.num += 1

    End Sub

    Private Sub btnYouAre_Click(sender As Object, e As EventArgs) Handles btnYouAre.Click
        frmFood.words.Add("You are ")
        'frmFood.listen.Add("iWant.mp3") 
        'replace with "You are"
        frmFood.display()
        frmFood.noiseMaker.URL = "iNeed.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("iNeed.mp3"))
        frmFood.num += 1

    End Sub

    Private Sub btnWeAre_Click(sender As Object, e As EventArgs) Handles btnWeAre.Click
        frmFood.words.Add("We are ")
        'frmFood.listen.Add("iWant.mp3") 
        'replace with"We are"
        frmFood.display()
        frmFood.noiseMaker.URL = "iNeed.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("iNeed.mp3"))
        frmFood.num += 1

    End Sub
End Class