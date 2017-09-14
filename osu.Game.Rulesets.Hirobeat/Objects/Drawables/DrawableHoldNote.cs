using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    /// <summary>
    /// Visualises a <see cref="HoldNote"/> hit object.
    /// </summary>
    public class DrawableHoldNote : DrawableHirobeatHitObject<HoldNote>, IKeyBindingHandler<HirobeatAction>
    {
        /// <summary>
        /// Time at which the user started holding this hold note. Null if the user is not holding this hold note.
        /// </summary>
        private double? holdStartTime;

        /// <summary>
        /// Whether the hold note has been released too early and shouldn't give full score for the release.
        /// </summary>
        private bool hasBroken;

        public DrawableHoldNote(HoldNote hitObject, HirobeatAction? action = null)
            : base(hitObject, action)
        {
        }

        public bool OnPressed(HirobeatAction action)
        {
            throw new System.NotImplementedException();
        }

        public bool OnReleased(HirobeatAction action)
        {
            throw new System.NotImplementedException();
        }

        protected override void UpdateState(ArmedState state)
        {
            throw new System.NotImplementedException();
        }
    }
}
