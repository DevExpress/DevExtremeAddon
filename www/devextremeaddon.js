
var devextremeaddon = {
    setup: function () {
        cordova.exec(null, null, "DevExtremeAddon", "setup", []);
    }
}

module.exports = devextremeaddon;