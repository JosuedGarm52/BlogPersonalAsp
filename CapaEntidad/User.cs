using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*
    --
    -- Estructura de tabla para la tabla `users`
    --

    CREATE TABLE `users` (
      `Id` int(11) NOT NULL,
      `Username` varchar(50) NOT NULL,
      `Email` varchar(255) NOT NULL,
      `PasswordHash` varchar(256) NOT NULL,
      `CreatedAt` datetime DEFAULT current_timestamp(),
      `UpdatedAt` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp()
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `users`
    --

    INSERT INTO `users` (`Id`, `Username`, `Email`, `PasswordHash`, `CreatedAt`, `UpdatedAt`) VALUES
    (1, 'johndoe', 'johndoe@example.com', 'hashedpassword1234567890abcdef...', '2024-07-28 22:11:09', '2024-07-28 22:11:09'),
    (2, 'janedoe', 'janedoe@example.com', 'hashedpassword0987654321fedcba...', '2024-07-28 22:11:09', '2024-07-28 22:11:09');
     */
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(256)]
        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<UserRoles> UserRoles { get; set; }
        public ICollection<Posts> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; } 
    }
}
