/*
    Data service module with ajax calls to the server
*/
define("oil/oil.dataservice", function () {

    // Data service for forecast 
    var dataService = (function () {
        var // True if initialized
            isInitialized = false,
            // Initialize
            initialize = function() {
                if (!isInitialized) {

                    // Define request to get vehicle makers 
                    amplify.request.define('getVehicleMakers', 'ajax', {
                        url: '/Api/VehicleMaker',
                        dataType: 'json',
                        type: 'GET'
                    });
                    // Define request to get vehicle model maker 
                    amplify.request.define('getVehicleModelMaker', 'ajax', {
                        url: '/Api/VehicleModelMaker',
                        dataType: 'json',
                        type: 'GET'
                    });

                    isInitialized = true;
                }
            },
            // Get Product Base
            getVehicleMakers = function(callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getVehicleMakers',
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            // Get Vehicle Model Maker
            getVehicleModelMaker = function(param, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getVehicleModelMaker',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: param
                });
            };


        return {
            getVehicleMakers: getVehicleMakers,
            getVehicleModelMaker: getVehicleModelMaker,
        };
    })();

    return dataService;
});