<head>
    <style type="text/css">
        #answer {
            height: 33px;
            width: 320px;
        }
    </style>
</head>
@Code
    ViewData("Title") = "Game"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>


<p>Correct the below movie title:</p>

<p></p>

<input id="answer" type="text" value="Risky Biscuits" style="font-size: 20px"/>

<p></p>

<button onclick="submitAnswer()">Submit</button>

<p></p>

<button onclick="Reset()">Reset</button>

<p></p>

<p id="check"></p>

<p></p>

<button onclick="apiCall()">api test</button>

<p></p>

<p id="apiTest"></p>

<script>
    function submitAnswer() {
        var result;
        if (answer.value == "Risky Business") {
            result = "Correct";
        } else {
            result = "Incorrect";
        }
        document.getElementById("check").innerHTML = result;
    }
</script>

<script>
    function Reset() {
        var result;
        if (answer.value == "Risky Business") {
            result = "Correct";
        } else {
            result = "Incorrect";
        }
        document.getElementById("check").innerHTML = result;
    }
</script>

<script>

    function apiCall() {

        var randomNumber = Math.floor(Math.random() * 2399999) + 1
        var randomMovie = 'tt' + randomNumber


        $.getJSON('https://www.omdbapi.com/?i=' + encodeURI(randomMovie) + '&apikey=e648f3a').then(function (response) {
            var title = response.Title
            document.getElementById("apiTest").innerHTML = title;
        })
    }



</script>


