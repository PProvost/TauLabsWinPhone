// Object ID: 1150760892
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class OPLinkSettings : UAVDataObject
	{
		public const long OBJID = 1150760892;
		public int NUMBYTES { get; set; }
		protected const String NAME = "OPLinkSettings";
	    protected static String DESCRIPTION = @"OPLink configurations options.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<UInt32> PairID;
		public UAVObjectField<UInt32> MinFrequency;
		public UAVObjectField<UInt32> MaxFrequency;
		public UAVObjectField<UInt16> SendTimeout;
		public enum CoordinatorUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<CoordinatorUavEnum> Coordinator;
		public enum PPMUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<PPMUavEnum> PPM;
		public enum UAVTalkUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<UAVTalkUavEnum> UAVTalk;
		public enum InputConnectionUavEnum
		{
			[Description("HID")]
			HID = 0, 
			[Description("VCP")]
			VCP = 1, 
			[Description("Telemetry")]
			Telemetry = 2, 
			[Description("Flexi")]
			Flexi = 3, 
		}
		public UAVObjectField<InputConnectionUavEnum> InputConnection;
		public enum OutputConnectionUavEnum
		{
			[Description("RemoteHID")]
			RemoteHID = 0, 
			[Description("RemoteVCP")]
			RemoteVCP = 1, 
			[Description("RemoteTelemetry")]
			RemoteTelemetry = 2, 
			[Description("RemoteFlexi")]
			RemoteFlexi = 3, 
			[Description("Telemetry")]
			Telemetry = 4, 
			[Description("Flexi")]
			Flexi = 5, 
		}
		public UAVObjectField<OutputConnectionUavEnum> OutputConnection;
		public enum ComSpeedUavEnum
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
		public UAVObjectField<ComSpeedUavEnum> ComSpeed;
		public enum MaxRFPowerUavEnum
		{
			[Description("1.25")]
			v125 = 0, 
			[Description("1.6")]
			v16 = 1, 
			[Description("3.16")]
			v316 = 2, 
			[Description("6.3")]
			v63 = 3, 
			[Description("12.6")]
			v126 = 4, 
			[Description("25")]
			v25 = 5, 
			[Description("50")]
			v50 = 6, 
			[Description("100")]
			v100 = 7, 
		}
		public UAVObjectField<MaxRFPowerUavEnum> MaxRFPower;
		public UAVObjectField<byte> MinPacketSize;
		public UAVObjectField<byte> FrequencyCalibration;
		public UAVObjectField<byte> AESKey;

		public OPLinkSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> PairIDElemNames = new List<String>();
			PairIDElemNames.Add("0");
			PairID=new UAVObjectField<UInt32>("PairID", "", PairIDElemNames, null, this);
			fields.Add(PairID);

			List<String> MinFrequencyElemNames = new List<String>();
			MinFrequencyElemNames.Add("0");
			MinFrequency=new UAVObjectField<UInt32>("MinFrequency", "", MinFrequencyElemNames, null, this);
			fields.Add(MinFrequency);

			List<String> MaxFrequencyElemNames = new List<String>();
			MaxFrequencyElemNames.Add("0");
			MaxFrequency=new UAVObjectField<UInt32>("MaxFrequency", "", MaxFrequencyElemNames, null, this);
			fields.Add(MaxFrequency);

			List<String> SendTimeoutElemNames = new List<String>();
			SendTimeoutElemNames.Add("0");
			SendTimeout=new UAVObjectField<UInt16>("SendTimeout", "ms", SendTimeoutElemNames, null, this);
			fields.Add(SendTimeout);

			List<String> CoordinatorElemNames = new List<String>();
			CoordinatorElemNames.Add("0");
			List<String> CoordinatorEnumOptions = new List<String>();
			CoordinatorEnumOptions.Add("FALSE");
			CoordinatorEnumOptions.Add("TRUE");
			Coordinator=new UAVObjectField<CoordinatorUavEnum>("Coordinator", "binary", CoordinatorElemNames, CoordinatorEnumOptions, this);
			fields.Add(Coordinator);

			List<String> PPMElemNames = new List<String>();
			PPMElemNames.Add("0");
			List<String> PPMEnumOptions = new List<String>();
			PPMEnumOptions.Add("FALSE");
			PPMEnumOptions.Add("TRUE");
			PPM=new UAVObjectField<PPMUavEnum>("PPM", "binary", PPMElemNames, PPMEnumOptions, this);
			fields.Add(PPM);

			List<String> UAVTalkElemNames = new List<String>();
			UAVTalkElemNames.Add("0");
			List<String> UAVTalkEnumOptions = new List<String>();
			UAVTalkEnumOptions.Add("FALSE");
			UAVTalkEnumOptions.Add("TRUE");
			UAVTalk=new UAVObjectField<UAVTalkUavEnum>("UAVTalk", "binary", UAVTalkElemNames, UAVTalkEnumOptions, this);
			fields.Add(UAVTalk);

			List<String> InputConnectionElemNames = new List<String>();
			InputConnectionElemNames.Add("0");
			List<String> InputConnectionEnumOptions = new List<String>();
			InputConnectionEnumOptions.Add("HID");
			InputConnectionEnumOptions.Add("VCP");
			InputConnectionEnumOptions.Add("Telemetry");
			InputConnectionEnumOptions.Add("Flexi");
			InputConnection=new UAVObjectField<InputConnectionUavEnum>("InputConnection", "function", InputConnectionElemNames, InputConnectionEnumOptions, this);
			fields.Add(InputConnection);

			List<String> OutputConnectionElemNames = new List<String>();
			OutputConnectionElemNames.Add("0");
			List<String> OutputConnectionEnumOptions = new List<String>();
			OutputConnectionEnumOptions.Add("RemoteHID");
			OutputConnectionEnumOptions.Add("RemoteVCP");
			OutputConnectionEnumOptions.Add("RemoteTelemetry");
			OutputConnectionEnumOptions.Add("RemoteFlexi");
			OutputConnectionEnumOptions.Add("Telemetry");
			OutputConnectionEnumOptions.Add("Flexi");
			OutputConnection=new UAVObjectField<OutputConnectionUavEnum>("OutputConnection", "function", OutputConnectionElemNames, OutputConnectionEnumOptions, this);
			fields.Add(OutputConnection);

			List<String> ComSpeedElemNames = new List<String>();
			ComSpeedElemNames.Add("0");
			List<String> ComSpeedEnumOptions = new List<String>();
			ComSpeedEnumOptions.Add("2400");
			ComSpeedEnumOptions.Add("4800");
			ComSpeedEnumOptions.Add("9600");
			ComSpeedEnumOptions.Add("19200");
			ComSpeedEnumOptions.Add("38400");
			ComSpeedEnumOptions.Add("57600");
			ComSpeedEnumOptions.Add("115200");
			ComSpeed=new UAVObjectField<ComSpeedUavEnum>("ComSpeed", "bps", ComSpeedElemNames, ComSpeedEnumOptions, this);
			fields.Add(ComSpeed);

			List<String> MaxRFPowerElemNames = new List<String>();
			MaxRFPowerElemNames.Add("0");
			List<String> MaxRFPowerEnumOptions = new List<String>();
			MaxRFPowerEnumOptions.Add("1.25");
			MaxRFPowerEnumOptions.Add("1.6");
			MaxRFPowerEnumOptions.Add("3.16");
			MaxRFPowerEnumOptions.Add("6.3");
			MaxRFPowerEnumOptions.Add("12.6");
			MaxRFPowerEnumOptions.Add("25");
			MaxRFPowerEnumOptions.Add("50");
			MaxRFPowerEnumOptions.Add("100");
			MaxRFPower=new UAVObjectField<MaxRFPowerUavEnum>("MaxRFPower", "mW", MaxRFPowerElemNames, MaxRFPowerEnumOptions, this);
			fields.Add(MaxRFPower);

			List<String> MinPacketSizeElemNames = new List<String>();
			MinPacketSizeElemNames.Add("0");
			MinPacketSize=new UAVObjectField<byte>("MinPacketSize", "bytes", MinPacketSizeElemNames, null, this);
			fields.Add(MinPacketSize);

			List<String> FrequencyCalibrationElemNames = new List<String>();
			FrequencyCalibrationElemNames.Add("0");
			FrequencyCalibration=new UAVObjectField<byte>("FrequencyCalibration", "", FrequencyCalibrationElemNames, null, this);
			fields.Add(FrequencyCalibration);

			List<String> AESKeyElemNames = new List<String>();
			AESKeyElemNames.Add("0");
			AESKeyElemNames.Add("1");
			AESKeyElemNames.Add("2");
			AESKeyElemNames.Add("3");
			AESKeyElemNames.Add("4");
			AESKeyElemNames.Add("5");
			AESKeyElemNames.Add("6");
			AESKeyElemNames.Add("7");
			AESKeyElemNames.Add("8");
			AESKeyElemNames.Add("9");
			AESKeyElemNames.Add("10");
			AESKeyElemNames.Add("11");
			AESKeyElemNames.Add("12");
			AESKeyElemNames.Add("13");
			AESKeyElemNames.Add("14");
			AESKeyElemNames.Add("15");
			AESKeyElemNames.Add("16");
			AESKeyElemNames.Add("17");
			AESKeyElemNames.Add("18");
			AESKeyElemNames.Add("19");
			AESKeyElemNames.Add("20");
			AESKeyElemNames.Add("21");
			AESKeyElemNames.Add("22");
			AESKeyElemNames.Add("23");
			AESKeyElemNames.Add("24");
			AESKeyElemNames.Add("25");
			AESKeyElemNames.Add("26");
			AESKeyElemNames.Add("27");
			AESKeyElemNames.Add("28");
			AESKeyElemNames.Add("29");
			AESKeyElemNames.Add("30");
			AESKeyElemNames.Add("31");
			AESKey=new UAVObjectField<byte>("AESKey", "", AESKeyElemNames, null, this);
			fields.Add(AESKey);

	

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
			PairID.setValue((UInt32)0);
			MinFrequency.setValue((UInt32)432000000);
			MaxFrequency.setValue((UInt32)436000000);
			SendTimeout.setValue((UInt16)50);
			Coordinator.setValue(CoordinatorUavEnum.FALSE);
			PPM.setValue(PPMUavEnum.FALSE);
			UAVTalk.setValue(UAVTalkUavEnum.FALSE);
			InputConnection.setValue(InputConnectionUavEnum.HID);
			OutputConnection.setValue(OutputConnectionUavEnum.RemoteTelemetry);
			ComSpeed.setValue(ComSpeedUavEnum.v38400);
			MaxRFPower.setValue(MaxRFPowerUavEnum.v100);
			MinPacketSize.setValue((byte)50);
			FrequencyCalibration.setValue((byte)127);
			AESKey.setValue((byte)0,0);
			AESKey.setValue((byte)0,1);
			AESKey.setValue((byte)0,2);
			AESKey.setValue((byte)0,3);
			AESKey.setValue((byte)0,4);
			AESKey.setValue((byte)0,5);
			AESKey.setValue((byte)0,6);
			AESKey.setValue((byte)0,7);
			AESKey.setValue((byte)0,8);
			AESKey.setValue((byte)0,9);
			AESKey.setValue((byte)0,10);
			AESKey.setValue((byte)0,11);
			AESKey.setValue((byte)0,12);
			AESKey.setValue((byte)0,13);
			AESKey.setValue((byte)0,14);
			AESKey.setValue((byte)0,15);
			AESKey.setValue((byte)0,16);
			AESKey.setValue((byte)0,17);
			AESKey.setValue((byte)0,18);
			AESKey.setValue((byte)0,19);
			AESKey.setValue((byte)0,20);
			AESKey.setValue((byte)0,21);
			AESKey.setValue((byte)0,22);
			AESKey.setValue((byte)0,23);
			AESKey.setValue((byte)0,24);
			AESKey.setValue((byte)0,25);
			AESKey.setValue((byte)0,26);
			AESKey.setValue((byte)0,27);
			AESKey.setValue((byte)0,28);
			AESKey.setValue((byte)0,29);
			AESKey.setValue((byte)0,30);
			AESKey.setValue((byte)0,31);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				OPLinkSettings obj = new OPLinkSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public OPLinkSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (OPLinkSettings)(objMngr.getObject(OPLinkSettings.OBJID, instID));
		}
	}
}
