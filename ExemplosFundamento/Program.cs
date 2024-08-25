using Exemplos.Fundamentos.Commom.Models;


int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;

// Exemplo de condicional 

 if(quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0)
 {
     Console.WriteLine("Venda realizada com sucesso");
 }

else if(quantidadeCompra == 0)
 {
     Console.WriteLine("Venda inválida");

  } else
 {
    Console.WriteLine("Venda não realizada por falta de estoque");
 }


Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

//  exemplo switch case

 switch(letra)
 {
     case "a":
     case "e":
     case "i":
     case "o":
     case "u":
     Console.WriteLine("Vogal");
     break;

    default:
    Console.WriteLine("Consoante");

    break;
 }


// exemplo for

int numero = 5;

 for(int contador1 = 0; contador1 <= 10; contador1++)
 {
   Console.WriteLine($"{numero} * {contador1} = {numero * contador1}");
 }

 //exemplo while

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

//exemplo do while 

 int soma = 0, numero2 = 0;

 do
  {
    Console.WriteLine("Digite um número(0 para parar)");
    numero2 = Convert.ToInt32(Console.ReadLine());
    soma += numero2;
  } while(numero2 != 0);

 Console.WriteLine($"Total da soma dos numeros digitados é {soma}");

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


//trabalhando com array

int[] arrayInteiros = new int [4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//percorrendo o array com for

for(int contador2 = 0; contador2 < arrayInteiros.Length; contador2++)
{
  Console.WriteLine($"Posição nº {contador2} - {arrayInteiros[contador2]}");
}


// percorrendo o array com foreach

Console.WriteLine("Percorrendo o array com foreach");
int contadorForEach = 0;

foreach(int valor in arrayInteiros)
{
  Console.WriteLine($"Posição nº {contadorForEach} - {valor}");
  contadorForEach++;
}


// trabalhando com lista

List<string> listaString = new List<string>();

listaString.Add("São Paulo");
listaString.Add("Baiha");
listaString.Add("Minas Gerais");
listaString.Add("Rio de Janeiro");

Console.WriteLine($"itens da minha lista {listaString.Count} - capacidade {listaString.Capacity}");

listaString.Add("Santa Catarina");
listaString.Remove("Minas Gerais");

for(int contador3 = 0; contador3 < listaString.Count; contador3++)
{
  Console.WriteLine($"Posição nº {contador3} - {listaString[contador3]}");
}

int contadorForEach2 = 0;
foreach(string item in listaString)
{
  Console.WriteLine($"Posição nº {contadorForEach2} - {item}");
  contadorForEach2++;
}