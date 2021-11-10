// question 1
console.log("************** ANSWER 1 ***************");

function isPrime(x){
    let total = false;

    for(let y = 2; y <= (x/2); y++){
        if(x < 2){
            total = false;
        }
        else if(x % y == 0){
            total = false;
            y = x;
        }
        else{
            total = true;
        }
    }

    return total;
}

function findPrime(...numbers){
    for(let i = 0; i <= numbers.length; i++){

        if(isPrime(numbers[i])){
            console.log(numbers[i] + " sayısı bir asal sayıdır.")
    
        }
        else{
            console.log(numbers[i] + " sayısı bir asal sayı değildir.")

        }
    }
}

findPrime(3,4,5,7,11,23,24)

// question 2
console.log("************** ANSWER 2 ***************");

function friendsNumbers(numberOne,numberTwo) {
    let sumNumOne = 0;
    let sumNumTwo = 0;

    for(let i = 0; i < numberOne; i++){
        if(numberOne % i == 0){
            sumNumOne = sumNumOne + i;
        }
    }

    for(let i = 0; i < numberTwo; i++){
        if(numberTwo % i == 0){
            sumNumTwo = sumNumTwo + i;
        }
    }

    if(numberOne == sumNumTwo && numberTwo == sumNumOne){
        console.log(numberOne + " ve " + numberTwo + " arkadaş sayılardır.")
    }
    else{
        console.log(numberOne + " ve " + numberTwo + " arkadaş sayılar değildir.")
    }
}

friendsNumbers(220,284);  // arkadaş sayılardır.
friendsNumbers(200,100);  // arkadaş sayılar değildir.

// question 3 
console.log("************** ANSWER 3 ***************");


function perfectNumbers(number){

    for(let ix = 0; ix < number; ix++){
        let totall = 0;
        for(let y = 1; y <= ix; y++){
            if(ix % y == 0){
                totall = totall + y;
            }
        }
        if((totall == 2*ix) && ix >= 2){
            console.log(ix + " sayısı mükemmel bir sayıdır.");
        }
    }

}

perfectNumbers(1000);

// question 3 - my bonus
console.log("************** ANSWER 3-b *************");


function perfectNumbers2(number){
    let total = 0;
    for(let i = 0; i < number; i++){
        if(number % i == 0){
            total = total + i;
        }
    }

    if(number == total){
        console.log(number + " sayısı mükemmel bir sayıdır.");
    }
    else{
        console.log(number + " sayısı mükemmel bir sayı değildir.");
    }
}

perfectNumbers2(28);

//question 4
console.log("************** ANSWER 4 ***************");

function isPrime(x){
    let total = false;

    for(let y = 2; y <= (x/2); y++){
        if(x < 2){
            total = false;
        }
        else if(x % y == 0){
            total = false;
            y = x;
        }
        else{
            total = true;
        }
    }

    return total;
}

function primeNumber(number) {
    for(let i = 0; i <= number; i++){

        if(isPrime(i)){
            console.log(i + " sayısı bir asal sayıdır.")
    
        }
    }

}

primeNumber(1000)