window.addEventListener('DOMContentLoaded', event => {

    // Toggle the side navigation
    const sidebarToggle = document.body.querySelector('#sidebarToggle');
    if (sidebarToggle) {
        // Uncomment Below to persist sidebar toggle between refreshes
        // if (localStorage.getItem('sb|sidebar-toggle') === 'true') {
        //     document.body.classList.toggle('sb-sidenav-toggled');
        // }
        sidebarToggle.addEventListener('click', event => {
            event.preventDefault();
            document.body.classList.toggle('sb-sidenav-toggled');
            localStorage.setItem('sb|sidebar-toggle', document.body.classList.contains('sb-sidenav-toggled'));
        });
    }

});

function btnAddToCardChange(id, price) {
    const ad = "btn-add-to-card-" + id;
    const element = document.getElementById(ad);
    element.innerText = "Sepete Ekle";
}

function btnAddToCardBack(id, price) {
    const ad = "btn-add-to-card-" + id;
    const element = document.getElementById(ad);
    element.innerText = price;
}
