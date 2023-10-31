$(function () {
    $(".buy-product").click(function (event) {
        event.preventDefault();
        var productid = $(".productDetail").attr("data-productid");
        var color = $('input[name=productColor]:checked', '.option-choose').attr("data-color");
        var size = $('input[name=productSize]:checked', '.option-choose').attr("data-size");
        var quantity = $('#sl-product').val();
        if (productid != null && color != null && size != null) {
            $.ajax({
                type: "POST",
                url: "/addcart",
                data: {
                    id: productid,
                    color: color,
                    size: size,
                    quantity: quantity
                },
                success: function (result) {
                    window.location.href = "/cart";
                },
                error: function (err) {
                    alert("Lỗi do mạng");
                }
            });
        }
    });
});