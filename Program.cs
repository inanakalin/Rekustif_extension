internal class Program
{
    private static void Main(string[] args)
    {
        //Recursive metotlar
        //3^4 = 3*3*3*3

        int result =1;
        for (int i = 1; i < 5; i++)
        
          result = result *3 ;
          System.Console.WriteLine(result);
        int v = Expo(3,4);
          System.Console.WriteLine( v);

        int fibo = FibonacciSerisi(9);
        System.Console.WriteLine(fibo);
        
    }
    static int Expo (int sayi, int üs)
    { 
        if (üs<2)
        return sayi;
        return Expo (sayi,üs-1)*sayi;

        //3^4
        //(3,3)*3
        //(3,2)*3*3
        //(3,1)*3*3*3
        //3*3*3*3
    }

    static int FibonacciSerisi(int sayi)
{  
    if (sayi==0)
        return 0;
    else if (sayi==1)
        return 1;
    else
        return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
}


}
