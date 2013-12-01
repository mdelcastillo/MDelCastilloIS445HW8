function ReverseText() {
    var reverse = "";
    var s = document.getElementById("inputText").value;
    
    console.log("S: " + s);

    var strArr = s.split(" ");
    console.log("strArr: " + strArr);


    for (var i = strArr.length - 1; i > -1; i--) {
        reverse = reverse + strArr[i] + " ";
        console.log("strArr(" + i + "), Reverse: " + reverse);
    }
    console.log("Reverse: " + reverse);
    document.getElementById("result").value = reverse;
    

}