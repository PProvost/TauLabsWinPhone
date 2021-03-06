﻿// Object ID: 1350043392
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class ModuleSettings : UAVDataObject
	{
		public const long OBJID = 1350043392;
		public int NUMBYTES { get; set; }
		protected const String NAME = "ModuleSettings";
	    protected static String DESCRIPTION = @"Optional module enable/disable configuration.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public enum AdminStateUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Enabled")]
			Enabled = 1, 
		}
		public UAVObjectField<AdminStateUavEnum> AdminState;
		public enum TelemetrySpeedUavEnum
		{
			[Description("2400")]
			v2400 = 0, 
			[Description("4800")]
			v4800 = 1, 
			[Description("9600")]
			v9600 = 2, 
			[Description("19200")]
			v19200 = 3, 
			[Description("38400")]
			v38400 = 4, 
			[Description("57600")]
			v57600 = 5, 
			[Description("115200")]
			v115200 = 6, 
		}
		public UAVObjectField<TelemetrySpeedUavEnum> TelemetrySpeed;
		public enum GPSSpeedUavEnum
		{
			[Description("2400")]
			v2400 = 0, 
			[Description("4800")]
			v4800 = 1, 
			[Description("9600")]
			v9600 = 2, 
			[Description("19200")]
			v19200 = 3, 
			[Description("38400")]
			v38400 = 4, 
			[Description("57600")]
			v57600 = 5, 
			[Description("115200")]
			v115200 = 6, 
			[Description("230400")]
			v230400 = 7, 
		}
		public UAVObjectField<GPSSpeedUavEnum> GPSSpeed;
		public enum GPSDataProtocolUavEnum
		{
			[Description("NMEA")]
			NMEA = 0, 
			[Description("UBX")]
			UBX = 1, 
		}
		public UAVObjectField<GPSDataProtocolUavEnum> GPSDataProtocol;
		public enum GPSAutoConfigureUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<GPSAutoConfigureUavEnum> GPSAutoConfigure;
		public enum ComUsbBridgeSpeedUavEnum
		{
			[Description("2400")]
			v2400 = 0, 
			[Description("4800")]
			v4800 = 1, 
			[Description("9600")]
			v9600 = 2, 
			[Description("19200")]
			v19200 = 3, 
			[Description("38400")]
			v38400 = 4, 
			[Description("57600")]
			v57600 = 5, 
			[Description("115200")]
			v115200 = 6, 
		}
		public UAVObjectField<ComUsbBridgeSpeedUavEnum> ComUsbBridgeSpeed;
		public enum I2CVMProgramSelectUavEnum
		{
			[Description("EndianTest")]
			EndianTest = 0, 
			[Description("MathTest")]
			MathTest = 1, 
			[Description("None")]
			None = 2, 
			[Description("OPBaroAltimeter")]
			OPBaroAltimeter = 3, 
			[Description("User")]
			User = 4, 
		}
		public UAVObjectField<I2CVMProgramSelectUavEnum> I2CVMProgramSelect;
		public enum MavlinkSpeedUavEnum
		{
			[Description("2400")]
			v2400 = 0, 
			[Description("4800")]
			v4800 = 1, 
			[Description("9600")]
			v9600 = 2, 
			[Description("19200")]
			v19200 = 3, 
			[Description("38400")]
			v38400 = 4, 
			[Description("57600")]
			v57600 = 5, 
			[Description("115200")]
			v115200 = 6, 
		}
		public UAVObjectField<MavlinkSpeedUavEnum> MavlinkSpeed;
		public enum LightTelemetrySpeedUavEnum
		{
			[Description("1200")]
			v1200 = 0, 
			[Description("2400")]
			v2400 = 1, 
			[Description("4800")]
			v4800 = 2, 
			[Description("9600")]
			v9600 = 3, 
			[Description("19200")]
			v19200 = 4, 
			[Description("38400")]
			v38400 = 5, 
			[Description("57600")]
			v57600 = 6, 
			[Description("115200")]
			v115200 = 7, 
		}
		public UAVObjectField<LightTelemetrySpeedUavEnum> LightTelemetrySpeed;

		public ModuleSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> AdminStateElemNames = new List<String>();
			AdminStateElemNames.Add("Airspeed");
			AdminStateElemNames.Add("AltitudeHold");
			AdminStateElemNames.Add("Autotune");
			AdminStateElemNames.Add("Battery");
			AdminStateElemNames.Add("CameraStab");
			AdminStateElemNames.Add("ComUsbBridge");
			AdminStateElemNames.Add("FixedWingPathFollower");
			AdminStateElemNames.Add("Fault");
			AdminStateElemNames.Add("GPS");
			AdminStateElemNames.Add("OveroSync");
			AdminStateElemNames.Add("PathPlanner");
			AdminStateElemNames.Add("TxPID");
			AdminStateElemNames.Add("VtolPathFollower");
			AdminStateElemNames.Add("GroundPathFollower");
			AdminStateElemNames.Add("GenericI2CSensor");
			AdminStateElemNames.Add("UAVOMavlinkBridge");
			AdminStateElemNames.Add("UAVOLighttelemetryBridge");
			AdminStateElemNames.Add("UAVORelay");
			AdminStateElemNames.Add("VibrationAnalysis");
			AdminStateElemNames.Add("UAVOHoTTBridge");
			AdminStateElemNames.Add("UAVOFrSKYSensorHubBridge");
			AdminStateElemNames.Add("PicoC");
			AdminStateElemNames.Add("UAVOFrSkySPortBridge");
			AdminStateElemNames.Add("Geofence");
			List<String> AdminStateEnumOptions = new List<String>();
			AdminStateEnumOptions.Add("Disabled");
			AdminStateEnumOptions.Add("Enabled");
			AdminState=new UAVObjectField<AdminStateUavEnum>("AdminState", "", AdminStateElemNames, AdminStateEnumOptions, this);
			fields.Add(AdminState);

			List<String> TelemetrySpeedElemNames = new List<String>();
			TelemetrySpeedElemNames.Add("0");
			List<String> TelemetrySpeedEnumOptions = new List<String>();
			TelemetrySpeedEnumOptions.Add("2400");
			TelemetrySpeedEnumOptions.Add("4800");
			TelemetrySpeedEnumOptions.Add("9600");
			TelemetrySpeedEnumOptions.Add("19200");
			TelemetrySpeedEnumOptions.Add("38400");
			TelemetrySpeedEnumOptions.Add("57600");
			TelemetrySpeedEnumOptions.Add("115200");
			TelemetrySpeed=new UAVObjectField<TelemetrySpeedUavEnum>("TelemetrySpeed", "bps", TelemetrySpeedElemNames, TelemetrySpeedEnumOptions, this);
			fields.Add(TelemetrySpeed);

			List<String> GPSSpeedElemNames = new List<String>();
			GPSSpeedElemNames.Add("0");
			List<String> GPSSpeedEnumOptions = new List<String>();
			GPSSpeedEnumOptions.Add("2400");
			GPSSpeedEnumOptions.Add("4800");
			GPSSpeedEnumOptions.Add("9600");
			GPSSpeedEnumOptions.Add("19200");
			GPSSpeedEnumOptions.Add("38400");
			GPSSpeedEnumOptions.Add("57600");
			GPSSpeedEnumOptions.Add("115200");
			GPSSpeedEnumOptions.Add("230400");
			GPSSpeed=new UAVObjectField<GPSSpeedUavEnum>("GPSSpeed", "bps", GPSSpeedElemNames, GPSSpeedEnumOptions, this);
			fields.Add(GPSSpeed);

			List<String> GPSDataProtocolElemNames = new List<String>();
			GPSDataProtocolElemNames.Add("0");
			List<String> GPSDataProtocolEnumOptions = new List<String>();
			GPSDataProtocolEnumOptions.Add("NMEA");
			GPSDataProtocolEnumOptions.Add("UBX");
			GPSDataProtocol=new UAVObjectField<GPSDataProtocolUavEnum>("GPSDataProtocol", "", GPSDataProtocolElemNames, GPSDataProtocolEnumOptions, this);
			fields.Add(GPSDataProtocol);

			List<String> GPSAutoConfigureElemNames = new List<String>();
			GPSAutoConfigureElemNames.Add("0");
			List<String> GPSAutoConfigureEnumOptions = new List<String>();
			GPSAutoConfigureEnumOptions.Add("FALSE");
			GPSAutoConfigureEnumOptions.Add("TRUE");
			GPSAutoConfigure=new UAVObjectField<GPSAutoConfigureUavEnum>("GPSAutoConfigure", "", GPSAutoConfigureElemNames, GPSAutoConfigureEnumOptions, this);
			fields.Add(GPSAutoConfigure);

			List<String> ComUsbBridgeSpeedElemNames = new List<String>();
			ComUsbBridgeSpeedElemNames.Add("0");
			List<String> ComUsbBridgeSpeedEnumOptions = new List<String>();
			ComUsbBridgeSpeedEnumOptions.Add("2400");
			ComUsbBridgeSpeedEnumOptions.Add("4800");
			ComUsbBridgeSpeedEnumOptions.Add("9600");
			ComUsbBridgeSpeedEnumOptions.Add("19200");
			ComUsbBridgeSpeedEnumOptions.Add("38400");
			ComUsbBridgeSpeedEnumOptions.Add("57600");
			ComUsbBridgeSpeedEnumOptions.Add("115200");
			ComUsbBridgeSpeed=new UAVObjectField<ComUsbBridgeSpeedUavEnum>("ComUsbBridgeSpeed", "bps", ComUsbBridgeSpeedElemNames, ComUsbBridgeSpeedEnumOptions, this);
			fields.Add(ComUsbBridgeSpeed);

			List<String> I2CVMProgramSelectElemNames = new List<String>();
			I2CVMProgramSelectElemNames.Add("0");
			List<String> I2CVMProgramSelectEnumOptions = new List<String>();
			I2CVMProgramSelectEnumOptions.Add("EndianTest");
			I2CVMProgramSelectEnumOptions.Add("MathTest");
			I2CVMProgramSelectEnumOptions.Add("None");
			I2CVMProgramSelectEnumOptions.Add("OPBaroAltimeter");
			I2CVMProgramSelectEnumOptions.Add("User");
			I2CVMProgramSelect=new UAVObjectField<I2CVMProgramSelectUavEnum>("I2CVMProgramSelect", "", I2CVMProgramSelectElemNames, I2CVMProgramSelectEnumOptions, this);
			fields.Add(I2CVMProgramSelect);

			List<String> MavlinkSpeedElemNames = new List<String>();
			MavlinkSpeedElemNames.Add("0");
			List<String> MavlinkSpeedEnumOptions = new List<String>();
			MavlinkSpeedEnumOptions.Add("2400");
			MavlinkSpeedEnumOptions.Add("4800");
			MavlinkSpeedEnumOptions.Add("9600");
			MavlinkSpeedEnumOptions.Add("19200");
			MavlinkSpeedEnumOptions.Add("38400");
			MavlinkSpeedEnumOptions.Add("57600");
			MavlinkSpeedEnumOptions.Add("115200");
			MavlinkSpeed=new UAVObjectField<MavlinkSpeedUavEnum>("MavlinkSpeed", "bps", MavlinkSpeedElemNames, MavlinkSpeedEnumOptions, this);
			fields.Add(MavlinkSpeed);

			List<String> LightTelemetrySpeedElemNames = new List<String>();
			LightTelemetrySpeedElemNames.Add("0");
			List<String> LightTelemetrySpeedEnumOptions = new List<String>();
			LightTelemetrySpeedEnumOptions.Add("1200");
			LightTelemetrySpeedEnumOptions.Add("2400");
			LightTelemetrySpeedEnumOptions.Add("4800");
			LightTelemetrySpeedEnumOptions.Add("9600");
			LightTelemetrySpeedEnumOptions.Add("19200");
			LightTelemetrySpeedEnumOptions.Add("38400");
			LightTelemetrySpeedEnumOptions.Add("57600");
			LightTelemetrySpeedEnumOptions.Add("115200");
			LightTelemetrySpeed=new UAVObjectField<LightTelemetrySpeedUavEnum>("LightTelemetrySpeed", "bps", LightTelemetrySpeedElemNames, LightTelemetrySpeedEnumOptions, this);
			fields.Add(LightTelemetrySpeed);

	

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
    		metadata.loggingUpdatePeriod = 0;
 
			return metadata;
		}

		/**
		 * Initialize object fields with the default values.
		 * If a default value is not specified the object fields
		 * will be initialized to zero.
		 */
		public void setDefaultFieldValues()
		{
			AdminState.setValue(AdminStateUavEnum.Disabled,0);
			AdminState.setValue(AdminStateUavEnum.Disabled,1);
			AdminState.setValue(AdminStateUavEnum.Disabled,2);
			AdminState.setValue(AdminStateUavEnum.Disabled,3);
			AdminState.setValue(AdminStateUavEnum.Disabled,4);
			AdminState.setValue(AdminStateUavEnum.Disabled,5);
			AdminState.setValue(AdminStateUavEnum.Disabled,6);
			AdminState.setValue(AdminStateUavEnum.Disabled,7);
			AdminState.setValue(AdminStateUavEnum.Disabled,8);
			AdminState.setValue(AdminStateUavEnum.Disabled,9);
			AdminState.setValue(AdminStateUavEnum.Disabled,10);
			AdminState.setValue(AdminStateUavEnum.Disabled,11);
			AdminState.setValue(AdminStateUavEnum.Disabled,12);
			AdminState.setValue(AdminStateUavEnum.Disabled,13);
			AdminState.setValue(AdminStateUavEnum.Disabled,14);
			AdminState.setValue(AdminStateUavEnum.Disabled,15);
			AdminState.setValue(AdminStateUavEnum.Disabled,16);
			AdminState.setValue(AdminStateUavEnum.Disabled,17);
			AdminState.setValue(AdminStateUavEnum.Disabled,18);
			AdminState.setValue(AdminStateUavEnum.Disabled,19);
			AdminState.setValue(AdminStateUavEnum.Disabled,20);
			AdminState.setValue(AdminStateUavEnum.Disabled,21);
			AdminState.setValue(AdminStateUavEnum.Disabled,22);
			AdminState.setValue(AdminStateUavEnum.Disabled,23);
			TelemetrySpeed.setValue(TelemetrySpeedUavEnum.v57600);
			GPSSpeed.setValue(GPSSpeedUavEnum.v57600);
			GPSDataProtocol.setValue(GPSDataProtocolUavEnum.UBX);
			GPSAutoConfigure.setValue(GPSAutoConfigureUavEnum.TRUE);
			ComUsbBridgeSpeed.setValue(ComUsbBridgeSpeedUavEnum.v57600);
			I2CVMProgramSelect.setValue(I2CVMProgramSelectUavEnum.None);
			MavlinkSpeed.setValue(MavlinkSpeedUavEnum.v57600);
			LightTelemetrySpeed.setValue(LightTelemetrySpeedUavEnum.v2400);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				ModuleSettings obj = new ModuleSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public ModuleSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (ModuleSettings)(objMngr.getObject(ModuleSettings.OBJID, instID));
		}
	}
}
