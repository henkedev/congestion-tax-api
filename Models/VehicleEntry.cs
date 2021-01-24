using System;

namespace CongestiontaxApi.Models
{
    public class VehicleEntry
    {
        public long Id { get; set; }

        public DateTime LastPassage { get; set; }

        public int Fee { get; set; }
    }
}