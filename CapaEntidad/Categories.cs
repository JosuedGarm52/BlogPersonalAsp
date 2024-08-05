using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace CapaEntidad
{

    /*
     --
    -- Estructura de tabla para la tabla `categories`
    --

    CREATE TABLE `categories` (
      `Id` int(11) NOT NULL,
      `Name` varchar(100) NOT NULL
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `categories`
    --

    INSERT INTO `categories` (`Id`, `Name`) VALUES
    (5, 'Education'),
    (4, 'Food'),
    (2, 'Lifestyle'),
    (1, 'Technology'),
    (3, 'Travel');
     */
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Posts> Posts { get; set; }
    }
}
/*
public class CD_Usuarios
{
    public List<CD_Usuarios> lista = new List<CD_Usuarios>();

    try
    {
        using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
        {
            string query = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(query, oconexion);
            cmd.CommandType = CommandType.Text;

            oconexion.Open();
            
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Usuario
                    {
                        // Asignar valores desde dr
                    });
                }
            }
        }
    }
    catch (Exception ex)
    {
        // Manejar excepciones
    }
}

*/
