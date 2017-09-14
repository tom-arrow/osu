using osu.Game.Rulesets.Objects.Types;

namespace osu.Game.Rulesets.Hirobeat.Objects
{
    /// <summary>
    /// Represents a hit object which requires pressing, holding, and releasing a key.
    /// </summary>
    public class HoldNote : HirobeatHitObject, IHasEndTime
    {
        public double EndTime => StartTime + Duration;
        public double Duration { get; set; }
    }
}
