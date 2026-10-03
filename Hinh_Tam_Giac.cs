using System;

interface IHinh
{
    double GetDienTich();
    double GetChuVi();
    void Nhap();
    void HienThi();
}

// ================= HÌNH TRÒN =================
class HinhTron : IHinh
{
    private double banKinh;

    public double BanKinh
    {
        get { return banKinh; }
        set
        {
            if (value > 0)
                banKinh = value;
            else
                throw new Exception("Bán kính phải lớn hơn 0!");
        }
    }

    // Constructor
    public HinhTron()
    {
        banKinh = 1;
    }

    public HinhTron(double banKinh)
    {
        BanKinh = banKinh;
    }

    public double GetDienTich()
    {
        return Math.PI * banKinh * banKinh;
    }

    public double GetChuVi()
    {
        return 2 * Math.PI * banKinh;
    }

    public void Nhap()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập bán kính: ");
                double r = double.Parse(Console.ReadLine());

                BanKinh = r;
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void HienThi()
    {
        Console.WriteLine("Hình tròn");
        Console.WriteLine($"Bán kính: {banKinh}");
        Console.WriteLine($"Diện tích: {GetDienTich():F2}");
        Console.WriteLine($"Chu vi: {GetChuVi():F2}");
    }
}


// ================= HÌNH CHỮ NHẬT =================
class HinhChuNhat : IHinh
{
    private double chieuDai;
    private double chieuRong;

    public double ChieuDai
    {
        get { return chieuDai; }
        set
        {
            if (value > 0)
                chieuDai = value;
            else
                throw new Exception("Chiều dài phải lớn hơn 0!");
        }
    }

    public double ChieuRong
    {
        get { return chieuRong; }
        set
        {
            if (value > 0)
                chieuRong = value;
            else
                throw new Exception("Chiều rộng phải lớn hơn 0!");
        }
    }

    // Constructor
    public HinhChuNhat()
    {
        chieuDai = 1;
        chieuRong = 1;
    }

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        ChieuDai = chieuDai;
        ChieuRong = chieuRong;
    }

    public double GetDienTich()
    {
        return chieuDai * chieuRong;
    }

    public double GetChuVi()
    {
        return 2 * (chieuDai + chieuRong);
    }

    public void Nhap()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập chiều dài: ");
                double dai = double.Parse(Console.ReadLine());

                Console.Write("Nhập chiều rộng: ");
                double rong = double.Parse(Console.ReadLine());

                ChieuDai = dai;
                ChieuRong = rong;

                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Vui lòng nhập lại!");
            }
        }
    }

    public void HienThi()
    {
        Console.WriteLine("Hình chữ nhật");
        Console.WriteLine($"Chiều dài: {chieuDai}");
        Console.WriteLine($"Chiều rộng: {chieuRong}");
        Console.WriteLine($"Diện tích: {GetDienTich():F2}");
        Console.WriteLine($"Chu vi: {GetChuVi():F2}");
    }
}


// ================= HÌNH TAM GIÁC =================
class HinhTamGiac : IHinh
{
    private double a;
    private double b;
    private double c;

    public double A
    {
        get { return a; }
        set
        {
            if (value > 0)
                a = value;
            else
                throw new Exception("Cạnh a phải lớn hơn 0!");
        }
    }

    public double B
    {
        get { return b; }
        set
        {
            if (value > 0)
                b = value;
            else
                throw new Exception("Cạnh b phải lớn hơn 0!");
        }
    }

    public double C
    {
        get { return c; }
        set
        {
            if (value > 0)
                c = value;
            else
                throw new Exception("Cạnh c phải lớn hơn 0!");
        }
    }

    // Constructor
    public HinhTamGiac()
    {
        a = 3;
        b = 4;
        c = 5;
    }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;

        if (!IsTamGiac())
            throw new Exception("Ba cạnh không tạo thành tam giác!");
    }

    // Kiểm tra 3 cạnh có tạo thành tam giác không
    public bool IsTamGiac()
    {
        return a + b > c &&
               a + c > b &&
               b + c > a;
    }

    public double GetChuVi()
    {
        return a + b + c;
    }

    public double GetDienTich()
    {
        double p = GetChuVi() / 2;

        // Công thức Heron
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public void Nhap()
    {
        while (true)
        {
            try
            {
                Console.Write("Nhập cạnh a: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh b: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Nhập cạnh c: ");
                double z = double.Parse(Console.ReadLine());

                A = x;
                B = y;
                C = z;

                if (!IsTamGiac())
                {
                    Console.WriteLine("3 cạnh không tạo thành tam giác!");
                    Console.WriteLine("Vui lòng nhập lại.\n");
                    continue;
                }

                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Vui lòng nhập lại!\n");
            }
        }
    }

    public void HienThi()
    {
        Console.WriteLine("Hình tam giác");
        Console.WriteLine($"Cạnh a: {a}");
        Console.WriteLine($"Cạnh b: {b}");
        Console.WriteLine($"Cạnh c: {c}");
        Console.WriteLine($"Diện tích: {GetDienTich():F2}");
        Console.WriteLine($"Chu vi: {GetChuVi():F2}");
    }
}


// ================= CHƯƠNG TRÌNH CHÍNH =================
class Program
{
    static void Main()
    {
        // Danh sách các đối tượng hình
        IHinh[] danhSach = new IHinh[3];

        // Tạo các đối tượng
        danhSach[0] = new HinhTron();
        danhSach[1] = new HinhChuNhat();
        danhSach[2] = new HinhTamGiac();

        Console.WriteLine("===== NHẬP THÔNG TIN =====\n");

        // Nhập dữ liệu
        for (int i = 0; i < danhSach.Length; i++)
        {
            Console.WriteLine($"--- Hình {i + 1} ---");
            danhSach[i].Nhap();
            Console.WriteLine();
        }

        Console.WriteLine("===== KẾT QUẢ =====\n");

        // Hiển thị
        foreach (IHinh hinh in danhSach)
        {
            hinh.HienThi();
            Console.WriteLine("--------------------");
        }
    }
}