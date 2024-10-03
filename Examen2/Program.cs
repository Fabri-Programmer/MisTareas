// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;


/*Hola("ricardo");
Otro(15,15); // parametros 


Console.WriteLine(hola(1,2,2));
Console.WriteLine(antonio1(5,10 ));
Console.WriteLine(antonio1(5,10 ));




static int hola(int numer1, int numer2, int f2)
{
    return (numer1 + numer2) * f2;
}


static double antonio1(double f1, double f2)
{
    return f1 / f2;
}

//SEMANA 1!// .. 

//1-

//Console.WriteLine("BIENVENIDO  AL CURSO  DE FUNDAMENTOS  DE ALGORITMOS");

//2-

/*
Console.WriteLine("FABRIZZIO JAIR");
Console.WriteLine("\nLLARA CAMPANO"); */

//3-

//Console.WriteLine("\nFabrizzio jair llara campano"+ "\n20 años "+ "\nIng.sistemas");

//4-

//Console.WriteLine("\"Fabrizzio\"");    //OJO

//5-

//Console.WriteLine("\"\"\"Fabri\"\"\""); //OJO

//6-

/*string text;
Console.Write("\nCual es tu nombre = ");
text = Console.ReadLine();
Console.WriteLine($"\nHola {text}");
Console.WriteLine("BIENVENIDO CRACK "); */

//7-

/*
int ingresar , ingresar2;
Console.Write("ingresa un numero entero = ");
ingresar=int.Parse(Console.ReadLine());
Console.Write("ingresa un numero entero = ");
ingresar2 = int.Parse(Console.ReadLine());
Console.WriteLine($"\n{ingresar},{ingresar2}"); */   //OJO

//8-

/*int r;
double r1;
Console.Write("ingresa un numero entero = ");
r = int.Parse(Console.ReadLine());
Console.Write("ingresa un numero con decimal = ");
r1 = double.Parse(Console.ReadLine());
Console.WriteLine($"\n\n{r},{r1}");*/

//9-

/*
string r1, r2, r3;
Console.Write("CUAL ES TU NOMBRE = ");
r1 = Console.ReadLine();
Console.Write("CUANTOS AÑOS TIENES = ");
r2 = Console.ReadLine();
Console.Write("QUE CARRERA ESTAS CURSANDO = ");
r3 = Console.ReadLine();
Console.WriteLine($"Tu nombre es {r1}, Tienes la edad de {r2} y En la carrera que estas es {r3}"); */

//10-

/*string r1, r2;
int f1, f2;
double l1, l2;
Console.Write("Cual es tu nombre = ");
r1 = Console.ReadLine();
Console.Write("Cual es tu nombre = ");
r2 = Console.ReadLine();
Console.Write("Dime un numero entero = ");
f1 = int.Parse(Console.ReadLine());
Console.Write("Dime un numero entero = ");
f2=int.Parse(Console.ReadLine());
Console.Write("Dime un numero decimal = ");
l1=double.Parse(Console.ReadLine());
Console.Write("Dime un numero decimal = ");
l2=double.Parse(Console.ReadLine());
Console.WriteLine($"\"{r1}\","+$"\"{r2}\","+$"\"{f1}\","+ $"\"{f2}\","+$"\"{l1}\","+$"\"{l2}\"");*/                        //OJO


//SEMANA 2..

//1-

/*int r1, r2, total;
Console.Write("Dime un numero entero = ");
r1 = int.Parse(Console.ReadLine());
Console.Write("Dime un numero entero = ");
r2= int.Parse(Console.ReadLine());
total = r1 + r2;
Console.WriteLine($"\nEl total es = {total}");*/

//2-

/*int x, y, tot;
Console.Write("Ingresa un numero = ");
x=int.Parse(Console.ReadLine());
Console.Write("Ingresa un numero = ");
y=int.Parse(Console.ReadLine());
tot = (x + y) * (x - y);
Console.WriteLine($"\nEl total es = {tot}"); */

//3-

/*
double r, total=0;
Console.Write("Cuantos soles tienes  = ");
r=double.Parse(Console.ReadLine());
total = r * 0.26;
Console.WriteLine($"\nEste es tu conversion de soles a dolares = $/ {total}");*/

//4-

/*double sueld, t1, t2, t3, suma;
Console.Write("Ingresa tu sueldo = ");
sueld = double.Parse(Console.ReadLine());
t1 = sueld - (sueld * 0.05) - 25;
t2 = sueld + (sueld * 0.23) + 72;
t3 = sueld + (sueld * 0.05) - 56;
suma = t1 + t2 + t3;
Console.WriteLine($"\tSUELDO DE MARIA = {t1} ");
Console.WriteLine($"\tSUELDO DE JUAN = {t2} ");
Console.WriteLine($"\tSUELDO DE PATRICIO = {t3} ");
Console.WriteLine($"\nSUMA DE TODOS LOS SUELDOS = {suma} ");*/

//5-

/*double r;
Console.Write("ingresa tu edad = ");
r=double.Parse(Console.ReadLine());
if (r < 18)
{
    Console.WriteLine("\nEres menor de edad ");
}
else
{
    Console.WriteLine("\nEres mayor ");
}*/

//6-

