using osu.Framework.Graphics;
using osu.Framework.Graphics.Shapes;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables
{
    public class DrawableSimpleMarker : DrawableMarker
    {
        private readonly Box growingRectangle;

        public DrawableSimpleMarker() : base()
        {
            Children = new Drawable[]
            {
                growingRectangle = new Box
                {
                    RelativeSizeAxes = Axes.Both,
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            };
        }

        public override void StartAnimation(float timePreempt)
        {
            growingRectangle.ScaleTo(0f);
            growingRectangle.FadeIn(timePreempt / 3);
            growingRectangle.ScaleTo(1f, timePreempt);
        }

    }
}
