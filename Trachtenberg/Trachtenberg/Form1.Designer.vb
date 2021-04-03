<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.德氏速乘法ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.速乘法練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.個十積練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.德氏速除法ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.速除法練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.數十積練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.個位積練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.德氏平方法ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.平方練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.橫積練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.德氏開平方根ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開平方根練習ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.離開ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文字一Label = New System.Windows.Forms.Label()
        Me.位數一TextBox = New System.Windows.Forms.TextBox()
        Me.文字二Label = New System.Windows.Forms.Label()
        Me.位數二TextBox = New System.Windows.Forms.TextBox()
        Me.文字三Label = New System.Windows.Forms.Label()
        Me.文字四Label = New System.Windows.Forms.Label()
        Me.文字五Label = New System.Windows.Forms.Label()
        Me.位數三ComboBox = New System.Windows.Forms.ComboBox()
        Me.文字六Label = New System.Windows.Forms.Label()
        Me.文字七Label = New System.Windows.Forms.Label()
        Me.位數四TextBox = New System.Windows.Forms.TextBox()
        Me.文字八Label = New System.Windows.Forms.Label()
        Me.計時器Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.計算紙RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.產生算式Button = New System.Windows.Forms.Button()
        Me.算式Label = New System.Windows.Forms.Label()
        Me.作答TextBox = New System.Windows.Forms.TextBox()
        Me.計算紙Label = New System.Windows.Forms.Label()
        Me.作答完畢Button = New System.Windows.Forms.Button()
        Me.歸零Button = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.德氏速乘法ToolStripMenuItem, Me.德氏速除法ToolStripMenuItem, Me.德氏平方法ToolStripMenuItem, Me.德氏開平方根ToolStripMenuItem, Me.離開ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '德氏速乘法ToolStripMenuItem
        '
        Me.德氏速乘法ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.速乘法練習ToolStripMenuItem, Me.個十積練習ToolStripMenuItem})
        Me.德氏速乘法ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.德氏速乘法ToolStripMenuItem.Name = "德氏速乘法ToolStripMenuItem"
        Me.德氏速乘法ToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.德氏速乘法ToolStripMenuItem.Text = "德氏速乘法"
        '
        '速乘法練習ToolStripMenuItem
        '
        Me.速乘法練習ToolStripMenuItem.Name = "速乘法練習ToolStripMenuItem"
        Me.速乘法練習ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.速乘法練習ToolStripMenuItem.Text = "速乘法練習"
        '
        '個十積練習ToolStripMenuItem
        '
        Me.個十積練習ToolStripMenuItem.Name = "個十積練習ToolStripMenuItem"
        Me.個十積練習ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.個十積練習ToolStripMenuItem.Text = "個十積練習"
        '
        '德氏速除法ToolStripMenuItem
        '
        Me.德氏速除法ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.速除法練習ToolStripMenuItem, Me.數十積練習ToolStripMenuItem, Me.個位積練習ToolStripMenuItem})
        Me.德氏速除法ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.德氏速除法ToolStripMenuItem.Name = "德氏速除法ToolStripMenuItem"
        Me.德氏速除法ToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.德氏速除法ToolStripMenuItem.Text = "德氏速除法"
        '
        '速除法練習ToolStripMenuItem
        '
        Me.速除法練習ToolStripMenuItem.Name = "速除法練習ToolStripMenuItem"
        Me.速除法練習ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.速除法練習ToolStripMenuItem.Text = "速除法練習"
        '
        '數十積練習ToolStripMenuItem
        '
        Me.數十積練習ToolStripMenuItem.Name = "數十積練習ToolStripMenuItem"
        Me.數十積練習ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.數十積練習ToolStripMenuItem.Text = "數十積練習"
        '
        '個位積練習ToolStripMenuItem
        '
        Me.個位積練習ToolStripMenuItem.Name = "個位積練習ToolStripMenuItem"
        Me.個位積練習ToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.個位積練習ToolStripMenuItem.Text = "個位積練習"
        '
        '德氏平方法ToolStripMenuItem
        '
        Me.德氏平方法ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.平方練習ToolStripMenuItem, Me.橫積練習ToolStripMenuItem})
        Me.德氏平方法ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.德氏平方法ToolStripMenuItem.Name = "德氏平方法ToolStripMenuItem"
        Me.德氏平方法ToolStripMenuItem.Size = New System.Drawing.Size(96, 23)
        Me.德氏平方法ToolStripMenuItem.Text = "德氏平方法"
        '
        '平方練習ToolStripMenuItem
        '
        Me.平方練習ToolStripMenuItem.Name = "平方練習ToolStripMenuItem"
        Me.平方練習ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.平方練習ToolStripMenuItem.Text = "平方練習"
        '
        '橫積練習ToolStripMenuItem
        '
        Me.橫積練習ToolStripMenuItem.Name = "橫積練習ToolStripMenuItem"
        Me.橫積練習ToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.橫積練習ToolStripMenuItem.Text = "橫積練習"
        '
        '德氏開平方根ToolStripMenuItem
        '
        Me.德氏開平方根ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開平方根練習ToolStripMenuItem})
        Me.德氏開平方根ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.德氏開平方根ToolStripMenuItem.Name = "德氏開平方根ToolStripMenuItem"
        Me.德氏開平方根ToolStripMenuItem.Size = New System.Drawing.Size(111, 23)
        Me.德氏開平方根ToolStripMenuItem.Text = "德氏開平方根"
        '
        '開平方根練習ToolStripMenuItem
        '
        Me.開平方根練習ToolStripMenuItem.Name = "開平方根練習ToolStripMenuItem"
        Me.開平方根練習ToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.開平方根練習ToolStripMenuItem.Text = "開平方根練習"
        '
        '離開ToolStripMenuItem
        '
        Me.離開ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem"
        Me.離開ToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.離開ToolStripMenuItem.Text = "離開"
        '
        '文字一Label
        '
        Me.文字一Label.AutoSize = True
        Me.文字一Label.Enabled = False
        Me.文字一Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字一Label.Location = New System.Drawing.Point(2, 34)
        Me.文字一Label.Name = "文字一Label"
        Me.文字一Label.Size = New System.Drawing.Size(67, 15)
        Me.文字一Label.TabIndex = 2
        Me.文字一Label.Text = "隨機產生"
        '
        '位數一TextBox
        '
        Me.位數一TextBox.Enabled = False
        Me.位數一TextBox.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.位數一TextBox.Location = New System.Drawing.Point(66, 31)
        Me.位數一TextBox.Name = "位數一TextBox"
        Me.位數一TextBox.Size = New System.Drawing.Size(26, 25)
        Me.位數一TextBox.TabIndex = 3
        '
        '文字二Label
        '
        Me.文字二Label.AutoSize = True
        Me.文字二Label.Enabled = False
        Me.文字二Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字二Label.Location = New System.Drawing.Point(92, 34)
        Me.文字二Label.Name = "文字二Label"
        Me.文字二Label.Size = New System.Drawing.Size(67, 15)
        Me.文字二Label.TabIndex = 4
        Me.文字二Label.Text = "位數乘以"
        '
        '位數二TextBox
        '
        Me.位數二TextBox.Enabled = False
        Me.位數二TextBox.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.位數二TextBox.Location = New System.Drawing.Point(153, 31)
        Me.位數二TextBox.Name = "位數二TextBox"
        Me.位數二TextBox.Size = New System.Drawing.Size(26, 25)
        Me.位數二TextBox.TabIndex = 5
        '
        '文字三Label
        '
        Me.文字三Label.AutoSize = True
        Me.文字三Label.Enabled = False
        Me.文字三Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字三Label.Location = New System.Drawing.Point(174, 34)
        Me.文字三Label.Name = "文字三Label"
        Me.文字三Label.Size = New System.Drawing.Size(82, 15)
        Me.文字三Label.TabIndex = 6
        Me.文字三Label.Text = "位數的算式"
        '
        '文字四Label
        '
        Me.文字四Label.AutoSize = True
        Me.文字四Label.Enabled = False
        Me.文字四Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字四Label.Location = New System.Drawing.Point(2, 59)
        Me.文字四Label.Name = "文字四Label"
        Me.文字四Label.Size = New System.Drawing.Size(187, 15)
        Me.文字四Label.TabIndex = 7
        Me.文字四Label.Text = "隨機產生一個個十積的算式"
        '
        '文字五Label
        '
        Me.文字五Label.AutoSize = True
        Me.文字五Label.Enabled = False
        Me.文字五Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字五Label.Location = New System.Drawing.Point(2, 85)
        Me.文字五Label.Name = "文字五Label"
        Me.文字五Label.Size = New System.Drawing.Size(67, 15)
        Me.文字五Label.TabIndex = 8
        Me.文字五Label.Text = "隨機產生"
        '
        '位數三ComboBox
        '
        Me.位數三ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.位數三ComboBox.Enabled = False
        Me.位數三ComboBox.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.位數三ComboBox.FormattingEnabled = True
        Me.位數三ComboBox.Items.AddRange(New Object() {"2", "3"})
        Me.位數三ComboBox.Location = New System.Drawing.Point(66, 82)
        Me.位數三ComboBox.Name = "位數三ComboBox"
        Me.位數三ComboBox.Size = New System.Drawing.Size(33, 23)
        Me.位數三ComboBox.TabIndex = 9
        '
        '文字六Label
        '
        Me.文字六Label.AutoSize = True
        Me.文字六Label.Enabled = False
        Me.文字六Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字六Label.Location = New System.Drawing.Point(92, 85)
        Me.文字六Label.Name = "文字六Label"
        Me.文字六Label.Size = New System.Drawing.Size(97, 15)
        Me.文字六Label.TabIndex = 10
        Me.文字六Label.Text = "位數的平方式"
        '
        '文字七Label
        '
        Me.文字七Label.AutoSize = True
        Me.文字七Label.Enabled = False
        Me.文字七Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字七Label.Location = New System.Drawing.Point(2, 113)
        Me.文字七Label.Name = "文字七Label"
        Me.文字七Label.Size = New System.Drawing.Size(67, 15)
        Me.文字七Label.TabIndex = 11
        Me.文字七Label.Text = "隨機產生"
        '
        '位數四TextBox
        '
        Me.位數四TextBox.Enabled = False
        Me.位數四TextBox.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.位數四TextBox.Location = New System.Drawing.Point(66, 110)
        Me.位數四TextBox.Name = "位數四TextBox"
        Me.位數四TextBox.Size = New System.Drawing.Size(26, 25)
        Me.位數四TextBox.TabIndex = 12
        '
        '文字八Label
        '
        Me.文字八Label.AutoSize = True
        Me.文字八Label.Enabled = False
        Me.文字八Label.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.文字八Label.Location = New System.Drawing.Point(92, 113)
        Me.文字八Label.Name = "文字八Label"
        Me.文字八Label.Size = New System.Drawing.Size(112, 15)
        Me.文字八Label.TabIndex = 13
        Me.文字八Label.Text = "位數的平方根式"
        '
        '計時器Label
        '
        Me.計時器Label.AutoSize = True
        Me.計時器Label.Enabled = False
        Me.計時器Label.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.計時器Label.Location = New System.Drawing.Point(343, 27)
        Me.計時器Label.Name = "計時器Label"
        Me.計時器Label.Size = New System.Drawing.Size(242, 64)
        Me.計時器Label.TabIndex = 14
        Me.計時器Label.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        '計算紙RichTextBox
        '
        Me.計算紙RichTextBox.Location = New System.Drawing.Point(2, 264)
        Me.計算紙RichTextBox.Name = "計算紙RichTextBox"
        Me.計算紙RichTextBox.Size = New System.Drawing.Size(580, 168)
        Me.計算紙RichTextBox.TabIndex = 15
        Me.計算紙RichTextBox.Text = ""
        '
        '產生算式Button
        '
        Me.產生算式Button.Enabled = False
        Me.產生算式Button.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.產生算式Button.Location = New System.Drawing.Point(5, 141)
        Me.產生算式Button.Name = "產生算式Button"
        Me.產生算式Button.Size = New System.Drawing.Size(140, 50)
        Me.產生算式Button.TabIndex = 16
        Me.產生算式Button.Text = "產生算式"
        Me.產生算式Button.UseVisualStyleBackColor = True
        '
        '算式Label
        '
        Me.算式Label.AutoSize = True
        Me.算式Label.Enabled = False
        Me.算式Label.Font = New System.Drawing.Font("新細明體", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.算式Label.Location = New System.Drawing.Point(4, 194)
        Me.算式Label.Name = "算式Label"
        Me.算式Label.Size = New System.Drawing.Size(252, 17)
        Me.算式Label.TabIndex = 10
        Me.算式Label.Tag = "  "
        Me.算式Label.Text = "                                                             "
        Me.算式Label.Visible = False
        '
        '作答TextBox
        '
        Me.作答TextBox.Enabled = False
        Me.作答TextBox.Font = New System.Drawing.Font("新細明體", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.作答TextBox.Location = New System.Drawing.Point(5, 214)
        Me.作答TextBox.Name = "作答TextBox"
        Me.作答TextBox.Size = New System.Drawing.Size(270, 28)
        Me.作答TextBox.TabIndex = 17
        '
        '計算紙Label
        '
        Me.計算紙Label.AutoSize = True
        Me.計算紙Label.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.計算紙Label.Location = New System.Drawing.Point(2, 245)
        Me.計算紙Label.Name = "計算紙Label"
        Me.計算紙Label.Size = New System.Drawing.Size(72, 16)
        Me.計算紙Label.TabIndex = 18
        Me.計算紙Label.Text = "計算紙："
        '
        '作答完畢Button
        '
        Me.作答完畢Button.Enabled = False
        Me.作答完畢Button.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.作答完畢Button.Location = New System.Drawing.Point(290, 192)
        Me.作答完畢Button.Name = "作答完畢Button"
        Me.作答完畢Button.Size = New System.Drawing.Size(140, 50)
        Me.作答完畢Button.TabIndex = 19
        Me.作答完畢Button.Text = "作答完畢"
        Me.作答完畢Button.UseVisualStyleBackColor = True
        '
        '歸零Button
        '
        Me.歸零Button.Enabled = False
        Me.歸零Button.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.歸零Button.Location = New System.Drawing.Point(445, 192)
        Me.歸零Button.Name = "歸零Button"
        Me.歸零Button.Size = New System.Drawing.Size(140, 50)
        Me.歸零Button.TabIndex = 20
        Me.歸零Button.Text = "歸零"
        Me.歸零Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 435)
        Me.Controls.Add(Me.歸零Button)
        Me.Controls.Add(Me.作答完畢Button)
        Me.Controls.Add(Me.計算紙Label)
        Me.Controls.Add(Me.作答TextBox)
        Me.Controls.Add(Me.算式Label)
        Me.Controls.Add(Me.產生算式Button)
        Me.Controls.Add(Me.計算紙RichTextBox)
        Me.Controls.Add(Me.計時器Label)
        Me.Controls.Add(Me.文字八Label)
        Me.Controls.Add(Me.位數四TextBox)
        Me.Controls.Add(Me.文字七Label)
        Me.Controls.Add(Me.文字六Label)
        Me.Controls.Add(Me.位數三ComboBox)
        Me.Controls.Add(Me.文字五Label)
        Me.Controls.Add(Me.文字四Label)
        Me.Controls.Add(Me.文字三Label)
        Me.Controls.Add(Me.位數二TextBox)
        Me.Controls.Add(Me.文字二Label)
        Me.Controls.Add(Me.位數一TextBox)
        Me.Controls.Add(Me.文字一Label)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "德氏高速算術練習 v2.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 德氏速乘法ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 速乘法練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 個十積練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 德氏速除法ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 速除法練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 數十積練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 個位積練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 德氏平方法ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 平方練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 橫積練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 德氏開平方根ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開平方根練習ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 離開ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 文字一Label As Label
    Friend WithEvents 位數一TextBox As TextBox
    Friend WithEvents 文字二Label As Label
    Friend WithEvents 位數二TextBox As TextBox
    Friend WithEvents 文字三Label As Label
    Friend WithEvents 文字四Label As Label
    Friend WithEvents 文字五Label As Label
    Friend WithEvents 位數三ComboBox As ComboBox
    Friend WithEvents 文字六Label As Label
    Friend WithEvents 文字七Label As Label
    Friend WithEvents 位數四TextBox As TextBox
    Friend WithEvents 文字八Label As Label
    Friend WithEvents 計時器Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 計算紙RichTextBox As RichTextBox
    Friend WithEvents 產生算式Button As Button
    Friend WithEvents 算式Label As Label
    Friend WithEvents 作答TextBox As TextBox
    Friend WithEvents 計算紙Label As Label
    Friend WithEvents 作答完畢Button As Button
    Friend WithEvents 歸零Button As Button

End Class
