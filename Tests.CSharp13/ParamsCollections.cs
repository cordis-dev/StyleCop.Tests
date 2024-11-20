namespace Tests.CSharp13
{
    public class ParamsCollections
    {
        public void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
