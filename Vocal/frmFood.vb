Public Class frmFood
    Public sentence, word As String
    Public words As ArrayList = New ArrayList()
    Public listen As ArrayList = New ArrayList()
    Public myPlaylist As WMPLib.IWMPPlaylist

    Public num As Integer

    Public WithEvents noiseMaker As New WMPLib.WindowsMediaPlayer


    Private Sub frmFood_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        noiseMaker = Nothing
        frmKeyboard.Show()
    End Sub 

    Private Sub frmFood_Load(sender As Object, e As EventArgs) Handles Me.Load
        'sentence = ""
        noiseMaker.settings.autoStart = False

    End Sub

    Private Sub btnPizza_Click(sender As Object, e As EventArgs) Handles btnPizza.Click
        If sentence = "" Then
            words.Add("Pizza ")
        Else
            words.Add("pizza ")
        End If
        listen.Add("pizza.mp3")
        display()
        noiseMaker.URL = "pizza.mp3"
        noiseMaker.controls.play()
        myPlaylist.appendItem(noiseMaker.newMedia("pizza.mp3"))
        num += 1
    End Sub

    Private Sub btnMilk_Click(sender As Object, e As EventArgs) Handles btnMilk.Click
        If sentence = "" Then
            words.Add("Milk ")
        Else
            words.Add("milk ")
        End If
        listen.Add("milk.mp3")
        display()
        noiseMaker.URL = "milk.mp3"
        noiseMaker.controls.play()
        myPlayList.appendItem(noiseMaker.newMedia("milk.mp3"))
        num += 1
    End Sub

    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        If sentence = "" Then
            words.Add("Chicken ")
        Else
            words.Add("chicken ")
        End If
        listen.Add("chicken.mp3")
        display()
        noiseMaker.URL = "chicken.mp3"
        noiseMaker.controls.play()
        myPlaylist.appendItem(noiseMaker.newMedia("chicken.mp3"))
        num += 1
    End Sub

    Private Sub btnPasta_Click(sender As Object, e As EventArgs) Handles btnPasta.Click
        If sentence = "" Then
            words.Add("Pasta ")
        Else
            words.Add("pasta ")
        End If
        listen.Add("pasta.mp3")
        display()
        noiseMaker.URL = "pasta.mp3"
        noiseMaker.controls.play()
        myPlaylist.appendItem(noiseMaker.newMedia("pasta.mp3"))
        num += 1

    End Sub

    Private Sub btnChips_Click(sender As Object, e As EventArgs) Handles btnChips.Click
        If sentence = "" Then
            words.Add("Chips ")
        Else
            words.Add("chips ")
        End If
        listen.Add("chips.mp3")
        display()
        noiseMaker.URL = "chips.mp3"
        noiseMaker.controls.play()
        myPlaylist.appendItem(noiseMaker.newMedia("chips.mp3"))
        num += 1
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        words.RemoveAt(words.Count() - 1)
        sentence = ""

        For Each item As String In words
            sentence += item
        Next

        'word = words(words.Count() - 1)
        'sentence += word

        myPlaylist.removeItem(myPlaylist.Item(num - 1))
        num -= 1
        lblSentence.Text = sentence
        'frmSentenceStarters.lblSentence.Text = sentence
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblSentence.Text = ""
        'frmSentenceStarters.lblSentence.Text = ""
        sentence = ""
        words.Clear()

        myPlaylist.clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmKeyboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'For Each item In listen

        '    noiseMaker.URL = item
        '    noiseMaker.controls.play()
        '    'MsgBox(item)
        'Next
        'myPlaylist.controls.play()
        noiseMaker.currentPlaylist = myPlaylist
        noiseMaker.controls.play()
    End Sub

    Public Sub display()

        word = words(words.Count() - 1)
        sentence += word
        lblSentence.Text = sentence
        'frmSentenceStarters.lblSentence.Text = sentence
        frmEmotions.lblSentence.Text = sentence
        frmPeople.lblSentence.Text = sentence
    End Sub
End Class