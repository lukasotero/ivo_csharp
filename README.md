## Guia de ejercicios del profesor
### Ejercicio 1 (clase 1)
Realizar un programa que dada una clase "Cuenta", cuyo atributo es el saldo de la misma permita 'Acreditar' saldo sobre la misma.
- El valor que se acredita no puede ser menor que 0.
- Debe incluir un método constructor que permita inicializar el valor inicial del saldo.
- Crear los objetos necesarios para realizar las pruebas con los llamados a los métodos correspondientes

### Ejercicio 2 (clase 2)
Crea una clase llamada "Cuenta" que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
Crear un constructor con ambos atributos.
Crea sus propiedades get, set y el método ToString.

Tendrá dos métodos:
1) Ingresar(float cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
2) Retirar(float cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.

### Ejercicio 3 (clase 2)
Crear una clase llamada "Persona" que siga las siguientes condiciones:
- Sus atributos son: nombre, edad, DNI, sexo ('H' hombre, 'M' mujer), peso y altura.
- No queremos que se accedan directamente a ellos.

Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo será hombre por defecto.

Se deben generar varios constructores:
1) Un constructor por defecto (no recibe parámetros).
2) Un constructor con el nombre, edad y sexo, el resto por defecto.
3) Un constructor con todos los atributos como parámetro (menos el DNI que se genera automaticamente).

Los métodos que se implementaran son:
1) CalcularIMC(): calculara si la persona está en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula nos da un valor menor que 20 la función devuelve un -1 y significa que está en su peso ideal; si nos da un valor entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal y la función devuelve un 0; y si nos da un valor mayor que 25 significa que tiene sobrepeso y la función devuelve un 1.
2) EsMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
3) ComprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, será H. No será visible al exterior.
4) GeneraDNI(): genera un número aleatorio de 8 cifras. Este método sera invocado cuando se instancie el objeto. No será visible al exterior.

Propiedad set de cada parámetro, excepto de DNI.

Crear un programa que haga lo siguiente:
1) Pedir por teclado el nombre, la edad, sexo, peso y altura.
2) Crear 3 objetos de la clase Persona, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza las propiedades set para darle a los atributos un valor.
3) Para cada objeto, deberá comprobar si está en su peso ideal, si tiene sobrepeso o está por debajo con un mensaje.
4) Indicar para cada objeto si es mayor de edad.
5) Por último, mostrar la información de cada objeto (ToString).

### Ejercicio 4 (clase 2)
Crear una clase llamada "Password" con las siguientes características:
Que tenga los atributos longitud y contraseña. Por defecto, la longitud será de 8.
Los constructores serán los siguiente:
1) Un constructor por defecto (sin parámetros).
2) Un constructor con la longitud que nosotros le pasemos. Generara una contraseña aleatoria con esa longitud.

Los métodos que implementa serán:
1) esFuerte(): devuelve un booleano si es fuerte o no. Para que sea fuerte debe tener al menos 2 mayúsculas, 1 minúscula y 5 números. Opcional: se puede utilizar una Expresión Regular para el chequeo. 
2) generarPassword():  genera la contraseña con la longitud definida.
3) Método get para contraseña y longitud.
4) Método set (privados) para contraseña y longitud.

Crear una clase clase ejecutable:
1) Crear un vector de Passwords con el tamaño que se le indique por teclado.
2) Crear un objeto para cada posición del vector.
3) Indicar también por teclado la longitud de los Password (antes de ingresarlos).

Al final, mostrar la contraseña y si es o no fuerte. Usar este formato para mostrar por pantalla:
1) La contraseña "J98Kp765" es "FUERTE"
2) La contraseña "12345678" es "DEBIL"

### Ejercicio 5 (clase 3)
Crear una clase llamada "Fecha" con las siguientes características:
- Sus atributos son dia, mes y año.
- Crear un constructor con todos sus atributos como parámetro.

Los métodos que implementa serán:
1) Propiedades get públicas para todos sus atributos.
2) Propiedades set privadas para todos sus atributos, donde se deberá validar cada uno de los valores (al menos día y mes).
3) En caso de no cumplir los valores, los mismos deberán ponerse en '1'.
4) Método ToString() que permita visualizar el objeto con el siguiente formato: "mes/dia/año"

### Ejercicio 6 (clase 3) - Incompleto (faltan arreglar cosas)
Crearemos una clase llamada "Electrodomestico" con las siguientes características:

- Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. 
- Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de $100 y el peso de 5 kg.
- Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.

- Los constructores que se implementaran serán:
1) Un constructor por defecto (sin parámetros).
2) Un constructor con el precio y peso. El resto por defecto.
3) Un constructor con todos los atributos.

Los métodos que implementara serán:
1) Propiedad get de todos los atributos.
2) comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.
3) comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.
4) precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. Esta es la lista de precios:
LETRA    PRECIO
A        $100
B        $80
C        $60
D        $50
E        $30
F        $10

TAMAÑO                           PRECIO
Entre 0 y 20kg (no inclusive)    $10
Entre 20 y 50kg (no inclusive)   $50
Entre 50 y 80kg (no inclusive)   $80
Mayor o igual a 80kg             $100

Ahora crea una clase ejecutable que realice lo siguiente:
1) Crear un array de Electrodomesticos de 10 posiciones.
2) Asignar a cada posición un objeto con los valores que desees.
3) Mostrar el precio de cada Electrodomestico y la suma total.
4) Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, otro de 200 y otro de 500, el resultado final será de $1000 (300+200+500).\

## Guia de ejercicios inventados
### Ejercicio A
Crear una clase llamada "Empleado" con las siguientes características:

Atributos:
1) nombre: Nombre del empleado.
2) edad: Edad del empleado.
3) DNI: Número de identificación del empleado.
4) departamento: Departamento en el que trabaja el empleado.
5) salario: Salario del empleado.

- No se permitirá el acceso directo a estos atributos.

Inicialización: Por defecto, todos los atributos (excepto DNI) tomarán valores por defecto según su tipo (0 para números, cadena vacía para String, etc.).

Constructores:
1) Constructor por defecto: No recibe parámetros.
2) Constructor con nombre, edad y departamento como parámetros. Los demás atributos se inicializan por defecto.
3) Constructor con todos los atributos como parámetros, excepto DNI, que se genera automáticamente.

Métodos:
1) calcularSalarioAnual(): Calcula el salario anual del empleado multiplicando su salario mensual por 12.
2) esJubilado(): Indica si el empleado es jubilado, basándose en la edad (mayor o igual a 65 años). Retorna un booleano.
3) generaDNI(): Genera un número aleatorio de 8 cifras como DNI. Este método se invoca automáticamente al instanciar el objeto y no es visible desde el exterior.
4) Propiedad set para cada atributo, excepto para DNI.

Crear un programa que realice lo siguiente:
1) Solicitar al usuario el nombre, edad, departamento y salario por teclado.
2) Crear tres objetos de la clase Empleado: el primero con los valores ingresados por el usuario, el segundo con nombre, edad y departamento ingresados por el usuario, y el tercero con valores por defecto, utilizando los métodos set para asignar valores a los atributos.

Para cada objeto:
- Calcular y mostrar su salario anual.
- Indicar si es jubilado.
- Mostrar la información de cada objeto.

### Ejercicio B
Crear una clase llamada "Libro" con las siguientes características:

Atributos:
1) titulo: Título del libro.
2) autor: Autor del libro.
3) anio_publicacion: Año de publicación del libro.
4) genero: Género del libro.
5) paginas: Número de páginas del libro.

- No se permitirá el acceso directo a estos atributos.

Inicialización: Por defecto, todos los atributos tomarán valores por defecto según su tipo (0 para números, cadena vacía para String, etc.).

Constructores:
1) Constructor por defecto: No recibe parámetros.
2) Constructor con título, autor y género como parámetros. Los demás atributos se inicializan por defecto.
3) Constructor con todos los atributos como parámetros.

Métodos:
1) esBestSeller(): Indica si el libro es un best-seller o no, basándose en el número de páginas. Retorna un booleano, considerando que un best-seller tiene más de 300 páginas.
2) calcularAntiguedad(): Calcula cuántos años han pasado desde la publicación del libro hasta el año actual.
3) Propiedad set para cada atributo.

Crear un programa que realice lo siguiente:

1) Solicitar al usuario el título, autor, año de publicación, género y número de páginas del libro por teclado.
2) Crear tres objetos de la clase Libro: el primero con los valores ingresados por el usuario, el segundo con título, autor y género ingresados por el usuario, y el tercero con valores por defecto, utilizando los métodos set para asignar valores a los atributos.

Para cada objeto:
1) Indicar si es un best-seller.
2) Calcular y mostrar la antigüedad del libro.
3) Mostrar la información de cada objeto.