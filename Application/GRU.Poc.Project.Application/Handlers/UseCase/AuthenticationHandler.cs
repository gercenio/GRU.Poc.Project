using GRU.Poc.Project.Application.Commands.Request;
using GRU.Poc.Project.Application.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GRU.Poc.Project.Application.Handlers.UseCase
{
    public class AuthenticationHandler : IRequestHandler<AuthenticationCommandRequest, AuthenticationCommandResponse>
    {
        public async Task<AuthenticationCommandResponse> Handle(AuthenticationCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new AuthenticationCommandResponse();


            return response;
        }
    }
}
