﻿// Object ID: 576180022
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using System;
using System.ComponentModel;
 
namespace UavTalk
{
	public class AttitudeSettings : UAVDataObject
	{
		public const long OBJID = 576180022;
		public int NUMBYTES { get; set; }
		protected const String NAME = "AttitudeSettings";
	    protected static String DESCRIPTION = @"Settings for the @ref Attitude module used on CopterControl";
		protected const bool ISSINGLEINST = true;
		protected const bool ISSETTINGS = true;

		public UAVObjectField<float> MagKp;
		public UAVObjectField<float> MagKi;
		public UAVObjectField<float> AccelKp;
		public UAVObjectField<float> AccelKi;
		public UAVObjectField<float> AccelTau;
		public UAVObjectField<float> VertPositionTau;
		public UAVObjectField<float> YawBiasRate;
		public UAVObjectField<Int16> BoardRotation;
		public enum ZeroDuringArmingUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<ZeroDuringArmingUavEnum> ZeroDuringArming;
		public enum BiasCorrectGyroUavEnum
		{
			[Description("FALSE")]
			FALSE = 0, 
			[Description("TRUE")]
			TRUE = 1, 
		}
		public UAVObjectField<BiasCorrectGyroUavEnum> BiasCorrectGyro;
		public enum FilterChoiceUavEnum
		{
			[Description("CCC")]
			CCC = 0, 
			[Description("PREMERLANI")]
			PREMERLANI = 1, 
			[Description("PREMERLANI_GPS")]
			PREMERLANIGPS = 2, 
		}
		public UAVObjectField<FilterChoiceUavEnum> FilterChoice;
		public enum TrimFlightUavEnum
		{
			[Description("NORMAL")]
			NORMAL = 0, 
			[Description("START")]
			START = 1, 
			[Description("LOAD")]
			LOAD = 2, 
		}
		public UAVObjectField<TrimFlightUavEnum> TrimFlight;

