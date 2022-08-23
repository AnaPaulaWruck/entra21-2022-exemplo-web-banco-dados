using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados
{
    public class ClinicaVeterinariaContexto : DbContext
    {
        public DbSet<Raca> Racas { get; set; }

        public ClinicaVeterinariaContexto(
            DbContextOptions<ClinicaVeterinariaContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* 
            * Obs.: Necessário instalar a ferramenta dotnet ef core
            * Documentação: https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
            * Executar o comando: dotnet ef migrations add AdicionarRacaTabela --project Repositorio --startup-project Entra21.CSharp.ClinicaVeterinaria.Aplicacao
            * dotnet ef database update --project Repositorio --startup-project Entra21.CSharp.ClinicaVeterinaria.Aplicacao
            * 1ª etapa - Criar a entidade - Exemplo Raca.cs
            * 2ª etapa - Criar o mapeamento da entidade para tabelas - Exemplo RacaMapeamento.cs
            * 3ª etapa - Registrar o mapeamento
            * 4ª etapa - Gerar a migration
            * 5ª etapa - A migration poderá ser aplicada de duas formas:
            *     - executar comando para aplicar a migration sem a necessidade de executar a aplicação
            *     - executar a aplicação irá aplicar a migration
            */

            modelBuilder.ApplyConfiguration(new RacaMapeamento());
        }
    }
}
