// Object ID: 1377552066
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class AltitudeHoldSettings : UAVDataObject
	{
		public const long OBJID = 1377552066;
		public int NUMBYTES { get; set; }
		protected const String NAME = "AltitudeHoldSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref AltitudeHold module";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> PositionKp;
		public UAVObjectField<float> VelocityKp;
		public UAVObjectField<float> VelocityKi;
		public UAVObjectField<UInt16> AttitudeComp;
		public UAVObjectField<byte> MaxRate;
		public UAVObjectField<byte> Expo;

		public AltitudeHoldSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> PositionKpElemNames = new List<String>();
			PositionKpElemNames.Add("0");
			PositionKp=new UAVObjectField<float>("PositionKp", "(m/s)/m", PositionKpElemNames, null, this);
			fields.Add(PositionKp);

			List<String> VelocityKpElemNames = new List<String>();
			VelocityKpElemNames.Add("0");
			VelocityKp=new UAVObjectField<float>("VelocityKp", "throttle/m", VelocityKpElemNames, null, this);
			fields.Add(VelocityKp);

			List<String> VelocityKiElemNames = new List<String>();
			VelocityKiElemNames.Add("0");
			VelocityKi=new UAVObjectField<float>("VelocityKi", "throttle/m/s", VelocityKiElemNames, null, this);
			fields.Add(VelocityKi);

			List<String> AttitudeCompElemNames = new List<String>();
			AttitudeCompElemNames.Add("0");
			AttitudeComp=new UAVObjectField<UInt16>("AttitudeComp", "%", AttitudeCompElemNames, null, this);
			fields.Add(AttitudeComp);

			List<String> MaxRateElemNames = new List<String>();
			MaxRateElemNames.Add("0");
			MaxRate=new UAVObjectField<byte>("MaxRate", "m/s", MaxRateElemNames, null, this);
			fields.Add(MaxRate);

			List<String> ExpoElemNames = new List<String>();
			ExpoElemNames.Add("0");
			Expo=new UAVObjectField<byte>("Expo", "", ExpoElemNames, null, this);
			fields.Add(Expo);

	

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
			PositionKp.setValue((float)1);
			VelocityKp.setValue((float)0.3);
			VelocityKi.setValue((float)0.3);
			AttitudeComp.setValue((UInt16)100);
			MaxRate.setValue((byte)4);
			Expo.setValue((byte)40);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				AltitudeHoldSettings obj = new AltitudeHoldSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public AltitudeHoldSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (AltitudeHoldSettings)(objMngr.getObject(AltitudeHoldSettings.OBJID, instID));
		}
	}
}
