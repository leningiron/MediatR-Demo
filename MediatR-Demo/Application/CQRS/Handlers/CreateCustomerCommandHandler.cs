using MediatR;
using MediatR_Demo.Application.CQRS.Command;
using MediatR_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Demo.Application.CQRS.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
    {

        public CreateCustomerCommandHandler()
        {
        }

        public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return 10;
        }
    }
}
