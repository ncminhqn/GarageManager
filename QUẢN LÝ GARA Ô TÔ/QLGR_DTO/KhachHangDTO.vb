Public Class KhachHangDTO

    Private strMaKH As Integer
    Private strHoTen As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Private strSoTienNo As Decimal

    Public Sub New()
    End Sub
    Public Sub New(strMaKH As Integer, strHoTen As String, strDiaChi As String, strSoDienThoai As String, strSoTienNo As Decimal)
        Me.strMaKH = strMaKH
        Me.strHoTen = strHoTen
        Me.strDiaChi = strDiaChi
        Me.strSoDienThoai = strSoDienThoai
        Me.strSoTienNo = strSoTienNo


    End Sub

    Public Property MaKH As Integer
        Get
            Return strMaKH
        End Get
        Set(value As Integer)
            strMaKH = value
        End Set
    End Property

    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property SoDienThoai As String
        Get
            Return strSoDienThoai
        End Get
        Set(value As String)
            strSoDienThoai = value
        End Set
    End Property

    Public Property SoTienNo As Decimal
        Get
            Return strSoTienNo
        End Get
        Set(value As Decimal)
            strSoTienNo = value
        End Set
    End Property
End Class
