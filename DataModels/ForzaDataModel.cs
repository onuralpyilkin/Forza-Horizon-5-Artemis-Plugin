using Artemis.Core.Modules;
using System;
using System.Collections.Generic;
using ForzaHorizon5.Telemetry;

namespace ForzaHorizon5.DataModels
{
    public class ForzaDataModel : DataModel
    {
        [DataModelProperty(Description = "Telemetry information since Forza Motorsport 7")]
        public SledDataModel Sled { get; set; }

        [DataModelProperty(Description = "Telemetry information since Forza Horizon 4")]
        public DashDataModel Dash { get; set; }

        public ForzaDataModel()
        {
            Sled = new SledDataModel();
            Dash = new DashDataModel();
        }
        public void Apply(ForzaStruct data)
        {
            Sled.Apply(data.Sled);
            Dash.Apply(data.Dash);
        }
    }

    public class SledDataModel
    {
        //s32 IsRaceOn; // = 1 when race is on. = 0 when in menus/race stopped …
        public int IsRaceOn { get; set; }

        //u32 TimestampMS; //Can overflow to 0 eventually
        public uint TimestampMS { get; set; }

        //f32 EngineMaxRpm;
        public float EngineMaxRpm { get; set; }

        //f32 EngineIdleRpm;
        public float EngineIdleRpm { get; set; }

        //f32 CurrentEngineRpm;
        public float CurrentEngineRpm { get; set; }

        //f32 AccelerationX; //In the car's local space; X = right, Y = up, Z = forward
        public float AccelerationX { get; set; }

        //f32 AccelerationY;
        public float AccelerationY { get; set; }

        //f32 AccelerationZ;
        public float AccelerationZ { get; set; }

        //f32 VelocityX; //In the car's local space; X = right, Y = up, Z = forward
        public float VelocityX { get; set; }

        //f32 VelocityY;
        public float VelocityY { get; set; }

        //f32 VelocityZ;
        public float VelocityZ { get; set; }

        //f32 AngularVelocityX; //In the car's local space; X = pitch, Y = yaw, Z = roll
        public float AngularVelocityX { get; set; }

        //f32 AngularVelocityY;
        public float AngularVelocityY { get; set; }

        //f32 AngularVelocityZ;
        public float AngularVelocityZ { get; set; }

        //f32 Yaw;
        public float Yaw { get; set; }

        //f32 Pitch;
        public float Pitch { get; set; }

        //f32 Roll;
        public float Roll { get; set; }

        //f32 NormalizedSuspensionTravelFrontLeft; // Suspension travel normalized: 0.0f = max stretch; 1.0 = max compression
        public float NormalizedSuspensionTravelFrontLeft { get; set; }

        //f32 NormalizedSuspensionTravelFrontRight;
        public float NormalizedSuspensionTravelFrontRight { get; set; }

        //f32 NormalizedSuspensionTravelRearLeft;
        public float NormalizedSuspensionTravelRearLeft { get; set; }

        //f32 NormalizedSuspensionTravelRearRight;
        public float NormalizedSuspensionTravelRearRight { get; set; }

        //f32 TireSlipRatioFrontLeft; // Tire normalized slip ratio, = 0 means 100% grip and |ratio| > 1.0 means loss of grip.
        public float TireSlipRatioFrontLeft { get; set; }

        //f32 TireSlipRatioFrontRight;
        public float TireSlipRatioFrontRight { get; set; }

        //f32 TireSlipRatioRearLeft;
        public float TireSlipRatioRearLeft { get; set; }

        //f32 TireSlipRatioRearRight;
        public float TireSlipRatioRearRight { get; set; }

        //f32 WheelRotationSpeedFrontLeft; // Wheel rotation speed radians/sec.
        public float WheelRotationSpeedFrontLeft { get; set; }

        //f32 WheelRotationSpeedFrontRight;
        public float WheelRotationSpeedFrontRight { get; set; }

