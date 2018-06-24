Public Class LoaiHieuXeDTO

    Private iMaLoaiHieuXe As Integer
    Private strTenHieuXe As String

    Public Sub New()
    End Sub

    Public Property MaHieuXe As Integer
        Get
            Return iMaLoaiHieuXe
        End Get
        Set(value As Integer)
            iMaLoaiHieuXe = value
        End Set
    End Property

    Public Property TenHieuXe As String
        Get
            Return strTenHieuXe
        End Get
        Set(value As String)
            strTenHieuXe = value
        End Set
    End Property
End Class
