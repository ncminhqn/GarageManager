Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility

Public Class XeDAL

    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insertXe(xe As XeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblXe] ([BienSoXe], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= "VALUES (@BienSoXe,@MaLoaiHieuXe,@NgayTiepNhan)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", xe.BienSo)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", xe.LoaiHieuXe)
                    .Parameters.AddWithValue("@NgayTiepNhan", xe.NgayTiepNhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Tiếp nhận xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALLXe(ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [tblXe] ([BienSoXe], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= "FROM [tblXe]"


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
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByMaKH(iMaKH As Integer, ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [tblXe] ([BienSoXe], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= " FROM [tblXe] "
        query &= "     ,[tblKhachHang] "
        query &= " WHERE "
        query &= "[tblXe].[MaKH] = @MaKH"



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
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Xe theo Lớp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL_ByHieuXe(maLoai As Integer, ByRef listXe As List(Of XeDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [tblXe] ([BienSoXe], [MaLoaiHieuXe], [NgayTiepNhan]"
        query &= "FROM [tblXe] "
        query &= "WHERE [MaHieuXe] = @MaHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", maLoai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listXe.Clear()
                        While reader.Read()
                            listXe.Add(New XeDTO(reader("BienSoXe"), reader("MaLoaiHieuXe"), reader("NgayTiepNhan")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Xe theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(Xe As XeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblXe] SET"
        query &= " [MaHieuXe] = @MaHieuXe "
        query &= " [NgayTiepNhan] = @NgayTiepNhan"
        query &= " WHERE "
        query &= " [BienSo] = @BienSo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSoXe", Xe.BienSo)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", Xe.LoaiHieuXe)
                    .Parameters.AddWithValue("@NgayTiepNhan", Xe.NgayTiepNhan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(BienSo As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblXe] "
        query &= " WHERE "
        query &= " [BienSo] = @BienSo "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@BienSo", BienSo)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function

End Class
