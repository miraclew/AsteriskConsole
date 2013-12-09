using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;

namespace VisualAsterisk.Asterisk.Dialplan.Application
{
    public class AddQueueMember : ApplicationBase
    {
        public AddQueueMember()
        {

        }
        public AddQueueMember(string queueName)
        {
            m_QueueName = queueName;
        }

        //[AutoCompletion(
        public AddQueueMember(string queueName, string _interface)
        {
            m_QueueName = queueName;
            m_Interface = _interface;
        }

        string m_QueueName;

        public string QueueName
        {
            get { return m_QueueName; }
            set { 
                m_QueueName = value;
                Queues qs = base.ConfigManager[ConfigFileEnum.Queues] as Queues;
                foreach (Queue var in qs.QueueList)
                {
                    if (var.Name == m_QueueName)
                    {
                        if (AutoCompletionDataDictionary.ContainsKey("memberName"))
                        {
                            AutoCompletionDataDictionary.Remove("memberName");
                        }
                        AutoCompletionDataDictionary["memberName"] = var.Members;

                        break;
                    }                    
                }
            }
        }
        string m_Interface;
        bool m_Penalty;
        string m_Option;
        string m_MemeberName;

        public override string[] AutoCompleteDataList
        {
            get
            {
                string[] data = { "queueName", "interface", "penalty","option", "memberName" };
                return data;
            }
        }

        public override void SetParameterValueByIndex(int index, string value)
        {
            base.SetParameterValueByIndex(index, value);
            switch (index)
            {
                case 0:
                    QueueName = value;
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }

        public override IConfig ConfigManager
        {
            set
            {
                base.ConfigManager = value;
                Queues qs = base.ConfigManager[ConfigFileEnum.Queues] as Queues;
                
                List<string> data = new List<string>();
                foreach (Queue var in qs.QueueList)
                {
                    data.Add(var.Name);
                }
                if (AutoCompletionDataDictionary.ContainsKey("queueName"))
                {
                    AutoCompletionDataDictionary.Remove("queueName");
                }
                AutoCompletionDataDictionary["queueName"] = data;
            }
        }
    }
}
