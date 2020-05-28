using GRU.Poc.Project.Application.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRU.Poc.Project.Application.Commands.Request
{
    public class AuthenticationCommandRequest : IRequest<AuthenticationCommandResponse>, IRequest<AuthenticationCommandRequest>
    {
        public string UserCode { get; }
        public string AccessKey { get; }

        public AuthenticationCommandRequest(string userCode, string accessKey) {

            UserCode = userCode;
            AccessKey = accessKey;
        }

    }
}
