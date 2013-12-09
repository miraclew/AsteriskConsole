///////////////////////////////////////////////////////////////////////////////////////////////
//
//    This File is Part of the CallButler Open Source PBX (http://www.codeplex.com/callbutler
//
//    Copyright (c) 2005-2008, Jim Heising
//    All rights reserved.
//
//    Redistribution and use in source and binary forms, with or without modification,
//    are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice,
//      this list of conditions and the following disclaimer.
//
//    * Redistributions in binary form must reproduce the above copyright notice,
//      this list of conditions and the following disclaimer in the documentation and/or
//      other materials provided with the distribution.
//
//    * Neither the name of Jim Heising nor the names of its contributors may be
//      used to endorse or promote products derived from this software without specific prior
//      written permission.
//
//    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//    ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
//    IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
//    INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
//    NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//    PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
//    WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
//    ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//    POSSIBILITY OF SUCH DAMAGE.
//
///////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace IC.Controls
{
    public partial class MapViewerControl : UserControl
    {
        private int zoomLevel = 0;
        private double lat = 0;
        private double lon = 0;
        private string location = "";

        private const string googleAPIKey = "ABQIAAAA_YO-lmQYdOWB8HEXfg9hHBRwqw291EfmGrUnOiS1DlRidXhZmBTd-NCr9q52qgbSyxSbZB8b-SS43g";

        public MapViewerControl()
        {
            InitializeComponent();

            ReloadMap();
        }

        public int Zoom
        {
            get
            {
                return zoomLevel;
            }
            set
            {
                zoomLevel = Math.Min(Math.Max(value, 0), 19);
                ReloadMap();
            }
        }

        public string MapLocation
        {
            get
            {
                return location;
            }
            set
            {
                lat = 0;
                lon = 0;

                LoadLocation(value);
            }
        }

        public double Latitude
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                ReloadMap();
            }
        }

        public double Longitude
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                ReloadMap();
            }
        }

        public bool LoadLocation(string location, int zoom)
        {
            zoomLevel = Math.Min(Math.Max(zoom, 0), 19);
            return LoadLocation(location);
        }

        public bool LoadLocation(string location)
        {
            string url = new System.Uri(string.Format("http://maps.google.com/maps/geo?q={0}&output=xml&key={1}", location, googleAPIKey)).AbsoluteUri;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                // Load our URL
                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)System.Net.HttpWebRequest.Create(url).GetResponse();

                System.IO.StreamReader stream = new System.IO.StreamReader(response.GetResponseStream());
                string responseString = stream.ReadToEnd();

                stream.Close();
                response.Close();

                xmlDoc.LoadXml(responseString);

                // Check to make sure our response is okay
                XmlNode responseNode = xmlDoc.DocumentElement["Response"]["Status"]["code"];

                if(responseNode != null && responseNode.InnerText == "200")
                {
                    XmlNode coordinatesNode = xmlDoc.DocumentElement["Response"]["Placemark"]["Point"]["coordinates"];

                    string[] coordString = coordinatesNode.InnerText.Split(',');

                    double lat = 0;
                    double lon = 0;

                    if (double.TryParse(coordString[1], out lat) && double.TryParse(coordString[0], out lon))
                    {
                        LoadLocation(lat, lon);

                        return true;
                    }
                }
            }
            catch(Exception e)
            {
            }

            return false;
        }

        public void LoadLocation(double latitude, double longitude, int zoom)
        {
            zoomLevel = Math.Min(Math.Max(zoom, 0), 19);
            LoadLocation(latitude, longitude);
        }

        public void LoadLocation(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lon = longitude;

            ReloadMap();
        }

        private void ReloadMap()
        {
            string url = string.Format("http://maps.google.com/staticmap?center={0},{1}&zoom={2}&size={3}x{4}&key={5}", Latitude, Longitude, Zoom, this.Width, this.Height, googleAPIKey);

            try
            {
                pbMap.Load(url);
            }
            catch
            {
            }
        }

        public static Image GetMapImage(double latitude, double longitude, int zoom, int width, int height)
        {
            try
            {
                string url = string.Format("http://maps.google.com/staticmap?center={0},{1}&zoom={2}&size={3}x{4}&key={5}", latitude, longitude, Math.Min(Math.Max(zoom, 0), 19), width, height, googleAPIKey);

                Bitmap bmp = new Bitmap(System.Net.HttpWebRequest.Create(url).GetResponse().GetResponseStream());

                return bmp;
            }
            catch
            {
            }

            return null;
        }

        public static Image GetMapImage(string location, int zoom, int width, int height)
        {
            string url = new System.Uri(string.Format("http://maps.google.com/maps/geo?q={0}&output=xml&key={1}", location, googleAPIKey)).AbsoluteUri;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                // Load our URL
                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)System.Net.HttpWebRequest.Create(url).GetResponse();

                System.IO.StreamReader stream = new System.IO.StreamReader(response.GetResponseStream());
                string responseString = stream.ReadToEnd();

                stream.Close();
                response.Close();

                xmlDoc.LoadXml(responseString);

                // Check to make sure our response is okay
                XmlNode responseNode = xmlDoc.DocumentElement["Response"]["Status"]["code"];

                if (responseNode != null && responseNode.InnerText == "200")
                {
                    XmlNode coordinatesNode = xmlDoc.DocumentElement["Response"]["Placemark"]["Point"]["coordinates"];

                    string[] coordString = coordinatesNode.InnerText.Split(',');

                    double lat = 0;
                    double lon = 0;

                    if (double.TryParse(coordString[1], out lat) && double.TryParse(coordString[0], out lon))
                    {
                        return GetMapImage(lat, lon, zoom, width, height);
                    }
                }
            }
            catch (Exception e)
            {
            }

            return null;
        }

        private void pbMap_SizeChanged(object sender, EventArgs e)
        {
            ReloadMap();
        }
    }
}
