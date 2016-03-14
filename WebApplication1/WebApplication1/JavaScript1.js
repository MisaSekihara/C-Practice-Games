// window.addEventListener("keypress", MoveRectangle, false);
// window.addEventListener("keypress", KeyCodeCheck, false);

var proxy;
var context;

window.onload = function () {
    proxy = new RectangleHubProxy();
    proxy.InitRectangle(10, 10);
    proxy.AddTinySquare(64,128);

    var handleMovement = function(e) {
        proxy.MoveRectangle(e);
    };
    
    var handleColour = function () {
        proxy.ChangeColour();
    };

    var handlePickUp = function() {
        proxy.PickUp();
    };

    var selectColour = document.getElementById("colourSelect");
    selectColour.addEventListener("change", handleColour, false);

    window.addEventListener("keypress", handleMovement, false);

    window.addEventListener("keypress", handlePickUp, false);

    StartConnection();
};

var Bubble = function(x, y) {
    this.x = x;
    this.y = y;
    this.size = 20;
    this.colour = "yellow";
    this.image = new Image("img/awa.png");
    this.name = "Something yellow";

    this.draw = function () {
        context.drawImage(this.image, this.x, this.y);
    };
}

var MyRectangle = function(x,y) {
    this.x = x;
    this.y = y;
    this.size = 50;
    this.rectangleColour = "pink";
    this.image = new Image("img/muma.png");

    this.draw = function () {
        context.drawImage(this.image, this.x, this.y);
    };
}

var Tree = function(x, y, src) {
    this.x = x;
    this.x = x;
    this.y = y;
    this.size = 64;
    this.image = new Image(src);

    this.draw = function () {
        context.drawImage(this.image, this.x, this.y);
    };
}

