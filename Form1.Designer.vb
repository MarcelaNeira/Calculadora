<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Dim operador As Char
    Dim siOperador As Boolean = False
    Dim cadena As String
    Dim signo, tamano As Integer
    Dim numero1, numero2 As Double


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.suma = New System.Windows.Forms.Button()
        Me.resta = New System.Windows.Forms.Button()
        Me.multiplicacion = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.botonIgual = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(158, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(58, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 33)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(108, 141)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(34, 33)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(158, 141)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 33)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(108, 238)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(34, 33)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "0"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(158, 190)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(34, 33)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "9"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(108, 190)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(34, 33)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "8"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(58, 190)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(34, 33)
        Me.Button12.TabIndex = 7
        Me.Button12.Text = "7"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'suma
        '
        Me.suma.Location = New System.Drawing.Point(234, 93)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(34, 33)
        Me.suma.TabIndex = 12
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.Location = New System.Drawing.Point(234, 141)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(34, 33)
        Me.resta.TabIndex = 13
        Me.resta.Text = "-"
        Me.resta.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.Location = New System.Drawing.Point(234, 190)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(34, 33)
        Me.multiplicacion.TabIndex = 14
        Me.multiplicacion.Text = "*"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(234, 238)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(34, 33)
        Me.division.TabIndex = 15
        Me.division.Text = "/"
        Me.division.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(58, 238)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(34, 33)
        Me.Button15.TabIndex = 16
        Me.Button15.Text = "c"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'botonIgual
        '
        Me.botonIgual.Location = New System.Drawing.Point(158, 238)
        Me.botonIgual.Name = "botonIgual"
        Me.botonIgual.Size = New System.Drawing.Size(34, 33)
        Me.botonIgual.TabIndex = 17
        Me.botonIgual.Text = "="
        Me.botonIgual.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(58, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 303)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.botonIgual)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents suma As Button
    Friend WithEvents resta As Button
    Friend WithEvents multiplicacion As Button
    Friend WithEvents division As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents botonIgual As Button
    Friend WithEvents TextBox1 As TextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escribir("1")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        escribir("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        escribir("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        escribir("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        escribir("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        escribir("6")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        escribir("7")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        escribir("8")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        escribir("9")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        escribir("0")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = ""
    End Sub
    Private Sub escribir(numero As String)
        TextBox1.Text = TextBox1.Text + numero
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles suma.Click
        operar("+")
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles resta.Click
        operar("-")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click
        operar("*")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles division.Click
        operar("/")
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles botonIgual.Click

        If (siOperador = True) Then
            siOperador = resolver()
        End If
    End Sub
    Function hayOperador(caracter As Char)
        cadena = TextBox1.Text

        If (cadena.EndsWith("+") Or cadena.EndsWith("-") Or cadena.EndsWith("*") Or cadena.EndsWith("/")) Then
            cadena = cadena.TrimEnd(operador)
            operador = caracter

            cadena = cadena + caracter

            TextBox1.Text = cadena

        End If
        Return True
    End Function

    Function operacion(numero1 As Double, numero2 As Double) As Double
        Dim resultado As Double

        If (operador = "+") Then
            resultado = numero1 + numero2
        ElseIf (operador = "-") Then
            resultado = numero1 - numero2
        ElseIf (operador = "/") Then
            resultado = numero1 / numero2
        ElseIf (operador = "*") Then
            resultado = numero1 * numero2
        End If

        Return resultado
    End Function
    Function resolver() As Boolean

        cadena = TextBox1.Text
        signo = cadena.IndexOf(operador)
        tamano = cadena.Length
        Dim sw As Boolean

        If (signo <> -1 And cadena.Remove(0, (signo + 1)) <> "") Then

            numero1 = CDbl(cadena.Remove(signo, (tamano - signo)))
            numero2 = CDbl(cadena.Remove(0, (signo + 1)))
            TextBox1.Text = CStr(operacion(numero1, numero2))
            sw = False
        Else
            sw = True

        End If

        Return sw
    End Function

    Function operar(simbolo As Char)
        hayOperador(simbolo)

        If (siOperador = True) Then
            siOperador = resolver()
        Else
            escribir(simbolo)
            operador = simbolo
            siOperador = True
        End If
        Return True

    End Function

End Class
