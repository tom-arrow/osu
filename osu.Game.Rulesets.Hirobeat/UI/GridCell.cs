// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Game.Rulesets.Hirobeat.Objects;
using OpenTK;
using OpenTK.Graphics;

namespace osu.Game.Rulesets.Hirobeat.UI
{
    public class GridCell : Container
    {
        private Box background;
        private Box outline;

        private const float background_opacity = 0.2f;

        public GridCell()
        {
            Size = new Vector2(HirobeatHitObject.OBJECT_SIZE);

            Children = new Drawable[]
            {
                background = new Box
                {
                    Name = "Background",
                    RelativeSizeAxes = Axes.Both,
                    Colour = Color4.Black,
                    Alpha = background_opacity
                },

                outline = new Box
                {
                    Name = "Outline",
                    RelativeSizeAxes = Axes.Both,
                }
            };
        }


    }
}
