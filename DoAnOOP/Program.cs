namespace DoAnOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;

            SanPham sanPham = new SanPham();
            
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
                        sanPham.ThemXe();
                        break;
                    case 2:
                        sanPham.TimKiemXe();
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
        
        
    }
}
