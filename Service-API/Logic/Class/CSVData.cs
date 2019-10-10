using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_API.Logic.Class
{
    class CSVData
    {
        // attributes
        int elev_nummer;
        DateTime elev_født;
        string elev_fornavn;
        string elev_efternavn;
        string elev_uddannelse;
        string elev_speciale;
        DateTime dato;
        string linetype;
        string skoleaftale_praktikcenter;
        DateTime skoleaftale_startdato;
        DateTime skoleaftale_slutdato;
        string udd_aftale_lærested;
        int løbenummer;
        string udd_aftale_virksomhed;
        int udd_aftale_cvr;
        DateTime udd_aftale_startdato;
        DateTime udd_aftale_slutdato;
        string udd_aftale_oprindelse;
        string udd_aftale_kategori;
        string udd_aftale_aftaletype;
        int udd_aftale_afttyp_obl;
        int udd_aftale_afttyp1;
        int udd_aftale_afttyp2;
        int udd_aftale_afttyp3;
        int udd_aftale_afttyp4;
        int udd_aftale_afttyp5;
        string praktikforløb;
        DateTime praktikforløb_startdato;
        DateTime praktikforløb_slutdato;
        string praktikaktivitet;
        string praktikaktivitet_type;
        DateTime praktikaktivitet_Fradato;
        DateTime praktikaktivitet_tildato;
        string praktikaktivitet_del_af_forløb;
        string praktikaktivitet_varighed;
        string praktikaktivitet_praktikperiode;
        string skoleforløb;
        DateTime skoleforløb_startdato;
        DateTime skoleforløb_slutdato;
        DateTime skoleforløb_skole;
        bool skoleforløb_skolehjem;
        string læringsaktivitet;
        DateTime læringsaktivitet_startdato;
        DateTime læringsaktivitet_slutdato;
        string læringsaktivitet_skole;
        string skolepraktik_skole;
        DateTime skolepraktik_startdato;
        DateTime skolepraktik_slutdato;

        // properties
        public int Elev_nummer { get => elev_nummer; set => elev_nummer = value; }
        public DateTime Elev_født { get => elev_født; set => elev_født = value; }
        public string Elev_fornavn { get => elev_fornavn; set => elev_fornavn = value; }
        public string Elev_efternavn { get => elev_efternavn; set => elev_efternavn = value; }
        public string Elev_uddannelse { get => elev_uddannelse; set => elev_uddannelse = value; }
        public string Elev_speciale { get => elev_speciale; set => elev_speciale = value; }
        public DateTime Dato { get => dato; set => dato = value; }
        public string Linetype { get => linetype; set => linetype = value; }
        public string Skoleaftale_praktikcenter { get => skoleaftale_praktikcenter; set => skoleaftale_praktikcenter = value; }
        public DateTime Skoleaftale_startdato { get => skoleaftale_startdato; set => skoleaftale_startdato = value; }
        public DateTime Skoleaftale_slutdato { get => skoleaftale_slutdato; set => skoleaftale_slutdato = value; }
        public string Udd_aftale_lærested { get => udd_aftale_lærested; set => udd_aftale_lærested = value; }
        public int Løbenummer { get => løbenummer; set => løbenummer = value; }
        public string Udd_aftale_virksomhed { get => udd_aftale_virksomhed; set => udd_aftale_virksomhed = value; }
        public int Udd_aftale_cvr { get => udd_aftale_cvr; set => udd_aftale_cvr = value; }
        public DateTime Udd_aftale_startdato { get => udd_aftale_startdato; set => udd_aftale_startdato = value; }
        public DateTime Udd_aftale_slutdato { get => udd_aftale_slutdato; set => udd_aftale_slutdato = value; }
        public string Udd_aftale_oprindelse { get => udd_aftale_oprindelse; set => udd_aftale_oprindelse = value; }
        public string Udd_aftale_kategori { get => udd_aftale_kategori; set => udd_aftale_kategori = value; }
        public string Udd_aftale_aftaletype { get => udd_aftale_aftaletype; set => udd_aftale_aftaletype = value; }
        public int Udd_aftale_afttyp_obl { get => udd_aftale_afttyp_obl; set => udd_aftale_afttyp_obl = value; }
        public int Udd_aftale_afttyp1 { get => udd_aftale_afttyp1; set => udd_aftale_afttyp1 = value; }
        public int Udd_aftale_afttyp2 { get => udd_aftale_afttyp2; set => udd_aftale_afttyp2 = value; }
        public int Udd_aftale_afttyp3 { get => udd_aftale_afttyp3; set => udd_aftale_afttyp3 = value; }
        public int Udd_aftale_afttyp4 { get => udd_aftale_afttyp4; set => udd_aftale_afttyp4 = value; }
        public int Udd_aftale_afttyp5 { get => udd_aftale_afttyp5; set => udd_aftale_afttyp5 = value; }
        public string Praktikforløb { get => praktikforløb; set => praktikforløb = value; }
        public DateTime Praktikforløb_startdato { get => praktikforløb_startdato; set => praktikforløb_startdato = value; }
        public DateTime Praktikforløb_slutdato { get => praktikforløb_slutdato; set => praktikforløb_slutdato = value; }
        public string Praktikaktivitet { get => praktikaktivitet; set => praktikaktivitet = value; }
        public string Praktikaktivitet_type { get => praktikaktivitet_type; set => praktikaktivitet_type = value; }
        public DateTime Praktikaktivitet_Fradato { get => praktikaktivitet_Fradato; set => praktikaktivitet_Fradato = value; }
        public DateTime Praktikaktivitet_tildato { get => praktikaktivitet_tildato; set => praktikaktivitet_tildato = value; }
        public string Praktikaktivitet_del_af_forløb { get => praktikaktivitet_del_af_forløb; set => praktikaktivitet_del_af_forløb = value; }
        public string Praktikaktivitet_varighed { get => praktikaktivitet_varighed; set => praktikaktivitet_varighed = value; }
        public string Praktikaktivitet_praktikperiode { get => praktikaktivitet_praktikperiode; set => praktikaktivitet_praktikperiode = value; }
        public string Skoleforløb { get => skoleforløb; set => skoleforløb = value; }
        public DateTime Skoleforløb_startdato { get => skoleforløb_startdato; set => skoleforløb_startdato = value; }
        public DateTime Skoleforløb_slutdato { get => skoleforløb_slutdato; set => skoleforløb_slutdato = value; }
        public DateTime Skoleforløb_skole { get => skoleforløb_skole; set => skoleforløb_skole = value; }
        public bool Skoleforløb_skolehjem { get => skoleforløb_skolehjem; set => skoleforløb_skolehjem = value; }
        public string Læringsaktivitet { get => læringsaktivitet; set => læringsaktivitet = value; }
        public DateTime Læringsaktivitet_startdato { get => læringsaktivitet_startdato; set => læringsaktivitet_startdato = value; }
        public DateTime Læringsaktivitet_slutdato { get => læringsaktivitet_slutdato; set => læringsaktivitet_slutdato = value; }
        public string Læringsaktivitet_skole { get => læringsaktivitet_skole; set => læringsaktivitet_skole = value; }
        public string Skolepraktik_skole { get => skolepraktik_skole; set => skolepraktik_skole = value; }
        public DateTime Skolepraktik_startdato { get => skolepraktik_startdato; set => skolepraktik_startdato = value; }
        public DateTime Skolepraktik_slutdato { get => skolepraktik_slutdato; set => skolepraktik_slutdato = value; }

        // constructor
        public CSVData(int elev_nummer, DateTime elev_født, string elev_fornavn, string elev_efternavn, string elev_uddannelse, string elev_speciale, DateTime dato, string linetype, string skoleaftale_praktikcenter, DateTime skoleaftale_startdato, DateTime skoleaftale_slutdato, string udd_aftale_lærested, int løbenummer, string udd_aftale_virksomhed, int udd_aftale_cvr, DateTime udd_aftale_startdato, DateTime udd_aftale_slutdato, string udd_aftale_oprindelse, string udd_aftale_kategori, string udd_aftale_aftaletype, int udd_aftale_afttyp_obl, int udd_aftale_afttyp1, int udd_aftale_afttyp2, int udd_aftale_afttyp3, int udd_aftale_afttyp4, int udd_aftale_afttyp5, string praktikforløb, DateTime praktikforløb_startdato, DateTime praktikforløb_slutdato, string praktikaktivitet, string praktikaktivitet_type, DateTime praktikaktivitet_Fradato, DateTime praktikaktivitet_tildato, string praktikaktivitet_del_af_forløb, string praktikaktivitet_varighed, string praktikaktivitet_praktikperiode, string skoleforløb, DateTime skoleforløb_startdato, DateTime skoleforløb_slutdato, DateTime skoleforløb_skole, bool skoleforløb_skolehjem, string læringsaktivitet, DateTime læringsaktivitet_startdato, DateTime læringsaktivitet_slutdato, string læringsaktivitet_skole, string skolepraktik_skole, DateTime skolepraktik_startdato, DateTime skolepraktik_slutdato)
        {
            Elev_nummer = elev_nummer;
            Elev_født = elev_født;
            Elev_fornavn = elev_fornavn;
            Elev_efternavn = elev_efternavn;
            Elev_uddannelse = elev_uddannelse;
            Elev_speciale = elev_speciale;
            Dato = dato;
            Linetype = linetype;
            Skoleaftale_praktikcenter = skoleaftale_praktikcenter;
            Skoleaftale_startdato = skoleaftale_startdato;
            Skoleaftale_slutdato = skoleaftale_slutdato;
            Udd_aftale_lærested = udd_aftale_lærested;
            Løbenummer = løbenummer;
            Udd_aftale_virksomhed = udd_aftale_virksomhed;
            Udd_aftale_cvr = udd_aftale_cvr;
            Udd_aftale_startdato = udd_aftale_startdato;
            Udd_aftale_slutdato = udd_aftale_slutdato;
            Udd_aftale_oprindelse = udd_aftale_oprindelse;
            Udd_aftale_kategori = udd_aftale_kategori;
            Udd_aftale_aftaletype = udd_aftale_aftaletype;
            Udd_aftale_afttyp_obl = udd_aftale_afttyp_obl;
            Udd_aftale_afttyp1 = udd_aftale_afttyp1;
            Udd_aftale_afttyp2 = udd_aftale_afttyp2;
            Udd_aftale_afttyp3 = udd_aftale_afttyp3;
            Udd_aftale_afttyp4 = udd_aftale_afttyp4;
            Udd_aftale_afttyp5 = udd_aftale_afttyp5;
            Praktikforløb = praktikforløb;
            Praktikforløb_startdato = praktikforløb_startdato;
            Praktikforløb_slutdato = praktikforløb_slutdato;
            Praktikaktivitet = praktikaktivitet;
            Praktikaktivitet_type = praktikaktivitet_type;
            Praktikaktivitet_Fradato = praktikaktivitet_Fradato;
            Praktikaktivitet_tildato = praktikaktivitet_tildato;
            Praktikaktivitet_del_af_forløb = praktikaktivitet_del_af_forløb;
            Praktikaktivitet_varighed = praktikaktivitet_varighed;
            Praktikaktivitet_praktikperiode = praktikaktivitet_praktikperiode;
            Skoleforløb = skoleforløb;
            Skoleforløb_startdato = skoleforløb_startdato;
            Skoleforløb_slutdato = skoleforløb_slutdato;
            Skoleforløb_skole = skoleforløb_skole;
            Skoleforløb_skolehjem = skoleforløb_skolehjem;
            Læringsaktivitet = læringsaktivitet;
            Læringsaktivitet_startdato = læringsaktivitet_startdato;
            Læringsaktivitet_slutdato = læringsaktivitet_slutdato;
            Læringsaktivitet_skole = læringsaktivitet_skole;
            Skolepraktik_skole = skolepraktik_skole;
            Skolepraktik_startdato = skolepraktik_startdato;
            Skolepraktik_slutdato = skolepraktik_slutdato;
        }
    }
}
