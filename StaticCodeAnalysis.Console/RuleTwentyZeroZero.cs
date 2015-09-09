using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCodeAnalysis.Console
{
    /// <summary>
    /// Code that exercises code analysis rule CA2000.
    /// <see cref="https://msdn.microsoft.com/en-us/library/ms182212.aspx"/>
    /// </summary>
    internal static class RuleTwentyZeroZero
    {
        internal static bool Execute(string input)
        {
            Stream file = new FileStream(@"output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.Write(Encoding.UTF8.GetBytes(input), 0, input.Length);

            return true;
        }
    }
}
