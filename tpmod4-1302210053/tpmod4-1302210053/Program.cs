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
        int[] outputkodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        int inputint = (int)inputkodepos;

        return outputkodepos[inputint];
    }

    public static void Main(string[] args)
    {
        kelurahan kelurahan = kelurahan.Batununggal;
        int nokodepos = kodepos(kelurahan);
        Console.WriteLine(kelurahan + "  " + nokodepos);

        kelurahan kelurahan1 = kelurahan.Kujangsari;
        int nokodepos1 = kodepos(kelurahan1);
        Console.WriteLine(kelurahan1 + "  " + nokodepos1);

        kelurahan kelurahan2 = kelurahan.Mengger;
        int nokodepos2 = kodepos(kelurahan2);
        Console.WriteLine(kelurahan2 + "  " + nokodepos2);

        kelurahan kelurahan3 = kelurahan.Wates;
        int nokodepos3 = kodepos(kelurahan3);
        Console.WriteLine(kelurahan3 + "  " + nokodepos3);

        kelurahan kelurahan4 = kelurahan.Cijaura;
        int nokodepos4 = kodepos(kelurahan4);
        Console.WriteLine(kelurahan4 + "  " + nokodepos4);

        kelurahan kelurahan5 = kelurahan.Jatisari;
        int nokodepos5 = kodepos(kelurahan5);
        Console.WriteLine(kelurahan5 + "  " + nokodepos5);

        kelurahan kelurahan6 = kelurahan.Margasari;
        int nokodepos6 = kodepos(kelurahan6);
        Console.WriteLine(kelurahan6 + "  " + nokodepos6);

        kelurahan kelurahan7 = kelurahan.Sekejati;
        int nokodepos7 = kodepos(kelurahan7);
        Console.WriteLine(kelurahan7 + "  " + nokodepos7);

        kelurahan kelurahan8 = kelurahan.Kebonwaru;
        int nokodepos8 = kodepos(kelurahan8);
        Console.WriteLine(kelurahan8 + "  " + nokodepos8);

        kelurahan kelurahan9 = kelurahan.Maleer;
        int nokodepos9 = kodepos(kelurahan9);
        Console.WriteLine(kelurahan9 + "  " + nokodepos9);

        kelurahan kelurahan10 = kelurahan.Samoja;
        int nokodepos10 = kodepos(kelurahan10);
        Console.WriteLine(kelurahan10 + "  " + nokodepos10);


    }



}



