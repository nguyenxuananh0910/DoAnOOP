﻿class NganHang
{
    public string TenNganHang { get; set; }
    public string MaHoaDon { get; set; }




    public void ThanhToanHoaDon()
    {
        HoaDon HoaDon = new HoaDon();

        // hiển thị hóa đơn
        HoaDon.HienHoaDon();


        Console.Write("TenNganHang : ");
        string ten = Console.ReadLine();
        TenNganHang = ten;

        // người dùng nhập "1" để thanh toán
        Console.WriteLine("nhập '1' để thanh toán hoặc '2' để hủy:");
        string confirmpaymentinput = Console.ReadLine();

        if (confirmpaymentinput == "1")
        {

            Console.WriteLine("Xác nhận giao dịch thanh toán:");
            Console.WriteLine($"Số điện thoại:: {TenNganHang}");
            Console.WriteLine("Số hóa đơn:  12345");
            Console.WriteLine("thanh toán thành công.");

        }
        else if (confirmpaymentinput == "2")
        {
            Console.WriteLine("hủy thanh toán.");
        }


    }



}





//class PaymentSystem
//{
//    public bool ValidatePaymentMethod(PaymentMethod paymentMethod)
//    {
//        // Giả sử hệ thống luôn xác nhận phương thức thanh toán là hợp lệ
//        return true;
//    }

//    public bool ProcessPayment(Transaction transaction)
//    {
//        // Giả sử hệ thống luôn xử lý giao dịch thanh toán thành công
//        return true;
//    }
//}
