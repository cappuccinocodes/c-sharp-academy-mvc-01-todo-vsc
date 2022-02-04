function deleteTodo(i) 
{

    $.ajax({
        url: 'Home/Delete',
        type: 'POST',
        data: {
            id: i
        },
        success: function() {
            window.location.reload();
        }
    });
}