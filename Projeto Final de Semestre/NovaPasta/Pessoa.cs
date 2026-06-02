using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Final_de_Semestre.NovaPasta;

public abstract class  Pessoa
{
    
    public string Nome { get; private set; } = string.Empty;
    public DateTime DataNascimento { get; private set; }
}