		public AttitudeSettings() : base (OBJID, ISSINGLEINST, ISSETTINGS, NAME)
		{
			List<UAVObjectField> fields = new List<UAVObjectField>();

			List<String> MagKpElemNames = new List<String>();
			MagKpElemNames.Add("0");
			MagKp=new UAVObjectField<float>("MagKp", "channel", MagKpElemNames, null, this);
			fields.Add(MagKp);

			List<String> MagKiElemNames = new List<String>();
			MagKiElemNames.Add("0");
			MagKi=new UAVObjectField<float>("MagKi", "channel", MagKiElemNames, null, this);
			fields.Add(MagKi);

			List<String> AccelKpElemNames = new List<String>();
			AccelKpElemNames.Add("0");
			AccelKp=new UAVObjectField<float>("AccelKp", "channel", AccelKpElemNames, null, this);
			fields.Add(AccelKp);

			List<String> AccelKiElemNames = new List<String>();
			AccelKiElemNames.Add("0");
			AccelKi=new UAVObjectField<float>("AccelKi", "channel", AccelKiElemNames, null, this);
			fields.Add(AccelKi);

			List<String> AccelTauElemNames = new List<String>();
			AccelTauElemNames.Add("0");
			AccelTau=new UAVObjectField<float>("AccelTau", "", AccelTauElemNames, null, this);
			fields.Add(AccelTau);

			List<String> VertPositionTauElemNames = new List<String>();
			VertPositionTauElemNames.Add("0");
			VertPositionTau=new UAVObjectField<float>("VertPositionTau", "", VertPositionTauElemNames, null, this);
			fields.Add(VertPositionTau);

			List<String> YawBiasRateElemNames = new List<String>();
			YawBiasRateElemNames.Add("0");
			YawBiasRate=new UAVObjectField<float>("YawBiasRate", "channel", YawBiasRateElemNames, null, this);
			fields.Add(YawBiasRate);

			List<String> BoardRotationElemNames = new List<String>();
			BoardRotationElemNames.Add("Roll");
			BoardRotationElemNames.Add("Pitch");
			BoardRotationElemNames.Add("Yaw");
			BoardRotation=new UAVObjectField<Int16>("BoardRotation", "deg*100", BoardRotationElemNames, null, this);
			fields.Add(BoardRotation);

			List<String> ZeroDuringArmingElemNames = new List<String>();
			ZeroDuringArmingElemNames.Add("0");
			List<String> ZeroDuringArmingEnumOptions = new List<String>();
			ZeroDuringArmingEnumOptions.Add("FALSE");
			ZeroDuringArmingEnumOptions.Add("TRUE");
			ZeroDuringArming=new UAVObjectField<ZeroDuringArmingUavEnum>("ZeroDuringArming", "channel", ZeroDuringArmingElemNames, ZeroDuringArmingEnumOptions, this);
			fields.Add(ZeroDuringArming);

			List<String> BiasCorrectGyroElemNames = new List<String>();
			BiasCorrectGyroElemNames.Add("0");
			List<String> BiasCorrectGyroEnumOptions = new List<String>();
			BiasCorrectGyroEnumOptions.Add("FALSE");
			BiasCorrectGyroEnumOptions.Add("TRUE");
			BiasCorrectGyro=new UAVObjectField<BiasCorrectGyroUavEnum>("BiasCorrectGyro", "channel", BiasCorrectGyroElemNames, BiasCorrectGyroEnumOptions, this);
			fields.Add(BiasCorrectGyro);

			List<String> FilterChoiceElemNames = new List<String>();
			FilterChoiceElemNames.Add("0");
			List<String> FilterChoiceEnumOptions = new List<String>();
			FilterChoiceEnumOptions.Add("CCC");
			FilterChoiceEnumOptions.Add("PREMERLANI");
			FilterChoiceEnumOptions.Add("PREMERLANI_GPS");
			FilterChoice=new UAVObjectField<FilterChoiceUavEnum>("FilterChoice", "channel", FilterChoiceElemNames, FilterChoiceEnumOptions, this);
			fields.Add(FilterChoice);

			List<String> TrimFlightElemNames = new List<String>();
			TrimFlightElemNames.Add("0");
			List<String> TrimFlightEnumOptions = new List<String>();
			TrimFlightEnumOptions.Add("NORMAL");
			TrimFlightEnumOptions.Add("START");
			TrimFlightEnumOptions.Add("LOAD");
			TrimFlight=new UAVObjectField<TrimFlightUavEnum>("TrimFlight", "channel", TrimFlightElemNames, TrimFlightEnumOptions, this);
			fields.Add(TrimFlight);

	

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
			MagKp.setValue((float)0.05);
			MagKi.setValue((float)0.0001);
			AccelKp.setValue((float)0.05);
			AccelKi.setValue((float)0.0001);
			AccelTau.setValue((float)0.1);
			VertPositionTau.setValue((float)2);
			YawBiasRate.setValue((float)1E-06);
			BoardRotation.setValue((Int16)0,0);
			BoardRotation.setValue((Int16)0,1);
			BoardRotation.setValue((Int16)0,2);
			ZeroDuringArming.setValue(ZeroDuringArmingUavEnum.TRUE);
			BiasCorrectGyro.setValue(BiasCorrectGyroUavEnum.TRUE);
			FilterChoice.setValue(FilterChoiceUavEnum.CCC);
			TrimFlight.setValue(TrimFlightUavEnum.NORMAL);
		}

		/**
		 * Create a clone of this object, a new instance ID must be specified.
		 * Do not use this function directly to create new instances, the
		 * UAVObjectManager should be used instead.
		 */
		public override UAVDataObject clone(long instID) {
			// TODO: Need to get specific instance to clone
			try {
				AttitudeSettings obj = new AttitudeSettings();
				obj.initialize(instID, this.getMetaObject());
				return obj;
			} catch  (Exception) {
				return null;
			}
		}

		/**
		 * Static function to retrieve an instance of the object.
		 */
		public AttitudeSettings GetInstance(UAVObjectManager objMngr, long instID)
		{
			return (AttitudeSettings)(objMngr.getObject(AttitudeSettings.OBJID, instID));
		}
	}
}
