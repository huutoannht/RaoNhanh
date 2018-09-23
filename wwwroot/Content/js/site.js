// Write your JavaScript code.
$(function () {
})
function DeleteImage() {
   // $('#ImageUrl').val('');
}
function changeRecord(id, controller, action) {
    var text = "Bạn muốn thay đổi trạng thái!";
    if (!action) {
        action = "Delete";
        text = "Dòng này sẽ được xóa khỏi hệ thống!";
    };
    swal({
        title: text,
        text: "",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#f8b32d",
        confirmButtonText: "Yes!",
        closeOnConfirm: false
    }, function () {
        $.ajax({
            type: "POST",
            url: "/Admin/" + controller + "/" + action,
            data: { id: id },
            success: function () {
                //swal("Deleted!", "Xóa thành công.", "success");
                window.location.reload(true);
            },
        });

    });
    return false;
};