
hr(1);

/* Fuction declarations hoisting */
functionDeclaration();

function functionDeclaration() {
    console.log('functionDeclaration');
}

/* Function expressions not hoisting */
try 
{
    fucntionExpression();
}
catch(e) {
    console.log(e);
}

var fucntionExpression = function() {
    console.log('fucntionExpression');
}

hr(1);

var arrowFunction = (p) => {
    console.log(p);
};

arrowFunction(111);