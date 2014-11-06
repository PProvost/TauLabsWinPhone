// Object ID: 3747522558
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class GeoFenceSettings : UAVDataObject
	{
		public const long OBJID = 3747522558;
		public int NUMBYTES { get; set; }
		protected const String NAME = "GeoFenceSettings";
	    protected static String DESCRIPTION = @"Radius for simple geofence boundaries";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<UInt16> WarningRadius;
		public UAVObjectField<UInt16> ErrorRadius;

		public GeoFenceSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> WarningRadiusElemNames = new List<String>();
			WarningRadiusElemNames.Add("0");
			WarningRadius=new UAVObjectField<UInt16>("WarningRadius", "m", WarningRadiusElemNames, null, this);
			fields.Add(WarningRadius);

			List<String> ErrorRadiusElemNames = new List<String>();
			ErrorRadiusElemNames.Add("0");
			ErrorRadius=new UAVObjectField<UInt16>("ErrorRadius", "m", ErrorRadiusElemNames, null, this);
			fields.Add(ErrorRadius);

	

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
			WarningRadius.setValue((UInt16)200);
			ErrorRadius.setValue((UInt16)250);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				GeoFenceSettings obj = new GeoFenceSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public GeoFenceSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (GeoFenceSettings)(objMngr.getObject(GeoFenceSettings.OBJID, instID));
		}
	}
}
