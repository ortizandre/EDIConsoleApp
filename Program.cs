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

    * TODO: definir reglas y variación de estas (proyecto hipotetico).
    * TODO: preparar clases para designar la impresión de menús
    * TODO: definir variables y clases para trabajar con arrays.
*/

// variable auxiliar, ayuda a evitar un aviso sobre conversión de un input tipo null (se debe explayar más)
string? readInput;
string selectedOption = "";

do
{
    Console.Clear();
    Console.WriteLine("HidroMind - Menú de Administración\n");
    Console.WriteLine("1. Menú de Administración de clientes");
    Console.WriteLine("2. Menú de Administración de pedidos");
    Console.WriteLine("3. Menú de Administración de ventas");
    Console.WriteLine("0. Salir");
    Console.WriteLine("\nIngrese una opción o ingrese \'0\' para salir.");

    readInput = Console.ReadLine();
    // si la entrada no es nula, se agrega el valor de esta a la variable para el condicional switch.
    if (readInput != null)
    {
        selectedOption = readInput;
    }

    switch (selectedOption)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Menú de Administración de clientes\n");
            Console.WriteLine("1. Agregar cliente");
            Console.WriteLine("2. Ver clientes");
            Console.WriteLine("3. Actualizar cliente");
            Console.WriteLine("4. Eliminar cliente");
            Console.WriteLine("0. Volver atrás");
            Console.WriteLine("\nIngrese una opción o ingrese \'0\' para volver al menú anterior");
            readInput = Console.ReadLine();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Menú de Administración de pedidos\n");
            Console.WriteLine("1. Agregar Pedido");
            Console.WriteLine("2. Ver Pedidos");
            Console.WriteLine("3. Actualizar Pedido");
            Console.WriteLine("4. Eliminar Pedido");
            Console.WriteLine("0. Volver atrás");
            Console.WriteLine("\nIngrese una opción o ingrese \'0\' para volver al menú anterior");
            readInput = Console.ReadLine();
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("Menú de Administración de ventas\n");
            Console.WriteLine("1. Agregar Venta");
            Console.WriteLine("2. Ver Ventas");
            Console.WriteLine("3. Actualizar Venta");
            Console.WriteLine("4. Eliminar Venta");
            Console.WriteLine("0. Volver atrás");
            Console.WriteLine("\nIngrese una opción o ingrese \'0\' para volver al menú anterior");
            readInput = Console.ReadLine();
            break;

        default:
            if (readInput != "0")
            {
                Console.Clear();
                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                readInput = Console.ReadLine();
            }
            break;
    }
} while (readInput != "0");