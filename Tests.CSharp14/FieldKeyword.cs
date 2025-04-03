namespace Tests.CSharp14
{
    public class FieldKeyword
    {
		public string Message
		{
			get;
			set => field = value ?? throw new ArgumentNullException(nameof(value));
		}
		
		public bool Enabled
		{
			get
			{

				return this.enabled;
			}
		}
    }
}