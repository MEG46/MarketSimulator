using System;
using System.Security.Cryptography.X509Certificates;

void menu1(string [] gro, double [] price,string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[0]);
    Console.WriteLine();
    for (i = 0; i < 9; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/kg)",(i+1),gro[i],price[i]);
    }
    Console.WriteLine();
}
void menu2(string[] del, double[] price1, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[1]);
    Console.WriteLine();
    for (i = 0; i < 12; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/kg)", (i + 10), del[i], price1[i]);
    }
    Console.WriteLine();
}
void menu3(string[] snk, double[] price2, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[2]);
    Console.WriteLine();
    for (i = 0; i < 18; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/kg)", (i +22), snk[i], price2[i]);
    }
    Console.WriteLine();
}
void menu4(string[] cle, double[] price3, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[3]);
    Console.WriteLine();
    for (i = 0; i < 20; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/per)", (i + 40), cle[i], price3[i]);
    }
    Console.WriteLine();
}
void menu5(string[] elc, double[] price4, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[4]);
    Console.WriteLine();
    for (i = 0; i < 9; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/per)", (i + 60), elc[i], price4[i]);
    }
    Console.WriteLine();
}
void menu6(string[] bak, double[] price5, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[5]);
    Console.WriteLine();
    for (i = 0; i < 15; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/per)", (i + 69), bak[i], price5[i]);
    }
    Console.WriteLine();
}
void menu7(string[] stp, double[] price6, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[6]);
    Console.WriteLine();
    for (i = 0; i < 40; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/kg)", (i + 84), stp[i], price6[i]);
    }
    Console.WriteLine();
}
void menu8(string[] drk, double[] price7, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[7]);
    Console.WriteLine();
    for (i = 0; i < 13; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/per)", (i + 124), drk[i], price7[i]);
    }
    Console.WriteLine();
}

