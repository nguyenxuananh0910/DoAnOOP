namespace DoAnOOP
{
    internal class Menu
    {
        public void HienThiMenu() {
            int option;
            SanPham sanPham = new SanPham();

            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Đăng nhập");
                Console.WriteLine("2. Đăng kí");
                Console.WriteLine("3. Thêm xe");
                Console.WriteLine("4. Xoá Xe");
                Console.WriteLine("5. Sửa Xe");
                Console.WriteLine("6. Xem sản phẩm bán được");
                Console.WriteLine("7. Đặt Xe");
                Console.WriteLine("8. Tạo hoá đơn");
                Console.WriteLine("8. Chỉnh sửa thông tin cá nhân");
                Console.WriteLine("9. Tìm kiếm xe");
                Console.WriteLine("10. Thoát");
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
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
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
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 8:
                        Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        Console.WriteLine("---------------------------------");
                        break;
                    case 9:
                        sanPham.TimKiemXe();
                        Console.WriteLine("---------------------------------");
                        break;
                    case 10:
                        Console.WriteLine("Chương trình kết thúc.");
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