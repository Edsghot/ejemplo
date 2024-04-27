using principal.Dto;

namespace principal.conexion
{
    public class DataTrabajador
    {
        public List<Trabajador> conexionBaseDatos()
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

                trabajador.Dni = fila[0];
                trabajador.Horas = int.Parse(fila[1]);
                trabajador.Dias = int.Parse(fila[2]);
                trabajador.Faltas = int.Parse(fila[3]);
                trabajador.TipoTrabajador = int.Parse(fila[4]);

                trabajador.CalcularSalario();

                listaTrabajador.Add(trabajador);
            }

            return listaTrabajador;

        }

    }
}


