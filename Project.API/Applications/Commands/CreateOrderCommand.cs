﻿using MediatR;

namespace Project.API.Applications.Commands
{
    public class CreateOrderCommand:IRequest<Domain.AggregatesModel.Project>
    {
        public Domain.AggregatesModel.Project Project { get; set; }
    }
}