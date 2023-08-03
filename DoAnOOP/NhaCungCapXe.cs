public class NhaCungCapXe
{


    public int MaNhaCungCap;

    public string TenNhaCungCap;

    public string Diachi;

    public int LoaiXe;

    public string HangXe;

    public int GiaXe;

    public string NgayDatXe;

    public string NgayDuKienCoXe;
    public void NhapLoaiXe()
    {
        Console.Write("Nhap loai xe : ");
        int LoaiXe = int.Parse(Console.ReadLine());
    }

    public void TaoDonHangMoi()
    {
        // TODO implement here
        LoaiXe = 1;
        HangXe = "Toyota";
        GiaXe = 2000000;

        Console.WriteLine("Đặt Xe Thành Công");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Loại Xe : {LoaiXe}");
        Console.WriteLine($"Hãng Xe : {HangXe}");
        Console.WriteLine($"Giá Xe : {GiaXe}");
        this.ThongTinDonDatXe();

    }

    public void ThongTinDonDatXe()
    {
        // TODO implement here
        LoaiXe = 1;
        HangXe = "Toyota";
        GiaXe = 2000000;

        Console.WriteLine("Thông Tin Đơn Đặt Xe");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Loại Xe : {LoaiXe}");
        Console.WriteLine($"Hãng Xe : {HangXe}");
        Console.WriteLine($"Giá Xe : {GiaXe}");
        this.XuatDonDatXe();
    }

    public void XuatDonDatXe()
    {
        // TODO implement here
        LoaiXe = 1;
        HangXe = "Toyota";
        GiaXe = 2000000;

        Console.WriteLine("Xuất Đơn Đặt Xe");
        Console.WriteLine("-----------------");
        Console.WriteLine($"Loại Xe : {LoaiXe}");
        Console.WriteLine($"Hãng Xe : {HangXe}");
        Console.WriteLine($"Giá Xe : {GiaXe}");
    }

}