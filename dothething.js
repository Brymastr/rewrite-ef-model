var readline = require('readline');
var fs = require('fs');

var inputFile = 'OldLot.cs';
var outputFile = 'Lot.cs';

var rl = readline.createInterface({
  input: fs.createReadStream(inputFile),
  output: fs.createWriteStream(outputFile)
});

var columnPropGlobal = "";

rl.on('line', function(line) {
  // Property name line
  if(line.trim().substr(0, 1) == 'p' && line.trim().substr(-1, 1) == '}') {
    var name = line.trim().split(' ').slice(2, 3);
    var fixedLine = fixLine(name[0], line);
    rl.output.write('\t\t\t\t[Column("' + name + '", ' + columnPropGlobal + ')]\n');
    rl.output.write(fixedLine + '\n');
    
    // Column attribute line
  } else if(line.trim().substr(0, 7) == '[Column') {
    columnPropGlobal = line.trim().match(/\(([^)]+)\)/)[1];
    console.log(columnPropGlobal);
    
    // Other line
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