using HotelReservationApplication.Application.Common.Models;
using System.Threading.Tasks;

namespace HotelReservationApplication.Application.Common.Interfaces
{
    public interface IUserManager
    {
        Task<(Result Result, string UserID)> CreateUserAsync(string userName, string password);
        Task<Result> DeleteUserAsync(string userID);
    }
}
