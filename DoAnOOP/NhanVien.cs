class Employee
{
    public string HoTen;
    public string SĐT;
    public string NgaySinh;
    public string GioiTinh;
    public string ChiNhanhLamViec;
    public string Password;

    public void CapNhatThongTin()
    {

        Console.WriteLine("Chào mừng bạn đến với trang chỉnh sửa thông tin cá nhân");
        Console.WriteLine("Vui lòng nhập thông tin cá nhân của bạn:");

        Console.Write("Tên: ");
        string hoten = Console.ReadLine();

        Console.Write("Số điện thoại: ");
        string sdt = Console.ReadLine();

        Console.Write(":Ngay Sinh : ");
        string ngaysinh = Console.ReadLine();

        Console.Write("Gioi Tinh: ");
        string gioitinh = Console.ReadLine();

        Console.Write("Chi Nhanh: ");
        string chinhanh = Console.ReadLine();

        Console.Write("Mật khẩu: ");
        string password = Console.ReadLine();
        HoTen = hoten;
        SĐT = sdt;
        NgaySinh = ngaysinh;
        GioiTinh = gioitinh;
        ChiNhanhLamViec = chinhanh;
        Password = password;

        Console.WriteLine("Thông tin của bạn đã được cập nhật:");
        Console.WriteLine($"Tên: {HoTen}");
        Console.WriteLine($"Số điện thoại:: {SĐT}");
        Console.WriteLine($"Ngay Sinh: {NgaySinh}");
        Console.WriteLine($"Gioi Tinh: {GioiTinh}");
        Console.WriteLine($"Chi Nhanh: {ChiNhanhLamViec}");
        Console.WriteLine($"Mật khẩu: {Password}");

        Console.WriteLine("Nhấn '1' và Enter để áp dụng các thay đổi hoặc '2' để hủy .");
        string applyChanges = Console.ReadLine();

        if (applyChanges == "1")
        {
            // Hệ thống kiểm tra tính hợp lệ của dữ liệu và cập nhật thông tin tài khoản
            // Tạm thời, trong ví dụ này, chúng ta sẽ giả định rằng dữ liệu luôn hợp lệ và chỉ cần hiển thị thông báo thành công.
            Console.WriteLine("Cập nhật thông tin thành công!");
        }
        else if (applyChanges == "2")
        {
            Console.WriteLine("Hủy Cập nhật thông tin !");
        }
        else
        {
            Console.WriteLine("Các thay đổi chưa được lưu.");
        }

        Console.ReadLine();
    }
}

