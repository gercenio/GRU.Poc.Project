using System;
using System.Collections.Generic;
using System.Text;

namespace GRU.Poc.Project.Domain.Entities
{
    public class ApiAccount
    {
        public string UserCode { get; }
        public string AccessKey { get; }

        public ApiAccount(string userCode, string accessKey) {

            UserCode = userCode;
            AccessKey = accessKey;
        }
    }
}
