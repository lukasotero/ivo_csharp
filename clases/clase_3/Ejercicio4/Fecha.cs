namespace Ejercicio4
{
    public class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        // Getters y setters para el atributo
        public int GetDia()
        {
            return dia;
        }

        public int GetMes()
        {
            return mes;
        }

        public int GetAnio()
        {
            return anio;
        }

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

        public void SetAnio(int anio)
        {
            this.anio = anio;
        }

        public override string ToString()
        {
            return $"{mes}/{dia}/{anio}";
        }
    }
}
