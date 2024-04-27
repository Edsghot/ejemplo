using principal.Dto;

namespace principal.conexion
{
    public class DataTrabajador
    {
        public List<Trabajador> conexionBaseDatos()
        {
            string ubicacion = "./datacs.csv";
            StreamReader archivo = new StreamReader(ubicacion);
            archivo.ReadLine();
            string linea;
            string dni = "";
            List<Trabajador> listaTrabajador = new List<Trabajador>();
            var trabajador = new Trabajador();

            while ((linea = archivo.ReadLine()!) != null)
            {
                string[] fila = linea.Split("|");

                trabajador.Dni = new string(fila[0].Where(char.IsDigit).ToArray());
                trabajador.Horas = Convert.ToInt32(fila[1]);
                trabajador.Dias = Convert.ToInt32(fila[2]);
                trabajador.Faltas = Convert.ToInt32(fila[3]);
                var prob = fila[^1];
                trabajador.TipoTrabajador = Convert.ToInt32(prob[0].ToString());


                trabajador.CalcularSalario();

                listaTrabajador.Add(trabajador);
            }

            return listaTrabajador;

        }


        public string conexionBaseDatos2()
        {
            string ubicacion = "D:\\prueba tecnica\\datacs.csv";
            StreamReader archivo = new StreamReader(ubicacion);
            archivo.ReadLine();
            string linea;
            string dni = "";
            List<Trabajador> listaTrabajador = new List<Trabajador>();
            var trabajador = new Trabajador();

            while ((linea = archivo.ReadLine()!) != null)
            {
                string[] fila = linea.Split("|");

                dni = fila[0] + fila[1] + fila[2] + fila[3];
            }

            return dni;

        }

    }
}


