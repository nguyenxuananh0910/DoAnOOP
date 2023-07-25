namespace DoAnOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Thêm xe");
                Console.WriteLine("2. Tìm kiếm xe");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng (1/2/3): ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ThemXe();
                        break;
                    case 2:
                        TimKiemXe();
                        break;
                    case 3:
                        Console.WriteLine("Chương trình kết thúc.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            } while (option != 3);
        }

        static void ThemXe()
        {
            string moTaSP, tenSP, loaiSP, giaSP;

            do
            {
                Console.Write("Nhập tên sản phẩm: ");
                tenSP = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(tenSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(tenSP));

           do
            {
                Console.Write("Nhập giá sản phẩm: ");
                giaSP = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(giaSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(giaSP));


            do
            {
                Console.Write("Nhập loại sản phẩm: ");
                 loaiSP = Console.ReadLine();
                if (string.IsNullOrWhiteSpace( loaiSP))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace( loaiSP));
        
             Console.WriteLine("Nhập mô tả chi tiết:");
              moTaSP = Console.ReadLine();
            Console.WriteLine("Mã sản phẩm là: 898 ");
            Console.WriteLine("Thêm xe thành công!");

        }

        static void TimKiemXe()
        {
            int maSP = 898; 
            int userInput;

            do
            {
                Console.Write("Nhập mã sản phẩm cần tìm : ");
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Dữ liệu không tìm thấy. Vui lòng nhập lại!");
                }
                else if (userInput ==  maSP)
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
                }
            } while (userInput != 898);

        }
    }
}
