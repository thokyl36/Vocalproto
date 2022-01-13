Public Class frmEmotions
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        frmFood.noiseMaker.currentPlaylist = frmFood.myPlaylist
        frmFood.noiseMaker.controls.play()
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblSentence.Text = ""
        frmFood.lblSentence.Text = ""
        frmFood.sentence = ""
        frmFood.words.Clear()

        frmFood.myPlaylist.clear()
    End Sub

    Private Sub btnHappy_Click(sender As Object, e As EventArgs) Handles btnHappy.Click
        frmFood.words.Add("Happy ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "happy" 
        frmFood.display()
        frmFood.noiseMaker.URL = "happy.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("happy.mp3"))
        frmFood.num += 1


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmKeyboard.Show()
        Me.Hide()

    End Sub
    Public Sub display()

        frmFood.word = frmFood.words(frmFood.words.Count() - 1)
        frmFood.sentence += frmFood.word
        lblSentence.Text = frmFood.sentence
        'frmSentenceStarters.lblSentence.Text = frmFood.sentence

    End Sub

    Private Sub btnAngry_Click(sender As Object, e As EventArgs) Handles btnAngry.Click
        frmFood.words.Add("Angry ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "angry" 
        frmFood.display()
        frmFood.noiseMaker.URL = "angry.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("angry.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnSad_Click(sender As Object, e As EventArgs) Handles btnSad.Click
        frmFood.words.Add("Sad ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "sad" 
        frmFood.display()
        frmFood.noiseMaker.URL = "sad.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("sad.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnScared_Click(sender As Object, e As EventArgs) Handles btnScared.Click
        frmFood.words.Add("Scared ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "scared.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("scared.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnExcited_Click(sender As Object, e As EventArgs) Handles btnExcited.Click
        frmFood.words.Add("Excited ")
        'frmFood.listen.Add("iWant.mp3")

        'need to replace "i need" with "excited" 
        frmFood.display()
        frmFood.noiseMaker.URL = "excited.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("excited.mp3"))
        frmFood.num += 1
    End Sub
End Class