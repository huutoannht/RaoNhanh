/*
 * Created by Pixel-Mafia
 * www.pixel-mafia.com
*/
"use strict";
var	html = jQuery('html'),
	photobooth_split_gallery_wrapper = jQuery('.photobooth_split_showcase_wrapper'),
	photobooth_split_gallery = jQuery('.photobooth_split_showcase'),
	photobooth_split_slide = jQuery('.photobooth_split_slide'),
	even_max_slide = jQuery('.photobooth_even_slide').length,
	odd_max_slide = jQuery('.photobooth_odd_slide').length;

var lastChange = +new Date();
	
if (jQuery('.photobooth_split_showcase_wrapper').length > 0) {
	jQuery(document.documentElement).keyup(function (event) {
		if ((event.keyCode == 40)) {
			photobooth_split_prevSlide();				
		}
		if ((event.keyCode == 38)) {
			photobooth_split_nextSlide();
		}
	});
}
	
jQuery(document).ready(function ($) {
	//photobooth_preloader();
	html.addClass('photobooth_split_gallery_page').addClass('photobooth_transparent_header');
	
	jQuery('.photobooth_split_btn_prev').on('click', function () {
		photobooth_split_prevSlide();		
	});
	jQuery('.photobooth_split_btn_next').on('click', function () {
		photobooth_split_nextSlide();
	});

	//Touch Events
	photobooth_split_gallery.on("swipeleft", function () {
		if (!photobooth_split_gallery_wrapper.hasClass('fullview')) {
			jQuery('.photobooth_split_even_current').addClass('slide_fullview');
			photobooth_split_gallery_wrapper.addClass('fullview');
		} else {
			jQuery('.photobooth_split_even_current').removeClass('slide_fullview');
			jQuery('.photobooth_split_odd_current').removeClass('slide_fullview');
			photobooth_split_gallery_wrapper.removeClass('fullview');
		}
	});
	photobooth_split_gallery.on("swiperight", function () {
		if (!photobooth_split_gallery_wrapper.hasClass('fullview')) {
			jQuery('.photobooth_split_odd_current').addClass('slide_fullview');
			photobooth_split_gallery_wrapper.addClass('fullview');
		} else {
			jQuery('.photobooth_split_even_current').removeClass('slide_fullview');
			jQuery('.photobooth_split_odd_current').removeClass('slide_fullview');
			photobooth_split_gallery_wrapper.removeClass('fullview');
		}
	});
	photobooth_split_gallery.on("swipeup", function () {
		photobooth_split_nextSlide();
	});
	photobooth_split_gallery.on("swipedown", function () {
		photobooth_split_prevSlide();
	});

	photobooth_split_gallery.on('mousewheel', function(event) {
	    if(+new Date() - lastChange > 100){
			var half_screen = jQuery(window).width()/2;
			if (event.deltaY < 0) {
				if (event.pageX <= half_screen) {
					photobooth_split_nextSlide();
				} else {
					photobooth_split_prevSlide();
				}
			}
			if (event.deltaY > 0) {
				if (event.pageX <= half_screen) {
					photobooth_split_prevSlide();
				} else {
					photobooth_split_nextSlide();
				}
			}
			lastChange = +new Date();
		} else {
			lastChange = +new Date();
		}
	});	
});

jQuery(window).resize(function () {
	setup_photobooth_split_gallery();
});

jQuery(document).on("click", ".photobooth_split_slide", function() {
	jQuery(this).toggleClass('slide_fullview');
	photobooth_split_gallery_wrapper.toggleClass('fullview');
});

function photobooth_split_prevSlide() {
	if (!photobooth_split_gallery_wrapper.hasClass('fullview') && !photobooth_split_gallery.hasClass('now_animate')) {
		if (even_max_slide < 5 && odd_max_slide < 5) {
			photobooth_split_gallery.addClass('prev_power');
		}
		var cur_slide_even = parseInt(jQuery('.photobooth_split_even_current').attr('data-count'), 10);
		var cur_slide_odd = parseInt(jQuery('.photobooth_split_odd_current').attr('data-count'), 10);
	
		cur_slide_even--;
		cur_slide_odd--;
		
		var even_max_slide = jQuery('.photobooth_even_slide').length,
			odd_max_slide = jQuery('.photobooth_odd_slide').length;
	
		if (cur_slide_even > even_max_slide) cur_slide_even = 1;
		if (cur_slide_even < 1) cur_slide_even = even_max_slide;
	
		if (cur_slide_odd > odd_max_slide) cur_slide_odd = 1;
		if (cur_slide_odd < 1) cur_slide_odd = odd_max_slide;
	
		set_photobooth_split_Slide(cur_slide_even,cur_slide_odd);
	}
}

