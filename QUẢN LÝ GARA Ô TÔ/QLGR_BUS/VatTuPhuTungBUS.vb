Imports QLGR_DAL
Imports QLGR_DTO
Imports Utility
Public Class VatTuPhuTungBUS
    Private phuTungDAL As VatTuPhuTungDAL
    Public Sub New()
        phuTungDAL = New VatTuPhuTungDAL()
    End Sub
    Public Sub New(connectionString As String)
        phuTungDAL = New VatTuPhuTungDAL(connectionString)
    End Sub
    Public Function isValidName(phuTung As VatTuPhuTungDTO) As Boolean

        If (phuTung.TenLoaiPhuTung.Length < 1) Then
            Return False
        End If

        Return True

    End Function

    Public Function insert(phuTung As VatTuPhuTungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phuTungDAL.insert(phuTung)
    End Function
    Public Function update(phuTung As VatTuPhuTungDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phuTungDAL.update(phuTung)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phuTungDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listPhuTung As List(Of VatTuPhuTungDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return phuTungDAL.selectALL(listPhuTung)
    End Function
    Public Function getNextID(ByRef nextID As Integer) As Result
        Return phuTungDAL.getNextID(nextID)
    End Function
End Class
