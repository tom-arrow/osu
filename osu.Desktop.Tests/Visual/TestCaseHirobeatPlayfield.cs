// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Collections.Generic;
using osu.Desktop.Tests.Beatmaps;
using osu.Framework.Allocation;
using osu.Framework.Graphics.Containers;
using osu.Game.Beatmaps;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Rulesets;
using osu.Game.Rulesets.Hirobeat.Objects;
using osu.Game.Rulesets.Hirobeat.Objects.Drawables;
using osu.Game.Rulesets.Hirobeat.UI;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Taiko.Objects;

namespace osu.Desktop.Tests.Visual
{
    public class TestCaseHirobeatPlayfield : OsuTestCase
    {
        private const float delay = 1000;

        public override string Description => "Hirobeat playfield";
        private HirobeatRulesetContainer rulesetContainer;
        private Container playfieldContainer;

        [BackgroundDependencyLoader]
        private void load(RulesetStore rulesets)
        {
            AddStep("Note", () => addNote());

            var controlPointInfo = new ControlPointInfo();
            controlPointInfo.TimingPoints.Add(new TimingControlPoint());

            WorkingBeatmap beatmap = new TestWorkingBeatmap(new Beatmap
            {
                HitObjects = new List<HitObject> { new CentreHit() },
                BeatmapInfo = new BeatmapInfo
                {
                    Difficulty = new BeatmapDifficulty(),
                    Metadata = new BeatmapMetadata
                    {
                        Artist = @"Unknown",
                        Title = @"Sample Beatmap",
                        Author = @"peppy",
                    },
                },
                ControlPointInfo = controlPointInfo
            });


        }

        private void addNote()
        {
            rulesetContainer.Playfield.Add(new DrawableNote(new HirobeatHitObject
            {
                StartTime = rulesetContainer.Playfield.Time.Current + delay
            }));
        }
    }
}
