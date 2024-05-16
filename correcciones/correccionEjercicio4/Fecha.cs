namespace correccionEjercicio4
{
    public class Fecha // Cuidado con los nombres de las clases, no deben ser iguales a las de los namespaces
    {
        // Atributos
        private int dia; // Cambié "dia" -> "dia"
        private int mes;
        private int anio;

        // Constructor
        public Fecha(int fecha, int m, int a) // No hace falta cambiar el nombre de las variables. Esto se soluciona con el .this
        {
            // Estos atributos tienen que hacer referencia a los atributos de la clase y no al Setter.
            // Cambié "Fecha" -> "dia" / "Mes" -> "mes" / "Anio" -> "anio".
            this.dia = fecha; // Ejemplo del uso del .this
            mes = m;
            anio = a;
        }

        // Getter y Setter
        // Cuidado con los Getters y Setters, crealos por separado. De esta manera queda mas claro el código y disminuis errores. 
        public int getDia() => dia; // Getter en una sola línea

        public void SetDia(int dia)
        {
            if (dia >= 1 && dia <= 31)
            {
                this.dia = dia;
            }
            else
            {
                this.dia = 1;
            }
        }
        public int getMes() => mes; // Getter en una sola línea

        public void SetMes(int mes)
        {
            if (mes >= 1 && mes <= 12)
            {
                this.mes = mes;
            }
            else
            {
                this.mes = 1;
            }
        }

        public int getAnio() => anio; // Getter en una sola línea
        public void SetAnio(int anio) => this.anio = anio; // Setter en una sola línea


        /*public int Fecha
        {
            get { return dia; }
            private set
            {
                if (dia < 1 || dia > 31)
                {
                    dia = 1;
                }
                else
                {
                    dia = value;
                }
            }
        }

        public int Mes
        {
            get { return mes; }
            private set
            {
                if (mes == 2 || dia > 29) { dia = 1; }
                if (mes > 12 || mes < 1)
                {
                    mes = 1;
                }
                else
                {
                    mes = value;
                }
            }
        }

        public int Anio
        {
            get { return anio; }
            private set { anio = value; }
        }*/

        // ToString
        public override string ToString()
        {
            // return string.Format("{0}/{1}/{2}", Mes, Fecha, Anio);
            return $"{mes}/{dia}/{anio}"; // Esta es otra posibilidad
        }
    }
}
