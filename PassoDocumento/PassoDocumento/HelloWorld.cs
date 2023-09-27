
//N° 8

String a = "String";
int b = 3;
int c = 7;
Out.println(a + b + c + a);

namespace System
{
    public static class Out
    {
        public static void println(object message)
        {
            Console.WriteLine(message);
        }
    }
}