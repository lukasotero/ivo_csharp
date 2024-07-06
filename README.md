# Recuperatorio 2 (está en la 'correcciones' -> 'Consola' -> 'correcionRecuperatorio2')
Realizar las clases necesarias.

Se tienen Vehículos con las siguientes características:
- Patente
- Marca
- PotenciaCV
- Los mismos pueden saber si es un vehículo es veloz, si la PotenciaCV es mayor a 200.

Existen vehículos con características particulares:

1. Un tipo de Vehículo son los Taxi, que además de las características mencionadas anteriormente se le agrega un número de licencia, un valor de bajada de bandera y un precio por km.
Además, los taxis pueden calcular el valor de un viaje basado en la cantidad de km que corresponda + la bajada de bandera correspondiente.


2. Otro tipo de vehículo son los Colectivos, que además de las características mencionadas anteriormente se le agrega la cantidad de pasajeros que puede llevar, el número de línea y la cantidad de paradas que tiene su recorrido.
Los colectivos pueden informar el valor del viaje basados en la cantidad de paradas que tengan que hacer, teniendo un valor de $75 por cada parada recorrida.

3. Implementar Propiedades y ToString en todas las clases.

4. Todos los objetos deben inicializarse con todos sus parámetros.

Realizar un programa que permita probar todos los métodos de los objetos propuestos

# Windows Form
## :soon: Ejercicio 1.1 (está en la clase 9)
Realizar las siguientes modificaciones al formulario de la Actividad 1:

- El botón de submit deberá estar inhabilitado hasta que todos los campos sean correctos.
- El campo Password deberá validar además que la contraseña sea fuerte, hasta que no se cumpla no debería habilitar el campo para repetir la contraseña.
- El campo FullName deberán ser solo letras y espacios.
- Los campos se validarán al quitar del foco del mismo. Se podrán agregar otros eventos para mejorar la funcionalidad.
- El campo usuario deberá ser TODO minúscula.
- El botón Submit deberá abrir un formulario nuevo, cerrando el anterior.
- Para marcar los errores no se mostrará un MsgBox, sino que se deberá informar sobre el campo del formulario de alguna forma.

## :heavy_check_mark: Ejercicio 1 (está en la clase 8)
Realizar un formulario como el de la imagen de ejemplo, teniendo en cuenta las siguientes restricciones de uso:

- Todos los campos deben iniciar vacios.
- Se debe poder desplazarse por los campos a completar en orden con la tecla TAB del teclado.
- El campo de email debe validar que sea una dirección de correo válida al presionar el botón submit, caso contrario desplegar un MessageBox que indique que el campo no es válido.
- Los campos de contraseña deben ser "ocultos" en sus caracteres.
- Ambos campos de contraseña deben coincidir, caso contrario desplegar un MessageBox que indique que no coinciden las contraseñas.
- Si todos los campos están completos y válidos, informar mediante un MessageBox que todo está OK sino informar que faltan campos a completar.

# Consola
## :heavy_check_mark: Ejercicio 8 (está en la clase 7)
Nos piden realizar una agenda telefónica de contactos.
Un contacto está definido por un nombre y un teléfono. Un contacto es igual a otro cuando sus nombres son iguales.
Una agenda de contactos está formada por un conjunto de contactos.
Se podrá crear de dos formas, indicándoles nosotros el tamaño o con un tamaño por defecto (10).

Los métodos de la agenda serán los siguientes:
- añadirContacto(Contacto c): Añade un contacto a la agenda, sino se pueden agregar más a la agenda se indicará por pantalla. No se pueden agregar contactos que existan, es decir, no podemos duplicar nombres, aunque tengan distinto teléfono.
- existeContacto(Contacto c): indica si el contacto pasado existe o no.
- listarContactos(): Lista toda la agenda.
- buscaContacto(String nombre): busca un contacto por su nombre y muestra su teléfono.
- eliminarContacto(Contacto c): elimina el contacto de la agenda, indica si se ha eliminado o no por pantalla.
- agendaLlena(): indica si la agenda está llena.
- huecosLibres(): indica cuantos contactos más podemos meter.

Crear un menú con opciones en el programa principal para probar todas estas funcionalidades.

Ejemplo:
- "1. Añadir contacto"
- "2. Listar contactos"
- "3. Buscar contacto"
- "4. Existe contacto"
- "5. Eliminar contacto"
- "6. Contactos disponibles"
- "7. Agenda llena"
- "8. Salir"

