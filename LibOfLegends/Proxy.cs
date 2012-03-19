namespace LibOfLegends
{
	public class Proxy
	{
		public string Server;
		public ProxyType Type;
	}

	public enum ProxyType
	{
		DIRECT, HTTP, SOCKS
	}
}
