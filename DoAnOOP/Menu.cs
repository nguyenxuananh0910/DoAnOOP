namespace DoAnOOP
{
    internal class Menu
    {
        public void HienThiMenu()
        {
            int option;
            SanPham sanPham = new SanPham();
            HoaDon hoadon = new HoaDon();
            KhoHang khohang = new KhoHang();
            NhaCungCapXe nhaCungCapXe = new NhaCungCapXe();
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Đăng nhập");
                Console.WriteLine("2. Đăng kí");
                Console.WriteLine("3. Thêm xe");
                Console.WriteLine("4. Xoá Xe");
                Console.WriteLine("5. Sửa Xe");
                Console.WriteLine("6. Xem sản phẩm bán được");
                Console.WriteLine("7. Thanh Toan");
                Console.WriteLine("8. Chỉnh sửa thông tin cá nhân");
                Console.WriteLine("9. Xuất Hóa Đơn");
                Console.WriteLine("10. Đặt Xe");
                Console.WriteLine("11. Tạo hoá đơn");
                Console.WriteLine("12. Tìm kiếm xe");
                Console.WriteLine("13. Thoát");
                Console.Write("Chọn chức năng: ");
                option = int.Parse(Console.ReadLine()!);
                Console.WriteLine("---------------------------------");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 3:
                        sanPham.ThemXe();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 4:
                        sanPham.XoaXe();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 7:
                        NganHang nganhang = new NganHang();
                        nganhang.ThanhToanHoaDon();
                        break;
                    case 8:
                        // Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Employee employee = new Employee();
                        employee.CapNhatThongTin();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 9:
                        hoadon.XuatHoaDon();

                        Console.WriteLine("---------------------------------");
                        break;
                    case 10:
                        nhaCungCapXe.TaoDonHangMoi();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 12:
                        khohang.TimKiemXe();
                        Console.WriteLine("---------------------------------");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (option != 10);
        }

    }

}