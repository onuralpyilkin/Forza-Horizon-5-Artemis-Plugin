using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ForzaHorizon5.Telemetry
{
    public class ForzaDataListener : UdpStreamListener, IObservable<ForzaStruct>
    {
        private ICollection<IObserver<ForzaStruct>> observers;
        public ForzaDataReader reader;
        private ForzaStruct? lastData;

        public ForzaDataListener(int port, IPAddress serverIpAddress) : base(port, serverIpAddress)
        {
            observers = new List<IObserver<ForzaStruct>>();
            reader = new ForzaDataReader();

            lastData = null;
        }

        public IDisposable Subscribe(IObserver<ForzaStruct> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);

                if (lastData != null)
                {
                    observer.OnNext(lastData.Value);
                }
            }
            return new ForzaDataUnsubscriber(observers, observer);
        }

        protected override void NotifyData(byte[] data)
        {
            base.NotifyData(data);

            ForzaStruct forzaData;

            try
            {
                forzaData = reader.Read(data);

                // success reading
                NotifyData(forzaData);
            }
            catch (Exception ex)
            {
                // read exception: notified to observers
                NotifyError(new Exception("An error occured while trying to read data", ex));
            }
        }

        protected void NotifyData(ForzaStruct data)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(data);
            }
        }

        protected void NotifyError(Exception error)
		{
			foreach (var observer in observers)
			{
				observer.OnError(error);
			}
		}

        protected override void NotifyCompletion()
        {
            base.NotifyCompletion();

            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
        }
    }
}
