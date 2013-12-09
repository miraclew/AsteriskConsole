using System;
using System.Collections.Generic;
using System.Text;

namespace AstFileEditor
{
    class Class1
    {
        public const string manager_conf = @"
;
; AMI - The Asterisk Manager Interface
; 
; Third party application call management support and PBX event supervision
;
; This configuration file is read every time someone logs in
;
;
; ---------------------------- SECURITY NOTE -------------------------------
; Note that you should not enable the AMI on a public IP address. If needed,
; block this TCP port with iptables (or another FW software) and reach it
; with IPsec, SSH, or SSL vpn tunnel.  You can also make the manager 
; interface available over http if Asterisk's http server is enabled in
;
[general]
displaysystemname = yes
enabled = yes
webenabled = yes
port = 5038

;httptimeout = 60
; a) httptimeout sets the Max-Age of the http cookie
; b) httptimeout is the amount of time the webserver waits 
;    on a action=waitevent request (actually its httptimeout-10)
; c) httptimeout is also the amount of time the webserver keeps 
;    a http session alive after completing a successful action

bindaddr = 0.0.0.0
;displayconnects = yes
;
; Add a Unix epoch timestamp to events (not action responses)
;
;timestampevents = yes

[admin]
secret = abc123
;deny=0.0.0.0/0.0.0.0
permit=192.168.0.0/255.255.0.0
;
; If the device connected via this user accepts input slowly,
; the timeout for writes to it can be increased to keep it
; from being disconnected (value is in milliseconds)
;
; writetimeout = 100
;
; Authorization for various classes 
read = system,call,log,verbose,command,agent,user,config
write = system,call,log,verbose,command,agent,user,config
";

        public const string users_conf = @";!
;! Automatically generated configuration file
;! Filename: users.conf (/etc/asterisk/users.conf)
;! Generator: Manager
;! Creation Date: Sat Dec  6 17:49:46 2008
;!
[general]
;
; Full name of a user
;
fullname = New User
userbase = 6000
;
; Create voicemail mailbox and use use macro-stdexten
;
hasvoicemail = yes
;
; Set voicemail mailbox 6000 password to 1234
;
vmsecret = 1234
;
; Create SIP Peer
;
hassip = yes
;
; Create IAX friend
;
hasiax = yes
;
; Create H.323 friend
;
;hash323 = yes
;
; Create manager entry
;
hasmanager = no
;
; Set permissions for manager entry (see manager.conf.sample for documentation)
; (defaults to *all* permissions)
;managerread = system,call,log,verbose,command,agent,user,config
;managerwrite = system,call,log,verbose,command,agent,user,config
;
; Remaining options are not specific to users.conf entries but are general.
;
callwaiting = yes
threewaycalling = yes
callwaitingcallerid = yes
transfer = yes
canpark = yes
cancallforward = yes
callreturn = yes
callgroup = 1
pickupgroup = 1
localextenlength = 0
allow_aliasextns = no
allow_an_extns = yes
hasagent = no
hasdirectory = no
operatorExtension = 6001
login_exten = 6200
login_callback_exten = 6201

[6001]
callwaiting = yes
fullname = test1
hasagent = yes
hasdirectory = no
hasiax = yes
hasmanager = no
hassip = yes
hasvoicemail = yes
deletevoicemail = no
host = dynamic
mailbox = 6001
secret = 6001
threewaycalling = yes
vmsecret = 1234
registeriax = yes
registersip = yes
autoprov = no
canreinvite = no
nat = no
dtmfmode = rfc2833
disallow = all
allow = all
signalling = fxo_ks

[6002]
callwaiting = yes
fullname = test2
hasagent = yes
hasdirectory = no
hasiax = yes
hasmanager = no
hassip = yes
hasvoicemail = yes
deletevoicemail = no
host = dynamic
mailbox = 6002
secret = 6002
threewaycalling = yes
vmsecret = 1234
registeriax = yes
registersip = yes
autoprov = no
canreinvite = no
nat = no
dtmfmode = rfc2833
disallow = all
allow = all
signalling = fxo_ks

