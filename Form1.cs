using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaAutorizacionSRI
{
	public partial class Form1 : Form
	{
		public List<ClaveAcceso> listaClavesAcceso = new List<ClaveAcceso>();
		public List<DatosTributarios> listaResultados = new List<DatosTributarios>();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvIn.DataSource = ClaveAcceso.GetData();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			List<ClaveAcceso> lista = new List<ClaveAcceso>();
			lista= (List<ClaveAcceso>)dgvIn.DataSource;
			foreach (ClaveAcceso claveAcceso in lista)
			{
				if (claveAcceso.Numero.Length == 49)
				{
					listaResultados.Add(LlamarSri(claveAcceso.Numero));
				}
			 
			}
			dgvOut.DataSource = listaResultados;
		}
		#region Metodos
		private DatosTributarios LlamarSri(string claveAcceso)
		{
			var resultado = string.Empty;
			DatosTributarios datosTributarios = null;
			string url = "https://cel.sri.gob.ec/comprobantes-electronicos-ws/AutorizacionComprobantes?wsdl";

			string xml = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:ec=\"http://ec.gob.sri.ws.autorizacion\">";
			xml = xml + "<soapenv:Header/>";
			xml = xml + "<soapenv:Body>";
			xml = xml + "<ec:autorizacionComprobante>";
			xml = xml + "<claveAccesoComprobante>" + claveAcceso + "</claveAccesoComprobante>";
			xml = xml + "</ec:autorizacionComprobante>";
			xml = xml + "</soapenv:Body>";
			xml = xml + "</soapenv:Envelope>";

			byte[] bytes = Encoding.ASCII.GetBytes(xml);
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.Method = "POST";
			request.ContentLength = bytes.Length;
			request.ContentType = "text/xml";

			Stream requestStream = request.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				Stream responseStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(responseStream);
				resultado = reader.ReadToEnd();
			}
			resultado = WebUtility.HtmlDecode(resultado);
			response.Close();
			if (resultado.Contains("<numeroComprobantes>0</numeroComprobantes>"))
			{
				datosTributarios = new DatosTributarios
				{
					claveAcceso = claveAcceso,
					numeroAutorizacion = "",
					FechaAutorizacion = DateTime.Now,
					Estado = "NO RECIBIDO",
				};
			}
			else
			{
				var caracterPrincipal = resultado.IndexOf('?') - 1;
				var caracterSecundario = resultado.LastIndexOf('?') + 2;
				resultado = resultado.Remove(caracterPrincipal, (caracterSecundario - caracterPrincipal));
				resultado = "<?xml version=" + "\"1.0\"" + " encoding=" + "\"UTF-8\"" + "?>" + resultado;
				System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
				doc.LoadXml(resultado);
				System.Xml.XmlNode element = doc.SelectSingleNode("numeroAutorizacion");
				datosTributarios = new DatosTributarios
				{
					claveAcceso = doc.GetElementsByTagName("claveAcceso")[0].InnerText,
					numeroAutorizacion = doc.GetElementsByTagName("numeroAutorizacion")[0].InnerText,
					FechaAutorizacion = Convert.ToDateTime(doc.GetElementsByTagName("fechaAutorizacion")[0].InnerText),
					Estado = doc.GetElementsByTagName("estado")[0].InnerText,
				};
			}
			return datosTributarios;
		}
		private void Copiar()
		{
			listaClavesAcceso = new List<ClaveAcceso>();
			string formato = DataFormats.CommaSeparatedValue;
			object contenido = Clipboard.GetData(formato);
			if (contenido != null && contenido is MemoryStream)
			{
				byte[] buffer;
				using (MemoryStream ms = (MemoryStream)contenido) buffer = ms.ToArray();
				string lista = Encoding.UTF8.GetString(buffer).Replace("\r\n", ",");
				string[] data = lista.Split(',');
				
				foreach (string a in data)
				{
					if (a.ToString().Length == 49)
					{
						listaClavesAcceso.Add(new ClaveAcceso { Numero = a.ToString() });
					}
				}
					

				dgvIn.DataSource = null;
				dgvIn.DataSource = listaClavesAcceso;
			}
			else MessageBox.Show("Numero de columnas a copiar del Excel y la Grilla deben ser iguales");
			
			}

		#endregion

		private void btnPegar_Click(object sender, EventArgs e)
		{
			this.Copiar();
		}
	}
}
