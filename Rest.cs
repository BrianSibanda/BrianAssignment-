namespace RestApp
{
    public class Rest
    {
      public string GetDataUsingMethod(string userName)
        {
            return "Hello, " + userName + ", welcome back!";
        }

		public string GetDataUsingURI(string userName)
		{
			return "Hello, " + userName + ", welcome back!";
		}
	}
}