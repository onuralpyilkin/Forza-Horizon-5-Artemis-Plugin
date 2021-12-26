using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForzaHorizon5.Telemetry
{
    public struct DashStruct
    {
        //hzn HorizonPlaceholder; // unknown FH4 values

        //f32 PositionX;
        public float PositionX;

        //f32 PositionY;
        public float PositionY;

        //f32 PositionZ;
        public float PositionZ;

        //f32 Speed; // meters per second
        public float Speed;

        //f32 Power; // watts
        public float Power;

        //f32 Torque; // newton meter
        public float Torque;

        //f32 TireTempFrontLeft;
        public float TireTempFrontLeft;

        //f32 TireTempFrontRight;
        public float TireTempFrontRight;

        //f32 TireTempRearLeft;
        public float TireTempRearLeft;

        //f32 TireTempRearRight;
        public float TireTempRearRight;

        //f32 Boost;
        public float Boost;

        //f32 Fuel;
        public float Fuel;

        //f32 DistanceTraveled;
        public float DistanceTraveled;

        //f32 BestLap;
        public float BestLap;

        //f32 LastLap;
        public float LastLap;

        //f32 CurrentLap;
        public float CurrentLap;

        //f32 CurrentRaceTime;
        public float CurrentRaceTime;

        //u16 LapNumber;
        public ushort LapNumber;

        //u8 RacePosition;
        public byte RacePosition;

        //u8 Accel;
        public byte Accel;

        //u8 Brake;
        public byte Brake;

        //u8 Clutch;
        public byte Clutch;

        //u8 HandBrake;
        public byte HandBrake;

        //u8 Gear;
        public byte Gear;

        //s8 Steer;
        public sbyte Steer;

        //s8 NormalizedDrivingLine;
        public sbyte NormalizedDrivingLine;

        //s8 NormalizedAIBrakeDifference;
        public sbyte NormalizedAIBrakeDifference;
    }
}