## :heavy_check_mark: Ejercicio 7 (está en la clase 7)
Realizar una clase Raices, que permitirá resolver ecuación de 2º grado.
Se tienen los 3 coeficientes como atributos (a, b y c).
El constructor deberá recibir los 3 valores para construir el objeto.

Las operaciones que se podrán hacer son las siguientes:
- obtenerRaices(): imprime las 2 posibles soluciones
- obtenerRaiz(): imprime la única raíz (única solución posible).
- getDiscriminante(): devuelve el valor del discriminante, el discriminante tiene la siguiente formula, (b^2)-4*a*c.
- tieneRaices(): devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
- tieneRaiz(): devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
- calcular(): mostrara por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
- Fórmula ecuación 2º grado: (-b±√((b^2)-(4*a*c)))/(2*a)

## :heavy_check_mark: Ejercicio 6 (está en la clase 6)
Crear una clase llamada "Serie" con las siguientes características:
- Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
Por defecto, el numero de temporadas es de 3 temporadas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.

Los constructores que se implementaran serán:
- Un constructor por defecto (sin parámetros).
- Un constructor con el titulo y creador. El resto por defecto.
- Un constructor con todos los atributos, excepto de entregado.

Los métodos que se implementara serán:
- Métodos get de todos los atributos, excepto de entregado.
- Métodos set de todos los atributos, excepto de entregado.
- Sobrescribe los métodos toString.
- Entregar(): cambia el atributo entregado a true.
- Devolver(): cambia el atributo entregado a false.
- IsEntregado(): devuelve el estado del atributo entregado.

Crear una clase "Videojuego" con las siguientes características:
- Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
Por defecto, las horas estimadas serán de 10 horas y entregado false. El resto de atributos serán valores por defecto según el tipo del atributo.

Los constructores que se implementaran serán:
- Un constructor por defecto (sin parámetros).
- Un constructor con el titulo y horas estimadas. El resto por defecto.
- Un constructor con todos los atributos, excepto de entregado.

- Los métodos que se implementara serán:
- Métodos get de todos los atributos, excepto de entregado.
- Métodos set de todos los atributos, excepto de entregado.
- Sobrescribe los métodos toString.
- Entregar(): cambia el atributo entregadoa true.
- Devolver(): cambia el atributo entregadoa false.
- IsEntregado(): devuelve el estado del atributo entregado.

Realizar lo siguiente:
- Crear dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
- Crear un objeto en cada posición del array, con valores, se pueden usar distintos constructores.
- Entregar algunos Videojuegos y Series con el método entregar().
- Contar e informar cuantas Series y Videojuegos hay entregados.
- Indicar el Videojuego tiene más horas estimadas y la serie con más temporadas. Mostrarlos en pantalla con toda su información (usar el método toString()).

## :heavy_check_mark: Ejercicio 5.1 (está en la clase 5)
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
| A	| $100 |
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

## :heavy_check_mark: Ejercicio 5 (está en la clase 4)
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

## :heavy_check_mark: Ejercicio 4 (está en la clase 3)
Crear una clase llamada "Fecha" con las siguientes características:
- Sus atributos son dia, mes y año.
- Crear un constructor con todos sus atributos como parámetro.

Los métodos que implementa serán:
- Propiedades get públicas para todos sus atributos.
- Propiedades set privadas para todos sus atributos, donde se deberá validar cada uno de los valores (al menos día y mes).
- En caso de no cumplir los valores, los mismos deberán ponerse en '1'.
- Método ToString() que permita visualizar el objeto con el siguiente formato: "mes/dia/año"

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

## :heavy_check_mark: Ejercicio 1 (está en la clase 2)
Crea una clase llamada "Cuenta" que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
Crear un constructor con ambos atributos.
Crea sus propiedades get, set y el método ToString.

Tendrá dos métodos:
- Ingresar(float cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
- Retirar(float cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
- 
## :heavy_check_mark: Ejercicio 0 (está en la clase 1)
Realizar un programa que dada una clase "Cuenta", cuyo atributo es el saldo de la misma permita 'Acreditar' saldo sobre la misma.
- El valor que se acredita no puede ser menor que 0.
- Debe incluir un método constructor que permita inicializar el valor inicial del saldo.
- Crear los objetos necesarios para realizar las pruebas con los llamados a los métodos correspondientes