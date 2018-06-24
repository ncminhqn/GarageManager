Public Class VatTuPhuTungDTO
    Private iMaLoaiPhuTung
    Private strTenLoaiPhuTung
    Private iDonGia
    Private iSoLuong

    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiPhuTung As Integer, strTenLoaiPhuTung As String, iDonGia As Integer, iSoLuong As Integer)
        Me.iMaLoaiPhuTung = iMaLoaiPhuTung
        Me.strTenLoaiPhuTung = strTenLoaiPhuTung
        Me.iDonGia = iDonGia
        Me.iSoLuong = iSoLuong
    End Sub

    Property MaLoaiPhuTung() As Integer
        Get
            Return iMaLoaiPhuTung
        End Get
        Set(value As Integer)
            iMaLoaiPhuTung = value
        End Set
    End Property

    Property TenLoaiPhuTung() As String
        Get
            Return strTenLoaiPhuTung
        End Get
        Set(value As String)
            strTenLoaiPhuTung = value
        End Set
    End Property

    Property DonGia() As Integer
        Get
            Return iDonGia
        End Get
        Set(value As Integer)
            iDonGia = value
        End Set
    End Property

    Property SoLuong As Integer
        Get
            Return iSoLuong
        End Get
        Set(value As Integer)
            iSoLuong = value
        End Set
    End Property
End Class
