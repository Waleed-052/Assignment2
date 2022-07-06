var currentIndex = 0;
animate();

function animate() {
  var i;
  var x = document.getElementsByClassName("animated");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  currentIndex++;
  if (currentIndex > x.length) {currentIndex = 1}    
  x[currentIndex-1].style.display = "block";  
  setTimeout(animate, 2500);
}
