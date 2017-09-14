// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics.Containers;

namespace osu.Game.Rulesets.Hirobeat.UI
{
    public class Grid : FillFlowContainer
    {
        private readonly int gridSize;

        public Grid(int gridSize)
        {
            this.gridSize = gridSize;

            Direction = FillDirection.Horizontal;

            for (int i = 0; i < gridSize; i++)
            {
                var ffc = new FillFlowContainer<GridCell>
                {
                    Direction = FillDirection.Vertical
                };

                for (int j = 0; j < gridSize; j++)
                {
                    ffc.Add(new GridCell());
                }
            }
        }
    }
}
