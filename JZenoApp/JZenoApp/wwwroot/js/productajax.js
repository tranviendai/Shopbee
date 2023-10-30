$(function () {
    $("#updateProduct").click(function () {
        $("input[id^=productColor]").each(function () {
            $.ajax({
                type: "POST",
                url: "/Products/PutColor",
                data: {
                    id: $(this).attr("data-color"),
                    name: $(this).val()
                },
                success: function (data) {
                },
                error: function (err) {
                    alert("Lỗi do mạng");
                }
            });
        });

        $("input[id^=productSize]").each(function () {
            $.ajax({
                type: "POST",
                url: "/Products/PutSize",
                data: {
                    id: $(this).attr("data-size"),
                    name: $(this).val()
                },
                success: function (data) {
                },
                error: function (err) {
                    alert("Lỗi do mạng");
                }
            });
        });
        $("input[id^=productQuantity]").each(function () {
            $.ajax({
                type: "POST",
                url: "/Products/PutQuantity",
                data: {
                    id: $(this).attr("data-quantity"),
                    quantity: $(this).val()
                },
                success: function (data) {
                },
                error: function (err) {
                    alert("Lỗi do mạng");
                }
            });
        });
    });
});