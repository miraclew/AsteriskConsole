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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IC.Controls
{
    public partial class CountryComboBox : System.Windows.Forms.ComboBox
    {
        public CountryComboBox()
        {
            InitializeComponent();

            base.DropDownStyle = ComboBoxStyle.DropDownList;

            base.Items.Add("Please Select a Country");
            base.Items.Add("Afghanistan");
            base.Items.Add("Åland Islands");
            base.Items.Add("Albania");
            base.Items.Add("Algeria");
            base.Items.Add("American Samoa");
            base.Items.Add("Andorra");
            base.Items.Add("Angola");
            base.Items.Add("Anguilla");
            base.Items.Add("Antarctica");
            base.Items.Add("Antigua and Barbuda");
            base.Items.Add("Argentina");
            base.Items.Add("Armenia");
            base.Items.Add("Aruba");
            base.Items.Add("Australia");
            base.Items.Add("Austria");
            base.Items.Add("Azerbaijan");
            base.Items.Add("Bahamas");
            base.Items.Add("Bahrain");
            base.Items.Add("Bangladesh");
            base.Items.Add("Barbados");
            base.Items.Add("Belarus");
            base.Items.Add("Belgium");
            base.Items.Add("Belize");
            base.Items.Add("Benin");
            base.Items.Add("Bermuda");
            base.Items.Add("Bhutan");
            base.Items.Add("Bolivia");
            base.Items.Add("Bosnia and Herzegovina");
            base.Items.Add("Botswana");
            base.Items.Add("Bouvet Island");
            base.Items.Add("Brazil");
            base.Items.Add("British Indian Ocean Territory");
            base.Items.Add("Brunei Darussalam");
            base.Items.Add("Bulgaria");
            base.Items.Add("Burkina Faso");
            base.Items.Add("Burundi");
            base.Items.Add("Cambodia");
            base.Items.Add("Cameroon");
            base.Items.Add("Canada");
            base.Items.Add("Canary Islands");
            base.Items.Add("Cape Verde");
            base.Items.Add("Cayman Islands");
            base.Items.Add("Central African Republic");
            base.Items.Add("Ceuta");
            base.Items.Add("Chad");
            base.Items.Add("Chile");
            base.Items.Add("China");
            base.Items.Add("Christmas Island");
            base.Items.Add("Cocos (Keeling) Islands");
            base.Items.Add("Colombia");
            base.Items.Add("Comoros");
            base.Items.Add("Congo, Dem. Republic");
            base.Items.Add("Congo, Republic");
            base.Items.Add("Cook Islands");
            base.Items.Add("Costa Rica");
            base.Items.Add("Cote d'Ivoire");
            base.Items.Add("Croatia");
            base.Items.Add("Cyprus");
            base.Items.Add("Cyprus (unregulated area)");
            base.Items.Add("Czech Republic");
            base.Items.Add("Denmark");
            base.Items.Add("Djibouti");
            base.Items.Add("Dominica");
            base.Items.Add("Dominican Republic");
            base.Items.Add("East-Timor");
            base.Items.Add("Ecuador");
            base.Items.Add("Egypt");
            base.Items.Add("El Salvador");
            base.Items.Add("Equatorial Guinea");
            base.Items.Add("Eritrea");
            base.Items.Add("Estonia");
            base.Items.Add("Ethiopia");
            base.Items.Add("Falkland Islands");
            base.Items.Add("Faroe Islands");
            base.Items.Add("Fiji");
            base.Items.Add("Finland");
            base.Items.Add("France");
            base.Items.Add("French Guiana");
            base.Items.Add("French Polynesia");
            base.Items.Add("French Southern Territories");
            base.Items.Add("Gabon");
            base.Items.Add("Gambia");
            base.Items.Add("Georgia");
            base.Items.Add("Germany");
            base.Items.Add("Ghana");
            base.Items.Add("Gibraltar");
            base.Items.Add("Greece");
            base.Items.Add("Greenland");
            base.Items.Add("Grenada");
            base.Items.Add("Guadeloupe");
            base.Items.Add("Guam");
            base.Items.Add("Guatemala");
            base.Items.Add("Guernsey");
            base.Items.Add("Guinea");
            base.Items.Add("Guinea-Bissau");
            base.Items.Add("Guyana");
            base.Items.Add("Haiti");
            base.Items.Add("Heard Island and McDonald Islands");
            base.Items.Add("Honduras");
            base.Items.Add("Hong Kong");
            base.Items.Add("Hungary");
            base.Items.Add("Iceland");
            base.Items.Add("India");
            base.Items.Add("Indonesia");
            base.Items.Add("Iraq");
            base.Items.Add("Ireland");
            base.Items.Add("Isle Of Man");
            base.Items.Add("Israel");
            base.Items.Add("Italy");
            base.Items.Add("Jamaica");
            base.Items.Add("Japan");
            base.Items.Add("Jersey");
            base.Items.Add("Jordan");
            base.Items.Add("Kazakhstan");
            base.Items.Add("Kenya");
            base.Items.Add("Kiribati");
            base.Items.Add("Korea, South");
            base.Items.Add("Kuwait");
            base.Items.Add("Kyrgyzstan");
            base.Items.Add("Laos");
            base.Items.Add("Latvia");
            base.Items.Add("Lebanon");
            base.Items.Add("Lesotho");
            base.Items.Add("Liberia");
            base.Items.Add("Liechtenstein");
            base.Items.Add("Lithuania");
            base.Items.Add("Luxembourg");
            base.Items.Add("Macau");
            base.Items.Add("Macedonia (Former Yugoslav Republic)");
            base.Items.Add("Madagascar");
            base.Items.Add("Malawi");
            base.Items.Add("Malaysia");
            base.Items.Add("Maldives");
            base.Items.Add("Mali");
            base.Items.Add("Malta");
            base.Items.Add("Marshall Islands");
            base.Items.Add("Martinique");
            base.Items.Add("Mauritania");
            base.Items.Add("Mauritius");
            base.Items.Add("Mayotte");
            base.Items.Add("Melilla");
            base.Items.Add("Mexico");
            base.Items.Add("Micronesia");
            base.Items.Add("Moldova");
            base.Items.Add("Monaco");
            base.Items.Add("Mongolia");
            base.Items.Add("Montserrat");
            base.Items.Add("Morocco");
            base.Items.Add("Mozambique");
            base.Items.Add("Myanmar");
            base.Items.Add("Namibia");
            base.Items.Add("Nauru");
            base.Items.Add("Nepal");
            base.Items.Add("Netherlands");
            base.Items.Add("Netherlands Antilles");
            base.Items.Add("New Caledonia");
            base.Items.Add("New Zealand");
            base.Items.Add("Nicaragua");
            base.Items.Add("Niger");
            base.Items.Add("Nigeria");
            base.Items.Add("Niue");
            base.Items.Add("Norfolk Island");
            base.Items.Add("Northern Mariana Islands");
            base.Items.Add("Norway");
            base.Items.Add("Oman");
            base.Items.Add("Pakistan");
            base.Items.Add("Palau");
            base.Items.Add("Palestinian Territory");
            base.Items.Add("Panama");
            base.Items.Add("Papua New Guinea");
            base.Items.Add("Paraguay");
            base.Items.Add("Peru");
            base.Items.Add("Philippines");
            base.Items.Add("Pitcairn Islands");
            base.Items.Add("Poland");
            base.Items.Add("Portugal");
            base.Items.Add("Puerto Rico");
            base.Items.Add("Qatar");
            base.Items.Add("Reunion");
            base.Items.Add("Romania");
            base.Items.Add("Russia");
            base.Items.Add("Rwanda");
            base.Items.Add("Samoa");
            base.Items.Add("San Marino");
            base.Items.Add("Sao Tome and Principe");
            base.Items.Add("Saudi Arabia");
            base.Items.Add("Senegal");
            base.Items.Add("Serbia and Montenegro");
            base.Items.Add("Seychelles");
            base.Items.Add("Sierra Leone");
            base.Items.Add("Singapore");
            base.Items.Add("Slovakia");
            base.Items.Add("Slovenia");
            base.Items.Add("Solomon Islands");
            base.Items.Add("Somalia");
            base.Items.Add("South Africa");
            base.Items.Add("South Georgia and Sandwich Islands");
            base.Items.Add("Spain");
            base.Items.Add("Sri Lanka");
            base.Items.Add("St. Helena");
            base.Items.Add("St. Kitts and Nevis");
            base.Items.Add("St. Lucia");
            base.Items.Add("St. Pierre and Miquelon");
            base.Items.Add("St. Vincent and the Grenadines");
            base.Items.Add("Suriname");
            base.Items.Add("Svalbard");
            base.Items.Add("Swaziland");
            base.Items.Add("Sweden");
            base.Items.Add("Switzerland");
            base.Items.Add("Taiwan");
            base.Items.Add("Tajikistan");
            base.Items.Add("Tanzania");
            base.Items.Add("Thailand");
            base.Items.Add("Togo");
            base.Items.Add("Tokelau");
            base.Items.Add("Tonga");
            base.Items.Add("Trinidad and Tobago");
            base.Items.Add("Tunisia");
            base.Items.Add("Turkey");
            base.Items.Add("Turkmenistan");
            base.Items.Add("Turks and Caicos Islands");
            base.Items.Add("Tuvalu");
            base.Items.Add("Uganda");
            base.Items.Add("Ukraine");
            base.Items.Add("United Arab Emirates");
            base.Items.Add("United Kingdom");
            base.Items.Add("Uruguay");
            base.Items.Add("United States");
            base.Items.Add("US Minor Outlying Islands");
            base.Items.Add("Uzbekistan");
            base.Items.Add("Vanuatu");
            base.Items.Add("Vatican City State");
            base.Items.Add("Venezuela");
            base.Items.Add("Viet Nam");
            base.Items.Add("Virgin Islands (British)");
            base.Items.Add("Virgin Islands (U.S.)");
            base.Items.Add("Wallis and Futuna");
            base.Items.Add("Western Sahara");
            base.Items.Add("Yemen");
            base.Items.Add("Zambia");
            base.Items.Add("Zimbabwe");

            base.SelectedIndex = 0;

            this.Text = System.Globalization.RegionInfo.CurrentRegion.EnglishName;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ObjectCollection Items
        {
            get
            {
                return base.Items;
            }
        }
    }
}

