using System;

namespace Tests.Console
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public sealed class CustomAssemblyAttribute : Attribute
    {
        public CustomAssemblyAttribute(string title)
        {
            Title = title;
        }

        public string Title { get; }
    }
}
