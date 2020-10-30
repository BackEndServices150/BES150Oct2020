using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Playlists.Models.Status
{
    public class GetStatusResponse
    {
        public string Message { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime LastChecked { get; set; }
    }
}
