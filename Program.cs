
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;

//exemplo de condicional 

// if(quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0)
// {
//     Console.WriteLine("Venda realizada com sucesso");
// }
// else if(quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda inválida");
// }
// else
// {
//    Console.WriteLine("Venda não realizada por falta de estoque");
// }


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// // exemplo switch case

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Consoante");

//     break;
// }


// exemplo for

int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }

// exemplo while

int contador = 0;

while(contador <=10)
{
  Console.WriteLine($"{numero} * {contador} = {numero * contador}");
  contador++;

  if(contador == 5)
  {
    break;
  }
}