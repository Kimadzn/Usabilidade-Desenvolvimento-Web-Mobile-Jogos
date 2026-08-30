function calcularJuros() {

    const valorInicial = parseFloat(document.getElementById('valorInicial').value);
    const taxa = parseFloat(document.getElementById('taxa').value) / 100;
    const tempo = parseFloat(document.getElementById('tempo').value);

    if (isNaN(valorInicial) || valorInicial <= 0 ||
        isNaN(taxa) || taxa < 0 ||
        isNaN(tempo) || tempo <= 0) {

        document.getElementById('resultado').innerText =
            "Digite valores válidos.";

        return;
    }

    const montante = valorInicial * Math.pow(1 + taxa, tempo);

    document.getElementById('resultado').innerText =
        `O montante é R$ ${montante.toFixed(2)}`;
}