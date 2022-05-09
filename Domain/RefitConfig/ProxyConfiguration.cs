using System;
using System.Linq;
using System.Net.Http;

namespace Domain.RefitConfig
{
    internal class ProxyConfiguration
	{
		public static string ObterUriBase(Type type)
		{
			var atributo = (ProxyUriAttribute)Attribute.GetCustomAttributes(type)
							   .FirstOrDefault(t => t is ProxyUriAttribute)
						   ?? throw new ArgumentNullException(type.Name);
			var baseUri = Environment.GetEnvironmentVariable(atributo.BaseUri)
						  ?? throw new ArgumentNullException(atributo.BaseUri);

			return baseUri;
		}

		public static HttpClient RequestHeaders(string uri)
		{
			return new HttpClient
			{
				BaseAddress = new Uri(uri)
			};
		}
	}
}
