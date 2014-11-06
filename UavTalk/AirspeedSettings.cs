// Object ID: 104818588
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class AirspeedSettings : UAVDataObject
	{
		public const long OBJID = 104818588;
		public int NUMBYTES { get; set; }
		protected const String NAME = "AirspeedSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref BaroAirspeed module used on CopterControl or Revolution";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> Scale;
		public UAVObjectField<UInt16> ZeroPoint;
		public UAVObjectField<byte> GPSSamplePeriod_ms;
		public enum AirspeedSensorTypeUavEnum
		{
			[Description("EagleTreeAirspeedV3")]
			EagleTreeAirspeedV3 = 0, 
			[Description("DIYDronesMPXV5004")]
			DIYDronesMPXV5004 = 1, 
			[Description("DIYDronesMPXV7002")]
			DIYDronesMPXV7002 = 2, 
			[Description("GPSOnly")]
			GPSOnly = 3, 
		}
		public UAVObjectField<AirspeedSensorTypeUavEnum> AirspeedSensorType;
		public enum AnalogPinUavEnum
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
		public UAVObjectField<AnalogPinUavEnum> AnalogPin;

		public AirspeedSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> ScaleElemNames = new List<String>();
			ScaleElemNames.Add("0");
			Scale=new UAVObjectField<float>("Scale", "raw", ScaleElemNames, null, this);
			fields.Add(Scale);

			List<String> ZeroPointElemNames = new List<String>();
			ZeroPointElemNames.Add("0");
			ZeroPoint=new UAVObjectField<UInt16>("ZeroPoint", "raw", ZeroPointElemNames, null, this);
			fields.Add(ZeroPoint);

			List<String> GPSSamplePeriod_msElemNames = new List<String>();
			GPSSamplePeriod_msElemNames.Add("0");
			GPSSamplePeriod_ms=new UAVObjectField<byte>("GPSSamplePeriod_ms", "ms", GPSSamplePeriod_msElemNames, null, this);
			fields.Add(GPSSamplePeriod_ms);

			List<String> AirspeedSensorTypeElemNames = new List<String>();
			AirspeedSensorTypeElemNames.Add("0");
			List<String> AirspeedSensorTypeEnumOptions = new List<String>();
			AirspeedSensorTypeEnumOptions.Add("EagleTreeAirspeedV3");
			AirspeedSensorTypeEnumOptions.Add("DIYDronesMPXV5004");
			AirspeedSensorTypeEnumOptions.Add("DIYDronesMPXV7002");
			AirspeedSensorTypeEnumOptions.Add("GPSOnly");
			AirspeedSensorType=new UAVObjectField<AirspeedSensorTypeUavEnum>("AirspeedSensorType", "", AirspeedSensorTypeElemNames, AirspeedSensorTypeEnumOptions, this);
			fields.Add(AirspeedSensorType);

			List<String> AnalogPinElemNames = new List<String>();
			AnalogPinElemNames.Add("0");
			List<String> AnalogPinEnumOptions = new List<String>();
			AnalogPinEnumOptions.Add("ADC0");
			AnalogPinEnumOptions.Add("ADC1");
			AnalogPinEnumOptions.Add("ADC2");
			AnalogPinEnumOptions.Add("ADC3");
			AnalogPinEnumOptions.Add("ADC4");
			AnalogPinEnumOptions.Add("ADC5");
			AnalogPinEnumOptions.Add("ADC6");
			AnalogPinEnumOptions.Add("ADC7");
			AnalogPinEnumOptions.Add("ADC8");
			AnalogPinEnumOptions.Add("NONE");
			AnalogPin=new UAVObjectField<AnalogPinUavEnum>("AnalogPin", "", AnalogPinElemNames, AnalogPinEnumOptions, this);
			fields.Add(AnalogPin);

	

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
			Scale.setValue((float)1);
			ZeroPoint.setValue((UInt16)0);
			GPSSamplePeriod_ms.setValue((byte)100);
			AirspeedSensorType.setValue(AirspeedSensorTypeUavEnum.GPSOnly);
			AnalogPin.setValue(AnalogPinUavEnum.NONE);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				AirspeedSettings obj = new AirspeedSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public AirspeedSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (AirspeedSettings)(objMngr.getObject(AirspeedSettings.OBJID, instID));
		}
	}
}
