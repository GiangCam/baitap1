using baitap1;

List<HocSinh> dshs = new List<HocSinh>();
Console.Write("Nhap so luong hoc sinh:");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhap thong tin hoc sinh thu" + (i + 1) + ":");
    Console.Write("Ma hoc sinh:");
    string mahs = Console.ReadLine();
    Console.Write("Hoten Hoc sinh:");
    string hoten = Console.ReadLine();
    Console.Write("Mon Phai:");
    string phai = Console.ReadLine();
    Console.Write("Diachi:");
    string diachi = Console.ReadLine();
    Console.Write("Nhap diem mon toan");
    float toan = float.Parse(Console.ReadLine());
    Console.Write("Nhap diem mon hoa");
    float hoa = float.Parse(Console.ReadLine());
    Console.Write("Nhap diem mon ly");
    float ly = float.Parse(Console.ReadLine());
    HocSinh hs = new HocSinh(mahs, hoten, phai, diachi, toan, hoa, ly);
    dshs.Add(hs); }
    Console.WriteLine("Danh sach hoc sinh");
        for(int i=0; i<n; i++)
    {
    Console.WriteLine(dshs[i].Mahs + "\t" + dshs[i].Hoten +"\t" + dshs[i].Phai + "\t" + dshs[i].Diachi + "\t" + dshs[i].Điemtoan + "\t" + dshs[i].Diemhoa + "\t" + dshs[i].Diemly + "\t" + dshs[i].Dtb); 
    }  
        



  
        
          
        