/*int r, suma, resta;
Console.Write("Ingresa un numero entero = ");
r = int.Parse(Console.ReadLine());
if (r > 0)
{
    suma = r * 2;
    Console.WriteLine($"Numero positivo = " + suma);
}
else
{
    resta = r + 5;
    Console.WriteLine($"Numero Negativo = " + resta);
}
*/

//7-

/*int r;
Console.Write("Ingresa un numero entero = ");
r=int.Parse(Console.ReadLine());
if(r >=10 && r <= 50)
{
    Console.WriteLine("\nSi Estas en el rango");
}
else
{
    Console.WriteLine("\n No estas en el rango");
}*/

//8-

/*int r;
Console.Write("Ingresa un numero entero = ");
r=int.Parse(Console.ReadLine());
if(r % 3 == 0)
{
    Console.WriteLine("\nSi es multiplo de 3");
}
else if(r % 5 == 0)
{
    Console.WriteLine("\nSi es multiplo de 5");
}
else
{
    Console.WriteLine("\nNo es multiplo ni de 5 ni de 3");
}*/

//9-

/*int r;
Console.Write("Ingresa un numero entero = ");
r = int.Parse(Console.ReadLine());
if (r % 2 == 0)
{
    Console.WriteLine("\nSi es par ");
}
else
{
    Console.WriteLine("\nNo es par ");
}*/

//10-

/*int r;
Console.Write("Ingrese un año = ");
r=int.Parse(Console.ReadLine());
if (r % 4 == 0)
{
    Console.WriteLine("Es un año bisiesto");
}
else if (r % 100 == 0)
{
    Console.WriteLine("No es bisiesto");
}
else
{
    Console.WriteLine("No es bisiesto !! ");
}*/

//SEMANA 3..

//1-

/*int r, r1;
Console.Write("Ingresa un numero (1) = ");
r = int.Parse(Console.ReadLine());
Console.Write("Ingresa un numero (2) = ");
r1 = int.Parse(Console.ReadLine());
if (r > r1)
{
    Console.WriteLine("\nEs el numero mayor (1) ");
}
else if (r1 > r)
{
    Console.WriteLine("\nEs el numero mayor (2) ");
}
else
{
    Console.WriteLine("\nSon iguales"); 
}*/

//2-

/*string text;
Console.Write("Ingresa un dia de la semana = ");
text = Console.ReadLine();
if (text == "Lunes")
{
    Console.WriteLine("\n\"DIA DE SEMANA\"");
}
else if (text == "Martes")
{
    Console.WriteLine("\n\"DIA DE SEMANA\"");
}
else if (text == "Miercoles")
{
    Console.WriteLine("\n\"DIA DE SEMANA\"");
}
else if (text == "Juevez")
{
    Console.WriteLine("\n\"DIA DE SEMANA\"");
}
else if (text == "Viernes")
{
    Console.WriteLine("\n\"DIA DE SEMANA\"");
}
else if(text == "Sabado") 
{
    Console.WriteLine("\n\"FIN DE SEMANA\"");
}
else if (text== "Domingo")
{
    Console.WriteLine("\n\"FIN DE SEMANA\"");
}
else
{
    Console.WriteLine("\n\"DIA INCORRECTO\"");
}*/

//3-

/*int r;
Console.Write("Ingresa tu edad = ");
r = int.Parse(Console.ReadLine());
if (r >= 18 && r <=24)
{
    Console.WriteLine("\nEres acto para votar");
}
else if (r >= 25)
{
    Console.WriteLine("\nEres acto para ser candidato politico");
}
else
{
    Console.WriteLine("\nEres menor para votar");
}*/

//4-

/*double r;
Console.Write("Ingresar un sueldo = ");
r = double.Parse(Console.ReadLine());
if (r > 0)
{
    if(r>=0 && r <= 900)
    {
        Console.WriteLine("\nSueldo menor");
    }
    else if(r>900 && r <= 1250)
    {
        Console.WriteLine("\nSueldo Basico");
    }
    else if(r>1250 && r <= 1500)
    {
        Console.WriteLine("\nSueldo regular");
    }
    else if(r>1500 && r <= 2500)
    {
        Console.WriteLine("\nSueldo Bueno");
    }
    else
    {
        Console.WriteLine("\nSueldo excelente");
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nSueldo incorrecto");
}*/

//5-

/*int r, r1, r2;
Console.Write("Ingresa un numero entero = ");
r=int.Parse(Console.ReadLine());
Console.Write("Ingresa un numero entero = ");
r1=int.Parse(Console.ReadLine());
Console.Write("Ingresa un numero entero = ");
r2=int.Parse(Console.ReadLine());
if (r == r1 && r == r2)
{
    Console.WriteLine("\nTRIANGULO EQUILATERO");
}
else if (r1 == r2 && r1 == r) 
{
    Console.WriteLine("\nTRIANGULO EQUILATERO");
}
else if (r == r1 && r != r2)
{
    Console.WriteLine("\nTRIANGULO ISOSCELES");
}
else if (r2 == r1 && r2 != r)
{
    Console.WriteLine("\nTRIANGULO ISOCELES");
}
else
{
    Console.WriteLine("\nTRIANGULO ESCALENO");
}*/

//6-

