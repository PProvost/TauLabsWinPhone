// Object ID: 1571909630
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class PicoCSettings : UAVDataObject
	{
		public const long OBJID = 1571909630;
		public int NUMBYTES { get; set; }
		protected const String NAME = "PicoCSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref PicoC Interpreter Module";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<UInt32> MaxFileSize;
		public UAVObjectField<UInt32> TaskStackSize;
		public UAVObjectField<UInt32> PicoCStackSize;
		public UAVObjectField<byte> BootFileID;
		public enum StartupUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("OnBoot")]
			OnBoot = 1, 
			[Description("WhenArmed")]
			WhenArmed = 2, 
		}
		public UAVObjectField<StartupUavEnum> Startup;
		public enum SourceUavEnum
		{
			[Description("Disabled")]
			Disabled = 0, 
			[Description("Demo")]
			Demo = 1, 
			[Description("Interactive")]
			Interactive = 2, 
			[Description("File")]
			File = 3, 
		}
		public UAVObjectField<SourceUavEnum> Source;
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

		public PicoCSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> MaxFileSizeElemNames = new List<String>();
			MaxFileSizeElemNames.Add("0");
			MaxFileSize=new UAVObjectField<UInt32>("MaxFileSize", "bytes [be careful!]", MaxFileSizeElemNames, null, this);
			fields.Add(MaxFileSize);

			List<String> TaskStackSizeElemNames = new List<String>();
			TaskStackSizeElemNames.Add("0");
			TaskStackSize=new UAVObjectField<UInt32>("TaskStackSize", "bytes [be careful!]", TaskStackSizeElemNames, null, this);
			fields.Add(TaskStackSize);

			List<String> PicoCStackSizeElemNames = new List<String>();
			PicoCStackSizeElemNames.Add("0");
			PicoCStackSize=new UAVObjectField<UInt32>("PicoCStackSize", "bytes [be careful!]", PicoCStackSizeElemNames, null, this);
			fields.Add(PicoCStackSize);

			List<String> BootFileIDElemNames = new List<String>();
			BootFileIDElemNames.Add("0");
			BootFileID=new UAVObjectField<byte>("BootFileID", "", BootFileIDElemNames, null, this);
			fields.Add(BootFileID);

			List<String> StartupElemNames = new List<String>();
			StartupElemNames.Add("0");
			List<String> StartupEnumOptions = new List<String>();
			StartupEnumOptions.Add("Disabled");
			StartupEnumOptions.Add("OnBoot");
			StartupEnumOptions.Add("WhenArmed");
			Startup=new UAVObjectField<StartupUavEnum>("Startup", "", StartupElemNames, StartupEnumOptions, this);
			fields.Add(Startup);

			List<String> SourceElemNames = new List<String>();
			SourceElemNames.Add("0");
			List<String> SourceEnumOptions = new List<String>();
			SourceEnumOptions.Add("Disabled");
			SourceEnumOptions.Add("Demo");
			SourceEnumOptions.Add("Interactive");
			SourceEnumOptions.Add("File");
			Source=new UAVObjectField<SourceUavEnum>("Source", "", SourceElemNames, SourceEnumOptions, this);
			fields.Add(Source);

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
			MaxFileSize.setValue((UInt32)2048);
			TaskStackSize.setValue((UInt32)16384);
			PicoCStackSize.setValue((UInt32)16384);
			BootFileID.setValue((byte)0);
			Startup.setValue(StartupUavEnum.Disabled);
			Source.setValue(SourceUavEnum.Disabled);
			ComSpeed.setValue(ComSpeedUavEnum.v115200);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				PicoCSettings obj = new PicoCSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public PicoCSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (PicoCSettings)(objMngr.getObject(PicoCSettings.OBJID, instID));
		}
	}
}
