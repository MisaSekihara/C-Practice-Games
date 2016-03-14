window.onload = function() {
    Game.start();
    ReadName();
}

var Game = {
    start : function() {
        Crafty.init(500, 350, document.getElementById("game"));
        Crafty.background("blue");
        }
    }

var ReadName = function() {
    alert('<%= Name  %>');
}