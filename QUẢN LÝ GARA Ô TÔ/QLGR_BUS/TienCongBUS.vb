Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class TienCongBUS
    Private tcDAL As TienCongDAL
    Public Sub New()
        tcDAL = New TienCongDAL()
    End Sub
    Public Sub New(connectionString As String)
        tcDAL = New TienCongDAL(connectionString)
    End Sub
    Public Function isValidName(tc As TienCongDTO) As Boolean
        If (tc.TenLoaiTienCong.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(tc As TienCongDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tcDAL.insert(tc)
    End Function
    Public Function update(tc As TienCongDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tcDAL.update(tc)
    End Function
    Public Function delete(tc As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tcDAL.delete(tc)
    End Function
    Public Function selectAll(ByRef listLoaiTienCong As List(Of TienCongDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tcDAL.selectAll(listLoaiTienCong)
    End Function

    'Public Function Show() As DataTable
    '    Return tcDAL.FilterData()
    'End Function

    Public Function getNextID(ByRef nextID As Integer) As Result
        Return tcDAL.getNextID(nextID)
    End Function
End Class
