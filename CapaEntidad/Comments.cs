using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*
    --
    -- Estructura de tabla para la tabla `comments`
    --

    CREATE TABLE `comments` (
      `Id` int(11) NOT NULL,
      `PostId` int(11) DEFAULT NULL,
      `AuthorId` int(11) DEFAULT NULL,
      `Content` text NOT NULL,
      `CreatedAt` datetime DEFAULT current_timestamp()
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `comments`
    --

    INSERT INTO `comments` (`Id`, `PostId`, `AuthorId`, `Content`, `CreatedAt`) VALUES
    (1, 1, 1, 'Great introduction to ASP.NET Core! Looking forward to trying it out.', '2024-07-28 22:19:26'),
    (2, 1, 2, 'Thanks for the detailed explanation. Very helpful!', '2024-07-28 22:19:26'),
    (3, 2, 1, 'These destinations look amazing. Can you provide more details on each one?', '2024-07-28 22:19:26'),
    (4, 3, 2, 'Excellent tips on healthy eating. I will definitely try some of these!', '2024-07-28 22:19:26');

    -- --------------------------------------------------------
     */
    public class Comments
    {
    }
}
