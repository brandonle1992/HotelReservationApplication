using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelReservationApplication.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.RoomTypes.Queries.GetRoomTypeList
{
    public class GetRoomTypeListQueryHandler
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetRoomTypeListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetRoomTypevm> Handle(GetRoomTypeListQuery request, CancellationToken cancellationToken)
        {
            var roomtype = await _context.RoomType
                .ProjectTo<RoomTypeLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var vm = new GetRoomTypevm
            {
                RoomTypes = roomtype
            };

            return vm;
        }
    }
}
