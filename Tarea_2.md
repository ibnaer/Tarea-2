
# Programación orientada a objetos

## Tarea 2

***

### Ibarra Navarro Erick | 18212200

#### Declaración de clases: atributos, métodos, encapsulamiento

 Cada una de ellas es básicamente una estructura de datos que ***encapsula*** un conjunto de datos y comportamientos que forman un conjunto como una unidad lógica.

 Una declaración de clase o estructura es como un plano que se utiliza para crear instancias u objetos en tiempo de ejecución. Si define una clase o estructura llamada **Person**, **Person** es el nombre del tipo. Si declara e inicializa una ***variable p*** de tipo **Person**, se dice que *p* es un ***objeto o instancia de Person***.

```c#
Class Person //Clase Persona
    {
        string p; //Atributo *P* de Clase Persona
    }
```

 Se pueden crear varias instancias del mismo tipo Person, y cada instancia tiene diferentes valores en sus propiedades y campos. ***Una clase es un tipo de referencia.***

 -**Encapsulamiento:**

 Se refiere a que tanto se puede acceder a sus miembros para codificar fuera de la clase o la estructura.

 -**Método:**

 Los métodos se declaran en una clase o struct especificando el nivel de acceso. Los parámetros de método se encierran entre paréntesis y se separan por comas. Los paréntesis vacíos indican que el método no requiere parámetros. Esta clase contiene cuatro métodos:

```c#
abstract class Motocicleta
{
 // Quien sea puede llamar a este método
 public void Encender_Motor()
 { /* Declaraciones de método aquí */}

// Solo clases derivadas pueden llamar a este método
 protected void AñadirCombustible(int litros)
 { /* Declaraciones de método aquí */}

 // Clases derivadas pueden anular la implementación de la clase base
public virtual int Manejo(int Kilómetros, int Velocidad) 
{ /* Declaraciones de método aquí */ return 1; }

 // Clases derivadas deberían implementar esto
public abstract double GetVelocidadMax(;
}
```

 ***

#### Instanciación de una clase

Se usa para crear objetos e invocar constructores.

```c#
    Class1 obj  = new Class1();
```

También se usa para crear instancias de tipos anónimos:

```c#
    var query = from cust in customers
            select new { Name = cust.Name, Address = cust.PrimaryAddress };
```

El operador new también se usa para invocar el constructor predeterminado para tipos de valor. Por ejemplo:

```c#
int i = new int();
```

***

#### Referencia al objeto actual

 La palabra clave this hace referencia a la instancia actual de la clase.

 **Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.**

 ```c#
 class Fracción
    {
        private int num;
        private int dem;

        public fracción(int num, int dem)
        {
            this.num = num; this.dem = dem;
        }

        public fracción()
        {
            num = 1;
            dem = 1;
        }
 ```

 **Escribe un programa donde se utilice this como parámetro.**

***

#### Métodos: declaración, mensajes, paso de parámetros, retorno de valores

Los `parámetros` declarados para un método `sin in, ref` o `out` se pasan al método llamado por valor. Ese valor se puede cambiar en el método, pero el cambio se perderá cuando se devuelva el control al procedimiento que ha realizado la llamada. 

***Si usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.***

Esta sección describe las palabras clave que puede usar para declarar parámetros de métodos:

**params** especifica que este parámetro puede tomar un `número variable` de argumentos. *(Puede enviar una lista separada por comas de argumentos del tipo especificado en la declaración de parámetro o una matriz de argumentos del tipo especificado. También puede no enviar ningún argumento. Si no envía ningún argumento, la longitud de la lista params es cero.)*

**in** especifica que este parámetro se pasa por referencia, pero solo se lee mediante el método llamado.

**ref** especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.

|Se usa|
|------|
|En una firma del método y en una llamada al método, para pasar un argumento a un método mediante referencia.
|En una firma del método, para devolver un valor al autor de la llamada mediante referencia|
|En un cuerpo de miembro, para indicar que un valor devuelto de referencia se almacena localmente como una referencia que el autor de la llamada pretende modificar o, en general, que una variable local accede a otro valor por referencia.|
|En una declaración *struct* para declarar ***ref struct*** o ***ref readonly struct***. |
||

**out** especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.

|Puede ser usado|
|----|
|Como un modificador de parámetro, que le permite pasar un argumento a un método mediante una referencia en lugar de mediante un valor.
En declaraciones de parámetro de tipo genérico para interfaces y delegados, que especifica que un parámetro de tipo es covariante.|
||

#### Constructores y destructores: declaración, uso y aplicaciones

Los **constructores** son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. Los constructores tienen el mismo nombre que la clase y, normalmente, inicializan los miembros de datos del nuevo objeto.

```c#
class Fraccion
    {
        private int num;
        private int dem;

        public Fraccion(int num, int dem)
        {
            this.num = num; this.dem = dem;
        }
````

***Un constructor que no toma ningún parámetro se denomina constructor predeterminado.***

```c#
class CoOrds
{
    public int x, y;

    // constructor
    public CoOrds()
    {
        x = 0;
        y = 0;
    }
}
````

#### Sobrecarga de métodos

Es cuando se tiene dos métodos de nombres iguales, sin embargo estos piden parámetros diferentes. El compilador decide qué método invocar comparando los argumentos.

Sea el caso:

```c#
class Program
    {
        public int Sumar(int x1, int x2)
        {
            int s = x1 + x2;
            return s;
        }

        public string Sumar(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("La suma de 5+10 es:" + p.Sumar(5, 10));
            Console.WriteLine("La concatenacion de \"Juan\" y \" Carlos\" es "+p.Sumar("Juan"," Carlos"));
            Console.ReadKey();
        }
    }
```

#### Retorno de Valores

Los valores devueltos de referencia (o valores devueltos de tipo ref) son valores que devuelve un método mediante referencia al autor de la llamada. Es decir, el autor de la llamada puede modificar el valor devuelto por un método, y ese cambio se refleja en el estado del objeto que contiene el método.

Un valor devuelto de referencia se define mediante la palabra clave **ref**

En la firma del método. Por ejemplo, en la firma de método siguiente se indica que el método `GetCurrentPrice` devuelve un valor Decimal por referencia.

```C#
public ref decimal GetCurrentPrice()
```

***

#### Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios