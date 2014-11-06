// Object ID: 4046607242
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class PicoCStatus : UAVDataObject
	{
		public const long OBJID = 4046607242;
		public int NUMBYTES { get; set; }
		protected const String NAME = "PicoCStatus";
	    protected static String DESCRIPTION = @"status information of the @ref PicoC Interpreter Module.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = false;

		public UAVObjectField<Int16> ExitValue;
		public UAVObjectField<Int16> TestValue;
		public UAVObjectField<UInt16> SectorID;
		public UAVObjectField<byte> FileID;
		public enum CommandUavEnum
		{
			[Description("Idle")]
			Idle = 0, 
			[Description("StartScript")]
			StartScript = 1, 
			[Description("USARTmode")]
			USARTmode = 2, 
			[Description("GetSector")]
			GetSector = 3, 
			[Description("SetSector")]
			SetSector = 4, 
			[Description("LoadFile")]
			LoadFile = 5, 
			[Description("SaveFile")]
			SaveFile = 6, 
			[Description("DeleteFile")]
			DeleteFile = 7, 
			[Description("FormatPartition")]
			FormatPartition = 8, 
		}
		public UAVObjectField<CommandUavEnum> Command;
		public UAVObjectField<sbyte> CommandError;
		public UAVObjectField<byte> Sector;

		public PicoCStatus() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> ExitValueElemNames = new List<String>();
			ExitValueElemNames.Add("0");
			ExitValue=new UAVObjectField<Int16>("ExitValue", "", ExitValueElemNames, null, this);
			fields.Add(ExitValue);

			List<String> TestValueElemNames = new List<String>();
			TestValueElemNames.Add("0");
			TestValue=new UAVObjectField<Int16>("TestValue", "", TestValueElemNames, null, this);
			fields.Add(TestValue);

			List<String> SectorIDElemNames = new List<String>();
			SectorIDElemNames.Add("0");
			SectorID=new UAVObjectField<UInt16>("SectorID", "", SectorIDElemNames, null, this);
			fields.Add(SectorID);

			List<String> FileIDElemNames = new List<String>();
			FileIDElemNames.Add("0");
			FileID=new UAVObjectField<byte>("FileID", "", FileIDElemNames, null, this);
			fields.Add(FileID);

			List<String> CommandElemNames = new List<String>();
			CommandElemNames.Add("0");
			List<String> CommandEnumOptions = new List<String>();
			CommandEnumOptions.Add("Idle");
			CommandEnumOptions.Add("StartScript");
			CommandEnumOptions.Add("USARTmode");
			CommandEnumOptions.Add("GetSector");
			CommandEnumOptions.Add("SetSector");
			CommandEnumOptions.Add("LoadFile");
			CommandEnumOptions.Add("SaveFile");
			CommandEnumOptions.Add("DeleteFile");
			CommandEnumOptions.Add("FormatPartition");
			Command=new UAVObjectField<CommandUavEnum>("Command", "", CommandElemNames, CommandEnumOptions, this);
			fields.Add(Command);

			List<String> CommandErrorElemNames = new List<String>();
			CommandErrorElemNames.Add("0");
			CommandError=new UAVObjectField<sbyte>("CommandError", "", CommandErrorElemNames, null, this);
			fields.Add(CommandError);

			List<String> SectorElemNames = new List<String>();
			SectorElemNames.Add("0");
			SectorElemNames.Add("1");
			SectorElemNames.Add("2");
			SectorElemNames.Add("3");
			SectorElemNames.Add("4");
			SectorElemNames.Add("5");
			SectorElemNames.Add("6");
			SectorElemNames.Add("7");
			SectorElemNames.Add("8");
			SectorElemNames.Add("9");
			SectorElemNames.Add("10");
			SectorElemNames.Add("11");
			SectorElemNames.Add("12");
			SectorElemNames.Add("13");
			SectorElemNames.Add("14");
			SectorElemNames.Add("15");
			SectorElemNames.Add("16");
			SectorElemNames.Add("17");
			SectorElemNames.Add("18");
			SectorElemNames.Add("19");
			SectorElemNames.Add("20");
			SectorElemNames.Add("21");
			SectorElemNames.Add("22");
			SectorElemNames.Add("23");
			SectorElemNames.Add("24");
			SectorElemNames.Add("25");
			SectorElemNames.Add("26");
			SectorElemNames.Add("27");
			SectorElemNames.Add("28");
			SectorElemNames.Add("29");
			SectorElemNames.Add("30");
			SectorElemNames.Add("31");
			Sector=new UAVObjectField<byte>("Sector", "", SectorElemNames, null, this);
			fields.Add(Sector);

	

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
			ExitValue.setValue((Int16)0);
			TestValue.setValue((Int16)0);
			SectorID.setValue((UInt16)0);
			FileID.setValue((byte)0);
			Command.setValue(CommandUavEnum.Idle);
			CommandError.setValue((sbyte)0);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				PicoCStatus obj = new PicoCStatus();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public PicoCStatus GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (PicoCStatus)(objMngr.getObject(PicoCStatus.OBJID, instID));
		}
	}
}
