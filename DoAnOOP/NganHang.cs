class Transaction
{
    public string TenNganHang { get; set; }
    public string MaHoaDon { get; set; }




    public void DisplayTransactionConfirmation()
    {
        Console.WriteLine("Xác nhận giao dịch thanh toán:");
        Console.WriteLine("Tên ngân hàng: VCB ");
        Console.WriteLine("Số hóa đơn:  12345");
    }
}

// Lớp PaymentSystem đại diện cho hệ thống xử lý giao dịch thanh toán
class PaymentSystem
{
    public bool ValidatePaymentMethod(PaymentMethod paymentMethod)
    {
        // Giả sử hệ thống luôn xác nhận phương thức thanh toán là hợp lệ
        return true;
    }

    public bool ProcessPayment(Transaction transaction)
    {
        // Giả sử hệ thống luôn xử lý giao dịch thanh toán thành công
        return true;
    }
}
