using System;

namespace Razor.Networking.Http
{
	/// <summary>
	/// ; // [RFC2045,RFC2046] specifies that Content Types, Content Subtypes, Character Sets, Access Types, and conversion values for MIME mail will be assigned and listed by the IANA.
	///	The following is the list of Directories of Content Types and Subtypes.
	/// </summary>
	public class MIME
	{
//		public class application
//		{
//			public const string X = @"activemessage"     ; // [Shapiro]
//			public const string X = @"andrew-inset"   ; // [Borenstein]
//			public const string X = @"applefile"   ; // [Faltstrom]
//			public const string X = @"atomicmail"  ; // [Borenstein]
//			public const string X = @"batch-SMTP"  ; // [RFC2442]
//			public const string X = @"beep+xml"    ; // [RFC3080]
//			public const string X = @"cals-1840"   ; // [RFC1895]
//			public const string X = @"cnrp+xml"    ; // [RFCCNRP]
//			public const string X = @"commonground"   ; // [Glazer]
//			public const string X = @"cpl+xml"  ; // [RFC-ietf-iptel-cpl-09.txt]
//			public const string X = @"cybercash"   ; // [Eastlake]
//			public const string X = @"dca-rft"  ; // [Campbell]
//			public const string X = @"dec-dx"   ; // [Campbell]
//			public const string X = @"dicom"    ; // [RFC3240]
//			public const string X = @"dns"   ; // [RFC-josefsson-mime-dns-02.txt]
//			public const string X = @"dvcs" ; // [RFC3029]
//			public const string X = @"EDI-Consent"    ; // [RFC1767]
//			public const string X = @"EDIFACT"  ; // [RFC1767]
//			public const string X = @"EDI-X12"  ; // [RFC1767]
//			public const string X = @"epp+xml"  ; // [RFC3730]
//			public const string X = @"eshop"    ; // [Katz]
//			public const string X = @"fits"  ; // [RFC-allen-fitsmime-00.txt]
//			public const string X = @"font-tdpfr"  ; // [RFC3073]
//			public const string X = @"http"  ; // [RFC2616]
//			public const string X = @"hyperstudio"    ; // [Domino]
//			public const string X = @"iges"  ; // [Parks]
//			public const string X = @"im-iscomposing+xml"   ; // [RFC-ietf-simple-iscomposing-03.txt]
//			public const string X = @"index"    ; // [RFC2652]
//			public const string X = @"index.cmd"   ; // [RFC2652]
//			public const string X = @"index.obj"   ; // [RFC2652]
//			public const string X = @"index.response"    ; // [RFC2652]
//			public const string X = @"index.vnd"   ; // [RFC2652]
//			public const string X = @"iotp"  ; // [RFC2935]
//			public const string X = @"ipp"   ; // [RFC2910]
//			public const string X = @"isup"  ; // [RFC3204]
//			public const string X = @"mac-binhex40"   ; // [Faltstrom]
//			public const string X = @"macwriteii"  ; // [Lindner]
//			public const string X = @"marc"  ; // [RFC2220]
//			public const string X = @"mathematica"    ; // [Van Nostern]
//			public const string X = @"mikey"    ; // [RFC3830]
//			public const string X = @"mpeg4-generic"  ; // [RFC3640]
//			public const string X = @"msword"   ; // [Lindner]
//			public const string X = @"news-message-id"   ; // [RFC1036,Spencer]
//			news-transmission    ; // [RFC1036, Spencer]
//			ocsp-request   ; // [RFC2560]
//			ocsp-response  ; // [RFC2560]
//			octet-stream   ; // [RFC2045,RFC2046]
//			oda   ; // [RFC2045,RFC2046]
//			ogg   ; // [RFC3534]
//			parityfec   ; // [RFC3009]
//			pdf   ; // [RFC3778]
//			pgp-encrypted  ; // [RFC3156]
//			pgp-keys    ; // [RFC3156]
//			pgp-signature  ; // [RFC3156]
//			pidf+xml    ; // [RFC3863]
//			pkcs10   ; // [RFC2311]
//			pkcs7-mime  ; // [RFC2311]
//			pkcs7-signature   ; // [RFC2311]
//			pkix-cert   ; // [RFC2585]
//			pkixcmp  ; // [RFC2510]
//			pkix-crl    ; // [RFC2585]
//			pkix-pkipath   ; // [RFC3546]
//			postscript  ; // [RFC2045,RFC2046]
//			prs.alvestrand.titrax-sheet   ; // [Alvestrand]
//			prs.cww  ; // [Rungchavalnont]
//			prs.nprend  ; // [Doggett]
//			prs.plucker    ; // [Janssen]
//			rdf+xml  ; // [RFC3870]
//			qsig  ; // [RFC3204]
//			reginfo+xml    ; // [RFC3680]
//			remote-printing   ; // [RFC1486,Rose]
//			riscos   ; // [Smith]
//			rtf   ; // [Lindner]
//			samlassertion+xml    ; // [OASIS Security Services Technical Committee (SSTC)]
//			samlmetadata+xml  ; // [OASIS Security Services Technical Committee (SSTC)]
//			sbml+xml    ; // [RFC3823]
//			sdp   ; // [RFC2327]
//			set-payment    ; // [Korver]
//			set-payment-initiation  ; // [Korver]
//			set-registration  ; // [Korver]
//			set-registration-initiation   ; // [Korver]
//			sgml  ; // [RFC1874]
//			sgml-open-catalog    ; // [Grosso]
//			sieve    ; // [RFC3028]
//			simple-message-summary  ; // [RFC3842]
//			slate    ; // [Crowley]
//			soap+xml    ; // [RFC3902]
//			spirits-event+xml    ; // [RFC3910]
//			timestamp-query   ; // [RFC3161]
//			timestamp-reply   ; // [RFC3161]
//			tve-trigger    ; // [Welsh]
//			vemmi    ; // [RFC2122]
//			vnd.3gpp.pic-bw-large   ; // [Meredith]
//			vnd.3gpp.pic-bw-small   ; // [Meredith]
//			vnd.3gpp.pic-bw-var  ; // [Meredith]
//			vnd.3gpp.sms   ; // [Meredith]
//			vnd.3M.Post-it-Notes    ; // [O'Brien]
//			vnd.accpac.simply.aso   ; // [Leow]
//			vnd.accpac.simply.imp   ; // [Leow]
//			vnd.acucobol   ; // [Lubin]
//			vnd.acucorp    ; // [Lubin]
//			vnd.adobe.xfdf    ; // [Perelman]
//			vnd.aether.imp    ; // [Moskowitz]
//			vnd.amiga.ami  ; // [Blumberg]
//			vnd.anser-web-certificate-issue-initiation   ; // [Mori]
//			vnd.anser-web-funds-transfer-initiation   ; // [Mori]
//			vnd.audiograph    ; // [Slusanschi]
//			vnd.blueice.multipass   ; // [Holmstrom]
//			vnd.bmi  ; // [Gotoh]
//			vnd.businessobjects  ; // [Imoucha]
//			vnd.canon-cpdl    ; // [Muto]
//			vnd.canon-lips    ; // [Muto]
//			vnd.cinderella    ; // [Kortenkamp]
//			vnd.claymore   ; // [Simpson]
//			vnd.commerce-battelle   ; // [Applebaum]
//			vnd.commonspace   ; // [Chandhok]
//			vnd.cosmocaller   ; // [Dellutri]
//			vnd.contact.cmsg  ; // [Patz]
//			vnd.criticaltools.wbs+xml  ; // [Spiller]
//			vnd.ctc-posml  ; // [Kohlhepp]
//			vnd.cups-postscript  ; // [Sweet]
//			vnd.cups-raster   ; // [Sweet]
//			vnd.cups-raw   ; // [Sweet]
//			vnd.curl    ; // [Byrnes]
//			vnd.cybank  ; // [Helmee]
//			vnd.data-vision.rdz  ; // [Fields]
//			vnd.dna  ; // [Searcy]
//			vnd.dpgraph    ; // [Parker]
//			vnd.dreamfactory  ; // [Appleton]
//			vnd.dxr  ; // [Duffy]
//			vnd.ecdis-update  ; // [Buettgenbach]
//			vnd.ecowin.chart  ; // [Olsson]
//			vnd.ecowin.filerequest  ; // [Olsson]
//			vnd.ecowin.fileupdate   ; // [Olsson]
//			vnd.ecowin.series    ; // [Olsson]
//			vnd.ecowin.seriesrequest   ; // [Olsson]
//			vnd.ecowin.seriesupdate    ; // [Olsson]
//			vnd.enliven    ; // [Santinelli]
//			vnd.epson.esf  ; // [Hoshina]
//			vnd.epson.msf  ; // [Hoshina]
//			vnd.epson.quickanime    ; // [Gu]
//			vnd.epson.salt    ; // [Nagatomo]
//			vnd.epson.ssf  ; // [Hoshina]
//			vnd.ericsson.quickcall  ; // [Tidwell]
//			vnd.eudora.data   ; // [Resnick]
//			vnd.fdf  ; // [Zilles]
//			vnd.ffsns   ; // [Holstage]
//			vnd.fints   ; // [Hammann]
//			vnd.FloGraphIt    ; // [Floersch]
//			vnd.framemaker    ; // [Wexler]
//			vnd.fsc.weblaunch    ; // [D.Smith]
//			vnd.fujitsu.oasys    ; // [Togashi]
//			vnd.fujitsu.oasys2   ; // [Togashi]
//			vnd.fujitsu.oasys3   ; // [Okudaira]
//			vnd.fujitsu.oasysgp  ; // [Sugimoto]
//			vnd.fujitsu.oasysprs    ; // [Ogita]
//			vnd.fujixerox.ddd    ; // [Onda]
//			vnd.fujixerox.docuworks    ; // [Taguchi]
//			vnd.fujixerox.docuworks.binder   ; // [Matsumoto]
//			vnd.fut-misnet    ; // [Pruulmann]
//			vnd.genomatix.tuxedo    ; // [Frey]
//			vnd.grafeq  ; // [Tupper]
//			vnd.groove-account   ; // [Joseph]
//			vnd.groove-help   ; // [Joseph]
//			vnd.groove-identity-message   ; // [Joseph]
//			vnd.groove-injector  ; // [Joseph]
//			vnd.groove-tool-message    ; // [Joseph]
//			vnd.groove-tool-template   ; // [Joseph]
//			vnd.groove-vcard  ; // [Joseph]
//			vnd.hbci    ; // [Hammann]
//			vnd.hcl-bireports    ; // [Serres]
//			vnd.hhe.lesson-player   ; // [Jones]
//			vnd.hp-HPGL    ; // [Pentecost]
//			vnd.hp-hpid    ; // [Gupta]
//			vnd.hp-hps  ; // [Aubrey]
//			vnd.hp-PCL  ; // [Pentecost]
//			vnd.hp-PCLXL   ; // [Pentecost]
//			vnd.httphone   ; // [Lefevre]
//			vnd.hzn-3d-crossword    ; // [Minnis]
//			vnd.ibm.afplinedata  ; // [Buis]
//			vnd.ibm.electronic-media   ; // [Tantlinger]
//			vnd.ibm.MiniPay   ; // [Herzberg]
//			vnd.ibm.modcap    ; // [Hohensee]
//			vnd.ibm.rights-management  ; // [Tantlinger]
//			vnd.ibm.secure-container   ; // [Tantlinger]
//			vnd.informix-visionary  ; // [Gales]
//			vnd.intercon.formnet    ; // [Gurak]
//			vnd.intertrust.digibox  ; // [Tomasello]
//			vnd.intertrust.nncp  ; // [Tomasello]
//			vnd.intu.qbo   ; // [Scratchley]
//			vnd.intu.qfx   ; // [Scratchley]
//			vnd.ipunplugged.rcprofile  ; // [Ersson]
//			vnd.irepository.package+xml   ; // [Knowles]
//			vnd.is-xpr  ; // [Natarajan]
//			vnd.japannet-directory-service   ; // [Fujii]
//			vnd.japannet-jpnstore-wakeup  ; // [Yoshitake]
//			vnd.japannet-payment-wakeup   ; // [Fujii]
//			vnd.japannet-registration  ; // [Yoshitake]
//			vnd.japannet-registration-wakeup    ; // [Fujii]
//			vnd.japannet-setstore-wakeup  ; // [Yoshitake]
//			vnd.japannet-verification  ; // [Yoshitake]
//			vnd.japannet-verification-wakeup    ; // [Fujii]
//			vnd.jisp    ; // [Deckers]
//			vnd.kde.karbon    ; // [Faure]
//			vnd.kde.kchart    ; // [Faure]
//			vnd.kde.kformula  ; // [Faure]
//			vnd.kde.kivio  ; // [Faure]
//			vnd.kde.kontour   ; // [Faure]
//			vnd.kde.kpresenter   ; // [Faure]
//			vnd.kde.kspread   ; // [Faure]
//			vnd.kde.kword  ; // [Faure]
//			vnd.kenameaapp    ; // [DiGiorgio-Haag]
//			vnd.kidspiration  ; // [Bennett]
//			vnd.Kinar   ; // [Thakkar]
//			vnd.koan    ; // [Cole]
//			vnd.liberty-request+xml    ; // [McDowell]
//			vnd.llamagraphics.life-balance.desktop    ; // [White]
//			vnd.llamagraphics.life-balance.exchange+xml  ; // [White]
//			vnd.lotus-1-2-3   ; // [Wattenberger]
//			vnd.lotus-approach   ; // [Wattenberger]
//			vnd.lotus-freelance  ; // [Wattenberger]
//			vnd.lotus-notes   ; // [Laramie]
//			vnd.lotus-organizer  ; // [Wattenberger]
//			vnd.lotus-screencam  ; // [Wattenberger]
//			vnd.lotus-wordpro    ; // [Wattenberger]
//			vnd.mcd  ; // [Gotoh]
//			vnd.mediastation.cdkey  ; // [Flurry]
//			vnd.meridian-slingshot  ; // [Wedel]
//			vnd.mfmp    ; // [Ikeda]
//			vnd.micrografx.flo   ; // [Prevo]
//			vnd.micrografx.igx   ; // [Prevo]
//			vnd.mif  ; // [Wexler]
//			vnd.minisoft-hp3000-save   ; // [Bartram]
//			vnd.mitsubishi.misty-guard.trustweb    ; // [Tanaka]
//			vnd.Mobius.DAF    ; // [Kabayama]
//			vnd.Mobius.DIS    ; // [Kabayama]
//			vnd.Mobius.MBK    ; // [Devasia]
//			vnd.Mobius.MQY    ; // [Devasia]
//			vnd.Mobius.MSL    ; // [Kabayama]
//			vnd.Mobius.PLC    ; // [Kabayama]
//			vnd.Mobius.TXF    ; // [Kabayama]
//			vnd.mophun.application  ; // [Wennerstrom]
//			vnd.mophun.certificate  ; // [Wennerstrom]
//			vnd.motorola.flexsuite  ; // [Patton]
//			vnd.motorola.flexsuite.adsi   ; // [Patton]
//			vnd.motorola.flexsuite.fis    ; // [Patton]
//			vnd.motorola.flexsuite.gotap  ; // [Patton]
//			vnd.motorola.flexsuite.kmr    ; // [Patton]
//			vnd.motorola.flexsuite.ttc    ; // [Patton]
//			vnd.motorola.flexsuite.wem    ; // [Patton]
//			vnd.mozilla.xul+xml  ; // [McDaniel]
//			vnd.ms-artgalry   ; // [Slawson]
//			vnd.ms-asf  ; // [Fleischman]
//			vnd.mseq    ; // [Le Bodic]
//			vnd.ms-excel   ; // [Gill]
//			vnd.msign   ; // [Borcherding]
//			vnd.ms-lrm  ; // [Ledoux]
//			vnd.ms-powerpoint    ; // [Gill]
//			vnd.ms-project    ; // [Gill]
//			vnd.ms-tnef    ; // [Gill]
//			vnd.ms-works   ; // [Gill]
//			vnd.ms-wpl  ; // [Plastina]
//			vnd.musician   ; // [Adams]
//			vnd.music-niff    ; // [Butler]
//			vnd.nervana    ; // [Judkins]
//			vnd.netfpx  ; // [Mutz]
//			vnd.noblenet-directory  ; // [Solomon]
//			vnd.noblenet-sealer  ; // [Solomon]
//			vnd.noblenet-web  ; // [Solomon]
//			vnd.nokia.landmark+xml  ; // [Nokia]
//			vnd.nokia.landmark+wbxml   ; // [Nokia]
//			vnd.nokia.landmarkcollection+xml    ; // [Nokia]
//			vnd.nokia.radio-preset  ; // [Nokia]
//			vnd.nokia.radio-presets    ; // [Nokia]
//			vnd.novadigm.EDM  ; // [Swenson]
//			vnd.novadigm.EDX  ; // [Swenson]
//			vnd.novadigm.EXT  ; // [Swenson]
//			vnd.obn  ; // [Hessling]
//			vnd.omads-email+xml  ; // [OMA Data Synchronization Working Group]
//			vnd.omads-file+xml   ; // [OMA Data Synchronization Working Group]
//			vnd.omads-folder+xml    ; // [OMA Data Synchronization Working Group]
//			vnd.osa.netdeploy    ; // [Klos]
//			vnd.palm    ; // [Peacock]
//			vnd.paos.xml   ; // [Kemp]
//			vnd.pg.format  ; // [Gandert]
//			vnd.picsel  ; // [Naccarato]
//			vnd.pg.osasli  ; // [Gandert]
//			vnd.powerbuilder6    ; // [Guy]
//			vnd.powerbuilder6-s  ; // [Guy]
//			vnd.powerbuilder7    ; // [Shilts]
//			vnd.powerbuilder75   ; // [Shilts]
//			vnd.powerbuilder75-s    ; // [Shilts]
//			vnd.powerbuilder7-s  ; // [Shilts]
//			vnd.previewsystems.box  ; // [Smolgovsky]
//			vnd.publishare-delta-tree  ; // [Ben-Kiki]
//			vnd.pvi.ptid1  ; // [Lamb]
//			vnd.pwg-multiplexed  ; // [RFC3391]
//			vnd.pwg-xhtml-print+xml    ; // [Wright]
//			vnd.Quark.QuarkXPress   ; // [Scheidler]
//			vnd.rapid   ; // [Szekely]
//			vnd.RenLearn.rlprint    ; // [Wick]
//			vnd.s3sms   ; // [Tarkkala]
//			vnd.sealed.doc    ; // [Petersen]
//			vnd.sealed.eml    ; // [Petersen]
//			vnd.sealed.mht    ; // [Petersen]
//			vnd.sealed.net    ; // [Lambert]
//			vnd.sealed.ppt    ; // [Petersen]
//			vnd.sealed.xls    ; // [Petersen]
//			vnd.sealedmedia.softseal.html    ; // [Petersen]
//			vnd.sealedmedia.softseal.pdf  ; // [Petersen]
//			vnd.seemail    ; // [Webb]
//			vnd.shana.informed.formdata   ; // [Selzler]
//			vnd.shana.informed.formtemplate  ; // [Selzler]
//			vnd.shana.informed.interchange   ; // [Selzler]
//			vnd.shana.informed.package    ; // [Selzler]
//			vnd.smaf    ; // [Takahashi]
//			vnd.sss-cod    ; // [Dani]
//			vnd.sss-dtf    ; // [Bruno]
//			vnd.sss-ntf    ; // [Bruno]
//			vnd.street-stream    ; // [Levitt]
//			vnd.sus-calendar  ; // [Niedfeldt]
//			vnd.svd  ; // [Becker]
//			vnd.swiftview-ics    ; // [Widener]
//			vnd.syncml.ds.notification    ; // [OMA Data Synchronization Working Group]
//			vnd.syncml.+xml   ; // [OMA Data Synchronization Working Group]
//			vnd.triscape.mxs  ; // [Simonoff]
//			vnd.trueapp    ; // [Hepler]
//			vnd.truedoc    ; // [Chase]
//			vnd.ufdl    ; // [Manning]
//			vnd.uiq.theme  ; // [Ocock]
//			vnd.uplanet.alert    ; // [Martin]
//			vnd.uplanet.alert-wbxml    ; // [Martin]
//			vnd.uplanet.bearer-choice  ; // [Martin]
//			vnd.uplanet.bearer-choice-wbxml  ; // [Martin]
//			vnd.uplanet.cacheop  ; // [Martin]
//			vnd.uplanet.cacheop-wbxml  ; // [Martin]
//			vnd.uplanet.channel  ; // [Martin]
//			vnd.uplanet.channel-wbxml  ; // [Martin]
//			vnd.uplanet.list  ; // [Martin]
//			vnd.uplanet.listcmd  ; // [Martin]
//			vnd.uplanet.listcmd-wbxml  ; // [Martin]
//			vnd.uplanet.list-wbxml  ; // [Martin]
//			vnd.uplanet.signal   ; // [Martin]
//			vnd.vcx  ; // [T.Sugimoto]
//			vnd.vectorworks   ; // [Pharr]
//			vnd.vidsoft.vidconference  ; // [Hess]
//			vnd.visio   ; // [Sandal]
//			vnd.visionary  ; // [Aravindakumar]
//			vnd.vividence.scriptfile   ; // [Risher]
//			vnd.vsf  ; // [Rowe]
//			vnd.wap.sic    ; // [WAP-Forum]
//			vnd.wap.slc    ; // [WAP-Forum]
//			vnd.wap.wbxml  ; // [Stark]
//			vnd.wap.wmlc   ; // [Stark]
//			vnd.wap.wmlscriptc   ; // [Stark]
//			vnd.webturbo   ; // [Rehem]
//			vnd.wordperfect   ; // [Scarborough]
//			vnd.wqd  ; // [Bostrom]
//			vnd.wrq-hp3000-labelled    ; // [Bartram]
//			vnd.wt.stf  ; // [Wohler]
//			vnd.wv.csp+xml    ; // [Ingimundarson]
//			vnd.wv.csp+wbxml  ; // [Salmi]
//			vnd.wv.ssp+xml    ; // [Ingimundarson]
//			vnd.xara    ; // [Matthewman]
//			vnd.xfdl    ; // [Manning]
//			vnd.yamaha.hv-dic    ; // [Yamamoto]
//			vnd.yamaha.hv-script    ; // [Yamamoto]
//			vnd.yamaha.hv-voice  ; // [Yamamoto]
//			vnd.yamaha.smaf-audio   ; // [Shinoda]
//			vnd.yamaha.smaf-phrase  ; // [Shinoda]
//			vnd.yellowriver-custom-menu   ; // [Yellow]
//			watcherinfo+xml   ; // [RFC3858]
//			whoispp-query  ; // [RFC2957]
//			whoispp-response  ; // [RFC2958]
//			wita  ; // [Campbell]
//			wordperfect5.1    ; // [Lindner]
//			x400-bp  ; // [RFC1494]
//			xhtml+xml   ; // [RFC3236]
//			xml   ; // [RFC3023]
//			xml-dtd  ; // [RFC3023]
//			xml-external-parsed-entity    ; // [RFC3023]
//			xmpp+xml    ; // [RFC3923]
//			xop+xml  ; // [Nottingham]
//			zip   ; // [Lindner]
//		}

//		public class audio
//		{
//			public const string X = @"32kadpcm  	; // [RFC2421,RFC2422]
//			public const string X = @"3gpp 	; // [RFC3839]
//			public const string X = @"AMR 	; // [RFC3267]
//			public const string X = @"AMR-WB 	; // [RFC3267]
//			public const string X = @"basic 	; // [RFC2045,RFC2046]
//			public const string X = @"clearmode 	; // [RFC-draft-ietf-avt-rtp-clearmode-05.txt]
//			public const string X = @"CN 	; // [RFC3389]
//			public const string X = @"DAT12 	; // [RFC3190]
//			public const string X = @"dsr-es201108 	; // [RFC3557]
//			public const string X = @"dsr-es202050 	; // [RFC-ietf-avt-rtp-dsr-codecs-03.txt]
//			public const string X = @"dsr-es202211 	; // [RFC-ietf-avt-rtp-dsr-codecs-03.txt]
//			public const string X = @"dsr-es202212 	; // [RFC-ietf-avt-rtp-dsr-codecs-03.txt]
//			public const string X = @"DVI4 	; // [RFC3555]
//			public const string X = @"EVRC 	; // [RFC3558]
//			public const string X = @"EVRC0 	; // [RFC3558]
//			public const string X = @"EVRC-QCP 	; // [RFC3625]
//			public const string X = @"G722 	; // [RFC3555]
//			public const string X = @"G.722.1 	; // [RFC3047]
//			public const string X = @"G723 	; // [RFC3555]
//			public const string X = @"G726-16 	; // [RFC3555]
//			public const string X = @"G726-24 	; // [RFC3555]
//			public const string X = @"G726-32 	; // [RFC3555]
//			public const string X = @"G726-40 	; // [RFC3555]
//			public const string X = @"G728 	; // [RFC3555]
//			public const string X = @"G729 	; // [RFC3555]
//			public const string X = @"G729D 	; // [RFC3555]
//			public const string X = @"G729E 	; // [RFC3555]
//			public const string X = @"GSM 	; // [RFC3555]
//			public const string X = @"GSM-EFR 	; // [RFC3555]
//			public const string X = @"iLBC 	; // [RFC-ietf-avt-rtp-ilbc-05.txt]
//			public const string X = @"L8 	; // [RFC3555]
//			public const string X = @"L16 	; // [RFC3555]
//			public const string X = @"L20 	; // [RFC3190]
//			public const string X = @"L24 	; // [RFC3190]
//			public const string X = @"LPC 	; // [RFC3555]
//			public const string X = @"MPA 	; // [RFC3555]
//			public const string X = @"MP4A-LATM 	; // [RFC3016]
//			public const string X = @"mpa-robust 	; // [RFC3119]
//			public const string X = @"mpeg 	; // [RFC3003]
//			public const string X = @"mpeg4-generic 	; // [RFC3640]
//			public const string X = @"parityfec 	; // [RFC3009]
//			public const string X = @"PCMA 	; // [RFC3555]
//			public const string X = @"PCMU 	; // [RFC3555]
//			public const string X = @"prs.sid 	; // [Walleij]
//			public const string X = @"QCELP 	; // [RFC3555]; // [RFC3625]
//			public const string X = @"RED 	; // [RFC3555]
//			public const string X = @"SMV 	; // [RFC3558]
//			public const string X = @"SMV0 	; // [RFC3558]
//			public const string X = @"SMV-QCP 	; // [RFC3625]
//			public const string X = @"telephone-event 	; // [RFC2833]
//			public const string X = @"tone 	; // [RFC2833]
//			public const string X = @"VDVI 	; // [RFC3555]
//			public const string X = @"vnd.3gpp.iufp 	; // [Belling]
//			public const string X = @"vnd.audiokoz 	; // [DeBarros]
//			public const string X = @"vnd.cisco.nse 	; // [Kumar]
//			public const string X = @"vnd.cns.anp1 	; // [McLaughlin]
//			public const string X = @"vnd.cns.inf1 	; // [McLaughlin]
//			public const string X = @"vnd.digital-winds 	; // [Strazds]
//			public const string X = @"vnd.everad.plj 	; // [Cicelsky]
//			public const string X = @"vnd.lucent.voice 	; // [Vaudreuil]
//			public const string X = @"vnd.nokia.mobile-xmf 	; // [Nokia Corporation]
//			public const string X = @"vnd.nortel.vbk 	; // [Parsons]
//			public const string X = @"vnd.nuera.ecelp4800 	; // [Fox]
//			public const string X = @"vnd.nuera.ecelp7470 	; // [Fox]
//			public const string X = @"vnd.nuera.ecelp9600 	; // [Fox]
//			public const string X = @"vnd.octel.sbc 	; // [Vaudreuil]
//			public const string X = @"vnd.qcelp - DEPRECATED - Please use audio/qcelp 	; // [RFC3625]
//			public const string X = @"vnd.rhetorex.32kadpcm 	; // [Vaudreuil]
//			public const string X = @"vnd.sealedmedia.softseal.mpeg 	; // [Petersen]
//			public const string X = @"vnd.vmx.cvsd 	; // [Vaudreuil]
//		}

