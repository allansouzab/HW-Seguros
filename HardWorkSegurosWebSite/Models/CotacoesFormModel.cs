using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HardWorkSegurosWebSite.Models
{
    public class CotacoesFormModel
    {
        public string Plano { get; set; }
        [Display(Name = "Tipo de Seguro")]
        public string TipoSeguro { get; set; }
        [Display(Name = "Opção de Acomodação")]
        public string OpcaoAcomodacao { get; set; }
        [Display(Name = "Opção de Cobertura")]
        public string OpcaoCobertura { get; set; }
        [Display(Name = "Opção de Reembolso")]
        public string OpcaoReembolso { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Seu Email")]
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Fixo { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Idade { get; set; }
        [Display(Name = "Opção de Plano")]
        public string OpcaoPlano { get; set; }
        [Display(Name = "Cobertura (R$)")]
        public string Cobertura { get; set; }
        [Display(Name = "Deseja contratar assistência funeral?")]
        public string DesejaFuneral { get; set; }
        [Display(Name = "Seu CPF")]
        public string Cpf { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; }
        [Display(Name = "Fumante?")]
        public string Fumante { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Sua Profissão")]
        public string Profissao { get; set; }
        [Display(Name = "Renda Mensal (R$)")]
        public string RendaMensal { get; set; }
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }
        [Display(Name = "Tem Filhos?")]
        public string TemFilhos { get; set; }
        [Display(Name = "Tipo de Contrato")]
        public string TipoContrato { get; set; }
        [Display(Name = "Seu RG")]
        public string Rg { get; set; }
        [Display(Name = "Data de Expedição")]
        public string DataExpedicaoRg { get; set; }
        [Display(Name = "Orgão Expedidor")]
        public string OrgaoExpeditor { get; set; }
        [Display(Name = "Número da CNH")]
        public string Cnh { get; set; }
        [Display(Name = "Data da 1ª CNH")]
        public string DataPrimeiraCnh { get; set; }
        [Display(Name = "Relação com o condutor")]
        public string RelacaoCondutor { get; set; }
        [Display(Name = "Seu CEP")]
        public string Cep { get; set; }
        public string Rua { get; set; }
        [Display(Name = "Número")]
        public string ResidenciaNum { get; set; }
        [Display(Name = "Complemento")]
        public string ResidenciaCompl { get; set; }
        [Display(Name = "Ano de Fabricação")]
        public string AnoFabricacao { get; set; }
        [Display(Name = "Ano de Modelo")]
        public string AnoModelo { get; set; }
        [Display(Name = "Marca do carro")]
        public string Marca { get; set; }
        [Display(Name = "Modelo do carro")]
        public string ModeloVersao { get; set; }
        [Display(Name = "Zero KM?")]
        public string ZeroKm { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        [Display(Name = "Possui Kit GNV?")]
        public string PossuiGnv { get; set; }
        [Display(Name = "Veículo Blindado?")]
        public string Blindado { get; set; }
        [Display(Name = "Deficiente Físico?")]
        public string DeficienteFisico { get; set; }
        [Display(Name = "Existem ou residem com o principal condutor e/ou segurado pessoas de 18 a 24 anos?")]
        public string Pessoas18a24 { get; set; }
        [Display(Name = "CEP de Pernoite")]
        public string CepPernoite { get; set; }
        [Display(Name = "Uso Comercial?")]
        public string UsoComercial { get; set; }
        [Display(Name = "Garagem na residência?")]
        public string GaragemResidencia { get; set; }
        [Display(Name = "Garagem no trabalho?")]
        public string GaragemTrabalho { get; set; }
        [Display(Name = "Garagem na escola?")]
        public string GaragemEscola { get; set; }
        [Display(Name = "Nome do Segurado")]
        public string NomeSegurado { get; set; }
        [Display(Name = "Nome do Condutor")]
        public string NomeCondutor { get; set; }
        [Display(Name = "CPF do Segurado")]
        public string CpfSegurado { get; set; }
        [Display(Name = "CPF do Condutor")]
        public string CpfCondutor { get; set; }
        [Display(Name = "Sexo do Segurado")]
        public string SexoSegurado { get; set; }
        [Display(Name = "Sexo do Condutor")]
        public string SexoCondutor { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string DataNascimentoSegurado { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string DataNascimentoCondutor { get; set; }
        [Display(Name = "Estado Civil")]
        public string EstadoCivilSegurado { get; set; }
        [Display(Name = "Estado Civil")]
        public string EstadoCivilCondutor { get; set; }
        [Display(Name = "CNH")]
        public string CnhSegurado { get; set; }
        [Display(Name = "CNH")]
        public string CnhCondutor { get; set; }
        [Display(Name = "Data da 1ª CNH")]
        public string DataPrimeiraCnhSegurado { get; set; }
        [Display(Name = "Data da 1ª CNH")]
        public string DataPrimeiraCnhCondutor { get; set; }

    }
}