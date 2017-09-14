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
using osu.Framework.Input.Bindings;

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

        public override string Description => "hirobeat!";

        public override Drawable CreateIcon() => new SpriteIcon() { Icon = FontAwesome.fa_square_o };

        public override RulesetContainer CreateRulesetContainerWith(WorkingBeatmap beatmap, bool isForCurrentRuleset) => new HirobeatRulesetContainer(this, beatmap, isForCurrentRuleset);

        public override DifficultyCalculator CreateDifficultyCalculator(Beatmap beatmap) => new HirobeatDifficultyCalculator(beatmap);

        public override int LegacyID => 16;

        public override IEnumerable<int> AvailableVariants => new[] { 3, 4 };

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new List<KeyBinding>
        {
            new KeyBinding(InputKey.Number1, HirobeatAction.Key00),
            new KeyBinding(InputKey.Q, HirobeatAction.Key01),
            new KeyBinding(InputKey.A, HirobeatAction.Key02),
            new KeyBinding(InputKey.Z, HirobeatAction.Key03),

            new KeyBinding(InputKey.Number2, HirobeatAction.Key10),
            new KeyBinding(InputKey.W, HirobeatAction.Key11),
            new KeyBinding(InputKey.S, HirobeatAction.Key12),
            new KeyBinding(InputKey.X, HirobeatAction.Key13),

            new KeyBinding(InputKey.Number3, HirobeatAction.Key20),
            new KeyBinding(InputKey.E, HirobeatAction.Key21),
            new KeyBinding(InputKey.D, HirobeatAction.Key22),
            new KeyBinding(InputKey.C, HirobeatAction.Key23),

            new KeyBinding(InputKey.Number4, HirobeatAction.Key30),
            new KeyBinding(InputKey.R, HirobeatAction.Key31),
            new KeyBinding(InputKey.F, HirobeatAction.Key32),
            new KeyBinding(InputKey.V, HirobeatAction.Key33),
        };

        public override string GetVariantName(int variant) => $"{variant}x{variant}";
    }
}
