using Playlists.Models.Status;

namespace Playlists.Services
{
    public interface IProvideServerStatus
    {
        GetStatusResponse GetServerStatus();
    }
}