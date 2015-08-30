/*
    Module with the view model for the Vehicle
*/
define("record/record.viewModel",
    ["jquery", "amplify", "ko", "record/record.dataservice", "record/record.model", "oil/oil.model", "vehicle/vehicle.model", "common/confirmation.viewModel", "common/pagination"],
    function ($, amplify, ko, dataservice, model, oilModel, vehicleModel, confirmation, pagination) {

        var ist = window.ist || {};
        ist.record = {
            viewModel: (function () {
                var // the view 
                    view,

                    //#region Observables 

                    //Is Loading Records
                    isRecordLoaded = ko.observable(false),
                    
                    //Oil Maker Companies // Shell, Helix
                    oilMakers = ko.observableArray([]),
                    //oils // remula
                    oils = ko.observableArray([]),
                    //oil Companies For Dialog // Honda, Toyota, Suzuki
                    vehiclesMakersList = ko.observableArray([]),
                    //vehicles // corolla, city, mehran
                    vehicles = ko.observableArray([]),
                    
                    //search Filter
                    searchFilter = ko.observable(),
                    //oil Maker Company Filter
                    oilMakerCompanyFilter = ko.observable(),
                    //selected Oil
                    selectedOil = ko.observable(),
                    //Is Loading Oil
                    isLoadingOil = ko.observable(false),
                    //pager
                    pager = ko.observable(),

                    //#endregion

                    //#region Utility Functions 

                    //get Base Data
                    getBaseData = function () {
                        getRecordBaseData();
                    },
                    getRecordBaseData = function() {
                        dataservice.getRecordBaseData({
                            success: function (data) {
                                
                                var oilMakerCompaniesList = [];
                                var oilsList = [];
                                var vehicleMakersList = [];
                                var vehiclesList = [];
                               
                                _.each(data.OilMakerCompanies, function (item) {
                                    var oilMaker = new oilModel.OilMakerCompany.Create(item);
                                    oilMakerCompaniesList.push(oilMaker);
                                });
                                ko.utils.arrayPushAll(oilMakers(), oilMakerCompaniesList);
                                oilMakers.valueHasMutated();
                                
                                _.each(data.Oils, function (item) {
                                    var oil = new oilModel.Oil.Create(item);
                                    oilsList.push(oil);
                                });
                                ko.utils.arrayPushAll(oils(), oilsList);
                                oils.valueHasMutated();
                                
                                _.each(data.VehicleMakers, function (item) {
                                    var vehicleMaker = new vehicleModel.VehicleMaker.Create(item);
                                    vehicleMakersList.push(vehicleMaker);
                                });
                                ko.utils.arrayPushAll(vehiclesMakersList(), vehicleMakersList);
                                vehiclesMakersList.valueHasMutated();
                                
                                _.each(data.VehicleModelMaker, function (item) {
                                    var vehicleModelMaker = new vehicleModel.VehicleModelMaker.Create(item);
                                    vehiclesList.push(vehicleModelMaker);
                                });
                                ko.utils.arrayPushAll(vehicles(), vehiclesList);
                                vehicles.valueHasMutated();
                                
                            },
                            error: function () {
                                toastr.error("Failed to load oil maker companies data");
                            }
                        });
                    },
                    //Get Oils
                    getOils = function () {
                        isLoadingOil(true);
                        //dataservice.getOils({
                        //    SearchString: searchFilter(),
                        //    PageSize: pager().pageSize(),
                        //    PageNo: pager().currentPage()
                        //}, {
                        //    success: function (data) {
                        //        oils.removeAll();
                        //        if (data != null) {
                        //            pager().totalCount(data.TotalCount);
                        //            _.each(data.Oils, function (item) {
                        //                var module = new model.Oil.Create(item);
                        //                oils.push(module);
                        //            });
                        //        }
                        //        isLoadingOil(false);
                        //    },
                        //    error: function (response) {
                        //        isLoadingOil(false);
                        //        toastr.error("Error: Failed to Load Oils Data." + response);
                        //    }
                        //});
                    },
                    //Create Record
                    createRecord = function () {
                        //selectedOil(new model.Oil.Create({}));
                        view.showRecordDialog();
                    },
                    //Search Oil
                    searchOil = function () {
                        getOils();
                    },
                    //Delete oil
                    onDeleteOil = function () {

                    },
                    //Edit Oil
                    onEditOil = function () {
                        if (selectedOil() != undefined) {
                            view.showOilDialog();
                        }
                    },
                    //Select Oil
                    selectOil = function (oil) {
                        if (selectedOil() != oil) {
                            selectedOil(oil);
                        }
                    },
                    //On Save Oil
                    onSaveOil = function () {
                        if (selectedOil().isValid()) {
                            view.hideOilDialog();
                        }
                    },
                    //On Close Dialog
                    onCloseOilDialog = function () {
                        view.hideOilDialog();
                    },

                    //#endregion

                    //#region Initialize the view model
                    initialize = function (specifiedView) {
                        view = specifiedView;
                        ko.applyBindings(view.viewModel, view.bindingRoot);
                        pager(pagination.Pagination({}, oils, getOils));
                        getBaseData();
                        //getOils();

                    };
                //#endregion


                return {
                    isRecordLoaded: isRecordLoaded,
                    oilMakers: oilMakers,
                    oils: oils,
                    searchFilter: searchFilter,
                    oilMakerCompanyFilter: oilMakerCompanyFilter,
                    selectedOil: selectedOil,
                    isLoadingOil: isLoadingOil,
                    pager: pager,
                    getBaseData: getBaseData,
                    getOils: getOils,
                    createRecord: createRecord,
                    searchOil: searchOil,
                    onDeleteOil: onDeleteOil,
                    onEditOil: onEditOil,
                    selectOil: selectOil,
                    onSaveOil: onSaveOil,
                    onCloseOilDialog: onCloseOilDialog,
                    vehiclesMakersList: vehiclesMakersList,
                    vehicles: vehicles,
                    initialize: initialize
                };

            })()
        };
        return ist.record.viewModel;
    });
