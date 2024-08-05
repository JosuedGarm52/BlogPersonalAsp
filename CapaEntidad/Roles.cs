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
    -- Estructura de tabla para la tabla `roles`
    --

    CREATE TABLE `roles` (
      `Id` int(11) NOT NULL,
      `Name` varchar(50) NOT NULL
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `roles`
    --

    INSERT INTO `roles` (`Id`, `Name`) VALUES
    (1, 'Admin'),
    (2, 'Author'),
    (3, 'Reader');

    -- --------------------------------------------------------
     */

    public class Roles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
