using zavdannia1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zavdannia2;
using zavdannia3;

namespace zavdannia1
{
    public class Romb
    {
    protected int a { get; set; }
    protected int d1 { get; set; }
    protected string kolir { get; }

    public string this[int i]
    {
    get
    {
    if (i == 0)
    {
    string a1 = a.ToString();
        return a1;
        }
        else if (i == 1)
        {
        string d = d1.ToString();
        return d;
        }
        else if (i == 2) { return kolir; }
        else { throw new Exception("Помилка!"); }
        }
        }

        public Romb(int a_, int d1_, string kolir_)
        {
        if (a_ > 0)
        {
        a = a_;
        }
        if (d1_ > 0)
        {
        d1 = d1_;
        }
        kolir = kolir_;
        }

        public void Otrumatu_Storonu()
        {
        Console.WriteLine($"Сторона A = {a}");
        Console.WriteLine($"Дiагональ D1 = {d1}");
        }

        public void Otrumatu_Perimetr()
        {
        int perimetr = a + a + a + a;
        Console.WriteLine($"Периметр ромба дорiвнює: {perimetr}");
        }

        public void Otrumatu_Ploschu()
        {
        int ploscha = (a * d1)/2;
        Console.WriteLine($"Площа ромба дорiвнює: {ploscha}");
        }

        public void Chi_E_Kvadratom()
        {
        if (d1 == a * Math.Sqrt(2))
        {
        Console.WriteLine("Даний ромб є квадратом!");
        }
        if (d1 != a * Math.Sqrt(2))
        {
        Console.WriteLine("Даний ромб НЕ є квадратом!");
        }
        }

        public static Romb operator ++(Romb A)
        {
        A.a++;
        A.d1++;
        return A;
        }

        public static Romb operator --(Romb A)
        {
        A.a--;
        A.d1--;
        return A;
        }

        public static Romb operator *(Romb A, int D1)
        {
        A.a = A.a * D1;
        A.d1 = A.d1 * D1;
        return A;
        }

        public static bool operator true(Romb A)
        {
        if (A.a == A.d1)
        {
        return true;
        }
        return false;
        }
        public static bool operator false(Romb A)
        {
        if (A.a != A.d1)
        {
        return false;
        }
        return true;
        }

    public static implicit operator Romb(string A)
    {
    string[] words = A.Split("\n\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
    int a = int.Parse(words[0]);
    int d1 = int.Parse(words[1]);
    string kolir = words[2];

    Romb D1 = new Romb(a, d1, kolir);
    return D1;
    }

    public static implicit operator string(Romb A)
    {
    return $"{A.a} {A.d1} {A.kolir}";
    }
    }
}

namespace zavdannia2
{
    public class VectorUShort
    {
        ushort[] ArrayUShort { get; set; }
        uint num { get; }
        uint codeError { get; set; }
        static uint num_vs { get; set; }

        public ushort this[uint i]
        {
        get
        {
        if (i > num)
        {
        codeError = 10;
        return 0;
        }
        return ArrayUShort[i];
        }
        set
        {
        if (i > num)
        {
        codeError = 10;
        }
        else
        {
        ArrayUShort[i] = value;
        }
        }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public VectorUShort()
        {
        num = 1;
        ArrayUShort = new ushort[num];
        ArrayUShort[0] = 0;
        num_vs++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public VectorUShort(uint num_)
        {
        num = num_;
        ArrayUShort = new ushort[num];
        for (int i = 0; i < num; i++)
        {
        ArrayUShort[i] = 0;
        }
        num_vs++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public VectorUShort(uint num_, ushort a)
        {
        num = num_;
        ArrayUShort = new ushort[num];
        for (int i = 0; i < num; i++)
        {
        ArrayUShort[i] = a;
        }
        num_vs++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        ~VectorUShort()
        {
        Console.WriteLine("Деструкцiя...");
        num_vs--;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void Input()
        {
            for (int i = 0; i < this.num; i++)
            {
                Console.WriteLine($"Введiть ,будь ласка, елемент A[{i}] = ");
                this.ArrayUShort[i] = ushort.Parse(Console.ReadLine());
            }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void Output()
        {
        for (int i = 0; i < this.num; i++)
        {
        Console.WriteLine($"Массив[{i}] = {this.ArrayUShort[i]}");
        }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void SetVec(ushort A)
        {
        for (int i = 0; i < this.num; i++)
        {
        this.ArrayUShort[i] = A;
        }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void SetVec(uint w, short A)
        {
        if (w < 0 || w > num) { Console.WriteLine("Помилка!"); }
        else
        {
        this.ArrayUShort[w] = (ushort)num;
        }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static VectorUShort operator ++(VectorUShort A)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i]++;
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static VectorUShort operator --(VectorUShort A)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i]--;
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static VectorUShort operator +(VectorUShort A, ushort B)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i] += B;
        }
        return A;
        }

        ///Console.WriteLine("/-------------------------------------------------------/");
        public static VectorUShort operator -(VectorUShort A, ushort B)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i] -= B;
        }
        return A;
        }

        ///Console.WriteLine("/-------------------------------------------------------/");

        public static VectorUShort operator *(VectorUShort A, ushort B)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i] *= B;
        }
        return A;
        }
        public static VectorUShort operator /(VectorUShort A, ushort B)
        {
        for (int i = 0; i < A.num; i++)
        {
        A.ArrayUShort[i] /= B;
        }
        return A;
        }

