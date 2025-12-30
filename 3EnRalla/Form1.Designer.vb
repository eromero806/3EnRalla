<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnIniciar = New Button()
        Label0 = New Label()
        pnlLyo = New TableLayoutPanel()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        lblX = New Label()
        lblO = New Label()
        chk1jug = New CheckBox()
        chkO = New CheckBox()
        pnlLyo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = SystemColors.Control
        btnIniciar.BackgroundImageLayout = ImageLayout.None
        btnIniciar.Location = New Point(126, 40)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(207, 37)
        btnIniciar.TabIndex = 0
        btnIniciar.Text = "Inicia el Joc"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' Label0
        ' 
        Label0.BackColor = SystemColors.Control
        Label0.BorderStyle = BorderStyle.FixedSingle
        Label0.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label0.Location = New Point(6, 3)
        Label0.Name = "Label0"
        Label0.Size = New Size(84, 80)
        Label0.TabIndex = 1
        Label0.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLyo
        ' 
        pnlLyo.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        pnlLyo.ColumnCount = 3
        pnlLyo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 48.6486473F))
        pnlLyo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 51.3513527F))
        pnlLyo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 97F))
        pnlLyo.Controls.Add(Label8, 2, 2)
        pnlLyo.Controls.Add(Label7, 1, 2)
        pnlLyo.Controls.Add(Label6, 0, 2)
        pnlLyo.Controls.Add(Label4, 1, 1)
        pnlLyo.Controls.Add(Label3, 0, 1)
        pnlLyo.Controls.Add(Label2, 2, 0)
        pnlLyo.Controls.Add(Label1, 1, 0)
        pnlLyo.Controls.Add(Label0, 0, 0)
        pnlLyo.Controls.Add(Label5, 2, 1)
        pnlLyo.Enabled = False
        pnlLyo.Location = New Point(90, 100)
        pnlLyo.Margin = New Padding(0)
        pnlLyo.Name = "pnlLyo"
        pnlLyo.RowCount = 3
        pnlLyo.RowStyles.Add(New RowStyle(SizeType.Percent, 49.7076035F))
        pnlLyo.RowStyles.Add(New RowStyle(SizeType.Percent, 50.2923965F))
        pnlLyo.RowStyles.Add(New RowStyle(SizeType.Absolute, 89F))
        pnlLyo.Size = New Size(296, 263)
        pnlLyo.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.BackColor = SystemColors.Control
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(198, 170)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 90)
        Label8.TabIndex = 9
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = SystemColors.Control
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(99, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 90)
        Label7.TabIndex = 8
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.Control
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(6, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 90)
        Label6.TabIndex = 7
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = SystemColors.Control
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(99, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 81)
        Label4.TabIndex = 5
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.Control
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 81)
        Label3.TabIndex = 4
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.Control
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(198, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 80)
        Label2.TabIndex = 3
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Control
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(99, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 80)
        Label1.TabIndex = 2
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = SystemColors.Control
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 42F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(198, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 81)
        Label5.TabIndex = 6
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(3, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 15)
        Label9.TabIndex = 3
        Label9.Text = "Partides Guanyades"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 15)
        Label10.TabIndex = 4
        Label10.Text = "X:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(12, 62)
        Label11.Name = "Label11"
        Label11.Size = New Size(19, 15)
        Label11.TabIndex = 5
        Label11.Text = "O:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(48, 52)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 15)
        Label12.TabIndex = 6
        ' 
        ' lblX
        ' 
        lblX.AutoSize = True
        lblX.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblX.Location = New Point(36, 40)
        lblX.Name = "lblX"
        lblX.Size = New Size(14, 15)
        lblX.TabIndex = 7
        lblX.Text = "0"
        ' 
        ' lblO
        ' 
        lblO.AutoSize = True
        lblO.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblO.Location = New Point(36, 62)
        lblO.Name = "lblO"
        lblO.Size = New Size(14, 15)
        lblO.TabIndex = 8
        lblO.Text = "0"
        ' 
        ' chk1jug
        ' 
        chk1jug.AutoSize = True
        chk1jug.Location = New Point(361, 27)
        chk1jug.Name = "chk1jug"
        chk1jug.Size = New Size(77, 19)
        chk1jug.TabIndex = 9
        chk1jug.Text = "1 Jugador"
        chk1jug.UseVisualStyleBackColor = True
        ' 
        ' chkO
        ' 
        chkO.AutoSize = True
        chkO.Enabled = False
        chkO.Location = New Point(361, 52)
        chkO.Name = "chkO"
        chkO.Size = New Size(97, 19)
        chkO.TabIndex = 10
        chkO.Text = "Començar 2n"
        chkO.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(470, 424)
        Controls.Add(chkO)
        Controls.Add(chk1jug)
        Controls.Add(lblO)
        Controls.Add(lblX)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(pnlLyo)
        Controls.Add(btnIniciar)
        Name = "Form1"
        Text = "3 en Ralla"
        pnlLyo.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label0 As Label
    Friend WithEvents pnlLyo As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblO As Label
    Friend WithEvents chk1jug As CheckBox
    Friend WithEvents chkO As CheckBox

End Class
