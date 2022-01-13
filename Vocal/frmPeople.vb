Public Class frmPeople
    Private Sub btnMom_Click(sender As Object, e As EventArgs) Handles btnMom.Click
        frmFood.words.Add("Mom ")
        'frmFood.listen.Add("iWant.mp3")
        'replace with "mom"
        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "mom.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("mom.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnDad_Click(sender As Object, e As EventArgs) Handles btnDad.Click
        frmFood.words.Add("Dad ")
        'frmFood.listen.Add("iWant.mp3")
        'replace with"dad"
        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "dad.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("dad.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        frmFood.words.Add("Teacher ")
        'frmFood.listen.Add("iWant.mp3")
        'replace with "teacher"
        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "teacher.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("teacher.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        frmFood.words.Add("Doctor ")
        'frmFood.listen.Add("iWant.mp3")
        'replace with "doctor"
        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "doctor.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("doctor.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnFriend_Click(sender As Object, e As EventArgs) Handles btnFriend.Click
        frmFood.words.Add("Friend ")
        'frmFood.listen.Add("iWant.mp3")
        'replcae with "friends"
        'need to replace "i need" with "scared" 
        frmFood.display()
        frmFood.noiseMaker.URL = "friend.mp3"
        frmFood.noiseMaker.controls.play()

        frmFood.myPlaylist.appendItem(frmFood.noiseMaker.newMedia("friend.mp3"))
        frmFood.num += 1
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'frmFood.noiseMaker.currentPlaylist = frmFood.myPlaylist
        'frmFood.noiseMaker.controls.play()

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmKeyboard.Show()
        Me.Hide()
    End Sub
End Class