/*string r;
Console.Write("Ingresa un numero 1 - 7 = ");
r = Console.ReadLine();
if(r == "1")
{
    Console.WriteLine("\n\"Lunes\"");
}
else if(r =="2")
{
    Console.WriteLine("\n\"Martes\"");
}
else if (r == "3")
{
    Console.WriteLine("\n\"Miercoles\"");
}
else if (r == "4")
{
    Console.WriteLine("\n\"Juevez\"");
}
else if(r == "5")
{
    Console.WriteLine("\n\"Viernes\"");
}
else if (r == "6")
{
    Console.WriteLine("\n\"Sabado\"");
}
else if (r == "7")
{
    Console.WriteLine("\n\"Domingo\"");
}
else
{
    Console.WriteLine("\n\"Dia de la semana incorrecto\"");
}*/

//7-

/*int r1, r2, r3, Suma = 0, Resta, Multi, Divi;
Console.Write("Ingresa un numero = ");
r1=int.Parse(Console.ReadLine());
Console.Write("Ingresa un numero = ");
r2=int.Parse(Console.ReadLine());
Console.WriteLine("\tSUMA (1) ");
Console.WriteLine("\tRESTA (2) ");
Console.WriteLine("\tMULTIPLICACION (3) ");
Console.WriteLine("\tDIVISION (4) ");
Console.Write("\tQue Operacion haras = ");
r3=int.Parse(Console.ReadLine());
if (r3 == 1)
{
    Suma = r1 + r2;
    Console.WriteLine("\nEsta es la suma = " + Suma);
}
else if(r3 == 2)
{
    Resta = r1 - r2;
    Console.WriteLine("\nEsta es la resta = " + Resta);
}
else if (r3 == 3)
{
    Multi = r1 * r2;
    Console.WriteLine("\nEsta es la multiplicacion = " + Multi);
}
else if(r3 == 4)
{
    if(r1 != 0 && r2 != 0)
    {
        Divi = r1 / r2;
        Console.WriteLine("\nEsta sera la division = " + Divi);
    }
    else
    {
        Console.WriteLine("\nNo se puede divir entre 0");
    }
}*/

//8-

/*double r1, r2, aCuadrado, aRectangulo, aTriangulo, aCirculo;
string r3;
Console.Write("ingresa un numero = ");
r1 = double.Parse(Console.ReadLine());
Console.WriteLine("\tCUADRADO (1) ");
Console.WriteLine("\tTRIANGULO (2) ");
Console.WriteLine("\tRECTANGULO (3) ");
Console.WriteLine("\tCIRCULO (4) ");
Console.Write("\n¿Que Area quieres hallar? = ");
r3 = Console.ReadLine();
if (r3 == "1")
{

    aCuadrado = r1 * r1;
    Console.WriteLine("\nEste es el area de un cuadrado = " + aCuadrado);
}
else if (r3 == "2")
{
    Console.Write("ingresa un numero = ");
    r2 = double.Parse(Console.ReadLine());
    aTriangulo = (r1 * r2) / 2;
    Console.WriteLine("\nEste es el area de un triangulo = " +aTriangulo);
}
else if (r3 == "3")
{
    Console.Write("ingresa un numero = ");
    r2 = double.Parse(Console.ReadLine());
    aRectangulo = r1 * r2;
    Console.WriteLine("\nEste es el area de un rectangulo = " + aRectangulo);
}
else if (r3 == "4") 
{
    aCirculo = 3.1416 * (r1 * r1);
    Console.WriteLine("\nEste es el area de un circulo = " + aCirculo);
}*/

//SEMANA 4..

//1-

/*int x = 20;
for(int i=0; i<=x; i++)
{
    Console.WriteLine(i);
}*/

//2-

/*int x = 20;
for(int i = 50; i >=x; i--)
{
    Console.WriteLine(i);
}*/

//3-

/*int x = 100, suma = 0;
for(int i = 0; i <= x; i = i + 5)
{
    Console.WriteLine(i);
    suma = suma + i;
}
Console.WriteLine($"La suma es = {suma}");*/

//4-

/*int r, suma = 0;
for(int i = 1; i<=10; i++)
{
    Console.Write("Ingresa un numero = ");
    r = int.Parse(Console.ReadLine());
    suma = suma + r;
}
Console.WriteLine($"\nLa suma de los 10 numeros es = {suma}");*/

//5-

/*int r1, r2, suma = 0, promedio = 0;
Console.Write("Cuantos numeros quieres ingresar = ");
r1 = int.Parse(Console.ReadLine());
for(int i = 1; i<= r1; i++)
{
    Console.Write("Ingresa un numero = ");
    r2= int.Parse(Console.ReadLine());
    suma = suma + r2;
}
promedio = suma / r1;
Console.WriteLine($"\nLa suma de todos los numeros es = {suma}");
Console.WriteLine($"\nEl Promedio es = {promedio}");*/                        //OJOO

//6-

/* r, suma = 0;
for(int i =1; i<=10; i++)
{
    Console.Write("ingrese un numero = ");
    r = int.Parse(Console.ReadLine());
    if (i > 5)
    {
        suma = suma + r;
    }
}
Console.WriteLine("\nLa suma es = " + suma);*/                         //OJO

//7-

/*int r1, r2, cantidad = 0;
Console.Write("Cuantos numeros quieres calcular (rango) = ");
r1 = int.Parse(Console.ReadLine());
for(int i = 1; i<=r1; i++)
{
    Console.Write($"Ingresa numero {i + 0} = ");
    r2=int.Parse(Console.ReadLine());
    if (r2 >= 1000) 
    {
        cantidad++;
    }
}
Console.WriteLine("\nEsta es la cantidad de numeros mayores o iguales a 1000 = "+cantidad);*/

//8-

/*int r, cantidadN = 0, cantidadA = 0, cantidadM = 0, cantidadP = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"ingresa un numero {i + 0} = ");
    r = int.Parse(Console.ReadLine());
    if (r < 0)
    {
        cantidadN++;
    }
    if (r > 0) 
    {
        cantidadA++;
    }
    if (r % 15 == 0)
    {
        cantidadM++;
    }
    if (r % 2 == 0)
    {
        cantidadP = cantidadP + r;

    }
}
Console.WriteLine("\nEsta es la cantidad de Negativos = "+cantidadN);
Console.WriteLine("\nEsta es la cantidad de Positivos = "+cantidadA);
Console.WriteLine("\nEsta es la cantidad de Multiplos de 15 = "+cantidadM);
Console.WriteLine("\nEsta es la suma de Pares = "+cantidadP);*/

//9-

/*int r = 0, r1 = 0, r2 = 0, sumaM = 0, sumaT = 0, sumaN = 0;
for(int i =1; i<=15; i++)
{
    
    if (i >=0 && i <=3)
    {
        Console.Write("Turno mañana = ");
        r = int.Parse(Console.ReadLine());
        sumaM = sumaM + r;
    }
    else if (i > 3 && i <= 8) 
    {
        Console.Write("Turno tarde = ");
        r1 = int.Parse(Console.ReadLine());
        sumaT = sumaT + r1;
    }
    if(i>= 8 && i <15)
    {
        Console.Write("turno noche = ");
        r2 = int.Parse(Console.ReadLine());
        sumaN = sumaN + r2;
    }
}
int promedioM = 0, promedioT = 0, promedioN = 0;
promedioM = (sumaM / 3);
promedioT = (sumaT / 5);
promedioN = (sumaN/ 7);
Console.WriteLine("\nPromedios del turno Mañana = " + promedioM);
Console.WriteLine("\nPromedios del turno Tarde = " + promedioT);
Console.WriteLine("\nPromedios del turno Noche = " + promedioN);
if (promedioM < promedioT && promedioM < promedioN)
{
    Console.WriteLine("\n\"El turno mañana es el promedio mas bajo\"");
}
else if (promedioT < promedioM && promedioT < promedioN) 
{
    Console.WriteLine("\n\"El turno tarde es el promedio mas bajo\"");
}
else if(promedioN< promedioM && promedioN< promedioT)
{
    Console.WriteLine("\n\"El turno noche es el promedio mas bajo\"");
}
else
{
    Console.WriteLine("\nSon iguales");
}*/

//10-

/*int primero = 0, segundo = 1, suma = 0, r;
Console.Write("Ingresa un numero maximo = ");
r=int.Parse(Console.ReadLine());
for(int i = 0; i<r; i++)
{

    Console.WriteLine(suma);
    primero = segundo;
    segundo = suma;
    suma = primero + segundo;
    
}*/

//SEMANA 5..

//1-

/*int r = 1;
while (r <= 100)
{
    Console.WriteLine(r);
    r++;
}*/

//2-

/*int r;
Console.Write("ingresa un numero = ");
r=int.Parse(Console.ReadLine());
while (r >= 0)
{
    Console.WriteLine(r);
    r--;
}*/

//3-

/*int r = 1;
while (r != 0)
{
    Console.Write("Ingresa un numero = ");
    r=int.Parse(Console.ReadLine());
}
Console.WriteLine("\n\"Bucle termino\"");*/

//4-

/*int r ,valor = 1;
Console.Write("ingresa la tabla que deseas realizar = ");
r = int.Parse(Console.ReadLine());
while (valor<= 12)
{
    if(r > 0)
    {
        Console.WriteLine(r + "X" + valor + "=" + (r * valor));
        valor++;
    }
    else
    {
        Console.Write("ingresa la tabla que deseas realizar = ");
        r = int.Parse(Console.ReadLine());
    }
}*/

//5-

/*int r=-1, sumaP=0, sumaI=0;
while (r != 0)
{
    if (r > 0)
    {
        if (r % 2 == 0)
        {
            sumaP = sumaP + r;
        }
        else 
        {
            sumaI = sumaI + r;
        }
        Console.Write("ingresa un numero = ");
        r=int.Parse(Console.ReadLine());
    }
    else
    {
        Console.Write("ingresa un numero = ");
        r = int.Parse(Console.ReadLine());
        
    }
}
Console.WriteLine("\nLa suma de Pares es = " + sumaP);
Console.WriteLine("\nLa suma de Impares = " + sumaI);*/

//6-


/*int valor = 0, filas, columnas;
Console.Write("ingresa filas = ");
filas = int.Parse(Console.ReadLine());
Console.Write("ingresa columnas = ");
columnas = int.Parse(Console.ReadLine());
while(valor < filas)
{
    int valor1 = 0;
    while (valor1 < columnas)
    {
        Console.Write("*  ");
        valor1++;
    }
     
    Console.WriteLine();
    valor++;
}*/                                   //ojoooo

//7-

