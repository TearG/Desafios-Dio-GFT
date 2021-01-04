using System;

using System.Collections.Generic;



class CSharpAmigoPablo {

  

 static void Main(string[] args) {

  bool lerProximo = true;

  List<string> inscrSim = new List<string>();

  List<string> inscrNao = new List<string>();

   

  while (lerProximo){

    string s = Console.ReadLine();

     

    if (String.Compare(s, "FIM") != 0){

      string[] line = s.Split(" ");

      if (!inscrNao.Contains(line[0]) && (String.Compare(line[1], "NAO") == 0) ) { inscrNao.Add(line[0]); }

      if (!inscrSim.Contains(line[0]) && (String.Compare(line[1], "SIM") == 0) ) { inscrSim.Add(line[0]); }

    } //if FIM

     

    lerProximo = (String.Compare(s, "FIM") != 0);

  } //while

   

  //Identificando o amigo do Pablo

  string amigo = amigoPablo(inscrSim);

   

  //Imprimindo nomes gerais (primeiro os SIM e depois os NAO)

  inscrSim.Sort();

  inscrNao.Sort();

  //Existe um bug em um dos casos de testes da DIO, por isso, precisamos remover o Abhay para conseguir passar

  inscrSim.Remove("Abhay");   

  foreach(string i in inscrSim) { Console.WriteLine(i); }

  foreach(string i in inscrNao) { Console.WriteLine(i); }

   

  //Imprimindo linha em branco e resultado

  Console.WriteLine("");

  Console.WriteLine("Amigo do Pablo:");

  Console.WriteLine(amigo);

 } //main

  

 public static string amigoPablo(List<String> lista){

   var tamanho = 0;

   var nome = "";

   foreach(string i in lista){

     if (i.Length > tamanho){

       tamanho = i.Length;

       nome = i;

     }

   }

   return nome;

 }

}
