﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function generateNumbers(numberAmount) {

    var numbers = "";

    for (var i = 0; i < numberAmount; i++) {
        numbers += Math.floor(Math.random() * 10);
    }
    return numbers;
}