/*int r = 1, r1=0, suma1 = 0, total = 0;
while (r <= 10)
{
    
    Console.Write("ingrese numero Lista 1 = ");
    r1=int.Parse(Console.ReadLine());
    suma1 = suma1 + r1;
    r++;
}
int r3=0, suma2=0;
Console.WriteLine("\n***************************");
while (r <= 20)
{
    
    Console.Write("ingrese numero Lista 2 = ");
    r3=int.Parse(Console.ReadLine());
    suma2 = suma2 + r3;
    r++;
}
if (suma1 > suma2)
{
    Console.WriteLine("\n\"La lista 1 es la Mayor\"");
}
else if (suma2 > suma1)
{
    Console.WriteLine("\n\"La Lista 2 es la Mayor\"");
}
else
{
    Console.WriteLine("\n\"Son iguales\"");
}*/

//10-

/*int contraseña, contador, intentos;
contraseña = 15;
contador = 0;
while(contador <= 2)
{
    Console.Write("ingresar tu contraseña = ");
    intentos=int.Parse(Console.ReadLine());
    if(contraseña == intentos)
    {
        Console.WriteLine("Muy bien");
        break;
    }
    else
    {
        Console.WriteLine("La clave esta mal ingresada");
        contador++;
    }
}
Console.WriteLine("termino");*/

//SEMANA 6

//1- 

/*int r;
do
{
    Console.Write("ingrese un numero = ");
    r=int.Parse(Console.ReadLine());
} while (r>=0);*/

//2-

/*int r, suma = 0;
do
{
    Console.Write("Ingrese numero ,[0] para finalizar = ");
    r = int.Parse(Console.ReadLine());
    if (r > 0)
    {
        suma = suma + r;
    }

} while (r!=0);
Console.WriteLine($"La suma es = {suma}");*/

//3-

/*int r, Cpares=0, Cimpares=0;
do
{
    Console.Write("Ingresa numero , [-1] para finalizar = ");
    r=int.Parse(Console.ReadLine());
    if (r > 0)
    {
        if (r % 2 == 0)
        {
            Cpares++;
        }
        else
        {
            Cimpares++;
        }
        
    }
  
} while (r>=0);
Console.WriteLine("Cantidad de pares = " + Cpares);
Console.WriteLine("Cantidad de impares = " + Cimpares);*/

//4-

/*int r, cant1=0,cant2=0,cant3=0;
do
{
    Console.Write("ingrese numeros positivos , [0] para finalizar = ");
    r=int.Parse(Console.ReadLine());
    if (r > 0)
    {

        if (r < 15)
        {
            cant1++;
        }
        if (r > 50)
        {
            cant2++;
        }
        if (r > 25 && r < 45)
        {
            cant3++;
        }
    }
    
    

} while (r!=0);
Console.WriteLine("\nLa cantidad de numeros menores de 15 es = " +cant1);
Console.WriteLine("\nLa cantidad de numeros mayores de 50 es = " +cant2);
Console.WriteLine("\nLa cantidad de numeros mayor a 25 y menor a 45 es = " +cant3);*/

//5-

/*Random aletorio = new Random();
int numero, r, cantidad = 0;
numero = aletorio.Next(1, 21);
Console.WriteLine(numero);
do
{
    Console.Write("ingresa un numero = ");
    r = int.Parse(Console.ReadLine());
    if (cantidad < 2)
    {
        if (cantidad >= 0)
        {
            
            if(r > numero)
            {
                Console.WriteLine("sigue intentando");
                Console.WriteLine("\nun numero menor te recomiendo ");
            }
            if (r < numero) 
            {
                Console.WriteLine("sigue intentando");
                Console.WriteLine("\nun numero mayor te recomiendo ");
            }
           
            
        }
        cantidad++;




    }
    else
    {
        if (r != numero)
        {
            Console.WriteLine("\nperdiste");
            break;
        }
        
    }

} while (r != numero);
if (r == numero)
{
    Console.WriteLine("\nganaste");
}*/

//6-

/*string n = "no";
do
{
    Console.Write("Quieres ingresar (si) o (no) = ");
    n = Console.ReadLine();
    if (n == "si")
    {
        int r, suma = 0;
        do
        {
            Console.Write("ingresa numero = ");
            r = int.Parse(Console.ReadLine());
            while (r >= 0)
            {
                suma = suma + r;
                r--;
            }
            Console.WriteLine(suma);
            
        } while (r>=0);
        



    }
   
} while (n != "no");
Console.WriteLine("finalizo"); */

//que el usuario ingrese cuantas notas quieras y no tenga un limite , pero cuando el quiera finalizar que presiona una letra

/*string r = "si";
int r1=0;
do
{
    Console.Write("¿Quieres ingresar (SI) O (NO) ? = ");
    r = Console.ReadLine();
    if (r == "si")
    {
     Console.Write("Ingresa un numero = ");
     r1=int.Parse(Console.ReadLine());
    }

} while (r!="no");*/







/*int primero = 0, segundo = 1, suma = 0, r;
Console.Write("Ingresa un numero maximo = ");
r=int.Parse(Console.ReadLine());
for(int i = 0; i<r; i++)
{

    Console.WriteLine(suma);
    primero = segundo;
    segundo = suma;
    suma = primero + segundo;
    
}*/

//SEMANA 7 

//1-


