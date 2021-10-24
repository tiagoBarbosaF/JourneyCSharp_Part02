# Introdução à Orientação a Objetos

## Objetivos ao completar os estudos

- Domine o paradigma de programação mais usado no mercado de trabalho
- Entenda o que são referencias e objetos
- Use atributos, métodos da instância e da classe
- Define objetos através de construtores
- Aprenda sobre encapsulamento

## Ementas:

### Introdução

- Nossa primeira classe
- Classes e objetos
- Benefícios da POO
- Arquivos de código
- Criando objetos
- Mão na massa: Criando a primeira classe
- O que aprendi?
  - O que é uma classe
  - Como criar uma classe
  - Como criar um objeto ou instância de uma classe

### Tipos

- Projeto da aula anterior
- Usando nossa classe
- Obtendo campos
- Inicialização de variáveis
- Definindo valor de atributos
- Valores padrões
- Tipos de referência e tipos de valor
- Inicialização de booleanos
- Referências de objetos
- Mão na massa: Criando a primeira classe
- O que aprendi?
  - Como acessar e alterar campos de um objeto
  - Valores padrões de campos de classes
  - Tipos de referência e tipos de valor
  - Inicialização de campos
  - Como funciona a atribuição de uma referência à uma variável

### Comportamentos de classes

- Projeto da aula anterior
- Nossa primeira funcao
- Como chamar um método?
- Metodo sem retorno
- Metodos com varios argumentos
- Sobre métodos
- Métodos válidos
- Onde usar o this?
- Mão na massa: Criando métodos
- O que aprendi?
  - Como definir métodos com parâmetros e retorno;
  - Como retornar algo usando a palavra chave `return` antes da expressão do resultado;
  - O uso do `return` para retornar antecipadamente a execução de um método;
  - Como usar a referência `this` para acessar um atributo;
  - Que podemos passar uma referência como parâmetro do método;
  - Métodos são chamadas a partir da referência usando o operador `.`.

### Namespace composição e null

- Projeto da aula anterior
- Entendendo namespaces
- Importância dos namespaces
- Diretivas using
- Composicao de classes
- Referências nulas
- Problema não esperado
- Extraindo o que é comum
- Solucionando o problema no código
- Mão na massa: Referências
- O que aprendi?
  - Realizar o relacionamento entre classes através de composição.
  - Vantagens de se isolar informações repetidas em outra classe.
  - Como `namespaces` funcionam no C#.
  - O que forma o nome completo de uma classe.
  - Como as diretivas `using` são usadas.
  - O valor `null`.

### Propriedades

- Projeto da aula anterior
- ObterSaldo e DefinirSaldo
- Propriedades Get e Set
- Produtividade com Get e Set
- Getters e Setters
- Público x Privado
- Vantagens de campos privados
- Mão na massa: Criando Getters e Setters
- O que aprendi?
  - Atributos privados, restringindo o acesso aos atributos
  - Encapsulamento de código
  - Métodos de leitura dos atributos, os ***getters***
  - Métodos de modificação dos atributos, os ***setters***
  - A sintaxe de propriedades no C# para facilitar a criação de getters e setters: `public int Idade { get; set; }`
  - *Getters* e *Setters* de referência

### Construtores e mesmbros estáticos

- Projeto da aula anterior
- Construtores
- Membros estáticos
- Conclusão
- Projeto final do curso
- Utilizando Construtores
- Onde está o erro?
- Por que não soma?
- Mãos na massa: Criando construtores e membros estáticos
- O que aprendi?
  - Construtor da classe, possibilitando receber argumentos e inicializar atributos a partir da criação de um objeto;
    - Com isso, a inicialização dos atributos recebidos no construtor torna-se obrigatória.
  - Atributos da classe, os atributos estáticos;
  - Métodos da classe, os métodos estáticos;
  - Ausência de referência, do `this`, dentro de métodos estáticos.