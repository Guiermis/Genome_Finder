function compare() {
    let fbase = document.getElementById('base').value
    let gbase = fbase.toUpperCase();
    let bnome = document.getElementById('base-nome').value
    let codNCBI = document.getElementById('NCBI-cod').value
    let output = [];           //output como array

    if (gbase.length == 0) { //verifica se a caixa de input está vazia.
        window.alert("DIGITE!")
    } else if (gbase.length /= 0) {
        for (var i = 0; i < gbase.length; i++) {
            if (gbase[i] == "A") {
                output[i] = "T";
            } else if (gbase[i] == "G") {
                output[i] = "C";
            } else if (gbase[i] == "T") {
                output[i] = "A";
            } else if (gbase[i] == "C") {
                output[i] = "G";
            } else
                output[i] = gbase[i];
        } // fim do loop

        output = output.join('');   //transforma o array em string
        reslista.innerHTML = output;
    }

}