using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using HotelReservationApplication.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.Common.Behaviours
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger _logger;
        private readonly ICurrentUserService _currentUserService;

        public RequestLogger(ILogger<TRequest> logger, ICurrentUserService user)
        {
            _logger = logger;
            _currentUserService = user;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var name = typeof(TRequest).Name;

            _logger.LogInformation("Hotel Reservation Request: {Name} {@UserId} {@Request}"
                , name, _currentUserService.UserID, request);

            return Task.CompletedTask;
        }
    }
}
