(function() {

    $(function () {
        //localhost://IpersonService
        var _personService = abp.services.app.person;

        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find("form");


        _$form.find("button[type='submit']").click(function(e) {
            e.preventDefault();

            if (!_$form.valid()) { 
                return false;
            }

            //Form表单序列化为Object
            var personEditDto = _$form.serializeFormToObject();

            abp.ui.setBusy(_$modal);

            _personService.createOrUpdatePerson({ personEditDto }).done(function () {
                //隐藏Modal , 刷新页面
                _$modal.modal("hide"); 
                location.reload(); 
            }).always(function() { 
                abp.ui.clearBusy(_$modal);
            });

        });

    });

})();