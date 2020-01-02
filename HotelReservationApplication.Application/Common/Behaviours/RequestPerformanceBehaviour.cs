using MediatR;
using Microsoft.Extensions.Logging;
using HotelReservationApplication.Application.Common.Interfaces;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.Common.Behaviours
{
    public class RequestPerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly Stopwatch _stopwatch;
        private readonly ILogger<TRequest> _logger;
        private readonly ICurrentUserService _currentUserService;

        public RequestPerformanceBehaviour(ILogger<TRequest> logger, ICurrentUserService user)
        {
            _stopwatch = new Stopwatch();
            _logger = logger;
            _currentUserService = user;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            _stopwatch.Start();

            var response = await next();

            _stopwatch.Stop();

            if(_stopwatch.ElapsedMilliseconds > 500)
            {
                var name = typeof(TRequest).Name;
                _logger.LogWarning("Hotel Reservation Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@UserId} {@Request}",
                    name, _stopwatch.ElapsedMilliseconds, _currentUserService.UserID, request);

            }

            return response;
        }
    }
}
