System.register("index", ["vue"], function (exports_1, context_1) {
    "use strict";
    var vue_1, vue;
    var __moduleName = context_1 && context_1.id;
    return {
        setters: [
            function (vue_1_1) {
                vue_1 = vue_1_1;
            }
        ],
        execute: function () {
            vue = new vue_1.default({
                el: "#app",
                data: {}
            });
        }
    };
});
//# sourceMappingURL=app-bundle.js.map