var RectangleHubProxy = function () {
    this.canvas = {};
    context = {};
    this.myRectangle = new MyRectangle(64, 64);
    this.backgroundItems = [];
    this.stuffOnTheFloor = [];
    this.myItem = {};

    this.InitRectangle = function () {
        this.canvas = document.getElementById("canvas");
        context = this.canvas.getContext("2d");
        context.fillStyle = this.myRectangle.rectangleColour;

        // x, y, width, height
        context.fillRect(this.myRectangle.x, this.myRectangle.y, this.myRectangle.size, this.myRectangle.size);

        this.DrawBorder();

        this.AddTrees();
        this.DrawTrees();
    }

    this.SetRectangleX = function (newX) {
        this.myRectangle.x = newX;
    }

    this.SetRectangleY = function (newY) {
        this.myRectangle.y = newY;
    }

    this.DrawBorder = function() {
        context.strokeStyle = "black";
        context.lineWidth = 2;
        context.strokeRect(0, 0, this.canvas.width, this.canvas.height);
    }

    // add trees to the screen boundary
    this.AddTrees = function () {
        var usualSize = new Tree(0, 0, "img/tree.png").size;
        var xMax = this.canvas.width - usualSize;
        var yMax = this.canvas.height - usualSize;

        for (var i = 0; i <= xMax; i += usualSize) {
            for (var j = 0; j <= yMax; j += usualSize) {
                if (i == 0 || j == 0 || i == xMax || j == yMax) {
                    var tree = new Tree(i, j);
                    this.stuffOnTheFloor.push(tree);
                    console.log("tree added");
                }
            }
        }
    }

    this.DrawTrees = function() {
        for (var i = 0; i < this.stuffOnTheFloor.length; i++) {
            var tree = this.stuffOnTheFloor[i];
            try {
                tree.draw();
            }
            catch (err) {
                context.fillStyle = "green";
                context.fillRect(tree.x, tree.y, tree.size, tree.size);
            }
        }
    }

    this.ClearCanvas = function() {
        context.clearRect(0, 0, canvas.width, canvas.height);
    }

    this.ReloadRectangle = function () {
        this.ClearCanvas();
        this.DrawBorder();
        this.DrawTrees();
        this.ReloadStuffOnTheFloor();
        context.fillStyle = this.myRectangle.rectangleColour;
        context.fillRect(this.myRectangle.x, this.myRectangle.y, this.myRectangle.size, this.myRectangle.size);
    };

    this.ChangeColour = function () {
        var colourList = document.getElementById("colourSelect");
        var selectedColour = colourList.selectedIndex;

        this.rectangleColour = colourList[selectedColour].text;
        context.fillStyle = this.myRectangle.rectangleColour;
        context.fillRect(this.myRectangle.x, this.myRectangle.y, this.myRectangle.size, this.myRectangle.size);
        window.connection.server.changeColour(this.rectangleColour);
    };

    this.ReceiveColourChange = function(colour) {
        this.myRectangle.rectangleColour = colour;
        this.ReloadRectangle();
    }

    this.ValidateMove = function(x,y) {
        for (var i = 0; i < this.backgroundItems.length; i++) {
            var bgitem = this.backgroundItems[i];
            if (bgitem.x == x || bgitem.y == y) {
                return false;
            }
        }
        return true;
    }

    this.MoveRectangle = function (e) {
        var canMove = false;

        if (e.keyCode === 37) {
            this.myRectangle.x -= 10;
            canMove = this.ValidateMove(this.myRectangle.x, this.myRectangle.y);
            // left
        }
        else if (e.keyCode === 39) {
            this.myRectangle.x += 10;
            canMove = this.ValidateMove(this.myRectangle.x, this.myRectangle.y);
            // right
        }
        else if (e.keyCode === 38) {
            this.myRectangle.y -= 10;
            canMove = this.ValidateMove(this.myRectangle.x, this.myRectangle.y);
            // down
        }
        else if (e.keyCode === 40) {
            this.myRectangle.y += 10;
            canMove = this.ValidateMove(this.myRectangle.x, this.myRectangle.y);
            // up
        }

        if (canMove) {
            window.connection.server.changePosition(this.myRectangle.x, this.myRectangle.y);
        }

        this.ReloadRectangle();
        return canMove;
    }

    this.ReceiveMoveRectangle = function(x, y) {
        this.myRectangle.x = x;
        this.myRectangle.y = y;
        this.ReloadRectangle();
    }

    this.AddTinySquare = function (x,y) {
        var item = new Bubble(x, y);
        context.fillStyle = item.colour;
        context.fillRect(item.x, item.y, item.size, item.size);

        this.stuffOnTheFloor.push(item);
    }

    this.ReloadStuffOnTheFloor = function () {
        for (var index = 0; index <= this.stuffOnTheFloor.length-1; index++) {
            var item = this.stuffOnTheFloor[index];
            context.fillStyle = item.colour;
            context.fillRect(item.x, item.y, item.size, item.size);
        }
    }

    this.RemoveItem = function (name) {
        var deleteThisItemIndex = this.stuffOnTheFloor.indexOf(name);

        this.stuffOnTheFloor.splice(deleteThisItemIndex, 1);
        context.clearRect(this.myItem.x, this.myItem.y, this.myItem.size, this.myItem.size);
    }

    this.PickUp = function ()
    {
        for (var index = 0; index <= this.stuffOnTheFloor.length-1; index++) {
            if (this.myRectangle.x == this.stuffOnTheFloor[index].x) {
                if (this.myRectangle.y == this.stuffOnTheFloor[index].y) {
                    console.log("Found something");
                    this.myItem = this.stuffOnTheFloor[index];
                    window.connection.server.pickUpItem(this.myItem.name);

                    this.RemoveItem(this.myItem.name);
                }
            }
        }
    }

    this.ReceivePickUp = function(name) {
        this.myItem = name;
        var itemList = document.getElementById("itemList");
        itemList.innerHTML = itemList.innerHTML + name;
        this.RemoveItem(name);
        console.log("I have " + name);
    }
}

function KeyCodeCheck(e) {
    alert(e.keyCode);
}


function StartConnection() {
    window.connection = $.connection.rectangleHub;

    function init() {
        window.connection.server.initializeGame().done(function() {
            window.connection.server.getMainCharacter().done(function (main) {
                console.log(main.Name);
            });

            window.connection.server.getItem().done(function (item) {
                console.log(item.name);
            });
        });
    }

    window.connection.client.broadcastColourChange = function (colour) {
        proxy.ReceiveColourChange(colour);
    }

    window.connection.client.broadcastPositionChange = function (x, y) {
        proxy.ReceiveMoveRectangle(x, y);
    }

    window.connection.client.broadcastItemPickUp = function (name) {
        proxy.ReceivePickUp(name);
    }

    $.connection.hub.start().done(function () {
        init();
    });
}

