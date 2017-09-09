using System.ComponentModel;

namespace osu.Game.Rulesets.Hirobeat.Judgements
{
    public enum HirobeatHitResult
    {
        [Description("POOR")]
        Poor,
        [Description("GOOD")]
        Good,
        [Description("GREAT")]
        Great,
        [Description("PERFECT")]
        Perfect
    }
}
