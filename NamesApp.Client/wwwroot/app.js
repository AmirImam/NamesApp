var Functions = {};
function init() {
    console.log("JS Initialzed !!");
    Functions = {
        setLocalItem: function (key, value) {
            localStorage.setItem(key, value);
        },
        getLocalItem: function (key) {
            return localStorage.getItem(key);
        },
        clear: function () {
            localStorage.clear();
        }
    };
}