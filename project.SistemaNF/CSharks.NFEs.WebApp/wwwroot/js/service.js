$('document').ready(e => {
    $('#selectize-codigo-descricao-servico').selectize({
        render: {
            option: function (data, escape) {
                return "<div id=" + data.value + " data-aliquota='" + data.aliquota + "'>" + data.text + "</div>"
            }
        }
    });

    $('#btn-cadastrar').click(e => {
        //e.preventDefault();
        //let form = $('#form-service');
        //let codigoInput = $('#input-codigo-servico');
        //let codigoServico = $('.item');
        //console.log(codigoServico.dataset.value);
        //form.submit();
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
            //Buscar Código TOM da sessão;
            let codigoTomEmpresa = "8845"
            inputTom.readOnly = true;
            inputTom.value = codigoTomEmpresa;
        } else {
            inputTom.readOnly = false;
            inputTom.value = "";
        }
    });
})