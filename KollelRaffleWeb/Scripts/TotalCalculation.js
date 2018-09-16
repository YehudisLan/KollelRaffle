$(() => {
    console.log("hello");
    $(".num-tickets").on('blur', function() {

        const numSheitel = $("#eighteen").val() * 18;
        const numCash = $("#thirty-six").val() * 36;
        const sheitelbulk = $("#sheitel-hundred").val();
        const timesHundred = sheitelbulk * 100;
        const cashBulk = $("#cash-hundred").val() * 100;
        const total = numSheitel + numCash + timesHundred + cashBulk;
       
        //console.log(cashBulk);
        //const work = cashBulk * 100;
        //console.log("hello");
        //const total = numSheitel + numCash + sheitelbulk + work;
        
        $("#btn-submit").text(total);
        console.log(total);

    });
    //$(".tickets").on('blur', function () {

    //    const numSheitel = $("#eighteen").val() * 18;
    //    const numCash = $("#thirty-six").val() * 36;
    //    const total = numSheitel + numCash;
    //    $(".btn.total").text(total);
    //});

  //make submit only enabled when payment type is selected
});