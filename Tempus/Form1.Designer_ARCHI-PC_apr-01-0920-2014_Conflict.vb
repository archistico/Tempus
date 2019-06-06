<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTempus
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTempus))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpArrivo = New System.Windows.Forms.DateTimePicker()
        Me.lbGiorni = New System.Windows.Forms.Label()
        Me.lbOre = New System.Windows.Forms.Label()
        Me.lbMinuti = New System.Windows.Forms.Label()
        Me.lbSecondi = New System.Windows.Forms.Label()
        Me.btParti = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtpPartenza = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data di arrivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Giorni"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(269, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ore"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Minuti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(751, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Secondi"
        '
        'dtpArrivo
        '
        Me.dtpArrivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpArrivo.CustomFormat = "dd/MM/yyyy - HH:mm"
        Me.dtpArrivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpArrivo.Location = New System.Drawing.Point(407, 112)
        Me.dtpArrivo.Name = "dtpArrivo"
        Me.dtpArrivo.Size = New System.Drawing.Size(173, 20)
        Me.dtpArrivo.TabIndex = 7
        Me.dtpArrivo.Value = New Date(2014, 3, 31, 21, 1, 0, 0)
        '
        'lbGiorni
        '
        Me.lbGiorni.AutoSize = True
        Me.lbGiorni.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGiorni.Location = New System.Drawing.Point(42, 319)
        Me.lbGiorni.Name = "lbGiorni"
        Me.lbGiorni.Size = New System.Drawing.Size(75, 33)
        Me.lbGiorni.TabIndex = 8
        Me.lbGiorni.Text = "XXX"
        '
        'lbOre
        '
        Me.lbOre.AutoSize = True
        Me.lbOre.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOre.Location = New System.Drawing.Point(267, 319)
        Me.lbOre.Name = "lbOre"
        Me.lbOre.Size = New System.Drawing.Size(75, 33)
        Me.lbOre.TabIndex = 9
        Me.lbOre.Text = "XXX"
        '
        'lbMinuti
        '
        Me.lbMinuti.AutoSize = True
        Me.lbMinuti.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMinuti.Location = New System.Drawing.Point(519, 319)
        Me.lbMinuti.Name = "lbMinuti"
        Me.lbMinuti.Size = New System.Drawing.Size(75, 33)
        Me.lbMinuti.TabIndex = 10
        Me.lbMinuti.Text = "XXX"
        '
        'lbSecondi
        '
        Me.lbSecondi.AutoSize = True
        Me.lbSecondi.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSecondi.Location = New System.Drawing.Point(749, 319)
        Me.lbSecondi.Name = "lbSecondi"
        Me.lbSecondi.Size = New System.Drawing.Size(75, 33)
        Me.lbSecondi.TabIndex = 11
        Me.lbSecondi.Text = "XXX"
        '
        'btParti
        '
        Me.btParti.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParti.Location = New System.Drawing.Point(12, 216)
        Me.btParti.Name = "btParti"
        Me.btParti.Size = New System.Drawing.Size(913, 48)
        Me.btParti.TabIndex = 12
        Me.btParti.Text = "ATTIVA IL CONTO ALLA ROVESCIA"
        Me.btParti.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'dtpPartenza
        '
        Me.dtpPartenza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpPartenza.CustomFormat = "dd/MM/yyyy - HH:mm"
        Me.dtpPartenza.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPartenza.Location = New System.Drawing.Point(407, 87)
        Me.dtpPartenza.Name = "dtpPartenza"
        Me.dtpPartenza.Size = New System.Drawing.Size(173, 20)
        Me.dtpPartenza.TabIndex = 14
        Me.dtpPartenza.Value = New Date(2014, 3, 31, 20, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Data di partenza"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "I - 1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "II - 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "III - 3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "IV - 4"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "V - 5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "VI - 6"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "VII - 7"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "VIII - 8"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "IX - 9"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "X - 10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "non esiste - 0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(116, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "XL - 40"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(116, 165)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "M - 1000"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(116, 151)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "CM - 900"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(116, 137)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "D - 500"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(116, 123)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(49, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "CD - 400"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(116, 109)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "C - 100"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(116, 95)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 13)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "XC - 90"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(116, 81)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 13)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "L - 50"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(725, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 190)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legenda"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(313, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(229, 33)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Imposta le date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tempus.My.Resources.Resources.Tempus
        Me.PictureBox1.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(350, 392)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(206, 16)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Copyright 2014 - Emilie Rollandin "
        '
        'frmTempus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 417)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpPartenza)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btParti)
        Me.Controls.Add(Me.lbSecondi)
        Me.Controls.Add(Me.lbMinuti)
        Me.Controls.Add(Me.lbOre)
        Me.Controls.Add(Me.lbGiorni)
        Me.Controls.Add(Me.dtpArrivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTempus"
        Me.Text = "Tempus - Archistico di Emilie Rollandin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpArrivo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbGiorni As System.Windows.Forms.Label
    Friend WithEvents lbOre As System.Windows.Forms.Label
    Friend WithEvents lbMinuti As System.Windows.Forms.Label
    Friend WithEvents lbSecondi As System.Windows.Forms.Label
    Friend WithEvents btParti As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dtpPartenza As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
