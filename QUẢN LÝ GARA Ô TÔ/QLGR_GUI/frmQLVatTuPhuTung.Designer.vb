<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLVatTuPhuTung
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lMaPhuTung = New System.Windows.Forms.Label()
        Me.dgvDanhSachPhuTung = New System.Windows.Forms.DataGridView()
        Me.lTenPhuTung = New System.Windows.Forms.Label()
        Me.lSoLuong = New System.Windows.Forms.Label()
        Me.lDonGia = New System.Windows.Forms.Label()
        Me.txtMaLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiPhuTung = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ VẬT TƯ PHỤ TÙNG"
        '
        'lMaPhuTung
        '
        Me.lMaPhuTung.AutoSize = True
        Me.lMaPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaPhuTung.Location = New System.Drawing.Point(763, 126)
        Me.lMaPhuTung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lMaPhuTung.Name = "lMaPhuTung"
        Me.lMaPhuTung.Size = New System.Drawing.Size(152, 21)
        Me.lMaPhuTung.TabIndex = 1
        Me.lMaPhuTung.Text = "Mã loại phụ tùng:"
        '
        'dgvDanhSachPhuTung
        '
        Me.dgvDanhSachPhuTung.AllowUserToAddRows = False
        Me.dgvDanhSachPhuTung.AllowUserToDeleteRows = False
        Me.dgvDanhSachPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDanhSachPhuTung.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDanhSachPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachPhuTung.Location = New System.Drawing.Point(16, 84)
        Me.dgvDanhSachPhuTung.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDanhSachPhuTung.MultiSelect = False
        Me.dgvDanhSachPhuTung.Name = "dgvDanhSachPhuTung"
        Me.dgvDanhSachPhuTung.ReadOnly = True
        Me.dgvDanhSachPhuTung.RowHeadersVisible = False
        Me.dgvDanhSachPhuTung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachPhuTung.Size = New System.Drawing.Size(599, 512)
        Me.dgvDanhSachPhuTung.TabIndex = 2
        '
        'lTenPhuTung
        '
        Me.lTenPhuTung.AutoSize = True
        Me.lTenPhuTung.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenPhuTung.Location = New System.Drawing.Point(763, 177)
        Me.lTenPhuTung.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTenPhuTung.Name = "lTenPhuTung"
        Me.lTenPhuTung.Size = New System.Drawing.Size(158, 21)
        Me.lTenPhuTung.TabIndex = 3
        Me.lTenPhuTung.Text = "Tên loại phụ tùng:"
        '
        'lSoLuong
        '
        Me.lSoLuong.AutoSize = True
        Me.lSoLuong.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSoLuong.Location = New System.Drawing.Point(763, 279)
        Me.lSoLuong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lSoLuong.Name = "lSoLuong"
        Me.lSoLuong.Size = New System.Drawing.Size(85, 21)
        Me.lSoLuong.TabIndex = 4
        Me.lSoLuong.Text = "Số lượng:"
        '
        'lDonGia
        '
        Me.lDonGia.AutoSize = True
        Me.lDonGia.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDonGia.Location = New System.Drawing.Point(763, 227)
        Me.lDonGia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDonGia.Name = "lDonGia"
        Me.lDonGia.Size = New System.Drawing.Size(80, 21)
        Me.lDonGia.TabIndex = 5
        Me.lDonGia.Text = "Đơn giá:"
        '
        'txtMaLoaiPhuTung
        '
        Me.txtMaLoaiPhuTung.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaLoaiPhuTung.Location = New System.Drawing.Point(941, 126)
        Me.txtMaLoaiPhuTung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaLoaiPhuTung.Name = "txtMaLoaiPhuTung"
        Me.txtMaLoaiPhuTung.ReadOnly = True
        Me.txtMaLoaiPhuTung.Size = New System.Drawing.Size(220, 22)
        Me.txtMaLoaiPhuTung.TabIndex = 6
        '
        'txtTenLoaiPhuTung
        '
        Me.txtTenLoaiPhuTung.Location = New System.Drawing.Point(941, 172)
        Me.txtTenLoaiPhuTung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoaiPhuTung.Name = "txtTenLoaiPhuTung"
        Me.txtTenLoaiPhuTung.Size = New System.Drawing.Size(220, 22)
        Me.txtTenLoaiPhuTung.TabIndex = 7
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(941, 280)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(103, 22)
        Me.txtSoLuong.TabIndex = 8
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(941, 228)
        Me.txtDonGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(220, 22)
        Me.txtDonGia.TabIndex = 9
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(731, 375)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(135, 53)
        Me.btnCapNhat.TabIndex = 11
        Me.btnCapNhat.Text = "CẬP NHẬT"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(941, 375)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(135, 53)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmQLVatTuPhuTung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 690)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenLoaiPhuTung)
        Me.Controls.Add(Me.txtMaLoaiPhuTung)
        Me.Controls.Add(Me.lDonGia)
        Me.Controls.Add(Me.lSoLuong)
        Me.Controls.Add(Me.lTenPhuTung)
        Me.Controls.Add(Me.dgvDanhSachPhuTung)
        Me.Controls.Add(Me.lMaPhuTung)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmQLVatTuPhuTung"
        Me.Text = "Quản Lí Vật Tư Phụ Tùng"
        CType(Me.dgvDanhSachPhuTung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lMaPhuTung As Label
    Friend WithEvents dgvDanhSachPhuTung As DataGridView
    Friend WithEvents lTenPhuTung As Label
    Friend WithEvents lSoLuong As Label
    Friend WithEvents lDonGia As Label
    Friend WithEvents txtMaLoaiPhuTung As TextBox
    Friend WithEvents txtTenLoaiPhuTung As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
