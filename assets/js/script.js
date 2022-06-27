let hamb_icon=document.getElementById("hamb_icon");
let collapse_navbar=document.getElementById("collapse_navbar")
hamb_icon.onclick=function(){
    if (collapse_navbar.style.display === "block") {
        collapse_navbar.style.display = "none";
      } else {
        collapse_navbar.style.display = "block";
      }
    
}
