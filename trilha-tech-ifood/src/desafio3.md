# Desafio Escrevendo as classes de um jogo

** O que deve ser utilizado**

- Variáveis
- Operadores
- Laços de repetição
- Estrutura de decisões
- Funções

## Objetivo

Crie uma classe genérica que represente um herói de uma
aventura e que possua as seguintes propriedades:

- nome
- idade
- tipo (ex: guerreiro, mago, monge, ninja)

além disso, deve ter um método chamado atacar que 
deve atender os seguintes requisitos:

- exibir a mensagem: ("o {tipo} atacou usando {ataque}")
- aonde o {tipo} deve ser concatenando o tipo que está 
propriedade da classe
- e no {ataque} deve seguir uma descrição diferente
o tipo, seguindo a tabela abaixo:

* Se mago -> no ataque exibir (usou magia)
* Se guerreiro -> no ataque exibir (usou espada)
* Se monge -> no ataque exibir (usou artes marciais)
* Se ninja -> no ataque exibir (usou shuriken) 

## Saída

Ao final deve ser exibido uma mensagem:
"O **{tipo}** atacou usando **{ataque}**
ex: mago atacou usando magia,
guerreiro atacou usando espada
