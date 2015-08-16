/*
    View for the Vehicle. Used to keep the viewmodel clear of UI related logic
*/
define("record/record.view",
    ["jquery", "record/record.viewModel"], function ($, recordViewModel) {

        var ist = window.ist || {};

        // View 
        ist.record.view = (function (specifiedViewModel) {
            var
                // View model 
                viewModel = specifiedViewModel,
                // Binding root used with knockout
                bindingRoot = $("#recordBinding")[0],
                //Show Record Dialog
                showRecordDialog = function () {
                    $("#recordDialog").modal("show");
                },
                 // Hide Record the dialog
                hideRecordDialog = function () {
                    $("#recordDialog").modal("hide");
                },

                // Initialize
                initialize = function () {
                    if (!bindingRoot) {
                        return;
                    }

                    // Handle Sorting
                    handleSorting("recordTable", viewModel.sortOn, viewModel.sortIsAsc, viewModel.getVehicles);
                };

            initialize();


            return {
                bindingRoot: bindingRoot,
                showRecordDialog: showRecordDialog,
                hideRecordDialog: hideRecordDialog,
                viewModel: viewModel
            };
        })(recordViewModel);

        // Initialize the view model
        if (ist.record.view.bindingRoot) {
            recordViewModel.initialize(ist.record.view);
        }

        return ist.record.view;
    });