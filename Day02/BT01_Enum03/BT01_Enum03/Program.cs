public class Program
{
    enum NhietDoNuoc
    {
        DoDong = 0,
        DoNguoi = 30,
        DoAm = 40,
        DoNong,
        DoSoi = 100,
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Nhiet do dong: {0}", (int)NhietDoNuoc.DoDong);
        System.Console.WriteLine("Nhiet do nguoi: {0}", (int)NhietDoNuoc.DoNguoi);
        System.Console.WriteLine("Nhiet do am: {0}", (int)NhietDoNuoc.DoAm);
        System.Console.WriteLine("Nhiet do nong: {0}", (int)NhietDoNuoc.DoNong);
        System.Console.WriteLine("Nhiet do soi: {0}", (int)NhietDoNuoc.DoSoi);
        System.Console.ReadKey();
    }
}