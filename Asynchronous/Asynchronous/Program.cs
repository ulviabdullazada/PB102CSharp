
//Method1();
//Method2();
//using System.Diagnostics;

//Stopwatch sw = Stopwatch.StartNew();
//Thread t1 = new Thread(Method1);
//Thread t2 = new Thread(Method2);

//t1.Start();
//t2.Start();

//t1.Join();
//t2.Join();
//sw.Stop();
//Parallel.Invoke(Method1, Method2);

//Console.WriteLine("Bu qeder ms kchdi -> " + sw.ElapsedMilliseconds);
//Console.WriteLine("Salam");



//static void Method1()
//{
//    for (int i = 0; i < 500; i++)
//    {
//        Console.WriteLine(i);
//    }
//}
//static void Method2()
//{
//    for (int i = 0; i > -500; i--)
//    {
//        Console.WriteLine(i);
//    }
//}
using System.Diagnostics;

ZaftrkAsync().Wait();
static void Zaftrk()
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    YumurtaBisir();
    CayiQaynat();
    SufreniHazirla();
    Console.WriteLine("Nuw");
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
}



static void CayiQaynat()
{
    Console.WriteLine("Qaz yandilirldi");
    Console.WriteLine("Chaydan ustune qoyuldu");
    Thread.Sleep(2000);
    Console.WriteLine("Chaydan qaynadi");
}

static void YumurtaBisir()
{
    Console.WriteLine("Yumurta hazirlandi");
    Console.WriteLine("Qaz yandilirldi");
    Thread.Sleep(5000);
    Console.WriteLine("Yumurta bisdi");
}

static void SufreniHazirla()
{
    Thread.Sleep(1000);
    Console.WriteLine("Sufre hazirlandi");

}


static async Task ZaftrkAsync()
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    //await ();
    //await ();
    //await ();
    await Task.WhenAll(CayiQaynatAsync(), YumurtaBisirAsync(), SufreniHazirlaAsync());
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
}


static async Task CayiQaynatAsync()
{
    Console.WriteLine("Qaz yandilirldi");
    Console.WriteLine("Chaydan ustune qoyuldu");
    await Task.Delay(2000);
    Console.WriteLine("Chaydan qaynadi");
}
static async Task YumurtaBisirAsync()
{
    Console.WriteLine("Yumurta hazirlandi");
    Console.WriteLine("Qaz yandilirldi");
    await Task.Delay(5000);
    Console.WriteLine("Yumurta bisdi");
}

static async Task SufreniHazirlaAsync()
{
    await Task.Delay(1000);
    Console.WriteLine("Sufre hazirlandi");

}
static async Task<int> TestAsync()
{
    await SufreniHazirlaAsync();
    return 1;
}