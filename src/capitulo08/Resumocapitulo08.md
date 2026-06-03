# CAPÍTULO	8 - STATE:	11	ESTADOS	E	1 OBJETO


---
## 📌 Visão Geral
Design pattern STATE  é um padrão comportamental que permite que um objeto altere seu comportamento quando seu estado interno muda.
Na prática, ele evita vários if, switch ou else espalhados pelo código para controlar comportamentos diferentes.

## Projeto
Sistema de jogos onde a personagem principal Maria precisa salvar o reino e para isso ela enfrenta vários desafios mudando de status de comportamento. 

## Escopo do sistema
Maria começa com formato pequeno, de acordo com o andamento do jogo ela pode pegar outros poderes (status) como: Flor de gelo, Estrela, Flor de Fogo
Se colidir com um inigimo ela vai perdendo os poderes até não ter nenhum e "morrer" no jogo.

## Status dos compostamentos de Maria
```csharp
public enum EstadoMaria
    {
        PEQUENA, FLOR_DE_GELO, ESTRELA, MORTA, FLOR_DE_FOGO

    }

```

Com isso será criada uma interface com os métodos e cada "Estado" terá a sua classe


### Solução
Ao invés de fazer vários "ifs" dependendo do comportamento do status, a solução é separar as funcionalidades em classes diferentes
e deixar que o cliente faça as mudanças
---


## Resumo
### O padrão State:

1. encapsula comportamentos por estado
2. elimina condicionais enormes
3. facilita manutenção
4 .deixa o código mais orientado a objetos

### Usado em:

1. jogos
2. fluxos
3. pedidos
4. máquinas de estado
5. workflows
6. autenticação
7. processos de aprovação

---

### Diferença entre Strategy e State

#### Características de cada um 

----------------------------------------------
| Padrão | Descrição                         |
----------------------------------------------
| Strategy | quando definida a estratégia, ela não vai mudar naquela execução. |
--------------------------------------------------------------------------------
| State | cada estado sabe suas transições, então o cliente não garante o estado atual |
----------------------------------------------------------------------------------------

#### Avaliação do uso dos padrões e um problema :

----------------------------------------------
| Padrão | Descrição                         |
----------------------------------------------
| Strategy | Se a estratégia precisa mmudar uma vez que ela foi definida? Se sim, vários ifs
provavelmente vão voltar a se espalhar pelo código para avaliarem um resultado e definirem uma nova estratégia|
--------------------------------------------------------------------------------
| State | o cliente precisa ficar verificando o estado atual o tempo todo? Se sim, a vantagem de não ter os ifs
espalhado pelo código desaparece completamente|
----------------------------------------------------------------------------------------
