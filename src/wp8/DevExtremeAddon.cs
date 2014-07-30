using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;
using System.Xml.Linq;

namespace WPCordovaClassLib.Cordova.Commands {
    public class DevExtremeAddon : BaseCommand {
        public void setup(string options) {
            Deployment.Current.Dispatcher.BeginInvoke(() => {
                PhoneApplicationFrame frame = Application.Current.RootVisual as PhoneApplicationFrame;
                if(frame != null) {
                    PhoneApplicationPage page = frame.Content as PhoneApplicationPage;
                    page.SupportedOrientations = LoadOrientationFromConfig();
                    if(page != null) {
                        CordovaView cView = page.FindName("CordovaView") as CordovaView;
                        cView.DisableBouncyScrolling = true;
                        if(cView != null) {
                            WebBrowser br = cView.Browser;
                            br.ScriptNotify += (sender, e) => {
                                if(e.Value == "DevExpress.ExitApp") {
                                    Application.Current.Terminate();
                                }
                            };
                        }
                    }
                }
            });
        }

        private SupportedPageOrientation LoadOrientationFromConfig() {

            StreamResourceInfo streamInfo = Application.GetResourceStream(new Uri("config.xml", UriKind.Relative));

            if(streamInfo != null) {
                StreamReader sr = new StreamReader(streamInfo.Stream);

                //This will Read Keys Collection for the xml file
                XDocument document = XDocument.Parse(sr.ReadToEnd());

                var preferences = from results in document.Descendants("preference")
                                  select new {
                                      name = (string)results.Attribute("name"),
                                      value = (string)results.Attribute("value")
                                  };

                foreach(var pref in preferences) {
                    if(pref.name == "orientation") {
                        if(pref.value == "portrait") {
                            return SupportedPageOrientation.Portrait;
                        }
                        if(pref.value == "landscape") {
                            return SupportedPageOrientation.Landscape;
                        }
                    }
                }
            }

            return SupportedPageOrientation.PortraitOrLandscape;
        }
    }
}
