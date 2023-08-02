public class KhoHang
{

    public int MaKhoHang;

    public string TenKhoHang;

    public string DiaChi;

    public int SoLuong;

    public int MaSanPham;

    public string TinhTrangHang;

    public string NgayNhapKho;

    public string NgayXuatKho;

    public void TimKiemXe()
    {
         MaSanPham = 898;
         SoLuong = 1;
         TinhTrangHang = "Đang trưng bày";
         NgayNhapKho = "01/08/2023";
         NgayXuatKho = "02/08/2023";
            int nguoiDungNhapVao;
            do
            {
                Console.Write("Nhập mã sản phẩm cần tìm : ");
                if (!int.TryParse(Console.ReadLine(), out nguoiDungNhapVao))
                {
                    Console.WriteLine("Dữ liệu không được để trống. Vui lòng nhập lại!");
                    Console.WriteLine("---------------------------------");
                }
                else if (nguoiDungNhapVao == MaSanPham)
                {
                    Console.WriteLine("Đã tìm thấy sản phẩm có mã " + MaSanPham);
                    Console.WriteLine("Số lượng: " + SoLuong);
                    Console.WriteLine("Trình trạng hàng: " + TinhTrangHang);
                    Console.WriteLine("Ngày nhập kho: " + NgayNhapKho);
                    Console.WriteLine("Ngày xuất kho: " + NgayXuatKho);
                    break;
                }
                else
                {
                    Console.WriteLine("Dữ liệu không tìm thấy!");
                    Console.WriteLine("---------------------------------");
                }
            } while (nguoiDungNhapVao != 898);
    }

}