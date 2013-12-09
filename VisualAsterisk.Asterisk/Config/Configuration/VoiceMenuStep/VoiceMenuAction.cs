using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace VisualAsterisk.Asterisk.Config.Configuration.VoiceMenuStep
{
    public abstract class VoiceMenuAction
    {
        public static VoiceMenuAction Parse(string[] application)
        {
            if (application[0] == "Authenticate")
            {
                return new Authenticate(application[1]);
            }
            else if (application[0] == "Answer")
            {
                return new Answer();
            }
            else if (application[0] == "Background")
            {
                return new Background(application[1]);
            }
            else if (application[0] == "Busy")
            {
                return new Busy(int.Parse(application[1]));
            }
            else if (application[0] == "Congestion")
            {
                if (application.Length == 2)
                {
                    return new Congestion(int.Parse(application[1]));
                }
                else
                    return new Congestion();
            }
            else if (application[0] == "Directory")
            {
                return new Directory();
            }
            else if (application[0] == "DISA")
            {
                return new DISA(application[1],application[2]);
            }
            else if (application[0] == "Hangup")
            {
                return new Hangup();
            }
            else if (application[0] == "Goto")
            {
                return Goto.Parse(application);
                //if (application[1].StartsWith("voicemenu-custom-"))
                //{
                //    return new GotoMenu();
                //}
                //else if (application[1].StartsWith("ringroups-custom-"))
                //{
                //    return new DialRingGroup(new RingGroup());
                //}
                //else if (application[1].StartsWith("default"))
                //{
                //    return new GotoExtension(application[2]);
                //}
                //else 
                //{
                //    Trace.TraceError(string.Format("AbstractVoiceMenuStep.Parse Unkown application arg {0}", application[1]));
                //    return null;
                //}
            }
            else if (application[0] == "Playback")
            {
                return new Playback(application[1]);
            }
            else if (application[0] == "SayDigits")
            {
                return new SayDigits(application[1]);
            }
            else if (application[0] == "Set")
            {
                if (application[1].StartsWith("TIMEOUT(digit)"))
                {
                    return new DigitsTimeout(int.Parse(application[1].Substring(application[1].IndexOf('=')+1)));
                }
                else if (application[1].StartsWith("TIMEOUT(response)"))
                {
                    return new ResponseTimeout(int.Parse(application[1].Substring(application[1].IndexOf('=') + 1)));
                }
                else if (application[1].StartsWith("CHANNEL(language)"))
                {
                    return new SetLanguage(application[1].Substring(application[1].IndexOf('=') + 1));                    
                }
                else
                {
                    Trace.TraceError(string.Format("AbstractVoiceMenuStep.Parse Unkown application arg {0}", application[1]));
                    return null;
                }
            }
            else if (application[0] == "Voicemail")
            {
                return new VoiceMail(application);
            }
            else if (application[0] == "VoiceMailMain")
            {
                return new CheckOwnVoiceMail();
            }
            else if (application[0] == "Wait")
            {
                return new Wait(int.Parse(application[1]));
            }
            else if (application[0] == "WaitExten")
            {
                return new WaitExten(int.Parse(application[1]));
            }
            else if (application[0] == "Macro")
            {
                return new Macro(application[1]);
            }
            else if (application[0] == "Ringing")
            {
                return new Ringing();
            }
            else if (application[0] == "SetMusicOnHold")
            {
                return new SetMusicOnHold(application[1]);
            }
            else if (application[0] == "SayAlpha")
            {
                return new SayAlpha(application[1]);
            }
            else if (application[0] == "SayNumber")
            {
                return new SayNumber(application[1]);
            }
            else if (application[0] == "AGI")
            {
                return new Agi(application[1]);
            }
            else if (application[0] == "UserEvent")
            {
                return new UserEvent(application[1],application[2]);
            }
            else
            {
                Trace.TraceError(string.Format("VoiceMenuAction.Parse Unkown application {0}",application[0]));
                return null;
            }
        }

        private int priority;
        protected string [] applicationString;

        public string[] ApplicationString
        {
            get { return applicationString; }
        }

        /// <summary>
        /// Priority in the exten =>
        /// </summary>
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        /// <summary>
        /// Application 
        /// </summary>
        public virtual string Name
        {
            get { return applicationString[0]; }
        }

        public virtual string HelpText
        {
            get { return ""; }
        }

        public virtual string DisplayText
        {
            get { return ToString(); }
        }

        public virtual int ParameterCount
        {
            get { return applicationString.Length - 1; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            if (applicationString.Length > 1)
            {
                sb.Append("(");
                for (int i = 1; i < applicationString.Length; i++)
                {
                    sb.Append(applicationString[i]);
                    if (i < applicationString.Length -1)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append(")");
            }
            return sb.ToString();
        }
    }
}
