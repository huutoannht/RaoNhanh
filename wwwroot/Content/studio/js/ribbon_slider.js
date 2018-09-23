/*
 * Created by Pixel-Mafia
 * www.pixel-mafia.com
*/
"use strict";
var	html = jQuery('html'),
	photobooth_ribbon_slider_wrapper = jQuery('.photobooth_ribbon_slider_wrapper'),
	photobooth_ribbon_slider = jQuery('.photobooth_ribbon_slider'),
	photobooth_ribbon_slide = jQuery('.photobooth_ribbon_slide'),
	photobooth_ribbon_title_wrapper = jQuery('.photobooth_ribbon_title_wrapper'),
	photobooth_ribbon_title = jQuery('.photobooth_ribbon_title'),
	photobooth_ribbon_descr = jQuery('.photobooth_ribbon_caption'),
	r_max_slide = photobooth_ribbon_slider.find('.photobooth_ribbon_slide').length;

jQuery(document.documentElement).keyup(function (event) {
	if ((event.keyCode == 37)) {
		//Left Button
		photobooth_ribbon_prevSlide();
	} else if ((event.keyCode == 39)) {
		//Right Button
		photobooth_ribbon_nextSlide();
	}
});

if (photobooth_ribbon_slider.attr('data-interval') !== '' && parseInt(photobooth_ribbon_slider.attr('data-interval'), 10) > 0) {
	var photobooth_ribbon_interval = setInterval('photobooth_ribbon_nextSlide()', parseInt(photobooth_ribbon_slider.attr('data-interval'), 10));
	if (photobooth_ribbon_slider.attr('data-autoplay') == 'yes') {
		jQuery('.photobooth_ribbon_btn_play').removeClass('photobooth_state_pause');
	} else {
		clearInterval(photobooth_ribbon_interval);
	}	
}

jQuery(document).ready(function ($) {
	if (jQuery('.photobooth_ribbon_slider_wrapper').length > 0) {
		photobooth_preloader();
		html.addClass('photobooth_ribbon_slider_page').addClass('photobooth_transparent_header');

		jQuery('.photobooth_ribbon_btn_prev').on('click', function () {
			photobooth_ribbon_prevSlide();
		});
		jQuery('.photobooth_ribbon_btn_next').on('click', function () {
			photobooth_ribbon_nextSlide();
		});		
		jQuery('.photobooth_ribbon_btn_fullview').on('click', function () {
			html.toggleClass('photobooth_ribbon_fullview');
		});		
		jQuery('.photobooth_ribbon_btn_play').on('click', function () {
			jQuery(this).toggleClass('photobooth_state_pause');
			if (jQuery(this).hasClass('photobooth_state_pause')) {
				clearInterval(photobooth_ribbon_interval);
			} else {
				photobooth_ribbon_interval = setInterval('photobooth_ribbon_nextSlide()', parseInt(photobooth_ribbon_slider.attr('data-interval'), 10));
			}
		});		

		//Touch Events
		var touch_container = photobooth_ribbon_slider;
		touch_container.on("swipeleft", function () {
			photobooth_ribbon_nextSlide();
		});
		touch_container.on("swiperight", function () {
			photobooth_ribbon_prevSlide();
		});
	}
});

jQuery(window).on('load', function () {
	if (jQuery('.photobooth_ribbon_slider_wrapper').length > 0) {
		photobooth_ribbon_setup();
	}
});

jQuery(window).resize(function () {
	if (jQuery('.photobooth_ribbon_slider_wrapper').length > 0) {
		photobooth_ribbon_setup();
	}
});

function photobooth_ribbon_prevSlide() {
	var	cur_slide = parseInt(jQuery('.photobooth_ribbon_current').attr('data-count'), 10);
	cur_slide--;
	var	r_max_slide = photobooth_ribbon_slider.find('.photobooth_ribbon_slide').length;
	if (cur_slide > r_max_slide) cur_slide = 1;
	if (cur_slide < 1) cur_slide = r_max_slide;	
	photobooth_set_ribbon_Slide(cur_slide);
}

