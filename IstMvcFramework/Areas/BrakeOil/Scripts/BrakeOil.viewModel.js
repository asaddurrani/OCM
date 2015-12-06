/*
    Module with the view model for the Vehicle
*/
define("brakeOil/brakeOil.viewModel",
    ["jquery", "amplify", "ko", "brakeOil/brakeOil.dataservice", "brakeOil/brakeOil.model", "common/confirmation.viewModel", "common/pagination"],
    function ($, amplify, ko, dataservice, model, confirmation, pagination) {

        var ist = window.ist || {};
        ist.brakeOil = {
            viewModel: (function () {
                var // the view 
                    view,

                    //#region Observables 

                    //Is Loading Brake Oils
                    isBrakeOilLoaded = ko.observable(false),
                    //Brake Oils
                    brakeOils = ko.observableArray([]),
                    //search Filter
                    searchFilter = ko.observable(),
                    //selected Brake Oil
                    selectedBrakeOil = ko.observable(),
                    //Is Loading BrakeOil
                    isLoadingBrakeOil = ko.observable(false),
                    //pager
                    pager = ko.observable(),

                    //#endregion

                    //#region Utility Functions 

                    //get Base Data
                    getBaseData = function () {
                    },
                    //Get Brake Oils
                    getBrakeOils = function () {
                        isLoadingBrakeOil(true);
                        dataservice.getBrakeOils({
                            SearchString: searchFilter(),
                            PageSize: pager().pageSize(),
                            PageNo: pager().currentPage()
                        }, {
                            success: function (data) {
                                brakeOils.removeAll();
                                if (data != null) {
                                    pager().totalCount(data.TotalCount);
                                    _.each(data.BrakeOils, function (item) {
                                        var module = new model.BrakeOil.Create(item);
                                        brakeOils.push(module);
                                    });
                                }
                                isLoadingBrakeOil(false);
                            },
                            error: function (response) {
                                isLoadingBrakeOil(false);
                                toastr.error("Error: Failed to Load Brake Oils Data." + response);
                            }
                        });
                    },
                    //Create Brake Oil
                    createBrakeOil = function () {
                        selectedBrakeOil(new model.BrakeOil.Create({}));
                        view.showBrakeOilDialog();
                    },
                    //Search Brake Oil
                    searchBrakeOil = function () {
                        getBrakeOils();
                    },
                    //Delete Brake Oil
                    onDeleteBrakeOil = function () {

                    },
                    //Edit Brake Oil
                    onEditBrakeOil = function () {
                        if (selectedBrakeOil() != undefined) {
                            view.showBrakeOilDialog();
                        }
                    },
                    //Select Brake Oil
                    selectBrakeOil = function (oil) {
                        if (selectedBrakeOil() != oil) {
                            selectedBrakeOil(oil);
                        }
                    },
                    //On Save Brake Oil
                    onSaveBrakeOil = function () {
                        if (doBeforeSelect()) {
                            dataservice.saveBrakeOil(
                                selectedBrakeOil().convertToServerData(),
                                {
                                    success: function (data) {
                                        if (data) {
                                            var savedBrakeOil = model.BrakeOil.Create(data);
                                            if (selectedBrakeOil().brakeOilId() <= 0 || selectedBrakeOil().brakeOilId() == undefined) {
                                                brakeOils.splice(0, 0, savedBrakeOil);
                                            }
                                            toastr.success("Saved Successfully");
                                            view.hideBrakeOilDialog();
                                        }
                                    },
                                    error: function (response) {
                                        toastr.error("Error: Failed To Save Brake Oil " + response);
                                    }
                                });
                        }
                    },
                    // Do Before Logic
                    doBeforeSelect = function () {
                        var flag = true;
                        if (!selectedBrakeOil().isValid()) {
                            selectedBrakeOil().errors.showAllMessages();
                            flag = false;
                        }
                        return flag;
                    },

                    //On Close Dialog
                    onCloseBrakeOilDialog = function () {
                        view.hideBrakeOilDialog();
                    },

                    //#endregion

                    //#region Initialize the view model
                    initialize = function (specifiedView) {
                        view = specifiedView;
                        ko.applyBindings(view.viewModel, view.bindingRoot);
                        pager(pagination.Pagination({}, brakeOils, getBrakeOils));
                        getBaseData();
                        getBrakeOils();

                    };
                //#endregion


                return {
                    //#region Return
                    isBrakeOilLoaded: isBrakeOilLoaded,
                    brakeOils: brakeOils,
                    searchFilter: searchFilter,
                    selectedBrakeOil: selectedBrakeOil,
                    isLoadingBrakeOil: isLoadingBrakeOil,
                    pager: pager,
                    getBaseData: getBaseData,
                    getBrakeOils: getBrakeOils,
                    createBrakeOil: createBrakeOil,
                    searchBrakeOil: searchBrakeOil,
                    onDeleteBrakeOil: onDeleteBrakeOil,
                    onEditBrakeOil: onEditBrakeOil,
                    selectBrakeOil: selectBrakeOil,
                    onSaveBrakeOil: onSaveBrakeOil,
                    onCloseBrakeOilDialog: onCloseBrakeOilDialog,
                    initialize: initialize
                    //#endregion
                };

            })()
        };
        return ist.brakeOil.viewModel;
    });
