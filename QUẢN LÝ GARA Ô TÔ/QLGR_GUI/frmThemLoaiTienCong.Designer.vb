<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemLoaiTienCong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lMaLoai = New System.Windows.Forms.Label()
        Me.lTenLoai = New System.Windows.Forms.Label()
        Me.lMucTien = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.txtMucTien = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThemVaDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lMaLoai
        '
        Me.lMaLoai.AutoSize = True
        Me.lMaLoai.Location = New System.Drawing.Point(130, 48)
        Me.lMaLoai.Name = "lMaLoai"
        Me.lMaLoai.Size = New System.Drawing.Size(62, 17)
        Me.lMaLoai.TabIndex = 0
        Me.lMaLoai.Text = "Mã Loại:"
        '
        'lTenLoai
        '
        Me.lTenLoai.AutoSize = True
        Me.lTenLoai.Location = New System.Drawing.Point(130, 102)
        Me.lTenLoai.Name = "lTenLoai"
        Me.lTenLoai.Size = New System.Drawing.Size(68, 17)
        Me.lTenLoai.TabIndex = 1
        Me.lTenLoai.Text = "Tên Loại:"
        '
        'lMucTien
        '
        Me.lMucTien.AutoSize = True
        Me.lMucTien.Location = New System.Drawing.Point(130, 155)
        Me.lMucTien.Name = "lMucTien"
        Me.lMucTien.Size = New System.Drawing.Size(70, 17)
        Me.lMucTien.TabIndex = 2
        Me.lMucTien.Text = "Mức Tiền:"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaLoai.Location = New System.Drawing.Point(232, 45)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(133, 22)
        Me.txtMaLoai.TabIndex = 3
        Me.txtMaLoai.WordWrap = False
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(232, 99)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(192, 22)
        Me.txtTenLoai.TabIndex = 4
        '
        'txtMucTien
        '
        Me.txtMucTien.Location = New System.Drawing.Point(232, 152)
        Me.txtMucTien.Name = "txtMucTien"
        Me.txtMucTien.Size = New System.Drawing.Size(192, 22)
        Me.txtMucTien.TabIndex = 5
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(161, 213)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 28)
        Me.btnThem.TabIndex = 15
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(335, 216)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(129, 28)
        Me.btnThemVaDong.TabIndex = 16
        Me.btnThemVaDong.Text = "Thêm Và Đóng"
        Me.btnThemVaDong.UseVisualStyleBackColor = True
        '
        'frmThemLoaiTienCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 286)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtMucTien)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.lMucTien)
        Me.Controls.Add(Me.lTenLoai)
        Me.Controls.Add(Me.lMaLoai)
        Me.Name = "frmThemLoaiTienCong"
        Me.Text = "Thêm Loại Tiền Công"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lMaLoai As Label
    Friend WithEvents lTenLoai As Label
    Friend WithEvents lMucTien As Label
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents txtMucTien As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnThemVaDong As Button
End Class
