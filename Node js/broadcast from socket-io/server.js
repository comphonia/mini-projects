var express = require('express'),
    app = express(),
    http = require('http'),
    socketIO = require('socket.io'),
    fs = require('fs'),
    path = require('path'),
    server, io;

    app.use(express.static(path.join(__dirname, 'public')));

app.get('/', function (req, res) {
    res.sendFile(__dirname + '/index.html');
});

server = http.Server(app);
server.listen(5000);

io = socketIO(server);
var imgChunks = []; //gather chucks and push the array or push `chunk` and gather on the client side
io.on('connection', function (socket) {
    var readStream = fs.createReadStream(path.join(__dirname,'./public/woodchuck.jpg'), {
        encoding: 'binary'
    })

    // readStream.on('readable', function () {
    //     console.log('Image loading');
    // });

    readStream.on('data', function (chunk) {
        console.log('chunk')
        imgChunks.push(chunk);
        socket.emit('img-chunk', imgChunks);
    });

    readStream.on('end', function () {
        console.log('Image loaded');
    });
});
