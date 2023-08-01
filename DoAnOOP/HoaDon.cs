using IronPdf;
using System;
class HoaDon
{
    // string MaHoaDon = null!;
    // DateTime ThoiGianMua;
    // DateTime ThoiGianXuatHoaDon;
    // string DanhSachSanPhamDaMua = null!;
    // int TongGia;
    // string NhanVienHoTro = null!;
    // string PhuongThucThanhToan = null!;
    int idHoaDon;
    string fullName = null!;
    string phoneNumber = null!;
    public void NhapThongTinKhachHang()
    {
        Console.Write("Nhập họ tên khách hàng : ");
        fullName = Console.ReadLine()!;
        Console.Write("Nhập số điện thoại khách hàng : ");
        phoneNumber = Console.ReadLine()!;
    }
    public void NhapIdHoaDon() {
        Console.Write("Nhập mã hoá đơn : ");
        idHoaDon = int.Parse(Console.ReadLine()!);
    }
    public int NhapDeXacNhan() {
        Console.Write("Nhập 1 để xác nhận / 2 đế huỷ : ");
        int xacNhan = int.Parse(Console.ReadLine()!);
        return xacNhan;
    }
    public bool HoaDonKhachHang() {
        bool result = false;
        NhapThongTinKhachHang();
        List<string> fakeFullName = new List<string>() { "Phan Le Tuan", "Nguyen Xuan Anh", "Bui Xuan Phuoc", "Tran Sy Huy"};
        List<string> fakePhoneNumber = new List<string>() { "0123456789", "9876543210", "135791113", "024681012"};
        if (fakeFullName.Contains(fullName) && fakePhoneNumber.Contains(phoneNumber))
        {
            result = true;
            Console.WriteLine($"Mã Khách Hàng : 1234124");
            Console.WriteLine($"Họ Tên Khách Hàng : {fullName}");
            Console.WriteLine($"Số điện thoại Khách Hàng : {phoneNumber}");
            Console.WriteLine($"Địa chỉ Khách Hàng : Đại học Văn Lang");
        }
        return result;
    }
    public void HoaDonTheoID() {
        if(HoaDonKhachHang()){
            NhapIdHoaDon();
        }
    }
    public void XuatHoaDon(){
        if(NhapDeXacNhan() == 1){
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("Hello");
            try
            {
                pdf.SaveAs("./HoaDon.pdf");
                Console.WriteLine("Xuất PDF Thành công");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Lỗi Xuất PDF");
                throw;
            }
        }
        else{
            Console.WriteLine("Huỷ xuất hoá đơn thành công !");
        }
    }
}