		public class Image
		{
			public const string Cgm										= @"image/cgm"; // [Francis]
			public const string Fits									= @"image/fits"     ; // [RFC-allen-fitsmime-00.txt]
			public const string G3fax									= @"image/g3fax"      ; // [RFC1494]
			public const string Gif										= @"image/gif"       ; // [RFC2045,RFC2046]
			public const string Ief										= @"image/ief"      ; // [RFC1314]
			public const string Jp2										= @"image/jp2"       ; // [RFC3745]
			public const string Jpeg									= @"image/jpeg"           ; // [RFC2045,RFC2046]
			public const string Jpm										= @"image/jpm"       ; // [RFC3745]
			public const string Jpx										= @"image/jpx"       ; // [RFC3745]
			public const string Naplps									= @"image/naplps"       ; // [Ferber]
			public const string Png										= @"image/png"       ; // [Randers-Pehrson]
			public const string Prs_btif								= @"image/prs.btif"      ; // [Simon]
			public const string Prs_pti									= @"image/prs.pti"     ; // [Laun]
			public const string T38										= @"image/t38"       ; // [RFC3362]
			public const string Tiff									= @"image/tiff"     ; // [RFC3302]
			public const string Tiff_fx									= @"image/tiff-fx"  ; // [RFC-draft-ietf-fax-tiff-fx-reg-v2-01.txt]
			public const string Vnd_cns_inf2							= @"image/vnd.cns.inf2"       ; // [McLaughlin]
			public const string Vnd_djvu								= @"image/vnd.djvu"      ; // [Bottou]
			public const string Vnd_dwg									= @"image/vnd.dwg"     ; // [Moline]
			public const string Vnd_dxf									= @"image/vnd.dxf"     ; // [Moline]
			public const string Vnd_fastbidsheet						= @"image/vnd.fastbidsheet"     ; // [Becker]
			public const string Vnd_fpx									= @"image/vnd.fpx"     ; // [Spencer]
			public const string Vnd_fst									= @"image/vnd.fst"     ; // [Fuldseth]
			public const string Vnd_fujixerox_edmics_mmr				= @"image/vnd.fujixerox.edmics-mmr"       ; // [Onda]
			public const string Vnd_fujixerox_edmics_rlc				= @"image/vnd.fujixerox.edmics-rlc"       ; // [Onda]
			public const string Vnd_globalgraphics_pgb					= @"image/vnd.globalgraphics.pgb"     ; // [Bailey]
			public const string Vnd_microsoft_icon						= @"image/vnd.microsoft.icon"       ; // [Butcher]
			public const string Vnd_mix									= @"image/vnd.mix"     ; // [Reddy]
			public const string Vnd_ms_modi								= @"image/vnd.ms-modi"      ; // [Vaughan]
			public const string Vnd_net_fpx								= @"image/vnd.net-fpx"      ; // [Spencer]
			public const string Vnd_sealed_png							= @"image/vnd.sealed.png"      ; // [Petersen]
			public const string Vnd_sealedmedia_softseal_gif			= @"image/vnd.sealedmedia.softseal.gif"     ; // [Petersen]
			public const string Vnd_sealedmedia_softseal_jpg			= @"image/vnd.sealedmedia.softseal.jpg"     ; // [Petersen]
			public const string Vnd_svf									= @"image/vnd.svf"     ; // [Moline]
			public const string Vnd_wap_wbmp							= @"image/vnd.wap.wbmp"       ; // [Stark]
			public const string Vnd_xiff								= @"image/vnd.xiff"      ; // [S.Martin]
		}

//		public class Message
//		{
//			public const string cpim									= @"message/CPIM"     ; // [RFC3862]
//			public const string delivery_status							= @"message/delivery-status"    ; // [RFC1894]
//			public const string disposition_notification				= @"message/disposition-notification"    ; // [RFC2298]
//			public const string external_body							= @"message/external-body"  ; // [RFC2045,RFC2046]
//			public const string http									= @"message/http"  ; // [RFC2616]
//			public const string news									= @"message/news"  ; // [RFC 1036, H.Spencer]
//			public const string partial									= @"message/partial"  ; // [RFC2045,RFC2046]
//			public const string rfc822									= @"message/rfc822"    ; // [RFC2045,RFC2046]
//			public const string s_http									= @"message/s-http"    ; // [RFC2660]
//			public const string sip										= @"message/sip"    ; // [RFC3261]
//			public const string sipfrag									= @"message/sipfrag"  ; // [RFC3420]
//			public const string tracking_status							= @"message/tracking-status"    ; // [RFC3886]
//		}

//		public class Model
//		{
//			public const string iges									= @"model/iges"     ; // [Parks]
//			public const string mesh									= @"model/mesh"  ; // [RFC2077]
//			public const string Vnd_dwf									= @"model/vnd.dwf"  ; // [Pratt]
//			public const string Vnd_flatland_3dml						= @"model/vnd.flatland.3dml"   ; // [Powers]
//			public const string Vnd_gdl									= @"model/vnd.gdl"  ; // [Babits]
//			public const string Vnd_gs_gdl								= @"model/vnd.gs-gdl"  ; // [Babits]
//			public const string Vnd_gtw									= @"model/vnd.gtw"  ; // [Ozaki]
//			public const string Vnd_mts									= @"model/vnd.mts"  ; // [Rabinovitch]
//			public const string Vnd_parasolid_transmit_binary			= @"model/vnd.parasolid.transmit.binary"   ; // [Parasolid]
//			public const string Vnd_parasolid_transmit_text				= @"model/vnd.parasolid.transmit.text"    ; // [Parasolid]
//			public const string Vnd_vtu									= @"model/vnd.vtu"  ; // [Rabinovitch]
//			public const string vrml									= @"model/vrml"  ; // [RFC2077]
//		}

