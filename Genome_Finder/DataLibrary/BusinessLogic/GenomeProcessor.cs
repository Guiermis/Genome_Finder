using Genome_Finder.DataLibrary.Dapper;
using Genome_Finder.DataLibrary.Models;

namespace Genome_Finder.DataLibrary.BusinessLogic
{
    public static class GenomeProcessor
    {
        public static int CreateGenome(string nome, string gene, int Searchnum, string ncbiCod)
        {
            Base_Nitrogen data = new Base_Nitrogen
            {
                Nome = nome,
                Gene = gene,
                searchNum = Searchnum,
                NBCICod = ncbiCod
            };

            string sql = @"declare @NCBICod varchar(35); insert into dbo.Base_Nitrogen (nome, gene, searchNum, ncbiCod) values (@nome, @gene, @searchNum, @NCBICod);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int UpdateGenome(string nome)
        {
            Base_Nitrogen data = new Base_Nitrogen
            {
                Nome = nome
            };

            string sql = "update Base_Nitrogen set searchNum = searchNum + 1 where (nome) = (@nome);";

            return SqlDataAccess.UpdateData(sql, data);
        }

        public static List<Base_Nitrogen> LoadBases()
        {
            string sql = @"select id, nome, gene, searchNum, NCBICod
                            from dbo.Base_Nitrogen;";
            return SqlDataAccess.LoadData<Base_Nitrogen>(sql);
        }
    }
}
