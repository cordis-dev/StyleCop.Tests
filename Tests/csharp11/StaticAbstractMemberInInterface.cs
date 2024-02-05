namespace Tests.csharp11
{
    // Interface specifies static properties and operators
    interface IAddable<T> where T : IAddable<T>
    {
        static abstract T Zero { get; }
        static abstract T operator +(T t1, T t2);
    }
}