void menu9(string[] stf, double[] price8, string[] departments)
{
    int i;
    Console.WriteLine("{0}:", departments[8]);
    Console.WriteLine();
    for (i = 0; i < 9; i++)
    {
        Console.WriteLine("{0}. {1} ({2}/per)", (i + 137), stf[i], price8[i]);
    }
    Console.WriteLine();
}
char ch;
    int chc, kg, flag=0;
    string[] departments = { "The Grocery", "The Delicatessen", "The Snacks","The Cleaning Section","The Electronics","The Bakery","The Staple Food","The Drinks","The Stuffs"};
    string [] gro={ "Apple","Orange","Tomato","Cucumber","Pineapple","Potato","Banana","Lemon","Avacado"};
    string[] del = { "American Cheese", "Bologna", "Cheese", "Toast Cheese", "Deli Meat", "Egg", "Olive", "Green Olive", "Nuggets", "Chicken","Veal Chop","Beef" };
    string[] snk = { "Pringles","Oreos","David Sunflower Seeds", "Doritos", "Italian Taralli", "Welch’s Fruit Snacks", "PopCorners", "Corn Nuts", "Better Cheddars", "Swiss Rolls", "Shrimp Chips", "Skittles", "Ruffles", "Snickers", "Twix", "Kit Kat", "Fritos", "M&Ms" };
    string[] cle = { "Microfiber Cloths", "Toilet Brush", "Scrub Brush", "Spray Bottle", "Rubber Gloves", "Old Toothbrush", "Dry-cleaning sponge", "Squeegee", "Broom", "Sponge Mop", "Disinfecting Wipes", "Mild Abrasive", "Dust Mop", "Extendable Duster", "White Vinegar", "Dishwashing Liquid", "Vacuum", "All-Purpose Cleaner", "Baking Soda", "Supply Caddy" };
    string[] elc = { "Laptop", "Computer", "Mobile Phone", "Tablet", "Speaker","Headphones","Blender", "Television", "Toaster" };
    string[] bak = { "Bread", "Bagel","Ramadan Pite","Pogaca","Bun","Pancake","Cake", "Cupcakes", "Brownies", "Pineapple Tart", "Carrot Cake","Chocolate Bar", "Lemon Drizzle", "Cherry Cake", "Honey & Apricot Cake"};
    string[] stp = { "Boxes of Pasta", "Tomato Sauce", "Canned Soups", "Rice", "Cereal & Oatmeal", "Chicken Broth", "Mixed Nuts", "Dried Fruit", "Canned Mushrooms", "Canned Chicken", "Canned Beans", "Canned Corn","Frozen French Fries", "Peanut Butter", "Baking Soda", "Baking Powder", "Corn Starch", "White Sugar", "Brown Sugar", "Shortening", "Chocolate Chips", "Flour", "Cinnamon", "Sea Salt", "Celery Seed", "Cill", "Paprika", "Oregano", "Basil", "Garlic Powder", "Dried Onion", "Pepper ", "Olive Oil", "Canola Oil", "Coconut Oil", "Vegetable Oil", "Frozen Spinach", "Frozen Green Beans", "Frozen Peas", "Frozen Broccoli" };
    string[] drk = { "Bottle Of Water 500ml", "Bottle Of Water 1500ml", "Lemonade 1L", "Iced Tea 1L","Mixed Juice 1L", "Milkshake 500ml","Full Oiled Milk 1L","Half Oiled Milk 1L","Chocolate Milk 200ml","Stawberry Milk 200ml","Banana Milk 200ml","Buttermilk 1L","Kefir 1L"};
    string[] stf = {"Plastic Plates 10 Pieces","Plastic Glass Set 10 Pieces","Plastic Fork Set 10 Pieces","Plastic Spoon Set 10 Pieces", "Ceramic Plates 10 Pieces", "Glass Set 10 Pieces", "Metal Fork Set 10 Pieces", "Metal Spoon Set 10 Pieces","Knife Set 3 Pieces" };
    double[] price8 = { 4.99, 4.99, 2.99, 2.99, 15.00, 15.00, 9.99, 9.99, 13.99 };
     double[] price7 = { 0.99, 1.99, 5.99,4.99,4.79,5.99,5.99,5.79, 2.99,2.99,2.99,6.99,6.79};
    double[] price6 = { 3.99,8.69,8.00,13.99,5.99,4.99,5.67,14.99,8.69,6.79,9.78,10.00,12.99,8.95,3.99,5.99,4.99,8.99,7.99,10.99,9.55,13.99,4.99,5.99,4.99,5.34,6.75,4.56,7.76,6.43,5.88,9.76,6.54,4.34,8.654,5.453,7.654,9.75,6.76,6.543};
    double[] price5 = {7.99,5.99,8.99,2.99,3.15,10.99,23.99,3.99,4.99,15.99,15.99,13.99,8.79,14.99,14.99,};
    double[] price4 = { 500.00, 650.00, 399.99, 350.99, 100.00, 20.00, 150.00, 570.00, 99.99 };
    double[] price3 = { 12.99, 10.99, 8.99, 9.99, 7.99, 5.99, 4.99, 6.79, 8.99, 8.19, 8.89, 12.99, 15.99, 21.99, 11.99, 14.59, 10.99, 9.09,12.99,11.17 };
    double[] price2 = { 10.99,13.99,6.99,5.99,4.99,7.99,8.99,5.79,10.99,9.99,6.79,2.99,5.99,2.99,3.99,4.59,5.99,2.99};
    double[] price = { 6.99, 7.99, 4.99, 8.70, 15.00, 4.23, 10.59, 9.99, 4.59 };
    double [] price1 = {23.99,17.99,21.59,25.99,27.99,15.99,20.54,23.69,15.99,24.99,35.99,30.10};
    double result=0;
    int men;
