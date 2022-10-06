$(function () {

    $('#adultPlus').click(function () {
        let currentNum = parseInt($('#adultNum').text())
        currentNum += 1
        $('#adultNum').text(currentNum)
        
    });
    $('#adultMinus').click(function () {
        let currentNum = parseInt($('#adultNum').text())
        if(currentNum > 0) {
            currentNum -= 1
            $('#adultNum').text(currentNum)
        }
        console.log($('#adultNum').text())
    });
    $('#childPlus').click(function () {
        let currentNum = parseInt($('#childNum').text())
        currentNum += 1
        $('#childNum').text(currentNum)
        
    });
    $('#childMinus').click(function () {
        let currentNum = parseInt($('#childNum').text())
        if(currentNum > 0) {
            currentNum -= 1
            $('#childNum').text(currentNum)
        }
    });
    // $('.goPayBtn').
});