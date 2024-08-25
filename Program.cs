using exemplo_fundamentos.Models;

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

//int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }

// exemplo while

// int contador = 0;

// while(contador <=10)
// {
//   Console.WriteLine($"{numero} * {contador} = {numero * contador}");
//   contador++;

//   if(contador == 5)
//   {
//     break;
//   }
// }

//exemplo do while 

// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um número(0 para parar)");
// numero = Convert.ToInt32(Console.ReadLine());
// soma += numero;
// } while(numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é {soma}");

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite sua opção");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;

    case "2":
      Console.WriteLine("Busca de cliente");
      break;

    case "3":
      Console.WriteLine("Apaga o cliente");
      break;

    case "4":
      Console.WriteLine("Encerra");
      exibirMenu = false;
      break;

    default:
      Console.WriteLine("Opção invalida");
      break;
  }
}