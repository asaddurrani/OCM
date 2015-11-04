define(["ko", "underscore", "underscore-ko"], function (ko) {

    var
    //#region Brake Oil Filter entity
    // ReSharper disable InconsistentNaming
    BrakeOil = function (specifiedBrakeOilId, specifiedBrakeOilName, specifiedBrakeOilCompanyName, specifiedBrakeOilPrice) {
        // ReSharper restore InconsistentNaming
        var // Reference to this object
            self,
            // Unique key
            brakeOilId = ko.observable(specifiedBrakeOilId),
            // Brake Oil Name
            brakeOilName = ko.observable(specifiedBrakeOilName),
            //Brake Oil Company Name
            brakeOilCompanyNamePrice = ko.observable(specifiedBrakeOilCompanyName),
            //Brake Oil Price
            brakeOilPrice = ko.observable(specifiedBrakeOilPrice),
            // Errors
            errors = ko.validation.group({
                brakeOilId: brakeOilId,
                brakeOilName: brakeOilName,
                brakeOilCompanyNamePrice: brakeOilCompanyNamePrice,
                brakeOilPrice: brakeOilPrice
            }),
            // Is Valid
            isValid = ko.computed(function () {
                return errors().length === 0;
            }),
            // True if the booking has been changed
            // ReSharper disable InconsistentNaming
            dirtyFlag = new ko.dirtyFlag({
                // ReSharper restore InconsistentNaming
                brakeOilId: brakeOilId,
                brakeOilName: brakeOilName,
                brakeOilCompanyNamePrice: brakeOilCompanyNamePrice,
                brakeOilPrice: brakeOilPrice
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
                    BrakeOilId: brakeOilId(),
                    BrakeOilName: brakeOilName(),
                    BrakeOilCompanyNamePrice: brakeOilCompanyNamePrice(),
                    BrakeOilPrice: brakeOilPrice()
                };
            };

        self = {
            brakeOilId: brakeOilId,
            brakeOilName: brakeOilName,
            brakeOilCompanyNamePrice: brakeOilCompanyNamePrice,
            brakeOilPrice: brakeOilPrice,
            errors: errors,
            isValid: isValid,
            dirtyFlag: dirtyFlag,
            hasChanges: hasChanges,
            reset: reset,
            convertToServerData: convertToServerData
        };
        return self;
    };

    // Brake Oil Factory
    BrakeOil.Create = function (source) {
        return new BrakeOil(source.BrakeOilId, source.BrakeOilName, source.BrakeOilCompanyNamePrice, source.BrakeOilPrice);
    };
    //#endregion

    return {
        BrakeOil: BrakeOil,
    };
});