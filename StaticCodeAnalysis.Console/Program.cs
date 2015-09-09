namespace StaticCodeAnalysis.Console
{
    /// <summary>
    /// Simple comsole app designed to demonstrate the value of FX-Cop static code analysis.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RuleFifteenZeroTwo.Execute(args[0] as string);
            RuleTwentyZeroZero.Execute(args[0] as string);
        }
    }
}
