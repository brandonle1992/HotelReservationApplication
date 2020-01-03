using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using HotelReservationApplication.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;


namespace HotelReservationApplication.Application.Reservations.Queries.GetReservationByCustomerID
{
    public class GetReservationListQueryHandler
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetReservationListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetReservationListvm> Handle(GetReservationListQuery request, CancellationToken cancellationToken)
        {
            var reservations = await _context.Reservations
                .ProjectTo<ReservationCLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new GetReservationListvm
            {
                Reservations = reservations
            };

            return vm;
        }
    }
}
