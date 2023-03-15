$('document').ready(e => {
    $('#input-cep').keyup(e => {
        let valueLength = e.target.value.length;
        if (valueLength == 8) {
            let cep = e.target.value;
            $.ajax({
                url: `https://viacep.com.br/ws/${cep}/json/`,
                method: 'GET',
                success: res => {
                    console.log(res);
                    $(`#input-city`).val(res.localidade);
                    $('#input-district').val(res.bairro);
                    $('#input-address').val(res.logradouro);
                    $('#hidden-input-city').val(res.siafi);
                }
            })
        }
    })
})