[6003]
callwaiting = yes
fullname = test3
hasagent = yes
hasdirectory = no
hasiax = yes
hasmanager = no
hassip = yes
hasvoicemail = yes
deletevoicemail = no
host = dynamic
mailbox = 6003
secret = 6003
threewaycalling = yes
vmsecret = 1234
registeriax = yes
registersip = yes
autoprov = no
canreinvite = no
nat = no
dtmfmode = rfc2833
disallow = all
allow = all
signalling = fxo_ks

[trunk_1]
allow = all
context = DID_trunk_1
dialformat = ${EXTEN:1}
canreinvite = no
hasexten = no
hasiax = yes
hassip = no
host = 192.168.88.128
port = 4569
registeriax = yes
registersip = no
secret = 123
trunkname = Custom - iax-trunk-1
trunkstyle = customvoip
username = iax1

[6004]
callwaiting = yes
fullname = test4
hasagent = no
hasdirectory = no
hasiax = yes
hasmanager = no
hassip = yes
hasvoicemail = yes
deletevoicemail = no
host = dynamic
mailbox = 6004
threewaycalling = yes
vmsecret = 1234
registeriax = yes
registersip = yes
autoprov = no
canreinvite = no
nat = no
dtmfmode = rfc2833
disallow = all
allow = all
signalling = fxo_ks
secret = 6004

[6005]
callwaiting = yes
context = numberplan-custom-1
fullname = test5
hasagent = no
hasdirectory = no
hasiax = yes
hasmanager = no
hassip = yes
hasvoicemail = yes
deletevoicemail = no
host = dynamic
mailbox = 6005
secret = 6005
threewaycalling = yes
vmsecret = 1234
registeriax = yes
registersip = yes
autoprov = no
canreinvite = no
nat = no
dtmfmode = rfc2833
disallow = all
allow = all
signalling = fxo_ks
";
        public const string extensions_conf = @";!
;! Automatically generated configuration file
;! Filename: extensions.conf (/etc/asterisk/extensions.conf)
;! Generator: Manager
;! Creation Date: Fri Dec  5 22:29:15 2008
;!
[general]
;
; If static is set to no, or omitted, then the pbx_config will rewrite
; this file when extensions are modified.  Remember that all comments
; made in the file will be lost when that happens. 
;
; XXX Not yet implemented XXX
;
static = yes
;
; if static=yes and writeprotect=no, you can save dialplan by
;
writeprotect = no
;
; If autofallthrough is set, then if an extension runs out of
; things to do, it will terminate the call with BUSY, CONGESTION
; or HANGUP depending on Asterisk's best guess. This is the default.
;
; If autofallthrough is not set, then if an extension runs out of 
; things to do, Asterisk will wait for a new extension to be dialed 
; (this is the original behavior of Asterisk 1.0 and earlier).
;
;autofallthrough=no
;
; If clearglobalvars is set, global variables will be cleared 
; and reparsed on an extensions reload, or Asterisk reload.
;
; If clearglobalvars is not set, then global variables will persist
; through reloads, and even if deleted from the extensions.conf or
; one of its included files, will remain set to the previous value.
;
; NOTE: A complication sets in, if you put your global variables into
; the AEL file, instead of the extensions.conf file. With clearglobalvars
;
clearglobalvars = no
;
; If priorityjumping is set to 'yes', then applications that support
; 'jumping' to a different priority based on the result of their operations
; will do so (this is backwards compatible behavior with pre-1.2 releases
; of Asterisk). Individual applications can also be requested to do this
; by passing a 'j' option in their arguments.
;
;priorityjumping=yes
;
; User context is where entries from users.conf are registered.  The
; default value is 'default'
;
;userscontext=default
;
; You can include other config files, use the #include command
; in all asterisk configuration files.
; in the dialplan with the GLOBAL dialplan function:
; ${GLOBAL(VARIABLE)}
; ${${GLOBAL(VARIABLE)}} or ${text${GLOBAL(VARIABLE)}} or any hybrid
; Unix/Linux environmental variables can be reached with the ENV dialplan
; function: ${ENV(VARIABLE)}
;
[globals]
CONSOLE = Console/dsp  ; Console interface for demo
;CONSOLE=Zap/1
;CONSOLE=Phone/phone0
IAXINFO = guest  ; IAXtel username/password
;IAXINFO=myuser:mypass
TRUNK = Zap/G2  ; Trunk interface
;
; Note the 'G2' in the TRUNK variable above. It specifies which group (defined
; in zapata.conf) to dial, i.e. group 2, and how to choose a channel to use in
; the specified group. The four possible options are:
;
; g: select the lowest-numbered non-busy Zap channel
;    (aka. ascending sequential hunt group).
; G: select the highest-numbered non-busy Zap channel
;    (aka. descending sequential hunt group).
; r: use a round-robin search, starting at the next highest channel than last
;    time (aka. ascending rotary hunt group).
; R: use a round-robin search, starting at the next lowest channel than last
;    time (aka. descending rotary hunt group).
;
TRUNKMSD = 1  ; MSD digits to strip (usually 1 or 0)
trunk_1 = IAX2/trunk_1
include => dundi-e164-canonical
include => dundi-e164-customers
include => dundi-e164-via-pstn

