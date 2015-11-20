var readline = require('readline');
var fs = require('fs');

// Get all filenames from input
var inputFiles = fs.readdirSync('./Input/');
// Compare with all files from output folder (consider updated/created time)
var outputFiles = fs.readdirSync('./Output/');

// Array of files to pass to execution component
var fileNames = [];

for(var file in inputFiles) {
  if(outputFiles.indexOf(inputFiles[file]) != -1) {
    var inputDateCreated;
    var outputDateCreated;
    // check if output created/updated time is newer than input
    inputDateCreated = fs.statSync('./Input/' + inputFiles[file]).birthtime;
    outputDateCreated = fs.statSync('./Output/' + inputFiles[file]).birthtime;

    if(inputDateCreated > outputDateCreated)
      fileNames.push(inputFiles[file]);
  } else {
    fileNames.push(inputFiles[file]);
  }
}

// Execute renamer for all files (list of filenames)
for(var i in fileNames) {
  
  console.log(fileNames[i])
  
  var rl = readline.createInterface({
    input: fs.createReadStream('./Input/' + fileNames[i]),
    output: fs.createWriteStream('./Output/' + fileNames[i])
  });
  
  var columnPropGlobal = "";
  
  rl.on('line', function(line) {
    // Property name line
    if(line.trim().substr(0, 1) == 'p' && line.trim().substr(-1, 1) == '}') {
      var name = line.trim().split(' ').slice(2, 3);
      var fixedLine = fixLine(name[0], line);
      rl.output.write('\t\t[Column("' + name + '"' + columnPropGlobal + ')]\n');
      rl.output.write(fixedLine + '\n');
      if(columnPropGlobal != '') columnPropGlobal = '';
      
      // Column attribute line
    } else if(line.trim().substr(0, 7) == '[Column') {
      columnPropGlobal = ', ' + line.trim().match(/\(([^)]+)\)/)[1];
      
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

}