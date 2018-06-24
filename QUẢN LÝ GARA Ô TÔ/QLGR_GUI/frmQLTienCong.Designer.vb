<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLTienCong
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
        Me.dgvListTienCong = New System.Windows.Forms.DataGridView()
        Me.lMaLoai = New System.Windows.Forms.Label()
        Me.lTenLoai = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.lMucTien = New System.Windows.Forms.Label()
        Me.txtMucTien = New System.Windows.Forms.TextBox()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        CType(Me.dgvListTienCong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ TIỀN CÔNG"
        '
        'dgvListTienCong
        '
        Me.dgvListTienCong.AllowUserToAddRows = False
        Me.dgvListTienCong.AllowUserToDeleteRows = False
        Me.dgvListTienCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListTienCong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListTienCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListTienCong.Location = New System.Drawing.Point(13, 60)
        Me.dgvListTienCong.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListTienCong.MultiSelect = False
        Me.dgvListTienCong.Name = "dgvListTienCong"
        Me.dgvListTienCong.ReadOnly = True
        Me.dgvListTienCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListTienCong.Size = New System.Drawing.Size(592, 560)
        Me.dgvListTienCong.TabIndex = 1
        '
        'lMaLoai
        '
        Me.lMaLoai.AutoSize = True
        Me.lMaLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMaLoai.Location = New System.Drawing.Point(671, 112)
        Me.lMaLoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lMaLoai.Name = "lMaLoai"
        Me.lMaLoai.Size = New System.Drawing.Size(75, 21)
        Me.lMaLoai.TabIndex = 2
        Me.lMaLoai.Text = "Mã loại:"
        '
        'lTenLoai
        '
        Me.lTenLoai.AutoSize = True
        Me.lTenLoai.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTenLoai.Location = New System.Drawing.Point(671, 186)
        Me.lTenLoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTenLoai.Name = "lTenLoai"
        Me.lTenLoai.Size = New System.Drawing.Size(86, 21)
        Me.lTenLoai.TabIndex = 3
        Me.lTenLoai.Text = "Tên loại: "
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(793, 185)
        Me.txtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(208, 22)
        Me.txtTenLoai.TabIndex = 5
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapNhat.Location = New System.Drawing.Point(725, 341)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(135, 53)
        Me.btnCapNhat.TabIndex = 7
        Me.btnCapNhat.Text = "CẬP NHẬT"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(899, 341)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(135, 53)
        Me.btnXoa.TabIndex = 8
        Me.btnXoa.Text = "XÓA"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'lMucTien
        '
        Me.lMucTien.AutoSize = True
        Me.lMucTien.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMucTien.Location = New System.Drawing.Point(671, 259)
        Me.lMucTien.Name = "lMucTien"
        Me.lMucTien.Size = New System.Drawing.Size(83, 21)
        Me.lMucTien.TabIndex = 10
        Me.lMucTien.Text = "Mức tiền:"
        '
        'txtMucTien
        '
        Me.txtMucTien.Location = New System.Drawing.Point(793, 259)
        Me.txtMucTien.Name = "txtMucTien"
        Me.txtMucTien.Size = New System.Drawing.Size(208, 22)
        Me.txtMucTien.TabIndex = 11
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(793, 113)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.ReadOnly = True
        Me.txtMaLoai.Size = New System.Drawing.Size(208, 22)
        Me.txtMaLoai.TabIndex = 14
        '
        'frmQLTienCong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 690)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.txtMucTien)
        Me.Controls.Add(Me.lMucTien)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.lTenLoai)
        Me.Controls.Add(Me.lMaLoai)
        Me.Controls.Add(Me.dgvListTienCong)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1194, 724)
        Me.Name = "frmQLTienCong"
        Me.Text = "Quản Lí Tiền Công"
        CType(Me.dgvListTienCong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListTienCong As DataGridView
    Friend WithEvents lMaLoai As Label
    Friend WithEvents lTenLoai As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents lMucTien As Label
    Friend WithEvents txtMucTien As TextBox
    Friend WithEvents txtMaLoai As TextBox
End Class
