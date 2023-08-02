class HoaDon
{
    string MaHoaDon = null!;
    string ThoiGianMua = null!;
    DateTime ThoiGianXuatHoaDon = DateTime.Now;
    string DanhSachSanPhamDaMua = null!;
    int TongGia;
    string NhanVienHoTro = null!;
    string PhuongThucThanhToan = null!;
    string fullName = null!;
    string phoneNumber = null!;

    #region FakeData
    private List<string> fakeFullName = new List<string>() { "Phan Le Tuan", "Nguyen Xuan Anh", "Bui Xuan Phuoc", "Tran Sy Huy" };
    private List<string> fakePhoneNumber = new List<string>() { "0123456789", "9876543210", "135791113", "024681012" };
    private Dictionary<string, string> fakeIdList = new Dictionary<string, string>() { { "0112233445", "July 1st, 2023" }, { "1234456789", "June 23th, 2023" }, { "2244668810", "April 4th, 202" }, { "1133557799", "January 18th, 2023" } };
    #endregion

    public void NhapThongTinKhachHang()
    {
        Console.Write("Nhập họ tên khách hàng : ");
        fullName = Console.ReadLine()!;
        Console.Write("Nhập số điện thoại khách hàng : ");
        phoneNumber = Console.ReadLine()!;
    }
    public void NhapMaHoaDon()
    {
        Console.Write("Nhập mã hoá đơn : ");
        MaHoaDon = Console.ReadLine()!;
    }
    public int NhapDeXacNhan()
    {
        Console.Write("Nhập 1 để xác nhận / 2 để huỷ : ");
        int xacNhan = int.Parse(Console.ReadLine()!);
        return xacNhan;
    }
    public bool HoaDonKhachHang()
    {
        bool result = false;
        NhapThongTinKhachHang();
        if (fakeFullName.Contains(fullName) && fakePhoneNumber.Contains(phoneNumber))
        {
            result = true;
            Console.WriteLine($"Mã Khách Hàng : 1234124");
            Console.WriteLine($"Họ Tên Khách Hàng : {fullName}");
            Console.WriteLine($"Số điện thoại Khách Hàng : {phoneNumber}");
            Console.WriteLine($"Địa chỉ Khách Hàng : Đại học Văn Lang");
            Console.WriteLine("-----------|---------");
            Console.WriteLine("Ma Hoa Don | Ngay Mua");
            Console.WriteLine("-----------|---------");
            foreach (var item in fakeIdList)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("-----------|---------");
        }
        else
        {
            Console.WriteLine("Thông tin khách hàng không tồn tại");
            result = false;
        }
        return result;
    }
    public bool HoaDonTheoID()
    {
        bool result = false;
        if (HoaDonKhachHang())
        {
            NhapMaHoaDon();
            if (fakeIdList.ContainsKey(MaHoaDon))
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Ma Hoa Don | Ngay Mua");
                Console.WriteLine("---------------------");
                foreach (var item in fakeIdList)
                {
                    if (item.Key == MaHoaDon)
                    {
                        result = true;
                        ThoiGianMua = item.Value;
                        Console.WriteLine($"{item.Key} | {item.Value}");
                    }
                }
                Console.WriteLine("---------------------");
            }
            else
            {
                Console.WriteLine("Thông tin ID Hoá đơn không tồn tại");
                result = false;
            }
        }
        return result;
    }
    public void XuatHoaDon()
    {
        if (HoaDonTheoID())
        {
            Console.WriteLine("Bạn có muốn xuất hoá đơn không ?");
            if (NhapDeXacNhan() == 1)
            {
                var renderer = new ChromePdfRenderer();
                var pdf = renderer.RenderHtmlAsPdf($"<h1> Hoá đơn thanh toán </h1><p>Mã Hoá Đơn : {MaHoaDon}</p><p>Họ tên Khách Hàng : {fullName}</p><p>Số điện thoại khách hàng : {phoneNumber}</p><p>Thời gian mua hàng : {ThoiGianMua}</p><p>Ngày xuất hoá đơn : {ThoiGianXuatHoaDon}</p>");
                try
                {
                    pdf.SaveAs("./HoaDon.pdf");
                    Console.WriteLine("Xuất hoá đơn thành công !");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Lỗi Xuất PDF");
                    throw;
                }
            }
            else
            {
                Console.WriteLine("Huỷ xuất hoá đơn thành công !");
            }
        }
    }

    public void HienHoaDon()
    {
        Console.WriteLine("Hóa đơn chi tiết:");
        Console.WriteLine("Ma Hóa đơn: 12345");
        Console.WriteLine("Thời Gian Mua: 25/7/20023 ");
        Console.WriteLine("Thời Gian Xuất Hóa Đơn:25/8/20023 ");
        Console.WriteLine("Danh Sách Sản Phẩm Đã Mua:  GTR 3 ");
        Console.WriteLine("Nhân Viên Hỗ Trợ: Xuân Anh ");

        Console.WriteLine("Tổng số tiền cần thanh toán: 200.000 $ ");

        // Nhập phương thức thanh toán từ người dùng
        Console.WriteLine("Nhập phương thức thanh toán ( thẻ tín dụng, chuyển khoản ngân hàng):");
        string paymentMethodInput = Console.ReadLine();
        PhuongThucThanhToan = paymentMethodInput;
    }
}