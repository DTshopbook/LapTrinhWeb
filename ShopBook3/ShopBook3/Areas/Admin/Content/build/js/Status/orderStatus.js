var order = {
    init: function () {
        order.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active3').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/Order/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    console.log(response);
                    if (response.status == true) {
                        btn.text('Chưa hoàn thành');
                    }
                    else {
                        btn.text('Đã hoàn thành');
                    }
                }
            });
        });
    }
}
order.init();
