/*
    IDEA-Proyecto: una tienda especializada en productos derivados de la acuaponia (pescado y vegetales).
    
    * ¿Como funciona el Negocio?:

        * ofrecen cajas de productos a sus clientes.
        * las cajas vienen en tres medidas: pequeña, mediana y grande.

        * cada medida lleva una cantidad fija de productos:
            - caja pequeña: 1kg de pescado |  1kg de vegetales.
            - caja mediana: 2kg de pescado |  2kg de vegetales.
            - caja grande:  5kg de pescado |  5kg de vegetales.

        * los precios son, por medida:
            - caja pequeña: 15$
            - caja mediana: 25$
            - caja grande:  50$

    * TODO: definir reglas y variación de estas, mas adelante (proyecto hipotetico).
*/

// variable auxiliar, ayuda a evitar un aviso sobre conversión de un input tipo null (se debe explayar más)
string? readInput;

do
{
    Console.Clear();

    Console.WriteLine("HidroMind - Menú de Administración\n");
    Console.WriteLine("1. Menú de Administración de clientes");
    Console.WriteLine("2. Menú de Administración de pedidos");
    Console.WriteLine("3. Menú de Administración de ventas");
    Console.WriteLine("0. Salir");
    
    Console.WriteLine("\nIngrese una opción o ingrese \"0\" para salir.");

    readInput = Console.ReadLine();
} while (readInput != "0");