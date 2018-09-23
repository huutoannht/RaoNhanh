/*
 * Created by Pixel-Mafia
 * www.pixel-mafia.com
*/
"use strict";
var	html = jQuery('html'),
	photobooth_fullscreen_slider = jQuery('.photobooth_fullscreen_slider'),
	photobooth_fullscreen_slider_wrapper = jQuery('.photobooth_fullscreen_slider_wrapper'),
	photobooth_fullscreen_title_wrapper = jQuery('.photobooth_slideshow_title_wrapper'),
	photobooth_fullscreen_title = jQuery('.photobooth_slideshow_title'),
	photobooth_fullscreen_descr = jQuery('.photobooth_slideshow_caption'),
	photobooth_fullscreen_controls = jQuery('.photobooth_fullscreen_controls'),
	max_slide = photobooth_fullscreen_slider.find('.photobooth_fullscreen_slide').length,
	photobooth_thumbs = jQuery('.photobooth_fullscreen_thumbs_wrapper');

/* Start Sldier */
if (jQuery('.photobooth_fullscreen_slider').length > 0) {
	jQuery(document.documentElement).keyup(function (event) {
		if ((event.keyCode == 37)) {
			photobooth_fullscreen_prevSlide();
		} else if ((event.keyCode == 39)) {
			photobooth_fullscreen_nextSlide();
		}
	});
}
var photobooth_fullscreen_interval = setInterval('photobooth_fullscreen_nextSlide()', photobooth_fullscreen_slider.attr('data-interval'));
clearInterval(photobooth_fullscreen_interval);
jQuery('.photobooth_fullscreen_play_pause').removeClass('photobooth_fullscreen_state_play');

jQuery(document).ready(function ($) {
	if (jQuery('.photobooth_fullscreen_slider').length > 0) {
		//photobooth_preloader();
		html.addClass('photobooth_fullscreen_slider').addClass('photobooth_transparent_header');;
		if (photobooth_fullscreen_slider.attr('data-nav') == 'thumbs') {
			html.addClass('photobooth_slider_w_thumbs');
		} else {
			html.addClass('photobooth_slider_w_arrows');
		}
		jQuery('.photobooth_fullscreen_slider_prev').on('click', function () {
			photobooth_fullscreen_prevSlide();
		});
		jQuery('.photobooth_fullscreen_slider_next').on('click', function () {
			photobooth_fullscreen_nextSlide();
		});
		jQuery('.photobooth_fullscreen_controls_toggler').on('click', function () {
			html.toggleClass('photobooth_fullscreen_fullview');
		});
		jQuery('.photobooth_fullscreen_thmb').on('click', function () {
			photobooth_setSlide(jQuery(this).attr('data-count'));
		});
		
		
		jQuery('.photobooth_fullscreen_play_pause').on('click', function(){
			if (jQuery(this).hasClass('photobooth_state_play')) {
				clearInterval(photobooth_fullscreen_interval);
			} else {
				photobooth_fullscreen_interval = setInterval('photobooth_fullscreen_nextSlide()', photobooth_fullscreen_slider.attr('data-interval'));
			}
			jQuery('.photobooth_fullscreen_play_pause').toggleClass('photobooth_state_play');
		});

		//Touch Events
		var touch_container = photobooth_fullscreen_slider;
		touch_container.on("swipeleft", function () {
			photobooth_fullscreen_nextSlide();
		});
		touch_container.on("swiperight", function () {
			photobooth_fullscreen_prevSlide();
		});
		var set_step = 0;
		 // photobooth_setGalleryContainer();
	}
	
});

jQuery(window).resize(function () {
	// if (jQuery('.photobooth_fullscreen_slider').length > 0) {
	// 	photobooth_setGalleryContainer(jQuery('.photobooth_fullscreen_gallery_container'));
	// }
});

function photobooth_fullscreen_prevSlide() {
	var cur_slide = parseInt(jQuery('.current-slide').attr('data-count'), 10);
	cur_slide--;
	var max_slide = photobooth_fullscreen_slider.find('.photobooth_fullscreen_slide').length;
	if (cur_slide > max_slide) cur_slide = 1;
	if (cur_slide < 1) cur_slide = max_slide;	
	photobooth_setSlide(cur_slide);
}