Console.WriteLine("WELCOME TO MEG MARKET!");
Console.WriteLine();
    do
    {
    Console.WriteLine("The Categories:");
    for(int i = 0; i < 9; i++)
    {
        Console.WriteLine("{0} = {1}", (i + 1), departments[i]);
    }
    Console.Write("Please enter which category do you want to buy something on : ");
    men = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (men)
    {
        case 1:
            menu1(gro, price, departments);
            break;
        case 2:
            menu2(del, price1, departments);
            break;
        case 3:
            menu3(snk, price2, departments);
            break;
        case 4:
            menu4(cle, price3, departments);
            break;
        case 5:
            menu5(elc, price4, departments);
            break;
        case 6:
            menu6(bak, price5, departments);
            break;
        case 7:
            menu7(stp, price6, departments);
            break;
        case 8:
            menu8(drk, price7, departments);
            break;
        case 9:
            menu9(stf, price8, departments);
            break;
        default:
            Console.WriteLine("Please choose something!");
            break;
    }    
    Console.Write("Please enter which item do you want to buy : ");
        chc = int.Parse(Console.ReadLine());
        Console.Write("Please enter how many per/kg do you want to buy : ");
        kg = int.Parse(Console.ReadLine());
    if ((chc < 147 && chc > 0) && (kg > 0))
    {
        if (men == 1)
        {
            switch (chc)
            {
                case 1:
                    result += price[0] * kg;
                    break;
                case 2:
                    result += price[1] * kg;
                    break;
                case 3:
                    result += price[2] * kg;
                    break;
                case 4:
                    result += price[3] * kg;
                    break;
                case 5:
                    result += price[4] * kg;
                    break;
                case 6:
                    result += price[5] * kg;
                    break;
                case 7:
                    result += price[6] * kg;
                    break;
                case 8:
                    result += price[7] * kg;
                    break;
                case 9:
                    result += price[8] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 2)
        {
            switch (chc)
            {
                case 10:
                    result += price1[0] * kg;
                    break;
                case 11:
                    result += price1[1] * kg;
                    break;
                case 12:
                    result += price1[2] * kg;
                    break;
                case 13:
                    result += price1[3] * kg;
                    break;
                case 14:
                    result += price1[4] * kg;
                    break;
                case 15:
                    result += price1[5] * kg;
                    break;
                case 16:
                    result += price1[6] * kg;
                    break;
                case 17:
                    result += price1[7] * kg;
                    break;
                case 18:
                    result += price1[8] * kg;
                    break;
                case 19:
                    result += price1[9] * kg;
                    break;
                case 20:
                    result += price1[10] * kg;
                    break;
                case 21:
                    result += price1[11] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 3)
        {
            switch (chc)
            {
                case 22:
                    result += price2[0] * kg;
                    break;
                case 23:
                    result += price2[1] * kg;
                    break;
                case 24:
                    result += price2[2] * kg;
                    break;
                case 25:
                    result += price2[3] * kg;
                    break;
                case 26:
                    result += price2[4] * kg;
                    break;
                case 27:
                    result += price2[5] * kg;
                    break;
                case 28:
                    result += price2[6] * kg;
                    break;
                case 29:
                    result += price2[7] * kg;
                    break;
                case 30:
                    result += price2[8] * kg;
                    break;
                case 31:
                    result += price2[9] * kg;
                    break;
                case 32:
                    result += price2[10] * kg;
                    break;
                case 33:
                    result += price2[11] * kg;
                    break;
                case 34:
                    result += price2[12] * kg;
                    break;
                case 35:
                    result += price2[13] * kg;
                    break;
                case 36:
                    result += price2[14] * kg;
                    break;
                case 37:
                    result += price2[15] * kg;
                    break;
                case 38:
                    result += price2[16] * kg;
                    break;
                case 39:
                    result += price1[17] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 4)
        {
            switch (chc)
            {
                case 40:
                    result += price3[0] * kg;
                    break;
                case 41:
                    result += price3[1] * kg;
                    break;
                case 42:
                    result += price3[2] * kg;
                    break;
                case 43:
                    result += price3[3] * kg;
                    break;
                case 44:
                    result += price3[4] * kg;
                    break;
                case 45:
                    result += price3[5] * kg;
                    break;
                case 46:
                    result += price3[6] * kg;
                    break;
                case 47:
                    result += price3[7] * kg;
                    break;
                case 48:
                    result += price3[8] * kg;
                    break;
                case 49:
                    result += price3[9] * kg;
                    break;
                case 50:
                    result += price3[10] * kg;
                    break;
                case 51:
                    result += price3[11] * kg;
                    break;
                case 52:
                    result += price3[12] * kg;
                    break;
                case 53:
                    result += price3[13] * kg;
                    break;
                case 54:
                    result += price3[14] * kg;
                    break;
                case 55:
                    result += price3[15] * kg;
                    break;
                case 56:
                    result += price3[16] * kg;
                    break;
                case 57:
                    result += price3[17] * kg;
                    break;
                case 58:
                    result += price3[18] * kg;
                    break;
                case 59:
                    result += price3[19] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 5)
        {
            switch (chc)
            {
                case 60:
                    result += price4[0] * kg;
                    break;
                case 61:
                    result += price4[1] * kg;
                    break;
                case 62:
                    result += price4[2] * kg;
                    break;
                case 63:
                    result += price4[3] * kg;
                    break;
                case 64:
                    result += price4[4] * kg;
                    break;
                case 65:
                    result += price4[5] * kg;
                    break;
                case 66:
                    result += price4[6] * kg;
                    break;
                case 67:
                    result += price4[7] * kg;
                    break;
                case 68:
                    result += price4[8] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 6)
        {
            switch (chc)
            {
                case 69:
                    result += price5[0] * kg;
                    break;
                case 70:
                    result += price5[1] * kg;
                    break;
                case 71:
                    result += price5[2] * kg;
                    break;
                case 72:
                    result += price5[3] * kg;
                    break;
                case 73:
                    result += price5[4] * kg;
                    break;
                case 74:
                    result += price5[5] * kg;
                    break;
                case 75:
                    result += price5[6] * kg;
                    break;
                case 76:
                    result += price5[7] * kg;
                    break;
                case 77:
                    result += price5[8] * kg;
                    break;
                case 78:
                    result += price5[9] * kg;
                    break;
                case 79:
                    result += price5[10] * kg;
                    break;
                case 80:
                    result += price5[11] * kg;
                    break;
                case 81:
                    result += price5[12] * kg;
                    break;
                case 82:
                    result += price5[13] * kg;
                    break;
                case 83:
                    result += price5[14] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 7)
        {
            switch (chc)
            {
                case 84:
                    result += price6[0] * kg;
                    break;
                case 85:
                    result += price6[1] * kg;
                    break;
                case 86:
                    result += price6[2] * kg;
                    break;
                case 87:
                    result += price6[3] * kg;
                    break;
                case 88:
                    result += price6[4] * kg;
                    break;
                case 89:
                    result += price6[5] * kg;
                    break;
                case 90:
                    result += price6[6] * kg;
                    break;
                case 91:
                    result += price6[7] * kg;
                    break;
                case 92:
                    result += price6[8] * kg;
                    break;
                case 93:
                    result += price6[9] * kg;
                    break;
                case 94:
                    result += price6[10] * kg;
                    break;
                case 95:
                    result += price6[11] * kg;
                    break;
                case 96:
                    result += price6[12] * kg;
                    break;
                case 97:
                    result += price6[13] * kg;
                    break;
                case 98:
                    result += price6[14] * kg;
                    break;
                case 99:
                    result += price6[15] * kg;
                    break;
                case 100:
                    result += price6[16] * kg;
                    break;
                case 101:
                    result += price6[17] * kg;
                    break;
                case 102:
                    result += price6[18] * kg;
                    break;
                case 103:
                    result += price6[19] * kg;
                    break;
                case 104:
                    result += price6[20] * kg;
                    break;
                case 105:
                    result += price6[21] * kg;
                    break;
                case 106:
                    result += price6[22] * kg;
                    break;
                case 107:
                    result += price6[23] * kg;
                    break;
                case 108:
                    result += price6[24] * kg;
                    break;
                case 109:
                    result += price6[25] * kg;
                    break;
                case 110:
                    result += price6[26] * kg;
                    break;
                case 111:
                    result += price6[27] * kg;
                    break;
                case 112:
                    result += price6[28] * kg;
                    break;
                case 113:
                    result += price6[29] * kg;
                    break;
                case 114:
                    result += price6[30] * kg;
                    break;
                case 115:
                    result += price6[31] * kg;
                    break;
                case 116:
                    result += price6[32] * kg;
                    break;
                case 117:
                    result += price6[33] * kg;
                    break;
                case 118:
                    result += price6[34] * kg;
                    break;
                case 119:
                    result += price6[35] * kg;
                    break;
                case 120:
                    result += price6[36] * kg;
                    break;
                case 121:
                    result += price6[37] * kg;
                    break;
                case 122:
                    result += price6[38] * kg;
                    break;
                case 123:
                    result += price6[39] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 8)
        {
            switch (chc)
            {
                case 124:
                    result += price7[0] * kg;
                    break;
                case 125:
                    result += price7[1] * kg;
                    break;
                case 126:
                    result += price7[2] * kg;
                    break;
                case 127:
                    result += price7[3] * kg;
                    break;
                case 128:
                    result += price7[4] * kg;
                    break;
                case 129:
                    result += price7[5] * kg;
                    break;
                case 130:
                    result += price7[6] * kg;
                    break;
                case 131:
                    result += price7[7] * kg;
                    break;
                case 132:
                    result += price7[8] * kg;
                    break;
                case 133:
                    result += price7[9] * kg;
                    break;
                case 134:
                    result += price7[10] * kg;
                    break;
                case 135:
                    result += price7[11] * kg;
                    break;
                case 136:
                    result += price7[12] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;
            }
        }
        else if (men == 9)
        {
            switch (chc)
            {
                case 137:
                    result += price8[0] * kg;
                    break;
                case 138:
                    result += price8[1] * kg;
                    break;
                case 139:
                    result += price8[2] * kg;
                    break;
                case 140:
                    result += price8[3] * kg;
                    break;
                case 141:
                    result += price8[4] * kg;
                    break;
                case 142:
                    result += price8[5] * kg;
                    break;
                case 143:
                    result += price8[6] * kg;
                    break;
                case 144:
                    result += price8[7] * kg;
                    break;
                case 145:
                    result += price8[8] * kg;
                    break;
                default:
                    Console.WriteLine("Choose something!");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Choose something right!");
        }
        Console.WriteLine("Current Total : {0}$",result);
        Console.Write("Do you want to continue shopping : (Y /N ) : ");
        ch = Console.ReadLine()[0];
        if (ch == 'Y' || ch == 'y')
        {
            flag = 1;
        }
        else if (ch == 'N' || ch == 'n')
        {
            int ch1, pay;
            Console.WriteLine("Types Of Payments\n1.Cash\n2.Credit");
            Console.Write("Please enter a payment type : ");
            ch1 = Convert.ToInt16(Console.ReadLine());
            switch (ch1)
            {
                case 1:
                    Console.WriteLine("Total : {0}$",result);
                    Console.WriteLine("The payment is completed. Thanks for choosing us! Have a nice day!");
                    break;
                case 2:
                    Console.WriteLine("Type Of Instalment Plans:\n1.By 0-3 Months\n2.0-6 Month\n3.0-9 Month\n");
                    Console.Write("Which instalment plan do you want to choose : ");
                    pay = int.Parse(Console.ReadLine());
                    if (pay == 1)
                    {
                        result = result + result * 0.1;
                        Console.WriteLine("Total : {0}$",result);
                        Console.WriteLine("The payment is completed. Thanks for choosing us! Have a nice day!");
                    }
                    else if (pay == 2)
                    {
                        result = result + result * 0.15;
                        Console.WriteLine("Total : {0}$",result);
                        Console.WriteLine("The payment is completed. Thanks for choosing us! Have a nice day!");
                    }
                    else if (pay == 3)
                    {
                        result = result + result * 0.20;
                        Console.WriteLine("Total : {0}$",result);
                        Console.WriteLine("The payment is completed. Thanks for choosing us! Have a nice day!");
                    }
                    else
                    {
                        Console.WriteLine("The payment is completed. Thanks for choosing us! Have a nice day!");
                    }
                    flag = 0;
                    break;
            }
        }
    }
    } while (flag != 0);