/*char r;
Console.WriteLine("Ingresa una letra de [A] HASTA [Z] = ");
r=char.Parse(Console.ReadLine());
for(char i = r; i <= 'Z'; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(i);
}

Console.WriteLine();
for(char i = 'Z'; i >= 'A'; i--)
{

    Console.WriteLine(i);
}
*/

//2-

/*double salario=0, DesISS=0, Opn=0, Afp=0, Renta=0;
string AfpOnp;
Console.Write("Ingresa tu sueldo = ");
salario=double.Parse(Console.ReadLine());
if(salario >= 0)
{


  if (salario <= 3000)
  {
    DesISS = salario - (salario * 0.090);
    Renta = salario - (salario * 0.10);
    Console.Write("¿Eres del afp o onp? = ");
    AfpOnp = Console.ReadLine();
    if (AfpOnp == "onp")
    {
        Opn = salario - (salario * 0.080);
            Console.WriteLine();
            Console.WriteLine("Descuento con Onp $/ = " + (Opn - salario));
            Console.WriteLine("Descuento con renta $/ = " + (Renta - salario));
            Console.WriteLine("Descuento con ISSS $/ = " + (DesISS - salario));
            Console.WriteLine("\ntotal  $/ = " + (salario-Renta+salario - DesISS+salario-Opn-salario)*-1);

        }
        else if(AfpOnp == "afp")
    {
        Afp = salario - (salario * 0.070);
            Console.WriteLine();
            Console.WriteLine("Descuento con Afp $/ = " + (Afp - salario));
            Console.WriteLine("Descuento con renta $/ = " + (Renta - salario));
            Console.WriteLine("Descuento con ISSS $/ = " + (DesISS - salario));
            Console.WriteLine("\ntotal $/ = "+(salario - Renta + salario - DesISS + salario - Afp - salario) * -1);

        }
    }
   else if(salario > 3000)
   {

    DesISS = salario - (salario * 0.090);
    Renta = salario - (salario * 0.12);
    Console.Write("¿Eres del Afp o Onp? = ");
    AfpOnp = Console.ReadLine();
    if (AfpOnp == "onp")
    {
        Opn = salario - (salario * 0.090);
            Console.WriteLine();
            Console.WriteLine("Descuento con Onp $/ = " + (Opn - salario));
            Console.WriteLine("Descuento con renta $/ = " + (Renta - salario));
            Console.WriteLine("Descuento con ISSS $/ = " + (DesISS - salario));
            Console.WriteLine("\ntotal $/ = " + (salario - Renta + salario - DesISS + salario - Opn - salario) * -1);

        }
        else if(AfpOnp == "afp")
    {
        Afp = salario - (salario * 0.10);
            Console.WriteLine();
        Console.WriteLine("Descuento con Afp $/ = " + (Afp - salario));
            Console.WriteLine("Descuento con renta $/ = " + (Renta - salario));
            Console.WriteLine("Descuento con ISSS $/ = " + (DesISS - salario));
            Console.WriteLine("\ntotal $/ = " + (salario - Renta + salario - DesISS + salario - Afp - salario) * -1);
        }
    

   }
}
else
{
    Console.WriteLine("ERROR");
} */

//3-

/*double x, total = 0, f;
do
{
    Console.Write("\nIngresa un valor de X = ");
    x = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("******OPCION (1)******");
    Console.WriteLine("******OPCION (2)******");
    Console.WriteLine("******OPCION (3)******");
    Console.WriteLine("******OPCION (4)******");
    Console.WriteLine("******OPCION PARA VOLVER INGRESAR (5) o (0)******");
    Console.Write("\n\"Ingresa una opcion  \" = ");
    f = double.Parse(Console.ReadLine());
    if (f == 1)
    {
        total = Math.Round(3 * Math.Pow(x, 3) - Math.Pow(x, 1 / 3d) + 4 * Math.Pow(x, 2), 2);
        Console.WriteLine("TOTAL = " + total);
    }
    if (f == 2)
    {
        total = Math.Round((4 * Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 2 * x - 5),2);
        Console.WriteLine("TOTAL = " + total);
    }
    if (f == 3)
    {
        total = Math.Round((5 * Math.Pow(x, 1 / 3d) + 4 * Math.Pow(x, 2) + 6),2);
        Console.WriteLine("TOTAL = " + total);
    }
    if (f == 4)
    {
        total = Math.Round((-8 * Math.Pow(Math.Pow(x, 2), 1 / 5d) - 3 * Math.Pow(x, 3) + 6 * Math.Pow(x, 2) - 7),2);
        Console.WriteLine("TOTAL = " + total);
    }



} while (f >= 5 || f <= 0);*/

//4-

/*int r1, r2, suma, resta;
string r, p;
do
{

    Console.Write("Quieres realizar un calculo (si) o (no) = ");
    r = Console.ReadLine();
    if (r == "si")
    {
        Console.Write("¿suma o resta? = ");
        p= Console.ReadLine();
        if(p == "suma")
        {
            Console.Write("Ingresar un numero = ");
            r1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar un numero = ");
            r2 = int.Parse(Console.ReadLine());
            suma = r1 + r2;
            Console.WriteLine("\nLa suma es = " + suma);

        }
        if(p == "resta")
        {
            Console.Write("Ingresar un numero = ");
            r1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar un numero = ");
            r2 = int.Parse(Console.ReadLine());
            resta = r1 - r2;
            Console.WriteLine("\nLa resta es = " + resta);
        }
        
    }
    


} while (r!="no");
Console.WriteLine();
Console.WriteLine("Gracias por participar !!! ... "); */


