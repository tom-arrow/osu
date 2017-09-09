using osu.Game.Beatmaps;
using osu.Game.Rulesets.Hirobeat.Objects;

namespace osu.Game.Rulesets.Hirobeat.Mods
{
    internal class HirobeatAutoGenerator
    {
        private Beatmap<HirobeatHitObject> beatmap;

        public HirobeatAutoGenerator(Beatmap<HirobeatHitObject> beatmap)
        {
            this.beatmap = beatmap;
        }
    }
}