using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingLeagueAPI.Data
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public int? CaptainID { get; set; }
    }
}
