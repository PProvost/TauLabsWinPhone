// Object ID: 4095580702
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class HwSparkyBGC : UAVDataObject
	{
		public const long OBJID = 4095580702;
		public int NUMBYTES { get; set; }
		protected const String NAME = "HwSparkyBGC";
	    protected static String DESCRIPTION = @"Selection of optional hardware configurations.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public enum RcvrPortUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("PPM")]
			PPM = 1, 
			[Description("S.Bus")]
			SBus = 2, 
			[Description("DSM2")]
			DSM2 = 3, 
			[Description("DSMX (10bit)")]
			DSMX10bit = 4, 
			[Description("DSMX (11bit)")]
			DSMX11bit = 5, 
			[Description("HoTT SUMD")]
			HoTTSUMD = 6, 
			[Description("HoTT SUMH")]
			HoTTSUMH = 7, 
		}
		public UAVObjectField<RcvrPortUavEnum> RcvrPort;
		public enum FlexiPortUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Telemetry")]
			Telemetry = 1, 
			[Description("DebugConsole")]
			DebugConsole = 2, 
			[Description("ComBridge")]
			ComBridge = 3, 
			[Description("GPS")]
			GPS = 4, 
			[Description("S.Bus")]
			SBus = 5, 
			[Description("DSM2")]
			DSM2 = 6, 
			[Description("DSMX (10bit)")]
			DSMX10bit = 7, 
			[Description("DSMX (11bit)")]
			DSMX11bit = 8, 
			[Description("MavLinkTX")]
			MavLinkTX = 9, 
			[Description("MavLinkTX_GPS_RX")]
			MavLinkTXGPSRX = 10, 
			[Description("HoTT Telemetry")]
			HoTTTelemetry = 11, 
			[Description("FrSKY Sensor Hub")]
			FrSKYSensorHub = 12, 
			[Description("LighttelemetryTx")]
			LighttelemetryTx = 13, 
			[Description("FrSKY SPort Telemetry")]
			FrSKYSPortTelemetry = 14, 
		}
		public UAVObjectField<FlexiPortUavEnum> FlexiPort;
		public enum USB_HIDPortUavEnum
		{
			[Description("USBTelemetry")]
			USBTelemetry = 0, 
			[Description("RCTransmitter")]
			RCTransmitter = 1, 
			[Description("Disabled")]
			Disabled = 2, 
		}
		public UAVObjectField<USB_HIDPortUavEnum> USB_HIDPort;
		public enum USB_VCPPortUavEnum
		{
			[Description("USBTelemetry")]
			USBTelemetry = 0, 
			[Description("ComBridge")]
			ComBridge = 1, 
			[Description("DebugConsole")]
			DebugConsole = 2, 
			[Description("Disabled")]
			Disabled = 3, 
		}
		public UAVObjectField<USB_VCPPortUavEnum> USB_VCPPort;
		public UAVObjectField<byte> DSMxBind;
		public enum GyroRangeUavEnum
		{
			[Description("250")]
			v250 = 0, 
			[Description("500")]
			v500 = 1, 
			[Description("1000")]
			v1000 = 2, 
			[Description("2000")]
			v2000 = 3, 
		}
		public UAVObjectField<GyroRangeUavEnum> GyroRange;
		public enum AccelRangeUavEnum
		{
			[Description("2G")]
			v2G = 0, 
			[Description("4G")]
			v4G = 1, 
			[Description("8G")]
			v8G = 2, 
			[Description("16G")]
			v16G = 3, 
		}
		public UAVObjectField<AccelRangeUavEnum> AccelRange;
		public enum MPU9150DLPFUavEnum
		{
			[Description("256")]
			v256 = 0, 
			[Description("188")]
			v188 = 1, 
			[Description("98")]
			v98 = 2, 
			[Description("42")]
			v42 = 3, 
			[Description("20")]
			v20 = 4, 
			[Description("10")]
			v10 = 5, 
			[Description("5")]
			v5 = 6, 
		}
		public UAVObjectField<MPU9150DLPFUavEnum> MPU9150DLPF;
		public enum MPU9150RateUavEnum
		{
			[Description("200")]
			v200 = 0, 
			[Description("333")]
			v333 = 1, 
			[Description("444")]
			v444 = 2, 
			[Description("500")]
			v500 = 3, 
			[Description("666")]
			v666 = 4, 
			[Description("1000")]
			v1000 = 5, 
			[Description("2000")]
			v2000 = 6, 
			[Description("4000")]
			v4000 = 7, 
			[Description("8000")]
			v8000 = 8, 
		}
		public UAVObjectField<MPU9150RateUavEnum> MPU9150Rate;

		public HwSparkyBGC() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> RcvrPortElemNames = new List<String>();
			RcvrPortElemNames.Add("0");
			List<String> RcvrPortEnumOptions = new List<String>();
			RcvrPortEnumOptions.Add("Disabled");
			RcvrPortEnumOptions.Add("PPM");
			RcvrPortEnumOptions.Add("S.Bus");
			RcvrPortEnumOptions.Add("DSM2");
			RcvrPortEnumOptions.Add("DSMX (10bit)");
			RcvrPortEnumOptions.Add("DSMX (11bit)");
			RcvrPortEnumOptions.Add("HoTT SUMD");
			RcvrPortEnumOptions.Add("HoTT SUMH");
			RcvrPort=new UAVObjectField<RcvrPortUavEnum>("RcvrPort", "function", RcvrPortElemNames, RcvrPortEnumOptions, this);
			fields.Add(RcvrPort);

			List<String> FlexiPortElemNames = new List<String>();
			FlexiPortElemNames.Add("0");
			List<String> FlexiPortEnumOptions = new List<String>();
			FlexiPortEnumOptions.Add("Disabled");
			FlexiPortEnumOptions.Add("Telemetry");
			FlexiPortEnumOptions.Add("DebugConsole");
			FlexiPortEnumOptions.Add("ComBridge");
			FlexiPortEnumOptions.Add("GPS");
			FlexiPortEnumOptions.Add("S.Bus");
			FlexiPortEnumOptions.Add("DSM2");
			FlexiPortEnumOptions.Add("DSMX (10bit)");
			FlexiPortEnumOptions.Add("DSMX (11bit)");
			FlexiPortEnumOptions.Add("MavLinkTX");
			FlexiPortEnumOptions.Add("MavLinkTX_GPS_RX");
			FlexiPortEnumOptions.Add("HoTT Telemetry");
			FlexiPortEnumOptions.Add("FrSKY Sensor Hub");
			FlexiPortEnumOptions.Add("LighttelemetryTx");
			FlexiPortEnumOptions.Add("FrSKY SPort Telemetry");
			FlexiPort=new UAVObjectField<FlexiPortUavEnum>("FlexiPort", "function", FlexiPortElemNames, FlexiPortEnumOptions, this);
			fields.Add(FlexiPort);

			List<String> USB_HIDPortElemNames = new List<String>();
			USB_HIDPortElemNames.Add("0");
			List<String> USB_HIDPortEnumOptions = new List<String>();
			USB_HIDPortEnumOptions.Add("USBTelemetry");
			USB_HIDPortEnumOptions.Add("RCTransmitter");
			USB_HIDPortEnumOptions.Add("Disabled");
			USB_HIDPort=new UAVObjectField<USB_HIDPortUavEnum>("USB_HIDPort", "function", USB_HIDPortElemNames, USB_HIDPortEnumOptions, this);
			fields.Add(USB_HIDPort);

			List<String> USB_VCPPortElemNames = new List<String>();
			USB_VCPPortElemNames.Add("0");
			List<String> USB_VCPPortEnumOptions = new List<String>();
			USB_VCPPortEnumOptions.Add("USBTelemetry");
			USB_VCPPortEnumOptions.Add("ComBridge");
			USB_VCPPortEnumOptions.Add("DebugConsole");
			USB_VCPPortEnumOptions.Add("Disabled");
			USB_VCPPort=new UAVObjectField<USB_VCPPortUavEnum>("USB_VCPPort", "function", USB_VCPPortElemNames, USB_VCPPortEnumOptions, this);
			fields.Add(USB_VCPPort);

			List<String> DSMxBindElemNames = new List<String>();
			DSMxBindElemNames.Add("0");
			DSMxBind=new UAVObjectField<byte>("DSMxBind", "", DSMxBindElemNames, null, this);
			fields.Add(DSMxBind);

			List<String> GyroRangeElemNames = new List<String>();
			GyroRangeElemNames.Add("0");
			List<String> GyroRangeEnumOptions = new List<String>();
			GyroRangeEnumOptions.Add("250");
			GyroRangeEnumOptions.Add("500");
			GyroRangeEnumOptions.Add("1000");
			GyroRangeEnumOptions.Add("2000");
			GyroRange=new UAVObjectField<GyroRangeUavEnum>("GyroRange", "deg/s", GyroRangeElemNames, GyroRangeEnumOptions, this);
			fields.Add(GyroRange);

			List<String> AccelRangeElemNames = new List<String>();
			AccelRangeElemNames.Add("0");
			List<String> AccelRangeEnumOptions = new List<String>();
			AccelRangeEnumOptions.Add("2G");
			AccelRangeEnumOptions.Add("4G");
			AccelRangeEnumOptions.Add("8G");
			AccelRangeEnumOptions.Add("16G");
			AccelRange=new UAVObjectField<AccelRangeUavEnum>("AccelRange", "*gravity m/s^2", AccelRangeElemNames, AccelRangeEnumOptions, this);
			fields.Add(AccelRange);

			List<String> MPU9150DLPFElemNames = new List<String>();
			MPU9150DLPFElemNames.Add("0");
			List<String> MPU9150DLPFEnumOptions = new List<String>();
			MPU9150DLPFEnumOptions.Add("256");
			MPU9150DLPFEnumOptions.Add("188");
			MPU9150DLPFEnumOptions.Add("98");
			MPU9150DLPFEnumOptions.Add("42");
			MPU9150DLPFEnumOptions.Add("20");
			MPU9150DLPFEnumOptions.Add("10");
			MPU9150DLPFEnumOptions.Add("5");
			MPU9150DLPF=new UAVObjectField<MPU9150DLPFUavEnum>("MPU9150DLPF", "", MPU9150DLPFElemNames, MPU9150DLPFEnumOptions, this);
			fields.Add(MPU9150DLPF);

			List<String> MPU9150RateElemNames = new List<String>();
			MPU9150RateElemNames.Add("0");
			List<String> MPU9150RateEnumOptions = new List<String>();
			MPU9150RateEnumOptions.Add("200");
			MPU9150RateEnumOptions.Add("333");
			MPU9150RateEnumOptions.Add("444");
			MPU9150RateEnumOptions.Add("500");
			MPU9150RateEnumOptions.Add("666");
			MPU9150RateEnumOptions.Add("1000");
			MPU9150RateEnumOptions.Add("2000");
			MPU9150RateEnumOptions.Add("4000");
			MPU9150RateEnumOptions.Add("8000");
			MPU9150Rate=new UAVObjectField<MPU9150RateUavEnum>("MPU9150Rate", "", MPU9150RateElemNames, MPU9150RateEnumOptions, this);
			fields.Add(MPU9150Rate);

	

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
			RcvrPort.setValue(RcvrPortUavEnum.Disabled);
			FlexiPort.setValue(FlexiPortUavEnum.Disabled);
			USB_HIDPort.setValue(USB_HIDPortUavEnum.USBTelemetry);
			USB_VCPPort.setValue(USB_VCPPortUavEnum.Disabled);
			DSMxBind.setValue((byte)0);
			GyroRange.setValue(GyroRangeUavEnum.v500);
			AccelRange.setValue(AccelRangeUavEnum.v8G);
			MPU9150DLPF.setValue(MPU9150DLPFUavEnum.v256);
			MPU9150Rate.setValue(MPU9150RateUavEnum.v444);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				HwSparkyBGC obj = new HwSparkyBGC();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public HwSparkyBGC GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (HwSparkyBGC)(objMngr.getObject(HwSparkyBGC.OBJID, instID));
		}
	}
}
