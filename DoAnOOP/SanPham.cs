namespace DoAnOOP
{
    internal class SanPham
    {
        private string idSanPham = null!;
        public void ThemXe()
        {
            string MoTaSanPham, TenSanPham, LoaiSanPham, GiaSanPham;

            do
            {
                Console.Write("Nhập tên sản phẩm: ");
                TenSanPham = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(TenSanPham))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(TenSanPham));

            do
            {
                Console.Write("Nhập giá sản phẩm: ");
                GiaSanPham = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(GiaSanPham))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(GiaSanPham));


            do
            {
                Console.Write("Nhập loại sản phẩm: ");
                LoaiSanPham = Console.ReadLine()!;
                Console.WriteLine("---------------------------------");
                if (string.IsNullOrWhiteSpace(LoaiSanPham))
                    Console.WriteLine("Vui lòng không để trống!");
            } while (string.IsNullOrWhiteSpace(LoaiSanPham));

            Console.WriteLine("Nhập mô tả chi tiết:");
            MoTaSanPham = Console.ReadLine()!;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Mã sản phẩm là: 898 ");
            Console.WriteLine("Thêm xe thành công!");
        }

        public void XoaXe() {
            NhapIdSanPham();
            if(idSanPham == "911"){
                if(XacNhanXoaXe() == 1){
                    Console.WriteLine("Xoá xe thành công !");
                }
                else{
                    Console.WriteLine("Huỷ xoá xe thành công!");
                }
            }
            else{
                Console.WriteLine("Không tìm thấy mã sản phảm!");
            }
        }
        public void NhapIdSanPham() {
            Console.Write("Nhập ID sản phẩm : ");
            idSanPham = Console.ReadLine()!;
        }

        public int XacNhanXoaXe() {
            Console.WriteLine($"Bạn có muốn xoá xe có mã id là {idSanPham} không ?");
            Console.Write("Nhập 1 để xác nhận / 2 để huỷ : ");
            int xacNhan = int.Parse(Console.ReadLine()!);
            return xacNhan;
        }
    }
}