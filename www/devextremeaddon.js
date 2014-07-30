
var devextremeaddon = {
    register: function () {
        cordova.exec(null, null, "DevExtremeAddon", "setup", []);
    }
}

module.exports = devextremeaddon;