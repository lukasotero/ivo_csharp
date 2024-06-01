namespace correccionEjercicio5._1
{
    // Acordate que el nombre de la clase siempre es la primera letra en mayúscula, cambié 'lavadora' por 'Lavadora'
    public class Lavadora : Electrodomestico
    {
        private float carga = 5;

        // Acordate de llenar el constructor sin parámetros con los valores default
        public Lavadora() : base() // Acordate que tiene que heredad de la clase padre, por eso le agregué el base()
        {
            carga = 5;
        }

        // Acordate de llenar el constructor con los atributos de esta clase 'Lavadora', en este caso 'carga' nada más
        public Lavadora(float pb, float p) : base(pb, p)
        {
            carga = 5;
        }

        public Lavadora(float pb2, string c, char ce, float pe, float cr) : base(pb2, c, ce, pe)
        {
            carga = cr; // Acordate que podes usar el .this en vez de cambiarle el nombre a la variable
        }

        // Getter
        public float Carga
        {
            get { return carga; }
        }

        // Métodos
        public override float Preciofinal()
        {
            float precio = base.Preciofinal(); // Primero creamos una variable local para guardar el precio base

            if (Carga > 30) // Ojo aca con la validación, si la carga es mayor a 30, el precio aumenta 50
            {
                precio += 50; // Usamos el += para sumarle 50 al precio
            }

            return precio; // Retornamos la variable local que creamos

            /*if (carga < 30)
            /{ preciob = base.Preciofinal() + 50; }
            return preciob;*/
        }
    }
}
