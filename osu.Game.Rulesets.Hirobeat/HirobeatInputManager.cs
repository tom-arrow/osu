using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Hirobeat
{
    public class HirobeatInputManager : RulesetInputManager<HirobeatAction>
    {
        public HirobeatInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum HirobeatAction
    {
    }
}
