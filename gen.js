function r(){
  var min=-1000; 
    var max=100;  
    var rand = 
    Math.floor(Math.random() * (+max - +min)) + +min;  
return rand;
}
function gen(size){
let str = "";
for(let i = 0;i<size;i++){
if(i>0){
  str += "\n";
}
 for(let j = 0;j<size;j++){
  if(j > 0)  str += ",";
  str += r(); 
 }
}
return str;
}