        //f32 WheelRotationSpeedRearLeft;
        public float WheelRotationSpeedRearLeft { get; set; }

        //f32 WheelRotationSpeedRearRight;
        public float WheelRotationSpeedRearRight { get; set; }

        //s32 WheelOnRumbleStripFrontLeft; // = 1 when wheel is on rumble strip, = 0 when off.
        public int WheelOnRumbleStripFrontLeft { get; set; }

        //s32 WheelOnRumbleStripFrontRight;
        public int WheelOnRumbleStripFrontRight { get; set; }

        //s32 WheelOnRumbleStripRearLeft;
        public int WheelOnRumbleStripRearLeft { get; set; }

        //s32 WheelOnRumbleStripRearRight;
        public int WheelOnRumbleStripRearRight { get; set; }

        //f32 WheelInPuddleDepthFrontLeft; // = from 0 to 1, where 1 is the deepest puddle
        public float WheelInPuddleDepthFrontLeft { get; set; }

        //f32 WheelInPuddleDepthFrontRight;
        public float WheelInPuddleDepthFrontRight { get; set; }

        //f32 WheelInPuddleDepthRearLeft;
        public float WheelInPuddleDepthRearLeft { get; set; }

        //f32 WheelInPuddleDepthRearRight;
        public float WheelInPuddleDepthRearRight { get; set; }

        //f32 SurfaceRumbleFrontLeft; // Non-dimensional surface rumble values passed to controller force feedback
        public float SurfaceRumbleFrontLeft { get; set; }

        //f32 SurfaceRumbleFrontRight;
        public float SurfaceRumbleFrontRight { get; set; }

        //f32 SurfaceRumbleRearLeft;
        public float SurfaceRumbleRearLeft { get; set; }

        //f32 SurfaceRumbleRearRight;
        public float SurfaceRumbleRearRight { get; set; }

        //f32 TireSlipAngleFrontLeft; // Tire normalized slip angle, = 0 means 100% grip and |angle| > 1.0 means loss of grip.
        public float TireSlipAngleFrontLeft { get; set; }

        //f32 TireSlipAngleFrontRight;
        public float TireSlipAngleFrontRight { get; set; }

        //f32 TireSlipAngleRearLeft;
        public float TireSlipAngleRearLeft { get; set; }

        //f32 TireSlipAngleRearRight;
        public float TireSlipAngleRearRight { get; set; }

        //f32 TireCombinedSlipFrontLeft; // Tire normalized combined slip, = 0 means 100% grip and |slip| > 1.0 means loss of grip.
        public float TireCombinedSlipFrontLeft { get; set; }

        //f32 TireCombinedSlipFrontRight;
        public float TireCombinedSlipFrontRight { get; set; }

        //f32 TireCombinedSlipRearLeft;
        public float TireCombinedSlipRearLeft { get; set; }

        //f32 TireCombinedSlipRearRight;
        public float TireCombinedSlipRearRight { get; set; }

        //f32 SuspensionTravelMetersFrontLeft; // Actual suspension travel in meters
        public float SuspensionTravelMetersFrontLeft { get; set; }

        //f32 SuspensionTravelMetersFrontRight;
        public float SuspensionTravelMetersFrontRight { get; set; }

        //f32 SuspensionTravelMetersRearLeft;
        public float SuspensionTravelMetersRearLeft { get; set; }

        //f32 SuspensionTravelMetersRearRight;
        public float SuspensionTravelMetersRearRight { get; set; }

        //s32 CarOrdinal; //Unique ID of the car make/model
        public int CarOrdinal { get; set; }

        //s32 CarClass; //Between 0 (D -- worst cars) and 7 (X class -- best cars) inclusive
        public int CarClass { get; set; }

        //s32 CarPerformanceIndex; //Between 100 (slowest car) and 999 (fastest car) inclusive
        public int CarPerformanceIndex { get; set; }

        //s32 DrivetrainType; //Corresponds to EDrivetrainType; 0 = FWD, 1 = RWD, 2 = AWD
        public int DrivetrainType { get; set; }

