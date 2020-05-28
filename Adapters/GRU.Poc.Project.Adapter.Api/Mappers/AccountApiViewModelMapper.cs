using GRU.Poc.Project.Adapter.Api.Models;
using GRU.Poc.Project.Application.Commands.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRU.Poc.Project.Adapter.Api.Mappers
{
    public static class AccountApiViewModelMapper
    {

        public static AuthenticationCommandRequest MapToCommand(this AccountApiViewModel model)
        => new AuthenticationCommandRequest(model.UserCode,model.AccessKey);
    }
}
