Imports QLGR_BUS
Imports QLGR_DTO
Imports Utility
Public Class frmQLTienCong
    Private tienCongBus As TienCongBUS

    Private Sub frmQLTienCong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tienCongBus = New TienCongBUS()
        ' Load LoaiHocSinh list
        loadListLoaiTienCong()
    End Sub

    Private Sub loadListLoaiTienCong()
        ' Load LoaiTienCong list
        Dim listLoaiTienCong = New List(Of TienCongDTO)
        Dim result As Result
        result = tienCongBus.selectAll(listLoaiTienCong)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvListTienCong.Columns.Clear()
        dgvListTienCong.DataSource = Nothing

        dgvListTienCong.AutoGenerateColumns = False
        dgvListTienCong.AllowUserToAddRows = False
        dgvListTienCong.DataSource = listLoaiTienCong

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoaiTienCong"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoaiTienCong"
        dgvListTienCong.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoaiTienCong"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoaiTienCong"
        dgvListTienCong.Columns.Add(clTenLoai)

        Dim clMucTien = New DataGridViewTextBoxColumn()
        clMucTien.Name = "MucTien"
        clMucTien.HeaderText = "Mức Tiền"
        clMucTien.DataPropertyName = "MucTien"
        dgvListTienCong.Columns.Add(clMucTien)

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListTienCong.CurrentCellAddress.Y 'current row selected

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListTienCong.RowCount) Then
            Try
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
                result = tienCongBus.update(tienCong)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiTienCong list
                    loadListLoaiTienCong()
                    ' Hightlight the row has been updated on table
                    dgvListTienCong.Rows(currentRowIndex).Selected = True
                    Try
                        tienCong = CType(dgvListTienCong.Rows(currentRowIndex).DataBoundItem, TienCongDTO)
                        txtMaLoai.Text = tienCong.MaLoaiTienCong
                        txtTenLoai.Text = tienCong.TenLoaiTienCong
                        txtMucTien.Text = tienCong.MucTien
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại tiền công thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật Loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub

    Private Sub dgvListTienCong_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListTienCong.SelectionChanged
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListTienCong.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvListTienCong.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListTienCong.RowCount) Then
            Try
                Dim ltc = CType(dgvListTienCong.Rows(currentRowIndex).DataBoundItem, TienCongDTO)
                txtMaLoai.Text = ltc.MaLoaiTienCong
                txtTenLoai.Text = ltc.TenLoaiTienCong
                txtMucTien.Text = ltc.MucTien
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try

        End If
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvListTienCong.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvListTienCong.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại tiền công có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = tienCongBus.delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListLoaiTienCong()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvListTienCong.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvListTienCong.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim lhs = CType(dgvListTienCong.Rows(currentRowIndex).DataBoundItem, TienCongDTO)
                                    txtMaLoai.Text = lhs.MaLoaiTienCong
                                    txtTenLoai.Text = lhs.TenLoaiTienCong
                                    txtMucTien.Text = lhs.MucTien
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại tiền công thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại tiền công không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub
End Class