using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Test.UI
{
    abstract class AbstractUITestCase
    {
        /// <summary>
        /// The oject under test
        /// </summary>
        protected object target;

        public object Target
        {
            get { return target; }
        }

        /// <summary>
        /// Test Case Name
        /// </summary>
        public virtual string Name
        {
            get { return target.GetType().Name; }
        }

        /// <summary>
        /// Description of this test case
        /// </summary>
        public virtual string Description
        {
            get { return "Test " + Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Namespace
        {
            get 
            {
                string str = target.GetType().FullName;
                return str.Substring(0, str.LastIndexOf('.'));
            }
        }

        public abstract void Run();
    }
}
