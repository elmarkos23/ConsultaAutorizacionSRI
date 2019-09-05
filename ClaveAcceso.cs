using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaAutorizacionSRI
{
	public class ClaveAcceso
	{
		public string Numero { get; set; }
		public ClaveAcceso()
		{

		}
		public static List<ClaveAcceso> GetData()
		{
			List<ClaveAcceso> lista = new List<ClaveAcceso>();
			return lista;
		}

	}
}
