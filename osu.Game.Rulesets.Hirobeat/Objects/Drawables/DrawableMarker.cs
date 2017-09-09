using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using OpenTK;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public abstract class DrawableMarker : Container
    {
        public const float SQUARE_SIZE = 100f;

        public abstract void StartAnimation(float timePreempt);

        public DrawableMarker()
        {
            Origin = Anchor.Centre;
            Size = new Vector2(SQUARE_SIZE, SQUARE_SIZE);
        }
    }
}
