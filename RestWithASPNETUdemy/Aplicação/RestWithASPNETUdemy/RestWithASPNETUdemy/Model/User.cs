using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("users")]
    public class User
    {
        [Key]
        public long id { get; set; }

        [Column("user_name")]
        public string userName { get; set; }

        [Column("full_name")]
        public string fullName { get; set; }

        public string password { get; set; }

        [Column("refresh_token")]
        public string refreshToken { get; set; }

        [Column("refresh_token_expiry_time")]
        public DateTime refreshTokenExpiryTime { get; set; }

    }
}
