using System;
using MediatR;
using MetWorkingUserApplication.Contracts.Response;

namespace MetWorkingUserApplication.Interest.Queries
{
    public class GetInterestByIdQuery: IRequest<InterestResponse>
    {
        public Guid Id { get; }

        public GetInterestByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}