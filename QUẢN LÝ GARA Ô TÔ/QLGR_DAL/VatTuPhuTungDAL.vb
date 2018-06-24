Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class VatTuPhuTungDAL
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
        query &= "SELECT TOP 1 [MaLoaiPhuTung] "
        query &= "FROM [tblVatTuPhuTung] "
        query &= "ORDER BY [MaLoaiPhuTung] DESC "

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
                            idOnDB = reader("MaLoaiPhuTung")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại Phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(phuTung As VatTuPhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblVatTuPhuTung] ([MaLoaiPhuTung], [TenLoaiPhuTung], [DonGia], [SoLuong])"
        query &= "VALUES (@MaLoaiPhuTung,@TenLoaiPhuTung,@DonGia,@SoLuong)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        phuTung.MaLoaiPhuTung = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiPhuTung", phuTung.MaLoaiPhuTung)
                    .Parameters.AddWithValue("@TenLoaiPhuTung", phuTung.TenLoaiPhuTung)
                    .Parameters.AddWithValue("@DonGia", phuTung.DonGia)
                    .Parameters.AddWithValue("@SoLuong", phuTung.SoLuong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(phuTung As VatTuPhuTungDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblVatTuPhuTung] SET"
        query &= " [TenLoaiPhuTung] = @TenLoaiPhuTung "
        query &= " ,[DonGia] = @DonGia "
        query &= " ,[SoLuong] = @SoLuong "
        query &= "WHERE "
        query &= " [MaLoaiPhuTung] = @MaLoaiPhuTung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenLoaiPhuTung", phuTung.TenLoaiPhuTung)
                    .Parameters.AddWithValue("@DonGia", phuTung.DonGia)
                    .Parameters.AddWithValue("@SoLuong", phuTung.SoLuong)
                    .Parameters.AddWithValue("@MaLoaiPhuTung", phuTung.MaLoaiPhuTung)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listPhuTung As List(Of VatTuPhuTungDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaLoaiPhuTung], [TenLoaiPhuTung],[DonGia],[SoLuong]"
        query &= " FROM [tblVatTuPhuTung]"


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
                        listPhuTung.Clear()
                        While reader.Read()
                            listPhuTung.Add(New VatTuPhuTungDTO(reader("MaLoaiPhuTung"), reader("TenLoaiPhuTung"), reader("DonGia"), reader("SoLuong")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại Phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblVatTuPhuTung] "
        query &= " WHERE "
        query &= " [MaLoaiPhuTung] = @MaLoaiPhuTung "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiPhuTung", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Phụ tùng không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
