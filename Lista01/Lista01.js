    const botao = document.getElementById('botao');
    const texto = document.getElementById('texto');

    botao.addEventListener('click', () => {
      texto.textContent = 'Você ativou o JavaScript com sucesso!';
      botao.textContent = 'Clicado';
    });