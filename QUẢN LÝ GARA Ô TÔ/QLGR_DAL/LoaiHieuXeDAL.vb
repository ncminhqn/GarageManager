
Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility


Public Class LoaiHieuXeDAL
    Private LoaiHieuXe_DAL As LoaiHieuXeDAL
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
        query &= "SELECT TOP 1 [MaLoaiHieuXe] "
        query &= "FROM [tblLoaiXe] "
        query &= "ORDER BY [MaLoaiHieuXe] DESC "

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
                            idOnDB = reader("MaLoaiXe")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiBienSo] ([MaLoaiHieuXe], [TenLoaiHieuXe])"
        query &= "VALUES (@MaLoaiBienSo,@TenLoaiHieuXe)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        LoaiHieuXe_DTO.MaHieuXe = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", LoaiHieuXe_DTO.MaHieuXe)
                    .Parameters.AddWithValue("@MaLoaiHieuXe", LoaiHieuXe_DTO.TenHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Hieu Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiHieuXe] SET"
        query &= " [TenLoaiHieuXe] = @TenLoaiHieuXe"
        query &= "WHERE "
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiHieuXe", LoaiHieuXe_DTO.MaHieuXe)
                    .Parameters.AddWithValue("@TenLoaiHieuXe", LoaiHieuXe_DTO.TenHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(MaLoaiHieuXe As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiHocSinh] "
        query &= " WHERE "
        query &= " [MaLoaiHieuXe] = @MaLoaiHieuXe"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaHieuXe", MaLoaiHieuXe)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa Xe không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectAll(ByRef listHieuXe As List(Of LoaiHieuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.selectAll(listHieuXe)
    End Function

End Class
