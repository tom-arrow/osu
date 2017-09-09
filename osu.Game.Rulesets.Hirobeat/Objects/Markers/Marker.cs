
using osu.Game.Rulesets.Hirobeat.Objects.Markers;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables.Markers
{
    public abstract class Marker
    {
        public abstract IMarkerAnimation CreateMainAnimation();
    }
}