        //s32 NumCylinders; //Number of cylinders in the engine
        public int NumCylinders { get; set; }

        public void Apply(SledStruct data)
        {
            IsRaceOn = data.IsRaceOn;
            TimestampMS = data.TimestampMS;
            EngineMaxRpm = data.EngineMaxRpm;
            EngineIdleRpm = data.EngineIdleRpm;
            CurrentEngineRpm = data.CurrentEngineRpm;
            AccelerationX = data.AccelerationX;
            AccelerationY = data.AccelerationY;
            AccelerationZ = data.AccelerationZ;
            VelocityX = data.VelocityX;
            VelocityY = data.VelocityY;
            VelocityZ = data.VelocityZ;
            AngularVelocityX = data.AngularVelocityX;
            AngularVelocityY = data.AngularVelocityY;
            AngularVelocityZ = data.AngularVelocityZ;
            Yaw = data.Yaw;
            Pitch = data.Pitch;
            Roll = data.Roll;
            NormalizedSuspensionTravelFrontLeft = data.NormalizedSuspensionTravelFrontLeft;
            NormalizedSuspensionTravelFrontRight = data.NormalizedSuspensionTravelFrontRight;
            NormalizedSuspensionTravelRearLeft = data.NormalizedSuspensionTravelRearLeft;
            NormalizedSuspensionTravelRearRight = data.NormalizedSuspensionTravelRearRight;
            TireSlipRatioFrontLeft = data.TireSlipRatioFrontLeft;
            TireSlipRatioFrontRight = data.TireSlipRatioFrontRight;
            TireSlipRatioRearLeft = data.TireSlipRatioRearLeft;
            TireSlipRatioRearRight = data.TireSlipRatioRearRight;
            WheelRotationSpeedFrontLeft = data.WheelRotationSpeedFrontLeft;
            WheelRotationSpeedFrontRight = data.WheelRotationSpeedFrontRight;
            WheelRotationSpeedRearLeft = data.WheelRotationSpeedRearLeft;
            WheelRotationSpeedRearRight = data.WheelRotationSpeedRearRight;
            WheelOnRumbleStripFrontLeft = data.WheelOnRumbleStripFrontLeft;
            WheelOnRumbleStripFrontRight = data.WheelOnRumbleStripFrontRight;
            WheelOnRumbleStripRearLeft = data.WheelOnRumbleStripRearLeft;
            WheelOnRumbleStripRearRight = data.WheelOnRumbleStripRearRight;
            WheelInPuddleDepthFrontLeft = data.WheelInPuddleDepthFrontLeft;
            WheelInPuddleDepthFrontRight = data.WheelInPuddleDepthFrontRight;
            WheelInPuddleDepthRearLeft = data.WheelInPuddleDepthRearLeft;
            WheelInPuddleDepthRearRight = data.WheelInPuddleDepthRearRight;
            SurfaceRumbleFrontLeft = data.SurfaceRumbleFrontLeft;
            SurfaceRumbleFrontRight = data.SurfaceRumbleFrontRight;
            SurfaceRumbleRearLeft = data.SurfaceRumbleRearLeft;
            SurfaceRumbleRearRight = data.SurfaceRumbleRearRight;
            TireSlipAngleFrontLeft = data.TireSlipAngleFrontLeft;
            TireSlipAngleFrontRight = data.TireSlipAngleFrontRight;
            TireSlipAngleRearLeft = data.TireSlipAngleRearLeft;
            TireSlipAngleRearRight = data.TireSlipAngleRearRight;
            TireCombinedSlipFrontLeft = data.TireCombinedSlipFrontLeft;
            TireCombinedSlipFrontRight = data.TireCombinedSlipFrontRight;
            TireCombinedSlipRearLeft = data.TireCombinedSlipRearLeft;
            TireCombinedSlipRearRight = data.TireCombinedSlipRearRight;
            SuspensionTravelMetersFrontLeft = data.SuspensionTravelMetersFrontLeft;
            SuspensionTravelMetersFrontRight = data.SuspensionTravelMetersFrontRight;
            SuspensionTravelMetersRearLeft = data.SuspensionTravelMetersRearLeft;
            SuspensionTravelMetersRearRight = data.SuspensionTravelMetersRearRight;
            CarOrdinal = data.CarOrdinal;
            CarClass = data.CarClass;
            CarPerformanceIndex = data.CarPerformanceIndex;
            DrivetrainType = data.DrivetrainType;
            NumCylinders = data.NumCylinders;
        }
    }

