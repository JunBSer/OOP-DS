using ClassViewer.Internal.Models;

namespace ClassViewer.Internal
{
    public class TransportList
    {
        private List<Transport> Transports;

        public  TransportList()
        {
            Transports = new List<Transport>();
        }

        public void AddTransport(Transport transport)
        {
            Transports.Add(transport);
        }

        public void RemoveTransport(Transport transport)
        {
            Transports.Remove(transport);
        }

        public List<Transport> GetTransports()
        {
            return Transports;
        }
        
        
        
    }
}