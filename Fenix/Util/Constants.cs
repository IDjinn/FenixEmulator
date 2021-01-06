using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Util
{
    public static class Constants
    {
        public const string POLICY_REQUEST_ID = "<policy-file-request/>";
        public static ReadOnlyMemory<byte> POLICY_REQUEST_RESPONSE = Encoding.UTF8.GetBytes("<?xml version =\"1.0\"?>\r\n" +
                   "<!DOCTYPE cross-domain-policy SYSTEM \"/xml/dtds/cross-domain-policy.dtd\">\r\n" +
                   "<cross-domain-policy>\r\n" +
                   "<allow-access-from domain=\"*\" to-ports=\"1-31111\" />\r\n" +
                   "</cross-domain-policy>\x0");
    }
}
