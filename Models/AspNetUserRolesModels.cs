using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vnmentor.Models
{
    public class AspNetUserRoles : IdentityUserRole<string>
    {
    }
}