﻿// Object ID: 3238931006
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class VtolPathFollowerSettings : UAVDataObject
	{
		public const long OBJID = 3238931006;
		public int NUMBYTES { get; set; }
		protected const String NAME = "VtolPathFollowerSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref VtolPathFollowerModule";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> HorizontalPosPI;
		public UAVObjectField<float> HorizontalVelPID;
		public UAVObjectField<float> VelocityFeedforward;
		public UAVObjectField<float> MaxRollPitch;
		public UAVObjectField<Int32> UpdatePeriod;
		public UAVObjectField<float> LandingRate;
		public UAVObjectField<UInt16> HorizontalVelMax;
		public UAVObjectField<UInt16> VerticalVelMax;
		public enum ThrottleControlUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<ThrottleControlUavEnum> ThrottleControl;
		public enum VelocityChangePredictionUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<VelocityChangePredictionUavEnum> VelocityChangePrediction;
		public UAVObjectField<byte> EndpointRadius;
		public enum YawModeUavEnum
		{
			[Description("Rate")]
			Rate = 0, 
			[Description("AxisLock")]
			AxisLock = 1, 
			[Description("Attitude")]
			Attitude = 2, 
			[Description("Path")]
			Path = 3, 
			[Description("POI")]
			POI = 4, 
		}
		public UAVObjectField<YawModeUavEnum> YawMode;

		public VtolPathFollowerSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> HorizontalPosPIElemNames = new List<String>();
			HorizontalPosPIElemNames.Add("Kp");
			HorizontalPosPIElemNames.Add("Ki");
			HorizontalPosPIElemNames.Add("ILimit");
			HorizontalPosPI=new UAVObjectField<float>("HorizontalPosPI", "(m/s)/m", HorizontalPosPIElemNames, null, this);
			fields.Add(HorizontalPosPI);

			List<String> HorizontalVelPIDElemNames = new List<String>();
			HorizontalVelPIDElemNames.Add("Kp");
			HorizontalVelPIDElemNames.Add("Ki");
			HorizontalVelPIDElemNames.Add("Kd");
			HorizontalVelPIDElemNames.Add("ILimit");
			HorizontalVelPID=new UAVObjectField<float>("HorizontalVelPID", "deg/(m/s)", HorizontalVelPIDElemNames, null, this);
			fields.Add(HorizontalVelPID);

			List<String> VelocityFeedforwardElemNames = new List<String>();
			VelocityFeedforwardElemNames.Add("0");
			VelocityFeedforward=new UAVObjectField<float>("VelocityFeedforward", "deg/(m/s)", VelocityFeedforwardElemNames, null, this);
			fields.Add(VelocityFeedforward);

			List<String> MaxRollPitchElemNames = new List<String>();
			MaxRollPitchElemNames.Add("0");
			MaxRollPitch=new UAVObjectField<float>("MaxRollPitch", "deg", MaxRollPitchElemNames, null, this);
			fields.Add(MaxRollPitch);

			List<String> UpdatePeriodElemNames = new List<String>();
			UpdatePeriodElemNames.Add("0");
			UpdatePeriod=new UAVObjectField<Int32>("UpdatePeriod", "ms", UpdatePeriodElemNames, null, this);
			fields.Add(UpdatePeriod);

			List<String> LandingRateElemNames = new List<String>();
			LandingRateElemNames.Add("0");
			LandingRate=new UAVObjectField<float>("LandingRate", "m/s", LandingRateElemNames, null, this);
			fields.Add(LandingRate);

			List<String> HorizontalVelMaxElemNames = new List<String>();
			HorizontalVelMaxElemNames.Add("0");
			HorizontalVelMax=new UAVObjectField<UInt16>("HorizontalVelMax", "m/s", HorizontalVelMaxElemNames, null, this);
			fields.Add(HorizontalVelMax);

			List<String> VerticalVelMaxElemNames = new List<String>();
			VerticalVelMaxElemNames.Add("0");
			VerticalVelMax=new UAVObjectField<UInt16>("VerticalVelMax", "m/s", VerticalVelMaxElemNames, null, this);
			fields.Add(VerticalVelMax);

			List<String> ThrottleControlElemNames = new List<String>();
			ThrottleControlElemNames.Add("0");
			List<String> ThrottleControlEnumOptions = new List<String>();
			ThrottleControlEnumOptions.Add("FALSE");
			ThrottleControlEnumOptions.Add("TRUE");
			ThrottleControl=new UAVObjectField<ThrottleControlUavEnum>("ThrottleControl", "", ThrottleControlElemNames, ThrottleControlEnumOptions, this);
			fields.Add(ThrottleControl);

			List<String> VelocityChangePredictionElemNames = new List<String>();
			VelocityChangePredictionElemNames.Add("0");
			List<String> VelocityChangePredictionEnumOptions = new List<String>();
			VelocityChangePredictionEnumOptions.Add("FALSE");
			VelocityChangePredictionEnumOptions.Add("TRUE");
			VelocityChangePrediction=new UAVObjectField<VelocityChangePredictionUavEnum>("VelocityChangePrediction", "", VelocityChangePredictionElemNames, VelocityChangePredictionEnumOptions, this);
			fields.Add(VelocityChangePrediction);

			List<String> EndpointRadiusElemNames = new List<String>();
			EndpointRadiusElemNames.Add("0");
			EndpointRadius=new UAVObjectField<byte>("EndpointRadius", "m", EndpointRadiusElemNames, null, this);
			fields.Add(EndpointRadius);

			List<String> YawModeElemNames = new List<String>();
			YawModeElemNames.Add("0");
			List<String> YawModeEnumOptions = new List<String>();
			YawModeEnumOptions.Add("Rate");
			YawModeEnumOptions.Add("AxisLock");
			YawModeEnumOptions.Add("Attitude");
			YawModeEnumOptions.Add("Path");
			YawModeEnumOptions.Add("POI");
			YawMode=new UAVObjectField<YawModeUavEnum>("YawMode", "", YawModeElemNames, YawModeEnumOptions, this);
			fields.Add(YawMode);

	

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
			HorizontalPosPI.setValue((float)1,0);
			HorizontalPosPI.setValue((float)0,1);
			HorizontalPosPI.setValue((float)2,2);
			HorizontalVelPID.setValue((float)3,0);
			HorizontalVelPID.setValue((float)0,1);
			HorizontalVelPID.setValue((float)0,2);
			HorizontalVelPID.setValue((float)0,3);
			VelocityFeedforward.setValue((float)0);
			MaxRollPitch.setValue((float)20);
			UpdatePeriod.setValue((Int32)50);
			LandingRate.setValue((float)0.5);
			HorizontalVelMax.setValue((UInt16)10);
			VerticalVelMax.setValue((UInt16)2);
			ThrottleControl.setValue(ThrottleControlUavEnum.FALSE);
			VelocityChangePrediction.setValue(VelocityChangePredictionUavEnum.FALSE);
			EndpointRadius.setValue((byte)2);
			YawMode.setValue(YawModeUavEnum.AxisLock);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				VtolPathFollowerSettings obj = new VtolPathFollowerSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public VtolPathFollowerSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (VtolPathFollowerSettings)(objMngr.getObject(VtolPathFollowerSettings.OBJID, instID));
		}
	}
}
