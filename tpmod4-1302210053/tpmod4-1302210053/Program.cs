public class program
{
    enum kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja

    }

    private static int kodepos(kelurahan inputkodepos)
    {
        int[] outputkodepos = {40266,40287,40267,40256,40287,40286,40286,40286,40272,40274,40273 };
        int inputint =(int)inputkodepos;

        return outputkodepos[inputint];
    }

    public static void Main(string[] args)
    {
        kelurahan kelurahan = kelurahan.Maleer;
        int nokodepos = kodepos(kelurahan);
        Console.WriteLine(kelurahan + "  " + nokodepos);

    }

}







