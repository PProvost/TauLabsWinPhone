// Object ID: 1824264450
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class HoTTSettings : UAVDataObject
	{
		public const long OBJID = 1824264450;
		public int NUMBYTES { get; set; }
		protected const String NAME = "HoTTSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref HoTT Telemetry Module";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> Limit;
		public enum SensorUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Enabled")]
			Enabled = 1, 
		}
		public UAVObjectField<SensorUavEnum> Sensor;
		public enum WarningUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Enabled")]
			Enabled = 1, 
		}
		public UAVObjectField<WarningUavEnum> Warning;

		public HoTTSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> LimitElemNames = new List<String>();
			LimitElemNames.Add("MinSpeed");
			LimitElemNames.Add("MaxSpeed");
			LimitElemNames.Add("NegDifference1");
			LimitElemNames.Add("PosDifference1");
			LimitElemNames.Add("NegDifference2");
			LimitElemNames.Add("PosDifference2");
			LimitElemNames.Add("MinHeight");
			LimitElemNames.Add("MaxHeight");
			LimitElemNames.Add("MaxDistance");
			LimitElemNames.Add("MinPowerVoltage");
			LimitElemNames.Add("MaxPowerVoltage");
			LimitElemNames.Add("MinSensor1Voltage");
			LimitElemNames.Add("MaxSensor1Voltage");
			LimitElemNames.Add("MinSensor2Voltage");
			LimitElemNames.Add("MaxSensor2Voltage");
			LimitElemNames.Add("MinCellVoltage");
			LimitElemNames.Add("MaxCurrent");
			LimitElemNames.Add("MaxUsedCapacity");
			LimitElemNames.Add("MinSensor1Temp");
			LimitElemNames.Add("MaxSensor1Temp");
			LimitElemNames.Add("MinSensor2Temp");
			LimitElemNames.Add("MaxSensor2Temp");
			LimitElemNames.Add("MaxServoTemp");
			LimitElemNames.Add("MinRPM");
			LimitElemNames.Add("MaxRPM");
			LimitElemNames.Add("MinFuel");
			LimitElemNames.Add("MaxServoDifference");
			Limit=new UAVObjectField<float>("Limit", "(km/h)/(m/s)/m/V/A/mAh/C/ml", LimitElemNames, null, this);
			fields.Add(Limit);

			List<String> SensorElemNames = new List<String>();
			SensorElemNames.Add("VARIO");
			SensorElemNames.Add("GPS");
			SensorElemNames.Add("EAM");
			SensorElemNames.Add("GAM");
			SensorElemNames.Add("ESC");
			List<String> SensorEnumOptions = new List<String>();
			SensorEnumOptions.Add("Disabled");
			SensorEnumOptions.Add("Enabled");
			Sensor=new UAVObjectField<SensorUavEnum>("Sensor", "", SensorElemNames, SensorEnumOptions, this);
			fields.Add(Sensor);

			List<String> WarningElemNames = new List<String>();
			WarningElemNames.Add("AltitudeBeep");
			WarningElemNames.Add("MinSpeed");
			WarningElemNames.Add("MaxSpeed");
			WarningElemNames.Add("NegDifference1");
			WarningElemNames.Add("PosDifference1");
			WarningElemNames.Add("NegDifference2");
			WarningElemNames.Add("PosDifference2");
			WarningElemNames.Add("MinHeight");
			WarningElemNames.Add("MaxHeight");
			WarningElemNames.Add("MaxDistance");
			WarningElemNames.Add("MinPowerVoltage");
			WarningElemNames.Add("MaxPowerVoltage");
			WarningElemNames.Add("MinSensor1Voltage");
			WarningElemNames.Add("MaxSensor1Voltage");
			WarningElemNames.Add("MinSensor2Voltage");
			WarningElemNames.Add("MaxSensor2Voltage");
			WarningElemNames.Add("MinCellVoltage");
			WarningElemNames.Add("MaxCurrent");
			WarningElemNames.Add("MaxUsedCapacity");
			WarningElemNames.Add("MinSensor1Temp");
			WarningElemNames.Add("MaxSensor1Temp");
			WarningElemNames.Add("MinSensor2Temp");
			WarningElemNames.Add("MaxSensor2Temp");
			WarningElemNames.Add("MaxServoTemp");
			WarningElemNames.Add("MinRPM");
			WarningElemNames.Add("MaxRPM");
			WarningElemNames.Add("MinFuel");
			WarningElemNames.Add("MaxServoDifference");
			List<String> WarningEnumOptions = new List<String>();
			WarningEnumOptions.Add("Disabled");
			WarningEnumOptions.Add("Enabled");
			Warning=new UAVObjectField<WarningUavEnum>("Warning", "", WarningElemNames, WarningEnumOptions, this);
			fields.Add(Warning);

	

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
			Limit.setValue((float)30,0);
			Limit.setValue((float)100,1);
			Limit.setValue((float)-10,2);
			Limit.setValue((float)10,3);
			Limit.setValue((float)-1,4);
			Limit.setValue((float)1,5);
			Limit.setValue((float)20,6);
			Limit.setValue((float)500,7);
			Limit.setValue((float)1500,8);
			Limit.setValue((float)5,9);
			Limit.setValue((float)30,10);
			Limit.setValue((float)5,11);
			Limit.setValue((float)30,12);
			Limit.setValue((float)5,13);
			Limit.setValue((float)30,14);
			Limit.setValue((float)3.3,15);
			Limit.setValue((float)40,16);
			Limit.setValue((float)2000,17);
			Limit.setValue((float)0,18);
			Limit.setValue((float)100,19);
			Limit.setValue((float)0,20);
			Limit.setValue((float)100,21);
			Limit.setValue((float)100,22);
			Limit.setValue((float)100,23);
			Limit.setValue((float)7000,24);
			Limit.setValue((float)1000,25);
			Limit.setValue((float)0,26);
			Sensor.setValue(SensorUavEnum.Disabled,0);
			Sensor.setValue(SensorUavEnum.Disabled,1);
			Sensor.setValue(SensorUavEnum.Disabled,2);
			Sensor.setValue(SensorUavEnum.Disabled,3);
			Sensor.setValue(SensorUavEnum.Disabled,4);
			Warning.setValue(WarningUavEnum.Disabled,0);
			Warning.setValue(WarningUavEnum.Disabled,1);
			Warning.setValue(WarningUavEnum.Disabled,2);
			Warning.setValue(WarningUavEnum.Disabled,3);
			Warning.setValue(WarningUavEnum.Disabled,4);
			Warning.setValue(WarningUavEnum.Disabled,5);
			Warning.setValue(WarningUavEnum.Disabled,6);
			Warning.setValue(WarningUavEnum.Disabled,7);
			Warning.setValue(WarningUavEnum.Disabled,8);
			Warning.setValue(WarningUavEnum.Disabled,9);
			Warning.setValue(WarningUavEnum.Disabled,10);
			Warning.setValue(WarningUavEnum.Disabled,11);
			Warning.setValue(WarningUavEnum.Disabled,12);
			Warning.setValue(WarningUavEnum.Disabled,13);
			Warning.setValue(WarningUavEnum.Disabled,14);
			Warning.setValue(WarningUavEnum.Disabled,15);
			Warning.setValue(WarningUavEnum.Disabled,16);
			Warning.setValue(WarningUavEnum.Disabled,17);
			Warning.setValue(WarningUavEnum.Disabled,18);
			Warning.setValue(WarningUavEnum.Disabled,19);
			Warning.setValue(WarningUavEnum.Disabled,20);
			Warning.setValue(WarningUavEnum.Disabled,21);
			Warning.setValue(WarningUavEnum.Disabled,22);
			Warning.setValue(WarningUavEnum.Disabled,23);
			Warning.setValue(WarningUavEnum.Disabled,24);
			Warning.setValue(WarningUavEnum.Disabled,25);
			Warning.setValue(WarningUavEnum.Disabled,26);
			Warning.setValue(WarningUavEnum.Disabled,27);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				HoTTSettings obj = new HoTTSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public HoTTSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (HoTTSettings)(objMngr.getObject(HoTTSettings.OBJID, instID));
		}
	}
}
