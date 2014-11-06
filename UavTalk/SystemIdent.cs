// Object ID: 2913983986
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class SystemIdent : UAVDataObject
	{
		public const long OBJID = 2913983986;
		public int NUMBYTES { get; set; }
		protected const String NAME = "SystemIdent";
	    protected static String DESCRIPTION = @"The input to the relay tuning.";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> Tau;
		public UAVObjectField<float> Beta;
		public UAVObjectField<float> Bias;
		public UAVObjectField<float> Noise;
		public UAVObjectField<float> Period;

		public SystemIdent() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> TauElemNames = new List<String>();
			TauElemNames.Add("0");
			Tau=new UAVObjectField<float>("Tau", "s", TauElemNames, null, this);
			fields.Add(Tau);

			List<String> BetaElemNames = new List<String>();
			BetaElemNames.Add("Roll");
			BetaElemNames.Add("Pitch");
			BetaElemNames.Add("Yaw");
			Beta=new UAVObjectField<float>("Beta", "", BetaElemNames, null, this);
			fields.Add(Beta);

			List<String> BiasElemNames = new List<String>();
			BiasElemNames.Add("Roll");
			BiasElemNames.Add("Pitch");
			BiasElemNames.Add("Yaw");
			Bias=new UAVObjectField<float>("Bias", "", BiasElemNames, null, this);
			fields.Add(Bias);

			List<String> NoiseElemNames = new List<String>();
			NoiseElemNames.Add("Roll");
			NoiseElemNames.Add("Pitch");
			NoiseElemNames.Add("Yaw");
			Noise=new UAVObjectField<float>("Noise", "(deg/s)^2", NoiseElemNames, null, this);
			fields.Add(Noise);

			List<String> PeriodElemNames = new List<String>();
			PeriodElemNames.Add("0");
			Period=new UAVObjectField<float>("Period", "ms", PeriodElemNames, null, this);
			fields.Add(Period);

	

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
				(int)AccessMode.ACCESS_READONLY << Metadata.UAVOBJ_ACCESS_SHIFT |
				(int)AccessMode.ACCESS_READONLY << Metadata.UAVOBJ_GCS_ACCESS_SHIFT |
				0 << Metadata.UAVOBJ_TELEMETRY_ACKED_SHIFT |
				0 << Metadata.UAVOBJ_GCS_TELEMETRY_ACKED_SHIFT |
				(int)UPDATEMODE.UPDATEMODE_ONCHANGE << Metadata.UAVOBJ_TELEMETRY_UPDATE_MODE_SHIFT |
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
			Tau.setValue((float)0);
			Beta.setValue((float)0,0);
			Beta.setValue((float)0,1);
			Beta.setValue((float)0,2);
			Bias.setValue((float)0,0);
			Bias.setValue((float)0,1);
			Bias.setValue((float)0,2);
			Noise.setValue((float)0,0);
			Noise.setValue((float)0,1);
			Noise.setValue((float)0,2);
			Period.setValue((float)0);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				SystemIdent obj = new SystemIdent();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public SystemIdent GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (SystemIdent)(objMngr.getObject(SystemIdent.OBJID, instID));
		}
	}
}
