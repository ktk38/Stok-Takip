﻿$(function () {
    $("#tblCategorie").on("click", ".btnKategorisil", function () {
        if (confirm("Silmek istediğinize emin misiniz")) {

            var id = $(this).data("id");
            alert(id);
            var btn = $(this);
            $.ajax({
                type: "GET",
                url: "/Categorie/Sil/" + id,
                success: function () {
                    btn.parent().parent().remove();
                }

            });
        }
    });
});

