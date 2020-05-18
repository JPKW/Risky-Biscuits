﻿<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>

<body>
    <div class="container">
        <h3>Welcome to our movie API project</h3>
        <img src="https://upload.wikimedia.org/wikipedia/commons/a/ac/No_image_available.svg"
             alt="" />
        <hr />
        <button>Click me to generate a new movie</button>
    </div>
</body>
</html>

<script>
    var randomMovieArray = [
        'Star Wars',
        'Game of Thrones',
        'Lord of the Rings',
        'Harry Potter',]

    var randomNumber = Math.floor(Math.random() * randomMovieArray.length)
    var RandomMovie = randomMovieArray[randomNumber]



    function apiCall(RandomMovie) {
        console.log(randomMovie)
        $.getJSON('https://www.omdbapi.com/?t=' + encodeURI(RandomMovie) + 'apikey=e648f3a').then(function (response) {
            console.log(response);
        })
    }





</script>