using System.Text;

namespace baiTapLon
{
    public struct lapLai()
    {
        public int luaChon;
        public bool kTra;
        //vì [] tach cần khai báo nhiều lên tạo trong struct tiết kiệm dung lượng chương trình
        public string[] tach;
        public string tach1;

    }


    internal class Program

    {

        //tạo chương trình quản lý điểm sinh viên
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //thiết lập cửa sổ
            Console.Title = "chương trình tính điểm";
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;
            Console.BufferWidth = 100;
            Console.BufferHeight = 40;
            manHinhChaoMung();
            phanLoai();

        }

        //hiển thị màn  hình đang nhập
        static void manHinhChaoMung()
        {


            Console.Clear();
            string s = "WELCOME BACK";
            Console.SetCursorPosition((100 - s.Length) / 2, (40 / 2));
            Console.WriteLine(s);
            string ss = "press to  next";
            Console.SetCursorPosition((100 - ss.Length) / 2, (42 / 2));
            Console.WriteLine(ss);
            Console.ReadKey();
            Console.Clear();
        }
        static void phanLoai()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            Console.WriteLine("nhập 1-giảng viên, 0-học sinh");
            aa.luaChon = chuanHoaNhap(2, 1, 2, 1);
            switch (aa.luaChon)
            {
                case 0:
                    hocSinh();
                    break;
                case 1:
                    giangVien();
                    break;
            }
        }
        static void hocSinh()
        {
            Console.Clear();
            manHinhDangNhapHocSinh();

        }
        static void giangVien()
        {
            Console.Clear();
            manHinhDangNhapGiangVien();

        }
        static void manHinhDangNhapGiangVien()
        {
            lapLai aa = new lapLai();
            hienThiThongBaoPhucKhao();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                     Quản lý điểm sinh viên                   ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               Tài khoản:                                     ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               Mật khẩu:                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                   Đăng nhập                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.kTra = true;
            string thongBao = "không thành công!";
            for (int a = 0; a < 3; a++)
            {
                Console.SetCursorPosition(36, 13);
                Console.WriteLine("Đăng nhập");
                Console.SetCursorPosition(26, 8);
                string taiKhoan = Console.ReadLine();
                string emptyLine = new string(' ', thongBao.Length);
                //lấy tại khoản từ tệp
                StreamReader doc = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\taiKHoanGiangVien.txt");
                String All = doc.ReadLine();
                aa.tach = All.Split(',');
                doc.Close();
                if (taiKhoan != aa.tach[0])
                {
                    aa.kTra = false;
                    //hiện thông báo
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(thongBao);
                    Console.ReadKey();
                    //xoá thông báo
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(emptyLine);
                    continue;
                }
                Console.SetCursorPosition(26, 10);
                string matKhau = Console.ReadLine();
                if (matKhau == aa.tach[1]) { aa.kTra = true; break; }
                else
                {
                    aa.kTra = false;
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(thongBao);
                    Console.ReadKey();
                    //xoá thông báo
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(emptyLine);
                }

            }
            if (aa.kTra)
            {
                Console.Clear();
                menuChonChucNangGiangVien();
            }
            else
            {
                Console.Clear();
                taoLaiMatKhauGiangVien();
            }
        }
        static void taoLaiMatKhauGiangVien()
        {
            lapLai aa = new lapLai();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                    TẠO LẠI MẬT KHẨU                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               0. có                                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               1.huỷ                                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                nhập lựa chọn:                ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            aa.luaChon = chuanHoaNhap(47, 14, 14, 1);
            if (aa.luaChon == 0)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
                Console.WriteLine("║                    ╚════════════════════╝                    ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                        TẠO LẠI MẬT KHẨU                      ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║              Mã giảng viên:                                  ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(29, 9);
                string maGv = Console.ReadLine();
                maGv = chuanHoaTen(maGv);
                String All = File.ReadAllText("maGiangVien.txt");
                if (maGv == All)
                {
                    Console.SetCursorPosition(22, 11);
                    Console.WriteLine("ĐÚNG");
                    Console.SetCursorPosition(15, 13);
                    Console.WriteLine("Mật khẩu mới:");
                    Console.SetCursorPosition(28, 13);
                    string matKhauMoi = Console.ReadLine();
                    string all = File.ReadAllText("taiKhoanGiangVien.txt");
                    aa.tach1 = "";
                    aa.tach = all.Split(',');
                    aa.tach[1] = matKhauMoi;
                    aa.tach1 = string.Join(',', aa.tach);
                    StreamWriter ghiMoi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\taiKhoanGiangVien.txt");

                    ghiMoi.WriteLine(aa.tach1);

                    ghiMoi.Close();
                    giangVien();
                }
                else giangVien();
            }
            else giangVien();

        }
        static void menuChonChucNangGiangVien()
        {
            lapLai aa = new lapLai();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               Chức năng                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    0. hiển thị điểm                                          ║");
            Console.WriteLine("║    1. sửa thông tin                                          ║");
            Console.WriteLine("║    2. nhập thông tin                                         ║");
            Console.WriteLine("║    3. thông báo cho phụ huynh                                ║");
            Console.WriteLine("║    4. thông báo                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                   nhập lựa chọn:             ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(50, 14, 11, 4);
            switch (aa.luaChon)
            {
                case 0:
                    hienThiDiemGiangVien();
                    break;
                case 1:
                    suaThongTin();
                    break;
                case 2:
                    nhapDuLieu();
                    break;
                case 3:
                    thongBaoChoPhuHuynh();
                    break;
                case 4:
                    phanHoiCuaSinhVien();
                    break;
            }
        }
        static void hienThiDiemGiangVien()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                         Hiển thị điểm                        ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    1. tất cả các môn                                         ║");
            Console.WriteLine("║    2. môn chỉ định                                           ║");
            Console.WriteLine("║    0. Thoát                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                   Nhập lựa chọn:             ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(50, 11, 11, 2);
            switch (aa.luaChon)
            {
                default:
                    Console.Clear();
                    menuChonChucNangGiangVien();
                    break;
                case 2:
                    oneMonGiangVien();
                    break;
                case 1:
                    tatCaCacMonGiangVien();
                    break;
            }
        }
        static void tatCaCacMonGiangVien()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               hiển thị điểm                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    0. tất cả sinh viên                                       ║");
            Console.WriteLine("║    1. sinh viên chỉ định                                     ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                    Nhập lựa chọn:            ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(51, 11, 11, 1);
            switch (aa.luaChon)
            {

                case 1:
                    allMonOneSV();
                    break;
                case 0:
                    allMonallSV();
                    break;
            }
        }
        static void oneMonGiangVien()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    0. tất cả học sinh                                        ║");
            Console.WriteLine("║    1. học sinh chỉ định                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                      Nhập lựa chọn:          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(53, 13, 11, 1);
            switch (aa.luaChon)
            {
                case 0:
                    oneMonAllsv();
                    break;
                case 1:
                    oneMonOneSV();
                    break;
            }
        }
        static void hienThiDiemSinhVien()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    1. tất cả các môn                                         ║");
            Console.WriteLine("║    2. môn nhập vào                                           ║");
            Console.WriteLine("║    3. sắp xếp                                                ║");
            Console.WriteLine("║    0. Thoát                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                     Nhập lựa chọn:           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(52, 13, 13, 3);
            switch (aa.luaChon)
            {
                default:
                    menuChonChucNangHocSinh();
                    break;
                case 2:
                    oneMon();
                    break;
                case 1:
                    allMon();
                    break;
                case 3:
                    sapXep();
                    break;
            }
        }
        static void suaThongTin()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                           Sửa                                ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    1. Xoá                                                    ║");
            Console.WriteLine("║    2. Sửa                                                    ║");
            Console.WriteLine("║    0. Thoát                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                     Nhập lựa chon:           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int LuaChon = chuanHoaNhap(52, 12, 12, 2);
            switch (LuaChon)
            {
                case 1:
                    Console.SetCursorPosition(1, 14);
                    hienThiCacMonTrongTep();
                    xoa();
                    break;
                case 2:
                    sua();
                    break;
                case 0:
                    Console.Clear();
                    menuChonChucNangGiangVien();
                    break;
            }
        }
        static void nhapDuLieu()
        {
            //viết giao diện
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                         NHẬP THÔNG TIN                       ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║      MaSV:                                                   ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║            Tên:                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║            Điểm:                                             ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║            Số tín:                                           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");


            int nhap;
            do
            {
                if (File.Exists("thongTin.txt"))
                {
                    Console.SetCursorPosition(12, 6);
                    string ma = Console.ReadLine();
                    ma = chuanHoaTen(ma);
                    Console.SetCursorPosition(18, 8);
                    string ten = Console.ReadLine();
                    ten = chuanHoaTen(ten);
                    bool qua = true;

                    string[] all = File.ReadAllLines("thongTin.txt");

                    foreach (string s in all)
                    {

                        string[] one = s.Split(',');
                        if (ten == one[0] && ma == one[4]) qua = false;
                    }


                    StreamWriter ghi = new StreamWriter("thongTin.txt", append: true);
                    if (qua)
                    {

                        ghi.Write(ten + ",");
                    }
                    else
                    {
                        Console.SetCursorPosition(2, 14);
                        Console.WriteLine("môn đã tồn tại");
                        Console.ReadKey();
                        goto loi;
                    }

                    double soDiem = chuanHoaThuc(18, 10, 15);
                    ghi.Write(soDiem + ",");
                    int soTin = chuanHoaNhap(20, 12, 15, 10);
                    ghi.Write(soTin + ",");
                    if (soDiem < 5) ghi.Write("không đạt,");
                    else ghi.Write("đạt,");
                    ghi.WriteLine(ma);
                loi:
                    {
                        Console.SetCursorPosition(2, 14);
                        Console.Write("bạn có muốn tiếp tục không (có-1, không-0):");
                        nhap = int.Parse(Console.ReadLine());
                    }
                    ghi.Close();


                }
                else
                {
                    Console.SetCursorPosition(12, 6);
                    string ma = Console.ReadLine();
                    ma = chuanHoaTen(ma);
                    Console.SetCursorPosition(18, 8);
                    string ten = Console.ReadLine();
                    ten = chuanHoaTen(ten);
                    StreamWriter ghi = new StreamWriter("thongTin.txt");

                    ghi.Write(ten + ",");

                    double soDiem = chuanHoaThuc(18, 10, 15);
                    ghi.Write(soDiem + ",");
                    int soTin = chuanHoaNhap(20, 12, 15, 10);
                    ghi.Write(soTin + ",");
                    if (soDiem < 5) ghi.Write("không đạt,");
                    else ghi.Write("đạt,");
                    ghi.WriteLine(ma);
                    ghi.Close();
                    Console.SetCursorPosition(2, 14);
                    Console.Write("bạn có muốn tiếp tục không (có-1, không-0):");
                    nhap = int.Parse(Console.ReadLine());
                }
            } while (nhap == 1);
            Console.ReadKey();
            Console.Clear();


        }
        static void thongBaoChoPhuHuynh()
        {
            Console.Clear();
            Console.Write("Nhập nội dung thông báo: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Đã thành công");
        }
        static void phanHoiCuaSinhVien()
        {

            lapLai aa = new lapLai();
            Console.Clear();
            //lấy chuỗi
            string[] all = File.ReadAllLines("thongBaoQuanLy.txt");
            //tạ bảng hiển thị kết quả

            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║  maSV      Tên môn                              Điểm         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;

            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');
                Console.SetCursorPosition(3, x);
                x++;
                Console.WriteLine("{0,-10:}{1,-37:}{2,-13:}", one[2], one[0], one[1]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                           Sửa                                ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    1. không thay dổi                                         ║");
            Console.WriteLine("║    0. thay đổi                                               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                     Nhập lựa chon:           ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            aa.luaChon = chuanHoaNhap(52, 12, 12, 1);
            switch (aa.luaChon)
            {
                case 0:
                    nhapLai();
                    break;
                case 1:
                    khongThayDoi();
                    break;
            }
        }

        //học sinh
        static void manHinhDangNhapHocSinh()
        {
            lapLai aa = new lapLai();

            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                     Quản lý điểm sinh viên                   ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               Tài khoản:                                     ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               Mật khẩu:                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                   Đăng nhập                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            bool kTra = true;
            string thongBao = "không thành công!";
            string taiKhoan, matKhau;
            string emptyLine = new string(' ', thongBao.Length);

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(36, 13);
                Console.WriteLine("Đăng nhập");
                Console.SetCursorPosition(26, 8);
                taiKhoan = Console.ReadLine();
                Console.SetCursorPosition(26, 10);
                matKhau = Console.ReadLine();


                //lấy tại khoản từ tệp
                string[] all = File.ReadAllLines("taiKhoanSinhVien.txt");
                foreach (string All in all)
                {
                    aa.tach = All.Split(',');

                    if (taiKhoan != aa.tach[0])
                    {
                        kTra = false;
                        continue;
                    }
                    if (matKhau == aa.tach[1])
                    {
                        kTra = true;
                        StreamWriter ghi = new StreamWriter("maSV.txt");
                        ghi.Write(aa.tach[2]);
                        ghi.Close();
                        break;
                    }
                    else
                    {
                        kTra = false;
                    }
                }



                if (kTra) break;
                else
                {
                    //hiện thông báo
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(thongBao);
                    Console.ReadKey();
                    ///xoá thông báo
                    Console.SetCursorPosition(36, 13);
                    Console.WriteLine(emptyLine);
                }

            }
            if (kTra)
            {
                Console.Clear();
                hienThiThongBaoDaDuocSua(layMaSV());
                hienThiThongBaoKhongDuocSua(layMaSV());
                menuChonChucNangHocSinh();
            }
            else { Console.Clear(); taoLaiMatKhauSinhVien(); }



        }

        static void taoLaiMatKhauSinhVien()
        {
            lapLai aa = new lapLai();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                    TẠO LẠI MẬT KHẨU                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               0. có                                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║               1.huỷ                                          ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                nhập lựa chọn:                ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            int luaChon = chuanHoaNhap(47, 14, 14, 1);
            if (luaChon == 0)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
                Console.WriteLine("║                    ╚════════════════════╝                    ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                        TẠO LẠI MẬT KHẨU                      ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║              Mã sinh viên:                                   ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("║                                                              ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(28, 9);
                string maSV = Console.ReadLine();
                String[] All = File.ReadAllLines("taiKhoanSinhVien.txt");
                foreach (string s in All)
                {
                    aa.tach = s.Split(',');
                    if (maSV == aa.tach[2])
                    {

                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("ĐÚNG");
                        Console.SetCursorPosition(15, 13);
                        Console.WriteLine("Mật khẩu mới:");
                        Console.SetCursorPosition(28, 13);
                        string matKhauMoi = Console.ReadLine();
                        aa.tach[1] = matKhauMoi;
                        aa.tach1 = string.Join(',', aa.tach);
                        xoaMKCu(maSV);
                        StreamWriter ghiMoi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\taiKhoanSinhVien.txt", append: true);

                        ghiMoi.WriteLine(aa.tach1);

                        ghiMoi.Close();
                        hocSinh();
                    }
                }

            }
            else hocSinh();
        }

        static void menuChonChucNangHocSinh()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                          Chức năng                           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    0. hiển thị điểm                                          ║");
            Console.WriteLine("║    1. các môn cần học lại                                    ║");
            Console.WriteLine("║    2. phúc khảo                                              ║");
            Console.WriteLine("║    3. Điểm trung bình theo tín:                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                   nhập lựa chọn:             ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int luaChon = chuanHoaNhap(50, 13, 13, 3);
            switch (luaChon)
            {
                case 0:
                    hienThiDiemSinhVien();
                    break;
                case 1:
                    cacMonHocLai();
                    break;
                case 2:
                    phucKhao();
                    break;
                case 3:
                    diemTB();
                    break;
            }
        }

        static void oneMon()
        {

            //lấy chuỗi
            string[] all = File.ReadAllLines("thongTin.txt");
            //tạ bảng hiển thị kết quả
            //tạo bảng
            bool kQ = true;
            string maSV = layMaSV();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║          môn nhập vào:                                       ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            //tìm và hiển thị

            hienThiCacMonCua1SV(maSV);
            Console.SetCursorPosition(24, 7);
            string find = Console.ReadLine();
            find = chuanHoaTen(find);
            Console.Clear();
            //tạ bảng hiển thị kết quả
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');

                if (one[4] == maSV)
                {


                    if (find == one[0])
                    {
                        kQ = false;
                        int x = 5;
                        Console.SetCursorPosition(5, x);
                        x++;
                        Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
                        break;
                    }
                }
            }

            if (kQ) Console.WriteLine("môn không tồn tại");
            Console.ReadKey();
            Console.Clear();

        }
        static void oneMonOneSV()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║          MaSV nhập vào:                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            //lấy chuỗi
            string[] all = File.ReadAllLines("thongTin.txt");
            //tạ bảng hiển thị kết quả
            //tạo bảng
            int soLuong = all.Length;
            int dem = 0, dem2 = 0;
            Console.SetCursorPosition(25, 7);
            string maSV = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║          Môn nhập vào:                                       ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

            hienThiCacMonCua1SV(maSV);
            Console.SetCursorPosition(24, 7);
            string find = Console.ReadLine();
            find = chuanHoaTen(find);
            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');

                if (one[4] == maSV)
                {

                    
                    //tìm và hiển thị

                    if (find == one[0])
                    {
                        Console.Clear();
                        //tạ bảng hiển thị kết quả
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
                        Console.WriteLine("║                    ╚════════════════════╝                    ║");
                        Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("║                                                              ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                        int x = 5;
                        Console.SetCursorPosition(5, x);
                        x++;
                        Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
                        break;
                    }
                    else  dem2++;

                }
                else { dem++; }
            }
            if (dem2 == soLuong-dem)
                {Console.SetCursorPosition(4, 17);
                Console.WriteLine("môn không tồn tại");
            }
            if (dem == soLuong)
                {Console.SetCursorPosition(4, 16);
                Console.WriteLine("maSV không tồn tại");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void oneMonAllsv()
        {

            Console.Clear();
            //lấy chuỗi
            string[] all = File.ReadAllLines("thongTin.txt");
            int soLuong = all.Length;
            int dem = 0;
            //tạ bảng hiển thị kết quả
            //tạo bảng
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                      Hiển thị điểm                           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║          Môn nhập vào:                                       ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            hienThiCacMonTrongTep();
            Console.SetCursorPosition(24, 7);
            string find = Console.ReadLine();
            find = chuanHoaTen(find);
            Console.Clear();
            //tạ bảng hiển thị kết quả
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;
            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');

                //tìm và hiển thị

                if (find == one[0])
                {
                    Console.SetCursorPosition(5, x);
                    x++;
                    Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
                }
                else { dem++; }


            }
            if (dem == soLuong) Console.WriteLine("môn không tồn tại");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("bạn có muốn nhập lại không? 1-có, 0-không");
            int luaChon = chuanHoaNhap(1, 1, 1, 1);
            switch (luaChon)
            {
                case 1:
                    oneMonAllsv();
                    break;
            }
        }
        static string layMaSV()
        {
            string s = File.ReadAllText("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\maSV.txt");
            return s;
        }
        static void allMon()
        {
            Console.Clear();
            string[] all = File.ReadAllLines("thongTin.txt");
            //tạ bảng hiển thị kết quả
            //tạo bảng
            int x = 5;
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            string maSV = layMaSV();
            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');

                if (one[4] == maSV)
                {
                    Console.SetCursorPosition(5, x);
                    x++;
                    Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
                }

            }

           
            Console.ReadKey();
            Console.Clear();
        }
        static void allMonOneSV()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                        Hiển thị điểm                         ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║          MaSV nhập vào:                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            //lấy chuỗi
            string[] all = File.ReadAllLines("thongTin.txt");
            //tạ bảng hiển thị kết quả
            //tạo bảng
            int soLuong = all.Length;
            int dem = 0;
            Console.SetCursorPosition(25, 7);
            string maSV = Console.ReadLine();
            maSV = chuanHoaTen(maSV);
            int x = 5;
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');

                if (one[4] == maSV)
                {
                    Console.SetCursorPosition(5, x);
                    x++;
                    Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
                }
                else { dem++; }
            }

            if (dem == soLuong)
            {
                Console.WriteLine("maSV không tồn tại");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("bạn có muốn nhập lại không? 1-có, 0-không");
            int luaChon = chuanHoaNhap(1, 1, 1, 1);
            switch (luaChon)
            {
                case 1:
                    allMonOneSV();
                    break;
            }
        }
        static void allMonallSV()
        {
            Console.Clear();
            //lấy chuỗi
            string[] all = File.ReadAllLines("thongTin.txt");
            //tạ bảng hiển thị kết quả
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    MaSV      Tên              Điểm    Số tín    Kết quả      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;

            foreach (string s in all)
            {
                //tách chuỗi
                string[] one = s.Split(',');
                Console.SetCursorPosition(5, x);
                x++;
                Console.WriteLine("{0,-10:}{1,-17:}{2,-8:}{3,-10:}{4,-13:}", one[4], one[0], one[1], one[2], one[3]);
            }

            Console.ReadKey();
            Console.Clear();
        }
        static void sapXep()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                           Sắp xếp                            ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    1. cao đến thấp                                           ║");
            Console.WriteLine("║    2. thấp đến cao                                           ║");
            Console.WriteLine("║    0. Thoát                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                    Nhập lựa chọn:            ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int luaChon = chuanHoaNhap(51, 11, 11, 2);
            switch (luaChon)
            {
                default:
                    hienThiDiemGiangVien();
                    break;
                case 2:
                    Tang();
                    break;
                case 1:
                    giam();
                    break;
            }
        }
        static void Tang()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            string[] all = File.ReadAllLines("thongTin.txt");
            var diemChuan = new List<float>();

            string maSV = layMaSV();
            foreach (string line in all)
            {
                aa.tach = (line).Split(',');
                if (aa.tach[4] == maSV)
                {
                    float chuyen = float.Parse(aa.tach[1]);
                    diemChuan.Add(chuyen);

                }
            }
            diemChuan.Sort();
            List<string> stringList = diemChuan.Select(f => f.ToString()).ToList();
            //in ra danh sách đã sắp xếp
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    Tên               Điểm       Số tín     Kết quả           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;

            foreach (string a in stringList)
            {

                foreach (string line in all)

                {
                    aa.tach = (line).Split(',');


                    if (aa.tach[1] == a && aa.tach[4] == maSV)
                    {
                        Console.SetCursorPosition(5, x);
                        x++;
                        Console.WriteLine("{0,-18:}{1,-11:}{2,-11:}{3,-18:}", aa.tach[0], aa.tach[1], aa.tach[2], aa.tach[3]);
                    }
                }
            }



            Console.ReadKey();
            Console.Clear();
        }
        static void giam()
        {
            lapLai aa = new lapLai();
            Console.Clear();
            string[] all = File.ReadAllLines("thongTin.txt");
            var diemChuan = new List<float>();

            string maSV = layMaSV();
            foreach (string line in all)
            {
                aa.tach = (line).Split(',');
                if (aa.tach[4] == maSV)
                {
                    float chuyen = float.Parse(aa.tach[1]);
                    diemChuan.Add(chuyen);

                }
            }
            diemChuan.Sort();
            diemChuan.Reverse();
            List<string> stringList = diemChuan.Select(f => f.ToString()).ToList();
            //in ra danh sách đã sắp xếp
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    Tên               Điểm       Số tín     Kết quả           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;

            foreach (string a in stringList)
            {
                Console.Write(a);
                foreach (string line in all)

                {
                    aa.tach = (line).Split(',');

                    Console.Write(aa.tach[1]);
                    if (aa.tach[1] == a && aa.tach[4] == maSV)
                    {
                        Console.SetCursorPosition(5, x);
                        x++;
                        Console.WriteLine("{0,-18:}{1,-11:}{2,-11:}{3,-18:}", aa.tach[0], aa.tach[1], aa.tach[2], aa.tach[3]);
                    }
                }
            }



            Console.ReadKey();
            Console.Clear();
        }
        static void cacMonHocLai()
        {
            bool kQ = true;
            string maSV = layMaSV();
            lapLai aa = new lapLai();
            Console.Clear();
            string[] all = File.ReadAllLines("thongTin.txt");
            var tam = new List<float>();
            foreach (string line in all)
            {
                aa.tach = (line).Split(',');
                float chuyen = float.Parse(aa.tach[1]);
                if (chuyen < 5 && aa.tach[4] == maSV)
                {
                    tam.Add(chuyen);
                }
            }
            List<string> stringList = tam.Select(f => f.ToString()).ToList();

            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║    Tên               Điểm       Số tín     Kết quả           ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            int x = 5;
            foreach (string a in stringList)
            {

                foreach (string line in all)

                {
                    aa.tach = (line).Split(',');


                    if (aa.tach[1] == a && aa.tach[4] == maSV)
                    {
                        kQ = false;
                        Console.SetCursorPosition(5, x);
                        x++;
                        Console.WriteLine("{0,-18:}{1,-11:}{2,-11:}{3,-18:}", aa.tach[0], aa.tach[1], aa.tach[2], aa.tach[3]);
                    }

                }
            }
            if (kQ) Console.WriteLine("không có môn nào học lại");
            Console.ReadKey();
            Console.Clear();
        }


        static void hienThiCacMonTrongTep()
        {
            string s;
            StreamReader doc = new StreamReader("thongTin.txt");
            Console.WriteLine("tên,mã");
            while ((s = doc.ReadLine()) != null)
            {
                int cuoi = s.LastIndexOf(',') + 1;
                string kQ2 = s.Substring(cuoi, s.Length - cuoi);
                int dau = s.IndexOf(',');
                string kQ = s.Substring(0, dau);
                Console.WriteLine(kQ + "," + kQ2);

            }
            doc.Close();
        }
        static void hienThiCacMonCua1SV(string maSV)
        {
            string s;
            StreamReader doc = new StreamReader("thongTin.txt");
            Console.WriteLine("tên:");
            while ((s = doc.ReadLine()) != null)
            {
                int cuoi = s.LastIndexOf(",") + 1;
                string dieuKien = s.Substring(cuoi, s.Length - cuoi);
                if (dieuKien == maSV)
                {
                    int dau = s.IndexOf(',');
                    string kQ = s.Substring(0, dau);
                    Console.WriteLine(kQ);
                }
            }
            doc.Close();
        }

        static void xoaMKCu(string ma)
        {

            string s;
            StreamReader doc = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\taiKhoanSinhVien.txt");
            var tam = new List<string>();


            while ((s = doc.ReadLine()) != null)
            {
                int cuoi = s.LastIndexOf(',') + 1;
                string kQ2 = s.Substring(cuoi, s.Length - cuoi);

                if (kQ2 == ma) continue;
                tam.Add(s);

            }
            doc.Close();
            StreamWriter ghi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\taiKhoanSinhVien.txt");

            for (int i = 0; i < tam.Count; i++)
            {
                ghi.Write(tam[i] + "\n");
            }
            ghi.Close();
            Console.ReadKey();
            Console.Clear();
        }

        static void xoa()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                            Xoá                               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập mã:                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập tên:                                                 ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(1, 14);
            hienThiCacMonTrongTep();
            Console.SetCursorPosition(13, 6);
            string ma = Console.ReadLine();
            Console.SetCursorPosition(14, 8);
            string a = Console.ReadLine();
            bool inRa = false;
            string s;
            a = chuanHoaTen(a);
            StreamReader doc = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongTin.txt");
            var tam = new List<string>();


            while ((s = doc.ReadLine()) != null)
            {
                int cuoi = s.LastIndexOf(',') + 1;
                string kQ2 = s.Substring(cuoi, s.Length - cuoi);
                int dau = s.IndexOf(',');
                string kQ = s.Substring(0, dau);
                if (kQ == a && kQ2 == ma)
                    {inRa = true;
                    continue;
                }
                tam.Add(s);

            }
            doc.Close();
            StreamWriter ghi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongTin.txt");
            foreach (string b in tam)
            {
                ghi.WriteLine(b);
            }
            ghi.Close();
            if (inRa)
                {Console.SetCursorPosition(2, 12);
                Console.WriteLine("đã Xoá thành công");
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void sua()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                            Sửa                               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập mã:                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập tên:                                                 ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(1, 14);
            hienThiCacMonTrongTep();
            Console.SetCursorPosition(13, 6);
            string ma = Console.ReadLine();
            Console.SetCursorPosition(14, 8);
            string a = Console.ReadLine();

            string s;
            a = chuanHoaTen(a);
            var tam = new List<string>();

            string[] all = File.ReadAllLines("thongTin.txt");
            string tach1 = "";
            bool thongBao = false;
            foreach (string one in all)
            {

                string[] tach = one.Split(',');
                if (tach[0] == a && tach[4] == ma)
                {
                    Console.Clear();
                    Console.WriteLine("0-ten, 1-diem, 2-soTin, 3-ma");
                    int cot = chuanHoaNhap(1, 1, 1, 3);

                    switch (cot)
                    {
                        case 0:
                            bool qua = true;
                            Console.SetCursorPosition(1, 3);
                            Console.Write("nhập nội dung sửa:");
                            string ten = chuanHoaTen(Console.ReadLine());
                            foreach (string kiemTra in all)
                            {

                                string[] tachKiemTRa = kiemTra.Split(',');
                                if (ten == tachKiemTRa[0] && ma == tachKiemTRa[4]) qua = false;
                            }
                            if (qua) {tach[0] = ten;thongBao = true; }
                            else
                                {Console.SetCursorPosition(1, 4);
                                Console.WriteLine("lỗi");
                            }
                            break;
                        case 1:
                            Console.SetCursorPosition(1, 3);
                            Console.Write("nhập nội dung sửa:");
                            double diem = chuanHoaThuc(19, 3, 4);
                            if (diem < 5) tach[3] = "không đạt";
                            else tach[3] = "đạt";
                            tach[1] = "" + diem;
                            thongBao = true;
                            break;
                        case 2:
                            Console.SetCursorPosition(1, 3);
                            Console.Write("nhập nội dung sửa:");
                            tach[2] = "" + chuanHoaNhap(19, 3, 4, 10);
                            thongBao = true;
                            break;
                        case 3:
                            bool kQ = true;
                            Console.SetCursorPosition(1, 3);
                            Console.Write("nhập nội dung sửa:");
                            string maKiemTra = chuanHoaTen(Console.ReadLine());
                            foreach (string kiemTra in all)
                            {

                                string[] tachKiemTRa = kiemTra.Split(',');
                                if (maKiemTra == tachKiemTRa[4] && a == tachKiemTRa[0]) qua = false;
                            }
                            if (kQ) {tach[4] = maKiemTra;thongBao = true; }
                            else
                            {
                                Console.SetCursorPosition(1, 4);
                                Console.WriteLine("lỗi");
                            }
                            break;

                    }

                }
                tach1 = string.Join(',', tach);
                tam.Add(tach1);


            }
            StreamWriter ghi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongTin.txt");
            foreach (string b in tam)
            {
                ghi.WriteLine(b);
            }
            ghi.Close();
            if(thongBao)
            {
                Console.WriteLine(" đã sửa thành công");
            }
            Console.ReadKey();
            Console.Clear();
        }


        static int chuanHoaNhap(int x, int y, int z, int t)//x,y l^3 chỉ số của setCursor hiển thị giá trị nhập
                                                           //z chỉ số dòng của setCur hiển thị thông báo
                                                           //t giá trị 0--t của lựa chọn
        {
            bool kQ = true;
            string baoLoi = "";
            string a;
            int aChuyennguyen = 0;
            do
            {
                Console.SetCursorPosition(x, y);
                a = Console.ReadLine();
                string so = "0123456789";
                int dem = 0;
                foreach (char c in a)
                {
                    foreach (char d in so)
                    {
                        if (c == d) dem++;
                    }
                }
                if (dem != a.Length)
                {
                    kQ = false;

                }
                else
                {
                    aChuyennguyen = int.Parse(a);
                    if (aChuyennguyen > t || aChuyennguyen < 0) kQ = false;
                    else
                    {
                        kQ = true;
                        break;
                    }

                }
                Console.SetCursorPosition(2, z);
                Console.WriteLine("yêu cầu nhập lại");

            } while (kQ == false);

            return aChuyennguyen;
        }
        static string chuanHoaTen(string a)
        {
            //lấy từng kí tự
            StringBuilder dau = new StringBuilder(a.Trim());
            // viết hoa kí tự đầu tiên
            dau[0] = char.ToUpper(dau[0]);
            for (int i = 0; i < dau.Length; i++)
            {
                //gặp = thì so sánh với phân tử ở vị trí tiếp theo
                if (dau[i] == ' ')
                {
                    int lap = i + 1;
                    while (dau[lap] == ' ')
                    {
                        dau.Remove(lap, 1);
                    }
                    //viết hoa kí tự sau cách
                    dau[lap] = char.ToUpper(dau[lap]);
                }
            }
            //trả lại xâu
            return dau.ToString();
        }
        static double chuanHoaThuc(int x, int y, int z)//x,y l^3 chỉ số của setCursor hiển thị giá trị nhập
                                                       //z chỉ số dòng của setCur hiển thị thông báo

        {
            bool kQ = true;
            string baoLoi = "";
            string a;
            double aChuyenthuc = 0;
            do
            {
                Console.SetCursorPosition(x, y);
                a = Console.ReadLine();
                string so = "0123456789.,";
                int dem = 0;
                foreach (char c in a)
                {
                    foreach (char d in so)
                    {
                        if (c == d) dem++;
                    }
                }
                if (dem != a.Length)
                {
                    kQ = false;

                }
                else
                {
                    aChuyenthuc = double.Parse(a);
                    if (aChuyenthuc > 10 || aChuyenthuc < 0) kQ = false;
                    else
                    {
                        kQ = true;
                        break;
                    }

                }
                Console.SetCursorPosition(2, z);
                Console.WriteLine("yêu cầu nhập lại");

            } while (kQ == false);

            return aChuyenthuc;
        }

        static void phucKhao()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                         NHẬP THÔNG TIN                       ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║            Tên:                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║            Điểm:                                             ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            string maSv = layMaSV();
            hienThiCacMonCua1SV(maSv);
            int dung = 1;
            while (dung == 1)
            {
            //thêm vào 1 file để người quản lý có thể truy cập dc                
                StreamWriter ghi = new StreamWriter("thongBaoQuanLy.txt", append: true);
                //nhập nội dung cần phúc khảo
                Console.SetCursorPosition(18, 8);
                string ten = Console.ReadLine();
                ten = chuanHoaTen(ten);
                ghi.Write(ten + ",");
                double diem = chuanHoaThuc(18, 10, 15);
                ghi.Write(diem + ",");
                ghi.WriteLine(maSv);
                Console.SetCursorPosition(2, 14);
                Console.Write("bạn có muốn tiếp tục không (có-1, không-0):");
                dung = int.Parse(Console.ReadLine());
                ghi.Close();
            StreamWriter ghi1 = new StreamWriter("thongBaoGiangVien.txt",append:true);
            ghi1.WriteLine("có sinh vien cần phúc khảo");
            ghi1.Close();
            }
            
            Console.ReadKey();
            Console.Clear();
        }

        static void hienThiThongBaoPhucKhao()
        {
            if (File.Exists("thongBaoGiangVien.txt"))
            { Console.WriteLine(File.ReadAllText("thongBaoGiangVien.txt")); Console.ReadKey(); }
        }

        static void nhapLai()
        {
            //nhập giá trị cần thay đổi
            //sửa
            bool kiemTraSuTonTaiMon = true;
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                            Sửa                               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập mã:                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập tên:                                                 ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(1, 14);
            hienThiCacMonTrongTep();
            Console.SetCursorPosition(13, 6);
            string ma = Console.ReadLine();
            Console.SetCursorPosition(14, 8);
            string a = Console.ReadLine();

            string s;
            a = chuanHoaTen(a);
            var tam = new List<string>();

            string[] all = File.ReadAllLines("thongTin.txt");
            string tach1 = "";
            foreach (string one in all)
            {

                string[] tach = one.Split(',');
                if (tach[0] == a && tach[4] == ma)
                {
                    kiemTraSuTonTaiMon = false;
                    Console.WriteLine("0-ten, 1-diem, 2-soTin, 3-ma");
                    int cot = chuanHoaNhap(1, 1, 1, 3);

                    switch (cot)
                    {
                        case 0:
                            bool qua = true;
                            string ten = chuanHoaTen(Console.ReadLine());
                            foreach (string kiemTra in all)
                            {

                                string[] tachKiemTRa = kiemTra.Split(',');
                                if (ten == tachKiemTRa[0] && ma == tachKiemTRa[4]) qua = false;
                            }
                            if (qua) tach[0] = ten;
                            else Console.WriteLine("lỗi");
                            break;
                        case 1:
                            Console.ReadKey();
                            Console.Clear();
                            Console.SetCursorPosition(1, 3);
                            Console.Write("nhập nội dung sửa:");
                            double diem = chuanHoaThuc(19, 3, 4);
                            if (diem < 5) tach[3] = "không đạt";
                            else tach[3] = "đạt";
                            tach[1] = "" + diem;
                            break;
                        case 2:
                            tach[2] = "" + chuanHoaNhap(1, 1, 1, 10);
                            break;
                        case 3:
                            bool kQ = true;
                            string maKiemTra = chuanHoaTen(Console.ReadLine());
                            foreach (string kiemTra in all)
                            {

                                string[] tachKiemTRa = kiemTra.Split(',');
                                if (maKiemTra == tachKiemTRa[4] && a == tachKiemTRa[0]) qua = false;
                            }
                            if (kQ) tach[4] = maKiemTra;
                            else Console.WriteLine("lỗi");
                            break;

                    }

                }

                tach1 = string.Join(',', tach);
                tam.Add(tach1);
                //có thông báo khi diểm dc sửa
               
            }
            if (File.Exists("thongBaoSinhVien.txt"))
            {
                StreamWriter ghi1 = new StreamWriter("thongBaoSinhVien.txt", append: true);
                ghi1.WriteLine("{0},Môn {1} đã được sửa", ma, a);
                ghi1.Close();
            }
            else
            {
                StreamWriter ghi1 = new StreamWriter("thongBaoSinhVien.txt");
                ghi1.WriteLine("{0},Môn {1} đã được sửa", ma, a);
                ghi1.Close();
            }
            if (kiemTraSuTonTaiMon)
                {Console.SetCursorPosition(3, 12);
                Console.WriteLine("môn không tồn tại");
            }

            StreamWriter ghi = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongTin.txt");
            foreach (string b in tam)
            {
                ghi.WriteLine(b);

            }
            ghi.Close();
            //xoá ở thông báo màn hình đăng nhập giảng viên
            StreamReader docManHinh = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoGiangVien.txt");


            var tamManHinh = new List<string>();

            int dem = 0;
            while ((s = docManHinh.ReadLine()) != null)
            {
                if (dem == 0)
                {
                    dem = 1;
                    continue;
                }
                tamManHinh.Add(s);



            }
            docManHinh.Close();
            StreamWriter ghiManHinh = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoGiangVien.txt");
            foreach (string b in tamManHinh)
            {
                ghiManHinh.WriteLine(b);
            }
            ghiManHinh.Close();
            Console.ReadKey();
            Console.Clear();



            //xoá những thôgn tin mà đã thay đổi rồi
            //ở thông báo của giảng viên
            StreamReader doc = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoQuanLy.txt");

            var tamXoa = new List<string>();


            while ((s = doc.ReadLine()) != null)
            {
                int cuoi = s.LastIndexOf(',') + 1;
                string kQ2 = s.Substring(cuoi, s.Length - cuoi);
                int dau = s.IndexOf(',');
                string kQ = s.Substring(0, dau);
                if (kQ == a && kQ2 == ma) continue;
                tamXoa.Add(s);

            }
            doc.Close();
            StreamWriter ghiXoa = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoQuanLy.txt");
            foreach (string b in tamXoa)
            {
                ghiXoa.WriteLine(b);
            }
            ghiXoa.Close();

            Console.ReadKey();
            Console.Clear();

        }
        static void hienThiThongBaoDaDuocSua(string ma)
        {
            bool kQ = false;
            if (File.Exists("thongBaoSinhVien.txt"))
            {
                lapLai aa = new lapLai();
                string[] all = File.ReadAllLines("thongBaoSinhVien.txt");
                foreach (string one in all)
                {
                    aa.tach = one.Split(',');
                    if (aa.tach[0] == ma)
                    {
                        string s;
                        Console.WriteLine(one); kQ = true;
                        StreamReader docManHinh = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoSinhVien.txt");


                        var tamManHinh = new List<string>();

                        int dem = 0;
                        while ((s = docManHinh.ReadLine()) != null)
                        {

                            if (aa.tach[0] == ma && dem == 0)
                            {
                                dem++;
                                continue;

                            }
                            tamManHinh.Add(s);

                        }
                        docManHinh.Close();
                        StreamWriter ghiManHinh = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoSinhVien.txt");
                        foreach (string b in tamManHinh)
                        {
                            ghiManHinh.WriteLine(b);
                        }
                        ghiManHinh.Close();
                    }

                }
                if (kQ) Console.ReadKey();
            }
        }
        static void khongThayDoi()
        {
           
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("╔════════════════════╣   →    Menu     ←  ╠════════════════════╗");
            Console.WriteLine("║                    ╚════════════════════╝                    ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                            Sửa                               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập mã:                                                  ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Nhập tên:                                                 ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(1, 14);
            hienThiCacMonTrongTep();
            Console.SetCursorPosition(13, 6);
            string ma = Console.ReadLine();
            Console.SetCursorPosition(14, 8);
            string ten = Console.ReadLine();
            ten = chuanHoaTen(ten);
            if (File.Exists("thongBaoSinhVienKhongSuaDiem.txt"))
            {
                StreamWriter ghi1 = new StreamWriter("thongBaoSinhVienKhongSuaDiem.txt", append: true);
                ghi1.WriteLine("{0},Môn {1} không được sửa", ma, ten);
                ghi1.Close();
            }
            else
            {
                StreamWriter ghi1 = new StreamWriter("thongBaoSinhVienKhongSuaDiem.txt");
                ghi1.WriteLine("{0},Môn {1} không được sửa", ma, ten);
                ghi1.Close();
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void hienThiThongBaoKhongDuocSua(string ma)
        {
            bool kQ = false;
            if (File.Exists("thongBaoSinhVienKhongSuaDiem.txt"))
            {
                lapLai aa = new lapLai();
                string[] all = File.ReadAllLines("thongBaoSinhVienKhongSuaDiem.txt");
                foreach (string one in all)
                {
                    aa.tach = one.Split(',');
                    if (aa.tach[0] == ma)
                    {
                        string s;
                        Console.WriteLine(one); kQ = true;
                        StreamReader docManHinh = new StreamReader("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoSinhVienKhongSuaDiem.txt");


                        var tamManHinh = new List<string>();

                        int dem = 0;
                        while ((s = docManHinh.ReadLine()) != null)
                        {

                            if (aa.tach[0] == ma && dem == 0)
                            {
                                dem++;
                                continue;

                            }
                            tamManHinh.Add(s);

                        }
                        docManHinh.Close();
                        StreamWriter ghiManHinh = new StreamWriter("D:\\linh tinh\\c#\\c# on vs\\baiTapLon\\baiTapLon\\bin\\Debug\\net8.0\\thongBaoSinhVienKhongSuaDiem.txt");
                        foreach (string b in tamManHinh)
                        {
                            ghiManHinh.WriteLine(b);
                        }
                        ghiManHinh.Close();
                    }

                }
                if (kQ) Console.ReadKey();
            }
        }
        static void diemTB()
        {
            lapLai aa = new lapLai();
            StreamReader doc = new StreamReader("thongTin.txt");
            float diem=0;
            int soTin,tongsoTin=0;
            string s;
            string maSV = layMaSV();
            while ((s = doc.ReadLine())!=null)
            {
                aa.tach = s.Split(',');
                if (aa.tach[4] == maSV)
                {
                    soTin = int.Parse(aa.tach[2]);
                    diem += (float.Parse(aa.tach[1])*soTin);
                    tongsoTin += soTin;
                }
            }
            Console.SetCursorPosition(33, 9);
            Console.WriteLine( diem / tongsoTin);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
