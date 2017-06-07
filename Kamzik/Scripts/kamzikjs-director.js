class Director {
    constructor() {
        this.createNewPage();
    }

    loadAjaxDataToSend(object) {

    }

    mapData(key,value) {
        let map = new Map();
        map.set(key, value);
        return map;
    }
    fetchData(identifier, value, hardtype) {
        if (typeof identifier === "string" && (typeof value === "string" || typeof value === "number") && hardtype != null) {
            identifier = identifier instanceof $ ? identifier = identifier : identifier = $('.' + identifier);
        }
        else {
            console.log('bad code format');
        }
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
