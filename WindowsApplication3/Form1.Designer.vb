<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 複数検討作業処理ツール
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer
    'test
    'test
    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規作成NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前を付けて保存AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.separator = New System.Windows.Forms.ToolStripSeparator()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ウィンドウWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ｵﾌﾟｼｮﾝToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ﾍﾙﾌﾟHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "NDTファイル(*.ndt)|*.ndt|All Files (*.*)|*.*"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "SDRファイル(*.sdr)|*.ndt|All Files (*.*)|*.*"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集EToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ウィンドウWToolStripMenuItem, Me.ｵﾌﾟｼｮﾝToolStripMenuItem, Me.ﾍﾙﾌﾟHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成NToolStripMenuItem, Me.開くOToolStripMenuItem, Me.名前を付けて保存AToolStripMenuItem, Me.separator, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.ファイルFToolStripMenuItem.Text = "ﾌｧｲﾙ(&F)"
        '
        '新規作成NToolStripMenuItem
        '
        Me.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem"
        Me.新規作成NToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.新規作成NToolStripMenuItem.Text = "新規作成(&N)"
        '
        '開くOToolStripMenuItem
        '
        Me.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem"
        Me.開くOToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.開くOToolStripMenuItem.Text = "開く(&O)"
        '
        '名前を付けて保存AToolStripMenuItem
        '
        Me.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem"
        Me.名前を付けて保存AToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(&A)"
        '
        'separator
        '
        Me.separator.Name = "separator"
        Me.separator.Size = New System.Drawing.Size(187, 6)
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '編集EToolStripMenuItem
        '
        Me.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem"
        Me.編集EToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.編集EToolStripMenuItem.Text = "編集(&E)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        'ウィンドウWToolStripMenuItem
        '
        Me.ウィンドウWToolStripMenuItem.Name = "ウィンドウWToolStripMenuItem"
        Me.ウィンドウWToolStripMenuItem.Size = New System.Drawing.Size(78, 22)
        Me.ウィンドウWToolStripMenuItem.Text = "ｳｲﾝﾄﾞｳ(&W)"
        '
        'ｵﾌﾟｼｮﾝToolStripMenuItem
        '
        Me.ｵﾌﾟｼｮﾝToolStripMenuItem.Name = "ｵﾌﾟｼｮﾝToolStripMenuItem"
        Me.ｵﾌﾟｼｮﾝToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.ｵﾌﾟｼｮﾝToolStripMenuItem.Text = "ｵﾌﾟｼｮﾝ(&O)"
        '
        'ﾍﾙﾌﾟHToolStripMenuItem
        '
        Me.ﾍﾙﾌﾟHToolStripMenuItem.Name = "ﾍﾙﾌﾟHToolStripMenuItem"
        Me.ﾍﾙﾌﾟHToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.ﾍﾙﾌﾟHToolStripMenuItem.Text = "ﾍﾙﾌﾟ(&H)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "計算・印刷"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "解析ケース"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(198, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "照査パラメータ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(291, 29)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 27)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "断面"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(384, 29)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "着目点"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "解析データおよび解析結果ファイル名称"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(396, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "結果ファイル選択"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(315, 19)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(63, 164)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(315, 19)
        Me.TextBox2.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(396, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "連携ファイル選択"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "連携ファイル名称"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(78, 201)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 12)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "※結果ファイル選択"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(90, 219)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(452, 18)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "JRSNAP入力データ(.ndt)、および計算結果ファイルが保存されているフォルダを指定してください。"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(90, 257)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(452, 18)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Text = "基礎の安定計算用連携ファイル(.sdr)、ファイルが保存されているフォルダを指定してください。"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Location = New System.Drawing.Point(78, 239)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 12)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.Text = "※連携ファイル選択"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(530, 294)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 23)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "計算・印刷スタート"
        Me.Button8.UseVisualStyleBackColor = True
        '
        '複数検討作業処理ツール
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 342)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "複数検討作業処理ツール"
        Me.Text = "複数検討作業処理ツール"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 新規作成NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 開くOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 名前を付けて保存AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 編集EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ウィンドウWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ｵﾌﾟｼｮﾝToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub ウィンドウWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ウィンドウWToolStripMenuItem.Click

    End Sub
    Friend WithEvents ﾍﾙﾌﾟHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Private Sub OpenFileDialog2_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button

    Private Sub Button6_Click(ByVal sender As System.Object, e As System.EventArgs) Handles Button6.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Using sr As New System.IO.StreamReader(OpenFileDialog1.FileName, System.Text.Encoding.GetEncoding("Shift-jis"))
                Dim s As String
                s = OpenFileDialog1.FileName
                TextBox1.Text = System.IO.Path.GetFullPath(s)
            End Using
        End If
    End Sub

    Friend WithEvents Button7 As System.Windows.Forms.Button

    Private Sub Button7_Click(ByVal sender As System.Object, e As System.EventArgs) Handles Button7.Click
        OpenFileDialog2.InitialDirectory = "C:\"
        OpenFileDialog2.FileName = ""

        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Using sr As New System.IO.StreamReader(OpenFileDialog2.FileName, System.Text.Encoding.GetEncoding("Shift-jis"))
                Dim s As String
                s = OpenFileDialog2.FileName
                TextBox2.Text = System.IO.Path.GetFullPath(s)
            End Using
        End If
    End Sub

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub 複数検討作業処理ツール_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