function photobooth_ribbon_nextSlide() {
	var	cur_slide = parseInt(jQuery('.photobooth_ribbon_current').attr('data-count'), 10);
	cur_slide++;
	var	r_max_slide = photobooth_ribbon_slider.find('.photobooth_ribbon_slide').length;
	if (cur_slide > r_max_slide) cur_slide = 1;
	if (cur_slide < 1) cur_slide = r_max_slide;
	photobooth_set_ribbon_Slide(cur_slide);
}

function photobooth_set_ribbon_Slide(slideNum) {
	var	slideNum = parseInt(slideNum, 10);

	if (photobooth_ribbon_slider.attr('data-interval') !== '' && parseInt(photobooth_ribbon_slider.attr('data-interval'), 10) > 0) {
		clearInterval(photobooth_ribbon_interval);	
	}

	if (r_max_slide < 5) {
		jQuery('.photobooth_ribbon_prev').removeClass('photobooth_ribbon_prev');
		jQuery('.photobooth_ribbon_current').removeClass('photobooth_ribbon_current');
		jQuery('.photobooth_ribbon_next').removeClass('photobooth_ribbon_next');
		
		var curSlide = jQuery('.photobooth_ribbon_slide'+slideNum);
		curSlide.addClass('photobooth_ribbon_current');

		if((parseInt(slideNum, 10)+1) > r_max_slide) {
			var nextSlide = jQuery('.photobooth_ribbon_slide1');
		} else if ((parseInt(slideNum, 10)+1) == r_max_slide){
			var nextSlide = jQuery('.photobooth_ribbon_slide'+r_max_slide);
		} else {
			var nextSlide = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)+1));
		}
		
		if((parseInt(slideNum, 10)-1) < 1) {
			var prevSlide = jQuery('.photobooth_ribbon_slide'+r_max_slide);
		} else if ((slideNum-1) == 1){
			var prevSlide = jQuery('.photobooth_ribbon_slide1');
		} else {
			var prevSlide = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)-1));
		}

		prevSlide.addClass('photobooth_ribbon_prev');
		curSlide.addClass('photobooth_ribbon_current');
		nextSlide.addClass('photobooth_ribbon_next');

		var	mainOffSet = (photobooth_window.width() - curSlide.width()) /2 - parseInt(photobooth_ribbon_slider_wrapper.css('left'), 10);
		var	nextOffset = curSlide.width() + mainOffSet;
		var	prevOffset = mainOffSet - prevSlide.width();
		
		curSlide.css('transform' , 'translateX('+Math.floor(mainOffSet)+'px)'); 
		nextSlide.css('transform' , 'translateX('+Math.floor(nextOffset)+'px)');
		prevSlide.css('transform' , 'translateX('+Math.floor(prevOffset)+'px)');

		ribbon_title.fadeOut(300, function () {
			setTimeout("ribbon_title.html(jQuery('.photobooth_ribbon_current').attr('data-title'))",100);
			setTimeout("ribbon_title.fadeIn(500)",200);
		});
	} else {
		jQuery('.photobooth_ribbon_prev2').removeClass('photobooth_ribbon_prev2');
		jQuery('.photobooth_ribbon_prev').removeClass('photobooth_ribbon_prev');
		jQuery('.photobooth_ribbon_current').removeClass('photobooth_ribbon_current');
		jQuery('.photobooth_ribbon_next').removeClass('photobooth_ribbon_next');
		jQuery('.photobooth_ribbon_next2').removeClass('photobooth_ribbon_next2');
		
		var curSlide = jQuery('.photobooth_ribbon_slide'+slideNum);
		curSlide.addClass('photobooth_ribbon_current');

		if((parseInt(slideNum, 10)+1) > r_max_slide) {
			var nextSlide = jQuery('.photobooth_ribbon_slide1');
			var nextSlide2 = jQuery('.photobooth_ribbon_slide2');
		} else if ((parseInt(slideNum, 10)+1) == r_max_slide){
			var nextSlide = jQuery('.photobooth_ribbon_slide'+r_max_slide);
			var nextSlide2 = jQuery('.photobooth_ribbon_slide1');
		} else {
			var nextSlide = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)+1));
			var nextSlide2 = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)+2));
		}
		
		if((parseInt(slideNum, 10)-1) < 1) {
			var prevSlide = jQuery('.photobooth_ribbon_slide'+r_max_slide);
			var prevSlide2 = jQuery('.photobooth_ribbon_slide'+(r_max_slide-1));
		} else if ((slideNum-1) == 1){
			var prevSlide = jQuery('.photobooth_ribbon_slide1');
			var prevSlide2 = jQuery('.photobooth_ribbon_slide'+r_max_slide);
		} else {
			var prevSlide = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)-1));
			var prevSlide2 = jQuery('.photobooth_ribbon_slide'+(parseInt(slideNum, 10)-2));
		}

		prevSlide2.addClass('photobooth_ribbon_prev2');
		prevSlide.addClass('photobooth_ribbon_prev');
		curSlide.addClass('photobooth_ribbon_current');
		nextSlide.addClass('photobooth_ribbon_next');
		nextSlide2.addClass('photobooth_ribbon_next2');

		var	mainOffSet = (photobooth_window.width() - curSlide.width()) /2 - parseInt(photobooth_ribbon_slider_wrapper.css('left'), 10),
		nextOffset = curSlide.width() + mainOffSet,
		prevOffset = mainOffSet - prevSlide.width(),
		nextOffset2 = nextSlide.width() + nextOffset,
		prevOffset2 = prevOffset - prevSlide2.width();
		
		curSlide.css('transform' , 'translateX('+Math.floor(mainOffSet)+'px)'); 
		nextSlide.css('transform' , 'translateX('+Math.floor(nextOffset)+'px)');
		nextSlide2.css('transform' , 'translateX('+Math.floor(nextOffset2)+'px)');
		prevSlide.css('transform' , 'translateX('+Math.floor(prevOffset)+'px)');
		prevSlide2.css('transform' , 'translateX('+Math.floor(prevOffset2)+'px)');

		photobooth_ribbon_title_wrapper.fadeOut(300, function () {
			setTimeout("photobooth_ribbon_title.html(jQuery('.photobooth_ribbon_current').attr('data-title'))",100);
			setTimeout("photobooth_ribbon_descr.html(jQuery('.photobooth_ribbon_current').attr('data-descr'))",100);
			setTimeout("photobooth_ribbon_title_wrapper.fadeIn(500)",200);
		});		
	}
	if (photobooth_ribbon_slider.hasClass('wait4load')) {
		photobooth_ribbon_slider.removeClass('wait4load');
	}
	if (photobooth_ribbon_slider.attr('data-interval') !== '' && parseInt(photobooth_ribbon_slider.attr('data-interval'), 10) > 0) {		
		if (photobooth_ribbon_slider.attr('data-autoplay') == 'yes' && !jQuery('.photobooth_ribbon_btn_play').hasClass('photobooth_state_pause')) {
			photobooth_ribbon_interval = setInterval('photobooth_ribbon_nextSlide()', parseInt(photobooth_ribbon_slider.attr('data-interval'), 10));
		}	
	}
	
}
function photobooth_ribbon_setup() {
	if (jQuery('#wpadminbar').length > 0) {
		var set_height = photobooth_window.height() - jQuery('#wpadminbar').height(),
			set_top = jQuery('#wpadminbar').height();
	} else {
		var set_height = photobooth_window.height(),
			set_top = 0;
	}	
	photobooth_ribbon_slider_wrapper.css('top', set_top+'px').height(set_height);
	photobooth_ribbon_slider.height(set_height);
	photobooth_ribbon_slide.height(set_height);	
	photobooth_ribbon_slide.each(function(){
		jQuery(this).width(set_height*jQuery(this).attr('data-ratio'));
	});
	if (!photobooth_ribbon_slider.hasClass('wait4load')) {
		var	cur_slide = parseInt(jQuery('.photobooth_ribbon_current').attr('data-count'), 10);
		photobooth_set_ribbon_Slide(cur_slide);
	}
}

function run_photobooth_ribbon_slider() {
	photobooth_ribbon_slider.addClass('started');	
	photobooth_set_ribbon_Slide(1);
	photobooth_ribbon_setup();
}