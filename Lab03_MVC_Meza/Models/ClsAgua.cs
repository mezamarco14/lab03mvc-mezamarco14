using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab03_MVC_Meza.Models
{
	public class ClsAgua
	{
		[Required]
		[Display(Name ="Litros")]
		public int litros { get; set; }
	}
}