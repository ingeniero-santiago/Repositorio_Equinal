
$(document).ready(function(){
	var altura = $('.navbar navbar-inverse navbar-static-top').offset().top;
	
	$(window).on('scroll', function(){
		if ( $(window).scrollTop() > altura ){
			$('.navbar navbar-inverse navbar-static-top').addClass('navbar navbar-inverse navbar-static-top-fixed');
		} else {
			$('.navbar navbar-inverse navbar-static-top').removeClass('navbar navbar-inverse navbar-static-top-fixed');
		}
	});
 
});

