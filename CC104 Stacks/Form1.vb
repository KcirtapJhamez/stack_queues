Imports System.Drawing.Text
Imports System.IO
Imports System.Net.Security

Public Class Form1
    'Stack
    Dim data(4) As String
    Const maxsize As Integer = 4
    Dim Stack_Top As Integer = -1

    'Queue
    Dim d(4) As String
    Const max As Integer = 4
    Dim Queue_Front As Integer = 0
    Dim Queue_Rear As Integer = -1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'PUSH
        Me.txtnewdata.Focus()
        Dim out As String = "Stack is Full / Overflow" & vbCrLf
        If Stack_Top = maxsize Then
            Me.Label1.ForeColor = Color.Red
            Me.Label1.Text = "Stack is Full / Overflow"
            MessageBox.Show(out, "Error***")
            Me.Close()
        Else
            Stack_Top = Stack_Top + 1
            data(Stack_Top) = Me.txtnewdata.Text
            Me.Controls("txtstack" & Stack_Top).Text = Me.txtnewdata.Text
            Me.txtnewdata.Text = ""
            Me.Label1.ForeColor = Color.Green
            Me.Label1.Text = "Stack Inserted : " + data(Stack_Top)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.txtnewdata.Focus()
        Dim out As String = "Stack is Empty!" & vbCrLf
        If Stack_Top = -1 Then
            Me.Label1.ForeColor = Color.Red
            Me.Label1.Text = "Stack is Empty!"
            MessageBox.Show(out, "Error***")
            Me.Close()
        Else
            Me.Label1.ForeColor = Color.Red
            Me.Label1.Text = "Item Popped : " + data(Stack_Top)
            Me.Controls("txtstack" & Stack_Top).Text = ""
            Stack_Top = Stack_Top - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' stack peek()
        Me.txtnewdata.Focus()
        Dim out As String = "Stack is Empty!" & vbCrLf

        If Stack_Top = -1 Then
            Me.Label1.ForeColor = Color.Red
            Me.Label1.Text = "Stack is Empty!"
            MessageBox.Show(out, "Error***")
            Me.Close()
        Else
            MessageBox.Show("The Peek is : " + data(Stack_Top), "Stack Peek()")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Enqueue()
        Me.txtnextdata.Focus()
        Dim pat As String = "Queue is Full / Overflow" & vbCrLf
        If Queue_Rear = max Then
            Me.Label6.ForeColor = Color.Red
            Me.Label6.Text = "Queue is Full / Overflow"
            MessageBox.Show(pat, "Error***")
            Me.Close()
        Else
            Queue_Rear = Queue_Rear + 1
            d(Queue_Rear) = Me.txtnextdata.Text
            Me.Controls("txtqueue" & Queue_Rear).Text = Me.txtnextdata.Text
            Me.txtnextdata.Text = ""
            Me.Label6.ForeColor = Color.Green
            Me.Label6.Text = "Enqueued Item : " + d(Queue_Rear)
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.txtnextdata.Focus()
        Dim pat As String = "Queue is Empty" & vbCrLf

        If Queue_Front > Queue_Rear Then
            Me.Label6.ForeColor = Color.Red
            Me.Label6.Text = "Queue is Empty!"
            MessageBox.Show(pat, "Error***")
            Me.Close()
        Else
            Me.Label6.ForeColor = Color.Red
            Me.Label6.Text = "Dequeued Item: " + d(Queue_Front)
            Me.Controls("txtqueue" & Queue_Front).Text = ""

            For i As Integer = Queue_Front + 1 To Queue_Rear
                Me.Controls("txtqueue" & i - 1).Text = Me.Controls("txtqueue" & i).Text
                d(i - 1) = d(i)
            Next
            Me.Controls("txtqueue" & Queue_Rear).Text = ""
            Queue_Rear = Queue_Rear - 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.txtnextdata.Focus()
        Dim pat As String = "Queue is Empty" & vbCrLf
        If Queue_Front > Queue_Rear Then
            Me.Label6.ForeColor = Color.Red
            Me.Label6.Text = "Queue is Empty!"
            MessageBox.Show(pat, "Error***")
            Me.Close()
        Else
            MessageBox.Show("The Peek is : " + d(Queue_Front), "Queue Peek()")
        End If
    End Sub
End Class
