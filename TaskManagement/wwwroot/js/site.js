/*alert ('hi')*/

//Colors array
//let colors = ['blue', 'yellow', 'black', 'red', 'brown', 'orange'];
let colors = ['info', 'warning', 'danger', 'success'];

//get button
let button = document.getElementById('cardbutton');

//add event listener
button.addEventListener('click', function () {

    //randomizer
    var randomColor = colors[Math.floor(Math.random() * colors.length)]
    //get container
    let container = document.getElementById('container').className = `card bg-${randomColor}`;
    document.getElementById("label").value = randomColor;
    container.style.background = randomColor;
})

//var now = new Date();
//now.setMinutes(now.getMinutes() - now.getTimezoneOffset());
//document.getElementById('dt').value = now.toISOString().slice(0, 16);

var getColor = document.getElementById('getColor').value;
if (getColor.length > 0) {
    let setColor = document.getElementById('container');
    setColor.className = `card bg-${getColor}`
}



