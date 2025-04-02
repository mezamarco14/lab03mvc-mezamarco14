using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab03_MVC_Meza.Models
{
	public class ClsDispensador
	{
        [Required]
        public double Monto { get; set; }
        public double b10 { get; set; }

        public double b20 { get; set; }

        public double b50 { get; set; }

        public double b100 { get; set; }
        public double b200 { get; set; }

        public double m5 { get; set; }
        public double m2 { get; set; }
        public double m1 { get; set; }
        public double m050 { get; set; }
        public double m020 { get; set; }
        public double m010 { get; set; }
        public double m005 { get; set; }

        public double CantidadBi { get; set; }
        public double CantidadMo { get; set; }



    }
}