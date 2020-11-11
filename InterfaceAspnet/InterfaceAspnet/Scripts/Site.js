$(document).ready(function() {
    $('.dupe-form-fields').click(function(event) {
        event.stopPropagation();
        $.each($(this).siblings(), function(index, item) {
            $this = $(item);
            if ($this.hasClass('group-form')) {
                $form_fields = $($this.children()[0]);
                $form_fields.clone().appendTo($this).addClass('group-fields-n');
            }
        });
    });

    $('.group-form').on('click', '.group-fields-n .close-btn', function(event) {
        event.stopPropagation();
        $(this).parent().parent().remove();
    });

    $('.group-form').on('mouseover', '.group-fields-n .close-btn', function(event) {
        event.stopPropagation();
        if(!$(this).parent().parent().hasClass('hover')) {
            $(this).parent().parent().addClass('hover');
        }
    });

    $('.group-form').on('mouseleave', '.group-fields-n .close-btn', function(event) {
        event.stopPropagation();
        if($(this).parent().parent().hasClass('hover')) {
            $(this).parent().parent().removeClass('hover');
        }
    });
});