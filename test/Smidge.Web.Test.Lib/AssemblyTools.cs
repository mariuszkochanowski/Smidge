using System.Reflection;

namespace Smidge.Web.Test.Lib
{
    public class AssemblyTools
    {
        public static Assembly GetCurrentAssembly()
        {
            return typeof(AssemblyTools).Assembly;
        }
    }
}
