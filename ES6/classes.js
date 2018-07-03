class A {

    constructor(a, b) {

        this.a = a;
        this.b = b;
        this.q = 10;
    }

    p() {
        console.log(this.a, this.b);
    }

    // get q() {
    //     this.q;
    // }

    // set q(val) {
    //     this.q = val;
    // }
}

$(() => {
    let a = new A(3, 4);

    $('#domelm').click(() => {
        a.p();    
    });
});
