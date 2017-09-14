using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public abstract class DrawableHirobeatHitObject<TObject> : DrawableHitObject<HirobeatHitObject>
        where TObject : HirobeatHitObject
    {
        /// <summary>
        /// The key that will trigger input for this hit object.
        /// </summary>
        protected HirobeatAction Action { get; }

        public new TObject HitObject;

        public DrawableHirobeatHitObject(TObject hitObject, HirobeatAction? action = null)
            : base(hitObject)
        {
            HitObject = hitObject;

            if (action != null)
                Action = action.Value;
        }
    }
}
