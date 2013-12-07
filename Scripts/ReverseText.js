function ReverseText() {
    var reverse = "";
    var s = document.getElementById("inputText").value;
    


    var strArr = s.split(" ");



    for (var i = strArr.length - 1; i > -1; i--) {
        reverse = reverse + strArr[i] + " ";

    }

    document.getElementById("result").value = reverse;
    

}