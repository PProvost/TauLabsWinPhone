// Object ID: 3797800718
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class SystemAlarms : UAVDataObject
	{
		public const long OBJID = 3797800718;
		public int NUMBYTES { get; set; }
		protected const String NAME = "SystemAlarms";
	    protected static String DESCRIPTION = @"Alarms from OpenPilot to indicate failure conditions or warnings.  Set by various modules.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = false;

		public enum AlarmUavEnum
		{
			[Description("Uninitialised")]
			Uninitialised = 0, 
			[Description("OK")]
			OK = 1, 
			[Description("Warning")]
			Warning = 2, 
			[Description("Error")]
			Error = 3, 
			[Description("Critical")]
			Critical = 4, 
		}
		public UAVObjectField<AlarmUavEnum> Alarm;
		public enum ConfigErrorUavEnum
		{
			[Description("Stabilization")]
			Stabilization = 0, 
			[Description("Multirotor")]
			Multirotor = 1, 
			[Description("AutoTune")]
			AutoTune = 2, 
			[Description("AltitudeHold")]
			AltitudeHold = 3, 
			[Description("VelocityControl")]
			VelocityControl = 4, 
			[Description("PositionHold")]
			PositionHold = 5, 
			[Description("PathPlanner")]
			PathPlanner = 6, 
			[Description("NavFilter")]
			NavFilter = 7, 
			[Description("UnsafeToArm")]
			UnsafeToArm = 8, 
			[Description("Undefined")]
			Undefined = 9, 
			[Description("None")]
			None = 10, 
		}
		public UAVObjectField<ConfigErrorUavEnum> ConfigError;
		public enum ManualControlUavEnum
		{
			[Description("Settings")]
			Settings = 0, 
			[Description("NoRx")]
			NoRx = 1, 
			[Description("Accessory")]
			Accessory = 2, 
			[Description("AltitudeHold")]
			AltitudeHold = 3, 
			[Description("PathFollower")]
			PathFollower = 4, 
			[Description("Undefined")]
			Undefined = 5, 
			[Description("None")]
			None = 6, 
		}
		public UAVObjectField<ManualControlUavEnum> ManualControl;
		public enum StateEstimationUavEnum
		{
			[Description("Gyro queue not updating")]
			Gyroqueuenotupdating = 0, 
			[Description("Accelerometer queue not updating")]
			Accelerometerqueuenotupdating = 1, 
			[Description("No GPS")]
			NoGPS = 2, 
			[Description("No magnetometer")]
			Nomagnetometer = 3, 
			[Description("No barometer")]
			Nobarometer = 4, 
			[Description("No home")]
			Nohome = 5, 
			[Description("Too few satellites")]
			Toofewsatellites = 6, 
			[Description("PDOP too high")]
			PDOPtoohigh = 7, 
			[Description("Undefined")]
			Undefined = 8, 
			[Description("None")]
			None = 9, 
		}
		public UAVObjectField<StateEstimationUavEnum> StateEstimation;

		public SystemAlarms() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> AlarmElemNames = new List<String>();
			AlarmElemNames.Add("OutOfMemory");
			AlarmElemNames.Add("CPUOverload");
			AlarmElemNames.Add("StackOverflow");
			AlarmElemNames.Add("SystemConfiguration");
			AlarmElemNames.Add("EventSystem");
			AlarmElemNames.Add("Telemetry");
			AlarmElemNames.Add("ManualControl");
			AlarmElemNames.Add("Actuator");
			AlarmElemNames.Add("Attitude");
			AlarmElemNames.Add("Sensors");
			AlarmElemNames.Add("Stabilization");
			AlarmElemNames.Add("Geofence");
			AlarmElemNames.Add("PathFollower");
			AlarmElemNames.Add("PathPlanner");
			AlarmElemNames.Add("Battery");
			AlarmElemNames.Add("FlightTime");
			AlarmElemNames.Add("I2C");
			AlarmElemNames.Add("GPS");
			AlarmElemNames.Add("AltitudeHold");
			AlarmElemNames.Add("BootFault");
			List<String> AlarmEnumOptions = new List<String>();
			AlarmEnumOptions.Add("Uninitialised");
			AlarmEnumOptions.Add("OK");
			AlarmEnumOptions.Add("Warning");
			AlarmEnumOptions.Add("Error");
			AlarmEnumOptions.Add("Critical");
			Alarm=new UAVObjectField<AlarmUavEnum>("Alarm", "", AlarmElemNames, AlarmEnumOptions, this);
			fields.Add(Alarm);

			List<String> ConfigErrorElemNames = new List<String>();
			ConfigErrorElemNames.Add("0");
			List<String> ConfigErrorEnumOptions = new List<String>();
			ConfigErrorEnumOptions.Add("Stabilization");
			ConfigErrorEnumOptions.Add("Multirotor");
			ConfigErrorEnumOptions.Add("AutoTune");
			ConfigErrorEnumOptions.Add("AltitudeHold");
			ConfigErrorEnumOptions.Add("VelocityControl");
			ConfigErrorEnumOptions.Add("PositionHold");
			ConfigErrorEnumOptions.Add("PathPlanner");
			ConfigErrorEnumOptions.Add("NavFilter");
			ConfigErrorEnumOptions.Add("UnsafeToArm");
			ConfigErrorEnumOptions.Add("Undefined");
			ConfigErrorEnumOptions.Add("None");
			ConfigError=new UAVObjectField<ConfigErrorUavEnum>("ConfigError", "", ConfigErrorElemNames, ConfigErrorEnumOptions, this);
			fields.Add(ConfigError);

			List<String> ManualControlElemNames = new List<String>();
			ManualControlElemNames.Add("0");
			List<String> ManualControlEnumOptions = new List<String>();
			ManualControlEnumOptions.Add("Settings");
			ManualControlEnumOptions.Add("NoRx");
			ManualControlEnumOptions.Add("Accessory");
			ManualControlEnumOptions.Add("AltitudeHold");
			ManualControlEnumOptions.Add("PathFollower");
			ManualControlEnumOptions.Add("Undefined");
			ManualControlEnumOptions.Add("None");
			ManualControl=new UAVObjectField<ManualControlUavEnum>("ManualControl", "", ManualControlElemNames, ManualControlEnumOptions, this);
			fields.Add(ManualControl);

			List<String> StateEstimationElemNames = new List<String>();
			StateEstimationElemNames.Add("0");
			List<String> StateEstimationEnumOptions = new List<String>();
			StateEstimationEnumOptions.Add("Gyro queue not updating");
			StateEstimationEnumOptions.Add("Accelerometer queue not updating");
			StateEstimationEnumOptions.Add("No GPS");
			StateEstimationEnumOptions.Add("No magnetometer");
			StateEstimationEnumOptions.Add("No barometer");
			StateEstimationEnumOptions.Add("No home");
			StateEstimationEnumOptions.Add("Too few satellites");
			StateEstimationEnumOptions.Add("PDOP too high");
			StateEstimationEnumOptions.Add("Undefined");
			StateEstimationEnumOptions.Add("None");
			StateEstimation=new UAVObjectField<StateEstimationUavEnum>("StateEstimation", "", StateEstimationElemNames, StateEstimationEnumOptions, this);
			fields.Add(StateEstimation);

	

			// Compute the number of bytes for this object
            NUMBYTES = fields.Sum(j => j.getNumBytes());
			
			// Initialize object
			initializeFields(fields, new ByteBuffer(NUMBYTES), NUMBYTES);
			// Set the default field values
			setDefaultFieldValues();
			// Set the object description
			setDescription(DESCRIPTION);
		}

		/**
		 * Create a Metadata object filled with default values for this object
		 * @return Metadata object with default values
		 */
		public override Metadata getDefaultMetadata() {
			Metadata metadata = new Metadata();
    		metadata.flags =
				(int)AccessMode.ACCESS_READWRITE << Metadata.UAVOBJ_ACCESS_SHIFT |
				(int)AccessMode.ACCESS_READWRITE << Metadata.UAVOBJ_GCS_ACCESS_SHIFT |
				1 << Metadata.UAVOBJ_TELEMETRY_ACKED_SHIFT |
				1 << Metadata.UAVOBJ_GCS_TELEMETRY_ACKED_SHIFT |
				(int)UPDATEMODE.UPDATEMODE_ONCHANGE << Metadata.UAVOBJ_TELEMETRY_UPDATE_MODE_SHIFT |
				(int)UPDATEMODE.UPDATEMODE_ONCHANGE << Metadata.UAVOBJ_GCS_TELEMETRY_UPDATE_MODE_SHIFT;
    		metadata.flightTelemetryUpdatePeriod = 0;
    		metadata.gcsTelemetryUpdatePeriod = 0;
    		metadata.loggingUpdatePeriod = 1000;
 
			return metadata;
		}

		/**
		 * Initialize object fields with the default values.
		 * If a default value is not specified the object fields
		 * will be initialized to zero.
		 */
		public void setDefaultFieldValues()
		{
			Alarm.setValue(AlarmUavEnum.Uninitialised,0);
			Alarm.setValue(AlarmUavEnum.Uninitialised,1);
			Alarm.setValue(AlarmUavEnum.Uninitialised,2);
			Alarm.setValue(AlarmUavEnum.Uninitialised,3);
			Alarm.setValue(AlarmUavEnum.Uninitialised,4);
			Alarm.setValue(AlarmUavEnum.Uninitialised,5);
			Alarm.setValue(AlarmUavEnum.Uninitialised,6);
			Alarm.setValue(AlarmUavEnum.Uninitialised,7);
			Alarm.setValue(AlarmUavEnum.Uninitialised,8);
			Alarm.setValue(AlarmUavEnum.Uninitialised,9);
			Alarm.setValue(AlarmUavEnum.Uninitialised,10);
			Alarm.setValue(AlarmUavEnum.Uninitialised,11);
			Alarm.setValue(AlarmUavEnum.Uninitialised,12);
			Alarm.setValue(AlarmUavEnum.Uninitialised,13);
			Alarm.setValue(AlarmUavEnum.Uninitialised,14);
			Alarm.setValue(AlarmUavEnum.Uninitialised,15);
			Alarm.setValue(AlarmUavEnum.Uninitialised,16);
			Alarm.setValue(AlarmUavEnum.Uninitialised,17);
			Alarm.setValue(AlarmUavEnum.Uninitialised,18);
			Alarm.setValue(AlarmUavEnum.Uninitialised,19);
			ConfigError.setValue(ConfigErrorUavEnum.None);
			ManualControl.setValue(ManualControlUavEnum.None);
			StateEstimation.setValue(StateEstimationUavEnum.None);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				SystemAlarms obj = new SystemAlarms();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public SystemAlarms GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (SystemAlarms)(objMngr.getObject(SystemAlarms.OBJID, instID));
		}
	}
}
