﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SkeletonEngine
{
    static class EngineLoader
    {
        static public void InitializeEngine(GameWindow gWindow, GraphicsDeviceManager gDeviceManager, GraphicsDevice gDevice, ContentManager cManager, SpriteBatch sBatch)
        {
            EngineControls.Initialize();

            GlobalVariables.Initialize(gWindow, gDeviceManager, gDevice, cManager, sBatch);
            ColorManager.Initialize();
            CameraManager.Initialize();
            GraphicsManager.Initialize();
            QuadManager.Initialize();


            LightManager.Initialize();
            EffectsManager.LoadContent();
            StringManager.LoadEmoticons();

            TestingClass.Initialize();
        }

        static private void LoadContent()
        {
        }

        /// <summary>
        /// Update the core engine.
        /// </summary>
        /// <param name="gameTime">The GameTime class.</param>
        /// <param name="WindowFocus">Game1 IsActive parameter.</param>
        static public void Update(GameTime gameTime, bool WindowFocus)
        {
            GlobalVariables.Update(gameTime);
            GraphicsManager.SetResolution(new Vector2(1280, 720));
            //GraphicsManager.SetResolution(new Vector2(1920, 1080));
            GraphicsManager.Update(WindowFocus);


            TestingClass.Update();
        }

        static public void Draw(SpriteBatch spriteBatch)
        {
            GraphicsManager.ResizeWindow();

            TestingClass.Draw();
        }
    }
}
