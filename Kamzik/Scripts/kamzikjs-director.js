class Director {
    constructor() {
        this.createNewPage();
    }

    loadAjaxDataToSend() {

    }

    createNewPage() {
        $('.kamzikjs_submit-Create-Page-Form').on('click', function (e) {
           e.preventDefault();
            $.ajax({
                url: "/Kamzik/CreateAjaxPage",
                type: "POST",
                data: JSON.stringify({ 'motherId': 1 }),
                dataType: "json",
                traditional: true,
                contentType: "application/json; charset=utf-8",
                success: function (data) {

                    // perform your save call here

                    if (data.status == "Success") {
                        alert("Done");
                    } else {
                        alert("Error occurs on the Database level!");
                    }
                },
                error: function () {
                    alert("An error has occured!!!");
                }
            });
        });
    }

}
