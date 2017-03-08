﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Kentor.PU_Adapter.Enums
{
    public enum Kommunkoder
    {
        [Display(Description = "LÄN SAKNAS ELLER ÄR FELAKTIGT")]
        SAKNAS_ELLER_FELAKTIGT = -1,

        // 01 Stockholms län
        [Display(Description = "Upplands Väsby")]
        Upplands_Väsby = 0114,
        [Display(Description = "Vallentuna")]
        Vallentuna = 0115,
        [Display(Description = "Österåker")]
        Österåker = 0117,
        [Display(Description = "Värmdö")]
        Värmdö = 0120,
        [Display(Description = "Järfälla")]
        Järfälla = 0123,
        [Display(Description = "Ekerö")]
        Ekerö = 0125,
        [Display(Description = "Huddinge")]
        Huddinge = 0126,
        [Display(Description = "Botkyrka")]
        Botkyrka = 0127,
        [Display(Description = "Salem")]
        Salem = 0128,
        [Display(Description = "Haninge")]
        Haninge = 0136,
        [Display(Description = "Tyresö")]
        Tyresö = 0138,
        [Display(Description = "Upplands-Bro")]
        Upplands_Bro = 0139,
        [Display(Description = "Nykvarn")]
        Nykvarn = 0140,
        [Display(Description = "Täby")]
        Täby = 0160,
        [Display(Description = "Danderyd")]
        Danderyd = 0162,
        [Display(Description = "Sollentuna")]
        Sollentuna = 0163,
        [Display(Description = "Stockholm")]
        Stockholm = 0180,
        [Display(Description = "Södertälje")]
        Södertälje = 0181,
        [Display(Description = "Nacka")]
        Nacka = 0182,
        [Display(Description = "Sundbyberg")]
        Sundbyberg = 0183,
        [Display(Description = "Solna")]
        Solna = 0184,
        [Display(Description = "Lidingö")]
        Lidingö = 0186,
        [Display(Description = "Vaxholm")]
        Vaxholm = 0187,
        [Display(Description = "Norrtälje")]
        Norrtälje = 0188,
        [Display(Description = "Sigtuna")]
        Sigtuna = 0191,
        [Display(Description = "Nynäshamn")]
        Nynäshamn = 0192,
        // 03 Uppsala län
        [Display(Description = "Håbo")]
        Håbo = 0305,
        [Display(Description = "Älvkarleby")]
        Älvkarleby = 0319,
        [Display(Description = "Knivsta")]
        Knivsta = 0330,
        [Display(Description = "Heby")]
        Heby = 0331,
        [Display(Description = "Tierp")]
        Tierp = 0360,
        [Display(Description = "Uppsala")]
        Uppsala = 0380,
        [Display(Description = "Enköping")]
        Enköping = 0381,
        [Display(Description = "Östhammar")]
        Östhammar = 0382,
        // 04 Södermanlands län
        [Display(Description = "Vingåker")]
        Vingåker = 0428,
        [Display(Description = "Gnesta")]
        Gnesta = 0461,
        [Display(Description = "Nyköping")]
        Nyköping = 0480,
        [Display(Description = "Oxelösund")]
        Oxelösund = 0481,
        [Display(Description = "Flen")]
        Flen = 0482,
        [Display(Description = "Katrineholm")]
        Katrineholm = 0483,
        [Display(Description = "Eskilstuna")]
        Eskilstuna = 0484,
        [Display(Description = "Strängnäs")]
        Strängnäs = 0486,
        [Display(Description = "Trosa")]
        Trosa = 0488,
        // 05 Östergötlands län
        [Display(Description = "Ödeshög")]
        Ödeshög = 0509,
        [Display(Description = "Ydre")]
        Ydre = 0512,
        [Display(Description = "Kinda")]
        Kinda = 0513,
        [Display(Description = "Boxholm")]
        Boxholm = 0560,
        [Display(Description = "Åtvidaberg")]
        Åtvidaberg = 0561,
        [Display(Description = "Finspång")]
        Finspång = 0562,
        [Display(Description = "Valdemarsvik")]
        Valdemarsvik = 0563,
        [Display(Description = "Linköping")]
        Linköping = 0580,
        [Display(Description = "Norrköping")]
        Norrköping = 0581,
        [Display(Description = "Söderköping")]
        Söderköping = 0582,
        [Display(Description = "Motala")]
        Motala = 0583,
        [Display(Description = "Vadstena")]
        Vadstena = 0584,
        [Display(Description = "Mjölby")]
        Mjölby = 0586,
        // 06 Jönköpings län
        [Display(Description = "Aneby")]
        Aneby = 0604,
        [Display(Description = "Gnosjö")]
        Gnosjö = 0617,
        [Display(Description = "Mullsjö")]
        Mullsjö = 0642,
        [Display(Description = "Habo")]
        Habo = 0643,
        [Display(Description = "Gislaved")]
        Gislaved = 0662,
        [Display(Description = "Vaggeryd")]
        Vaggeryd = 0665,
        [Display(Description = "Jönköping")]
        Jönköping = 0680,
        [Display(Description = "Nässjö")]
        Nässjö = 0682,
        [Display(Description = "Värnamo")]
        Värnamo = 0683,
        [Display(Description = "Sävsjö")]
        Sävsjö = 0684,
        [Display(Description = "Vetlanda")]
        Vetlanda = 0685,
        [Display(Description = "Eksjö")]
        Eksjö = 0686,
        [Display(Description = "Tranås")]
        Tranås = 0687,
        // 07 Kronobergs län
        [Display(Description = "Uppvidinge")]
        Uppvidinge = 0760,
        [Display(Description = "Lessebo")]
        Lessebo = 0761,
        [Display(Description = "Tingsryd")]
        Tingsryd = 0763,
        [Display(Description = "Alvesta")]
        Alvesta = 0764,
        [Display(Description = "Älmhult")]
        Älmhult = 0765,
        [Display(Description = "Markaryd")]
        Markaryd = 0767,
        [Display(Description = "Växjö")]
        Växjö = 0780,
        [Display(Description = "Ljungby")]
        Ljungby = 0781,
        // 08 Kalmar län
        [Display(Description = "Högsby")]
        Högsby = 0821,
        [Display(Description = "Torsås")]
        Torsås = 0834,
        [Display(Description = "Mörbylånga")]
        Mörbylånga = 0840,
        [Display(Description = "Hultsfred")]
        Hultsfred = 0860,
        [Display(Description = "Mönsterås")]
        Mönsterås = 0861,
        [Display(Description = "Emmaboda")]
        Emmaboda = 0862,
        [Display(Description = "Kalmar")]
        Kalmar = 0880,
        [Display(Description = "Nybro")]
        Nybro = 0881,
        [Display(Description = "Oskarshamn")]
        Oskarshamn = 0882,
        [Display(Description = "Västervik")]
        Västervik = 0883,
        [Display(Description = "Vimmerby")]
        Vimmerby = 0884,
        [Display(Description = "Borgholm")]
        Borgholm = 0885,
        // 09 Gotlands län
        [Display(Description = "Gotland")]
        Gotland = 0980,
        // 10 Blekinge län
        [Display(Description = "Olofström")]
        Olofström = 1060,
        [Display(Description = "Karlskrona")]
        Karlskrona = 1080,
        [Display(Description = "Ronneby")]
        Ronneby = 1081,
        [Display(Description = "Karlshamn")]
        Karlshamn = 1082,
        [Display(Description = "Sölvesborg")]
        Sölvesborg = 1083,
        // 12 Skåne län
        [Display(Description = "Svalöv")]
        Svalöv = 1214,
        [Display(Description = "Staffanstorp")]
        Staffanstorp = 1230,
        [Display(Description = "Burlöv")]
        Burlöv = 1231,
        [Display(Description = "Vellinge")]
        Vellinge = 1233,
        [Display(Description = "Östra Göinge")]
        Östra_Göinge = 1256,
        [Display(Description = "Örkelljunga")]
        Örkelljunga = 1257,
        [Display(Description = "Bjuv")]
        Bjuv = 1260,
        [Display(Description = "Kävlinge")]
        Kävlinge = 1261,
        [Display(Description = "Lomma")]
        Lomma = 1262,
        [Display(Description = "Svedala")]
        Svedala = 1263,
        [Display(Description = "Skurup")]
        Skurup = 1264,
        [Display(Description = "Sjöbo")]
        Sjöbo = 1265,
        [Display(Description = "Hörby")]
        Hörby = 1266,
        [Display(Description = "Höör")]
        Höör = 1267,
        [Display(Description = "Tomelilla")]
        Tomelilla = 1270,
        [Display(Description = "Bromölla")]
        Bromölla = 1272,
        [Display(Description = "Osby")]
        Osby = 1273,
        [Display(Description = "Perstorp")]
        Perstorp = 1275,
        [Display(Description = "Klippan")]
        Klippan = 1276,
        [Display(Description = "Åstorp")]
        Åstorp = 1277,
        [Display(Description = "Båstad")]
        Båstad = 1278,
        [Display(Description = "Malmö")]
        Malmö = 1280,
        [Display(Description = "Lund")]
        Lund = 1281,
        [Display(Description = "Landskrona")]
        Landskrona = 1282,
        [Display(Description = "Helsingborg")]
        Helsingborg = 1283,
        [Display(Description = "Höganäs")]
        Höganäs = 1284,
        [Display(Description = "Eslöv")]
        Eslöv = 1285,
        [Display(Description = "Ystad")]
        Ystad = 1286,
        [Display(Description = "Trelleborg")]
        Trelleborg = 1287,
        [Display(Description = "Kristianstad")]
        Kristianstad = 1290,
        [Display(Description = "Simrishamn")]
        Simrishamn = 1291,
        [Display(Description = "Ängelholm")]
        Ängelholm = 1292,
        [Display(Description = "Hässleholm")]
        Hässleholm = 1293,
        // 13 Hallands län
        [Display(Description = "Hylte")]
        Hylte = 1315,
        [Display(Description = "Halmstad")]
        Halmstad = 1380,
        [Display(Description = "Laholm")]
        Laholm = 1381,
        [Display(Description = "Falkenberg")]
        Falkenberg = 1382,
        [Display(Description = "Varberg")]
        Varberg = 1383,
        [Display(Description = "Kungsbacka")]
        Kungsbacka = 1384,
        // 14 Västra Götalands län
        [Display(Description = "Härryda")]
        Härryda = 1401,
        [Display(Description = "Partille")]
        Partille = 1402,
        [Display(Description = "Öckerö")]
        Öckerö = 1407,
        [Display(Description = "Stenungsund")]
        Stenungsund = 1415,
        [Display(Description = "Tjörn")]
        Tjörn = 1419,
        [Display(Description = "Orust")]
        Orust = 1421,
        [Display(Description = "Sotenäs")]
        Sotenäs = 1427,
        [Display(Description = "Munkedal")]
        Munkedal = 1430,
        [Display(Description = "Tanum")]
        Tanum = 1435,
        [Display(Description = "Dals-Ed")]
        Dals_Ed = 1438,
        [Display(Description = "Färgelanda")]
        Färgelanda = 1439,
        [Display(Description = "Ale")]
        Ale = 1440,
        [Display(Description = "Lerum")]
        Lerum = 1441,
        [Display(Description = "Vårgårda")]
        Vårgårda = 1442,
        [Display(Description = "Bollebygd")]
        Bollebygd = 1443,
        [Display(Description = "Grästorp")]
        Grästorp = 1444,
        [Display(Description = "Essunga")]
        Essunga = 1445,
        [Display(Description = "Karlsborg")]
        Karlsborg = 1446,
        [Display(Description = "Gullspång")]
        Gullspång = 1447,
        [Display(Description = "Tranemo")]
        Tranemo = 1452,
        [Display(Description = "Bengtsfors")]
        Bengtsfors = 1460,
        [Display(Description = "Mellerud")]
        Mellerud = 1461,
        [Display(Description = "Lilla Edet")]
        Lilla_Edet = 1462,
        [Display(Description = "Mark")]
        Mark = 1463,
        [Display(Description = "Svenljunga")]
        Svenljunga = 1465,
        [Display(Description = "Herrljunga")]
        Herrljunga = 1466,
        [Display(Description = "Vara")]
        Vara = 1470,
        [Display(Description = "Götene")]
        Götene = 1471,
        [Display(Description = "Tibro")]
        Tibro = 1472,
        [Display(Description = "Töreboda")]
        Töreboda = 1473,
        [Display(Description = "Göteborg")]
        Göteborg = 1480,
        [Display(Description = "Mölndal")]
        Mölndal = 1481,
        [Display(Description = "Kungälv")]
        Kungälv = 1482,
        [Display(Description = "Lysekil")]
        Lysekil = 1484,
        [Display(Description = "Uddevalla")]
        Uddevalla = 1485,
        [Display(Description = "Strömstad")]
        Strömstad = 1486,
        [Display(Description = "Vänersborg")]
        Vänersborg = 1487,
        [Display(Description = "Trollhättan")]
        Trollhättan = 1488,
        [Display(Description = "Alingsås")]
        Alingsås = 1489,
        [Display(Description = "Borås")]
        Borås = 1490,
        [Display(Description = "Ulricehamn")]
        Ulricehamn = 1491,
        [Display(Description = "Åmål")]
        Åmål = 1492,
        [Display(Description = "Mariestad")]
        Mariestad = 1493,
        [Display(Description = "Lidköping")]
        Lidköping = 1494,
        [Display(Description = "Skara")]
        Skara = 1495,
        [Display(Description = "Skövde")]
        Skövde = 1496,
        [Display(Description = "Hjo")]
        Hjo = 1497,
        [Display(Description = "Tidaholm")]
        Tidaholm = 1498,
        [Display(Description = "Falköping")]
        Falköping = 1499,
        // 17 Värmlands län
        [Display(Description = "Kil")]
        Kil = 1715,
        [Display(Description = "Eda")]
        Eda = 1730,
        [Display(Description = "Torsby")]
        Torsby = 1737,
        [Display(Description = "Storfors")]
        Storfors = 1760,
        [Display(Description = "Hammarö")]
        Hammarö = 1761,
        [Display(Description = "Munkfors")]
        Munkfors = 1762,
        [Display(Description = "Forshaga")]
        Forshaga = 1763,
        [Display(Description = "Grums")]
        Grums = 1764,
        [Display(Description = "Årjäng")]
        Årjäng = 1765,
        [Display(Description = "Sunne")]
        Sunne = 1766,
        [Display(Description = "Karlstad")]
        Karlstad = 1780,
        [Display(Description = "Kristinehamn")]
        Kristinehamn = 1781,
        [Display(Description = "Filipstad")]
        Filipstad = 1782,
        [Display(Description = "Hagfors")]
        Hagfors = 1783,
        [Display(Description = "Arvika")]
        Arvika = 1784,
        [Display(Description = "Säffle")]
        Säffle = 1785,
        // 18 Örebro län
        [Display(Description = "Lekeberg")]
        Lekeberg = 1814,
        [Display(Description = "Laxå")]
        Laxå = 1860,
        [Display(Description = "Hallsberg")]
        Hallsberg = 1861,
        [Display(Description = "Degerfors")]
        Degerfors = 1862,
        [Display(Description = "Hällefors")]
        Hällefors = 1863,
        [Display(Description = "Ljusnarsberg")]
        Ljusnarsberg = 1864,
        [Display(Description = "Örebro")]
        Örebro = 1880,
        [Display(Description = "Kumla")]
        Kumla = 1881,
        [Display(Description = "Askersund")]
        Askersund = 1882,
        [Display(Description = "Karlskoga")]
        Karlskoga = 1883,
        [Display(Description = "Nora")]
        Nora = 1884,
        [Display(Description = "Lindesberg")]
        Lindesberg = 1885,
        // 19 Västmanlands län
        [Display(Description = "Skinnskatteberg")]
        Skinnskatteberg = 1904,
        [Display(Description = "Surahammar")]
        Surahammar = 1907,
        [Display(Description = "Kungsör")]
        Kungsör = 1960,
        [Display(Description = "Hallstahammar")]
        Hallstahammar = 1961,
        [Display(Description = "Norberg")]
        Norberg = 1962,
        [Display(Description = "Västerås")]
        Västerås = 1980,
        [Display(Description = "Sala")]
        Sala = 1981,
        [Display(Description = "Fagersta")]
        Fagersta = 1982,
        [Display(Description = "Köping")]
        Köping = 1983,
        [Display(Description = "Arboga")]
        Arboga = 1984,
        // 20 Dalarnas län
        [Display(Description = "Vansbro")]
        Vansbro = 2021,
        [Display(Description = "Malung-Sälen")]
        Malung_Sälen = 2023,
        [Display(Description = "Gagnef")]
        Gagnef = 2026,
        [Display(Description = "Leksand")]
        Leksand = 2029,
        [Display(Description = "Rättvik")]
        Rättvik = 2031,
        [Display(Description = "Orsa")]
        Orsa = 2034,
        [Display(Description = "Älvdalen")]
        Älvdalen = 2039,
        [Display(Description = "Smedjebacken")]
        Smedjebacken = 2061,
        [Display(Description = "Mora")]
        Mora = 2062,
        [Display(Description = "Falun")]
        Falun = 2080,
        [Display(Description = "Borlänge")]
        Borlänge = 2081,
        [Display(Description = "Säter")]
        Säter = 2082,
        [Display(Description = "Hedemora")]
        Hedemora = 2083,
        [Display(Description = "Avesta")]
        Avesta = 2084,
        [Display(Description = "Ludvika")]
        Ludvika = 2085,
        // 21 Gävleborgs län
        [Display(Description = "Ockelbo")]
        Ockelbo = 2101,
        [Display(Description = "Hofors")]
        Hofors = 2104,
        [Display(Description = "Ovanåker")]
        Ovanåker = 2121,
        [Display(Description = "Nordanstig")]
        Nordanstig = 2132,
        [Display(Description = "Ljusdal")]
        Ljusdal = 2161,
        [Display(Description = "Gävle")]
        Gävle = 2180,
        [Display(Description = "Sandviken")]
        Sandviken = 2181,
        [Display(Description = "Söderhamn")]
        Söderhamn = 2182,
        [Display(Description = "Bollnäs")]
        Bollnäs = 2183,
        [Display(Description = "Hudiksvall")]
        Hudiksvall = 2184,
        // 22 Västernorrlands län
        [Display(Description = "Ånge")]
        Ånge = 2260,
        [Display(Description = "Timrå")]
        Timrå = 2262,
        [Display(Description = "Härnösand")]
        Härnösand = 2280,
        [Display(Description = "Sundsvall")]
        Sundsvall = 2281,
        [Display(Description = "Kramfors")]
        Kramfors = 2282,
        [Display(Description = "Sollefteå")]
        Sollefteå = 2283,
        [Display(Description = "Örnsköldsvik")]
        Örnsköldsvik = 2284,
        // 23 Jämtlands län
        [Display(Description = "Ragunda")]
        Ragunda = 2303,
        [Display(Description = "Bräcke")]
        Bräcke = 2305,
        [Display(Description = "Krokom")]
        Krokom = 2309,
        [Display(Description = "Strömsund")]
        Strömsund = 2313,
        [Display(Description = "Åre")]
        Åre = 2321,
        [Display(Description = "Berg")]
        Berg = 2326,
        [Display(Description = "Härjedalen")]
        Härjedalen = 2361,
        [Display(Description = "Östersund")]
        Östersund = 2380,
        // 24 Västerbottens län
        [Display(Description = "Nordmaling")]
        Nordmaling = 2401,
        [Display(Description = "Bjurholm")]
        Bjurholm = 2403,
        [Display(Description = "Vindeln")]
        Vindeln = 2404,
        [Display(Description = "Robertsfors")]
        Robertsfors = 2409,
        [Display(Description = "Norsjö")]
        Norsjö = 2417,
        [Display(Description = "Malå")]
        Malå = 2418,
        [Display(Description = "Storuman")]
        Storuman = 2421,
        [Display(Description = "Sorsele")]
        Sorsele = 2422,
        [Display(Description = "Dorotea")]
        Dorotea = 2425,
        [Display(Description = "Vännäs")]
        Vännäs = 2460,
        [Display(Description = "Vilhelmina")]
        Vilhelmina = 2462,
        [Display(Description = "Åsele")]
        Åsele = 2463,
        [Display(Description = "Umeå")]
        Umeå = 2480,
        [Display(Description = "Lycksele")]
        Lycksele = 2481,
        [Display(Description = "Skellefteå")]
        Skellefteå = 2482,
        // 25 Norrbottens län
        [Display(Description = "Arvidsjaur")]
        Arvidsjaur = 2505,
        [Display(Description = "Arjeplog")]
        Arjeplog = 2506,
        [Display(Description = "Jokkmokk")]
        Jokkmokk = 2510,
        [Display(Description = "Överkalix")]
        Överkalix = 2513,
        [Display(Description = "Kalix")]
        Kalix = 2514,
        [Display(Description = "Övertorneå")]
        Övertorneå = 2518,
        [Display(Description = "Pajala")]
        Pajala = 2521,
        [Display(Description = "Gällivare")]
        Gällivare = 2523,
        [Display(Description = "Älvsbyn")]
        Älvsbyn = 2560,
        [Display(Description = "Luleå")]
        Luleå = 2580,
        [Display(Description = "Piteå")]
        Piteå = 2581,
        [Display(Description = "Boden")]
        Boden = 2582,
        [Display(Description = "Haparanda")]
        Haparanda = 2583,
        [Display(Description = "Kiruna")]
        Kiruna = 2584,
    }
}
