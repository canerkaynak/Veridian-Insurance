function confirmDelete(event) {
    var confirmation = confirm("Are you sure you want to delete?");

    if (!confirmation) {
        event.preventDefault();
    }
}