    public class DashDataModel
    {
        //hzn HorizonPlaceholder; // unknown FH4 values

        //f32 PositionX;
        public float PositionX { get; set; }

        //f32 PositionY;
        public float PositionY { get; set; }

        //f32 PositionZ;
        public float PositionZ { get; set; }

        //f32 Speed; // meters per second
        public float Speed { get; set; }

        //f32 Power; // watts
        public float Power { get; set; }

        //f32 Torque; // newton meter
        public float Torque { get; set; }

        //f32 TireTempFrontLeft;
        public float TireTempFrontLeft { get; set; }

        //f32 TireTempFrontRight;
        public float TireTempFrontRight { get; set; }

        //f32 TireTempRearLeft;
        public float TireTempRearLeft { get; set; }

        //f32 TireTempRearRight;
        public float TireTempRearRight { get; set; }

        //f32 Boost;
        public float Boost { get; set; }

        //f32 Fuel;
        public float Fuel { get; set; }

        //f32 DistanceTraveled;
        public float DistanceTraveled { get; set; }

        //f32 BestLap;
        public float BestLap { get; set; }

        //f32 LastLap;
        public float LastLap { get; set; }

        //f32 CurrentLap;
        public float CurrentLap { get; set; }

        //f32 CurrentRaceTime;
        public float CurrentRaceTime { get; set; }

        //u16 LapNumber;
        public ushort LapNumber { get; set; }

        //u8 RacePosition;
        public byte RacePosition { get; set; }

        //u8 Accel;
        public byte Accel { get; set; }

        //u8 Brake;
        public byte Brake { get; set; }

        //u8 Clutch;
        public byte Clutch { get; set; }

        //u8 HandBrake;
        public byte HandBrake { get; set; }

        //u8 Gear;
        public byte Gear { get; set; }

        //s8 Steer;
        public sbyte Steer { get; set; }

        //s8 NormalizedDrivingLine;
        public sbyte NormalizedDrivingLine { get; set; }

        //s8 NormalizedAIBrakeDifference;
        public sbyte NormalizedAIBrakeDifference { get; set; }

        public void Apply(DashStruct data)
        {
            PositionX = data.PositionX;
            PositionY = data.PositionY;
            PositionZ = data.PositionZ;
            Speed = data.Speed;
            Power = data.Power;
            Torque = data.Torque;
            TireTempFrontLeft = data.TireTempFrontLeft;
            TireTempFrontRight = data.TireTempFrontRight;
            TireTempRearLeft = data.TireTempRearLeft;
            TireTempRearRight = data.TireTempRearRight;
            Boost = data.Boost;
            Fuel = data.Fuel;
            DistanceTraveled = data.DistanceTraveled;
            BestLap = data.BestLap;
            LastLap = data.LastLap;
            CurrentLap = data.CurrentLap;
            CurrentRaceTime = data.CurrentRaceTime;
            LapNumber = data.LapNumber;
            RacePosition = data.RacePosition;
            Accel = data.Accel;
            Brake = data.Brake;
            Clutch = data.Clutch;
            HandBrake = data.HandBrake;
            Gear = data.Gear;
            Steer = data.Steer;
            NormalizedDrivingLine = data.NormalizedDrivingLine;
            NormalizedAIBrakeDifference = data.NormalizedAIBrakeDifference;
        }
    }
}