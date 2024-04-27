namespace principal.Dto
{
    public record Trabajador
    {
        public string Dni { get; set; }
        public int Horas { get; set; }
        public int Dias { get; set; }
        public int Faltas { get; set; }
        public int TipoTrabajador {get;set;}
        public double Salario { get; set; }
    }
}
