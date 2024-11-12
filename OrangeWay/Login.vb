Imports System.Windows.Forms
Public Class Login

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each c As Control In Connexion.Controls
            If TypeOf c Is PictureBox Then
                c.Visible = False
                PictureBox2.Show()
            End If
        Next
       
       

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilisateur.Select()
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        Me.Close()
    End Sub

    Private Sub Utilisateur_TextChanged(sender As Object, e As EventArgs) Handles Utilisateur.TextChanged
        Message.Text = ""
        If Utilisateur.Text = "admin" Then
            PictureBox3.Visible = True
            PictureBox5.Hide()
        Else
            PictureBox3.Hide()
            PictureBox5.Show()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Password.PasswordChar = ""

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Password.PasswordChar = "*"
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        Message.Text = ""
        If Password.Text = "ahfir" Then
            PictureBox4.Visible = True
        Else
            PictureBox7.Visible = False
            PictureBox4.Visible = False

        End If
    End Sub

    Private Sub Connecter_Click(sender As Object, e As EventArgs) Handles Connecter.Click
        If Utilisateur.Text = "admin" And Password.Text = "ahfir" Then
            Orangeway.Show()
            Me.Hide()
        Else
            Message.Text = "Votre nom d'utilisateur et /ou Mot de passe est incorrect"
            Message.BackColor = Color.Red
            If Utilisateur.Text = "admin" Then
                Password.Select()
                Password.Clear()
            Else
                Utilisateur.Select()
                Utilisateur.Clear()
            End If
        End If
    End Sub
End Class
