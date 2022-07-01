function pegarData() {
    var hoje = new Date();
    var cHorario = hoje.getHours();
    var res = '';
    var msg = document.getElementById('intro');


    if (cHorario >= 0 && cHorario < 11) {
        res = 'Bom dia!';
    } else if (cHorario >= 12 && cHorario < 18) {
        res = 'Boa tarde!';
    } else if (cHorario >= 18 && cHorario < 24) {
        res = 'Boa noite!';
    }

    msg.innerHTML = res;
}