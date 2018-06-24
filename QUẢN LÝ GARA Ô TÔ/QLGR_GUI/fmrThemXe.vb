Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility


Public Class fmrThemXe

    Private Xe_Bus As XeBUS
    Private LoaiHieuXe_Bus As LoaiHieuXeBUS

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Xe_DTO As XeDTO
        Xe_DTO = New XeDTO()

        '1. Mapping data from GUI control
        Xe_DTO.BienSo = txtBienSo.Text
        Xe_DTO.LoaiHieuXe = Convert.ToInt32(cbHieuXe.SelectedValue)
        Xe_DTO.NgayTiepNhan = dtpNgayTiepNhan.Value


        '2. Business .....
        If (Xe_Bus.isValidName(Xe_DTO) = False) Then
            MessageBox.Show("Bien số xe không đúng")
            txtBienSo.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = Xe_Bus.insert(Xe_DTO)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Xe  thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto

            txtBienSo.Text = String.Empty

        Else
            MessageBox.Show("Thêm Xe sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

    End Sub

    Private Sub fmrThemXe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
