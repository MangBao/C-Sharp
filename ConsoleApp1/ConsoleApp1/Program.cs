using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        //===================================================================
        /* static void BT1()
         {
             //Nhập thông tin sinh viên từ bàn phím         
             string mssv, ht;
             bool gioitinh;
             int namsinh;
             Console.Write("Ho ten: ");
             ht = Convert.ToString(Console.ReadLine());
             Console.Write("Ma so sinh vien: ");
             mssv = Convert.ToString(Console.ReadLine());
             Console.Write("Nam sinh : ");
             bool ns = int.TryParse(Console.ReadLine(), out namsinh);
             Console.Write("Gioi tinh: ");
             bool gt = bool.TryParse(Console.ReadLine(), out gioitinh);
             // In thông tin sinh viên ra màn hình
             if (gt && ns)
                 if (gioitinh)
                     Console.WriteLine("Ho ten: {0}, Ma so sinh vien: {1}, {2}\t Nam", ht, mssv, namsinh);
                 else
                     Console.WriteLine("Ho ten: {0}, Ma so sinh vien: {1}, {2}\t Nu", ht, mssv, gioitinh);
             else
                 Console.WriteLine("Loi dinh dang");

             Console.ReadKey();
         }
         //===================================================================
         static void BT2()
         {
             int a, b;
             Console.Write("Nhap a: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Nhap b: ");
             b = Convert.ToInt32(Console.ReadLine());
             float x = -Convert.ToSingle(b) / Convert.ToSingle(a);
             if (a == 0 && b != 0) Console.WriteLine("Phuong trinh vo nghiem");
             if (a == 0 && b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
             if (a != 0 && b != 0) Console.WriteLine("Phuong trinh co nghiem: -{1}/{0}={2}", a, b, x);
             Console.ReadKey();
         }
         //===================================================================
         public static int nhuan(ref int b)
         {
         //Kiểm tra năm nhuận
             if (b % 400 == 0 || (b % 4 == 0 && b % 100 != 0))
                 return 1;
             return 0;
         }
         static void BT3()
         {
             int a, b;
             Console.Write("Nhap thang: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Nhap nam: ");
             b = Convert.ToInt32(Console.ReadLine());
             int songay = 0;
             if (a >= 1 && a <= 12)
             {
                 switch (a)
                 {
                     case 1:
                     case 3:
                     case 5:
                     case 7:
                     case 8:
                     case 10:
                     case 12:
                         {
                             songay = 31;
                             break;
                         }

                     case 4:
                     case 6:
                     case 9:
                     case 11:
                         {
                             songay = 30;
                             break;
                         }
                     case 2:
                         if (nhuan(ref b) == 1)
                             songay = 29;
                         else
                             songay = 28;
                         break;
                 }
             }
             Console.WriteLine("So ngay: {0}", songay);
             Console.ReadKey();
         }
         //===================================================================
        static Boolean SCP(int a)
        {
        //Kiểm tra số chính phương
            Boolean kq = false;
            double x = Math.Sqrt(a);
            if ((int)x * x == a)
            {
                kq = true;
            }
            return kq;
        }
        static void BT4(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Hien thi mang: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t", a[i]);
            for (int i = 0; i < n; i++)
            {
                if (SCP(a[i]))
                {
                    tong += a[i];
                }
            }
            Console.WriteLine("\nTong so chinh phuong = {0}", tong);
            Console.ReadKey();
        }
        //===================================================================
        static void BT5()
        {
            int a, b, c;
            double delta = 0, x1, x2;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            //Nếu là phương trình bậc 1
            if (a == 0)
                BT2();
            else
                delta = b * b - 4 * a * c;
            //Nếu là phương trình bậc 2
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
                else if (delta > 0)
                {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}\nx2 = {1}", x1, x2);
                }
            else
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x1 = {0}", x1);
            }
            Console.ReadKey();
        }*/
        //===================================================================
        static void them(ref int[] a, ref int n)
        {
            //Thêm 1 phần tử vào mảng
            Console.Write("Nhap phan tu them: ");
            int k = int.Parse(Console.ReadLine());
            a[n] = k;           
                n++;          
            Console.Write("Mang sau khi them: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t", a[i]);
        }
        static void BT6(int[] a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Hien thi mang: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t", a[i]);
            Console.Write("\n");
            //Sắp xếp tăng dần 
            for (int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = 0;
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            Console.Write("Mang tang dan: ");
            for (int i = 0; i < n; i++)
                Console.Write("{0}\t", a[i]);
            //Đếm các phần tử lẻ
            int dem = 0;
            for (int i = 0; i < n; i++)
                if (a[i] % 2 != 0)
                    dem++;
            Console.WriteLine("\nTong so phan tu le: {0}", dem);
            them(ref a, ref n);
           
        }
     
        static void Main(string[] args)
        {
            int n;
            do //Điều kiện nhập số phần tử bài 6
            {
                Console.Write("Nhap so ptu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 3 || n > 20);
            int[] a = new int[100];
            //BT1();

            //BT2();

            //BT3();
            /*
            int n;
            do //Điều kiện nhập số phần tử bài 4
            {
                Console.Write("Nhap so ptu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 10 || n > 1000);*/

            //BT4(a,n);

            //BT5();

            BT6(a,n);
            Console.ReadKey();
        }
    }
}


