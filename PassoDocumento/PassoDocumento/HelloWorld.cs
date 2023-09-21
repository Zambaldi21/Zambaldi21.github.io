
//N° 4

for (int i = 0; i < 3; i++)
{
    for (int j = 1; j < 3; j++)
    {
        if (i % j == 0)
        {
            continue;
        }
        else
        {
            Out.println("i = " + ",j = " + j);
        }
    }

}

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