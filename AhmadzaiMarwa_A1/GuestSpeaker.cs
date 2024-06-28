using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadzaiMarwa_A1
{
    public class GuestSpeaker : IPayable
    {
        public string SpeakerName { get; set; }
        public string SpeakerEmail { get; set; }
        public double Honorarium { get; set; }

        public GuestSpeaker(string speakerName, string speakerEmail, double honorarium)
        {
            SpeakerName = speakerName;
            SpeakerEmail = speakerEmail;
            Honorarium = honorarium;
        }

        public double Payment()
        {
            return Honorarium; // One-time payment
        }
    }
}

