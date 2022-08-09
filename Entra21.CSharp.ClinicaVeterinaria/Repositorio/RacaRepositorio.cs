using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio
{
    public class RacaRepositorio : IRacaRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;

        public RacaRepositorio(ClinicaVeterinariaContexto contexto)
        {
            // Contexto é o que irá permitir fazer todas as interações com o banco de dados
            _contexto = contexto;
        }

        public void Cadastrar(Raca raca)
        {
            // INSERT na tabela de racas
            _contexto.Racas.Add(raca);
            _contexto.SaveChanges();
        }
    }
}
