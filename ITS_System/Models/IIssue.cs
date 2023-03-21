using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ITS_System.Models
{
    public interface IIssue
    {
        public Guid Id { get; set; }

        public string Details { get; set; }

        public IdentityUser RecordedBy { get; set; }

        public DateTime Timestamp { get; set; }

    }
}
