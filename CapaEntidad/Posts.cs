using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*
    --
    -- Estructura de tabla para la tabla `posts`
    --

    CREATE TABLE `posts` (
      `Id` int(11) NOT NULL,
      `Title` varchar(255) NOT NULL,
      `Body` text NOT NULL,
      `AuthorId` int(11) DEFAULT NULL,
      `CategoryId` int(11) DEFAULT NULL,
      `CreatedAt` datetime DEFAULT current_timestamp(),
      `UpdatedAt` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp()
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `posts`
    --

    INSERT INTO `posts` (`Id`, `Title`, `Body`, `AuthorId`, `CategoryId`, `CreatedAt`, `UpdatedAt`) VALUES
    (1, 'Introduction to ASP.NET Core', 'ASP.NET Core is a cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.', 2, 1, '2024-07-28 22:19:26', '2024-07-28 22:19:26'),
    (2, 'Top 10 Travel Destinations', 'Discover the top 10 travel destinations for your next vacation and get inspired to explore the world.', 2, 3, '2024-07-28 22:19:26', '2024-07-28 22:19:26'),
    (3, 'Healthy Eating Tips', 'Learn about healthy eating habits and how to maintain a balanced diet.', 1, 4, '2024-07-28 22:19:26', '2024-07-28 22:19:26');

    -- --------------------------------------------------------
     */
    public class Posts
    {
    }
}
