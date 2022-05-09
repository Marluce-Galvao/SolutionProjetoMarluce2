using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.RefitConfig
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class ProxyUriAttribute : Attribute
    {
        public ProxyUriAttribute(string baseUri)
        {
            BaseUri = baseUri;
        }

        public string BaseUri { get; private set; }
    }
}
