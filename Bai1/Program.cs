
using System;
using System.Runtime.CompilerServices;

class Nguoi
{
    string ten;
    int tuoi;
    string cmnd;
    string quequan;
    string sdt;
    public Nguoi(string ten, int tuoi, string cmnd, string quequan, string sdt)
    {
        this.ten = ten;
        this.ten = InHoa();
        this.tuoi = tuoi;
        this.cmnd = cmnd;
        this.quequan = quequan;
        this.sdt = sdt;
    }
    ~Nguoi()
    {

    }
    public void XuatThongTin()
    {
        Console.Write("Toi ten la " + ten);
        Console.Write(" Que toi o " + quequan);
        Console.Write(" So dien thoai la " + sdt);
        Console.WriteLine(" Cmnd la " + cmnd);
        int a = kt();
        if (a == 1)
            Console.WriteLine("So dien thoai khong hop le");
        else Console.WriteLine("So dien thoai hop le");

    }
    public int kt()
    {
        int a = 0;
        for (int i = 0; i < sdt.Length; i++)
        {
            if ((i != 3 && sdt[i] < '0' && sdt[i] > '9') || (sdt[3] != '-') || sdt.Length != 11)
            {
                a = 1;
                break;
            }
            else a = 2;
        }
        return a;

    }
    public string InHoa()
    {
        string[] tam = ten.Split(' ');
        string sum = "";
        for (int i = 0; i < tam.Length; i++)
        {
            string k = tam[i].Substring(0, 1).ToUpper();
            sum = sum + k + tam[i].Substring(1).ToLower() + " ";
        }
        return sum;

    }

    public ELuaTuoi LuaTuoi()
    {
        if (tuoi > 60)
            return ELuaTuoi.nguoigia;
        else
        {
            if (tuoi < 16)
                return ELuaTuoi.treem;
            else return ELuaTuoi.thanhnien;
        }
    }
    public int DangKiChichVacXin()
    {
        ELuaTuoi c = LuaTuoi();
        if (c == ELuaTuoi.nguoigia)
            return 1;
        else
        {
            if (c == ELuaTuoi.treem)
                return 2;
            else return 3;
        }

    }
    public void KiemTraLuaTuoi()
    {
        int a = DangKiChichVacXin();
        if (a == 1)
            Console.WriteLine("La Nguoi Gia");
        else
        {
            if (a == 2)
                Console.WriteLine("La Tre em");
            else Console.WriteLine("La Thanh Nien");
        }
    }
    public void VacXin()
    {
        int a = DangKiChichVacXin();
        if (a == 1)
            Console.WriteLine("1 mui vao 15 ngay sau");
        else
        {
            if (a == 2)
                Console.WriteLine("1 mui vao 30 ngay sau");
            else Console.WriteLine("1 mui vao 10 ngay sau, 1 mui vao 20 ngay sau");
        }
    }
}
enum ELuaTuoi
{
    nguoigia,
    treem,
    thanhnien
}

class program
{
    static void Main()
    {
        Nguoi ex = new Nguoi("hoang thi my linh", 18, "066304001458", " Dac Lac", "034-9150510");
        ex.XuatThongTin();
        ex.InHoa();
        ex.KiemTraLuaTuoi();
        ex.VacXin();

    }
}



