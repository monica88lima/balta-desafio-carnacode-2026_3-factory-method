![CR-3](https://github.com/user-attachments/assets/485b7ff1-c098-40bf-93b4-00058c8729a9)

## 🥁 CarnaCode 2026 - Desafio 03 - Factory Method

Oi, eu sou a Mônica e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Factory Method** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Uma aplicação de e-commerce precisa enviar notificações por diferentes canais (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação.
O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações.

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]

### Factory Method Pattern — Resumo
O Factory Method é um padrão criacional que define uma interface para criar objetos, mas permite que as subclasses decidam qual classe concreta será instanciada.
A ideia central é: Quem usa o objeto não deve saber como ele é criado.

🧠 Como foi implementado no projeto

A arquitetura foi organizada separando responsabilidades em camadas.
📦 DesignerPatternChallenge
 ┣ 📂 Application - Camada que abstrai as implementações concretas. Orquestra o envio.
 ┃ ┣ 📜 INotificationFactory.cs
 ┃ ┣ 📜 NotificationCenter.cs
 ┃
 ┣ 📂 Infrastructure -Camada das implementações concretas.
 ┃ ┣ 📂 Channel 👉 Todo novo canal deve ser incluído aqui.
 ┃ ┃ ┣ 📜 EmailNotification.cs
 ┃ ┃ ┣ 📜 SmsNotification.cs
 ┃ ┃
 ┃ ┣ 📂 Factory Contém as fábricas concretas: Responsáveis por instanciar o canal correto.
 ┃ ┃ ┣ 📜 EmailNotificationFactory.cs
 ┃ ┃ ┣ 📜 SmsNotificationFactory.cs
 ┃
 ┣ 📜 INotification.cs -Todos os canais devem implementar esse contrato.
 ┣ 📜 Program.cs
