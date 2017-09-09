// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;
using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Objects;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using OpenTK;

namespace osu.Game.Rulesets.Hirobeat.Beatmaps
{
    public class HirobeatBeatmapConverter : BeatmapConverter<HirobeatHitObject>
    {
        private readonly int gridSize;

        protected override IEnumerable<Type> ValidConversionTypes { get; } = new[] { typeof(HitObject) };

        private readonly bool isForCurrentRuleset;

        public HirobeatBeatmapConverter(bool isForCurrentRuleset, int gridSize)
        {
            if (gridSize <= 0) throw new ArgumentOutOfRangeException(nameof(gridSize));

            this.isForCurrentRuleset = isForCurrentRuleset;
            this.gridSize = gridSize;
        }

        protected override IEnumerable<HirobeatHitObject> ConvertHitObject(HitObject original, Beatmap beatmap)
        {
            if (original is IHasPosition positionData)
            {
                yield return new Note
                {
                    StartTime = original.StartTime,
                    Samples = original.Samples,
                    XGrid = getXGridPosition(positionData.X),
                    YGrid = getYGridPosition(positionData.Y),

                };
            }
            else
            {
                yield return new Note
                {
                    StartTime = original.StartTime,
                    Samples = original.Samples,
                    XGrid = 0,
                    YGrid = 0,
                };
            }
        }

        private int getGridPosition(float position)
        {
            float localDivisor = 384f / gridSize;
            return MathHelper.Clamp((int)Math.Floor(position / localDivisor), 0, gridSize - 1);
        }

        private int getXGridPosition(float position)
        {
            return getGridPosition(position - 64f);
        }

        private int getYGridPosition(float position)
        {
            return getGridPosition(position);
        }

    }
}
