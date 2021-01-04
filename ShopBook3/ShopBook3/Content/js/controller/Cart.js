
var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });

        $('#btnUpdate').off('click').on('click', function () {
           
            var listProduct = $('.txtAmount');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                cartList.push({
                    Amount: $(item).val(),
                    Product: {
                        ProductID: $(item).data('id')
                    }
                });                
            });

            $.ajax({
                url: '/Cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/cart";
                    }                   
                }
            })        
        });
        $('#btnDeleteCart').off('click').on('click', function () {
            $.ajax({
                url: '/Cart/DeleteCart',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/cart";
                    }                    
                }
            })
        });

        $('.btn-delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data: {
                    ProductID: $(this).data('id')
                },
                url: '/Cart/Delete',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/cart";
                    }
                }
            })
        });

        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/payment";
        });


    }
}
cart.init();
