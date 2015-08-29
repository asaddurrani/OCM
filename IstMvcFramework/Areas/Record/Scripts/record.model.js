define(["ko", "underscore", "underscore-ko"], function (ko) {

    var
    //#region Customer entity
    // ReSharper disable InconsistentNaming
    Customer = function (specifiedCustomerId, specifiedCustomerFirstName, specifiedCustomerMiddleName, specifiedCustomerLastName, specifiedCustomerMobileNumber1,
        specifiedCustomerMobileNumber2, specifiedCustomerLandline, specifiedCustomerEmailAddress, specifiedCustomerAddress, specifiedCustomerCreatedDate, specifiedCustomerDescription) {
        // ReSharper restore InconsistentNaming
        var // Reference to this object
            self,
            // Unique key
            customerId = ko.observable(specifiedCustomerId),
            // customer First Name
            customerFirstName = ko.observable(specifiedCustomerFirstName),
            //customer Middle Name
            customerMiddleName = ko.observable(specifiedCustomerMiddleName),
            //customer Mobile Number 1
            customerMobileNumber1 = ko.observable(specifiedCustomerMobileNumber1),
            //customer Mobile Number 2
            customerMobileNumber2 = ko.observable(specifiedCustomerMobileNumber2),
            //customer Landline
            customerLandline = ko.observable(specifiedCustomerLandline),
            //customer Email Address
            customerEmailAddress = ko.observable(specifiedCustomerEmailAddress),
            //customer Address
            customerAddress = ko.observable(specifiedCustomerAddress),
            //customer Created Date
            customerCreatedDate = ko.observable(specifiedCustomerCreatedDate),
            //customer Description
            customerDescription = ko.observable(specifiedCustomerDescription),

            // Errors
            errors = ko.validation.group({
                customerId: customerId,
                customerFirstName: customerFirstName,
                customerMiddleName: customerMiddleName,
                customerMobileNumber1: customerMobileNumber1,
                customerMobileNumber2: customerMobileNumber2,
                customerLandline: customerLandline,
                customerEmailAddress: customerEmailAddress,
                customerAddress: customerAddress,
                customerCreatedDate: customerCreatedDate,
                customerDescription: customerDescription,
            }),
            // Is Valid
            isValid = ko.computed(function () {
                return errors().length === 0;
            }),
            // True if the booking has been changed
            // ReSharper disable InconsistentNaming
            dirtyFlag = new ko.dirtyFlag({
                // ReSharper restore InconsistentNaming
                customerId: customerId,
                customerFirstName: customerFirstName,
                customerMiddleName: customerMiddleName,
                customerMobileNumber1: customerMobileNumber1,
                customerMobileNumber2: customerMobileNumber2,
                customerLandline: customerLandline,
                customerEmailAddress: customerEmailAddress,
                customerAddress: customerAddress,
                customerCreatedDate: customerCreatedDate,
                customerDescription: customerDescription,
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
                    CustomerId: customerId(),
                    CustomerFirstName: customerFirstName(),
                    CustomerMiddleName: customerMiddleName(),
                    CustomerMobileNumber1: customerMobileNumber1(),
                    CustomerMobileNumber2: customerMobileNumber2(),
                    CustomerLandline: customerLandline(),
                    CustomerEmailAddress: customerEmailAddress(),
                    CustomerAddress: customerAddress(),
                    CustomerCreatedDate: customerCreatedDate(),
                    CustomerDescription: customerDescription(),
                };
            };

        self = {
            customerId: customerId,
            customerFirstName: customerFirstName,
            customerMiddleName: customerMiddleName,
            customerMobileNumber1: customerMobileNumber1,
            customerMobileNumber2: customerMobileNumber2,
            customerLandline: customerLandline,
            customerEmailAddress: customerEmailAddress,
            customerAddress: customerAddress,
            customerCreatedDate: customerCreatedDate,
            customerDescription: customerDescription,
            errors: errors,
            isValid: isValid,
            dirtyFlag: dirtyFlag,
            hasChanges: hasChanges,
            reset: reset,
            convertToServerData: convertToServerData
        };
        return self;
    };

    // Customer Factory
    Customer.Create = function (source) {
        return new Customer(source.CustomerId, source.CustomerFirstName, source.CustomerMiddleName, source.CustomerLastName, source.CustomerMobileNumber1,
        source.CustomerMobileNumber2, source.CustomerLandline, source.CustomerEmailAddress, source.CustomerAddress, source.CustomerCreatedDate, source.CustomerDescription);
    };
    //#endregion

    //#region Customer Vehicles entity
    // ReSharper disable once AssignToImplicitGlobalInFunctionScope
    CustomerVehicles = function (specifiedCustomerVehicleId,specifiedCustomerId,specifiedVehicleId,specifiedVehiclePlateAlphabets,specifiedVehiclePlateNumbers,
        specifiedVehiclePlateYear,specifiedVehicleManufacturingYear,specifiedVehicleDailyRunningKms) {
        // ReSharper restore InconsistentNaming
        var // Reference to this object
            self,
            // Unique key
            customerVehicleId = ko.observable(specifiedCustomerVehicleId),
            //customer Id
            customerId = ko.observable(specifiedCustomerId),
            //vehicle Id
            vehicleId = ko.observable(specifiedVehicleId),
            //vehicle Plate Alphabets
            vehiclePlateAlphabets = ko.observable(specifiedVehiclePlateAlphabets),
            //vehicle Plate Numbers
            vehiclePlateNumbers = ko.observable(specifiedVehiclePlateNumbers),
            //vehicle Plate Year
            vehiclePlateYear = ko.observable(specifiedVehiclePlateYear),
            //vehicle Manufacturing Year
            vehicleManufacturingYear = ko.observable(specifiedVehicleManufacturingYear),
            //vehicle Daily Running Kms
            vehicleDailyRunningKms = ko.observable(specifiedVehicleDailyRunningKms),

            // Errors
            errors = ko.validation.group({
                customerVehicleId: customerVehicleId,
                customerId: customerId,
                vehicleId: vehicleId,
                vehiclePlateAlphabets: vehiclePlateAlphabets,
                vehiclePlateNumbers: vehiclePlateNumbers,
                vehiclePlateYear: vehiclePlateYear,
                vehicleManufacturingYear: vehicleManufacturingYear,
                vehicleDailyRunningKms: vehicleDailyRunningKms,
            }),
            // Is Valid
            isValid = ko.computed(function () {
                return errors().length === 0;
            }),
            // True if the booking has been changed
            // ReSharper disable InconsistentNaming
            dirtyFlag = new ko.dirtyFlag({
                // ReSharper restore InconsistentNaming
                customerVehicleId: customerVehicleId,
                customerId: customerId,
                vehicleId: vehicleId,
                vehiclePlateAlphabets: vehiclePlateAlphabets,
                vehiclePlateNumbers: vehiclePlateNumbers,
                vehiclePlateYear: vehiclePlateYear,
                vehicleManufacturingYear: vehicleManufacturingYear,
                vehicleDailyRunningKms: vehicleDailyRunningKms,
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
                    CustomerVehicleId: customerVehicleId(),
                    CustomerId: customerId(),
                    VehicleId: vehicleId(),
                    VehiclePlateAlphabets: vehiclePlateAlphabets(),
                    VehiclePlateNumbers: vehiclePlateNumbers(),
                    VehiclePlateYear: vehiclePlateYear(),
                    VehicleManufacturingYear: vehicleManufacturingYear(),
                    VehicleDailyRunningKms: vehicleDailyRunningKms(),
                };
            };

        self = {
            customerVehicleId: customerVehicleId,
            customerId: customerId,
            vehicleId: vehicleId,
            vehiclePlateAlphabets: vehiclePlateAlphabets,
            vehiclePlateNumbers: vehiclePlateNumbers,
            vehiclePlateYear: vehiclePlateYear,
            vehicleManufacturingYear: vehicleManufacturingYear,
            vehicleDailyRunningKms: vehicleDailyRunningKms,
            errors: errors,
            isValid: isValid,
            dirtyFlag: dirtyFlag,
            hasChanges: hasChanges,
            reset: reset,
            convertToServerData: convertToServerData
        };
        return self;
    };

    // Customer Vehicles Factory
    CustomerVehicles.Create = function (source) {
        return new CustomerVehicles(source.CustomerVehicleId, source.CustomerId, source.VehicleId, source.VehiclePlateAlphabets, source.VehiclePlateNumbers,
        source.VehiclePlateYear, source.VehicleManufacturingYear, source.VehicleDailyRunningKms);
    };
    //#endregion
    
    //#region Oil Change Records entity
    // ReSharper disable once AssignToImplicitGlobalInFunctionScope
    OilChangeRecords = function (specifiedOilChangeRecordId, specifiedOilCustomerId, specifiedOilId, specifiedCustomerVehicleId) {
        // ReSharper restore InconsistentNaming
        var // Reference to this object
            self,
            // Unique key
            oilChangeRecordId = ko.observable(specifiedOilChangeRecordId),
            //Oil Customer Id
            oilCustomerId = ko.observable(specifiedOilCustomerId),
            //oil Id
            oilId = ko.observable(specifiedOilId),
            //customer Vehicle Id
            customerVehicleId = ko.observable(specifiedCustomerVehicleId),

            // Errors
            errors = ko.validation.group({
                oilChangeRecordId: oilChangeRecordId,
                oilCustomerId: oilCustomerId,
                oilId: oilId,
                customerVehicleId: customerVehicleId,
            }),
            // Is Valid
            isValid = ko.computed(function () {
                return errors().length === 0;
            }),
            // True if the booking has been changed
            // ReSharper disable InconsistentNaming
            dirtyFlag = new ko.dirtyFlag({
                // ReSharper restore InconsistentNaming
                oilChangeRecordId: oilChangeRecordId,
                oilCustomerId: oilCustomerId,
                oilId: oilId,
                customerVehicleId: customerVehicleId,
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
                    OilChangeRecordId: oilChangeRecordId(),
                    OilCustomerId: oilCustomerId(),
                    OilId: oilId(),
                    CustomerVehicleId: customerVehicleId(),
                };
            };

        self = {
            oilChangeRecordId: oilChangeRecordId,
            oilCustomerId: oilCustomerId,
            oilId: oilId,
            customerVehicleId: customerVehicleId,
            errors: errors,
            isValid: isValid,
            dirtyFlag: dirtyFlag,
            hasChanges: hasChanges,
            reset: reset,
            convertToServerData: convertToServerData
        };
        return self;
    };

    // Oil Maker Factory
    OilChangeRecords.Create = function (source) {
        return new OilChangeRecords(source.OilChangeRecordId, source.OilCustomerId, source.OilId, source.CustomerVehicleId);
    };
    //#endregion
    
    return {
        Customer: Customer,
        CustomerVehicles: CustomerVehicles,
        OilChangeRecords: OilChangeRecords
    };
});