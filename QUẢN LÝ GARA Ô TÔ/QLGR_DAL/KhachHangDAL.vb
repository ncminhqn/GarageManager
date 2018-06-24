
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class KhachHangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [malop] "
        query &= "FROM [tbllop] "
        query &= "ORDER BY [malop] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As Integer
                    idOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("malop")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblKhachHang] ([MaKH], [TenKH],[DiaChi],[DienThoai], [SoDIenThoai], [SoTienNo])"
        query &= "VALUES (@malop,@tenlop,@makhoi,@mahocky)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        KhachHang_DTO.MaKH = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", KhachHang_DTO.MaKH)
                    .Parameters.AddWithValue("@TenKH", KhachHang_DTO.HoTen)
                    .Parameters.AddWithValue("@DiaChi", KhachHang_DTO.DiaChi)
                    .Parameters.AddWithValue("@SoDienThoai", KhachHang_DTO.SoDienThoai)
                    .Parameters.AddWithValue("@TienNo", KhachHang_DTO.SoTienNo)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(KhachHang_DTO As KhachHangDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblKhachHang] SET"
        query &= " [TenKH] = @TenKH "
        query &= " [DiaChi] = @Diachi "
        query &= " [SoDienThoai] = @SoDienThoai"
        query &= "WHERE "
        query &= " [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", KhachHang_DTO.MaKH)
                    .Parameters.AddWithValue("@TenKH", KhachHang_DTO.HoTen)
                    .Parameters.AddWithValue("@DiaChi", KhachHang_DTO.DiaChi)
                    .Parameters.AddWithValue("@SoDienThoai", KhachHang_DTO.SoDienThoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listKhachHang As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKH], [TenKH], [DiaChi], [SoDienThoai],[SoTienNo]"
        query &= " FROM [tblKhachHang]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listKhachHang.Clear()
                        While reader.Read()
                            listKhachHang.Add(New KhachHangDTO(reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("SoTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Khach hang không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listKhachHang As List(Of KhachHangDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaKH], [TenKH], [DiaChi], [SoDienThoai],[SoTienNo]"
        query &= " FROM [tblKhachHang]"
        query &= " WHERE "
        query &= " [MaKH] = @MaKH "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", iMaKH)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listKhachHang.Clear()
                        While reader.Read()
                            listKhachHang.Add(New KhachHangDTO(reader("MaKH"), reader("TenKH"), reader("DiaChi"), reader("SoDienThoai"), reader("SoTienNo")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả khach hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(MaKH As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblKhachHang "
        query &= " WHERE "
        query &= " [malop] = @malop "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaKH", MaKH)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa khách hàng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

End Class
