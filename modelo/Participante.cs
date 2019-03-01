using System;

/// <summary>
/// Classe que represenata um participante da tabela
/// </summary>
public class Participante{
     
    private String nome;
    private String pais;
    private String instituicao;
    private String email;
    private String inscricao;

    public string Nome { get => nome; set => nome = value; }
    public string Pais { get => pais; set => pais = value; }
    public string Instituicao { get => instituicao; set => instituicao = value; }
    public string Email { get => email; set => email = value; }
    public string Inscricao { get => inscricao; set => inscricao = value; }
}
