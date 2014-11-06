// Object ID: 2314113350
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class BrushlessGimbalSettings : UAVDataObject
	{
		public const long OBJID = 2314113350;
		public int NUMBYTES { get; set; }
		protected const String NAME = "BrushlessGimbalSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref BrushlessGimbal module";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> Damping;
		public UAVObjectField<UInt16> MaxDPS;
		public UAVObjectField<UInt16> SlewLimit;
		public UAVObjectField<byte> PowerScale;

		public BrushlessGimbalSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> DampingElemNames = new List<String>();
			DampingElemNames.Add("Roll");
			DampingElemNames.Add("Pitch");
			DampingElemNames.Add("Yaw");
			Damping=new UAVObjectField<float>("Damping", "deg/(deg/s)", DampingElemNames, null, this);
			fields.Add(Damping);

			List<String> MaxDPSElemNames = new List<String>();
			MaxDPSElemNames.Add("Roll");
			MaxDPSElemNames.Add("Pitch");
			MaxDPSElemNames.Add("Yaw");
			MaxDPS=new UAVObjectField<UInt16>("MaxDPS", "deg/s", MaxDPSElemNames, null, this);
			fields.Add(MaxDPS);

			List<String> SlewLimitElemNames = new List<String>();
			SlewLimitElemNames.Add("Roll");
			SlewLimitElemNames.Add("Pitch");
			SlewLimitElemNames.Add("Yaw");
			SlewLimit=new UAVObjectField<UInt16>("SlewLimit", "deg/s^2", SlewLimitElemNames, null, this);
			fields.Add(SlewLimit);

			List<String> PowerScaleElemNames = new List<String>();
			PowerScaleElemNames.Add("Roll");
			PowerScaleElemNames.Add("Pitch");
			PowerScaleElemNames.Add("Yaw");
			PowerScale=new UAVObjectField<byte>("PowerScale", "%", PowerScaleElemNames, null, this);
			fields.Add(PowerScale);

	

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
			Damping.setValue((float)0,0);
			Damping.setValue((float)0,1);
			Damping.setValue((float)0,2);
			MaxDPS.setValue((UInt16)8000,0);
			MaxDPS.setValue((UInt16)8000,1);
			MaxDPS.setValue((UInt16)8000,2);
			SlewLimit.setValue((UInt16)32000,0);
			SlewLimit.setValue((UInt16)32000,1);
			SlewLimit.setValue((UInt16)32000,2);
			PowerScale.setValue((byte)33,0);
			PowerScale.setValue((byte)33,1);
			PowerScale.setValue((byte)33,2);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				BrushlessGimbalSettings obj = new BrushlessGimbalSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public BrushlessGimbalSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (BrushlessGimbalSettings)(objMngr.getObject(BrushlessGimbalSettings.OBJID, instID));
		}
	}
}
