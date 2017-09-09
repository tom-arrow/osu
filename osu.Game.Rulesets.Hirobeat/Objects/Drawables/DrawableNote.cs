// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics;
using osu.Game.Rulesets.Hirobeat.Objects.Drawables.Pieces;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public class DrawableNote : DrawableHirobeatHitObject
    {
        public const float TIME_PREEMPT = 600;
        public const float TIME_FADEIN = 400;
        public const float TIME_FADEOUT = 500;

        private readonly SquarePiece square;

        public DrawableNote(HirobeatHitObject hitObject)
            : base(hitObject)
        {
            Origin = Anchor.Centre;
        }
    }
}
