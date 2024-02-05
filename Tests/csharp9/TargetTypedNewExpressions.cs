using System.Collections.Generic;

namespace Tests.csharp9
{
    internal class TargetTypedNewExpressions
    {
       // private List<string> testField = new() { string.Empty };

        public void T()
        {
            Test test = new(false, true) { Prop1 = 2 };
            Test2 test2 = new() { Prop2 = 2 };
        }

        public class Test(bool b1, bool b2)
        {
            public int Prop1 { get; set; }
        }

        public class Test2()
        {
            public int Prop2 { get; set; }
        }
    }
}
