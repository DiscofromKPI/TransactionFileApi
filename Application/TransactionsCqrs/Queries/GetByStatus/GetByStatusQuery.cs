﻿using System.IO;
using Domain;
using MediatR;

namespace Application.TransactionsCqrs.Queries.GetByStatus
{
    public class GetByStatusQuery : IRequest<MemoryStream>
    {
        public Status Status { get; set; }

        public GetByStatusQuery(Status status) =>
            Status = status;
    }
}