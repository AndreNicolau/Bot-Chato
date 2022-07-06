// get btnStart element from index.html
var btnStart = document.getElementById("btnStart");

// get inpMessage element from index.html
var inpMessage = document.getElementById("inpMessage");

// get inpNumber element from index.html
var inpNumber = document.getElementById("inpNumber");

// btnStart click event
btnStart.addEventListener("click", function () {
	// get message from inpMessage
	var message = inpMessage.value;
	// get number from inpNumber
	var number = inpNumber.value;

	// check if message is empty
	if (message === "") {
		// show error message
		alert("Please enter a message");
		// stop function
		return;
	} else if (number === "" || isNaN(number)) {
		// show error message
		alert("Please enter a number. Characters are not allowed!");
		// stop function
		return;
	}

	// Create <p> element with message
	var p = document.createElement("p");
	p.innerHTML = message;
	// show p element 
	document.body.appendChild(p);
	// delete p element after 3 seconds
	setTimeout(function () {
		document.body.removeChild(p);
    }, 3000);
    
    
});
