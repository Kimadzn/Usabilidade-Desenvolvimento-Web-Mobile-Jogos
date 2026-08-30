function calcularAreaEsfera() {

    const raio = parseFloat(document.getElementById('raio').value);

    if (isNaN(raio) || raio <= 0) {
        document.getElementById('resultado').innerText = "Digite um raio válido.";
        return;
    }

    const area = 4 * Math.PI * Math.pow(raio, 2);

    document.getElementById('resultado').innerText =
        `A área da esfera é ${area.toFixed(2)}`;
}