[dundi-e164-switch]
;
; Just a wrapper for the switch
;
switch => DUNDi/e164

exten => s,1,Goto(${ARG1},1)
include => dundi-e164-lookup

[iaxprovider]
;switch => IAX2/user:[key]@myserver/mycontext
[trunkint]
;
; International long distance through trunk
;
exten => _9011.,1,Macro(dundi-e164,${EXTEN:4})
exten => _9011.,n,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})

[trunkld]
;
; Long distance context accessed through trunk
;
exten => _91NXXNXXXXXX,1,Macro(dundi-e164,${EXTEN:1})
exten => _91NXXNXXXXXX,n,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})

[trunklocal]
;
; Local seven-digit dialing accessed through trunk interface
;
exten => _9NXXXXXX,1,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})

[trunktollfree]
;
; Long distance context accessed through trunk interface
;
exten => _91800NXXXXXX,1,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})
exten => _91888NXXXXXX,1,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})
exten => _91877NXXXXXX,1,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})
exten => _91866NXXXXXX,1,Dial(${GLOBAL(TRUNK)}/${EXTEN:${GLOBAL(TRUNKMSD)}})

[international]
;
; Master context for international long distance
;
ignorepat => 9
include => longdistance
include => trunkint

[longdistance]
;
; Master context for long distance
;
ignorepat => 9
include => local
include => trunkld

[local]
;
; Master context for local, toll-free, and iaxtel calls only
;
ignorepat => 9
include => default
include => trunklocal
include => iaxtel700
include => trunktollfree
include => iaxprovider
;Include parkedcalls (or the context you define in features conf)
;to enable call parking.
include => parkedcalls

