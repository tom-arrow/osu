using osu.Game.Rulesets.Mods;


namespace osu.Game.Rulesets.Hirobeat.Mods
{
    public class HirobeatModNoFail : ModNoFail
    {

    }

    public class HirobeatModEasy : ModEasy
    {

    }

    public class HirobeatModHidden : ModHidden
    {
        public override double ScoreMultiplier => 1.06;
    }

    public class HirobeatModHardRock : ModHardRock
    {
        public override double ScoreMultiplier => 1.06;
        public override bool Ranked => true;
    }

    public class HirobeatModSuddenDeath : ModSuddenDeath
    {

    }

    public class HirobeatModDaycore : ModDaycore
    {
        public override double ScoreMultiplier => 0.5;
    }

    public class HirobeatModDoubleTime : ModDoubleTime
    {
        public override double ScoreMultiplier => 1.12;
    }

    public class HirobeatModRelax : ModRelax
    {

    }

    public class HirobeatModHalfTime : ModHalfTime
    {
        public override double ScoreMultiplier => 0.5;
    }

    public class HirobeatModNightcore : ModNightcore
    {
        public override double ScoreMultiplier => 1.12;
    }

    public class HirobeatModFlashlight : ModFlashlight
    {
        public override double ScoreMultiplier => 1.12;
    }

    public class HirobeatModPerfect : ModPerfect
    {

    }
}
