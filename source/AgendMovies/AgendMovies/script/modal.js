function AbrirModal(m){
    let Modal = document.getElementById(m);
    Modal.style.display = "flex"; 
    setTimeout(function () {
        Modal.style.opacity = 1;
    }, 20);
}
function FecharModal(m){
    let Modal = document.getElementById(m);
    Modal.style.opacity = 0;
    setTimeout(function () {
        Modal.style.display = "none"; 
    }, 500);
}
