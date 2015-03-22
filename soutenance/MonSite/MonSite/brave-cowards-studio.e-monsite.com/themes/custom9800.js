layout.adjustMenu = function()
{   
    //IN HEADER ?
    if($('header .navbar').length > 0)
    {
        var navLeftMargin  = 0;
        var navRightMargin = 0;
        $('header .in-header').each(function(){
            
            var elementWidth = $(this).innerWidth();
            if($(this).is('.pull-right'))
            {
                navRightMargin += elementWidth;
            }
            else if($(this).is('.pull-left'))
            {
                navLeftMargin += elementWidth;
            }
        });
        $('nav').css({
            'margin-left'       : navLeftMargin + 'px',
            'margin-right'      : navRightMargin + 'px'
        })
    }
    
    //IN MENU
    var navCollapseLeftMargin   = 0;
    var navCollapseRightMargin  = 0;
    if($('.navbar .in-menu').length > 0)
    {
        $('.navbar .in-menu').each(function(){
            var elementWidth = $(this).innerWidth();
            if($(this).is('.pull-right'))
            {
                navCollapseRightMargin += elementWidth;
            }
            else if($(this).is('.pull-left'))
            {
                navCollapseLeftMargin += elementWidth;
            }
        });
        $('.navbar .nav-collapse').css({
            'margin-left'       : navCollapseLeftMargin + 'px',
            'margin-right'      : navCollapseRightMargin + 'px'
        })
    }
}
layout.fixMenu = function()
{
    var menu = $('.navbar');
    var menuHeight = menu.outerHeight(true) + 'px';
    var menuMarginTop = menu.css('marginTop');
    var menuTop = menu.offset().top - menuMarginTop.replace('px', '');
    
    if(!menu.hasClass('container'))
        {
        var menuWidth = menu.parent().width();
        menu.css({
            'width'    :   menuWidth
        });
    }
    
    if($('.navbar-affix-clone').length == 0)
    {
        menu.after('<div class="navbar-affix-clone"></div>');  
    }
    $('.navbar-affix-clone').css({
        'height'    :   menuHeight
    });
    $('.navbar').affix({
        offset:     { top: menuTop }
    });
}
layout.adjustColumns = function()
{   
    if($('#content-area #header').length == 1 || $('#content-area .navbar').length == 1)
    {
        $('.content-wrapper').css('height','auto');
    }
    var tallest = 0;
    var minheight = 0;
    $('#main-area > .container > .row-fluid > [class*="span"]').each(function(){
        $(this).removeAttr('style');
        if($(this).innerHeight() > tallest) {
            tallest = $(this).innerHeight();
            minheight = $(this).innerHeight();
        }
    });
    $('#main-area > .container > .row-fluid > [class*="span"]').each(function(){
        $(this).css('height',minheight);
    });
    
    if($('#content-area #header').length == 1 || $('#content-area .navbar').length == 1)
    {
        layout.adjustContent(minheight);
    }

}

layout.adjustContent = function(minheight)
{
    if($('#content-area #header').length == 1)
    {
        minheight -= $('#content-area #header').outerHeight(true);
    }
    if($('#content-area .navbar').length == 1)
    {
        minheight -= $('#content-area .navbar').outerHeight(true);
    }
    $('.content-wrapper').css('height', minheight);
}


$(window).load(function(){
    //MENU
    layout.adjustMenu();
        //FIX MENU
    if($('.navbar.fixed').length == 1)
    {
    layout.fixMenu();
    }
        //CART
        //COLUMNS
    if($('.row-fluid.equalize').length > 0 && $('.row-fluid.equalize > .sidebar').length > 0)
    {
        layout.adjustColumns();
        
        $('#view-item.view-eco .nav-tabs a, #pagination-pages a, #agenda-toolbar a').click(function(){
            layout.adjustColumns();
        });
    }
});

$(window).on("resize", function (){
    //MENU
    layout.adjustMenu();
        //FIX MENU
    if($('.navbar.fixed').length == 1)
    {
    layout.fixMenu();
    }
            //COLUMNS
    if($('.row-fluid.equalize').length > 0 && $('.row-fluid.equalize > .sidebar').length > 0)
    {
        layout.adjustColumns();
    }
})