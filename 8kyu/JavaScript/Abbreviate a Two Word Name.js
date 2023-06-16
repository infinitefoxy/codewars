function abbrevName(name){
  return name.match(/\b(\w)/g).toString().toUpperCase().replace(',', '.');

}