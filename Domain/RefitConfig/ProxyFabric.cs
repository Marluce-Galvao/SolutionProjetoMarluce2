using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RefitConfig
{
	public class ProxyFabric<T> : IProxyFabric<T>
	{
		public T Proxy { get; }

		public ProxyFabric()
		{
			Proxy = GetServiceProxy();
		}

		private T GetServiceProxy()
		{
			var uri = ProxyConfiguration.ObterUriBase(typeof(T));

			var client = ProxyConfiguration.RequestHeaders(uri);

			return RestService.For<T>(client);
		}
	}
}
