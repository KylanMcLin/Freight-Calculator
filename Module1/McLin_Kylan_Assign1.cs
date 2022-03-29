using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    class McLin_Kylan_Assign1
{
    static void Main(string[] args)
    {

        Console.WriteLine("Freight Calculator \n\n");

        bool invalid_Data = true;
        string data = "";
        

        while (invalid_Data == true)
        {


            Console.WriteLine("Enter the number of miles: ", Is_valid(data));
            double miles = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the number of pounds: ", Is_valid(data));
            double pounds = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ship by rail or by truck: ");
            string freight_type = Console.ReadLine();


            Console.WriteLine("The frieght quote is {0}", Calculate_freight(miles, pounds, freight_type));
            int totalShippingCharges = Convert.ToInt32(Console.ReadLine());
           

            if (invalid_Data == false)
            {
                Console.WriteLine("Invalid data. You must enter a positive integer.");
            }

        }

        Console.WriteLine("Invalid data. You must enter a positive integer.");

    }

    public static bool Is_valid(string data)
    {
        int i = 0;
        if (true)
        {
            return int.TryParse(data, out i);
        }

    }

    public static int Calculate_freight(double miles, double pounds, string freight_type)
    {

        if (pounds <= 4000)
        {
            pounds = 1.10;
        }
        else if (pounds > 4000 && pounds <= 6000)
        {
            pounds = 2.20;
        }
        else if (pounds > 6000 && pounds <= 20000)
        {
            pounds = 3.30;
        }
        else if(pounds > 20000)
        {
            pounds = 4.40;
        }

        int totalShippingCharges = ((int)(pounds * miles));

        if (freight_type == "truck")
        {
            return totalShippingCharges;
        }
        else if( freight_type == "rail")
        {
            totalShippingCharges /= 2;
            return totalShippingCharges;
        }

        return totalShippingCharges;

    }

}