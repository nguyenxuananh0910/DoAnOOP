namespace DoAnOOP
{
    internal class Menu
    {
        public void HienThiMenu()
        {
            int option;
            SanPham sanPham = new SanPham();
            HoaDon hoadon = new HoaDon();
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
                Console.WriteLine("9. Đặt Xe");
                Console.WriteLine("10. Tạo hoá đơn");
                Console.WriteLine("11. Tìm kiếm xe");
                Console.WriteLine("12. Thoát");
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
                        Invoice invoice = new Invoice();

                        // Hiển thị hóa đơn
                        invoice.DisplayInvoice();


                        // Tạo phương thức thanh toán
                        PaymentMethod paymentMethod = new PaymentMethod();

                        // Xác nhận phương thức thanh toán
                        PaymentSystem paymentSystem = new PaymentSystem();
                        if (!paymentSystem.ValidatePaymentMethod(paymentMethod))
                        {
                            Console.WriteLine("Phương thức thanh toán không hợp lệ.");
                            return;
                        }

                        // Người dùng nhập "1" để thanh toán
                        Console.WriteLine("Nhập '1' để thanh toán hoặc '2' để hủy:");
                        string confirmPaymentInput = Console.ReadLine();

                        if (confirmPaymentInput == "1")
                        {
                            Transaction transaction = new Transaction();
                            if (paymentSystem.ProcessPayment(transaction))
                            {
                                transaction.DisplayTransactionConfirmation();
                                Console.WriteLine("Thanh toán thành công.");
                            }
                            else
                            {
                                Console.WriteLine("Giao dịch thanh toán thất bại.");
                            }
                        }
                        else if (confirmPaymentInput == "2")
                        {
                            Console.WriteLine("Hủy thanh toán.");
                        }
                        break;1
                    case 8:
                        // Console.WriteLine("Chức năng đang phát triển! Xin thử lại sau.");
                        hoadon.XuatHoaDon();
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
}