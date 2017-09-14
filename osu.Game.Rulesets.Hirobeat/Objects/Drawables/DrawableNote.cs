// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Graphics;
using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.Hirobeat.Judgements;
using osu.Game.Rulesets.Hirobeat.Objects.Drawables.Pieces;
using osu.Game.Rulesets.Objects.Drawables;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    /// <summary>
    /// Visualises a <see cref="Note"/> hit object.
    /// </summary>
    public class DrawableNote : DrawableHirobeatHitObject<Note>, IKeyBindingHandler<HirobeatAction>
    {
        public const float TIME_PREEMPT = 600;
        public const float TIME_FADEIN = 400;
        public const float TIME_FADEOUT = 500;

        private readonly SquarePiece square;

        public DrawableNote(Note hitObject)
            : base(hitObject)
        {
            Origin = Anchor.Centre;
        }

        protected override void CheckForJudgements(bool userTriggered, double timeOffset)
        {
            if (!userTriggered)
            {
                if (timeOffset > HitObject.HitWindowFor(HitResult.Meh))
                    AddJudgement(new HirobeatJudgement{ Result = HitResult.Miss});
                return;
            }

            AddJudgement(new HirobeatJudgement
            {
                Result = HitObject.ScoreResultForOffset(Math.Abs(timeOffset))
            });
        }

        public bool OnPressed(HirobeatAction action)
        {
            if (action != Action)
                return false;
            return UpdateJudgement(true);
        }

        public bool OnReleased(HirobeatAction action) => false;

        protected override void UpdateState(ArmedState state)
        {
            
        }
    }
}
