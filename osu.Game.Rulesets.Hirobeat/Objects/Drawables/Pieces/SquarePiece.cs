using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using OpenTK;

namespace osu.Game.Rulesets.Hirobeat.Objects.Drawables.Pieces
{
    public class SquarePiece : Container
    {
        public SquarePiece()
        {
            Size = new Vector2(HirobeatHitObject.OBJECT_SIZE);
            Masking = true;
            CornerRadius = 10;

            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

        }
    }
}