//5-

/*string hola = string.Empty;
Console.Write("ingresa un texto = ");
hola = Console.ReadLine();
for(int i = hola.Length -1; i >= 0; i--)
{

 hola += hola.Substring(i, 1);
    
}
Console.WriteLine(hola);*/



//Semana 8 

//1-








//6-



/*int  piedra1 = 2, papel2 = 3, tijera3 = 4;
string  opciones, r;
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Quieres ingresar al juego (si) o (no) = ");
    r = Console.ReadLine();
    if (r == "si")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Elige una opcion !! (piedra) ,(papel) o (tijera) = ");
        opciones = Console.ReadLine();
        if (opciones == "piedra")
        {
            Random aletario = new Random();
            int numero = aletario.Next(1, 4);
            
            if (piedra1 == numero)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEmpate");
                Console.WriteLine($"\nla computadora eligio Piedra");
                Console.WriteLine();
            }
            else if (piedra1 < numero)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nComputadora gano");
                Console.WriteLine($"\nla computadora eligio Papel");
                Console.WriteLine();
            }
            else if (piedra1 > numero)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nJugador 1 gano, eligio Piedra");
                Console.WriteLine($"\nla computadora eligio tijera");
                Console.WriteLine();
            }
        }
        if (opciones == "papel")
        {
            Random aletario = new Random();
            int numero1 = aletario.Next(1, 4);
            
            if (papel2 == numero1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEmpate");
                Console.WriteLine($"\nla computadora eligio Papel");
                Console.WriteLine();
            }
            else if (papel2 < numero1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nComputadora gano");
                Console.WriteLine($"\nla computadora eligio  tijera");
                Console.WriteLine();
            }
            else if (papel2 > numero1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nJugador 1 gano, eligio Papel");
                Console.WriteLine($"\nla computadora eligio {numero1} = Piedra");
                Console.WriteLine();
            }
        }
        if (opciones == "tijera")
        {

            Random aletario = new Random();
            int numero2 = aletario.Next(1, 4);
            
            if (tijera3 == numero2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEmpate");
                Console.WriteLine($"\nla computadora eligio Tijera");
                Console.WriteLine();
            }
            else if (tijera3 < numero2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nComputadora gano");
                Console.WriteLine($"\nla computadora eligio Piedra");
                Console.WriteLine();
            }
            else if (tijera3 > numero2)
            {
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("\nJugador 1 gano, eligio Tijera");
                Console.WriteLine($"\nla computadora eligio papel");
                Console.WriteLine();
            }
        }


    }
    if (r == "no")
    {
        Console.WriteLine();
        Console.WriteLine("Hasta luego... ");
        break;
    }
    
} while (r=="si");*/

//Semana 8 -

/*static void tarea2()
{
    int tarea1 = 2;
    Console.WriteLine(tarea1);  // void sin parametro
    
}
tarea2();
static void tarea3(int tarea3 = 3)
{
    Console.WriteLine(tarea3); // void con parametro
}
tarea3();
static int tarea4()
{
    int f1 = 1, f2 = 2;
    int fabri = f1 + f2;        //retorno sin parametro
    return fabri;
    
}

Console.WriteLine(tarea4());

static int tarea5(int tarea = 5)
{
    return tarea;   // retorno con parametro
}
Console.WriteLine(tarea5()); */


//1 -

/*static void primero(int num1 =1 , int num2 = 1)
{
    Console.WriteLine($"la suma es {num1} + {num2} = " + (num1 + num2));
   
}
primero();

//2 -
static int segundo(int nu1 = 2 , int nu2 = 2)
{
    
    return nu1 + nu2;
}
Console.WriteLine("El valor es = "+segundo());

//3-

static void tercero()
{
    int f1=1, f2=2;
    int fabri = f1 + f2;
    Console.WriteLine("La suma de los numeros seran = " + fabri);
}
tercero();

//4-

static int cuarto()
{
    int k1 = 2, k3 = 4;
    return k1 + k3;
}
Console.WriteLine("El valor es = "+cuarto());*/

//5-



/*static void menu(int r = 0)
{
    string a = "s";
    do
    {
       
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nQuieres ingresar (si) o (no) = ");
        a = Console.ReadLine();
        if(a == "no")
        {
            Console.WriteLine("Se finalizo , te quiero ");
            break;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Suma (1) ");
        Console.WriteLine("Resta (2) ");
        Console.WriteLine("Division (3) ");
        Console.WriteLine("Multiplicacion (4) ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\n¿Que operacion te gustaria realizar? = ");
        r = int.Parse(Console.ReadLine());

        if (r == 1)
        {


            static void p1(int f1=0 , int f2=0 )
            {

                Console.Write("Ingresa un valor = ");
                f1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa un valor = ");
                f2 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nLa suma es = " + (f1 + f2));
            }
            p1();
        }
        else if (r == 2)
        {
            static void p2(int f1 = 0, int f2 = 0)
            {

                Console.Write("Ingresa un valor = ");
                f1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa un valor = ");
                f2 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("la resta es = " + (f1 - f2));

            }
            p2();
        }
        else if (r == 3)
        {
            static void p3(int f1 = 0, int f2 = 0)
            {
                Console.Write("Ingresa un valor = ");
                f1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa un valor = ");
                f2 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La division es = " + (f1 / f2));

            }
            p3();
        }
        else if (r == 4) 
        {
        static void p4(int f1=0, int f2=0)
        {
                Console.Write("Ingresa un valor = ");
                f1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa un valor = ");
                f2 = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La multiplicacion es = "+(f1 * f2));
        }
            p4();
        }
        
    } while (a != "no") ;
}
menu();*/


