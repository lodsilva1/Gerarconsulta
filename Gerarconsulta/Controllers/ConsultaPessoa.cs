using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerarconsulta.Controllers
{
    public class ConsultaPessoa
    {
        public string ConsultaNome(int Inicio, int Fim, int Qtde)
        {
            string OUrlPesquisa = "https://localhost:7120/ListaPessoas?IdadeInicial=" + Inicio.ToString() + "&IdadeFinal=" + Fim.ToString() + "&QuantasPessoas=" + Qtde.ToString() + "";

            HttpClient client = new HttpClient();

            HttpResponseMessage Resposta = client.GetAsync(OUrlPesquisa).Result;

            string jsonResposta = Resposta.Content.ReadAsStringAsync().Result;

            return jsonResposta;
        }
    }
}
