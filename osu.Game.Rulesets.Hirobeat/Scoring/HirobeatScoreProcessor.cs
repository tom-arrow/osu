// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Game.Rulesets.Hirobeat.Objects;
using osu.Game.Rulesets.Hirobeat.Objects.Drawables;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Hirobeat.Scoring
{
    public class HirobeatScoreProcessor : ScoreProcessor<HirobeatHitObject, HirobeatJudgement>
    {
        public HirobeatScoreProcessor()
        {
        }

        public HirobeatScoreProcessor(RulesetContainer<HirobeatHitObject, HirobeatJudgement> rulesetContainer)
            : base(rulesetContainer)
        {
        }

        protected override void OnNewJudgement(HirobeatJudgement judgement)
        {
            throw new System.NotImplementedException();
        }
    }
}