[macro-stdexten];
;
; Standard extension macro:
;   ${ARG1} - Extension  (we could have used ${MACRO_EXTEN} here as well
;   ${ARG2} - Device(s) to ring
;
exten => s,1,Dial(${ARG2},20)  ; Ring the interface, 20 seconds maximum
exten => s,2,Goto(s-${DIALSTATUS},1)  ; Jump based on status (NOANSWER,BUSY,CHANUNAVAIL,CONGESTION,ANSWER)
exten => s-NOANSWER,1,Voicemail(${ARG1},u)  ; If unavailable, send to voicemail w/ unavail announce
exten => s-NOANSWER,2,Goto(default,s,1)  ; If they press #, return to start
exten => s-BUSY,1,Voicemail(${ARG1},b)  ; If busy, send to voicemail w/ busy announce
exten => s-BUSY,2,Goto(default,s,1)  ; If they press #, return to start
exten => _s-.,1,Goto(s-NOANSWER,1)  ; Treat anything else as no answer
exten => a,1,VoicemailMain(${ARG1})  ; If they press *, send the user into VoicemailMain

[macro-stdPrivacyexten];
;
; Standard extension macro:
;   ${ARG1} - Extension  (we could have used ${MACRO_EXTEN} here as well
;   ${ARG2} - Device(s) to ring
;   ${ARG3} - Optional DONTCALL context name to jump to (assumes the s,1 extension-priority)
;   ${ARG4} - Optional TORTURE context name to jump to (assumes the s,1 extension-priority)`
;
exten => s,1,Dial(${ARG2},20|p)  ; Ring the interface, 20 seconds maximum, call screening 
; option (or use P for databased call screening)
exten => s,2,Goto(s-${DIALSTATUS},1)  ; Jump based on status (NOANSWER,BUSY,CHANUNAVAIL,CONGESTION,ANSWER)
exten => s-NOANSWER,1,Voicemail(${ARG1},u)  ; If unavailable, send to voicemail w/ unavail announce
exten => s-NOANSWER,2,Goto(default,s,1)  ; If they press #, return to start
exten => s-BUSY,1,Voicemail(${ARG1},b)  ; If busy, send to voicemail w/ busy announce
exten => s-BUSY,2,Goto(default,s,1)  ; If they press #, return to start
exten => s-DONTCALL,1,Goto(${ARG3},s,1)  
exten => s-TORTURE,1,Goto(${ARG4},s,1)  ; Callee chose to send this call to a telemarketer torture script.
exten => _s-.,1,Goto(s-NOANSWER,1)  ; Treat anything else as no answer
exten => a,1,VoicemailMain(${ARG1})  ; If they press *, send the user into VoicemailMain

[macro-page];
;
; Paging macro:
;
;       Check to see if SIP device is in use and DO NOT PAGE if they are
;
;   ${ARG1} - Device to page
exten => s,1,ChanIsAvail(${ARG1}|js)  ; j is for Jump and s is for ANY call
exten => s,n,SIPAddHeader(Call-Info: Answer-After=0)  ; This is for the Grandstream, Snoms, and Others
exten => s,n,NoOp()  ; Add others here and Post on the Wiki!!!!
exten => s,n,Dial(${ARG1}||)
exten => s,n(fail),Hangup

[demo]
;
; We start with what to do when a call first comes in.
;
exten => s,1,Wait(1)  ; Wait a second, just for fun
exten => s,n,Answer  ; Answer the line
exten => s,n,Set(TIMEOUT(digit)=5)  ; Set Digit Timeout to 5 seconds
exten => s,n,Set(TIMEOUT(response)=10)  ; Set Response Timeout to 10 seconds
exten => s,n(restart),BackGround(demo-congrats)  ; Play a congratulatory message
exten => s,n(instruct),BackGround(demo-instruct)  ; Play some instructions
exten => s,n,WaitExten  ; Wait for an extension to be dialed.
exten => 2,1,BackGround(demo-moreinfo)  ; Give some more information.
exten => 2,n,Goto(s,instruct)
exten => 3,1,Set(LANGUAGE()=fr)  ; Set language to french
exten => 3,n,Goto(s,restart)  ; Start with the congratulations
exten => 1000,1,Goto(default,s,1)
;
; We also create an example user, 1234, who is on the console and has
; voicemail, etc.
;
exten => 1234,1,Playback(transfer,skip)  ;  
; (but skip if channel is not up)
exten => 1234,n,Macro(stdexten,1234,${GLOBAL(CONSOLE)})
exten => 1235,1,Voicemail(1234,u)  ; Right to voicemail
exten => 1236,1,Dial(Console/dsp)  ; Ring forever
exten => 1236,n,Voicemail(1234,b)  ; Unless busy
;
; # for when they're done with the demo
;
exten => #,1,Playback(demo-thanks)  
exten => #,n,Hangup  ; Hang them up.
;
exten => t,1,Goto(#,1)  ; If they take too long, give up
exten => i,1,Playback(invalid)  ; 
;
; Create an extension, 500, for dialing the
; Asterisk demo.
;
exten => 500,1,Playback(demo-abouttotry)  ; Let them know what's going on
exten => 500,n,Dial(IAX2/guest@pbx.digium.com/s@default)  ; Call the Asterisk demo
exten => 500,n,Playback(demo-nogo)  ; Couldn't connect to the demo site
exten => 500,n,Goto(s,6)  ; Return to the start over message.
;
; Create an extension, 600, for evaluating echo latency.
;
exten => 600,1,Playback(demo-echotest)  ; Let them know what's going on
exten => 600,n,Echo  ; Do the echo test
exten => 600,n,Playback(demo-echodone)  ; Let them know it's over
exten => 600,n,Goto(s,6)  ; Start over
;
;	You can use the Macro Page to intercom a individual user
exten => 76245,1,Macro(page,SIP/Grandstream1)
; or if your peernames are the same as extensions
exten => _7XXX,1,Macro(page,SIP/${EXTEN})
;
;
; System Wide Page at extension 7999
;
exten => 7999,1,Set(TIMEOUT(absolute)=60)
exten => 7999,2,Page(Local/Grandstream1@page&Local/Xlite1@page&Local/1234@page/n|d)
; Give voicemail at extension 8500
;
exten => 8500,1,VoicemailMain
exten => 8500,n,Goto(s,6)
;
; Here's what a phone entry would look like (IXJ for example)
;
;exten => 1265,1,Dial(Phone/phone0,15)
;exten => 1265,n,Goto(s,5)
;
;	The page context calls up the page macro that sets variables needed for auto-answer
;	It is in is own context to make calling it from the Page() application as simple as 
;	Local/{peername}@page
;
[page]
exten => _X.,1,Macro(page,SIP/${EXTEN})
;[mainmenu]
;
;
;exten => s,1,Answer
;exten => s,n,Background(thanks)		
;exten => s,n,WaitExten
;exten => 1,1,Goto(submenu,s,1)
;exten => 2,1,Hangup
;include => default
;
;[submenu]
;exten => s,1,Ringing					; Make them comfortable with 2 seconds of ringback
;exten => s,n,Wait,2
;exten => s,n,WaitExten
;exten => 1,1,Goto(default,steve,1)
;exten => 2,1,Goto(default,mark,2)
[default]
;
; By default we include the demo.  In a production system, you 
; probably don't want to have the demo there.
;
include => demo
exten => 7001,1,MeetMe(${EXTEN}|MI)
exten = 8000,1,Queue(${EXTEN})
exten => 9000,1,VoiceMailMain
exten => 7002,1,MeetMe(${EXTEN}|MI)
exten = 6100,1,Goto(voicemenu-custom-1|s|1)
exten = o,1,Goto(default,6001,1)
exten = 6200,1,agentlogin()
exten = 6201,1,agentcallbacklogin()

[macro-trunkdial]
exten = s,n,Dial(${ARG1})
exten = s,n,Goto(s-${DIALSTATUS},1)
exten = s-NOANSWER,1,Hangup
exten = s-BUSY,1,Hangup
exten = _s-.,1,NoOp

[asterisk_guitools]
exten = executecommand,1,System(${command})
exten = executecommand,n,Hangup()
exten = record_vmenu,1,Answer
exten = record_vmenu,n,Playback(vm-intro)
exten = record_vmenu,n,Record(${var1})
exten = record_vmenu,n,Playback(vm-saved)
exten = record_vmenu,n,Playback(vm-goodbye)
exten = record_vmenu,n,Hangup
exten = play_file,1,Answer
exten = play_file,n,Playback(${var1})
exten = play_file,n,Hangup

[DID_trunk_1]
include = default

[ringroups-custom-1]
gui_ring_groupname = ringgroup1
exten = s,1,NoOp(RINGGROUP)
exten = s,n,Dial(SIP/6001&SIP/6002,20)
exten = s,n,Hangup

[voicemenu-custom-1]
comment = voicemenuMain
alias_exten = 6100
exten = s,1,Answer
exten = 0,1,Goto(default|6001|1)
exten = 1,1,Goto(default|6002|1)
exten = s,2,Background(agent-incorrect)

[DialPlan1]
include = default
parked = no

[numberplan-custom-1]
plancomment = Default DialPlan
include = default
include = parkedcalls

[numberplan-custom-2]
include = default
plancomment = DialPlan2
parked = no
";
    }
}
