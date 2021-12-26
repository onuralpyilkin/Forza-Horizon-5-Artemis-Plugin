using Artemis.Core;
using Artemis.Core.Modules;
using ForzaHorizon5.DataModels;
using System.Collections.Generic;
using ForzaHorizon5.Telemetry;
using System.Net;
using System.Threading.Tasks;
using System;

namespace ForzaHorizon5
{
    // The core of your module. Hover over the method names to see a description.
    [PluginFeature(Name = "ForzaHorizon5", Icon = "Racing-Helmet")]
    public class ForzaHorizon5Module : Module<ForzaDataModel>
    {
        // This is useful if your module targets a specific game or application.
        // If this list is not null and not empty, the data of your module is only available to profiles specifically targeting it
        public static UdpStreamListener listener;
        public static IPAddress address = IPAddress.Parse("127.0.0.1");
        public int port = 8001;
        public static ForzaDataReader dataReader;
        public static ForzaDataModel model;
        public override List<IModuleActivationRequirement> ActivationRequirements => null;

        // This is the beginning of your plugin feature's life cycle. Use this instead of a constructor.
        public override void Enable()
        {
            // Anything you'd otherwise do in a constructor is done here
            ActivationRequirementMode = ActivationRequirementType.Any;
            listener = new UdpStreamListener();
            dataReader = new ForzaDataReader();
            model = new ForzaDataModel();
            listener.Initialize(address, port);
            listener.StartReceiveLoop();
        }

        // This is the end of your plugin feature's life cycle.
        public override void Disable()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
            listener.Close();
            listener.Dispose();
        }

        public override void Update(double deltaTime)
        {
            // This is where you can add your update logic
            DataModel.Sled = model.Sled;
            DataModel.Dash = model.Dash;
        }
    }
}