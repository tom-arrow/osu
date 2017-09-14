using osu.Framework.Input.Bindings;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Hirobeat
{
    public class HirobeatInputManager : RulesetInputManager<HirobeatAction>
    {
        public HirobeatInputManager(RulesetInfo ruleset, int variant)
            : base(ruleset, variant, SimultaneousBindingMode.Unique)
        {
        }
    }

    public enum HirobeatAction
    {
        Key00,
        Key01,
        Key02,
        Key03,

        Key10,
        Key11,
        Key12,
        Key13,

        Key20,
        Key21,
        Key22,
        Key23,

        Key30,
        Key31,
        Key32,
        Key33
    }
}
