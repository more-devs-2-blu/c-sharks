$('document').ready(e => {
    $('#selectize-codigo-descricao-servico').selectize({
        render: {
            option: function (data, escape) {
                return "<div id=" + data.value + " data-aliquota='" + data.aliquota + "'>" + data.text + "</div>"
            }
        }
    });

    $('#selectize-codigo-descricao-servico').change(e => {
        let selected = e.target.options[e.target.selectedIndex];
        let selectedItem = $(`#${selected.value}`)[0];
        let aliquota = selectedItem.dataset.aliquota;
        let descricao = (e.target.innerText.trim().substring(6).trim());
        $('#input-aliquota').val(aliquota);
        $('#input-descricao').val(descricao);
        $('#input-codigo-servico').val(selectedItem.id);
    })

    $('#checkbox-tributavel').change(e => {
        let checkbox = e.target;
        let inputTom = $('#codigo-tom')[0];
        if (checkbox.checked) {
            let codigoTomEmpresa = $('#input-tom').val();
            inputTom.readOnly = true;
            inputTom.value = codigoTomEmpresa;
        } else {
            inputTom.readOnly = false;
            inputTom.value = "";
        }
    });
})