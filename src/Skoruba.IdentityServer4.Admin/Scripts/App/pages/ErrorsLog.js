﻿$(function () {

    $(".row-error-detail>td").each(function () {

        const json = $(this).data("error-json");
        var result;

        try {
            result = JSONTree.create(JSON.parse(json));
        } catch (e) {
            result = JSONTree.create(json);
        }

        $(this).html(result);
    });

    $(".btn-error-detail").click(function (e) {

        e.preventDefault();

        var errorId = $(this).data("error-id");

        if ($(`.row-error-detail[data-error-id=${errorId}]`).is(":visible")) {
            $(`.row-error-detail[data-error-id=${errorId}]`).addClass('d-none');
        } else {
            $(`.row-error-detail[data-error-id=${errorId}]`).removeClass('d-none');
        }

        return false;
    });

});