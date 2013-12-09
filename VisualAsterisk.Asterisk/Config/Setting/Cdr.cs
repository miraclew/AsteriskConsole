using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("cdr.conf", "Asterisk Call Detail Record engine configuration\r\n\r\nCDR is Call Detail Record, which provides logging services via a variety of pluggable backend modules. Detailed call information can be recorded to databases, files, etc.  Useful for billing, fraud prevention, compliance with Sarbanes-Oxley aka The Enron Act, QOS evaluations, and more. ")]
    public class Cdr : ConfigFileBase
    {
        public Cdr()
        {
            categories.Add("General", new List<PropertyInfo>());
            categories.Add("CSV", new List<PropertyInfo>());
            categories.Add("Radius", new List<PropertyInfo>());

            foreach (PropertyInfo pi in this.GetType().GetProperties())
            {
                object[] pros = pi.GetCustomAttributes(typeof(AstConfigPropertyAttribute), false);
                object[] cats = pi.GetCustomAttributes(typeof(CategoryAttribute), false);
                if (pros != null && pros.Length > 0)
                {
                    AstConfigPropertyAttribute pro = pros[0] as AstConfigPropertyAttribute;
                    if (pro.Exclude)
                    {
                        continue;
                    }
                }

                if (cats != null && cats.Length > 0)
                {
                    CategoryAttribute c = cats[0] as CategoryAttribute;
                    categories[c.Category].Add(pi);
                }
            }

        }

        #region [General]
        [Category("General"),Description("Define whether or not to use CDR logging.  Setting this to \"no\" will override any loading of backend CDR modules.  Default is \"yes\".")]
        bool enable;

        public bool Enable
        {
            get { return enable; }
            set { enable = value; }
        }
        bool unanswered;

        [Category("General"),Description("Define whether or not to log unanswered calls. Setting this to \"yes\" will report every attempt to ring a phone in dialing attempts, when it was not answered. For example, if you try to dial 3 extensions, and this option is \"yes\",you will get 3 CDR's, one for each phone that was rung. Default is \"no\". Some find this information horribly useless. Others find it very valuable. Note, in \"yes\" mode, you will see one CDR, with one of the call targets on one side, and the originating channel on the other, and then one CDR for each channel attempted. This may seem redundant, but cannot be helped.")]
        [DisplayName("unanswered")]
        public bool Unanswered
        {
            get { return unanswered; }
            set { unanswered = value; }
        }

        /*; Define the CDR batch mode, where instead of posting the CDR at the end of
; every call, the data will be stored in a buffer to help alleviate load on the
; asterisk server.  Default is "no".
;
; WARNING WARNING WARNING
; Use of batch mode may result in data loss after unsafe asterisk termination
; ie. software crash, power failure, kill -9, etc.
; WARNING WARNING WARNING
*/
        bool batch;

        [Category("General")]
        public bool Batch
        {
            get { return batch; }
            set { batch = value; }
        }

        /*; Define the maximum Number of CDRs to accumulate in the buffer before posting
; them to the backend engines.  'batch' must be set to 'yes'.  Default is 100.
*/
        int size;
        [Category("General")]
        [DefaultValue(100)]
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /*; Define the maximum time to accumulate CDRs in the buffer before posting them
; to the backend engines.  If this time Limit is reached, then it will post the
; records, regardless of the Value defined for 'size'.  'batch' must be set to
; 'yes'.  Note that time is in seconds.  Default is 300 (5 minutes).
*/
        int time;

        [Category("General")]
        [DefaultValue(300)]
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        /*; The CDR engine uses the internal asterisk scheduler to determine when to post
; records.  Posting can either occur inside the scheduler thread, or a new
; thread can be spawned for the submission of every batch.  For small batches,
; it might be acceptable to just use the scheduler thread, so set this to "yes".
; For large batches, say anything over size=10, a new thread is recommended, so
; set this to "no".  Default is "no".
*/
        bool scheduleronly;

        [Category("General")]
        [DefaultValue(false)]
        public bool Scheduleronly
        {
            get { return scheduleronly; }
            set { scheduleronly = value; }
        }

        /*; When shutting down asterisk, you can block until the CDRs are submitted.  If
; you don't, then data will likely be lost.  You can always check the size of
; the CDR batch buffer with the CLI "cdr status" command.  To enable blocking on
; submission of CDR data during asterisk shutdown, set this to "yes".  Default
; is "yes".
*/
        bool safeshutdown;
        
        [Category("General")]
        [DefaultValue(true)]
        public bool Safeshutdown
        {
            get { return safeshutdown; }
            set { safeshutdown = value; }
        }

        /*; Normally, CDR's are not closed out until after all extensions are finished
; executing.  By enabling this option, the CDR will be ended before executing
; the "h" Extension1 so that CDR values such as "end" and "billsec" may be
; retrieved inside of of this Extension1.
*/
        bool endbeforehexten;

        [Category("General")]
        public bool Endbeforehexten
        {
            get { return endbeforehexten; }
            set { endbeforehexten = value; }
        }
        #endregion

        #region [CSV]
        bool usegmtime;

        [Category("CSV")]
        [DefaultValue(true)]
        [Description("log date/time in GMT. Default is \"no\"")]
        public bool Usegmtime
        {
            get { return usegmtime; }
            set { usegmtime = value; }
        }

        bool loguniqueid;

        [Category("CSV")]
        [DefaultValue(false)]
        [Description("log uniqueid.  Default is \"no\"")]
        public bool Loguniqueid
        {
            get { return loguniqueid; }
            set { loguniqueid = value; }
        }

        bool loguserfield;

        [Category("CSV")]
        [DefaultValue(false)]
        [Description("log user field.  Default is \"no\"")]
        public bool Loguserfield
        {
            get { return loguserfield; }
            set { loguserfield = value; }
        }

        #endregion

        #region [radius]
        // TODO: 3 fields is same as csv, what to do ?

        /*; Set this to the Location of the radiusclient-ng configuration file
; The default is /etc/radiusclient-ng/radiusclient.conf
*/
        string radiuscfg; // TODO: this may be changed, it's defined as an object

        [Category("Radius")]
        [DefaultValue("/etc/radiusclient-ng/radiusclient.conf")]
        public string Radiuscfg
        {
            get { return radiuscfg; }
            set { radiuscfg = value; }
        }
        #endregion

        protected override void LoadCategory(AstCategory cat)
        {
            if (cat.Name.Equals("csv"))
            {
                setProperties(this, cat);
            }
            else if (cat.Name.Equals("radius"))
            {
                setProperties(this, cat);
            }
            else
            {
                Trace.TraceError("upsupport category {0}", cat.Name);
            }
        }

    }
}
