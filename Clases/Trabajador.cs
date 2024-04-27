namespace principal.Dto
{
    public class Trabajador
    {
        public string Dni { get; set; }
        public int Horas { get; set; }
        public int Dias { get; set; }
        public int Faltas { get; set; }
        public int TipoTrabajador { get; set; }
        public double Salario { get; set; }


        public double CalcularSalarioObrero()
        {
         var monto = (((Horas*Dias) * 15) - (12 * Faltas) + 130);
           return monto * 0.12;
        }

        public double CalcularSalarioSupervisor()
        {
         var monto = (((Horas*Dias) * 35) - (280 * Faltas) + 200);
           return monto * 0.16;
        }

        public double CalcularSalarioGerente()
        {
             var monto = (((Horas*Dias) * 85) - (680 * Faltas) + 350);
            return monto * 18;
        }

        public double sueldoMayores()
        {
            return (TipoTrabajador == 1) ? CalcularSalarioSupervisor() : CalcularSalarioGerente();
        }

        public void CalcularSalario()
        {
           this.Salario =  (TipoTrabajador == 0) ? CalcularSalarioObrero() : sueldoMayores();  
        }
}
}
