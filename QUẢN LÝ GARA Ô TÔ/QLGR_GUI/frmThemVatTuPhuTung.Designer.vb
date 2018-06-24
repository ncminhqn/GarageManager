<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemVatTuPhuTung
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
        Me.lMaLoaiPhuTung = New System.Windows.Forms.Label()
        Me.lTenLoaiPhuTung = New System.Windows.Forms.Label()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.lSoLuong = New System.Windows.Forms.Label()
        Me.txtMaLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnThemVaDong = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lMaLoaiPhuTung
        '
        Me.lMaLoaiPhuTung.AutoSize = True
        Me.lMaLoaiPhuTung.Location = New System.Drawing.Point(70, 94)
        Me.lMaLoaiPhuTung.Name = "lMaLoaiPhuTung"
        Me.lMaLoaiPhuTung.Size = New System.Drawing.Size(134, 17)
        Me.lMaLoaiPhuTung.TabIndex = 0
        Me.lMaLoaiPhuTung.Text = "Tên Loại Phụ Tùng:"
        '
        'lTenLoaiPhuTung
        '
        Me.lTenLoaiPhuTung.AutoSize = True
        Me.lTenLoaiPhuTung.Location = New System.Drawing.Point(70, 46)
        Me.lTenLoaiPhuTung.Name = "lTenLoaiPhuTung"
        Me.lTenLoaiPhuTung.Size = New System.Drawing.Size(128, 17)
        Me.lTenLoaiPhuTung.TabIndex = 1
        Me.lTenLoaiPhuTung.Text = "Mã Loại Phụ Tùng:"
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.Location = New System.Drawing.Point(70, 148)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(64, 17)
        Me.lDonGia.TabIndex = 2
        Me.lDonGia.Text = "Đơn Giá:"
        '
        'lSoLuong
        '
        Me.lSoLuong.AutoSize = True
        Me.lSoLuong.Location = New System.Drawing.Point(70, 198)
        Me.lSoLuong.Name = "lSoLuong"
        Me.lSoLuong.Size = New System.Drawing.Size(73, 17)
        Me.lSoLuong.TabIndex = 3
        Me.lSoLuong.Text = "Số Lượng:"
        '
        'txtMaLoaiPhuTung
        '
        Me.txtMaLoaiPhuTung.Location = New System.Drawing.Point(253, 43)
        Me.txtMaLoaiPhuTung.Name = "txtMaLoaiPhuTung"
        Me.txtMaLoaiPhuTung.ReadOnly = True
        Me.txtMaLoaiPhuTung.Size = New System.Drawing.Size(185, 22)
        Me.txtMaLoaiPhuTung.TabIndex = 4
        '
        'txtTenLoaiPhuTung
        '
        Me.txtTenLoaiPhuTung.Location = New System.Drawing.Point(253, 91)
        Me.txtTenLoaiPhuTung.Name = "txtTenLoaiPhuTung"
        Me.txtTenLoaiPhuTung.Size = New System.Drawing.Size(203, 22)
        Me.txtTenLoaiPhuTung.TabIndex = 5
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(253, 145)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(185, 22)
        Me.txtDonGia.TabIndex = 6
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(253, 195)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(185, 22)
        Me.txtSoLuong.TabIndex = 7
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(102, 245)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(100, 28)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Text = "THÊM"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.Location = New System.Drawing.Point(307, 245)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(162, 28)
        Me.btnThemVaDong.TabIndex = 9
        Me.btnThemVaDong.Text = "THÊM VÀ ĐÓNG"
        Me.btnThemVaDong.UseVisualStyleBackColor = True
        '
        'frmThemVatTuPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 309)
        Me.Controls.Add(Me.btnThemVaDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtTenLoaiPhuTung)
        Me.Controls.Add(Me.txtMaLoaiPhuTung)
        Me.Controls.Add(Me.lSoLuong)
        Me.Controls.Add(Me.lDonGia)
        Me.Controls.Add(Me.lTenLoaiPhuTung)
        Me.Controls.Add(Me.lMaLoaiPhuTung)
        Me.Name = "frmThemVatTuPhuTung"
        Me.Text = "Thêm Vật Tư Phụ Tùng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lMaLoaiPhuTung As Label
    Friend WithEvents lTenLoaiPhuTung As Label
    Friend WithEvents lDonGia As Label
    Friend WithEvents lSoLuong As Label
    Friend WithEvents txtMaLoaiPhuTung As TextBox
    Friend WithEvents txtTenLoaiPhuTung As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnThemVaDong As Button
End Class
