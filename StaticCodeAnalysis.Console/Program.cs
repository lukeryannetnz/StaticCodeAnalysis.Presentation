namespace StaticCodeAnalysis.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RuleFifteenZeroTwo.Execute(args[0] as string);
            RuleTwentyZeroZero.Execute(args[0] as string);
        }
    }
}
