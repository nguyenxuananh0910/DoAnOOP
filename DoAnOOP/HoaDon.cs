class Invoice
{
    public string ThoiGianMua { get; set; }
    public string ThoiGianXuatHoaDon { get; set; }
    public string DanhSachSanPham { get; set; }
    public string TongGia { get; set; }
    public string NhanVienHoTro { get; set; }
    public string PhuongThucThanhToan { get; set; }



    public void DisplayInvoice()
    {
        Console.WriteLine("Hóa đơn chi tiết:");
        Console.WriteLine("Thời Gian Mua: 25/7/20023 ");
        Console.WriteLine("Thời Gian Xuất Hóa Đơn:25/8/20023 ");
        Console.WriteLine("Danh Sách Sản Phẩm Đã Mua:  GTR 3 ");
        Console.WriteLine("Nhân Viên Hỗ Trợ: Xuân Anh ");

        Console.WriteLine("Tổng số tiền cần thanh toán: 200.000 $ ");
    }
}
class PaymentMethod
{
    public string Name { get; set; }

    public PaymentMethod()
    {
        // Nhập phương thức thanh toán từ người dùng
        Console.WriteLine("Nhập phương thức thanh toán (tiền mặt, thẻ tín dụng/debit, chuyển khoản ngân hàng):");
        string paymentMethodInput = Console.ReadLine();
        Name = paymentMethodInput;
    }
}