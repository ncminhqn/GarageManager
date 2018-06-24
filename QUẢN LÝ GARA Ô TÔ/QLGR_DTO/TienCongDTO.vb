Public Class TienCongDTO

    Private strMaLoaiTienCong
    Private strTenLoaiTienCong
    Private iMucTien
    Public Sub New()
    End Sub

    Public Sub New(strMaLoaiTienCong As String, strTenLoaiTienCong As String, iMucTien As Integer)
        Me.strMaLoaiTienCong = strMaLoaiTienCong
        Me.strTenLoaiTienCong = strTenLoaiTienCong
        Me.iMucTien = iMucTien
    End Sub

    Property MaLoaiTienCong() As String
        Get
            Return strMaLoaiTienCong
        End Get
        Set(value As String)
            strMaLoaiTienCong = value
        End Set
    End Property

    Property TenLoaiTienCong() As String
        Get
            Return strTenLoaiTienCong
        End Get
        Set(value As String)
            strTenLoaiTienCong = value
        End Set
    End Property

    Property MucTien() As Integer
        Get
            Return iMucTien
        End Get
        Set(value As Integer)
            iMucTien = value
        End Set
    End Property
End Class
