Public Class Form1
    Dim Ball As New Rectangle(385, 280, 20, 20)
    Dim Paddle1 As New Rectangle(15, 150, 15, 150)
    Dim Paddle2 As New Rectangle(755, 150, 15, 150)
    Dim BallSpeedY As Integer
    Dim BallSpeedX As Integer
    Dim Player1Speed As Integer
    Dim Player2Speed As Integer
    Dim PlayerConstant As Integer
    Dim RNG As New Random
    Dim RNG2 As New Random
    Dim RNGPlayer2 As New Integer
    Dim StartingMotion As Integer
    Dim P1Points As Integer
    Dim P2Points As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BallSpeedY = 5
        BallSpeedX = 5
        StartingMotion = RNG.Next(1, 5)
        PlayerConstant = 5
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gameTimer.Enabled = True
        Button1.Visible = False
        Label1.Visible = False
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        P1Points = 0
        P2Points = 0
        RNGPlayer2 = RNG2.Next(1, 5)
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.FillEllipse(Brushes.White, Ball)
        e.Graphics.FillRectangle(Brushes.White, Paddle1)
        e.Graphics.FillRectangle(Brushes.White, Paddle2)
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        Me.Focus()
        MoveBall()
        MovePlayer()
        MoveOpponent()
        If Ball.IntersectsWith(Paddle1) = True Then
            BallSpeedX = -BallSpeedX
        End If
        If Ball.IntersectsWith(Paddle2) = True Then
            BallSpeedX = -BallSpeedX
        End If
        If Ball.X >= 800 Then
            P1Points += 1
            lblP1Points.Text = P1Points
            RoundReset()
        End If
        If Ball.X <= 0 Then
            P2Points += 1
            lblP2Points.Text = P2Points
            RoundReset()
        End If
        If P2Points = 3 Then
            gameTimer.Enabled = False
            MessageBox.Show("You lost!")
            Reset()
        End If
        If P1Points = 3 Then
            gameTimer.Enabled = False
            MessageBox.Show("You won!")
            Reset()
        End If

        If Ball.IntersectsWith(Paddle1) Then
            RNGPlayer2 = RNG2.Next(1, 5)
        End If

        Me.Invalidate()
    End Sub

    Private Sub MoveBall()
        If StartingMotion = 1 Then
            Ball.Y += BallSpeedY
            Ball.X += BallSpeedX
        End If
        If StartingMotion = 2 Then
            Ball.Y -= BallSpeedY
            Ball.X -= BallSpeedX
        End If
        If StartingMotion = 3 Then
            Ball.Y -= BallSpeedY
            Ball.X += BallSpeedX
        End If
        If StartingMotion = 4 Then
            Ball.Y += BallSpeedY
            Ball.X -= BallSpeedX
        End If

        If Ball.Y = Me.Height - 55 Then
            BallSpeedY = BallSpeedY * -1
        End If
        If Ball.Y = 0 Then
            BallSpeedY = BallSpeedY * -1
        End If
    End Sub

    Private Sub MovePlayer()
        Paddle1.Y = Paddle1.Y + Player1Speed

        If Paddle1.Y = 0 Then
            PlayerConstant = 0
            Paddle1.Y = 5
        End If
        If Paddle1.Y = 315 Then
            PlayerConstant = 0
            Paddle1.Y = 310
        End If
    End Sub

    Private Sub MoveOpponent()
        Paddle2.Y = Paddle2.Y + Player2Speed

        If RNGPlayer2 = 1 Or RNGPlayer2 = 3 Or RNGPlayer2 = 4 Then
            If Ball.X > 450 And Paddle2.Y <> Ball.Y Then
                Paddle2.Y = Ball.Y - 50
            End If
        ElseIf RNGPlayer2 = 2 Then
            If Ball.X > 450 And Paddle2.Y <> Ball.Y Then
                Paddle2.Y = Ball.Y + 50
            End If
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            Player1Speed = -PlayerConstant
        End If
        If e.KeyCode = Keys.S Then
            Player1Speed = PlayerConstant
        End If

        If e.KeyCode = Keys.W And PlayerConstant = 0 Then
            PlayerConstant = 5
        End If
        If e.KeyCode = Keys.S And PlayerConstant = 0 Then
            PlayerConstant = 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.W Then
            Player1Speed = 0
        End If
        If e.KeyCode = Keys.S Then
            Player1Speed = 0
        End If
    End Sub

    Private Sub Reset()
        gameTimer.Enabled = False
        Me.Invalidate()
        Button1.Visible = True
        Label1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Ball.Y = 280
        Ball.X = 385
        Paddle1.Y = 150
        Paddle2.Y = 150
        BallSpeedY = 5
        BallSpeedX = 5
        StartingMotion = RNG.Next(1, 5)
        PlayerConstant = 5
        P1Points = 0
        P2Points = 0
        lblP1Points.Text = P1Points
        lblP2Points.Text = P2Points
    End Sub

    Private Sub RoundReset()
        Me.Invalidate()
        Ball.Y = 280
        Ball.X = 385
        Paddle1.Y = 150
        Paddle2.Y = 150
        BallSpeedY = 5
        BallSpeedX = 5
        StartingMotion = RNG.Next(1, 5)
        RNGPlayer2 = RNG2.Next(1, 5)
        PlayerConstant = 5
    End Sub
End Class
