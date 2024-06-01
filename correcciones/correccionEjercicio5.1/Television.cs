namespace correccionEjercicio5._1
{
    // Acordate que el nombre de la clase siempre es la primera letra en mayúscula, cambié 'television' por 'Television'
    public class Television : Electrodomestico
    {
        private float resolucion = 20;
        private bool sintonizadorTDT = false;

        // Acordate que el constructor tiene que tener el mismo nombre de la clase
        public Television() : base() // Acordate que tiene que heredad de la clase padre, por eso le agregué el base()
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }

        // Acordate que el constructor tiene que tener el mismo nombre de la clase
        // Acordate de llenar el constructor con los atributos de esta clase 'Television'
        public Television(float pb, float p) : base(pb, p)
        {
            resolucion = 20;
            sintonizadorTDT = false;
        }

        // Acordate que el constructor tiene que tener el mismo nombre de la clase
        public Television(float pb2, string c, char ce, float pe, float res, bool sint) : base(pb2, c, ce, pe)
        {
            resolucion = res; // Acordate que podes usar el .this en vez de cambiarle el nombre a la variable
            sintonizadorTDT = sint; // Acordate que podes usar el .this en vez de cambiarle el nombre a la variable
        }

        //Getters
        public float Resolucion
        {
            get { return resolucion; }
        }

        public bool SintotizadorTDT
        {
            get { return sintonizadorTDT; }
        }

        // Métodos
        public override float Preciofinal()
        {
            float precio = base.Preciofinal(); // Primero creamos una variable local para guardar el precio base

            if (resolucion > 40)
            {
                precio += precio * 0.3f; // Esta es otra manera
                // preciob = base.Preciofinal() + (base.Preciofinal() * 0.3f);
            }

            if (sintonizadorTDT == true) // El == true es redundante, podes borrarlo que no pasa nada
            {
                precio += 50; // Esta es otra manera
                // preciob = base.Preciofinal() + (base.Preciofinal() * 0.5f);
            }

            return precio; // Retornamos la variable local que creamos
            //return preciob;
        }
    }
}
