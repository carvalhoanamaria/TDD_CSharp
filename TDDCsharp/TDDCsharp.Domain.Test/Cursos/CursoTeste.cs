using TDDCsharp.Domain.Curso;
using TDDCsharp.Domain.Cursos.Enums;
using Xunit;

namespace TDDCsharp.Domain.Test.Cursos
{
    public class CursoTeste
    {

        // Criar um curso com os seguintes dados:
        // Nome, Carga Horaria, Publico alvo e Valor do Curso

        [Fact]
        public void Curso_CriarCurso_RetornaCurso()
        {
            var CursoEsperado = new
            {
                Nome = "Curso de TDD",
                CargaHoraria = (double)40,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = (decimal) 100    
            };

            var curso = new CursoDomain(CursoEsperado.Nome,
                                  CursoEsperado.CargaHoraria,
                                  CursoEsperado.PublicoAlvo,
                                  CursoEsperado.Valor);

            Assert.Equal(CursoEsperado.Nome, curso.Nome);
        }

    }
}
