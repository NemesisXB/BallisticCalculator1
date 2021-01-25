﻿using Gehtsoft.Measurements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BallisticCalculator
{
    /// <summary>
    /// One point of the projectile trajectory
    /// </summary>
    public class TrajectoryPoint
    {
        /// <summary>
        /// Time since start
        /// </summary>
        public TimeSpan Time { get; }
        /// <summary>
        /// Distance traveled
        /// </summary>
        public Measurement<DistanceUnit> Distance { get; }
        /// <summary>
        /// Current velocity
        /// </summary>
        public Measurement<VelocityUnit> Velocity { get; }
        /// <summary>
        /// Velocity in Mach 
        /// 
        /// The value shows proportion of the current velocity to the velocity of sound for the current atmosphere conditions
        /// </summary>
        public double Mach { get; }

        /// <summary>
        /// Current drop 
        /// 
        /// The stop is vertical distance between trajectory and the line of sight.
        /// </summary>
        public Measurement<DistanceUnit> Drop { get; }

        /// <summary>
        /// Current windage 
        /// 
        /// The windage is horizontal distance between trajectory and the line of sight
        /// </summary>

        public Measurement<DistanceUnit> Windage { get; }


        /// <summary>
        /// Projectile energy
        /// </summary>
        public Measurement<EnergyUnit> Energy { get; }

        /// <summary>
        /// Adjustment for drop in angular units
        /// </summary>
        [JsonIgnore]
        public Measurement<AngularUnit> DropAdjustment { get; }

        /// <summary>
        /// Adjustment for windage in angular units
        /// </summary>
        [JsonIgnore]
        public Measurement<AngularUnit> WindageAdjustment { get; }

        /// <summary>
        /// Optimal weight of the game
        /// </summary>
        public Measurement<WeightUnit> OptimalGameWeight { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="time"></param>
        /// <param name="weight"></param>
        /// <param name="distance"></param>
        /// <param name="velocity"></param>
        /// <param name="mach"></param>
        /// <param name="drop"></param>
        /// <param name="windage"></param>
        public TrajectoryPoint(TimeSpan time, Measurement<WeightUnit> weight, Measurement<DistanceUnit> distance,
                               Measurement<VelocityUnit> velocity, double mach, Measurement<DistanceUnit> drop,
                               Measurement<DistanceUnit> windage)
            : this(time, distance, velocity, mach, drop, windage,
                  MeasurementMath.KineticEnergy(weight, velocity),
                  BallisticMath.OptimalGameWeight(weight, velocity))
        {

        }

        /// <summary>
        /// Constructor for serialization
        /// </summary>
        /// <param name="time"></param>
        /// <param name="distance"></param>
        /// <param name="velocity"></param>
        /// <param name="mach"></param>
        /// <param name="drop"></param>
        /// <param name="windage"></param>
        /// <param name="energy"></param>
        /// <param name="optimalGameWeight"></param>
        [JsonConstructor]
        public TrajectoryPoint(TimeSpan time, Measurement<DistanceUnit> distance,
                               Measurement<VelocityUnit> velocity, double mach, Measurement<DistanceUnit> drop,
                               Measurement<DistanceUnit> windage, Measurement<EnergyUnit> energy, 
                               Measurement<WeightUnit> optimalGameWeight)
        {
            Time = time;
            Distance = distance;
            Velocity = velocity;
            Drop = drop;
            DropAdjustment = MeasurementMath.Atan(Drop / Distance);

            Windage = windage;
            WindageAdjustment = MeasurementMath.Atan(Windage / Distance);
            Energy = energy;
            OptimalGameWeight = optimalGameWeight;
        }
    }
}
