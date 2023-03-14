// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// close _MessageResult alert


$(document).ready(function () {
    // Get the current page URL
    var url = window.location.href;
    // Loop through each navigation item
    $('.nav-link').each(function () {
        // Get the URL of the navigation item
        var navUrl = $(this).attr('href');
        // Check if the current page URL matches the navigation URL
        if (url.includes(navUrl)) {
            // Add the "active" class to the navigation item and show the circle
            $(this).addClass('active');
            $(this).parent().find('.selected-circle').css('opacity', '1');
        }
    });

    // Handle click events on the navigation items
    $('.nav-link').click(function (e) {
        e.preventDefault();
        $('.nav-link').removeClass('active');
        $('.selected-circle').css('opacity', '0');
        $(this).addClass('active');
        $(this).parent().find('.selected-circle').css('opacity', '1');
        window.location.href = $(this).attr('href');
    });

    $('.close-alert').click(function () {
        $('.alert').hide('hide');
    });

    $('#menu-bar').Load("Home/GetMenuBar"); 

});