function photobooth_fullscreen_nextSlide() {
	var cur_slide = parseInt(jQuery('.current-slide').attr('data-count'), 10);
	cur_slide++;
	var max_slide = photobooth_fullscreen_slider.find('.photobooth_fullscreen_slide').length;
	if (cur_slide > max_slide) cur_slide = 1;
	if (cur_slide < 1) cur_slide = max_slide;
	photobooth_setSlide(cur_slide);
}

function photobooth_setSlide(slideNum) {
	clearInterval(photobooth_fullscreen_interval);
	var slideNum = parseInt(slideNum, 10);
	jQuery('.prev-slide').removeClass('prev-slide');
	jQuery('.current-slide').removeClass('current-slide');
	jQuery('.next-slide').removeClass('next-slide');

	if((parseInt(slideNum, 10)+1) > max_slide) {
		var nextSlide = jQuery('.photobooth_fullscreen_slide1');
	} else if ((parseInt(slideNum, 10)+1) == max_slide){
		var nextSlide = jQuery('.photobooth_fullscreen_slide'+max_slide);
	} else {
		var nextSlide = jQuery('.photobooth_fullscreen_slide'+(parseInt(slideNum, 10)+1));
	}
	
	if((parseInt(slideNum, 10)-1) < 1) {
		var prevSlide = jQuery('.photobooth_fullscreen_slide'+max_slide);
	} else if ((slideNum-1) == 1){
		var prevSlide = jQuery('.photobooth_fullscreen_slide1');
	} else {
		var prevSlide = jQuery('.photobooth_fullscreen_slide'+(parseInt(slideNum, 10)-1));
	}

	prevSlide.addClass('prev-slide');
	var curSlide = jQuery('.photobooth_fullscreen_slide'+slideNum);
	
	curSlide.addClass('current-slide');
	nextSlide.addClass('next-slide');
	
	if (prevSlide.find('iframe').length > 0) {
		prevSlide.find('iframe').remove();
	}
	if (nextSlide.find('iframe').length > 0) {
		nextSlide.find('iframe').remove();
	}
	if (prevSlide.find('div').length > 0) {
		prevSlide.find('div').remove();
	}
	if (nextSlide.find('div').length > 0) {
		nextSlide.find('div').remove();
	}
	photobooth_fullscreen_title_wrapper.fadeOut(500, function () {
		setTimeout("photobooth_fullscreen_title.html(jQuery('.current-slide').attr('data-title'))",100);
		setTimeout("photobooth_fullscreen_descr.html(jQuery('.current-slide').attr('data-descr'))",100);
		setTimeout("photobooth_fullscreen_title_wrapper.fadeIn(500)",200);
	});
	curSlide.attr('style', 'background:url(' + curSlide.attr('data-src') + ') no-repeat;');
	nextSlide.attr('style', 'background:url(' + nextSlide.attr('data-src') + ') no-repeat;');
	prevSlide.attr('style', 'background:url(' + prevSlide.attr('data-src') + ') no-repeat;');

	if (!prevSlide.hasClass('was_showed')) {
		prevSlide.addClass('was_showed');
	}
	if (!curSlide.hasClass('was_showed')) {
		curSlide.addClass('was_showed');
	}
	if (!nextSlide.hasClass('was_showed')) {
		nextSlide.addClass('was_showed');
	}
	
	if (photobooth_thumbs.length > 0) {
		if (max_slide < 5) {
			if (!jQuery('.photobooth_fullscreen_thumbs_wrapper').hasClass('photobooth_three_thumbs')) {
				jQuery('.photobooth_fullscreen_thumbs_wrapper').addClass('photobooth_three_thumbs');
			}
			jQuery('.photobooth_thmb_prev').removeClass('photobooth_thmb_prev');
			jQuery('.photobooth_thmb_current').removeClass('photobooth_thmb_current');
			jQuery('.photobooth_thmb_next').removeClass('photobooth_thmb_next');
			
			var curSlide = jQuery('.photobooth_fullscreen_thmb'+slideNum);
			curSlide.addClass('photobooth_thmb_current');
	
			if((parseInt(slideNum, 10)+1) > max_slide) {
				var nextSlide = jQuery('.photobooth_fullscreen_thmb1');
			} else if ((parseInt(slideNum, 10)+1) == max_slide){
				var nextSlide = jQuery('.photobooth_fullscreen_thmb'+max_slide);
			} else {
				var nextSlide = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)+1));
			}
			
			if((parseInt(slideNum, 10)-1) < 1) {
				var prevSlide = jQuery('.photobooth_fullscreen_thmb'+max_slide);
			} else if ((slideNum-1) == 1){
				var prevSlide = jQuery('.photobooth_fullscreen_thmb1');
			} else {
				var prevSlide = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)-1));
			}
	
			prevSlide.addClass('photobooth_thmb_prev');
			curSlide.addClass('photobooth_thmb_current');
			nextSlide.addClass('photobooth_thmb_next');

		} else {
			jQuery('.photobooth_thmb_prev2').removeClass('photobooth_thmb_prev2');
			jQuery('.photobooth_thmb_prev').removeClass('photobooth_thmb_prev');
			jQuery('.photobooth_thmb_current').removeClass('photobooth_thmb_current');
			jQuery('.photobooth_thmb_next').removeClass('photobooth_thmb_next');
			jQuery('.photobooth_thmb_next2').removeClass('photobooth_thmb_next2');
			
			var curSlide = jQuery('.photobooth_fullscreen_thmb'+slideNum);
			curSlide.addClass('photobooth_thmb_current');
	
			if((parseInt(slideNum, 10)+1) > max_slide) {
				var nextSlide = jQuery('.photobooth_fullscreen_thmb1');
				var nextSlide2 = jQuery('.photobooth_fullscreen_thmb2');
			} else if ((parseInt(slideNum, 10)+1) == max_slide){
				var nextSlide = jQuery('.photobooth_fullscreen_thmb'+max_slide);
				var nextSlide2 = jQuery('.photobooth_fullscreen_thmb1');
			} else {
				var nextSlide = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)+1));
				var nextSlide2 = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)+2));
			}
			
			if((parseInt(slideNum, 10)-1) < 1) {
				var prevSlide = jQuery('.photobooth_fullscreen_thmb'+max_slide);
				var prevSlide2 = jQuery('.photobooth_fullscreen_thmb'+(max_slide-1));
			} else if ((slideNum-1) == 1){
				var prevSlide = jQuery('.photobooth_fullscreen_thmb1');
				var prevSlide2 = jQuery('.photobooth_fullscreen_thmb'+max_slide);
			} else {
				var prevSlide = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)-1));
				var prevSlide2 = jQuery('.photobooth_fullscreen_thmb'+(parseInt(slideNum, 10)-2));
			}
	
			prevSlide2.addClass('photobooth_thmb_prev2');
			prevSlide.addClass('photobooth_thmb_prev');
			curSlide.addClass('photobooth_thmb_current');
			nextSlide.addClass('photobooth_thmb_next');
			nextSlide2.addClass('photobooth_thmb_next2');	
		}
	}
	
	if (jQuery('.photobooth_fullscreen_play_pause').hasClass('photobooth_state_play')) {
		photobooth_fullscreen_interval = setInterval('photobooth_fullscreen_nextSlide()', photobooth_fullscreen_slider.attr('data-interval'));
	}
}

function run_photobooth_fullscreen_slider() {
	photobooth_fullscreen_slider.addClass('started');
	if (photobooth_fullscreen_slider.attr('data-autoplay') == 'yes') {
		jQuery('.photobooth_fullscreen_play_pause').addClass('photobooth_state_play');
		clearInterval(photobooth_fullscreen_interval);
		photobooth_fullscreen_interval = setInterval('photobooth_fullscreen_nextSlide()', photobooth_fullscreen_slider.attr('data-interval'));
	}
	photobooth_setSlide(1);
}

function slide_not_loaded(slide_num) {
	var slide_num = parseInt(slide_num, 10);
	var curSlide = jQuery('.photobooth_fullscreen_slide'+slide_num);
	if (curSlide.attr('data-type') == 'image' && !curSlide.hasClass('photobooth_slide_loaded'))  {
		curSlide.attr('style', 'background:none');
		setTimeout("slide_not_loaded(jQuery('.current-slide').attr('data-count'))",500);	
	} else {
		photobooth_setSlide(slide_num);
	}
}