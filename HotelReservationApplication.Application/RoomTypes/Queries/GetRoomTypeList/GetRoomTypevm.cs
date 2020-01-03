using System.Collections.Generic;

namespace HotelReservationApplication.Application.RoomTypes.Queries.GetRoomTypeList
{
    public class GetRoomTypevm
    {
        public IList<RoomTypeLookupDto> RoomTypes { get; set; }
    }
}
