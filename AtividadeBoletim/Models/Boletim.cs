namespace AtividadeBoletim.Models
{
    public class Boletim
    {
        public int Id { get; set; }
        public string NomeAluno { get; set; } = string.Empty;
        public string Materia { get; set; } = string.Empty;
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        
        public decimal Media => (Nota1 + Nota2) / 2;
        public string Situacao => Media >= 6.0m ? "Aprovado" : "Reprovado";
    }
}