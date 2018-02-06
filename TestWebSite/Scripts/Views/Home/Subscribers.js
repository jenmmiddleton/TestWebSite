$(document).ready(function () {
    ///-----------------
    /// Set up Datatable
    ///-----------------
    var table = $('#subscriberTable').DataTable({
        serverSide: false,
        paging: true,
        lengthChange: true,
        searching: true,
        ordering: true,
        info: true,
        autoWidth: true,
        lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
        buttons: [
            {
                extend: "csv",
                className: "btn-sm"
            }
        ],
        responsive: true,
        ajax: {
            "url": "/api/SubscribersAPI/SubscribersDataTable",
            "type": "POST"
        },
        columns: [
            { "data": "Fullname" },
            { "data": "Email" },
            { "data": "SMS" },
            { "data": "Fax" }
        ]
    });
});