
function initGallery(element) {
    if (element) {
        element.style.webkitOverflowScrolling = 'touch';
    }
}

function scrollGallery(element, scrollAmount) {
    if (element) {
        element.scrollLeft += scrollAmount;
    }
}

window.initGallery = initGallery;
window.scrollGallery = scrollGallery;