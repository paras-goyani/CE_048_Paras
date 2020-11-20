
document.getElementById("delete-form").onsubmit = show;

function show(e) {
    e.preventDefault();
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover this blog!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    }).then((willDelete) => {
            if (willDelete) {
                swal("Your blog has been deleted!", {
                    icon: "success",
                }).then(() => { document.getElementById("delete-form").submit() });
            } else {
                swal("Your blog is safe!");
            }
      });
}
