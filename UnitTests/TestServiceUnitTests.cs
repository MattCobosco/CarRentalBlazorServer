using CarRental_API;
using CoreBusiness;
using System;
using Xunit;
using Xunit.Abstractions;

namespace UnitTests
{
    public class TestServiceUnitTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly TestService _sut = new();
        private readonly FleetVehicle _fleetVehicle = new()
        {
            FleetVehicleLicensePlate = "GDA23842",
            Odometer = 16000,
            Vin = "WAUD2AFD7DN006931",
            MaintenanceDate = DateTime.Today.AddDays(13),
            MaintenanceOdometer = 15000,
            DateAdded = DateTime.Today,
            VehicleModelId = 1,
            CurrentBranchId = 2
            // Warsaw BranchID=2
        };

        public TestServiceUnitTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CarInWarsaw_ReturnsTrue_IfBranchIdEqualsWarsawBranchId_Fact()
        {
            var result = _sut.IsThisCarInWarsaw(_fleetVehicle);

            _testOutputHelper.WriteLine("Testing...");
            Assert.True(result);
            _testOutputHelper.WriteLine(result.ToString());
        }

        [Fact]
        public void CarNeedsMaintenance_ReturnsTrueIf_MaintenanceOdometerSmallerThanOdometer_Fact()
        {
            var result = _sut.DoesThisCarNeedsMaintenance(_fleetVehicle);
            _testOutputHelper.WriteLine("Testing...");
            Assert.True(result);
            _testOutputHelper.WriteLine(result.ToString());

        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(1, false)]
        public void CarInWarsaw_ReturnsTrue_IfIfBranchIdEqualsWarsawBranchId_Theory(int branchId, bool expectedOutput)
        {
            FleetVehicle fleetVehicleBis = new()
            {
                FleetVehicleLicensePlate = "GDA23842",
                Odometer = 16000,
                Vin = "WAUD2AFD7DN006931",
                MaintenanceDate = DateTime.Today.AddDays(13),
                MaintenanceOdometer = 15000,
                DateAdded = DateTime.Today,
                VehicleModelId = 1,
                CurrentBranchId = branchId
            };

            _testOutputHelper.WriteLine("Testing...");
            var output = _sut.IsThisCarInWarsaw(fleetVehicleBis);

            Assert.Equal(expectedOutput,output);
        }

        [Theory]
        [InlineData(15000, 16000, true)]
        [InlineData(16000, 15000, false)]
        public void CarNeedsMaintenance_ReturnsTrueIf_MaintenanceOdometerSmallerThanOdometer_Theory(
            int maintenanceOdometer, int odometer, bool expectedOutput)
        {
            FleetVehicle fleetVehicleBis = new()
            {
                FleetVehicleLicensePlate = "GDA23842",
                Odometer = odometer,
                Vin = "WAUD2AFD7DN006931",
                MaintenanceDate = DateTime.Today.AddDays(13),
                MaintenanceOdometer = maintenanceOdometer,
                DateAdded = DateTime.Today,
                VehicleModelId = 1,
                CurrentBranchId = 2
            };

            _testOutputHelper.WriteLine("Testing...");
            var output = _sut.DoesThisCarNeedsMaintenance(fleetVehicleBis);

            Assert.Equal(expectedOutput, output);
        }
    }
}
