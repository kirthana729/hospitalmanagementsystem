using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace hospitalmanagementsystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the hospitalmanagementsystemUser class
public class hospitalmanagementsystemUser : IdentityUser
{
	[PersonalData]
	[Column(TypeName ="nvarchar(100)")]
    public string FirstName { get; set; }

	[PersonalData]
	[Column(TypeName = "nvarchar(100)")]
	public string LastName { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int UserId { get; set; }


}

