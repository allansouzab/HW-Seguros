using HardWorkSegurosWebSite.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HardWorkSegurosWebSite.Controllers
{
    public class CotacoesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SentTrue()
        {
            return View();
        }

        public ActionResult SentNotTrue()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(CotacoesFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = GetEmailBody(model);
                var message = new MailMessage();
                message.To.Add(new MailAddress("seguros@hardworkbr.com"));  // replace with valid value 
                //message.To.Add(new MailAddress("allansouzab@hotmail.com"));  // replace with valid value 
                message.From = new MailAddress("websitehardwork@hotmail.com");  // replace with valid value
                message.Subject = string.Format("HardWork Seguros - Cotação de {0}", model.Plano);
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "websitehardwork@hotmail.com",  // replace with valid value
                        Password = "All@n1souza2"  // replace with valid value
                    };
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = credential;
                    await smtp.SendMailAsync(message);

                    ViewBag.EmailReturn = "Email enviado com sucesso. Retornaremos em breve!";
                    return RedirectToAction("SentTrue");
                }
            }
            ViewBag.EmailReturn = "Falha ao enviar email. Tente novamente em alguns instantes!";
            return RedirectToAction("SentNotTrue");
        }

        public string GetEmailBody(CotacoesFormModel model)
        {
            if (model.Plano == "Saúde")
            {
                return string.Format($"" +
                $"<p><h2>{model.Plano} solicitado por {model.Nome} ({model.Email})</h2></p>" +
                "<p><h3>Dados do Plano:</h3></p>" +
                $"<b>Tipo de Seguro:</b> {model.TipoSeguro}<br>" +
                $"<b>Opção de Acomodação:</b> {model.OpcaoAcomodacao}<br>" +
                $"<b>Opção de Reembolso:</b> {model.OpcaoReembolso}<br>" +
                $"<b>Opção de Cobertura:</b> {model.OpcaoCobertura}<br>" +

                "<p><h3>Dados Pessoais:</h3></p>" +
                $"<b>Nome:</b> {model.Nome}<br>" +
                $"<b>Email:</b> {model.Email}<br>" +
                $"<b>Celular:</b> {model.Celular}<br>" +
                $"<b>Fixo:</b> {model.Fixo}<br>" +
                $"<b>Estado:</b> {model.Estado}<br>" +
                $"<b>Cidade:</b> {model.Cidade}<br>" +
                $"<b>Idade:</b> {model.Idade}<br>" +
                $"<b>Opção de Plano:</b> {model.OpcaoPlano}");
            }
            else if (model.Plano == "Vida")
            {
                return string.Format($"" +
                $"<p><h2>{model.Plano} solicitado por {model.Nome} ({model.Email})</h2></p>" +
                "<p><h3>Dados do Plano:</h3></p>" +
                $"<b>Tipo de Seguro:</b> {model.TipoSeguro}<br>" +
                $"<b>Cobertura:</b> {model.Cobertura}<br>" +
                $"<b>Deseja Assistência Funeral?:</b> {model.DesejaFuneral}<br>" +
                $"<b>Tipo de Contrato:</b> {model.TipoContrato}<br>" +

                "<p><h3>Dados Pessoais:</h3></p>" +
                $"<b>Nome:</b> {model.Nome}<br>" +
                $"<b>Email:</b> {model.Email}<br>" +
                $"<b>Celular:</b> {model.Celular}<br>" +
                $"<b>Fixo:</b> {model.Fixo}<br>" +
                $"<b>CPF:</b> {model.Cpf}<br>" +
                $"<b>Data de Nascimento:</b> {model.DataNascimento}<br>" +
                $"<b>Fumante:</b> {model.Fumante}<br>" +
                $"<b>Sexo:</b> {model.Sexo}<br>" +
                $"<b>Profissão:</b> {model.Profissao}<br>" +
                $"<b>Renda Mensal:</b> {model.RendaMensal}<br>" +
                $"<b>Estado Civil:</b> {model.EstadoCivil}<br>" +
                $"<b>Tem Filhos?:</b> {model.TemFilhos}");
            }
            else if(model.Plano == "Auto")
            {
                return string.Format($"" +
                $"<p><h2>{model.Plano} solicitado por {model.Nome} ({model.Email})</h2></p>" +
                "<p><h3>Informações do Segurado:</h3></p>" +
                $"<b>Nome:</b> {model.NomeSegurado}<br>" +
                $"<b>CPF:</b> {model.CpfSegurado}<br>" +
                $"<b>RG:</b> {model.Rg}<br>" +
                $"<b>Data de Expedição:</b> {model.DataExpedicaoRg}<br>" +
                $"<b>Órgão Expedidor:</b> {model.OrgaoExpeditor}<br>" +
                $"<b>Sexo:</b> {model.SexoSegurado}<br>" +
                $"<b>Data de Nascimento:</b> {model.DataNascimentoSegurado}<br>" +
                $"<b>Estado Civil:</b> {model.EstadoCivilSegurado}<br>" +
                $"<b>CNH:</b> {model.CnhSegurado}<br>" +
                $"<b>Data da 1ª CNH:</b> {model.DataPrimeiraCnhSegurado}<br>" +
                $"<b>Relação com o condutor:</b> {model.RelacaoCondutor}<br>" +
                $"<b>Email:</b> {model.Email}<br>" +
                $"<b>Telefone:</b> {model.Fixo}<br>" +
                $"<b>Celular:</b> {model.Celular}<br>" +
                $"<b>CEP:</b> {model.Cep}<br>" +
                $"<b>Rua:</b> {model.Rua}<br>" +
                $"<b>Número:</b> {model.ResidenciaNum}<br>" +
                $"<b>Complemento:</b> {model.ResidenciaCompl}<br>" +
                $"<b>Estado:</b> {model.Estado}<br>" +
                $"<b>Cidade:</b> {model.Cidade}<br>" +

                "<p><h3>Informações do Condutor:</h3></p>" +
                $"<b>Nome:</b> {model.NomeCondutor}<br>" +
                $"<b>CPF:</b> {model.CpfCondutor}<br>" +
                $"<b>Sexo:</b> {model.SexoCondutor}<br>" +
                $"<b>Data de Nascimento:</b> {model.DataNascimentoCondutor}<br>" +
                $"<b>Estado Civil:</b> {model.EstadoCivilCondutor}<br>" +
                $"<b>CNH:</b> {model.CnhCondutor}<br>" +
                $"<b>Data da 1ª CNH:</b> {model.DataPrimeiraCnhCondutor}<br>" +

                "<p><h3>Informações do Veículo:</h3></p>" +
                $"<b>Fabricação:</b> {model.AnoFabricacao}<br>" +
                $"<b>Modelo:</b> {model.AnoModelo}<br>" +
                $"<b>Marca:</b> {model.Marca}<br>" +
                $"<b>Modelo/Versão:</b> {model.ModeloVersao}<br>" +
                $"<b>Zero KM?:</b> {model.ZeroKm}<br>" +
                $"<b>Placa:</b> {model.Placa}<br>" +
                $"<b>Chassi</b> {model.Chassi}<br>" +
                $"<b>Renavam</b> {model.Renavam}<br>" +
                $"<b>Possui Kit GNV?</b> {model.PossuiGnv}<br>" +
                $"<b>Veículo Blindado</b> {model.Blindado}<br>" +
                $"<b>Deficiente Físico?</b> {model.DeficienteFisico}<br>" +

                "<p><h3>Informações Adicionais:</h3></p>" +
                $"<b>Tipo de Seguro:</b> {model.TipoSeguro}<br>" +
                $"<b>Existem ou residem com o principal condutor e / ou segurado pessoas de 18 a 24 anos?:</b> {model.Pessoas18a24}<br>" +
                $"<b>CEP de Pernoite:</b> {model.CepPernoite}<br>" +
                $"<b>Uso Comercial?:</b> {model.UsoComercial}<br>" +
                $"<b>Garagem na Residência:</b> {model.GaragemResidencia}<br>" +
                $"<b>Garagem no Trabalho:</b> {model.GaragemTrabalho}<br>" +
                $"<b>Garagem na Escola:</b> {model.GaragemEscola}<br>");
            }
            else
            {
                return string.Format($"" +
                $"<p><h2>{model.Plano} solicitado por {model.Nome} ({model.Email})</h2></p>" +
                "<p><h3>Informações:</h3></p>" +
                $"<b>Nome:</b> {model.Nome}<br>" +
                $"<b>Email:</b> {model.Email}<br>" +
                $"<b>Celular:</b> {model.Celular}<br>");
            }
        }

    }
}