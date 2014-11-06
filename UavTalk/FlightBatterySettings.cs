// Object ID: 2487701198
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class FlightBatterySettings : UAVDataObject
	{
		public const long OBJID = 2487701198;
		public int NUMBYTES { get; set; }
		protected const String NAME = "FlightBatterySettings";
	    protected static String DESCRIPTION = @"Flight Battery configuration.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<UInt32> Capacity;
		public UAVObjectField<float> VoltageThresholds;
		public UAVObjectField<float> SensorCalibrationFactor;
		public UAVObjectField<float> SensorCalibrationOffset;
		public enum CurrentPinUavEnum
		{
			[Description("ADC0")]
			ADC0 = 0, 
			[Description("ADC1")]
			ADC1 = 1, 
			[Description("ADC2")]
			ADC2 = 2, 
			[Description("ADC3")]
			ADC3 = 3, 
			[Description("ADC4")]
			ADC4 = 4, 
			[Description("ADC5")]
			ADC5 = 5, 
			[Description("ADC6")]
			ADC6 = 6, 
			[Description("ADC7")]
			ADC7 = 7, 
			[Description("ADC8")]
			ADC8 = 8, 
			[Description("NONE")]
			NONE = 9, 
		}
		public UAVObjectField<CurrentPinUavEnum> CurrentPin;
		public enum VoltagePinUavEnum
		{
			[Description("ADC0")]
			ADC0 = 0, 
			[Description("ADC1")]
			ADC1 = 1, 
			[Description("ADC2")]
			ADC2 = 2, 
			[Description("ADC3")]
			ADC3 = 3, 
			[Description("ADC4")]
			ADC4 = 4, 
			[Description("ADC5")]
			ADC5 = 5, 
			[Description("ADC6")]
			ADC6 = 6, 
			[Description("ADC7")]
			ADC7 = 7, 
			[Description("ADC8")]
			ADC8 = 8, 
			[Description("NONE")]
			NONE = 9, 
		}
		public UAVObjectField<VoltagePinUavEnum> VoltagePin;
		public enum TypeUavEnum
		{
			[Description("LiPo")]
			LiPo = 0, 
			[Description("A123")]
			A123 = 1, 
			[Description("LiCo")]
			LiCo = 2, 
			[Description("LiFeSO4")]
			LiFeSO4 = 3, 
			[Description("None")]
			None = 4, 
		}
		public UAVObjectField<TypeUavEnum> Type;
		public UAVObjectField<byte> NbCells;
		public enum SensorTypeUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Enabled")]
			Enabled = 1, 
		}
		public UAVObjectField<SensorTypeUavEnum> SensorType;

		public FlightBatterySettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> CapacityElemNames = new List<String>();
			CapacityElemNames.Add("0");
			Capacity=new UAVObjectField<UInt32>("Capacity", "mAh", CapacityElemNames, null, this);
			fields.Add(Capacity);

			List<String> VoltageThresholdsElemNames = new List<String>();
			VoltageThresholdsElemNames.Add("Warning");
			VoltageThresholdsElemNames.Add("Alarm");
			VoltageThresholds=new UAVObjectField<float>("VoltageThresholds", "V", VoltageThresholdsElemNames, null, this);
			fields.Add(VoltageThresholds);

			List<String> SensorCalibrationFactorElemNames = new List<String>();
			SensorCalibrationFactorElemNames.Add("Voltage");
			SensorCalibrationFactorElemNames.Add("Current");
			SensorCalibrationFactor=new UAVObjectField<float>("SensorCalibrationFactor", "mV/U", SensorCalibrationFactorElemNames, null, this);
			fields.Add(SensorCalibrationFactor);

			List<String> SensorCalibrationOffsetElemNames = new List<String>();
			SensorCalibrationOffsetElemNames.Add("Voltage");
			SensorCalibrationOffsetElemNames.Add("Current");
			SensorCalibrationOffset=new UAVObjectField<float>("SensorCalibrationOffset", "", SensorCalibrationOffsetElemNames, null, this);
			fields.Add(SensorCalibrationOffset);

			List<String> CurrentPinElemNames = new List<String>();
			CurrentPinElemNames.Add("0");
			List<String> CurrentPinEnumOptions = new List<String>();
			CurrentPinEnumOptions.Add("ADC0");
			CurrentPinEnumOptions.Add("ADC1");
			CurrentPinEnumOptions.Add("ADC2");
			CurrentPinEnumOptions.Add("ADC3");
			CurrentPinEnumOptions.Add("ADC4");
			CurrentPinEnumOptions.Add("ADC5");
			CurrentPinEnumOptions.Add("ADC6");
			CurrentPinEnumOptions.Add("ADC7");
			CurrentPinEnumOptions.Add("ADC8");
			CurrentPinEnumOptions.Add("NONE");
			CurrentPin=new UAVObjectField<CurrentPinUavEnum>("CurrentPin", "", CurrentPinElemNames, CurrentPinEnumOptions, this);
			fields.Add(CurrentPin);

			List<String> VoltagePinElemNames = new List<String>();
			VoltagePinElemNames.Add("0");
			List<String> VoltagePinEnumOptions = new List<String>();
			VoltagePinEnumOptions.Add("ADC0");
			VoltagePinEnumOptions.Add("ADC1");
			VoltagePinEnumOptions.Add("ADC2");
			VoltagePinEnumOptions.Add("ADC3");
			VoltagePinEnumOptions.Add("ADC4");
			VoltagePinEnumOptions.Add("ADC5");
			VoltagePinEnumOptions.Add("ADC6");
			VoltagePinEnumOptions.Add("ADC7");
			VoltagePinEnumOptions.Add("ADC8");
			VoltagePinEnumOptions.Add("NONE");
			VoltagePin=new UAVObjectField<VoltagePinUavEnum>("VoltagePin", "", VoltagePinElemNames, VoltagePinEnumOptions, this);
			fields.Add(VoltagePin);

			List<String> TypeElemNames = new List<String>();
			TypeElemNames.Add("0");
			List<String> TypeEnumOptions = new List<String>();
			TypeEnumOptions.Add("LiPo");
			TypeEnumOptions.Add("A123");
			TypeEnumOptions.Add("LiCo");
			TypeEnumOptions.Add("LiFeSO4");
			TypeEnumOptions.Add("None");
			Type=new UAVObjectField<TypeUavEnum>("Type", "", TypeElemNames, TypeEnumOptions, this);
			fields.Add(Type);

			List<String> NbCellsElemNames = new List<String>();
			NbCellsElemNames.Add("0");
			NbCells=new UAVObjectField<byte>("NbCells", "", NbCellsElemNames, null, this);
			fields.Add(NbCells);

			List<String> SensorTypeElemNames = new List<String>();
			SensorTypeElemNames.Add("BatteryCurrent");
			SensorTypeElemNames.Add("BatteryVoltage");
			List<String> SensorTypeEnumOptions = new List<String>();
			SensorTypeEnumOptions.Add("Disabled");
			SensorTypeEnumOptions.Add("Enabled");
			SensorType=new UAVObjectField<SensorTypeUavEnum>("SensorType", "", SensorTypeElemNames, SensorTypeEnumOptions, this);
			fields.Add(SensorType);

	

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
			Capacity.setValue((UInt32)2200);
			VoltageThresholds.setValue((float)9.8,0);
			VoltageThresholds.setValue((float)9.2,1);
			SensorCalibrationFactor.setValue((float)63.69,0);
			SensorCalibrationFactor.setValue((float)36.6,1);
			SensorCalibrationOffset.setValue((float)0,0);
			SensorCalibrationOffset.setValue((float)0,1);
			CurrentPin.setValue(CurrentPinUavEnum.ADC0);
			VoltagePin.setValue(VoltagePinUavEnum.ADC1);
			Type.setValue(TypeUavEnum.LiPo);
			NbCells.setValue((byte)3);
			SensorType.setValue(SensorTypeUavEnum.Enabled,0);
			SensorType.setValue(SensorTypeUavEnum.Enabled,1);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				FlightBatterySettings obj = new FlightBatterySettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public FlightBatterySettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (FlightBatterySettings)(objMngr.getObject(FlightBatterySettings.OBJID, instID));
		}
	}
}
