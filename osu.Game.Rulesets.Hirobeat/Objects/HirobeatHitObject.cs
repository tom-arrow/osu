using osu.Game.Rulesets.Hirobeat.Objects.Types;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Objects
{
    public class HirobeatHitObject : HitObject, IHasGridPosition
    {
        public const float OBJECT_SIZE = 100f;
        public int XGrid { get; set; }
        public int YGrid { get; set; }

        public double HitWindowFor(HitResult result)
        {
            switch (result)
            {
                default:
                    return 300;
                case HitResult.Meh:
                    return 150;
                case HitResult.Good:
                    return 80;
                case HitResult.Great:
                    return 30;
            }
        }

        public HitResult ScoreResultForOffset(double offset)
        {
            if (offset < HitWindowFor(HitResult.Great))
                return HitResult.Great;
            if (offset < HitWindowFor(HitResult.Good))
                return HitResult.Good;
            if (offset < HitWindowFor(HitResult.Meh))
                return HitResult.Meh;
            return HitResult.Miss;
        }
    }

}