		public class Multipart
		{
			public const string Alternative								= @"multipart/alternative"   ; // [RFC2045,RFC2046]
			public const string Appledouble								= @"multipart/appledouble"   ; // [Faltstrom]
			public const string Byteranges								= @"multipart/byteranges"  ; // [RFC2068]
			public const string Digest									= @"multipart/digest"    ; // [RFC2045,RFC2046]
			public const string Encrypted								= @"multipart/encrypted"    ; // [RFC1847]
			public const string Form_data								= @"multipart/form-data"    ; // [RFC2388]
			public const string Header_set								= @"multipart/header-set"  ; // [Crocker]
			public const string Mixed									= @"multipart/mixed"   ; // [RFC2045,RFC2046]
			public const string Parallel								= @"multipart/parallel"   ; // [RFC2045,RFC2046]
			public const string Related									= @"multipart/related"  ; // [RFC2387]
			public const string Report									= @"multipart/report"    ; // [RFC1892]
			public const string Signed									= @"multipart/signed"    ; // [RFC1847]
			public const string Voice_message							= @"multipart/voice-message"  ; // [RFC2421,RFC2423]
		}
		
		public class Text
		{
			public const string Calendar								= @"text/calendar"   ; // [RFC2445]
			public const string Css										= @"text/css"    ; // [RFC2318]
			public const string Directory								= @"text/directory"    ; // [RFC2425]
			public const string Dns										= @"text/dns"    ; // [RFC-josefsson-mime-dns-02.txt]
			public const string Enriched								= @"text/enriched"   ; // [RFC1896]
			public const string Html									= @"text/html"  ; // [RFC2854]
			public const string Parityfec								= @"text/parityfec"    ; // [RFC3009]
			public const string Plain									= @"text/plain"   ; // [RFC2046, RFC3676]
			public const string Prs_fallenstein_rst						= @"text/prs.fallenstein.rst"  ; // [Fallenstein]
			public const string Prs_lines_tag							= @"text/prs.lines.tag"  ; // [Lines]
			public const string Rfc822_headers							= @"text/rfc822-headers"   ; // [RFC1892]
			public const string Richtext								= @"text/richtext"   ; // [RFC2045,RFC2046]
			public const string Rtf										= @"text/rtf"    ; // [Lindner]
			public const string Sgml									= @"text/sgml"  ; // [RFC1874]
			public const string T140									= @"text/t140"  ; // [RFC-ietf-avt-rfc2793bis-09.txt]
			public const string Tab_separated_values					= @"text/tab-separated-values"   ; // [Lindner]
			public const string Uri_list								= @"text/uri-list"   ; // [RFC2483]
			public const string Vnd_abc									= @"text/vnd.abc"  ; // [Allen]
			public const string Vnd_curl								= @"text/vnd.curl"   ; // [Byrnes]
			public const string Vnd_DMClientScript						= @"text/vnd.DMClientScript"    ; // [Bradley]
			public const string Vnd_esmertec_theme_descriptor			= @"text/vnd.esmertec.theme-descriptor"   ; // [Eilemann]
			public const string Vnd_fly									= @"text/vnd.fly"  ; // [Gurney]
			public const string Vnd_fmi_flexstor						= @"text/vnd.fmi.flexstor"  ; // [Hurtta]
			public const string Vnd_in3d_3dml							= @"text/vnd.in3d.3dml"  ; // [Powers]
			public const string Vnd_in3d_spot							= @"text/vnd.in3d.spot"  ; // [Powers]
			public const string Vnd_IPTC_NewsML							= @"text/vnd.IPTC.NewsML"    ; // [IPTC]
			public const string Vnd_IPTC_NITF							= @"text/vnd.IPTC.NITF"  ; // [IPTC]
			public const string Vnd_latex_z								= @"text/vnd.latex-z"   ; // [Lubos]
			public const string Vnd_motorola_reflex						= @"text/vnd.motorola.reflex"  ; // [Patton]
			public const string Vnd_ms_mediapackage						= @"text/vnd.ms-mediapackage"  ; // [Nelson]
			public const string Vnd_net2phone_commcenter_command		= @"text/vnd.net2phone.commcenter.command"   ; // [Xie]
			public const string Vnd_sun_j2me_app_descriptor				= @"text/vnd.sun.j2me.app-descriptor"    ; // [G.Adams]
			public const string Vnd_wap_si								= @"text/vnd.wap.si"  ; // [WAP-Forum]
			public const string Vnd_wap_sl								= @"text/vnd.wap.sl"  ; // [WAP-Forum]
			public const string Vnd_wap_wml								= @"text/vnd.wap.wml"   ; // [Stark]
			public const string Vnd_wap_wmlscript						= @"text/vnd.wap.wmlscript"   ; // [Stark]
			public const string Xml										= @"text/xml"    ; // [RFC3023]
			public const string Xml_external_parsed_entity				= @"text/xml-external-parsed-entity"   ; // [RFC3023]
		}

//		public class Video
//		{
//			public const string 3gpp									= @"video/3gpp";       // [RFC3839]
//			public const string bmpeg									= @"video/BMPEG";        // [RFC3555]
//			public const string bt656									= @"video/BT656"   ; // [RFC3555]
//			public const string celb									= @"video/CelB"  ; // [RFC3555]
//			public const string dv										= @"video/DV"   ; // [RFC3189]
//			public const string h261									= @"video/H261"  ; // [RFC3555]
//			public const string h263									= @"video/H263"  ; // [RFC3555]
//			public const string h263_1998								= @"video/H263-1998"    ; // [RFC3555]
//			public const string h263_2000								= @"video/H263-2000"    ; // [RFC3555]
//			public const string h264									= @"video/H264"  ; // [RFC-ietf-avt-rtp-h264-11.txt]
//			public const string jpeg									= @"video/JPEG"  ; // [RFC3555]
//			public const string mj2										= @"video/MJ2"    ; // [RFC3745]
//			public const string mp1s									= @"video/MP1S"  ; // [RFC3555]
//			public const string mp2p									= @"video/MP2P"  ; // [RFC3555]
//			public const string mp2t									= @"video/MP2T"  ; // [RFC3555]
//			public const string mp4v_es									= @"video/MP4V-ES"  ; // [RFC3016]
//			public const string mpv										= @"video/MPV"    ; // [RFC3555]
//			public const string mpeg									= @"video/mpeg"  ; // [RFC2045,RFC2046]
//			public const string mpeg4_generic							= @"video/mpeg4-generic"  ; // [RFC3640]
//			public const string nv										= @"video/nv"   ; // [RFC3555]
//			public const string parityfec								= @"video/parityfec"    ; // [RFC3009]
//			public const string pointer									= @"video/pointer"  ; // [RFC2862]
//			public const string quicktime								= @"video/quicktime"    ; // [Lindner]
//			public const string SMPTE292M								= @"video/SMPTE292M" ; // [RFC3497]
//			public const string Vnd_fvt									= @"video/vnd.fvt"  ; // [Fuldseth]
//			public const string Vnd_motorola_video						= @"video/vnd.motorola.video"    ; // [McGinty]
//			public const string Vnd_motorola_videop						= @"video/vnd.motorola.videop"  ; // [McGinty]
//			public const string Vnd_mpegurl								= @"video/vnd.mpegurl"   ; // [Recktenwald]
//			public const string Vnd_nokia_interleaved_multimedia		= @"video/vnd.nokia.interleaved-multimedia"   ; // [Kangaslampi]
//			public const string Vnd_objectvideo							= @"video/vnd.objectvideo"    ; // [Clark]
//			public const string Vnd_sealed_mpeg1						= @"video/vnd.sealed.mpeg1"  ; // [Petersen]
//			public const string Vnd_sealed_mpeg4						= @"video/vnd.sealed.mpeg4"  ; // [Petersen]
//			public const string Vnd_sealed_swf							= @"video/vnd.sealed.swf"   ; // [Petersen]
//			public const string Vnd_sealedmedia_softseal_mov			= @"video/vnd.sealedmedia.softseal.mov"  ; // [Petersen]
//			public const string Vnd_vivo								= @"video/vnd.vivo"   ; // [Wolfe]
//		}
	}
}
