using System;


namespace Arbor.Api
{
	public class ServerErrorException : Exception
	{
		public ServerErrorException(string message, Exception innerException = null) : base (message, innerException)
		{

		}
	}
}