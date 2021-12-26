using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaHorizon5.Telemetry
{
    public struct SledStruct
    {
        //s32 IsRaceOn; // = 1 when race is on. = 0 when in menus/race stopped …
        public int IsRaceOn;

        //u32 TimestampMS; //Can overflow to 0 eventually
        public uint TimestampMS;

        //f32 EngineMaxRpm;
        public float EngineMaxRpm;

        //f32 EngineIdleRpm;
        public float EngineIdleRpm;

        //f32 CurrentEngineRpm;
        public float CurrentEngineRpm;

        //f32 AccelerationX; //In the car's local space; X = right, Y = up, Z = forward
        public float AccelerationX;

        //f32 AccelerationY;
        public float AccelerationY;

        //f32 AccelerationZ;
        public float AccelerationZ;

        //f32 VelocityX; //In the car's local space; X = right, Y = up, Z = forward
        public float VelocityX;

        //f32 VelocityY;
        public float VelocityY;

        //f32 VelocityZ;
        public float VelocityZ;

        //f32 AngularVelocityX; //In the car's local space; X = pitch, Y = yaw, Z = roll
        public float AngularVelocityX;

        //f32 AngularVelocityY;
        public float AngularVelocityY;

        //f32 AngularVelocityZ;
        public float AngularVelocityZ;

        //f32 Yaw;
        public float Yaw;

        //f32 Pitch;
        public float Pitch;

        //f32 Roll;
        public float Roll;

        //f32 NormalizedSuspensionTravelFrontLeft; // Suspension travel normalized: 0.0f = max stretch; 1.0 = max compression
        public float NormalizedSuspensionTravelFrontLeft;

        //f32 NormalizedSuspensionTravelFrontRight;
        public float NormalizedSuspensionTravelFrontRight;

        //f32 NormalizedSuspensionTravelRearLeft;
        public float NormalizedSuspensionTravelRearLeft;

        //f32 NormalizedSuspensionTravelRearRight;
        public float NormalizedSuspensionTravelRearRight;

        //f32 TireSlipRatioFrontLeft; // Tire normalized slip ratio, = 0 means 100% grip and |ratio| > 1.0 means loss of grip.
        public float TireSlipRatioFrontLeft;

        //f32 TireSlipRatioFrontRight;
        public float TireSlipRatioFrontRight;

        //f32 TireSlipRatioRearLeft;
        public float TireSlipRatioRearLeft;

        //f32 TireSlipRatioRearRight;
        public float TireSlipRatioRearRight;

        //f32 WheelRotationSpeedFrontLeft; // Wheel rotation speed radians/sec.
        public float WheelRotationSpeedFrontLeft;

        //f32 WheelRotationSpeedFrontRight;
        public float WheelRotationSpeedFrontRight;

        //f32 WheelRotationSpeedRearLeft;
        public float WheelRotationSpeedRearLeft;

        //f32 WheelRotationSpeedRearRight;
        public float WheelRotationSpeedRearRight;

        //s32 WheelOnRumbleStripFrontLeft; // = 1 when wheel is on rumble strip, = 0 when off.
        public int WheelOnRumbleStripFrontLeft;

        //s32 WheelOnRumbleStripFrontRight;
        public int WheelOnRumbleStripFrontRight;

        //s32 WheelOnRumbleStripRearLeft;
        public int WheelOnRumbleStripRearLeft;

        //s32 WheelOnRumbleStripRearRight;
        public int WheelOnRumbleStripRearRight;

        //f32 WheelInPuddleDepthFrontLeft; // = from 0 to 1, where 1 is the deepest puddle
        public float WheelInPuddleDepthFrontLeft;

        //f32 WheelInPuddleDepthFrontRight;
        public float WheelInPuddleDepthFrontRight;

        //f32 WheelInPuddleDepthRearLeft;
        public float WheelInPuddleDepthRearLeft;

        //f32 WheelInPuddleDepthRearRight;
        public float WheelInPuddleDepthRearRight;

        //f32 SurfaceRumbleFrontLeft; // Non-dimensional surface rumble values passed to controller force feedback
        public float SurfaceRumbleFrontLeft;

        //f32 SurfaceRumbleFrontRight;
        public float SurfaceRumbleFrontRight;

        //f32 SurfaceRumbleRearLeft;
        public float SurfaceRumbleRearLeft;

        //f32 SurfaceRumbleRearRight;
        public float SurfaceRumbleRearRight;

        //f32 TireSlipAngleFrontLeft; // Tire normalized slip angle, = 0 means 100% grip and |angle| > 1.0 means loss of grip.
        public float TireSlipAngleFrontLeft;

        //f32 TireSlipAngleFrontRight;
        public float TireSlipAngleFrontRight;

        //f32 TireSlipAngleRearLeft;
        public float TireSlipAngleRearLeft;

        //f32 TireSlipAngleRearRight;
        public float TireSlipAngleRearRight;

        //f32 TireCombinedSlipFrontLeft; // Tire normalized combined slip, = 0 means 100% grip and |slip| > 1.0 means loss of grip.
        public float TireCombinedSlipFrontLeft;

        //f32 TireCombinedSlipFrontRight;
        public float TireCombinedSlipFrontRight;

        //f32 TireCombinedSlipRearLeft;
        public float TireCombinedSlipRearLeft;

        //f32 TireCombinedSlipRearRight;
        public float TireCombinedSlipRearRight;

        //f32 SuspensionTravelMetersFrontLeft; // Actual suspension travel in meters
        public float SuspensionTravelMetersFrontLeft;

        //f32 SuspensionTravelMetersFrontRight;
        public float SuspensionTravelMetersFrontRight;

        //f32 SuspensionTravelMetersRearLeft;
        public float SuspensionTravelMetersRearLeft;

        //f32 SuspensionTravelMetersRearRight;
        public float SuspensionTravelMetersRearRight;

        //s32 CarOrdinal; //Unique ID of the car make/model
        public int CarOrdinal;

        //s32 CarClass; //Between 0 (D -- worst cars) and 7 (X class -- best cars) inclusive
        public int CarClass;

        //s32 CarPerformanceIndex; //Between 100 (slowest car) and 999 (fastest car) inclusive
        public int CarPerformanceIndex;

        //s32 DrivetrainType; //Corresponds to EDrivetrainType; 0 = FWD, 1 = RWD, 2 = AWD
        public int DrivetrainType;

        //s32 NumCylinders; //Number of cylinders in the engine
        public int NumCylinders;
    }
}
