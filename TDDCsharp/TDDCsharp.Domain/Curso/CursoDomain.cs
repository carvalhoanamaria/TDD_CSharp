using TDDCsharp.Domain.Cursos.Enums;

namespace TDDCsharp.Domain.Curso
{
    public class CursoDomain
    {
        public string Nome { get; private set; }

        public double CargaHoraria { get; private set; }

        public PublicoAlvo PublicoAlvo { get; set; }

        public decimal Valor { get; set; }

        public CursoDomain(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, decimal valor)
        {
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.Valor = valor;
        }
    }
}
