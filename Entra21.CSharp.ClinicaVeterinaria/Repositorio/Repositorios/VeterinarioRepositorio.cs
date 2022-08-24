using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Repositorios
{
    internal class VeterinarioRepositorio : IVeterinarioRepositorio
    {
        private readonly ClinicaVeterinariaContexto _contexto;

        public VeterinarioRepositorio(ClinicaVeterinariaContexto contexto)
        {
            _contexto = contexto;
        }

        public Veterinario Cadastrar(Veterinario veterinario)
        {
            _contexto.Veterinarios.Add(veterinario);
            _contexto.SaveChanges();

            return veterinario;
        }

        public IList<Veterinario> ObterTodos(string pesquisa) => // <= expression body (só usa quando tem apenas "uma linha", não usar quando for construtor)
            _contexto.Veterinarios
                // buscar nome com LIKE ou CRMV exato
                .Where(x => x.Nome.Contains(pesquisa) || x.Crmv == pesquisa)
                .ToList();
    }
}
