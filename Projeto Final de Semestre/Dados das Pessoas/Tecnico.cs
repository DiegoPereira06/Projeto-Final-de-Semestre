using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Final_de_Semestre.NovaPasta;

public class Tecnico : Pessoa 
{
    public Tecnico(string nome, DateTime dataNascimento)
    : base(nome, dataNascimento)
    { }
    public Tecnico(string nome, DateTime dataNascimento, int AnosDeExperiencia, string TimesQueliderou)
        : base(nome, dataNascimento)
    { }


    public int AnosDeExperiencia { get; private set; }
    public string TimesQueLiderou { get; private set; } = string.Empty;
}
