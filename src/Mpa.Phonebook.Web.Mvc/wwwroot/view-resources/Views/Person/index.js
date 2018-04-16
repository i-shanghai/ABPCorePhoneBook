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
                refreshPersonList(); 
            }).always(function() { 
                abp.ui.clearBusy(_$modal);
            });

        });
         
        $("#RefreshButton").click(function() { 
            refreshPersonList();
        });


        function refreshPersonList() {
            location.reload(true); 
        };

        //---begin Delete
        $(".delete-person").click(function() {
            var personId = $(this).attr("data-person-id");
            var personName = $(this).attr("data-person-name");
            deletePerson(personId, personName);
        });

        function deletePerson(personId,personName) {
            abp.message.confirm(
                "Delete Person '" + personName + "'? ",
                function(isConfirmed) {
                    if (isConfirmed) {
                        _personService.deletePerson({
                            id: personId
                        }).done(function() {
                            refreshPersonList();
                        });
                    }
                }
            ); 
        }
        //---End Delete

        //---begin Edit,数据取出来放到Form表单中
        $(".edit-person").click(function (e) {
            e.preventDefault();

            var personId = $(this).attr("data-person-id"); 

            _personService.getPersonForEdit({
                 id: personId
            }).done(function (data) { 
                $("input[name=Id]").val(data.personEditDto.id);
                $("input[name=Name]").val(data.personEditDto.name).closest(".form-line").addClass("focused");
                $("input[name=Email]").val(data.personEditDto.email).closest(".form-line").addClass("focused");
                $("input[name=Address]").val(data.personEditDto.address).closest(".form-line").addClass("focused");  
            }); 
        });
       
        //---End Edit

        //Modal 触发事件
        $("#PersonCreateModal").on("hidden.bs.modal", function () {
            $("input[name=Id]").val("");
            $("input").closest(".form-line").removeClass("focused");
            _$form[0].reset();
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

    });

})();