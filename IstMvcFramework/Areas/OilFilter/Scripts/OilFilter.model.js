define(["ko", "underscore", "underscore-ko"], function (ko) {

    var
    //#region Oil Filter entity
    // ReSharper disable InconsistentNaming
    OilFilter = function (specifiedOilFilterId, specifiedOilFilterName, specifiedOilFilterPrice) {
        // ReSharper restore InconsistentNaming
        var // Reference to this object
            self,
            // Unique key
            oilFilterId = ko.observable(specifiedOilFilterId),
            // Oil Filter Name
            oilFilterName = ko.observable(specifiedOilFilterName),
            //Oil Filter Price
            oilFilterPrice = ko.observable(specifiedOilFilterPrice),
            // Errors
            errors = ko.validation.group({
                oilFilterId: oilFilterId,
                oilFilterName: oilFilterName,
                oilFilterPrice: oilFilterPrice
            }),
            // Is Valid
            isValid = ko.computed(function () {
                return errors().length === 0;
            }),
            // True if the booking has been changed
            // ReSharper disable InconsistentNaming
            dirtyFlag = new ko.dirtyFlag({
                // ReSharper restore InconsistentNaming
                oilMakerId: oilFilterId,
                oilFilterName: oilFilterName,
                oilFilterPrice: oilFilterPrice
            }),
            // Has Changes
            hasChanges = ko.computed(function () {
                return dirtyFlag.isDirty();
            }),
            // Reset
            reset = function () {
                dirtyFlag.reset();
            },
            // Convert to server
            convertToServerData = function () {
                return {
                    OilFilterId: oilFilterId(),
                    OilFilterName: oilFilterName(),
                    OilFilterPrice: oilFilterPrice()
                };
            };

        self = {
            oilFilterId: oilFilterId,
            oilFilterName: oilFilterName,
            oilFilterPrice: oilFilterPrice,
            errors: errors,
            isValid: isValid,
            dirtyFlag: dirtyFlag,
            hasChanges: hasChanges,
            reset: reset,
            convertToServerData: convertToServerData
        };
        return self;
    };

    // Oil Filter Factory
    OilFilter.Create = function (source) {
        return new OilFilter(source.OilFilterId, source.OilFilterName, source.OilFilterPrice);
    };
    //#endregion

    return {
        OilFilter: OilFilter,
    };
});