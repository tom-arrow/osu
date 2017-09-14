using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Rulesets.UI;
using OpenTK;

namespace osu.Game.Rulesets.Hirobeat.UI
{
    public class HirobeatPlayfield : Playfield
    {
        private readonly Container markers;
        private readonly Container judgementLayer;

        public static readonly Vector2 BASE_SIZE = new Vector2(384, 384);

        public override Vector2 Size
        {
            get
            {
                var parentSize = Parent.DrawSize;
                var aspectSize = parentSize.X < parentSize.Y ? new Vector2(parentSize.X, parentSize.X) : new Vector2(parentSize.Y, parentSize.Y);

                return new Vector2(aspectSize.X / parentSize.X, aspectSize.Y / parentSize.Y) * base.Size;
            }
        }

        public HirobeatPlayfield() : base(BASE_SIZE.X)
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            AddRange(new Drawable[]
            {
                markers = new Container
                {
                    RelativeSizeAxes =  Axes.Both,
                    Depth = 2
                },
                judgementLayer = new Container
                {
                    RelativeSizeAxes =  Axes.Both,
                    Depth = 1
                },
            });
        }
    }
}
