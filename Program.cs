using System;

class HinhTamGiac
{
    // Thuộc tính
    private int chieuCao;

    // Constructor
    public HinhTamGiac(int chieuCao)
    {
        this.chieuCao = chieuCao;
    }

    // Phương thức vẽ tam giác
    public void VeTamGiac()
    {
        for (int i = 1; i <= chieuCao; i++)
        {
            // In khoảng trắng
            for (int j = 1; j <= chieuCao - i; j++)
            {
                Console.Write(" ");
            }

            // In dấu *
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập chiều cao tam giác: ");
        int h = int.Parse(Console.ReadLine());

        // Khai báo và tạo đối tượng hình tam giác
        HinhTamGiac tamGiac = new HinhTamGiac(h);

        // Gọi phương thức vẽ
        tamGiac.VeTamGiac();
    }
}