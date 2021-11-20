using MediatR;
using MediatR_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR_Demo.Application.CQRS.Command
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public Account Account { get; set; }
    }
}
