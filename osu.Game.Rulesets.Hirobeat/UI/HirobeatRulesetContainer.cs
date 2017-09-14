// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Objects;
using osu.Game.Rulesets.Hirobeat.Objects.Drawables;
using osu.Game.Rulesets.Hirobeat.Scoring;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Hirobeat.UI
{
    public class HirobeatRulesetContainer : RulesetContainer<HirobeatPlayfield, HirobeatHitObject>
    {
        private int gridSize;

        public HirobeatRulesetContainer(Ruleset ruleset, WorkingBeatmap beatmap, bool isForCurrentRuleset)
            : base(ruleset, beatmap, isForCurrentRuleset)
        {
        }

        public override ScoreProcessor CreateScoreProcessor() => new HirobeatScoreProcessor(this);

        public override PassThroughInputManager CreateInputManager() => new HirobeatInputManager(Ruleset.RulesetInfo);

        protected override BeatmapConverter<HirobeatHitObject> CreateBeatmapConverter()
        {
            if(IsForCurrentRuleset)
                gridSize = (int)Math.Max(1, Math.Round(WorkingBeatmap.BeatmapInfo.Difficulty.CircleSize));
            else
            {
                gridSize = 4;
            }
            return new HirobeatBeatmapConverter(IsForCurrentRuleset, gridSize);
        }

        protected override DrawableHitObject<HirobeatHitObject> GetVisualRepresentation(HirobeatHitObject h)
        {
            var note = h as Note;
            if (note != null)
                return new DrawableNote(note);
            return null;
        }

        protected override Playfield CreatePlayfield() => new HirobeatPlayfield();
    }
}
