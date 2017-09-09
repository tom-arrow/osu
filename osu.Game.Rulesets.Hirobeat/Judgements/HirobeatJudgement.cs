using osu.Framework.Extensions;
using osu.Game.Rulesets.Hirobeat.Judgements;
using osu.Game.Rulesets.Judgements;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public class HirobeatJudgement : Judgement
    {

        /// <summary>
        /// The maximum result.
        /// </summary>
        public const HirobeatHitResult MAX_HIT_RESULT = HirobeatHitResult.Perfect;


        /// <summary>
        /// The result.
        /// </summary>
        public HirobeatHitResult HirobeatResult;

        public override string ResultString => HirobeatResult.GetDescription();

        public override string MaxResultString => MAX_HIT_RESULT.GetDescription();
    }
}