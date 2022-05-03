namespace Vendas.Service.Dtos
{
    public class DtoVenda
    {

        public int Id { get; set; }
        public int IdCurso { get; set; }
        public int IdEstudante { get; set; }
        public int IdCartao { get; set; }
        public double ValorTotal { get; set; }
    }
}
