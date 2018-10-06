i = 10;
while (true) {
    if (isKaibun(i.toString(10)) && isKaibun(i.toString(8)) && isKaibun(i.toString(2))){
        console.log(i);
        break;
    }
    i += 1;
}

function isKaibun(val){
    return val == val.split("").reverse().join("");
}