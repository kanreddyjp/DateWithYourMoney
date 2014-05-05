function numberOnly(e) {
  var key; var tf;
  if (window.event) // IE 
    key = e.keyCode;
  else if (e.which) // Firefox/Opera
    key = e.which;
  if ((key > 47 && key < 58) || (key == 8) || (e.keyCode > 36 && e.keyCode < 41) || (e.keyCode == 46) || (e.keyCode == 9)) return true;
  else return false;
}