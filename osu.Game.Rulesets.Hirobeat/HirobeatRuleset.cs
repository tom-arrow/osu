using System.Collections.Generic;
using System.Linq;
using osu.Framework.Graphics.Textures;
using osu.Framework.IO.Stores;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Hirobeat.Mods;
using osu.Game.Rulesets.Hirobeat.Objects;
using osu.Game.Rulesets.Hirobeat.UI;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;
using osu.Framework.Graphics;

namespace osu.Game.Rulesets.Hirobeat
{
    public class HirobeatRuleset : Ruleset
    {
        public static ResourceStore<byte[]> ResourceStore;
        public static TextureStore TextureStore;

        public HirobeatRuleset(RulesetInfo rulesetInfo)
            : base(rulesetInfo)
        {
            ResourceStore = new NamespacedResourceStore<byte[]>(new DllResourceStore("osu.Game.Rulesets.Hirobeat.dll"), "Resources");
            TextureStore = new TextureStore(new RawTextureLoaderStore(new NamespacedResourceStore<byte[]>(ResourceStore, @"Textures")));
        }

        public override IEnumerable<BeatmapStatistic> GetBeatmapStatistics(WorkingBeatmap beatmap) => new[]
        {
            new BeatmapStatistic
            {
                Name = @"Note count",
                Content = beatmap.Beatmap.HitObjects.Count(h => h is Note).ToString(),
                Icon = FontAwesome.fa_dot_circle_o
            },
            new BeatmapStatistic
            {
                Name = @"Hold count",
                Content = "lol",
                Icon = FontAwesome.fa_circle_o
            },
        };

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            switch (type)
            {
                case ModType.DifficultyReduction:
                    return new Mod[]
                    {
                        new HirobeatModEasy(),
                        new HirobeatModNoFail(),
                        new MultiMod
                        {
                            Mods = new Mod[]
                            {
                                new HirobeatModHalfTime(),
                                new HirobeatModDaycore(),
                            },
                        },
                    };

                case ModType.DifficultyIncrease:
                    return new Mod[]
                    {
                        new HirobeatModHardRock(),
                        new MultiMod
                        {
                            Mods = new Mod[]
                            {
                                new HirobeatModSuddenDeath(),
                                new HirobeatModPerfect(),
                            },
                        },
                        new MultiMod
                        {
                            Mods = new Mod[]
                            {
                                new HirobeatModDoubleTime(),
                                new HirobeatModNightcore(),
                            },
                        },
                        new HirobeatModHidden(),
                        new HirobeatModFlashlight(),
                    };

                case ModType.Special:
                    return new Mod[]
                    {
                        new HirobeatModRelax(),
                        null,
                        null,
                        new MultiMod
                        {
                            Mods = new Mod[]
                            {
                                new ModAutoplay(),
                                new ModCinema(),
                            },
                        },
                    };

                default:
                    return new Mod[] { };
            }
        }

        public override Drawable CreateIcon() => new SpriteIcon() { Icon = FontAwesome.fa_square };

        public override RulesetContainer CreateRulesetContainerWith(WorkingBeatmap beatmap, bool isForCurrentRuleset) => new HirobeatRulesetContainer(this, beatmap, isForCurrentRuleset);

        public override DifficultyCalculator CreateDifficultyCalculator(Beatmap beatmap) => new HirobeatDifficultyCalculator(beatmap);

        public override string Description => "hirobeat!";

        public override int LegacyID => 16;
    }
}
