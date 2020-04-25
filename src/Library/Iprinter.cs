using System;
using System.IO;

// Se utiliza los patrones de pliformismo y LSP. 
// Cumple con la definicion de poliformismo, ya que la operacion de imprimir el ticket es implementada por 2 objetos de diferentes tipos.
// También cumple con LSP porque al enviarle el mismo mensaje a 2 objetos uno de la clase ConsolePrinter y otro de la clase FilePrinter, el mensaje funciona de la misma forma. 

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);  
        

    }
}

