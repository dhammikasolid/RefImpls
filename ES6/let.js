'use strict'

// -------- Block of code 

var x = 1;

if(true) {
    let x = 2;
    console.log(x); // 2
}

console.log(x); // 1

if (true) {
    var y = 10;
}

console.log(y); // 10

if (true) {

    let z = 20
}

try {
    console.log(z); 
}
catch(e) {
    console.log(e); // Uncaught ReferenceError: z is not defined
}

hr(2);

for (var i = 0; i < 2; i++) {
    console.log(i); // 0, 1
}

console.log(i); // 5

hr(3);

for (let j = 0; j < 2; j++) {
    console.log(j); // 0, 1
}

try {
    console.log(j);
}
catch(e) {
    console.log(e); // Uncaught ReferenceError: j is not defined
}

hr(2);

//---------- Execution Context

(function () {
    var p = 10;
})();

try {
    console.log(p); 
}
catch(e) {
    console.log(e); // Uncaught ReferenceError: p is not defined
}

/* This is core concept of IIFE */




