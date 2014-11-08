﻿using GreyMagic;
using IceFlake.Client;
using IceFlake.Client.Objects;
using IceFlake.Client.Collections;
using IceFlake.Client.Scripts;
using IceFlake.DirectX;
using IceFlake.Runtime;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace IceFlake
{
    internal static class Manager
    {
        internal static void Initialize()
        {
            Memory = new InProcessMemoryReader(Process.GetCurrentProcess());

            Direct3D.OnFirstFrame += Start;
            Direct3D.OnLastFrame += Stop;
            Direct3D.Initialize();
        }

        internal static void Start(object sender, EventArgs e)
        {
            //Debugger.Break();
            Stopwatch sw = Stopwatch.StartNew();

            ObjectManager = new ObjectManager();
            AssemblyAnalyzer.RegisterTarget(ObjectManager);

            ESExecute = new EndSceneExecute();
            AssemblyAnalyzer.RegisterTarget(ESExecute);

            DBC = new WoWDB();

            Movement = new Movement();
            AssemblyAnalyzer.RegisterTarget(Movement);

            LuaInterface.Initialize();

            Events = new Events();
            AssemblyAnalyzer.RegisterTarget(Events);

            Helper.Initialize();

            Spellbook = new SpellCollection();
            AssemblyAnalyzer.RegisterTarget(Spellbook);

            ScriptManager.Initialize();

            Camera = new Camera();

            //Initialize Chat Logger // qk
            Client.Chat.ChatThread.Start();

            AssemblyAnalyzer.Analyze(Assembly.GetExecutingAssembly());

            sw.Stop();
            Log.WriteLine("Initialization took {0} ms", sw.ElapsedMilliseconds);
        }

        internal static void Stop(object sender, EventArgs e)
        {
            //Terminate Chat Logger // qk // prevent crash on exit ??
            if (Client.Chat.ChatThread.IsAlive)
            {
                Client.Chat.ChatThread.Abort();
            }

            Log.WriteLine("Shutting down IceFlake");
            Events = null;
            Spellbook = null;
            Movement = null;
            DBC = null;
            ObjectManager = null;
            ESExecute = null;

            Memory.Detours.RemoveAll();
            Memory.Patches.RemoveAll();

            Memory = null;

            GC.Collect();

            //Environment.Exit(1);

        }

        internal static InProcessMemoryReader Memory { get; private set; }

        internal static ObjectManager ObjectManager { get; private set; }

        internal static WoWLocalPlayer LocalPlayer
        {
            get { return ObjectManager.LocalPlayer; }
        }

        internal static EndSceneExecute ESExecute { get; private set; }

        internal static WoWDB DBC { get; private set; }

        internal static Movement Movement { get; private set; }

        internal static SpellCollection Spellbook { get; private set; }

        internal static Camera Camera { get; private set; }

        internal static Events Events { get; private set; }
    }
}
