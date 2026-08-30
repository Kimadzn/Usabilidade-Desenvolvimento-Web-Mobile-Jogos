function calcularArea() {

    const raio = parseFloat(document.getElementById('raio').value);

    if (isNaN(raio) || raio <= 0) {
        document.getElementById('resultado').innerText = "Digite um raio válido.";
        return;
    }

    const area = Math.PI * Math.pow(raio, 2);

    document.getElementById('resultado').innerText =
        `A área do círculo é ${area.toFixed(2)}`;
}