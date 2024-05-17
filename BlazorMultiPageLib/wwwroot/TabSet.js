// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function GetTabWidth(index) {
    var lst = document.querySelectorAll('.middletab-tabs li');
    if (lst.length > index) {
        return lst[index].offsetWidth;
    }
    return 0;
}

export function GetWidth(query) {
    var obj = document.querySelector(query);
    if (obj) {
        return obj.offsetWidth;
    }
    return 0;
}

export function GoLogin() {
    window.top.location.href = "/";
}