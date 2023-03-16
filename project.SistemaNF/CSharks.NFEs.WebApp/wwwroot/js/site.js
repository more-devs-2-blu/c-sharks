$(document).ready(function () {


    // BEGIN MENU BAR
    var url = window.location.href;
    $('.nav-link').each(function () {
        var navUrl = $(this).attr('href');
        if (url.includes(navUrl)) {
            $(this).addClass('active');
            $(this).parent().find('.selected-circle').css('opacity', '1');
        }
    });

    $('.nav-link').click(function (e) {
        e.preventDefault();
        $('.nav-link').removeClass('active');
        $('.selected-circle').css('opacity', '0');
        $(this).addClass('active');
        $(this).parent().find('.selected-circle').css('opacity', '1');
        window.location.href = $(this).attr('href');
    });
    // END MENU BAR


    //ALERT MESSAGE RESULT
    $('.close-alert').click(function () {
        $('.alert').hide('hide');
    });
    //END

    //BEGIN DATA TABLE
    getDataTable('#dt-nf');
    getDataTable2('#dt-recents')

    function getDataTable(id) {
        $(id).DataTable({
            "ordering": true,
            "paging": true,
            "searching": true,
            "oLanguage": {
                "sEmptyTable": "Nenhum registro encontrado na tabela",
                "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
                "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
                "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
                "sInfoPostFix": "",
                "sInfoThousands": ".",
                "sLengthMenu": "Mostrar _MENU_ registros por pagina",
                "sLoadingRecords": "Carregando...",
                "sProcessing": "Processando...",
                "sZeroRecords": "Nenhum registro encontrado",
                "sSearch": "Pesquisar",
                "oPaginate": {
                    "sNext": "Próximo",
                    "sPrevious": "Anterior",
                    "sFirst": "Primeiro",
                    "sLast": "Ultimo"
                },
                "oAria": {
                    "sSortAscending": ": Ordenar colunas de forma ascendente",
                    "sSortDescending": ": Ordenar colunas de forma descendente"
                }
            }
        });
    }

    function getDataTable2(id) {
        $(id).DataTable({
            "ordering": true,
            "paging": false,
            "searching": false,
            "oLanguage": {
                "sEmptyTable": "Nenhum registro encontrado na tabela",
                "sInfo": "Mostrar _START_ até _END_ de _TOTAL_ registros",
                "sInfoEmpty": "Mostrar 0 até 0 de 0 Registros",
                "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
                "sInfoPostFix": "",
                "sInfoThousands": ".",
                "sLengthMenu": "Mostrar _MENU_ registros por pagina",
                "sLoadingRecords": "Carregando...",
                "sProcessing": "Processando...",
                "sZeroRecords": "Nenhum registro encontrado",
                "sSearch": "Pesquisar",
                "oPaginate": {
                    "sNext": "Próximo",
                    "sPrevious": "Anterior",
                    "sFirst": "Primeiro",
                    "sLast": "Ultimo"
                },
                "oAria": {
                    "sSortAscending": ": Ordenar colunas de forma ascendente",
                    "sSortDescending": ": Ordenar colunas de forma descendente"
                }
            }
        });
    }
    //END DATA TABLE
});