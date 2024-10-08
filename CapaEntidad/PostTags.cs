﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    /*
    --
    -- Estructura de tabla para la tabla `posttags`
    --

    CREATE TABLE `posttags` (
      `PostId` int (11) NOT NULL,
      `TagId` int (11) NOT NULL
    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE = utf8mb4_general_ci;

    --
    -- Volcado de datos para la tabla `posttags`
    --

    INSERT INTO `posttags` (`PostId`, `TagId`) VALUES
    (1, 1),
    (1, 5),
    (2, 3),
    (2, 4),
    (3, 2);

    -- --------------------------------------------------------
    */
    public class PostTags
    {
        [Required]
        public int PostId { get; set; }

        [Required]
        public int TagId { get; set; }

        [ForeignKey(nameof(PostId))]
        public virtual Posts Post { get; set; }

        [ForeignKey(nameof(TagId))]
        public virtual Tag Tag { get; set; }
    }

}
