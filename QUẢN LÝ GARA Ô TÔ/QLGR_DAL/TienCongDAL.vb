Imports System.Configuration
Imports System.Data.SqlClient
Imports QLGR_DTO
Imports Utility
Public Class TienCongDAL
    Private connectionString As String

    'Dim connection As New SqlConnection("Server = DESKTOP-RU98CSS; Database = QLGR06; Integrated Security = true")
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    'Public Function FilterData() As DataTable ' Do Du lieu
    '    Dim query As String = "Select * FROM tblLOAITIENCONG"
    '    Dim command As New SqlCommand(query, connection)
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim table As New DataTable

    '    adapter.Fill(table)
    '    Return table

    'End Function

    Public Function getNextID(ByRef nextID As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaLoaiTienCong] "
        query &= "FROM [tblLoaiTienCong] "
        query &= "ORDER BY [MaLoaiTienCong] DESC "

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
                            idOnDB = reader("MaLoaiTienCong")
                        End While
                    End If
                    ' new ID = current ID + 1
                    nextID = idOnDB + 1
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    nextID = 1
                    Return New Result(False, "Lấy ID kế tiếp của Loại tiền công không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(tienCong As TienCongDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLoaiTienCong] ([MaLoaiTienCong], [TenLoaiTienCong], [MucTien])"
        query &= "VALUES (@MaLoaiTienCong,@TenLoaiTienCong,@MucTien)"

        Dim nextID = 0
        Dim result As Result
        result = getNextID(nextID)
        If (result.FlagResult = False) Then
            Return result
        End If
        tienCong.MaLoaiTienCong = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiTienCong", tienCong.MaLoaiTienCong)
                    .Parameters.AddWithValue("@TenLoaiTienCong", tienCong.TenLoaiTienCong)
                    .Parameters.AddWithValue("@MucTien", tienCong.MucTien)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Thêm Loại tiền công không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(tienCong As TienCongDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLOAITIENCONG] SET"
        query &= " [TenLoaiTienCong] = @TenLoaiTienCong "
        query &= " ,[MucTien] = @MucTien "
        query &= " WHERE "
        query &= " [MaLoaiTienCong] = @MaLoaiTienCong "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@TenLoaiTienCong", tienCong.TenLoaiTienCong)
                    .Parameters.AddWithValue("@MucTien", tienCong.MucTien)
                    .Parameters.AddWithValue("@MaLoaiTienCong", tienCong.MaLoaiTienCong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Tiền công không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(maLoaiTienCong As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLOAITIENCONG] "
        query &= " WHERE "
        query &= " [MaLoaiTienCong] = @MaLoaiTienCong "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiTienCong", maLoaiTienCong)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Tiền công không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
    Public Function selectAll(listLoaiTienCong As List(Of TienCongDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaLoaiTienCong], [TenLoaiTienCong], [MucTien]"
        query &= "FROM [tblLOAITIENCONG]"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiTienCong.Clear()
                        While reader.Read()
                            listLoaiTienCong.Add(New TienCongDTO(reader("MaLoaiTienCong"), reader("TenLoaiTienCong"), reader("MucTien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close() 'Thất bại
                    Return New Result(False, "Lấy tất cả mã loại tiền công không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) 'Thành công
    End Function


End Class

