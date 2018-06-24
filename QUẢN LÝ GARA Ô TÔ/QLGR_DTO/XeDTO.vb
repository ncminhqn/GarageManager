Public Class XeDTO

    Private strBienSo As String
    Private iLoaiHieuXe As Integer
    Private dateNgayTiepNhan As DateTime

    Public Sub New()
    End Sub

    Public Sub New(strBienSo As String, iLoaiHieuXe As Integer, dateNgayTiepNhan As DateTime)
        Me.strBienSo = strBienSo
        Me.iLoaiHieuXe = iLoaiHieuXe
        Me.dateNgayTiepNhan = dateNgayTiepNhan
    End Sub

    Public Property BienSo As String
        Get
            Return strBienSo
        End Get
        Set(value As String)
            strBienSo = value
        End Set
    End Property

    Public Property LoaiHieuXe As Integer
        Get
            Return iLoaiHieuXe
        End Get
        Set(value As Integer)
            iLoaiHieuXe = value
        End Set
    End Property

    Public Property NgayTiepNhan As Date
        Get
            Return dateNgayTiepNhan
        End Get
        Set(value As Date)
            dateNgayTiepNhan = value
        End Set
    End Property

End Class
