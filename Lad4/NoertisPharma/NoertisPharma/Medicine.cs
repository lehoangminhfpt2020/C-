using System;

namespace NoertisPharma
{
    class Medicine
    {
        public int MedicineCode;         // mã thuốc//
        string MedicineName;      // tên thuốc//
        string ManufacturerName;  // nhà sản xuất//
        double Price;             // giá thuốc//
        int QuantityOnHand;       // số lượng viên//
        DateTime ManufacturedDate; // Ngày sản xuất//
        DateTime ExpiryDate;       // Hạn sử dụng //
        int BatchNumber;           // số lô hàng // 

        public Medicine()
        {

        }

        public Medicine(int Code, string Name, string ManuName, double Price, int Quantity, DateTime ManuDate, DateTime ExpDate, int Batch)
        {
            MedicineCode = Code;
            MedicineName = Name;
            ManufacturerName = ManuName;
            this.Price = Price;
            QuantityOnHand = Quantity;
            ManufacturedDate = ManuDate;
            ExpiryDate = ExpDate;
            BatchNumber = Batch;
        }

        public void Accept() 
        {
            Console.WriteLine("-------- Enter the information of medicine --------");
            Console.WriteLine("-+  1.MedicineCode - 2.MedicineName - 3.ManufacturerName - 4.Price  +- ");
            Console.WriteLine("-+  5.Quantity - 6.ManufacturedDate - 7.ExpiryDate - 8.BatchNumber  +- ");
            Console.WriteLine(" Enter MedicineCode: ");
            MedicineCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Medicine 's name: ");
            MedicineName = Console.ReadLine();
            Console.WriteLine(" Enter manufacturer's name: ");
            ManufacturerName = Console.ReadLine();
            Console.WriteLine(" Enter the Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter Quantity On Hand: ");
            QuantityOnHand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Manufactured Date (DD/MM/YYYY) : ");
            ManufacturedDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" Enter ExpiryDate (DD/MM/YYYY) : ");
            ExpiryDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" Enter Batch Number: ");
            BatchNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {   
            Console.WriteLine("Medicince information:");
            Console.WriteLine("Medicine code:" + MedicineCode);
            Console.WriteLine("Medicine name: " + MedicineName);
            Console.WriteLine("Medicine's manufacturer: " + ManufacturerName);
            Console.WriteLine("Medicine's price:" + Price);
            Console.WriteLine("Quantity in hand: " + QuantityOnHand);
            Console.WriteLine("Medicine's manufactured date:" + ManufacturedDate);
            Console.WriteLine("Medicine's expiry date: " + ExpiryDate);
            Console.WriteLine("Batch number: " + BatchNumber);
        }
    }

    class Sales
    {
        int QuantitySold;
        double PlannedSales;
        double ActualSales;
        int SalesID;
        string Password;
    }
    class Program
    {
        static void Main()
        {
            Medicine Paradon = new Medicine();
            Paradon.Accept();
            Paradon.Print();
        }
    }


}
