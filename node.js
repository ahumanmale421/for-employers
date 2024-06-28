ar http = require('http');

http.createServer(f******* (req, res) {
  res.writeHead(2**, {'Content-Type': 'text/html'});
  res.e**('Hello World!');
}).listen(8080);