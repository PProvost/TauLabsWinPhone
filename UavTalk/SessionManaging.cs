// Object ID: 2298695242
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class SessionManaging : UAVDataObject
	{
		public const long OBJID = 2298695242;
		public int NUMBYTES { get; set; }
		protected const String NAME = "SessionManaging";
	    protected static String DESCRIPTION = @"Provides session managing to uavtalk";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = false;

		public UAVObjectField<UInt32> ObjectID;
		public UAVObjectField<UInt16> SessionID;
		public UAVObjectField<byte> ObjectInstances;
		public UAVObjectField<byte> NumberOfObjects;
		public UAVObjectField<byte> ObjectOfInterestIndex;

		public SessionManaging() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> ObjectIDElemNames = new List<String>();
			ObjectIDElemNames.Add("0");
			ObjectID=new UAVObjectField<UInt32>("ObjectID", "", ObjectIDElemNames, null, this);
			fields.Add(ObjectID);

			List<String> SessionIDElemNames = new List<String>();
			SessionIDElemNames.Add("0");
			SessionID=new UAVObjectField<UInt16>("SessionID", "", SessionIDElemNames, null, this);
			fields.Add(SessionID);

			List<String> ObjectInstancesElemNames = new List<String>();
			ObjectInstancesElemNames.Add("0");
			ObjectInstances=new UAVObjectField<byte>("ObjectInstances", "", ObjectInstancesElemNames, null, this);
			fields.Add(ObjectInstances);

			List<String> NumberOfObjectsElemNames = new List<String>();
			NumberOfObjectsElemNames.Add("0");
			NumberOfObjects=new UAVObjectField<byte>("NumberOfObjects", "", NumberOfObjectsElemNames, null, this);
			fields.Add(NumberOfObjects);

			List<String> ObjectOfInterestIndexElemNames = new List<String>();
			ObjectOfInterestIndexElemNames.Add("0");
			ObjectOfInterestIndex=new UAVObjectField<byte>("ObjectOfInterestIndex", "", ObjectOfInterestIndexElemNames, null, this);
			fields.Add(ObjectOfInterestIndex);

	

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
				(int)UPDATEMODE.UPDATEMODE_MANUAL << Metadata.UAVOBJ_GCS_TELEMETRY_UPDATE_MODE_SHIFT;
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
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				SessionManaging obj = new SessionManaging();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public SessionManaging GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (SessionManaging)(objMngr.getObject(SessionManaging.OBJID, instID));
		}
	}
}
