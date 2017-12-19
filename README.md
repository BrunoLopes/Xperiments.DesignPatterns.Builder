##### Design Patterns (Padrões de Projeto)     
[![N|MFYIT](https://contrib.azurewebsites.net/mfyit_card.png)](http://mfyit.azurewebsites.net) 


# Padrão Builder 

> Builder é um padrão de projeto de software criacional que permite a separação da construção de um objeto complexo da sua representação, de forma que o mesmo processo de construção possa criar diferentes representações.

### Utilização

> O padrão Builder pode ser utilizado em uma aplicação que converte o formato de texto RTF para uma série de outros formatos e que permite a inclusão de suporte para conversão para outros formatos, sem a alteração do código fonte do leitor de RTF.

> A implementação da solução para esse problema pode ser realizada através de uma classe de leitura (director) associada a uma classe capaz de converter o formato RTF para outra representação (builder). O objeto da classe de leitura lê cada token do texto e executa o método apropriado no objeto de conversão, de acordo com tipo do token. A classe de conversão possui um método para cada tipo de token, incluindo os caracteres comuns, parágrafos, fontes e etc. Para cada formato de texto suportado é criada uma classe de conversão especializada (concrete builder). Um conversor para formato ASCII, por exemplo, poderia ignorar qualquer requisição para converter tokens que não fossem caracteres comuns. Um conversor para o formato PDF, por outro lado, iria processar qualquer requisição para poder converter o estilo, além do texto.

### Vantagens
* Permite variar a representação interna de um produto;
* Encapsula o código entre construção e representação;
* Provê controle durante o processo de construção.

### Desvantagens
* Requer criar um concrete builder específico para cada instância diferente do produto.

### Comparação com o Abstract Factory
> O padrão Builder é muitas vezes comparado com o padrão Abstract Factory pois ambos podem ser utilizados para a construção de objetos complexos. A principal diferença entre eles é que o Builder constrói objetos complexos passo a passo e procura evitar ser um anti-padrão, enquanto o Abstract Factory constrói famílias de objetos, simples ou complexos, de uma só vez - e permite polimorfismo.

### Estrutura
O padrão Builder, da forma como foi descrito no livro Design Patterns: Elements of Reusable Object-Oriented Software, contém os seguintes elementos:

* director — constrói um objeto utilizando a interface do builder;
* builder — especifica uma interface para um construtor de partes do objeto-produto;
* concrete builder — define uma implementação da interface builder, mantém a representação que cria e fornece interface para recuperação do produto;
* product — o objeto complexo acabado de construir. Inclui classes que definem as partes constituintes.
![N|MFYIT](https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/500px-Builder_UML_class_diagram.svg.png)

---

## Installation

- Download the latest .NET Core SDK

* [.NET Core 2.0 SDK](release-notes/download-archives/2.0.3.md)

### Clone

- Clone this repo to your local machine using `https://github.com/BrunoLopes/Xperiments.DesignPatterns.Interpreter`

### Setup



> Restore all the packages first

```shell
$ dotnet restore
```

> now build the project

```shell
$ dotnet build
```
---

## Support

Reach out to me at one of the following places!

- Website:  [![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](http://mfyit.azurewebsites.net)
- Email: emfyit@gmail.com

---

## Donations (Optional)

[![Support via Gratipay](https://cdn.rawgit.com/gratipay/gratipay-badge/2.3.0/dist/gratipay.png)](https://liberapay.com/brunolopes/donate)


---

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright MFY IT © 2017  
