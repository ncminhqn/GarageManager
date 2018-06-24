Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmThemVatTuPhuTung
    Private phuTungBus As VatTuPhuTungBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim phuTung As VatTuPhuTungDTO
        phuTung = New VatTuPhuTungDTO()

        '1. Mapping data from GUI control
        phuTung.MaLoaiPhuTung = Convert.ToInt32(txtMaLoaiPhuTung.Text)
        phuTung.TenLoaiPhuTung = txtTenLoaiPhuTung.Text
        phuTung.DonGia = txtDonGia.Text
        phuTung.SoLuong = txtSoLuong.Text

        '2. Business .....
        If (phuTungBus.isValidName(phuTung) = False) Then
            MessageBox.Show("Tên Loại phụ tùng không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoaiPhuTung.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = phuTungBus.insert(phuTung)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTenLoaiPhuTung.Text = String.Empty

            ' Get Next ID
            Dim nextID As Integer
            result = phuTungBus.getNextID(nextID)
            If (result.FlagResult = True) Then
                txtMaLoaiPhuTung.Text = nextID.ToString()
            Else
                MessageBox.Show("Lấy ID kế tiếp của Loại phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
            End If

        Else
            MessageBox.Show("Thêm loại phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub frmThemVatTuPhuTung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phuTungBus = New VatTuPhuTungBUS()

        ' Get Next ID
        Dim nextID As Integer
        Dim result As Result
        result = phuTungBus.getNextID(nextID)
        If (result.FlagResult = True) Then
            txtMaLoaiPhuTung.Text = nextID.ToString()
        Else
            MessageBox.Show("Lấy ID kế tiếp của Loại phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        Dim phuTung As VatTuPhuTungDTO
        phuTung = New VatTuPhuTungDTO()

        '1. Mapping data from GUI control
        phuTung.MaLoaiPhuTung = Convert.ToInt32(txtMaLoaiPhuTung.Text)
        phuTung.TenLoaiPhuTung = txtTenLoaiPhuTung.Text
        phuTung.DonGia = txtDonGia.Text
        phuTung.SoLuong = txtSoLuong.Text

        '2. Business .....
        If (phuTungBus.isValidName(phuTung) = False) Then
            MessageBox.Show("Tên Loại học sinh không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTenLoaiPhuTung.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = phuTungBus.insert(phuTung)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm loại phụ tùng thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Thêm loại phụ tùng không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class