using System;

namespace ConsoleApp5;

public interface ITest
{
    string Name { get; }
}

internal class FileScopedNamespace
{
    public int Prop { get; set; }
}