        public static VectorUShort operator %(VectorUShort A, ushort B)
        {
        for (int i = 0; i < A.num; i++)
        {
         A.ArrayUShort[i] %= B;
        }
        return A;
        }
        public void ShowNum()
        {
        Console.WriteLine($"Кiлькiсть векторiв: {num_vs}");
        }

    }
}

///Console.WriteLine("/-------------------------------------------------------/");

namespace zavdannia3
{
    internal class MatrixUShort
    {
        short[,] ShortIntArray { get; set; }
        int n { get; set; }
        int m { get; set; }
        int codeError { get; set; }
        static int num_m { get; set; }

        ///Console.WriteLine("/-------------------------------------------------------/");
        public short this[int i, int j]
        {
        get
        {
        if (i > n && j > n)
        {
        return 0;
        }
        return ShortIntArray[i, j];
        }
        set
        {
        if (i > n && j > n)
        {
        codeError = 10;
        }
        else
        {
        ShortIntArray[i, j] = value;
        }
        }
        }

        ///Console.WriteLine("/-------------------------------------------------------/");
        ///
        public short this[int index]
        {
        get
        {
        if (index < n * m - 1)
        {
        return ShortIntArray[index / m, (int)(index % m)];
        }
        else
        {
        codeError = 10;
        return 0;
        }
        }
        set
        {
        if (index < n * m - 1)
        {
        ShortIntArray[index / m, (int)(index % m)] = value;
        }
        else
        {
        codeError = 10;
        }
        }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public MatrixUShort()
        {
        n = 1;
        m = 1;
        ShortIntArray = new short[n, m];
        ShortIntArray[0, 0] = 0;
        num_m++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public MatrixUShort(int n_, int m_)
        {
        n = n_;
        m = m_;
        ShortIntArray = new short[n, m];
        for (int i = 0; i < n; i++)
        {
        for (int j = 0; j < m; j++)
        {
        ShortIntArray[i, j] = 0;
        }
        }
        num_m++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public MatrixUShort(int n_, int m_, short a)
        {
        n = n_;
        m = m_;
        ShortIntArray = new short[n, m];
        for (int i = 0; i < n; i++)
        {
        for (int j = 0; j < m; j++)
        {
        ShortIntArray[i, j] = a;
        }
        }
        num_m++;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        ~MatrixUShort()
        {
        Console.WriteLine("Деструкцiя...");
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void Input()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    Console.WriteLine($"Input A[{i}][{j}] = ");
                    this.ShortIntArray[i, j] = short.Parse(Console.ReadLine());
                }
            }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void Output()
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    Console.Write($"Array[{i}][{j}] = {this.ShortIntArray[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void SetVec(short A)
        {
            for (int i = 0; i < this.n; i++)
            {
                for (int j = 0; j < this.m; j++)
                {
                    this.ShortIntArray[i, j] = A;
                }
            }
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public void SetVec(int n_, int m_, short A)
        {
        if (n_ < 0 || n_ > n || m_ < 0 || m_ > m) { Console.WriteLine("Error!"); }
        else
        {
        this.ShortIntArray[n_, m_] = A;

        }
        }
        public static MatrixUShort operator ++(MatrixUShort A)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j]++;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator --(MatrixUShort A)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j]--;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator +(MatrixUShort A, short B)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j] += B;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator -(MatrixUShort A, short B)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j] -= B;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator *(MatrixUShort A, short B)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j] *= B;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator /(MatrixUShort A, short B)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j] /= B;
        }
        }
        return A;
        }
        ///Console.WriteLine("/-------------------------------------------------------/");
        public static MatrixUShort operator %(MatrixUShort A, short B)
        {
        for (int i = 0; i < A.n; i++)
        {
        for (int j = 0; j < A.m; j++)
        {
        A.ShortIntArray[i, j] %= B;
        }
        }
        return A;
        }
        public void ShowNum()
        {
        Console.WriteLine($"Кiлькiсть векторiв: {num_m}");
        }

    }
}

