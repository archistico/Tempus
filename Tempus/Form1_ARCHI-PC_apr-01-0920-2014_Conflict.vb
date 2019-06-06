Public Class frmTempus

    Public Differenza As TimeSpan
    Public secondi As Integer = 0
    Public minuti As Integer = 0
    Public ore As Integer = 0
    Public giorni As Integer = 0
    Public span As TimeSpan = New TimeSpan(0, 0, 0, 1)

    Private Function Converti(ByRef numArabo As Integer) As String
        Dim numRomano As String = ""
        If (numArabo > 0) And (numArabo < 3999) Then
            Dim numArabos() As Integer = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1}
            Dim numRomanos() As String = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"}
            Dim contatore As Integer = numArabo
            Dim i As Integer
            For i = 0 To numArabos.Length - 1 Step 1
                While (contatore >= numArabos(i))
                    numRomano = numRomano & numRomanos(i)
                    contatore = contatore - numArabos(i)
                End While
            Next
        ElseIf numArabo = 0 Then
            Return "-"
        Else
            Return "-"
        End If
        'Ritorna tempo in numeri romani
        Return numRomano
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Ad ogni tick (int)
        Differenza = Differenza.Subtract(span)
        lbSecondi.Text = Converti(Integer.Parse(Differenza.Seconds))
        lbMinuti.Text = Converti(Integer.Parse(Differenza.Minutes))
        lbOre.Text = Converti(Integer.Parse(Differenza.Hours))
        lbGiorni.Text = Converti(Integer.Parse(Differenza.Days))
    End Sub

    Private Sub btParti_Click(sender As Object, e As EventArgs) Handles btParti.Click
        'Setta le variabili di tempo
        Differenza = dtpArrivo.Value - dtpPartenza.Value
        'Setta le variabili del conto alla rovescia
        secondi = Differenza.Seconds
        minuti = Differenza.Minutes
        ore = Differenza.Hours
        giorni = Differenza.Days
        'MessageBox.Show("Giorni " & giorni.ToString & " - Ore " & ore.ToString & " - Minuti " & minuti.ToString & " - Secondi " & secondi.ToString)
        'Parti con il conto alla rovescia
        Timer1.Start()
    End Sub

    Private Sub frmTempus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Azzero le label con i risultati
        lbGiorni.Text = ""
        lbOre.Text = ""
        lbMinuti.Text = ""
        lbSecondi.Text = ""

        'days_txt.text = convertToRoman(days);
        'hours_txt.text = convertToRoman(hrs);
        'mins_txt.text = convertToRoman(min);
        'secs_txt.text = convertToRoman(sec);
    End Sub

End Class
