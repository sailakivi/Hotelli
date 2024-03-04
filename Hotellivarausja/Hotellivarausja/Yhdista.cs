﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotellivarausja
{
    /*
     * Tämän luokan avulla muodostetaan yhteys MySql-tietokantaan.
     * Mikäli et ole ladannut MySql Connectoria ja Xamppia, tee se nyt.
     * Muista myös lisätä MySql.Data.MySqlClient -kirjasto alkuun
     */
    class Yhdista
    {
        public string yhteyslause()
        {
            return "datasource=localhost; port=3306;username=root;password=;database=hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hotelli");
        // Luodaan funktio yhteyttä varten
        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }
        // Luodaan funktio yhteyden avaamista varten - HUOM! System.Data -kirjasto
        public void avaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        // Luodaan funktio yhteyden sulkemista varten
        public void suljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