///Console.WriteLine("/-------------------------------------------------------/");

namespace laboratorna_robota4
{
internal class Program
{
static void Main(string[] args)
{
int vubir = 0;
do
            {
            Console.Write("Яке (одне з трьох) завдання лабораторної Ви бажаєте запустити?:");
            vubir = int.Parse(Console.ReadLine());
            } while (vubir != 1 && vubir != 2 && vubir != 3);

            switch (vubir)
            {
            case 1:
            Console.WriteLine("Перше завдання:");
            {  Console.WriteLine("/-------------------------------------------------------/");
                        Console.Write("Введiть , будь ласка, розмiрнiсть сторони a: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("/-------------------------------------------------------/");

                        Console.Write("Введiть , будь ласка, розмiрнiсть сторони d1: ");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine("/-------------------------------------------------------/");

                        Console.Write("Введiть , будь ласка, колiр ромба: ");
                        string kolir = Console.ReadLine();
                        Console.WriteLine();

                        Romb A = new Romb(a, b, kolir);
                        Console.WriteLine();

                        Console.WriteLine("/-------------------------------------------------------/");

                        Console.Write("Введiть , будь ласка, iндекс:(0 або 1 чи 2)");
                        int i = int.Parse(Console.ReadLine());

                        Console.WriteLine($"A[{i}] = {A[i]}");

                        Console.WriteLine("/-------------------------------------------------------/");
                        Console.WriteLine("До операцiї '++' :");
                        A.Otrumatu_Storonu();
                        A++;

                        Console.WriteLine("/-----------------/");

                        Console.WriteLine("Пiсля операцiї '++' :");
                        A.Otrumatu_Storonu();
                        A--;

                        Console.WriteLine("/-----------------/");

                        Console.WriteLine("Пiсля операцiї '--' :");
                        A.Otrumatu_Storonu();
                        A = A * 4;

                        Console.WriteLine("/-----------------/");

                        Console.WriteLine("Пiсля операцiї '*4' :");
                        A.Otrumatu_Storonu();

                        if (A)
                        {
                        Console.WriteLine("Даний ромб Є квадратом!");
                        }
                        else
                        {
                        Console.WriteLine("Даний ромб НЕ Є квадратом!");
                        }

                        A = "2 3 синiй";
                        A.Otrumatu_Storonu();
                    }
                    break;
                case 2:
                    Console.WriteLine("Друге завдання:");
                    {

                        VectorUShort A = new VectorUShort();
                        A.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, N для другого: ");
                        uint num = uint.Parse(Console.ReadLine());
                        VectorUShort B = new VectorUShort(num);
                        B.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, N для третього: ");
                        num = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для третього: ");
                        ushort a = ushort.Parse(Console.ReadLine());
                        VectorUShort C = new VectorUShort(num, a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для сеттера:");
                        a = ushort.Parse(Console.ReadLine());
                        C.SetVec(a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, iндекс для сеттера:");
                        num = uint.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для сеттера: ");
                        a = ushort.Parse(Console.ReadLine());
                        C.SetVec(a, (short)num);
                        C.Output();

                        Console.WriteLine();
                        C.ShowNum();
                    }
                    break;
                case 3:
                    Console.WriteLine("Третє завдання:");
                    {
                        MatrixUShort A = new MatrixUShort();
                        A.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, N для другого: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, M для другого: ");
                        int m = int.Parse(Console.ReadLine());
                        MatrixUShort B = new MatrixUShort(n, m);
                        B.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, N для третього: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, M для третього: ");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для сеттера: ");
                        short a = short.Parse(Console.ReadLine());
                        MatrixUShort C = new MatrixUShort(n, m, a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для сеттера:");
                        a = short.Parse(Console.ReadLine());
                        C.SetVec(a);
                        C.Output();

                        Console.WriteLine();
                        Console.WriteLine("Введiть , будь ласка, N для сеттера: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, M для другого: ");
                        m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введiть , будь ласка, iнiцiацiю для сеттера:");
                        a = short.Parse(Console.ReadLine());
C.SetVec(n, m, a);
C.Output();

Console.WriteLine();
C.ShowNum();
}
break;
default:
Console.WriteLine("Помилка!");
break;
}
}
}
}


