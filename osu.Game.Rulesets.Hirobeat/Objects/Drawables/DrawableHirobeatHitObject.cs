// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE
using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public class DrawableHirobeatHitObject : DrawableHitObject<HirobeatHitObject>
    {
        public DrawableHirobeatHitObject(HirobeatHitObject hitObject)
            : base(hitObject)
        {
        }

        protected override void UpdateState(ArmedState state)
        {
            FinishTransforms();

            
        }

        protected virtual void UpdateCurrentState(ArmedState state)
        {
        }
    }
}
