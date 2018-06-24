<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuSuaChua
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lMaPhieu = New System.Windows.Forms.Label()
        Me.lBienSo = New System.Windows.Forms.Label()
        Me.txtMaPhieu = New System.Windows.Forms.TextBox()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.lThanhTien = New System.Windows.Forms.Label()
        Me.cbTienCong = New System.Windows.Forms.ComboBox()
        Me.lTienCong = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.cbPhuTung = New System.Windows.Forms.ComboBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.lSoLuong = New System.Windows.Forms.Label()
        Me.lPhuTung = New System.Windows.Forms.Label()
        Me.lNoiDung = New System.Windows.Forms.Label()
        Me.lNgaySuaChua = New System.Windows.Forms.Label()
        Me.dtpNgaySuaChua = New System.Windows.Forms.DateTimePicker()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PHIẾU SỬA CHỮA"
        '
        'lMaPhieu
        '
        Me.lMaPhieu.AutoSize = True
        Me.lMaPhieu.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaPhieu.Location = New System.Drawing.Point(76, 85)
        Me.lMaPhieu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lMaPhieu.Name = "lMaPhieu"
        Me.lMaPhieu.Size = New System.Drawing.Size(90, 21)
        Me.lMaPhieu.TabIndex = 1
        Me.lMaPhieu.Text = "Mã phiếu:"
        '
        'lBienSo
        '
        Me.lBienSo.AutoSize = True
        Me.lBienSo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBienSo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lBienSo.Location = New System.Drawing.Point(501, 90)
        Me.lBienSo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lBienSo.Name = "lBienSo"
        Me.lBienSo.Size = New System.Drawing.Size(76, 21)
        Me.lBienSo.TabIndex = 2
        Me.lBienSo.Text = "Biển số: "
        '
        'txtMaPhieu
        '
        Me.txtMaPhieu.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaPhieu.Location = New System.Drawing.Point(187, 84)
        Me.txtMaPhieu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaPhieu.Name = "txtMaPhieu"
        Me.txtMaPhieu.Size = New System.Drawing.Size(240, 32)
        Me.txtMaPhieu.TabIndex = 3
        '
        'txtBienSo
        '
        Me.txtBienSo.Location = New System.Drawing.Point(588, 85)
        Me.txtBienSo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(240, 32)
        Me.txtBienSo.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtThanhTien)
        Me.Panel1.Controls.Add(Me.lThanhTien)
        Me.Panel1.Controls.Add(Me.cbTienCong)
        Me.Panel1.Controls.Add(Me.lTienCong)
        Me.Panel1.Controls.Add(Me.txtDonGia)
        Me.Panel1.Controls.Add(Me.cbPhuTung)
        Me.Panel1.Controls.Add(Me.txtSoLuong)
        Me.Panel1.Controls.Add(Me.txtNoiDung)
        Me.Panel1.Controls.Add(Me.lDonGia)
        Me.Panel1.Controls.Add(Me.lSoLuong)
        Me.Panel1.Controls.Add(Me.lPhuTung)
        Me.Panel1.Controls.Add(Me.lNoiDung)
        Me.Panel1.Location = New System.Drawing.Point(163, 170)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(727, 322)
        Me.Panel1.TabIndex = 6
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(143, 281)
        Me.txtThanhTien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(347, 32)
        Me.txtThanhTien.TabIndex = 18
        '
        'lThanhTien
        '
        Me.lThanhTien.AutoSize = True
        Me.lThanhTien.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lThanhTien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lThanhTien.Location = New System.Drawing.Point(27, 281)
        Me.lThanhTien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lThanhTien.Name = "lThanhTien"
        Me.lThanhTien.Size = New System.Drawing.Size(101, 21)
        Me.lThanhTien.TabIndex = 17
        Me.lThanhTien.Text = "Thành tiền:"
        '
        'cbTienCong
        '
        Me.cbTienCong.FormattingEnabled = True
        Me.cbTienCong.Location = New System.Drawing.Point(143, 228)
        Me.cbTienCong.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTienCong.Name = "cbTienCong"
        Me.cbTienCong.Size = New System.Drawing.Size(253, 28)
        Me.cbTienCong.TabIndex = 16
        '
        'lTienCong
        '
        Me.lTienCong.AutoSize = True
        Me.lTienCong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTienCong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lTienCong.Location = New System.Drawing.Point(29, 234)
        Me.lTienCong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTienCong.Name = "lTienCong"
        Me.lTienCong.Size = New System.Drawing.Size(96, 21)
        Me.lTienCong.TabIndex = 15
        Me.lTienCong.Text = "Tiền công:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(468, 176)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(253, 32)
        Me.txtDonGia.TabIndex = 14
        '
        'cbPhuTung
        '
        Me.cbPhuTung.FormattingEnabled = True
        Me.cbPhuTung.Location = New System.Drawing.Point(143, 134)
        Me.cbPhuTung.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPhuTung.Name = "cbPhuTung"
        Me.cbPhuTung.Size = New System.Drawing.Size(579, 28)
        Me.cbPhuTung.TabIndex = 13
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(143, 176)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(145, 32)
        Me.txtSoLuong.TabIndex = 12
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(143, 17)
        Me.txtNoiDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoiDung.Multiline = True
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(579, 94)
        Me.txtNoiDung.TabIndex = 11
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDonGia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lDonGia.Location = New System.Drawing.Point(384, 177)
        Me.lDonGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(80, 21)
        Me.lDonGia.TabIndex = 10
        Me.lDonGia.Text = "Đơn giá:"
        '
        'lSoLuong
        '
        Me.lSoLuong.AutoSize = True
        Me.lSoLuong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSoLuong.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lSoLuong.Location = New System.Drawing.Point(27, 176)
        Me.lSoLuong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lSoLuong.Name = "lSoLuong"
        Me.lSoLuong.Size = New System.Drawing.Size(90, 21)
        Me.lSoLuong.TabIndex = 9
        Me.lSoLuong.Text = "Số lượng: "
        '
        'lPhuTung
        '
        Me.lPhuTung.AutoSize = True
        Me.lPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPhuTung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lPhuTung.Location = New System.Drawing.Point(27, 134)
        Me.lPhuTung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lPhuTung.Name = "lPhuTung"
        Me.lPhuTung.Size = New System.Drawing.Size(90, 21)
        Me.lPhuTung.TabIndex = 8
        Me.lPhuTung.Text = "Phụ tùng: "
        '
        'lNoiDung
        '
        Me.lNoiDung.AutoSize = True
        Me.lNoiDung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNoiDung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lNoiDung.Location = New System.Drawing.Point(27, 17)
        Me.lNoiDung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNoiDung.Name = "lNoiDung"
        Me.lNoiDung.Size = New System.Drawing.Size(89, 21)
        Me.lNoiDung.TabIndex = 7
        Me.lNoiDung.Text = "Nội dung:"
        '
        'lNgaySuaChua
        '
        Me.lNgaySuaChua.AutoSize = True
        Me.lNgaySuaChua.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNgaySuaChua.Location = New System.Drawing.Point(293, 138)
        Me.lNgaySuaChua.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNgaySuaChua.Name = "lNgaySuaChua"
        Me.lNgaySuaChua.Size = New System.Drawing.Size(133, 21)
        Me.lNgaySuaChua.TabIndex = 7
        Me.lNgaySuaChua.Text = "Ngày sửa chữa:"
        '
        'dtpNgaySuaChua
        '
        Me.dtpNgaySuaChua.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySuaChua.Location = New System.Drawing.Point(447, 138)
        Me.dtpNgaySuaChua.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySuaChua.Name = "dtpNgaySuaChua"
        Me.dtpNgaySuaChua.Size = New System.Drawing.Size(265, 32)
        Me.dtpNgaySuaChua.TabIndex = 8
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(344, 545)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(135, 53)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDong.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(518, 545)
        Me.btnDong.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(135, 53)
        Me.btnDong.TabIndex = 10
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'frmPhieuSuaChua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 645)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dtpNgaySuaChua)
        Me.Controls.Add(Me.lNgaySuaChua)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.txtMaPhieu)
        Me.Controls.Add(Me.lBienSo)
        Me.Controls.Add(Me.lMaPhieu)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPhieuSuaChua"
        Me.Text = "Phiếu Sửa Chữa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lMaPhieu As Label
    Friend WithEvents lBienSo As Label
    Friend WithEvents txtMaPhieu As TextBox
    Friend WithEvents txtBienSo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lDonGia As Label
    Friend WithEvents lSoLuong As Label
    Friend WithEvents lPhuTung As Label
    Friend WithEvents lNoiDung As Label
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents lThanhTien As Label
    Friend WithEvents cbTienCong As ComboBox
    Friend WithEvents lTienCong As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents cbPhuTung As ComboBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents lNgaySuaChua As Label
    Friend WithEvents dtpNgaySuaChua As DateTimePicker
    Friend WithEvents btnThem As Button
    Friend WithEvents btnDong As Button
End Class
