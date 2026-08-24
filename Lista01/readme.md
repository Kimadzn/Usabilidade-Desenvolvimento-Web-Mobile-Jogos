# Explicação simples do JavaScript

```js
const botao = document.getElementById('botao');
const texto = document.getElementById('texto');

botao.addEventListener('click', () => {
  texto.textContent = 'Você ativou o JavaScript com sucesso!';
  botao.textContent = 'Clicado';
});
```

É bem simples:

- `document.getElementById('botao')` pega o botão.
- `document.getElementById('texto')` pega o texto da página.
- `addEventListener('click', ...)` faz o código ficar de olho no clique do botão.
- Quando o botão for clicado:
  - `texto.textContent = 'Você ativou o JavaScript com sucesso!'` troca a mensagem.
  - `botao.textContent = 'Clicado'` muda o nome do botão.

Em poucas palavras: ao clicar, a página mostra uma mensagem e muda o texto do botão.
RA 1252211620090 Arthur Octavio Xavier Messias