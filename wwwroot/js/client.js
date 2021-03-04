$(function () {
    var toast = new Audio('media/toast.wav');

    $('.code').on('click', function (e) {
        
        e.preventDefault();

        const discountCode = $("#" + e.target.id).attr("data-code");
        const productName = $("#" + e.target.id).attr("data-product");

        $("#product").text("" + productName);
        $("#code").text("" + discountCode);

        // first pause the audio (in case it is still playing)
        toast.pause();
        // reset the audio
        toast.currentTime = 0;
        // play audio
        toast.play();
        $('#toast').toast({ autohide: false }).toast('show');
    });
    
});

$(document).keydown(function (e) {
    // ESCAPE key pressed
    if (e.keyCode == 27) {
        // $(toast).delete(); // this just makes it so that it can never come back
        document.getElementById("closeToast").click();
    }
});
