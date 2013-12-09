using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    [AstConfigFile("modules.conf", "Module Loader configuration file")]
    class Modules : ConfigFileBase
    {
        //[AstConfigVariable("modules","")]
        bool autoload;
        /* 
         * ; Any modules that need to be loaded before the Asterisk core has been
; initialized (just after the logger has been initialized) can be loaded
; using 'preload'. This will frequently be needed if you wish to map all
; module configuration files into Realtime storage, since the Realtime
; driver will need to be loaded before the modules using those configuration
; files are initialized.
         * */
        List<string> preload;
        List<string> noload;
        List<string> load;
    }
}
