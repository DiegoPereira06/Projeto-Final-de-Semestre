using Projeto_Final_de_Semestre.NovaPasta;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Final_de_Semestre;

public class Jogador : Pessoa
{
    public Jogador(string nome, DateTime dataNascimento)
       : base(nome, dataNascimento)
    { }

    public Jogador(string nome, DateTime dataNascimento, float Altura, float Peso, Posicao posicao)
         : base(nome, dataNascimento)
    {
       ALTURA= Altura;
        PESO = Peso;
    }
    public float ALTURA {  get; private set; } 
    public float PESO{ get; private set; }

}