/*static string menu1()
{
    string r = "s";
    int a;
    do
    {
        Console.Write("¿Quieres ingresar (si) o (no) ? = ");
        r = Console.ReadLine();
        Console.Clear();
       
        if (r == "si")
        {
            Console.WriteLine("SOLES(1)");
            Console.WriteLine("DOLARES(2)");
            Console.Write("Que operacion te gustaria realizar = ");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                static double valor()
                {
                    int f1 = 0;
                    Console.Write("Ingresa tu valor en soles para dolares = ");
                    f1 = int.Parse(Console.ReadLine());
                    return f1 * 0.27;

                }
                Console.WriteLine("este es tu cambio de soles a dolares= " + Math.Round(valor(), 2));
                
            }
            if (a == 2)
            {
                static double valor1()
                {
                    int f1 = 0;
                    Console.Write("Ingresa tu valor en soles para euros = ");
                    f1 = int.Parse(Console.ReadLine());
                    return f1 * 0.24;
                    
                }
                Console.WriteLine("Este es tu cambio de soles a euros = " + Math.Round(valor1(), 2));
                
            }

        }
        else if(r=="no")
        {
            Console.WriteLine("Gracias por estar aqui!!");
            
            break;
            
        }
        



    } while (r=="si");
    string finalizo;
    finalizo = "gracias por estar aqui";
    return finalizo;
    
}
 menu1();*/

///Practica string

/*
string texto = " Hola ";
Console.WriteLine(texto);
Console.WriteLine(texto.Length);
Console.WriteLine(texto.Trim().Length);
Console.WriteLine(texto.ToLower().Trim().Length);
Console.WriteLine(texto.ToLower());
Console.WriteLine(("b").CompareTo(("a"))); //Comparacion
Console.WriteLine(("Hola").Equals("hola", StringComparison.InvariantCultureIgnoreCase));*/



static int menu()
{
    int respuesta;
    string a;
    do
    {
        Console.Write("Quieres ingresar si o no = ");
        a = Console.ReadLine();
        if (a == "no")
        {
            break;
        }
        Console.Write("Que Calculo quieres hacer = ");
        respuesta = int.Parse(Console.ReadLine());
        if(respuesta == 1)
        {
            static void triangulo()
            {
                int peri, altura, base1, total;
                string respuesta;
                Console.Write("Ingresa (Perimetro) o (Area) = ");
                respuesta = Console.ReadLine();
                if(respuesta == "Perimetro")
                {
                    Console.Write("Ingresa el Perimetro en numero = ");
                    peri=int.Parse(Console.ReadLine());
                    total = peri + peri + peri;
                    Console.WriteLine("El valor de tu perimetro es = " + total);
                }
                if(respuesta == "Area")
                {
                    Console.Write("Ingresa la altura en numero = ");
                    altura=int.Parse(Console.ReadLine());
                    Console.Write("Ingresa la Base en numero = ");
                    base1 = int.Parse(Console.ReadLine());
                    total = base1 * altura;
                }
                
            }
            
        }
        else if(respuesta == 2)
        {
            static void cuadrado(int area, int peri, int total,string r)
            {


                Console.Write("Que calculo quieres hacer (Area) o (Perimetro) = ");
                r = Console.ReadLine();
                if (r == "Area")
                {
                    Console.Write("Ingresa el area en numero = ");
                    area = int.Parse(Console.ReadLine());
                    total = area * area;
                    Console.WriteLine("El Area del cuadrado es = " + total);
                }
                if (r == "Perimetro") 
                {
                    Console.Write("Ingresa el Perietro en numero = ");
                    peri = int.Parse(Console.ReadLine());
                    total = peri + peri + peri + peri;
                    Console.WriteLine("El Perimetro del cuadrado es = " + total);
                }
                

                
            }
        }
        else if(respuesta == 3)
        {
            static int rectangulo()
            {
                string r;
                int area, peri, total;
                Console.Write("Que calculo quieres hacer (Area) o (Perimetro) = ");
                r= Console.ReadLine();
                if (r == "Area")
                {
                    Console.Write("Ingresa el area del rectangulo en numero = ");
                    area= int.Parse(Console.ReadLine());
                    total = area * (2*area);
                    Console.WriteLine("El area del rectangulo es = " + total);

                }
                if(r== "Perimetro")
                {
                    Console.Write("Ingresa el Perimetro del rectangulo en numero = ");
                    peri=int.Parse(Console.ReadLine());
                    total = peri * peri+(peri * 2) + (peri * 2);
                    Console.WriteLine("El valor del perimetro del rectangulo es = " + total);
                }
                return rectangulo();
            }
        }


    } while (a!="si");
    int finalizo;
    finalizo = 1;
    return finalizo;
    

}
menu();





















































