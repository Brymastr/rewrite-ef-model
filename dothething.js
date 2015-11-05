var readline = require('readline');
var fs = require('fs');

var inputFile = 'Lot.cs';
var outputFile = 'output.cs';

var rl = readline.createInterface({
    input: fs.createReadStream(inputFile)
});

rl.on('line', function(line) {
    console.log('Line from file: ', line);
});