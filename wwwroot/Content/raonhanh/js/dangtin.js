 $(function() {

     $('.cacdanhmuc li').click(function() {
         $('.cacdanhmuc li').removeClass('active');
         $(this).addClass('active');
         x = $(this).index(); // đếm xem là mình đang click vào phần tử li thứ bao nhiêu trong list
         x = x + 1;
         console.log(x);
         $('.ndchinh li').removeClass('hienthi');
         $('.ndchinh li:nth-child(' + x + ')').addClass('hienthi'); //add class hienthi vào phần tử vừa được click
         // điều kiện để xài được hàm này là số nút phải bằng số nội dung cần click
     });
 })