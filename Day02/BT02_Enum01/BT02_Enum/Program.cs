public class Program
{
    enum NhietDoNuoc
    {
        DoDong = 0,
        DoNguoi = 30,
        DoAm = 40,
        DoNong = 70,
        DoSoi = 100,
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Nhiet do dong: {0}", NhietDoNuoc.DoDong);
        System.Console.WriteLine("Nhiet do nguoi: {0}", NhietDoNuoc.DoNguoi);
        System.Console.WriteLine("Nhiet do am: {0}", NhietDoNuoc.DoAm);
        System.Console.WriteLine("Nhiet do nong: {0}", NhietDoNuoc.DoNong);
        System.Console.WriteLine("Nhiet do soi: {0}", NhietDoNuoc.DoSoi);
        System.Console.ReadKey();
    }
}