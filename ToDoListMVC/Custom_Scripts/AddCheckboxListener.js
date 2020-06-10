$(document).ready(function () {
    $('.activeCheck').change(function () {
        var element = $(this);
        var elementId = element.attr('id');
        var elementValue = element.prop('checked');

        $.ajax({
            url: 'ToDoes/AJAXEdit',
            data: {
                id: elementId,
                isDone: elementValue
            },
            type: 'POST',
            success: function (result) {
                $('#tableDiv').html(result);
            }
        });
    });
});