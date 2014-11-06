
using UavTalk;

public static class UAVObjectsInitialize
{
	public static void register(UAVObjectManager objMngr) {
		
		objMngr.registerObject( new AccelDesired() );
		
		objMngr.registerObject( new Accels() );
		
		objMngr.registerObject( new AccessoryDesired() );
		
		objMngr.registerObject( new ActuatorCommand() );
		
		objMngr.registerObject( new ActuatorDesired() );
		
		objMngr.registerObject( new ActuatorSettings() );
		
		objMngr.registerObject( new AirspeedActual() );
		
		objMngr.registerObject( new AirspeedSettings() );
		
		objMngr.registerObject( new AltitudeHoldDesired() );
		
		objMngr.registerObject( new AltitudeHoldSettings() );
		
		objMngr.registerObject( new AttitudeActual() );
		
		objMngr.registerObject( new AttitudeSettings() );
		
		objMngr.registerObject( new AttitudeSimulated() );
		
		objMngr.registerObject( new BaroAirspeed() );
		
		objMngr.registerObject( new BaroAltitude() );
		
		objMngr.registerObject( new BrushlessGimbalSettings() );
		
		objMngr.registerObject( new CameraDesired() );
		
		objMngr.registerObject( new CameraStabSettings() );
		
		objMngr.registerObject( new FaultSettings() );
		
		objMngr.registerObject( new FirmwareIAPObj() );
		
		objMngr.registerObject( new FixedWingAirspeeds() );
		
		objMngr.registerObject( new FixedWingPathFollowerSettings() );
		
		objMngr.registerObject( new FixedWingPathFollowerSettingsCC() );
		
		objMngr.registerObject( new FixedWingPathFollowerStatus() );
		
		objMngr.registerObject( new FlightBatterySettings() );
		
		objMngr.registerObject( new FlightBatteryState() );
		
		objMngr.registerObject( new FlightPlanControl() );
		
		objMngr.registerObject( new FlightPlanSettings() );
		
		objMngr.registerObject( new FlightPlanStatus() );
		
		objMngr.registerObject( new FlightStatus() );
		
		objMngr.registerObject( new FlightTelemetryStats() );
		
		objMngr.registerObject( new GCSReceiver() );
		
		objMngr.registerObject( new GCSTelemetryStats() );
		
		objMngr.registerObject( new GeoFenceSettings() );
		
		objMngr.registerObject( new GPSPosition() );
		
		objMngr.registerObject( new GPSSatellites() );
		
		objMngr.registerObject( new GPSTime() );
		
		objMngr.registerObject( new GPSVelocity() );
		
		objMngr.registerObject( new GroundPathFollowerSettings() );
		
		objMngr.registerObject( new GroundTruth() );
		
		objMngr.registerObject( new Gyros() );
		
		objMngr.registerObject( new GyrosBias() );
		
		objMngr.registerObject( new HomeLocation() );
		
		objMngr.registerObject( new HoTTSettings() );
		
		objMngr.registerObject( new HwColibri() );
		
		objMngr.registerObject( new HwCopterControl() );
		
		objMngr.registerObject( new HwDiscoveryF4() );
		
		objMngr.registerObject( new HwFlyingF3() );
		
		objMngr.registerObject( new HwFlyingF4() );
		
		objMngr.registerObject( new HwFreedom() );
		
		objMngr.registerObject( new HwQuanton() );
		
		objMngr.registerObject( new HwRevolution() );
		
		objMngr.registerObject( new HwRevoMini() );
		
		objMngr.registerObject( new HwSparky() );
		
		objMngr.registerObject( new HwSparkyBGC() );
		
		objMngr.registerObject( new I2CVM() );
		
		objMngr.registerObject( new I2CVMUserProgram() );
		
		objMngr.registerObject( new INSSettings() );
		
		objMngr.registerObject( new INSState() );
		
		objMngr.registerObject( new LoiterCommand() );
		
		objMngr.registerObject( new MagBias() );
		
		objMngr.registerObject( new Magnetometer() );
		
		objMngr.registerObject( new ManualControlCommand() );
		
		objMngr.registerObject( new ManualControlSettings() );
		
		objMngr.registerObject( new MixerSettings() );
		
		objMngr.registerObject( new MixerStatus() );
		
		objMngr.registerObject( new ModuleSettings() );
		
		objMngr.registerObject( new NedAccel() );
		
		objMngr.registerObject( new NEDPosition() );
		
		objMngr.registerObject( new ObjectPersistence() );
		
		objMngr.registerObject( new OPLinkSettings() );
		
		objMngr.registerObject( new OPLinkStatus() );
		
		objMngr.registerObject( new OveroSyncSettings() );
		
		objMngr.registerObject( new OveroSyncStats() );
		
		objMngr.registerObject( new PathDesired() );
		
		objMngr.registerObject( new PathPlannerSettings() );
		
		objMngr.registerObject( new PathStatus() );
		
		objMngr.registerObject( new PicoCSettings() );
		
		objMngr.registerObject( new PicoCStatus() );
		
		objMngr.registerObject( new PoiLocation() );
		
		objMngr.registerObject( new PositionActual() );
		
		objMngr.registerObject( new RateDesired() );
		
		objMngr.registerObject( new ReceiverActivity() );
		
		objMngr.registerObject( new SensorSettings() );
		
		objMngr.registerObject( new SessionManaging() );
		
		objMngr.registerObject( new SonarAltitude() );
		
		objMngr.registerObject( new StabilizationDesired() );
		
		objMngr.registerObject( new StabilizationSettings() );
		
		objMngr.registerObject( new StateEstimation() );
		
		objMngr.registerObject( new SystemAlarms() );
		
		objMngr.registerObject( new SystemIdent() );
		
		objMngr.registerObject( new SystemSettings() );
		
		objMngr.registerObject( new SystemStats() );
		
		objMngr.registerObject( new TabletInfo() );
		
		objMngr.registerObject( new TaskInfo() );
		
		objMngr.registerObject( new TrimAngles() );
		
		objMngr.registerObject( new TrimAnglesSettings() );
		
		objMngr.registerObject( new TxPIDSettings() );
		
		objMngr.registerObject( new UBloxInfo() );
		
		objMngr.registerObject( new VelocityActual() );
		
		objMngr.registerObject( new VelocityDesired() );
		
		objMngr.registerObject( new VibrationAnalysisOutput() );
		
		objMngr.registerObject( new VibrationAnalysisSettings() );
		
		objMngr.registerObject( new VtolPathFollowerSettings() );
		
		objMngr.registerObject( new VtolPathFollowerStatus() );
		
		objMngr.registerObject( new WatchdogStatus() );
		
		objMngr.registerObject( new Waypoint() );
		
		objMngr.registerObject( new WaypointActive() );
		
		objMngr.registerObject( new WindVelocityActual() );
	}
}
// Generated helper templates
// Generated items
// UavTalk\WindVelocityActual.cs
// UavTalk\WaypointActive.cs
// UavTalk\Waypoint.cs
// UavTalk\WatchdogStatus.cs
// UavTalk\VtolPathFollowerStatus.cs
// UavTalk\VtolPathFollowerSettings.cs
// UavTalk\VibrationAnalysisSettings.cs
// UavTalk\VibrationAnalysisOutput.cs
// UavTalk\VelocityDesired.cs
// UavTalk\VelocityActual.cs
// UavTalk\UBloxInfo.cs
// UavTalk\TxPIDSettings.cs
// UavTalk\TrimAnglesSettings.cs
// UavTalk\TrimAngles.cs
// UavTalk\TaskInfo.cs
// UavTalk\TabletInfo.cs
// UavTalk\SystemStats.cs
// UavTalk\SystemSettings.cs
// UavTalk\SystemIdent.cs
// UavTalk\SystemAlarms.cs
// UavTalk\StateEstimation.cs
// UavTalk\StabilizationSettings.cs
// UavTalk\StabilizationDesired.cs
// UavTalk\SonarAltitude.cs
// UavTalk\SessionManaging.cs
// UavTalk\SensorSettings.cs
// UavTalk\ReceiverActivity.cs
// UavTalk\RateDesired.cs
// UavTalk\PositionActual.cs
// UavTalk\PoiLocation.cs
// UavTalk\PicoCStatus.cs
// UavTalk\PicoCSettings.cs
// UavTalk\PathStatus.cs
// UavTalk\PathPlannerSettings.cs
// UavTalk\PathDesired.cs
// UavTalk\OveroSyncStats.cs
// UavTalk\OveroSyncSettings.cs
// UavTalk\OPLinkStatus.cs
// UavTalk\OPLinkSettings.cs
// UavTalk\ObjectPersistence.cs
// UavTalk\NEDPosition.cs
// UavTalk\NedAccel.cs
// UavTalk\ModuleSettings.cs
// UavTalk\MixerStatus.cs
// UavTalk\MixerSettings.cs
// UavTalk\ManualControlSettings.cs
// UavTalk\ManualControlCommand.cs
// UavTalk\Magnetometer.cs
// UavTalk\MagBias.cs
// UavTalk\LoiterCommand.cs
// UavTalk\INSState.cs
// UavTalk\INSSettings.cs
// UavTalk\I2CVMUserProgram.cs
// UavTalk\I2CVM.cs
// UavTalk\HwSparkyBGC.cs
// UavTalk\HwSparky.cs
// UavTalk\HwRevoMini.cs
// UavTalk\HwRevolution.cs
// UavTalk\HwQuanton.cs
// UavTalk\HwFreedom.cs
// UavTalk\HwFlyingF4.cs
// UavTalk\HwFlyingF3.cs
// UavTalk\HwDiscoveryF4.cs
// UavTalk\HwCopterControl.cs
// UavTalk\HwColibri.cs
// UavTalk\HoTTSettings.cs
// UavTalk\HomeLocation.cs
// UavTalk\GyrosBias.cs
// UavTalk\Gyros.cs
// UavTalk\GroundTruth.cs
// UavTalk\GroundPathFollowerSettings.cs
// UavTalk\GPSVelocity.cs
// UavTalk\GPSTime.cs
// UavTalk\GPSSatellites.cs
// UavTalk\GPSPosition.cs
// UavTalk\GeoFenceSettings.cs
// UavTalk\GCSTelemetryStats.cs
// UavTalk\GCSReceiver.cs
// UavTalk\FlightTelemetryStats.cs
// UavTalk\FlightStatus.cs
// UavTalk\FlightPlanStatus.cs
// UavTalk\FlightPlanSettings.cs
// UavTalk\FlightPlanControl.cs
// UavTalk\FlightBatteryState.cs
// UavTalk\FlightBatterySettings.cs
// UavTalk\FixedWingPathFollowerStatus.cs
// UavTalk\FixedWingPathFollowerSettingsCC.cs
// UavTalk\FixedWingPathFollowerSettings.cs
// UavTalk\FixedWingAirspeeds.cs
// UavTalk\FirmwareIAPObj.cs
// UavTalk\FaultSettings.cs
// UavTalk\CameraStabSettings.cs
// UavTalk\CameraDesired.cs
// UavTalk\BrushlessGimbalSettings.cs
// UavTalk\BaroAltitude.cs
// UavTalk\BaroAirspeed.cs
// UavTalk\AttitudeSimulated.cs
// UavTalk\AttitudeSettings.cs
// UavTalk\AttitudeActual.cs
// UavTalk\AltitudeHoldSettings.cs
// UavTalk\AltitudeHoldDesired.cs
// UavTalk\AirspeedSettings.cs
// UavTalk\AirspeedActual.cs
// UavTalk\ActuatorSettings.cs
// UavTalk\ActuatorDesired.cs
// UavTalk\ActuatorCommand.cs
// UavTalk\AccessoryDesired.cs
// UavTalk\Accels.cs
// UavTalk\AccelDesired.cs
