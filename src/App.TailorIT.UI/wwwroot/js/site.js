$(".delete-user").click(function () {
    let userId = parseInt($(this).data("id"));
    $.post("/Usuarios/DeleteConfirmed",
        {
            id: userId
        },
        function (data, status) {
            if (data == true) {
                swal({
                    text: "Usuário excluido com sucesso",
                    icon: "success",
                    button: {
                        confirm: {
                            text: "OK",
                            value: true,
                            visible: true,
                            className: "",
                            closeModal: false
                        }
                    },
                }).then((value) => {
                    location.reload();
                });
            }
            else {
                swal({
                    text: "Erro ao excluir o usuário",
                    icon: "error",
                });
            }
        });
});

function filter() {
    let nomeFilter = $("#nomeFilter").val();
    let idFilter = $('#sexosFilters option:selected').val();
    $.post("/Usuarios/Filters",
        {
            nome: nomeFilter,
            sexoId: idFilter
        },
        function (data, status) {
            console.log(status);
            $(".relatorio").html(data);
        });
}
