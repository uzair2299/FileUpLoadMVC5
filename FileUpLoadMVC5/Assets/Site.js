function showImage(event) {
    //--------------------------------------under testing script--------------------------------------------
    var filename = $('#filePreview').val();
    if (filename.substring(3, 11) == 'fakepath') {
        filename = filename.substring(12);
    }
    $('#my_file').html(filename);

    //-----------------------------------------------------------------------------------------------
    console.log("hello");
    //--------------------------------------tested script--------------------------------------------
    if (event.target.files.length > 0) {
        var file = event.target.files[0].name;
        var scr = URL.createObjectURL(event.target.files[0]);
        var preview = document.getElementById("ImagePreview");
        preview.src = scr;
        preview.style.display = "block";
        //document.getElementById("ImagePreviewLabel").innerText = name;
    }
    //-----------------------------------------------------------------------------------------
}

//----------------------------------------------Tested----------------------------------------------------
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#ImagePreview').attr('src', e.target.result);
        }
        var preview = document.getElementById("ImagePreview");
        preview.style.display = "block";
        reader.readAsDataURL(input.files[0]); // convert to base64 string
    }
}
//---------------------------------------------------------------------------------------------------------
//-----------------------------------------------Tested----------------------------------------------------
function readURLMultiple(input) {
    if (input.files) {
        var filesAmount = input.files.length;
        for (i = 0; i < filesAmount; i++) {
            var reader = new FileReader();
            reader.onload = function (event) {
                $($.parseHTML('<img>')).attr('src', event.target.result).appendTo('#gallery');
            }
            reader.readAsDataURL(input.files[i]);
        }
    }
}
//-----------------------------------------------------------------------------------------------------------