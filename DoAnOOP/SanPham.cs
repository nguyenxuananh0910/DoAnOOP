namespace DoAnOOP
{
    internal class SanPham
    {
        public void ThemXe()
        {
            string moTaSP, tenSP, loaiSP, giaSP;

            do
            {
                Console.Write("Nhập tên sản phẩm: ");
                tenSP = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(tenSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(tenSP));

            do
            {
                Console.Write("Nhập giá sản phẩm: ");
                giaSP = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(giaSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(giaSP));


            do
            {
                Console.Write("Nhập loại sản phẩm: ");
                loaiSP = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(loaiSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(loaiSP));

            Console.WriteLine("Nhập mô tả chi tiết:");
            moTaSP = Console.ReadLine()!;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Mã sản phẩm là: 898 ");
            Console.WriteLine("Thêm xe thành công!");
        }

        public void TimKiemXe()
        {
            int maSP = 898;
            int userInput;

            do
            {
                Console.Write("Nhập mã sản phẩm cần tìm : ");
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Dữ liệu không được để trống. Vui lòng nhập lại!");
                    Console.WriteLine("---------------------------------");
                }
                else if (userInput == maSP)
                {
                    Console.WriteLine("Đã tìm thấy sản phẩm có mã " + maSP);
                    Console.WriteLine("Tên: Toyota");
                    Console.WriteLine("Giá: 300.000.000 VND");
                    Console.WriteLine("Loại: Cũ");
                    Console.WriteLine("Mô tả chi tiết : Dung tích nhỏ, màu đen, xe hơi trầy xước, động cơ tốt, máy lạnh, màn hinh tivi");
                    break;
                }
                else
                {
                    Console.WriteLine("Dữ liệu không tìm thấy!");
                    Console.WriteLine("---------------------------------");
                }
            } while (userInput != 898);
        }
    }
}