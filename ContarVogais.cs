using System;
using System.Collections.Generic;
using System.Diagnostics;
using ExercicioCodeWar;
public class ContarVogais{

public void mostraVogal(){

    int totalDeVogais = 0;

    //Lista de vogais
    var vogais = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};

    Console.WriteLine("Escreva alguma palavra para checar se tem vogal");

        
    string respostaUsuario = Console.ReadLine().ToLower();

    for(int i = 0; i< respostaUsuario.Length; i++){

    if(vogais.Contains(respostaUsuario[i])){

    totalDeVogais++;
    }
 }
       
    Console.WriteLine($"Numero total de vogais : {totalDeVogais}");
       
}






}