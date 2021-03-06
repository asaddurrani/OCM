﻿/*
    Data service module with ajax calls to the server
*/
define("vehicle/vehicle.dataservice", function () {

    // Data service for forecast 
    var dataService = (function () {
        var
            // True if initialized
            isInitialized = false,
            // Initialize
            initialize = function () {
                if (!isInitialized) {

                    // Define request to get product base 
                    amplify.request.define('getProductBase', 'ajax', {
                        url: '/Api/ProductBase',
                        dataType: 'json',
                        type: 'GET'
                    });
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

                    // Define request to get products
                    amplify.request.define('getProducts', 'ajax', {
                        url: '/Api/Product',
                        dataType: 'json',
                        type: 'GET'
                    });

                    // Define request to save product
                    amplify.request.define('createProduct', 'ajax', {
                        url: '/Api/Product',
                        dataType: 'json',
                        type: 'PUT'
                    });

                    // Define request to update product
                    amplify.request.define('updateProduct', 'ajax', {
                        url: '/Api/Product',
                        dataType: 'json',
                        type: 'POST'
                    });

                    // Define request to delete product
                    amplify.request.define('deleteProduct', 'ajax', {
                        url: '/Api/Product',
                        dataType: 'json',
                        type: 'DELETE'
                    });

                    isInitialized = true;
                }
            },

            // Get Products
            getProducts = function (params, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getProducts',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: params
                });
            },

            // Get Product Base
            getProductBase = function (callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getProductBase',
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            // Get Product Base
            getVehicleMakers = function (callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getVehicleMakers',
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            // Get Vehicle Model Maker
            getVehicleModelMaker = function (param, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'getVehicleModelMaker',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: param
                });
            },

            // Create Product
            createProduct = function (param, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'createProduct',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: param
                });
            },

            // Update a Product
            updateProduct = function (param, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'updateProduct',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: param
                });
            },

            // save Forecast
            deleteProduct = function (param, callbacks) {
                initialize();
                return amplify.request({
                    resourceId: 'deleteProduct',
                    success: callbacks.success,
                    error: callbacks.error,
                    data: param
                });
            };


        return {
            getVehicleMakers: getVehicleMakers,
            getVehicleModelMaker: getVehicleModelMaker,
            //below to delete
            getProducts: getProducts,
            createProduct: createProduct,
            updateProduct: updateProduct,
            deleteProduct: deleteProduct,
            getProductBase: getProductBase
        };
    })();

    return dataService;
});