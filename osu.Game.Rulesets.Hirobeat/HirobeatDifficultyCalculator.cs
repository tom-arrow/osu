using System;
using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Objects;

namespace osu.Game.Rulesets.Hirobeat
{
    internal class HirobeatDifficultyCalculator : DifficultyCalculator<HirobeatHitObject>
    {

        public HirobeatDifficultyCalculator(Beatmap beatmap)
            : base(beatmap)
        {
        }

        protected override double CalculateInternal(Dictionary<string, string> categoryDifficulty)
        {
            return 0;
        }

        protected override BeatmapConverter<HirobeatHitObject> CreateBeatmapConverter() => new HirobeatBeatmapConverter(true, (int)Math.Max(1, Math.Round(Beatmap.BeatmapInfo.Difficulty.CircleSize)));
    }
}