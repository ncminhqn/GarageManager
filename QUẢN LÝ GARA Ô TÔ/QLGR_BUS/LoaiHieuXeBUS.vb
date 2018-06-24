Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility

Public Class LoaiHieuXeBUS
    Private LoaiHieuXe_DAL As LoaiHieuXeDAL
    Public Sub New()
        LoaiHieuXe_DAL = New LoaiHieuXeDAL()
    End Sub
    Public Sub New(connectionString As String)
        LoaiHieuXe_DAL = New LoaiHieuXeDAL(connectionString)
    End Sub
    Public Function isValidName(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Boolean

        If (LoaiHieuXe_DTO.TenHieuXe) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.insert(LoaiHieuXe_DTO)

    End Function
    Public Function update(LoaiHieuXe_DTO As LoaiHieuXeDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.update(LoaiHieuXe_DTO)
    End Function
    Public Function delete(MaLoaiHieuXe As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.delete(MaLoaiHieuXe)
    End Function
    Public Function selectAll(ByRef listLoaiHieuXe As List(Of LoaiHieuXeDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return LoaiHieuXe_DAL.selectAll(listLoaiHieuXe)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return LoaiHieuXe_DAL.getNextID(nextID)
    End Function
End Class
