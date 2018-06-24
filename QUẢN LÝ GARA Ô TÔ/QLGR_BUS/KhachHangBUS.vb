Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

Public Class KhachHangBUs
    Private KhachHang_DAL As KhachHangDAL
    Public Sub New()
        KhachHang_DAL = New KhachHangDAL()
    End Sub
    Public Sub New(connectionString As String)
        KhachHang_DAL = New KhachHangDAL(connectionString)
    End Sub
    Public Function isValidName(KhachHang_DTO As KhachHangDTO) As Boolean

        If (KhachHang_DTO.HoTen.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(KhachHang_DTO As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.insert(KhachHang_DTO)
    End Function
    Public Function update(lop As KhachHangDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.update(lop)
    End Function
    Public Function delete(MaKH As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.delete(MaKH)
    End Function
    Public Function selectAll(ByRef listKhachHang As List(Of KhachHangDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return KhachHang_DAL.selectALL(listKhachHang)
    End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return KhachHang_DAL.getNextID(nextID)
    End Function
End Class
