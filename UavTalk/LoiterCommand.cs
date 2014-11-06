// Object ID: 2161693882
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class LoiterCommand : UAVDataObject
	{
		public const long OBJID = 2161693882;
		public int NUMBYTES { get; set; }
		protected const String NAME = "LoiterCommand";
	    protected static String DESCRIPTION = @"Requested movement while in loiter mode";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = false;

		public UAVObjectField<float> Forward;
		public UAVObjectField<float> Right;
		public UAVObjectField<float> Upwards;
		public enum FrameUavEnum
		{
			[Description("Body")]
			Body = 0, 
			[Description("Earth")]
			Earth = 1, 
		}
		public UAVObjectField<FrameUavEnum> Frame;

		public LoiterCommand() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> ForwardElemNames = new List<String>();
			ForwardElemNames.Add("0");
			Forward=new UAVObjectField<float>("Forward", "m/s", ForwardElemNames, null, this);
			fields.Add(Forward);

			List<String> RightElemNames = new List<String>();
			RightElemNames.Add("0");
			Right=new UAVObjectField<float>("Right", "m/s", RightElemNames, null, this);
			fields.Add(Right);

			List<String> UpwardsElemNames = new List<String>();
			UpwardsElemNames.Add("0");
			Upwards=new UAVObjectField<float>("Upwards", "m/s", UpwardsElemNames, null, this);
			fields.Add(Upwards);

			List<String> FrameElemNames = new List<String>();
			FrameElemNames.Add("0");
			List<String> FrameEnumOptions = new List<String>();
			FrameEnumOptions.Add("Body");
			FrameEnumOptions.Add("Earth");
			Frame=new UAVObjectField<FrameUavEnum>("Frame", "", FrameElemNames, FrameEnumOptions, this);
			fields.Add(Frame);

	

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
				0 << Metadata.UAVOBJ_TELEMETRY_ACKED_SHIFT |
				0 << Metadata.UAVOBJ_GCS_TELEMETRY_ACKED_SHIFT |
				(int)UPDATEMODE.UPDATEMODE_PERIODIC << Metadata.UAVOBJ_TELEMETRY_UPDATE_MODE_SHIFT |
				(int)UPDATEMODE.UPDATEMODE_MANUAL << Metadata.UAVOBJ_GCS_TELEMETRY_UPDATE_MODE_SHIFT;
    		metadata.flightTelemetryUpdatePeriod = 1000;
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
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				LoiterCommand obj = new LoiterCommand();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public LoiterCommand GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (LoiterCommand)(objMngr.getObject(LoiterCommand.OBJID, instID));
		}
	}
}
