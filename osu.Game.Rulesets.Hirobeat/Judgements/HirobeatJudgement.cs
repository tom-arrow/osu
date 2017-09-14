using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Judgements
{
    public class HirobeatJudgement : Judgement
    {

        protected override int NumericResultFor(HitResult result)
        {
            switch (result)
            {
                default:
                    return 0;
                case HitResult.Meh:
                    return 50;
                case HitResult.Good:
                    return 100;
                case HitResult.Great:
                    return 300;
            }
        }
    }
}