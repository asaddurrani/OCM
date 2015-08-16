/*
    Module with the view model for the Vehicle
*/
define("record/record.viewModel",
    ["jquery", "amplify", "ko", "record/record.dataservice", "record/record.model", "common/confirmation.viewModel", "common/pagination"],
    function ($, amplify, ko, dataservice, model, confirmation, pagination) {

        var ist = window.ist || {};
        ist.record = {
            viewModel: (function () {
                var // the view 
                    view,

                    //#region Observables 

                    //Is Loading Records
                    isRecordLoaded = ko.observable(false),
                    //Oil Maker Companies
                    oilMakers = ko.observableArray([]),
                    //oil Companies For Dialog
                    oilMakerCompaniesListForDialog = ko.observableArray([]),
                    //oils
                    oils = ko.observableArray([]),
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
                        //Get Oil Maker Companies
                        getOilMakerCompanies();
                    },
                    //Get Oil Maker Companies
                    getOilMakerCompanies = function () {
                        //dataservice.getOilMakerCompanies({
                        //    success: function (data) {
                        //        var oilMakerCompaniesList = [];
                        //        _.each(data.OilMakerCompanies, function (item) {
                        //            var oilMaker = new model.OilMakerCompany.Create(item);
                        //            oilMakerCompaniesList.push(oilMaker);
                        //        });
                        //        ko.utils.arrayPushAll(oilMakers(), oilMakerCompaniesList);
                        //        oilMakers.valueHasMutated();
                        //        ko.utils.arrayPushAll(oilMakerCompaniesListForDialog(), oilMakerCompaniesList);
                        //        oilMakerCompaniesListForDialog.valueHasMutated();
                        //    },
                        //    error: function () {
                        //        toastr.error("Failed to load oil maker companies data");
                        //    }
                        //});
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
                        //getBaseData();
                        //getOils();

                    };
                //#endregion


                return {
                    isRecordLoaded: isRecordLoaded,
                    oilMakers: oilMakers,
                    oilMakerCompaniesListForDialog: oilMakerCompaniesListForDialog,
                    oils: oils,
                    searchFilter: searchFilter,
                    oilMakerCompanyFilter: oilMakerCompanyFilter,
                    selectedOil: selectedOil,
                    isLoadingOil: isLoadingOil,
                    pager: pager,
                    getBaseData: getBaseData,
                    getOilMakerCompanies: getOilMakerCompanies,
                    getOils: getOils,
                    createRecord: createRecord,
                    searchOil: searchOil,
                    onDeleteOil: onDeleteOil,
                    onEditOil: onEditOil,
                    selectOil: selectOil,
                    onSaveOil: onSaveOil,
                    onCloseOilDialog: onCloseOilDialog,
                    initialize: initialize
                };

            })()
        };
        return ist.record.viewModel;
    });
