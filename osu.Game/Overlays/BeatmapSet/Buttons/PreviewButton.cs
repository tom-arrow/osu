﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Audio.Track;
using osu.Framework.Configuration;
using osu.Framework.Extensions.Color4Extensions;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Graphics.Containers;
using osu.Game.Overlays.Direct;
using OpenTK;
using OpenTK.Graphics;

namespace osu.Game.Overlays.BeatmapSet.Buttons
{
    public class PreviewButton : OsuClickableContainer
    {
        private const float transition_duration = 500;

        private readonly Box bg, progress;
        private readonly PlayButton playButton;

        private Track preview => playButton.Preview;
        public Bindable<bool> Playing => playButton.Playing;

        public BeatmapSetInfo BeatmapSet
        {
            get { return playButton.BeatmapSet; }
            set { playButton.BeatmapSet = value; }
        }

        public PreviewButton()
        {
            Height = 42;

            Children = new Drawable[]
            {
                bg = new Box
                {
                    RelativeSizeAxes = Axes.Both,
                    Colour = Color4.Black.Opacity(0.25f),
                },
                new Container
                {
                    Anchor = Anchor.BottomLeft,
                    Origin = Anchor.BottomLeft,
                    RelativeSizeAxes = Axes.X,
                    Height = 3,
                    Child = progress = new Box
                    {
                        RelativeSizeAxes = Axes.Both,
                        Width = 0f,
                        Alpha = 0f,
                    },
                },
                playButton = new PlayButton
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                    Size = new Vector2(18),
                },
            };

            Action = () => Playing.Value = !Playing.Value;
            Playing.ValueChanged += newValue => progress.FadeTo(newValue ? 1 : 0, 100);
        }

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            progress.Colour = colours.Yellow;
        }

        protected override void Update()
        {
            base.Update();

            if (Playing.Value && preview != null)
            {
                // prevent negative (potential infinite) width if a track without length was loaded
                progress.Width = preview.Length > 0 ? (float)(preview.CurrentTime / preview.Length) : 0f;
            }
            else
                progress.Width = 0;
        }

        protected override void Dispose(bool isDisposing)
        {
            Playing.Value = false;
            base.Dispose(isDisposing);
        }

        protected override bool OnHover(InputState state)
        {
            bg.FadeColour(Color4.Black.Opacity(0.5f), 100);
            return base.OnHover(state);
        }

        protected override void OnHoverLost(InputState state)
        {
            bg.FadeColour(Color4.Black.Opacity(0.25f), 100);
            base.OnHoverLost(state);
        }
    }
}
