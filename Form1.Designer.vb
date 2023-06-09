<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Supplies = New GroupBox()
        txtsearch = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        btnremove = New Button()
        txtrs = New TextBox()
        datepicker = New DateTimePicker()
        Label4 = New Label()
        txtrqty = New TextBox()
        btncancel = New Button()
        Label2 = New Label()
        btnclear = New Button()
        txtrby = New TextBox()
        btnsubmit = New Button()
        Label5 = New Label()
        txtline = New TextBox()
        Label8 = New Label()
        DataGridView2 = New DataGridView()
        btnsubmit2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Supplies.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(628, 256)
        DataGridView1.TabIndex = 0
        ' 
        ' Supplies
        ' 
        Supplies.Controls.Add(txtsearch)
        Supplies.Controls.Add(Label1)
        Supplies.Controls.Add(DataGridView1)
        Supplies.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Supplies.Location = New Point(12, 12)
        Supplies.Name = "Supplies"
        Supplies.Size = New Size(640, 337)
        Supplies.TabIndex = 2
        Supplies.TabStop = False
        Supplies.Text = "Supplies"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(186, 37)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(448, 32)
        txtsearch.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 23)
        Label1.TabIndex = 0
        Label1.Text = "Material"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnremove)
        GroupBox1.Controls.Add(txtrs)
        GroupBox1.Controls.Add(datepicker)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtrqty)
        GroupBox1.Controls.Add(btncancel)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnclear)
        GroupBox1.Controls.Add(txtrby)
        GroupBox1.Controls.Add(btnsubmit)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtline)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 355)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(640, 322)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Requestition Form"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(42, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 23)
        Label3.TabIndex = 16
        Label3.Text = "RS Number"
        ' 
        ' btnremove
        ' 
        btnremove.Location = New Point(432, 255)
        btnremove.Name = "btnremove"
        btnremove.Size = New Size(114, 44)
        btnremove.TabIndex = 17
        btnremove.Text = "REMOVE"
        btnremove.UseVisualStyleBackColor = True
        ' 
        ' txtrs
        ' 
        txtrs.BackColor = SystemColors.HighlightText
        txtrs.Enabled = False
        txtrs.ForeColor = Color.Black
        txtrs.Location = New Point(249, 66)
        txtrs.Name = "txtrs"
        txtrs.Size = New Size(337, 32)
        txtrs.TabIndex = 15
        ' 
        ' datepicker
        ' 
        datepicker.CalendarMonthBackground = SystemColors.MenuBar
        datepicker.Location = New Point(249, 31)
        datepicker.Name = "datepicker"
        datepicker.Size = New Size(337, 32)
        datepicker.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(43, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 23)
        Label4.TabIndex = 13
        Label4.Text = "Date"
        ' 
        ' txtrqty
        ' 
        txtrqty.BackColor = SystemColors.Window
        txtrqty.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtrqty.Location = New Point(249, 133)
        txtrqty.Name = "txtrqty"
        txtrqty.Size = New Size(337, 41)
        txtrqty.TabIndex = 12
        ' 
        ' btncancel
        ' 
        btncancel.Location = New Point(312, 255)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(114, 44)
        btncancel.TabIndex = 10
        btncancel.Text = "CANCEL"
        btncancel.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(43, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 23)
        Label2.TabIndex = 11
        Label2.Text = "Line/Department"
        ' 
        ' btnclear
        ' 
        btnclear.Location = New Point(192, 255)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(114, 44)
        btnclear.TabIndex = 9
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' txtrby
        ' 
        txtrby.BackColor = SystemColors.Window
        txtrby.Location = New Point(249, 176)
        txtrby.Multiline = True
        txtrby.Name = "txtrby"
        txtrby.Size = New Size(337, 65)
        txtrby.TabIndex = 6
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Location = New Point(72, 255)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(114, 44)
        btnsubmit.TabIndex = 8
        btnsubmit.Text = "SUBMIT"
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(42, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 23)
        Label5.TabIndex = 5
        Label5.Text = "Requested By"
        ' 
        ' txtline
        ' 
        txtline.BackColor = SystemColors.Window
        txtline.Location = New Point(249, 100)
        txtline.Name = "txtline"
        txtline.Size = New Size(337, 32)
        txtline.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(43, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(157, 23)
        Label8.TabIndex = 0
        Label8.Text = "Requested Qty"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(658, 12)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(1128, 624)
        DataGridView2.TabIndex = 10
        ' 
        ' btnsubmit2
        ' 
        btnsubmit2.Location = New Point(1672, 637)
        btnsubmit2.Name = "btnsubmit2"
        btnsubmit2.Size = New Size(114, 44)
        btnsubmit2.TabIndex = 17
        btnsubmit2.Text = "SUBMIT"
        btnsubmit2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(1798, 686)
        Controls.Add(btnsubmit2)
        Controls.Add(DataGridView2)
        Controls.Add(GroupBox1)
        Controls.Add(Supplies)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Office Supplies Request"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Supplies.ResumeLayout(False)
        Supplies.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Supplies As GroupBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtrby As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtline As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents datepicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrqty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrs As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnsubmit2 As Button
    Friend WithEvents btnremove As Button
End Class
