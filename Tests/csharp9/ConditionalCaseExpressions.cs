namespace Tests.csharp9
{
    internal class ConditionalCaseExpressions
    {
        public void T(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case > 1 and < 10 when number != 5:
                    Console.WriteLine("B");
                    break;
            }
        }
		
		// case number compare expression without 'when'
		public string Humanise(TimeSpan timespan)
		{
			return timespan.TotalSeconds switch
			{
				<= 1 => "Just now",
				< 60 * 60 => $"{timespan.Minutes} {(timespan.Minutes == 1 ? "minute" : "minutes")} ago",
				_ => $"{timespan.Days / 365} {(timespan.Days / 365 == 1 ? "year" : "years")} ago",
			};
		}

        public void ConditionalNumberSwitch(int number)
        {
            string message = number switch
            {
                -1 => "Negative",
                > 1 and <= 10 => "Conditional",
                < 0 => "Negative",
                > 0 => "Positive",
                _ => "Zero"
            };
        }

        // case statement with number expression
        private void Test(decimal number)
		{
			switch (number)
			{
				case < 80 - (6 * 0m):
				default:
					Console.WriteLine("1");
					break;
			}
		}		
    }
}
