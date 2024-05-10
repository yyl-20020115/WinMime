using HeyRed.Mime;

namespace WinMime;

public class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: WinMime [filename]");
            return 0;
        }
        
        var path = args[0];
        using var magic = new Magic(MagicOpenFlags.MAGIC_NONE);
        var ret = magic.Read(path);
        Console.WriteLine(ret);
        return 0;
    }
}
