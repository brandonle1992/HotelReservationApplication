using HotelReservationApplication.Application.Notifications;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.Common.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(MessageDto message);
    }
}
