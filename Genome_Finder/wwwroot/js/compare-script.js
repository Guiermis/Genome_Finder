function compare() {
    var fbase = document.getElementById('base').value
    var fbase = fbase.toUpperCase();
    var res = document.querySelector('div#res')
    var output = [];           //output como array

    if (fbase.length == 0) { //verifica se a caixa de input está vazia.
        window.alert("DIGITE!")
    } else if (fbase.length /= 0) {
        for (var i = 0; i < fbase.length; i++) {
            if (fbase[i] == "A") {
                output[i] = "T";
            } else if (fbase[i] == "G") {
                output[i] = "C";
            } else if (fbase[i] == "T") {
                output[i] = "A";
            } else if (fbase[i] == "C") {
                output[i] = "G";
            } else
                output[i] = fbase[i];
        } // fim do loop

        output = output.join('');   //transforma o array em string
        reslista.innerHTML = output;
    }

}