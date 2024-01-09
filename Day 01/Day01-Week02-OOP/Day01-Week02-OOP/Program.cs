class MB
{

    public static void Main()
    {
        int n = System.Convert.ToInt32(System.Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            if (miller_robin(i))
            {
                System.Console.Write(i + " ");
            }
        }
    }

    public static bool miller_robin(int n)
    {

        if (n != 2 && n % 2 == 0)
        {
            return false;
        }

        //phan tich n - 1 = 2^k*m
        int k = 0;
        int m = n - 1;
        while (m % 2 == 0)
        {
            k++;
            m /= 2;
        }

        //chon so a 
        int a = 2;
        while (a != 1 && a != -1)
        {
            a = (int)(System.Math.Pow(a, m) % n);
            m = 2;
        }

        if (a == 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}