var readline = require('readline');
var fs = require('fs');

var inputFile = 'OldLot.cs';
var outputFile = 'Lot.cs';

var rl = readline.createInterface({
  input: fs.createReadStream(inputFile),
  output: fs.createWriteStream(outputFile)
});

rl.on('line', function(line) {
  if(line.trim().substr(0, 1) == 'p' && line.trim().substr(-1, 1) == '}') {
    var name = line.trim().split(' ').slice(2, 3);
    var fixedLine = fixLine(name[0], line);
    rl.output.write('\t\t[Column("' + name + '")]\n');
    rl.output.write(fixedLine + '\n');
  } else {
    rl.output.write(line + '\n');
  }
});

var fixLine = function(name, line) {
  var components = name.toString().split('_');
  var newName = "";
  for(var i = 0; i < components.length; i++) {
    newName += components[i].charAt(0).toUpperCase() + components[i].slice(1);
  }

  return line.replace(/\w*_\w*/, newName);
};