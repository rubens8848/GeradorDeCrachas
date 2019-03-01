# Crachas Even3

Este Mini projeto permite ao usuário criar crachás para vários participantes de um evento de forma rápida e dinâmica!
  
## Funcionamento

<ul>
<li> 1 - Usuário escolhe imagem do crachá</li>
<li> 2 - usuário digita texto do crachá, podendo conter tags como : {{nome}}, {{país}}, {{email}}, {{instituição}}, {{inscrição}}</li>
<li> 3 - Usuário cola o conteúdo da tabela, inclusive os cabeçalhos</li>  
<li> 3 - Usuário clica no botão "Baixar Crachás"
</ul>


## Pré-requisitos:

- Biblioteca iTextSharp


## Exemplo Rápido

<h3>Cria um arquivo com o texto da tabela e popula uma lista de participantes vinda do arquivo </h3>


```c#
ConverterParticipante conversorDeParticipante = new ConverterParticipante(area_tabela.Text);
conversorDeParticipante.CriaArquivo();
List<Participante> participantes = conversorDeParticipante.PopulaListaDeParticipantes();
textoComTagsOriginal = area_tags.Text;
  ```
  
<h3>Converte as tags em informações dos participantes e cria os crachás</h3>
  
```c#
area_tags.Text = textoComTagsOriginal;
ConverteTagsEmInformacoes(participantes, indiceDoLaco);
CriaPDFComCracha(participantes, indiceDoLaco);
```
