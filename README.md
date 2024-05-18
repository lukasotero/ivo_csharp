# Guia de ejercicios del profesor
## :heavy_check_mark: Ejercicio 0 (está en la clase 1)
Realizar un programa que dada una clase "Cuenta", cuyo atributo es el saldo de la misma permita 'Acreditar' saldo sobre la misma.
- El valor que se acredita no puede ser menor que 0.
- Debe incluir un método constructor que permita inicializar el valor inicial del saldo.
- Crear los objetos necesarios para realizar las pruebas con los llamados a los métodos correspondientes

## :heavy_check_mark: Ejercicio 1 (está en la clase 2)
Crea una clase llamada "Cuenta" que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
Crear un constructor con ambos atributos.
Crea sus propiedades get, set y el método ToString.

Tendrá dos métodos:
- Ingresar(float cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
- Retirar(float cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.

## :heavy_check_mark: Ejercicio 2 (está en la clase 2)
Crear una clase llamada "Persona" que siga las siguientes condiciones:
- Sus atributos son: nombre, edad, DNI, sexo ('H' hombre, 'M' mujer), peso y altura.
- No queremos que se accedan directamente a ellos.

Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo será hombre por defecto.

Se deben generar varios constructores:
- Un constructor por defecto (no recibe parámetros).
- Un constructor con el nombre, edad y sexo, el resto por defecto.
- Un constructor con todos los atributos como parámetro (menos el DNI que se genera automaticamente).

Los métodos que se implementaran son:
- CalcularIMC(): calculara si la persona está en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula nos da un valor menor que 20 la función devuelve un -1 y significa que está en su peso ideal; si nos da un valor entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal y la función devuelve un 0; y si nos da un valor mayor que 25 significa que tiene sobrepeso y la función devuelve un 1.
- EsMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
- ComprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, será H. No será visible al exterior.
- GeneraDNI(): genera un número aleatorio de 8 cifras. Este método sera invocado cuando se instancie el objeto. No será visible al exterior.

Propiedad set de cada parámetro, excepto de DNI.

Crear un programa que haga lo siguiente:
- Pedir por teclado el nombre, la edad, sexo, peso y altura.
- Crear 3 objetos de la clase Persona, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza las propiedades set para darle a los atributos un valor.
- Para cada objeto, deberá comprobar si está en su peso ideal, si tiene sobrepeso o está por debajo con un mensaje.
- Indicar para cada objeto si es mayor de edad.
- Por último, mostrar la información de cada objeto (ToString).

## :heavy_check_mark: Ejercicio 3 (está en la clase 2)
Crear una clase llamada "Password" con las siguientes características:
- Que tenga los atributos longitud y contraseña. Por defecto, la longitud será de 8.

Los constructores serán los siguiente:
- Un constructor por defecto (sin parámetros).
- Un constructor con la longitud que nosotros le pasemos. Generara una contraseña aleatoria con esa longitud.

Los métodos que implementa serán:
- esFuerte(): devuelve un booleano si es fuerte o no. Para que sea fuerte debe tener al menos 2 mayúsculas, 1 minúscula y 5 números. Opcional: se puede utilizar una Expresión Regular para el chequeo.
- generarPassword():  genera la contraseña con la longitud definida.
- Método get para contraseña y longitud.
- Método set (privados) para contraseña y longitud.

Crear una clase clase ejecutable:
- Crear un vector de Passwords con el tamaño que se le indique por teclado.
- Crear un objeto para cada posición del vector.
- Indicar también por teclado la longitud de los Password (antes de ingresarlos).

Al final, mostrar la contraseña y si es o no fuerte. Usar este formato para mostrar por pantalla:
- La contraseña "J98Kp765" es "FUERTE"
- La contraseña "12345678" es "DEBIL"

## :heavy_check_mark: Ejercicio 4 (está en la clase 3)
Crear una clase llamada "Fecha" con las siguientes características:
- Sus atributos son dia, mes y año.
- Crear un constructor con todos sus atributos como parámetro.

Los métodos que implementa serán:
- Propiedades get públicas para todos sus atributos.
- Propiedades set privadas para todos sus atributos, donde se deberá validar cada uno de los valores (al menos día y mes).
- En caso de no cumplir los valores, los mismos deberán ponerse en '1'.
- Método ToString() que permita visualizar el objeto con el siguiente formato: "mes/dia/año"

## :soon: Ejercicio 5 (está en la clase 4)
Crearemos una clase llamada "Electrodomestico" con las siguientes características:

- Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. 
- Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de $100 y el peso de 5 kg.
- Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.

Los constructores que se implementaran serán:
- Un constructor por defecto (sin parámetros).
- Un constructor con el precio y peso. El resto por defecto.
- Un constructor con todos los atributos.

Los métodos que implementara serán:
- Propiedad get de todos los atributos.
- comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.
- comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.
- precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. Esta es la lista de precios:

| LETRA | PRECIO |
| :---: | :---: |
| A     | $100 |
| B     | $80  |
| C     | $60  |
| D     | $50  |
| E     | $30  |
| F     | $10  |

| TAMAÑO | PRECIO |
| :---: | :---: |
| Entre 0 y 20kg (no inclusive) | $10 |
| Entre 20 y 50kg (no inclusive) | $50 |
| Entre 50 y 80kg (no inclusive) | $80 |
| Mayor o igual a 80kg | $100 |

Ahora crea una clase ejecutable que realice lo siguiente:
- Crear un array de Electrodomesticos de 10 posiciones.
- Asignar a cada posición un objeto con los valores que desees.
- Mostrar el precio de cada Electrodomestico y la suma total.
- Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, otro de 200 y otro de 500, el resultado final será de $1000 (300+200+500).

### :heavy_check_mark: Ejercicio 5.1 (está en la clase 5)
Crearemos una clase llamada "Electrodomestico" con las siguientes características:

- Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. Indica que se podrán heredar.
- Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de $100 y el peso de 5 kg.
- Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.

Los constructores que se implementaran serán:
- Un constructor por defecto (sin parámetros).
- Un constructor con el precio y peso. El resto por defecto.
- Un constructor con todos los atributos.

Los métodos que implementara serán:
- Propiedad get de todos los atributos.
- comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.
- comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.
- precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también. Esta es la lista de precios:

| LETRA	| PRECIO |
| :---: | :---: |
| A	|	$100 |
| B | $80 |
| C | $60 |
| D | $50 |
| E | $30 |
| F | $10 |

| TAMAÑO | PRECIO |
| :---: | :---: |
| Entre 0 y 20kg (no inclusive) | $10 |
| Entre 20 y 50kg (no inclusive) | $50 |
| Entre 50 y 80kg (no inclusive) | $80 |
| Mayor o igual a 80kg | $100 |

Crear una subclase llamada "Lavadora" con las siguientes características:
- Su atributo es carga, además de los atributos heredados.
- Por defecto, la carga es de 5 kg.

Los constructores que se implementaran serán:
- Un constructor por defecto.
- Un constructor con el precio y peso. El resto por defecto.
- Un constructor con la carga y el resto de atributos heredados.

Los métodos que se implementara serán:
- Método get de carga.
- precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio $50, sino es así no se incrementara el precio. Las condiciones en la clase Electrodomestico también deben afectar al precio.

Crear una subclase llamada "Television" con las siguientes características:
- Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), además de los atributos heredados.
- Por defecto, la resolución será de 20 pulgadas y no tendrá sintonizador.

Los constructores que se implementaran serán:
- Un constructor por defecto.
- Un constructor con el precio y peso. El resto por defecto.
- Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.

Los métodos que se implementara serán:
- Método get de resolución y sintonizador TDT.
- precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% y si tiene un sintonizador TDT incorporado, aumentara $50. Recuerda que las
- condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.

Crear una clase ejecutable que realice lo siguiente:
- Crear un array de Electrodomesticos de 10 posiciones.
- Asignar a cada posición un objeto de las clases anteriores con valores.
- Recorre el array y ejecuta el método precioFinal().
- Mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los Electrodomesticos.
Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.

# Guia de ejercicios inventados
## :soon: Ejercicio A
Crear una clase llamada "Empleado" con las siguientes características:

Atributos:
- nombre: Nombre del empleado.
- edad: Edad del empleado.
- DNI: Número de identificación del empleado.
- departamento: Departamento en el que trabaja el empleado.
- salario: Salario del empleado.
No se permitirá el acceso directo a estos atributos.

Inicialización: Por defecto, todos los atributos (excepto DNI) tomarán valores por defecto según su tipo (0 para números, cadena vacía para String, etc.).

Constructores:
- Constructor por defecto: No recibe parámetros.
- Constructor con nombre, edad y departamento como parámetros. Los demás atributos se inicializan por defecto.
- Constructor con todos los atributos como parámetros, excepto DNI, que se genera automáticamente.

Métodos:
- calcularSalarioAnual(): Calcula el salario anual del empleado multiplicando su salario mensual por 12.
- esJubilado(): Indica si el empleado es jubilado, basándose en la edad (mayor o igual a 65 años). Retorna un booleano.
- generaDNI(): Genera un número aleatorio de 8 cifras como DNI. Este método se invoca automáticamente al instanciar el objeto y no es visible desde el exterior.
- Propiedad set para cada atributo, excepto para DNI.

Crear un programa que realice lo siguiente:
- Solicitar al usuario el nombre, edad, departamento y salario por teclado.
- Crear tres objetos de la clase Empleado: el primero con los valores ingresados por el usuario, el segundo con nombre, edad y departamento ingresados por el usuario, y el tercero con valores por defecto, utilizando los métodos set para asignar valores a los atributos.

Para cada objeto:
- Calcular y mostrar su salario anual.
- Indicar si es jubilado.
- Mostrar la información de cada objeto.

### :soon: Ejercicio B
Crear una clase llamada "Libro" con las siguientes características:

Atributos:
- titulo: Título del libro.
- autor: Autor del libro.
- anio_publicacion: Año de publicación del libro.
- genero: Género del libro.
- paginas: Número de páginas del libro.

- No se permitirá el acceso directo a estos atributos.

Inicialización: Por defecto, todos los atributos tomarán valores por defecto según su tipo (0 para números, cadena vacía para String, etc.).

Constructores:
- Constructor por defecto: No recibe parámetros.
- Constructor con título, autor y género como parámetros. Los demás atributos se inicializan por defecto.
- Constructor con todos los atributos como parámetros.

Métodos:
- esBestSeller(): Indica si el libro es un best-seller o no, basándose en el número de páginas. Retorna un booleano, considerando que un best-seller tiene más de 300 páginas.
- calcularAntiguedad(): Calcula cuántos años han pasado desde la publicación del libro hasta el año actual.
- Propiedad set para cada atributo.

Crear un programa que realice lo siguiente:
- Solicitar al usuario el título, autor, año de publicación, género y número de páginas del libro por teclado.
- Crear tres objetos de la clase Libro: el primero con los valores ingresados por el usuario, el segundo con título, autor y género ingresados por el usuario, y el tercero con valores por defecto, utilizando los métodos set para asignar valores a los atributos.

Para cada objeto:
- Indicar si es un best-seller.
- Calcular y mostrar la antigüedad del libro.
- Mostrar la información de cada objeto.