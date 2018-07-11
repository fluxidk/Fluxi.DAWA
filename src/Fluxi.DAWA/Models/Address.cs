using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fluxi.DAWA.Models
{
    public class Address
    {
        public string id { get; set; }
        public string kvhx { get; set; }
        public int status { get; set; }
        public string href { get; set; }
        public History historik { get; set; }
        public string etage { get; set; }
        public string dør { get; set; }
        public string adressebetegnelse { get; set; }
        public Accessaddress adgangsadresse { get; set; }
    }

    public class History
    {
        public DateTime oprettet { get; set; }
        public DateTime ændret { get; set; }
    }

    public class Accessaddress
    {
        public string href { get; set; }
        public string id { get; set; }
        public string kvh { get; set; }
        public int status { get; set; }
        public Roadsegment vejstykke { get; set; }
        public string husnr { get; set; }
        public Navngivenvej navngivenvej { get; set; }
        public string supplerendebynavn { get; set; }
        public string supplerendebynavn2 { get; set; }
        public Postnummer postnummer { get; set; }
        public string stormodtagerpostnummer { get; set; }
        public Municipality kommune { get; set; }
        public OwnerAssociations ejerlav { get; set; }
        public string esrejendomsnr { get; set; }
        public string matrikelnr { get; set; }
        public Historik1 historik { get; set; }
        public Accesspoint adgangspunkt { get; set; }
        public Roadpoint vejpunkt { get; set; }
        public DDKN DDKN { get; set; }
        public Sogn sogn { get; set; }
        public Region region { get; set; }
        public Retskreds retskreds { get; set; }
        public Policearea politikreds { get; set; }
        public Opstillingskreds opstillingskreds { get; set; }
        public Afstemningsområde afstemningsområde { get; set; }
        public string zone { get; set; }
        public Jordstykke jordstykke { get; set; }
        public Bebyggelser[] bebyggelser { get; set; }
        public bool brofast { get; set; }
    }

    public class Roadsegment
    {
        public string href { get; set; }
        public string navn { get; set; }
        public string adresseringsnavn { get; set; }
        public string kode { get; set; }
    }

    public class Navngivenvej
    {
        public string href { get; set; }
        public string id { get; set; }
    }

    public class Postnummer
    {
        public string href { get; set; }
        public string nr { get; set; }
        public string navn { get; set; }
    }

    public class Municipality
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class OwnerAssociations
    {
        public int kode { get; set; }
        public string navn { get; set; }
    }

    public class Historik1
    {
        public DateTime oprettet { get; set; }
        public DateTime ændret { get; set; }
    }

    public class Accesspoint
    {
        public string id { get; set; }
        public float[] koordinater { get; set; }
        public float højde { get; set; }
        public string nøjagtighed { get; set; }
        public int kilde { get; set; }
        public string tekniskstandard { get; set; }
        public float tekstretning { get; set; }
        public DateTime ændret { get; set; }
    }

    public class Roadpoint
    {
        public string id { get; set; }
        public string kilde { get; set; }
        public string nøjagtighed { get; set; }
        public string tekniskstandard { get; set; }
        public float[] koordinater { get; set; }
    }

    public class DDKN
    {
        public string m100 { get; set; }
        public string km1 { get; set; }
        public string km10 { get; set; }
    }

    public class Sogn
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class Region
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class Retskreds
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class Policearea
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class Opstillingskreds
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }

    public class Afstemningsområde
    {
        public string href { get; set; }
        public string nummer { get; set; }
        public string navn { get; set; }
    }

    public class Jordstykke
    {
        public string href { get; set; }
        public Ejerlav1 ejerlav { get; set; }
        public string matrikelnr { get; set; }
        public string esrejendomsnr { get; set; }
    }

    public class Ejerlav1
    {
        public int kode { get; set; }
        public string navn { get; set; }
        public string href { get; set; }
    }

    public class Bebyggelser
    {
        public string id { get; set; }
        public int? kode { get; set; }
        public string type { get; set; }
        public string navn { get; set; }
        public string href { get; set; }
    }

}
