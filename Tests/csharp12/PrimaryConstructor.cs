using System.IO;

namespace ConsoleApp1
{
    // one-liner
    public class PrimaryCtorSingleLine() : StringReader(null);

    // multi-liner
    public class TestClass(bool b, int i, string s) : BaseClass
    {
        public int I { get; set; } = i; // i used for initialization
        public string S // s used directly in function members
        {
            get => s;
            set => s = value ?? throw new ArgumentNullException(nameof(S));
        }
        public TestClass(string s) : this(true, 0, s) { } // must call this(...)
    }

    public class BaseClass { }
}
