const responseAnswerClass = {};


function xhr_request(_url, _method, _param, _async, _callback) {
    $.ajax({
        type: "POST",
        url: _url + '/' + _method,
        data: (_param) ? JSON.stringify(_param) : "",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        cache: false,
        async: _async,
        success: function (response) {
            if (response.d != null) {
                _callback(response.d);
            } else {
                _callback({ resStatus: false, resMessage: 'Probably something wrong in ajax call.', data: null });
            }
        },
        error: function (request, status, error) {
            _callback({ resStatus: false, resMessage: request.responseText, data: null });
        }
    });
}

function DateBinding(data) {
    //data = ["id1", "id2", "id3"]
    for (var i = 0; i < data.length; i++) {

        $('#' + data[i]).datetimepicker({
            zIndex: 100000
            , format: 'd/m/Y'
            , timepicker: false
            , datepicker: true
            , showButtonPanel: true
        });
    }

}

function addErrorLabel(id) {
    $("label[for=\"" + id + "\"]").removeClass('n-error');
    $("label[for=\"" + id + "\"]").addClass('f-error');
}
function removeErrorLabel(id) {

    $("label[for=\"" + id + "\"]").removeClass('f-error');
    $("label[for=\"" + id + "\"]").addClass('n-error');
}
function onNextOrBack(form, to) {
    $("#" + form).removeClass('d-open');
    $("#" + to).removeClass('d-close');

    $("#" + form).addClass('d-close');
    $("#" + to).addClass('d-open');

  
}

function ChcekPersonalData(event) {
    CheckVendor();
    
    responseAnswerClass.WatchYoutube = $('input[name="watchYoutube"]:checked').val();
    responseAnswerClass.AsOfDate = $('#as_of_date_form').val();
    responseAnswerClass.Phone = $('#phone').val();
    responseAnswerClass.FullName = $('#fullname').val();
    responseAnswerClass.Companay = $('#company').val();

    var count_error = 0
    if (responseAnswerClass.WatchYoutube) {
        removeErrorLabel('watchYoutube')
    } else {
        addErrorLabel('watchYoutube')
        count_error++;
    }
    if (responseAnswerClass.AsOfDate) {
        removeErrorLabel('as_of_date_form')
    } else {
        addErrorLabel('as_of_date_form')
        count_error++;
    }
    if (responseAnswerClass.Phone) {
        removeErrorLabel('phone')
    } else {
        addErrorLabel('phone')
        count_error++;
    }
    if (responseAnswerClass.FullName) {
        removeErrorLabel('fullname')
    } else {
        addErrorLabel('fullname')
        count_error++;
    }
    if (responseAnswerClass.Companay) {
        removeErrorLabel('company')
    } else {
        addErrorLabel('company')
        count_error++;
    }

    if (event == 'next') {
        onNextOrBack('PersonalData', 'ExamAfterTraining')
    }

}

function ChcekExcems(event) {

    var ExcemOne = $('input[name="ExcemOne"]:checked').val();
    var ExcemTwo = $('input[name="ExcemTwo"]:checked').val();
    var ExcemTree = $('input[name="ExcemTree"]:checked').val();
    var ExcemFour = $('input[name="ExcemFour"]:checked').val();
    var ExcemFive = $('input[name="ExcemFive"]:checked').val();
    var ExcemSix = $('input[name="ExcemSix"]:checked').val();
    var ExcemSeven = $('input[name="ExcemSeven"]:checked').val();
    var ExcemEight = $('input[name="ExcemEight"]:checked').val();
    var ExcemNine = $('input[name="ExcemNine"]:checked').val();
    var ExcemTen = $('input[name="ExcemTen"]:checked').val();

    let excems = [{
        "No":"Question1"
        , "Name":"ExcemOne"
        //, "QuestionTH":""
        //, "QuestionEN":""
        //, "ChoiceClass":""
        //, "Answer":""
        //, "IsCorrect":""
        , "UserChoose":ExcemOne
       }]

    var count_error = 0
    if (ExcemOne) {
        removeErrorLabel('ExcemOne')
    } else {
        addErrorLabel('ExcemOne')
        count_error++;
    }
    
    responseAnswerClass.Excems = excems
    if (event == 'next') {
        onNextOrBack('PersonalData', 'ExamAfterTraining')
    }

}

function OnSvae(url) {
    ChcekExcems("")

    var params = {
        res: responseAnswerClass
    };

    xhr_request(url, "OnSaveFrom", params, false, function (response) {

        if (response.resStatus == true) {
            $('#phone').val(response.data);
            $("#PersonalData").removeClass('d-open');
            $("#ExamAfterTraining").removeClass('d-open');
            $("#Submitted").removeClass('d-close');

            $("#PersonalData").addClass('d-close');
            $("#ExamAfterTraining").addClass('d-close');
            $("#Submitted").addClass('d-open');

        }
    });
}
function OnLocation(url) {
    window.location.href = url;
}

function OnChcekScore(url, scoreUrl) {
    var params = { phone: $('#phone').val()}
    xhr_request(url, "OnChcekScore", params, false, function (response) {

        if (response.resStatus == true) {
            OnLocation(scoreUrl)
        }
    });

}
function CheckVendor() {
    responseAnswerClass.Id = "VendorCode";
}