function photobooth_split_nextSlide() {	
	if (!photobooth_split_gallery_wrapper.hasClass('fullview') && !photobooth_split_gallery.hasClass('now_animate')) {
		if (even_max_slide < 5 && odd_max_slide < 5) {
			photobooth_split_gallery.addClass('next_power');
		}
		var cur_slide_even = parseInt(jQuery('.photobooth_split_even_current').attr('data-count'), 10);
		var cur_slide_odd = parseInt(jQuery('.photobooth_split_odd_current').attr('data-count'), 10);
	
		cur_slide_even++;
		cur_slide_odd++;
		
		var even_max_slide = jQuery('.photobooth_even_slide').length,
			odd_max_slide = jQuery('.photobooth_odd_slide').length;
	
		if (cur_slide_even > even_max_slide) cur_slide_even = 1;
		if (cur_slide_even < 1) cur_slide_even = even_max_slide;
	
		if (cur_slide_odd > odd_max_slide) cur_slide_odd = 1;
		if (cur_slide_odd < 1) cur_slide_odd = odd_max_slide;
	
		set_photobooth_split_Slide(cur_slide_even,cur_slide_odd);
	}
}

function set_photobooth_split_Slide(slideNumEven,slideNumOdd) {
	photobooth_split_gallery.addClass('now_animate');
	slideNumEven = parseInt(slideNumEven, 10);
	slideNumOdd = parseInt(slideNumOdd, 10);
	if (even_max_slide < 5 && odd_max_slide < 5) {
		jQuery('.photobooth_split_even_prev').removeClass('photobooth_split_even_prev');
		jQuery('.photobooth_split_even_current').removeClass('photobooth_split_even_current');
		jQuery('.photobooth_split_even_next').removeClass('photobooth_split_even_next');

		jQuery('.photobooth_split_odd_prev').removeClass('photobooth_split_odd_prev');
		jQuery('.photobooth_split_odd_current').removeClass('photobooth_split_odd_current');
		jQuery('.photobooth_split_odd_next').removeClass('photobooth_split_odd_next');
		
		var curSlideEven = jQuery('.photobooth_even_slide'+slideNumEven);
		var curSlideOdd = jQuery('.photobooth_odd_slide'+slideNumOdd);
		curSlideEven.addClass('photobooth_split_even_current');
		curSlideOdd.addClass('photobooth_split_odd_current');

		//EVEN
		if((parseInt(slideNumEven, 10)+1) > even_max_slide) {
			var nextSlideEven = jQuery('.photobooth_even_slide1');
		} else if ((parseInt(slideNumEven, 10)+1) == even_max_slide){
			var nextSlideEven = jQuery('.photobooth_even_slide'+even_max_slide);
		} else {
			var nextSlideEven = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)+1));
		}
		
		if((parseInt(slideNumEven, 10)-1) < 1) {
			var prevSlideEven = jQuery('.photobooth_even_slide'+even_max_slide);
		} else if ((slideNumEven-1) == 1){
			var prevSlideEven = jQuery('.photobooth_even_slide1');
		} else {
			var prevSlideEven = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)-1));
		}

		prevSlideEven.addClass('photobooth_split_even_prev');
		nextSlideEven.addClass('photobooth_split_even_next');
		
		//ODD
		if((parseInt(slideNumOdd, 10)+1) > odd_max_slide) {
			var nextSlideOdd = jQuery('.photobooth_odd_slide1');
		} else if ((parseInt(slideNumOdd, 10)+1) == odd_max_slide){
			var nextSlideOdd = jQuery('.photobooth_odd_slide'+odd_max_slide);
		} else {
			var nextSlideOdd = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)+1));
		}
		
		if((parseInt(slideNumOdd, 10)-1) < 1) {
			var prevSlideOdd = jQuery('.photobooth_odd_slide'+odd_max_slide);
		} else if ((slideNumOdd-1) == 1){
			var prevSlideOdd = jQuery('.photobooth_odd_slide1');
		} else {
			var prevSlideOdd = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)-1));
		}

		prevSlideOdd.addClass('photobooth_split_odd_prev');
		nextSlideOdd.addClass('photobooth_split_odd_next');
		
		setTimeout("photobooth_split_gallery.removeClass('prev_power')",500);
		setTimeout("photobooth_split_gallery.removeClass('next_power')",500);
		
	} else {
		jQuery('.photobooth_split_even_prev2').removeClass('photobooth_split_even_prev2');
		jQuery('.photobooth_split_even_prev').removeClass('photobooth_split_even_prev');
		jQuery('.photobooth_split_even_current').removeClass('photobooth_split_even_current');
		jQuery('.photobooth_split_even_next').removeClass('photobooth_split_even_next');
		jQuery('.photobooth_split_even_next2').removeClass('photobooth_split_even_next2');

		jQuery('.photobooth_split_odd_prev2').removeClass('photobooth_split_odd_prev2');
		jQuery('.photobooth_split_odd_prev').removeClass('photobooth_split_odd_prev');
		jQuery('.photobooth_split_odd_current').removeClass('photobooth_split_odd_current');
		jQuery('.photobooth_split_odd_next').removeClass('photobooth_split_odd_next');
		jQuery('.photobooth_split_odd_next2').removeClass('photobooth_split_odd_next2');
		
		var curSlideEven = jQuery('.photobooth_even_slide'+slideNumEven);
		var curSlideOdd = jQuery('.photobooth_odd_slide'+slideNumOdd);
		curSlideEven.addClass('photobooth_split_even_current');
		curSlideOdd.addClass('photobooth_split_odd_current');

		//EVEN
		if((parseInt(slideNumEven, 10)+1) > even_max_slide) {
			var nextSlideEven = jQuery('.photobooth_even_slide1');
			var nextSlideEven2 = jQuery('.photobooth_even_slide2');
		} else if ((parseInt(slideNumEven, 10)+1) == even_max_slide){
			var nextSlideEven = jQuery('.photobooth_even_slide'+even_max_slide);
			var nextSlideEven2 = jQuery('.photobooth_even_slide1');
		} else {
			var nextSlideEven = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)+1));
			var nextSlideEven2 = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)+2));
		}
		
		if((parseInt(slideNumEven, 10)-1) < 1) {
			var prevSlideEven = jQuery('.photobooth_even_slide'+even_max_slide);
			var prevSlideEven2 = jQuery('.photobooth_even_slide'+(even_max_slide-1));
		} else if ((slideNumEven-1) == 1){
			var prevSlideEven = jQuery('.photobooth_even_slide1');
			var prevSlideEven2 = jQuery('.photobooth_even_slide'+even_max_slide);
		} else {
			var prevSlideEven = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)-1));
			var prevSlideEven2 = jQuery('.photobooth_even_slide'+(parseInt(slideNumEven, 10)-2));
		}

		prevSlideEven2.addClass('photobooth_split_even_prev2');
		prevSlideEven.addClass('photobooth_split_even_prev');
		nextSlideEven.addClass('photobooth_split_even_next');
		nextSlideEven2.addClass('photobooth_split_even_next2');
		
		//ODD
		if((parseInt(slideNumOdd, 10)+1) > odd_max_slide) {
			var nextSlideOdd = jQuery('.photobooth_odd_slide1');
			var nextSlideOdd2 = jQuery('.photobooth_odd_slide2');
		} else if ((parseInt(slideNumOdd, 10)+1) == odd_max_slide){
			var nextSlideOdd = jQuery('.photobooth_odd_slide'+odd_max_slide);
			var nextSlideOdd2 = jQuery('.photobooth_odd_slide1');
		} else {
			var nextSlideOdd = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)+1));
			var nextSlideOdd2 = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)+2));
		}
		
		if((parseInt(slideNumOdd, 10)-1) < 1) {
			var prevSlideOdd = jQuery('.photobooth_odd_slide'+odd_max_slide);
			var prevSlideOdd2 = jQuery('.photobooth_odd_slide'+(odd_max_slide-1));
		} else if ((slideNumOdd-1) == 1){
			var prevSlideOdd = jQuery('.photobooth_odd_slide1');
			var prevSlideOdd2 = jQuery('.photobooth_odd_slide'+odd_max_slide);
		} else {
			var prevSlideOdd = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)-1));
			var prevSlideOdd2 = jQuery('.photobooth_odd_slide'+(parseInt(slideNumOdd, 10)-2));
		}

		prevSlideOdd2.addClass('photobooth_split_odd_prev2');
		prevSlideOdd.addClass('photobooth_split_odd_prev');
		nextSlideOdd.addClass('photobooth_split_odd_next');
		nextSlideOdd2.addClass('photobooth_split_odd_next2');		
	}
	setTimeout("photobooth_split_gallery.removeClass('now_animate')",800);
}
function setup_photobooth_split_gallery() {
	if (jQuery('.photobooth_even_slide').length == 1) {
		photobooth_split_gallery_wrapper.addClass('even_alone');
	}	 
	if (jQuery('.photobooth_odd_slide').length == 1) {
		photobooth_split_gallery_wrapper.addClass('odd_alone');
	}


	
	
	var set_height = photobooth_window.height(),
		set_top = 0;
		
	photobooth_split_gallery_wrapper.css('top', set_top+'px').height(set_height);
	photobooth_split_gallery.height(set_height).css('top', set_top+'px');	
	photobooth_split_slide.height(set_height);
	if (photobooth_split_gallery.hasClass('started')) {
		if (jQuery('.photobooth_split_even_current').length > 0 && jQuery('.photobooth_split_odd_current').length > 0) {
			var cur_slide_even = parseInt(jQuery('.photobooth_split_even_current').attr('data-count'), 10);
			var cur_slide_odd = parseInt(jQuery('.photobooth_split_odd_current').attr('data-count'), 10);
			set_photobooth_split_Slide(cur_slide_even,cur_slide_odd);
		} else {
			set_photobooth_split_Slide(1,1);
		}
	}
}
function run_photobooth_split_slider() {
	photobooth_split_gallery.addClass('started')
	setup_photobooth_split_gallery();
}