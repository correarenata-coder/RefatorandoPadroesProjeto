# CAPÍTULO	5 STRATEGY:	DIVIDIR	PARA SIMPLIFICAR

---
## 📌 Visão Geral

Neste capítulo, será abordado o padrão de projeto **Factory**, que é um dos padrões mais comuns e úteis para gerenciar a criação de objetos em sistemas orientados a objetos.
É um **padrão de comportamento** e resolve problemas de distribuição de responsabilidades.
---

## 🧩 O que é o padrão Strategy?
O padrão Strategy é um **padrão de comportamento** que permite definir uma família de algoritmos, encapsulá-los e torná-los intercambiáveis. O padrão Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam.

## 🔹 Vantagens do padrão Strategy
-- **Desacoplamento**: O código cliente não precisa conhecer as classes concretas que estão sendo instanciadas, promovendo um baixo acoplamento.
-- **Flexibilidade**: Permite que o sistema seja facilmente estendido para criar novos tipos de objetos sem modificar o código cliente.
-- **Centralização da criação de objetos**: Facilita a manutenção e evolução do código, pois a lógica de criação está concentrada em um único lugar.
-- **Facilidade de manutenção**: O código fica mais fácil de manter, pois cada algoritmo é encapsulado em uma classe separada, facilitando a identificação e correção de bugs.
-- **Reutilização de código**: Os algoritmos encapsulados podem ser reutilizados em diferentes partes do sistema, promovendo a reutilização de código.

# 🛒 Exemplo Prático em C#
## Cenário

Ao ser criado uma nova rede social "EuS2Livros", o time de desenvolvimento quer falicitar a entrada de novos usuários aproveitando as contas existentes das redes sociais.
---

## 🔹 Estratégias de Login

Aproveitar o Login do FaceNote
```csharp
public class ServicoFaceNoteLogin
    {
        public virtual ResultadoAutenticacao Autenticar(string idUsuario)
        {
            try
            {
                return ResultadoAutenticacao.Sucesso;
            }
            catch (TimeoutException ex)
            {
                return ResultadoAutenticacao.Falha;
            }

           
        }

        
    }

```

Aprovveitar também o Login do ZuiterLogin
```csharp
public class ServicoZuiterLogin
    {
        public ResultadoAutenticacao Autenticar(string idUsuario)
        {
            try
            {
                return ResultadoAutenticacao.Sucesso;
            }
            catch (TimeoutException)
            {
                return ResultadoAutenticacao.Falha;
            }
        }
    }

```

Na classe login foi criada conforme abaixo:

```csharp
public RespostaLogin Com(DadosDeLogin dadosDeLogin)
        {
            ResultadoAutenticacao resposta = ResultadoAutenticacao.MetodoInvalido;

            if (dadosDeLogin.Metodo == Autenticacao.ViaFaceNote)
            {
                resposta = _servicoFaceNote.Autenticar(dadosDeLogin.Usuario);
            }
            else if (dadosDeLogin.Metodo == Autenticacao.ViaZuiter)
            {
                resposta = _servicoZuiter.Autenticar(dadosDeLogin.Usuario);
            }

            string mensagem = "não foi possível autenticar";
            bool status = false;

            switch (resposta)
            {
                case ResultadoAutenticacao.Sucesso:
                    status = true;
                    mensagem = "login com sucesso";
                    break;

                case ResultadoAutenticacao.Revogado:
                    mensagem = "acesso revogado";
                    break;

                case ResultadoAutenticacao.Bloqueado:
                    mensagem = "acesso bloqueado";
                    break;

                case ResultadoAutenticacao.Pendente:
                    mensagem = "acesso pendente";
                    break;
            }

            return new RespostaLogin(mensagem, status);
        }
```

## Quais são os problemas encontrados que poderão ser refatorados:

Método Login que está bem grande e vai crescer mais ainda conforme novas redes sociais.
Sugestão é extrair cada provedor para ter as suas classes próprias.
