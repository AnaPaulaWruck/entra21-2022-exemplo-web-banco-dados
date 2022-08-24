namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Entidades
{
    public class Raca : EntidadeBase
    {
        // Entidades: são representações da tabelas para classes de objetos
        // Normalmente cada tabela é escrita como uma entidade
        // Nem todas as propriedades precisam existir nas colunas da tabela, mas todas as colunas da tabela precisam estar nas propriedades
        public string Nome { get; set; }
        public string Especie { get; set; }
    }
}
