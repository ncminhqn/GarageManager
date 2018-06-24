Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThemLoaiTienCong

    Private tienCongBus As TienCongBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim tienCong As TienCongDTO
        tienCong = New TienCongDTO()

        '1. Mapping data from GUI control
        tienCong.MaLoaiTienCong = Convert.ToInt32(txtMaLoai.Text)
        tienCong.TenLoaiTienCong = txtTenLoai.Text
        tienCong.MucTien = txtMucTien.Text

        '2. Business .....
        If (tienCongBus.isValidName(tienCong) = False) Then
            MessageBox.Show("Tên Loại tiền công không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tienCongBus.insert(tienCong)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại tiền công thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoai.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = tienCongBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoai.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmThemLoaiTienCong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tienCongBus = New TienCongBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = tienCongBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoai.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        Dim tienCong As TienCongDTO
        tienCong = New TienCongDTO()

        '1. Mapping data from GUI control
        tienCong.MaLoaiTienCong = Convert.ToInt32(txtMaLoai.Text)
        tienCong.TenLoaiTienCong = txtTenLoai.Text
        tienCong.MucTien = txtMucTien.Text

        '2. Business .....
        If (tienCongBus.isValidName(tienCong) = False) Then
            MessageBox.Show("Tên Loại tiền công không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoai.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = tienCongBus.insert(tienCong)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại tiền công thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class